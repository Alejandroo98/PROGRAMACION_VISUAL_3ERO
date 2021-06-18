using System;

namespace Clase2_17_06_2021_
 
{
    
    class Program
    {
        static void Main(string[] args)
        {
            // Console.WriteLine( args );
            // Pedir 10 datos de una persona, bool, string, float, int, double, dateTime
            Console.WriteLine("======= Bienvenido ========");
            if( args[0] == "START")
            {
                Console.WriteLine("==== LLENA LOS CAMPOS =====");
                SaludoInicial(args);

            }else
            {
                Console.WriteLine("FIN DE LA APP");
            }
        }
        static void SaludoInicial( String[] args ) 
        {
            Console.WriteLine("Ingresa tu primer nombre: ");
            string name = Console.ReadLine();

            Console.WriteLine("Ingresa tu segundo nombre: ");
            string lastName = Console.ReadLine();
            
            Console.WriteLine("¿Eres mayor de edad?");
            bool adult = bool.Parse(Console.ReadLine());

            //"Solo para mayores de edad"
            if( adult == false ){
                Console.Write("==== FIN DEL PROGRAMA ====");
                return;
                // Console.ReadKey();
            }

            Console.WriteLine("Ingresa tu edad: ");
            int age = int.Parse(Console.ReadLine());
            
            Console.WriteLine("Ingresa tu fecha de cumpleaños: ");
            string date = Console.ReadLine();

            Console.WriteLine("Ingresa tu semestre: ");
            int semester = int.Parse(Console.ReadLine());

            Console.WriteLine("Ingresa tu direccion domiciliaria: ");
            string address = Console.ReadLine();


            Console.WriteLine("Ingresa tu numero de telefono: ");
            float phone = float.Parse(Console.ReadLine());

            
            Console.WriteLine("Tipo de sangre: ");
            string blood = Console.ReadLine();

            Console.WriteLine("Carrera que estudias: ");
            string carrer = Console.ReadLine();
            
            Console.WriteLine(
                "==== REGISTRO EXITOSO ==== \n. Datos del registro:\n•Nombre: {0},\n•Apellido: {1},\n•Adulto: {2},\n•Age: {3},\n•Date: {4},\n•Semestre: {5},\n•Address: {6},\n•Phone: {7},\n•Blood: {8},\n•Carrer: {9}", name, lastName, adult, age, date, semester, address, phone, blood, carrer
            );

            Console.ReadKey();
            Console.WriteLine("<<==== PARA SALIR PRESIONA UNA TECLA ====>>");
        }
    }
}


