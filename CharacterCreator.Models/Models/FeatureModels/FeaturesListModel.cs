using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CharacterCreator.Models.Models.FeatureModels
{
    public class FeaturesListModel
    {
        public int FeatureId { get; set; }
        public string BodyType { get; set; } = string.Empty;
        public string Ability { get; set; } = string.Empty;
        public string SkinColor { get; set; } = string.Empty;
        public int CharacterId { get; set; }
        
    }
}