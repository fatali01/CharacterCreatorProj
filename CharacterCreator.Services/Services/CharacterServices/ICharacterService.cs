using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CharacterCreator.Models.Models.CharacterModels;
using CharacterCreator.Models.Models.FeatureModels;

namespace CharacterCreator.Services.Services.CharacterServices
{
    public interface ICharacterService
    {
        Task<bool> CharacterCreateAsync(CharacterCreate model);
        Task<CharacterDetail> CharacterDetailAsync(int id);
        Task<bool> CharacterDeleteAsync(int id);
        Task<bool> CharacterUpdateAsync(int id, CharacterCreate character);
        Task<List<CharacterDetail>> CharacterDetailAllAsync();

    }
}