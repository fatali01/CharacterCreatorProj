using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using CharacterCreator.Data.Entities;
using CharacterCreator.Models.Models.FeatureModels;


namespace CharacterCreator.Models.Models.CharacterModels
{
    public class CharacterCreate
    {
        [Required, MaxLength(100), MinLength(1)]
        public string? CharacterName { get; set; }
        [Required, MaxLength(100), MinLength(1)]
        public string? CharacterDescription { get; set; }
        public int CharacterAge { get; set; }
        [Required, MaxLength(100), MinLength(1)]
        public string? WarriorType { get; set; }
        [Required, MaxLength(100), MinLength(1)]
        public string? BirthLocation { get; set; }
        public List<FeatureEntity> Features = new List<FeatureEntity>();

    }
}