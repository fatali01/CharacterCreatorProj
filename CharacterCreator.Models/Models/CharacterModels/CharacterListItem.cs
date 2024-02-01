using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CharacterCreator.Models.Models.CharacterModels
{
    public class CharacterListItem
    {
        public int Id { get; set; }
        public string WarriorType  { get; set; } = string.Empty;

        public string CharacterName { get; set; } = string.Empty;

    }
}