using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CharacterCreator.Models.Models.CharacterModels;


namespace CharacterCreator.Models.Models.TeamModels
{
    public class TeamList
    {
        public string TeamName { get; set; }= string.Empty;
        public int TeamNumber { get; set; }
        public string TeamSlogan { get; set; }= string.Empty;
        public string TeamDescription { get; set; }= string.Empty;
        public string TeamMission { get; set; }= string.Empty;     
        public List<int> MemberIds { get; set; } = new List<int>();
    }
}