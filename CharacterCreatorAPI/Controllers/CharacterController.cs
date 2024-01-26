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

        public CharacterController(ICharacterService context)
        {
            _Context = context;
        }

        [HttpPost("Create")]
        public async Task<IActionResult> CharacterCreateAsync([FromBody] CharacterCreate model)
        {
            if(!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var charactercreate = await _Context.CharacterCreateAsync(model);

            if (charactercreate)
            {
                TextResponse response = new("Character was registered");
                return Ok(response);
            }

            return BadRequest(new TextResponse("Character could not be registered"));
        }
        [HttpDelete("Delete")]
        public async Task<IActionResult> CharacterDeleteAsync(int id)
        {
            var CharacterDelete = await _Context.CharacterDeleteAsync(id);

            if (CharacterDelete)
            {
                TextResponse response = new("Character was Deleted");
                return Ok(response);
            }

            return BadRequest(new TextResponse("Character could not be Deleted"));
        }
        [HttpGet("{id:int}")]
        public async Task<IActionResult> CharacterDetailAsync(int id)
        {
            var CharacterList = await _Context.CharacterDetailAsync(id);

            if (CharacterList is null)
            {
                return NotFound();
            }
                return Ok(CharacterList);
        }
        [HttpPut("Update")]
        public async Task<IActionResult> CharacterUpdateAsync(int id, CharacterCreate model)
        {
            if(!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var characterUpdate = await _Context.CharacterUpdateAsync(id, model);

            if (characterUpdate)
            {
                TextResponse response = new($"Character with the ID of {id} was Updated to: {model.CharacterName}\n {model.CharacterAge}\n {model.WarriorType}\n {model.BirthLocation}\n {model.CharacterDescription}\n");
                return Ok(response);
            }

            return BadRequest(new TextResponse("Character could not be Updated"));
        }
    }
}