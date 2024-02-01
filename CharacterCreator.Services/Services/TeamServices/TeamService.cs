using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Threading.Tasks;
using CharacterCreator.Data;
using CharacterCreator.Data.Entities;
using CharacterCreator.Models.Models.CharacterModels;
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
            };
            await _context.Teams.AddAsync(team);
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
                await _context.SaveChangesAsync();
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
        public async Task<TeamList> GetTeamMembers(int teamid) 
        {
        try
        {    
            var members = await _context.Characters.Where(x => x.TeamId == teamid).ToListAsync();
            var team = await _context.Teams.FindAsync(teamid);
            if (members == null)
            {
                return null;
            }
            TeamList teamlist = new TeamList    
            {
                TeamName = team.TeamName,
                TeamNumber = team.TeamNumber,
                TeamSlogan = team.TeamSlogan,
                TeamDescription = team.TeamDescription,
                TeamMission = team.TeamMission,
                TeamMembers = members.Select(member => new CharacterListItem{
                    Id = member.CharacterId,
                    WarriorType = member.WarriorType,
                    CharacterName = member.CharacterName 
                    }).ToList(),
                MemberIds = members.Select(member => member.CharacterId).ToList()
                };
            return teamlist;
            
        }
        
        catch (Exception ex)
        {
        DisplayError(ex.Message);
        return null;
        }
        }
        public async Task<bool> TeamMemberAdd(int id, int teamid)
        {        
        try
        {
            var character = await _context.Characters.FindAsync(id);

            if (character != null)
            {
                character.TeamId = teamid;
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

    private void DisplayError(string message)
    {
        Console.WriteLine($"Error: {message}");
        // Alternatively, use a logging framework to log the error
    }
    }
}