using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CharacterCreator.Models.Models.FeatureModels;

namespace CharacterCreator.Services.Services.FeatureServices
{
    public interface IFeatureService
    {
        Task<bool> FeaturesCreateAsync(FeaturesCreate model);

        Task<List<FeaturesListModel>> GetAllFeaturesDetail();
        Task<FeaturesDetail> FeatureDetailByIdAsync(int featureId);

        Task<bool> DeleteFeatureByIdAsync(int featureId);

        Task<bool> UpdateFeatureByIdAsync(int featureId, FeaturesCreate featureCreated);

    }
}