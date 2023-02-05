using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace cvhtml
{
    public class Persona
    {
        public string Cedula { get; set; } = string.Empty;
        public string Nombre { get; set; } = string.Empty;
        public string Apellido { get; set; } = string.Empty;
        public string Email { get; set; } = string.Empty;
        public string Comentario { get; set; } = string.Empty;
        public List<Estudio> EstudiosRealizados { get; set; } = new ();
        public List<Idioma> IdiomasQueDomina { get; set; } = new ();

        public string GetEstudios(string plantilla) {
            string list = string.Empty;
            foreach (var item in EstudiosRealizados)
            {
                list += plantilla
                    .Replace("{{periodo}}",item.Periodo)
                    .Replace("{{institucion}}", item.Institucion)
                    .Replace("{{nombre}}", item.Nombre)
                    ;
            }
            return list;
        }
        public string GetIdioma(string plantilla) {
            string list = string.Empty;
            foreach (var item in IdiomasQueDomina)
            {
                list += plantilla
                    .Replace("{{nivel}}", item.Nivel.ToString("n0"))
                    .Replace("{{nombre}}", item.Nombre)
                    ;
            }
            return list;
        }
        
    }
}