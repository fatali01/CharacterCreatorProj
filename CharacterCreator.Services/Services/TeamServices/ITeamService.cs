using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CharacterCreator.Models.Models.TeamModels;

namespace CharacterCreator.Services.Services.TeamServices
{
    public interface ITeamService
    {
        Task<bool> TeamCreateAsync(TeamCreate model);

        Task<bool> TeamMemberDelete(int id);

        Task<bool> TeamDelete(int id);

        Task<TeamList> GetTeamMembers(int id);

        Task<bool> TeamMemberAdd(int id, int teamid);
    }
}