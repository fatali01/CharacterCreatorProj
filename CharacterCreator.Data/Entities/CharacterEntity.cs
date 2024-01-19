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
        public string WarriorType  { get; set; } = string.Empty;
        public string CharacterName { get; set; } = string.Empty;
        public int CharacterAge { get; set; }
        public string CharacterDescription { get; set; } = string.Empty;
        public string BirthLocation { get; set; } = string.Empty;
        public List<FeatureEntity> Features  = new List<FeatureEntity>();
        [ForeignKey(nameof(TeamId))]
        public int TeamId { get; set; }
    }
}