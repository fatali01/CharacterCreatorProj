using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CharacterCreator.Models.Models.FeatureModels;

namespace CharacterCreator.Services.Services.FeatureServices
{
    public class FeatureService : IFeatureService
    {
        public Task<FeaturesDetail> FeatureDetailByIdAsync(int featureId)
        {
            throw new NotImplementedException();
        }

        public Task<bool> FeaturesCreateAsync(FeaturesCreate model)
        {
            throw new NotImplementedException();
        }
    }
}