using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CharacterCreator.Data;
using CharacterCreator.Data.Entities;
using CharacterCreator.Models.Models.FeatureModels;
using Microsoft.EntityFrameworkCore.Metadata.Internal;

namespace CharacterCreator.Services.Services.FeatureServices
{
    public class FeatureService : IFeatureService
    {
        private readonly AppDbContext _context;
        public async Task<FeaturesDetail> FeatureDetailByIdAsync(int featureId)
        {
            FeatureEntity feature = await _context.Features.FindAsync(featureId);

            if(feature != null)
            {
                FeaturesDetail characterFeatureDetail = new()
                {
                    EyeColor = feature.EyeColor,
                    HairStyle = feature.HairStyle,
                    HairColor = feature.HairColor,
                    Height = feature.Height,
                    Weight = feature.Weight,
                    BodyType = feature.BodyType,
                    Ability = feature.Ability,
                    SkinColor = feature.SkinColor
                };
                System.Console.WriteLine(characterFeatureDetail);
                return characterFeatureDetail; 
            }
            return null;
        }

        public async Task<bool> FeaturesCreateAsync(FeaturesCreate model)
        {
            if (model != null)
            {
                var features = new FeatureEntity()
                {
                    EyeColor = model.EyeColor,
                    HairStyle = model.HairStyle,
                    HairColor = model.HairColor,
                    Height = model.Height.ToString(),
                    Weight = model.Weight.ToString(),
                    BodyType = model.BodyType,
                    Ability = model.Ability,
                    SkinColor = model.SkinColor
                };
                await _context.Features.AddAsync(features);
                await _context.SaveChangesAsync();
                return true;
            }
            return false;
        }

        public async Task<bool> DeleteFeatureByIdAsync(int featureId)
        {
            FeatureEntity feature = await _context.Features.FindAsync(featureId);

            if(featureId != null)
            {
                _context.Features.Remove(feature);

                await _context.SaveChangesAsync();
            }
            return true;
        }


        public async Task<bool> UpdateFeatureByIdAsync(int featureId, FeaturesCreate featureCreated)
        {
            FeatureEntity feature = await _context.Features.FindAsync(featureId);

            if(featureId != null)
            {
                feature.EyeColor = featureCreated.EyeColor;
                feature.HairStyle = featureCreated.HairStyle;
                feature.HairColor = featureCreated.HairColor;
                feature.BodyType = featureCreated.BodyType;
                feature.Height = featureCreated.Height;
                feature.Weight = featureCreated.Weight;
                feature.Ability = featureCreated.Ability;
                feature.SkinColor = featureCreated.SkinColor;

            await _context.SaveChangesAsync();
            }
            return true;
        }
    }
}