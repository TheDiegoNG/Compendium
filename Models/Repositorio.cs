
using System.Collections.Generic;
using System.Linq;

namespace Compendium.Models
{
    public static class Repositorio
    {
        private static List<Persona> personas = new List<Persona>();
        public static IEnumerable<Persona> Personas => personas;
        public static void AgregarPersona(Persona persona) => personas.Add(persona);

        private static List<Arcana> arcanas = new List<Arcana>();
        public static IEnumerable<Arcana> Arcanas => arcanas;
        public static void AgregarArcana(Arcana arcana) => arcanas.Add(arcana);
    }
}