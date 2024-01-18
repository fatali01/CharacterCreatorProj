using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace CharacterCreator.Data.Entities
{
    public class FeatureEntity
    {
        [Key]
        public int FeatureId { get; set; }
        public string EyeColor { get; set; }= string.Empty;
        public string HairStyle { get; set; }= string.Empty;
        public string HairColor { get; set; }= string.Empty;
        public float Height { get; set; }
        public float Weight { get; set; }
        public string BodyType { get; set; } = string.Empty;
        public string Ability { get; set; } = string.Empty;
        public string SkinColor { get; set; } = string.Empty;
        [ForeignKey(nameof(CharacterId))]
        public int CharacterId { get; set; }
        
    }
}