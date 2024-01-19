using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CharacterCreator.Data;
using CharacterCreator.Data.Entities;
using CharacterCreator.Models.Models.CharacterModels;
using CharacterCreator.Models.Models.FeatureModels;

namespace CharacterCreator.Services.Services.CharacterServices
{
    public class CharacterService : ICharacterService
    {
        private readonly AppDbContext _context;

        public async Task<bool> CharacterCreateAsync(CharacterCreate model)
        {
            if (model != null)
            {
                var character = new CharacterEntity()
                {
                    WarriorType = model.WarriorType,
                    CharacterName = model.CharacterName,
                    CharacterAge = model.CharacterAge,
                    CharacterDescription = model.CharacterDescription,
                    BirthLocation = model.BirthLocation
                };
                await _context.Characters.AddAsync(character);
                await _context.SaveChangesAsync();
                return true;
            }
            return false;

        }

        public async Task<CharacterDetail> CharacterDetailAsync(int id)
        {
            CharacterEntity character = await _context.Characters.FindAsync(id);

            if (character != null)
            {
                CharacterDetail detail = new()
                {
                    CharacterName = character.CharacterName,
                    CharacterDescription = character.CharacterDescription,
                    CharacterAge = character.CharacterAge,
                    WarriorType = character.WarriorType,
                    BirthLocation = character.BirthLocation,
                    Features = character.Features,
                    TeamId = character.TeamId
                };

                System.Console.WriteLine(detail);
                return detail;
            }
            return null;

        }
    }
}