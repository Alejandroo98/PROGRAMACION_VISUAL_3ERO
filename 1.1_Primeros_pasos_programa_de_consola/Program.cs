using System;

namespace _1._1_Primeros_pasos_programa_de_consola
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Persona persona = new Persona();
            persona.Nombre = "Romeo";
            persona.Apellido = "Santos";
            // Console.WriteLine( persona.Saludar("Alejo") );
            Console.WriteLine( persona.getName() );
            Console.WriteLine( persona.Nombre );
            Saludar saludar = new Saludar();
            Console.WriteLine( saludar.holaClass("Romeo") );
            
        }
    }
    
}
