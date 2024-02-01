using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore.Metadata.Internal;

namespace CharacterCreator.Data.Entities
{
    public class CharacterEntity
    {
        [Key]
        public int CharacterId { get; set; }
        [Required, MaxLength(100), MinLength(1)]
        public string WarriorType  { get; set; } = string.Empty;
        [Required, MaxLength(100), MinLength(1)]
        public string CharacterName { get; set; } = string.Empty;
        public int CharacterAge { get; set; }
        [Required, MaxLength(100), MinLength(1)]
        public string CharacterDescription { get; set; } = string.Empty;
        [Required, MaxLength(100), MinLength(1)]
        public string BirthLocation { get; set; } = string.Empty;
        public List<FeatureEntity> Features  = new List<FeatureEntity>();
        public int? TeamId { get; set; }
        [ForeignKey(nameof(TeamId))]
        public TeamEntity TeamEntity { get; set; }
    }
}