using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CharacterCreator.Data.Entities;

namespace CharacterCreator.Models.Models.CharacterModels
{
    public class CharacterDetail
    {
        
        public string? CharacterName { get; set; }
        public string? CharacterDescription { get; set; }
        public int CharacterAge { get; set; }
        public string? WarriorType { get; set; }
        public string? BirthLocation { get; set; }
        public List<FeatureEntity> Features = new List<FeatureEntity>();
        public TeamEntity Team { get; set; }
    }
}