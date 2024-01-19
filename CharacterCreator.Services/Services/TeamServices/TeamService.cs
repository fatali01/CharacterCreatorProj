using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CharacterCreator.Models.Models.TeamModels;

namespace CharacterCreator.Services.Services.TeamServices
{
    public class TeamService : ITeamService
    {
        public Task<bool> TeamCreateAsync(TeamCreate model)
        {
            throw new NotImplementedException();
        }

        public Task<TeamList> TeamListAsync(int teamId)
        {
            throw new NotImplementedException();
        }
    }
}