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

        Task<TeamList> TeamListAsync(int teamId);
    }
}