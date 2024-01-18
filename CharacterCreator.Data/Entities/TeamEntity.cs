using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace CharacterCreator.Data.Entities
{
    public class TeamEntity
    {
        [Key]
        public int TeamId { get; set; }
        public string TeamName { get; set; }= string.Empty;
        public int TeamNumber { get; set; }
        public int TeamMembers { get; set; }
        public string TeamSlogan { get; set; }= string.Empty;
        public string TeamDescription { get; set; }= string.Empty;
        public string TeamMission { get; set; }= string.Empty;
        [ForeignKey(nameof(CharacterId))]
        public int CharacterId { get; set; }
        public List<CharacterEntity> Members = new List<CharacterEntity>();
    }
}