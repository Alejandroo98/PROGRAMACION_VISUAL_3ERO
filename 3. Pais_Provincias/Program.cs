using System;

using System.Collections.Generic;

namespace Clase_22_06_2021
{
    class Program
    {
        public static void Main(string[] args)
        {

            //Lo que hace esta linea es instanciar el objto y pasarle paremetros directamente;
            Pais pais = new Pais(); // Le pasamos los calores de sus parametros directamente pero no lo usasmos { Nombre = "Ecuador", PaisId = 1 }

            // pais.Provincias = new List<Provincia>(); //Esta linea no hace nada;

            Provincia provinciaUno = new Provincia();
            provinciaUno.Nombre = "Guayas";

            Provincia provinciaDos = new Provincia();
            provinciaDos.Nombre = "Pichincha";
            
            pais.Provincias = new List<Provincia>(){ provinciaUno , provinciaDos };

            /* PUEDES HACERLO DE ESTA MANERA O COMO LO VES JUSTO EN LAS LINEAS DE ARRIBA */
            // { 
            // new Provincia() { ProvinciaId = 5, Nombre = "Ecuador" }, 
            // new Provincia() { ProvinciaId = 5, Nombre = "Ecuador" }
            // };

            Canton cantonUno = new Canton();
            cantonUno.Nombre = "Mejia";
            // cantonUno.Parroquias = new List<Parroquia>(); //Linea inecesaria;

            

            Canton cantonDos = new Canton();
            cantonDos.Nombre = "Cayambe";
            
             
            provinciaDos.Cantones = new List<Canton>(){ cantonUno , cantonDos };

            /* ESTA ES UNA FORMA DIFERENTE DE PODER AHACER LO DE LA LINEA DE ARRIBA, LA DIFERENCIA ESQUE EN UNO PASAS LOS ARGUMENTOS 
            DIRECTAMENTE Y EN EL OTRO UTILIZAS LA PALABRA ADD CON EN LAS LINEAS DE ABAJO */
            // provinciaDos.Cantones.Add(cantonUno);
            // provinciaDos.Cantones.Add(cantonDos);
            

            Parroquia parroquiaUno = new Parroquia();
            parroquiaUno.Nombre = "San Sebastian";
            parroquiaUno.Habitantes = 200;

            
            Parroquia parroquiaDos = new Parroquia();
            parroquiaDos.Nombre = "Gonzales Suarez";
            parroquiaDos.Habitantes = 500;
            
            
            // provinciaDos.Cantones = new List<Canton>(); //Linea inecesaria;
            cantonUno.Parroquias = new List<Parroquia>(){ parroquiaUno , parroquiaDos };
            // cantonUno.Parroquias.Add(parroquiaUno);
            // cantonUno.Parroquias.Add(parroquiaDos);

            

            Console.WriteLine($"Habitantes totales en 2 parroquias: {pais.ObtenerNumeroDeHabitantes()}");

        }
    }
}
