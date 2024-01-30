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
        public TeamService(AppDbContext context)
        {
            _context = context;
        }
        public async Task<bool> TeamCreateAsync(TeamCreate model)
        {
        try{
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
        catch (Exception ex)
    {
        DisplayError(ex.Message);
        return false;
    }
        }
        

        
        public async Task<bool> TeamMemberDelete(int id)
        {        
        try
        {
            var character = await _context.Characters.FindAsync(id);
            

            if (character != null)
            {
                character.TeamId = null;
                await _context.SaveChangesAsync();                
                return true;
            }
            else
                return false;

        }
        catch (Exception ex)
        {
            DisplayError(ex.Message);
            return false;
        }
        }



        public async Task<bool> TeamDelete(int id)
        {
        try
            {
            var team = await _context.Teams.FindAsync(id);

            if (team != null)
            {
                _context.Teams.Remove(team);
                
                return true;
            }
            return false;
        }
        catch (Exception ex)
    {
        DisplayError(ex.Message);
        return false;
    }
        }
        public async Task<TeamList> GetTeamMembers(int id)
        {
        try
        {
            TeamEntity team = await _context.Teams.FindAsync(id);
            if (team == null)
            {
                return null; 
            }

            var teamList = new TeamList
            {
                TeamName = team.TeamName,
                TeamNumber = team.TeamNumber,
                TeamSlogan = team.TeamSlogan,
                TeamDescription = team.TeamDescription,
                TeamMission = team.TeamMission,
                MemberIds = team.Members.Select(member => member.CharacterId).ToList()
            };

            return teamList;
        }
        catch (Exception ex)
    {
        DisplayError(ex.Message);
        return null;
    }
        }

        private void DisplayError(string message)
        {
            throw new NotImplementedException();
        }
    }
}