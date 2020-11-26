using System.Collections.Generic;

namespace Compendium.Models
{
    public class Arcana
    {
        public byte id { get; set; }
        public string nombre { get; set; }
        public List<Persona> personas { get; set; }
        
    }
}