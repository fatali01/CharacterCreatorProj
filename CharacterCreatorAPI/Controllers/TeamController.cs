using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CharacterCreator.Models.Models.TeamModels;
using CharacterCreator.Models.Responses;
using CharacterCreator.Services.Services.TeamServices;
using Microsoft.AspNetCore.Mvc;

namespace CharacterCreatorAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class TeamController : ControllerBase
    {
        private readonly ITeamService _teamService;
        public TeamController(ITeamService teamService)
        {
            _teamService = teamService;
        }
        [HttpPost]
        public async Task<IActionResult> TeamCreateAsync([FromBody] TeamCreate model)
        {
            if(!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var teamcreate = await _teamService.TeamCreateAsync(model);

            if (teamcreate)
            {
                return Ok(teamcreate);
            }

            return BadRequest(new TextResponse("User could not be registered"));
        }
        [HttpDelete("{id:int}")]
        public async Task<IActionResult> TeamMemberDelete([FromBody]int id)
        {
            return await _teamService.TeamMemberDelete(id)
            ? Ok ($"Id {id} was deleted from his team.")
            : BadRequest($"Id {id} could not be deleted");
        }
        [HttpDelete("{id:int}")]
        public async Task<IActionResult> TeamDelete([FromBody]int id)
        {
            return await _teamService.TeamDelete(id)
            ? Ok ($"Team Id {id} was deleted")
            : BadRequest($"Id {id} could not be deleted");
        }
        [HttpGet("{id:int}")]
        public async Task<IActionResult> GetTeamMembers(int id)
        {
            TeamList teamlist = await _teamService.GetTeamMembers(id);

            return teamlist is not null
                ? Ok(teamlist)
                : NotFound();
        }
}
}