using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace CharacterCreatorAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class TeamController : ControllerBase
    {
        private readonly ITeamService _context;

        public async Task<IActionResult> CharacterCreateAsync([FromBody] CharacterCreate model)
        {
            if(!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var charactercreate = await _Context.CharacterCreateAsync(model);

            if (charactercreate)
            {
                TextResponse response = new("User was registered");
                return Ok(response);
            }

            return BadRequest(new TextResponse("User could not be registered"));
    }
}