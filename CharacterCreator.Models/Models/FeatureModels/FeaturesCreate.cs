using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace CharacterCreator.Models.Models.FeatureModels
{
    public class FeaturesCreate
    {
        [Required, MaxLength(50), MinLength(1)]
        public string EyeColor { get; set; }= string.Empty;
        [Required, MaxLength(50), MinLength(1)]
        public string HairStyle { get; set; }= string.Empty;
        [Required, MaxLength(50), MinLength(1)]
        public string HairColor { get; set; }= string.Empty;
        [Required, MaxLength(50), MinLength(1)]
        public string Height { get; set; }
        [Required, MaxLength(50), MinLength(1)]
        public string Weight { get; set; }
        [Required, MaxLength(50), MinLength(1)]
        public string BodyType { get; set; } = string.Empty;
        [Required, MaxLength(50), MinLength(1)]
        public string Ability { get; set; } = string.Empty;
        [Required, MaxLength(50), MinLength(1)]
        public string SkinColor { get; set; } = string.Empty;
        [ForeignKey(nameof(CharacterId))]
        public int CharacterId { get; set; }
        
    }
}