using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CharacterCreator.Models.Models.FeatureModels;
using CharacterCreator.Models.Responses;
using CharacterCreator.Services.Services.FeatureServices;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore.Metadata.Internal;

namespace CharacterCreatorAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class FeatureController : ControllerBase
    {
        private readonly IFeatureService _featureService;
        public FeatureController(IFeatureService featureService)
        {
            _featureService = featureService;
        }
        [HttpPost("Create")]
        public async Task<IActionResult> CreateFeature([FromBody]FeaturesCreate model)
        {
            if(!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            var createdFeature = await _featureService.FeaturesCreateAsync(model);

            if(createdFeature)
            {
                TextResponse response = new("Feature was created");
                return Ok(response);
            }
            
            return BadRequest(new TextResponse("Feature could not be created"));
        }

        [HttpDelete("/Delete/{featureId:int}")]
        public async Task<IActionResult> DeleteFeatureByIdAsync(int featureId)
        {
            if(!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            
            var FeaturesDelete = await _featureService.DeleteFeatureByIdAsync(featureId);

            if (FeaturesDelete)
            {
                TextResponse response = new("Feature that you have created was Deleted");
                return Ok(response);
            }
            return BadRequest(new TextResponse("Could not delete features"));
        }

        [HttpPut("/Update/{featureId:int}")]
        public async Task<IActionResult>UpdateFeatureByIdAsync(int featureId, FeaturesCreate model)
        {
            if(!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            
                var UpdatedFeature = await _featureService.UpdateFeatureByIdAsync(featureId, model);
            
            if(UpdatedFeature)
            {
                TextResponse response = new("The feature Id that you have selected has SUCCESSFULLY updated");
                return Ok(response);
            }
            return BadRequest(new TextResponse("The feature Id you have selected has NOT updated successfully."));
        }
        
        [HttpGet("/OneById/{featureId:int}")]
        public async Task<IActionResult> GetFeatureById(int featureId)
        {
            var FeaturesList = await _featureService.FeatureDetailByIdAsync(featureId);

            if(FeaturesList is null)
            {
                return NotFound();
            }
            return Ok(FeaturesList);
        }
        [HttpGet]
        public async Task<IActionResult> GetAllFeatures()
        {
            var FeatureList = await _featureService.GetAllFeaturesDetail();
            return Ok(FeatureList);
        }
        
    }
}