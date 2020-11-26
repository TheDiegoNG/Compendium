using System.Collections.Generic;
using System.Linq;

namespace Compendium.Models
{
    public class Persona
    {
        public string nombre { get; set; }
        public byte nivel { get; set; }
        public Arcana arcana { get; set; }
        public List<Skill> skills { get; set; }
        public byte magia { get; set; }
        public byte fuerza { get; set; }
        public byte agilidad { get; set; }
        public byte aguante { get; set; }
        public byte suerte { get; set; }
        
    }
}