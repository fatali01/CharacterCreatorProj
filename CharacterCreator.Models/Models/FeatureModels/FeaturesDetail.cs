using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CharacterCreator.Models.Models.FeatureModels
{
    public class FeaturesDetail
    {
        public string EyeColor { get; set; }= string.Empty;
        public string HairStyle { get; set; }= string.Empty;
        public string HairColor { get; set; }= string.Empty;
        public float Height { get; set; }
        public float Weight { get; set; }
        public string BodyType { get; set; } = string.Empty;
        public string Ability { get; set; } = string.Empty;
        public string SkinColor { get; set; } = string.Empty;
        
    }
}