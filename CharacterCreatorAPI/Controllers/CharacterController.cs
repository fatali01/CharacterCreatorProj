using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using CharacterCreator.Services.Services.CharacterServices;
using CharacterCreator.Models.Models.CharacterModels;
using CharacterCreator.Models.Responses;

namespace CharacterCreatorAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class CharacterController : ControllerBase
    {
        private readonly ICharacterService _Context;

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
}