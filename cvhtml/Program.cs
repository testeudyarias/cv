// See https://aka.ms/new-console-template for more information
using cvhtml;

Console.WriteLine("Hello, World!");
Console.WriteLine($@"
    Bienvenid@ al Generador de Curriculums
    {Tools.asciiarts[0]}
    Digita los datos necesarios
");
Persona p = new Persona();
p.Cedula = Tools.Input("Escriba su cedula: ");
p.Nombre = Tools.Input("Escriba su nombre: ");
p.Apellido = Tools.Input("Escriba su apellido: ");
p.Email = Tools.Input("Escriba su email: ");
p.Comentario = Tools.Input("Escriba su comentario: ");

string tmpText = string.Empty;
do
{
    tmpText = Tools.Input("Escriba su estudio realizado, para salir dejar en blanco: ");
    if (tmpText != string.Empty) {

        string instituto = Tools.Input("Escriba la institucion: ");
        string periodo = Tools.Input("Escriba el periodo: ");
        p.EstudiosRealizados.Add(new Estudio() { Nombre = tmpText, Institucion=instituto, Periodo = periodo }); 
    }
} while (tmpText != string.Empty);


 tmpText = string.Empty;
do
{
    tmpText = Tools.Input("Escriba su idioma que domina, para salir dejar en blanco: ");
    if (tmpText != string.Empty) {
        decimal nivel = Tools.InputDecimal("Escriba el nivel 1-100 de dominio: ");
        p.IdiomasQueDomina.Add(new Idioma() { Nombre = tmpText, Nivel = nivel  }); 
    };
} while (tmpText != string.Empty);

string plantilla = System.IO.File.ReadAllText("index2.html");
string pEstudio = System.IO.File.ReadAllText("estudio.html");
string pIdioma = System.IO.File.ReadAllText("idioma.html");

plantilla = plantilla
    .Replace("{{cedula}}",p.Cedula)
    .Replace("{{nombre}}",$"{p.Nombre} {p.Apellido}")
    .Replace("{{email}}", p.Email)
    .Replace("{{comentario}}",p.Comentario)
    .Replace("{{estudios}}", p.GetEstudios(pEstudio))
    .Replace("{{idiomas}}", p.GetIdioma(pIdioma))
    ;

System.IO.File.WriteAllText("cv.html",plantilla);

var psi =  new System.Diagnostics.ProcessStartInfo();
psi.UseShellExecute = true;
psi.FileName = "cv.html";
System.Diagnostics.Process.Start(psi);