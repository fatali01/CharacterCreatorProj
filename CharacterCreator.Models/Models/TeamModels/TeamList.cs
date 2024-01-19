using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CharacterCreator.Models.Models.TeamModels
{
    public class TeamList
    {
        public string TeamName { get; set; }= string.Empty;
        public int TeamNumber { get; set; }
        public int TeamMembers { get; set; }
        public string TeamSlogan { get; set; }= string.Empty;
        public string TeamDescription { get; set; }= string.Empty;
        public string TeamMission { get; set; }= string.Empty;
    }
}