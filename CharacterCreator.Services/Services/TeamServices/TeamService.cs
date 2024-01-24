using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Threading.Tasks;
using CharacterCreator.Data;
using CharacterCreator.Data.Entities;
using CharacterCreator.Models.Models.TeamModels;
using Microsoft.EntityFrameworkCore;

namespace CharacterCreator.Services.Services.TeamServices
{
    public class TeamService : ITeamService
    {
        private readonly AppDbContext _context;

        public async Task<bool> TeamCreateAsync(TeamCreate model)
        {
            if (model == null) return false;

            var team = new TeamEntity
            {
                TeamName = model.TeamName,
                TeamNumber = model.TeamNumber,
                TeamSlogan = model.TeamSlogan,
                TeamDescription = model.TeamDescription,
                TeamMission = model.TeamMission,
                // Members = model.C
            };
            await _context.Teams.AddAsync(team);
            await _context.SaveChangesAsync();
            foreach (var id in model.MemberIds)
            {
                // team.Members.Add(member);
                var character = await _context.Characters.FindAsync(id);
                if (character != null)
                {
                    if(character.TeamId == null)
                    {
                    character.TeamId = team.TeamId;
                    }
                }

            }
            await _context.AddAsync(team);
            await _context.SaveChangesAsync();
            return true;
        }

        
        public async Task<bool> TeamMemberDelete(int id)
        {        

            var character = await _context.Characters.FindAsync(id);
            

            if (character != null)
            {

                character.TeamId = null;

                await _context.SaveChangesAsync();
                return true;
            }
            else
            {

                return false;
            }
        }



        public async Task<bool> TeamDelete(int id)
        {
            var team = await _context.Teams.FindAsync(id);

            if (team != null)
            {
                _context.Teams.Remove(team);
                
                return true;
            }
            return false;

        }
        public async Task<TeamList> TeamListMemberIds(TeamList model)
        {
            var teamList = new TeamList()
            {
                TeamName = model.TeamName,
                TeamNumber = model.TeamNumber,
                TeamSlogan = model.TeamSlogan,
                TeamDescription = model.TeamDescription,
                TeamMission = model.TeamMission,
            };

            foreach (var memberId in model.MemberIds)
            {
                teamList.MemberIds.Add(memberId);
            }

            return teamList;
        }
    }
}