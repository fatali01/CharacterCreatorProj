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

        public CharacterService(AppDbContext context)
        {
            _context = context;
        }
        public async Task<bool> CharacterCreateAsync(CharacterCreate model)
        {
            if (model != null)
            {
                try
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
                catch(Exception ex)
                {
                    DisplayError(ex.Message);
                    return false;
                }
            }
            return false;
        }
        public async Task<bool> CharacterDeleteAsync(int id)
        {
            try
            {
                var character = await _context.Characters.FindAsync(id);
                if (character != null)
                {
                    _context.Characters.Remove(character!);
                    await _context.SaveChangesAsync();
                    return true;
                }
                return false;
            }
            catch(Exception ex)
            {
                DisplayError(ex.Message);
                return false;
            }
        }

        public async Task<bool> CharacterDetailAllAsync()
        {
            try
            {
                foreach(var character in _context.Characters)
                {
                    System.Console.WriteLine(character);
                }
                return true;
            }
            catch(Exception ex)
            {
                DisplayError(ex.Message);
                return false;
            }
        }

        public async Task<CharacterDetail> CharacterDetailAsync(int id)
        {
            try
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
                    };
                    System.Console.WriteLine(detail);
                    return detail;
                }
                return null;
            }
            catch(Exception ex)
            {
                DisplayError(ex.Message);
                return null;
            }
        }
        public async Task<bool> CharacterUpdateAsync(int id, CharacterCreate character)
        {
            try
            {
                if(character != null)
                {
                    var characterToUpdate = await _context.Characters.FindAsync(id);
                    if(characterToUpdate != null)
                    {
                        characterToUpdate.WarriorType = character.WarriorType;
                        characterToUpdate.CharacterName = character.CharacterName;
                        characterToUpdate.CharacterAge = character.CharacterAge;
                        characterToUpdate.CharacterDescription = character.CharacterDescription;
                        characterToUpdate.BirthLocation = character.BirthLocation;
                        
                        int numberOfChanges = await _context.SaveChangesAsync();
                        return numberOfChanges == 1;
                    }
                    return false;
                }
                return false;
            }
            catch(Exception ex)
            {
                DisplayError(ex.Message);
                return false;
            }
        }
        //Helper Methods
        void DisplayError(string v)
        {
            Console.ForegroundColor = ConsoleColor.DarkRed;
            System.Console.WriteLine(v);
            Console.ResetColor();
        }
    }
}