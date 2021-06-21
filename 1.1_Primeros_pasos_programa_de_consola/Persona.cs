namespace _1._1_Primeros_pasos_programa_de_consola
{
    class Persona
    {
        //Campo;
        // private string nombre; //Esta linea no hace flata.
        //Propiedad;
        //A ver, para poder acceder al valor de nombre lo hacemos por medio su propiedad llamada Nombre.
        public string Nombre { get ; set;  }
        public string Apellido { get ; set;  }

        public string name = "Alejo";

        public Persona()
        {
        }

        public string getName()
        {
            return name;
        }

        public string Saludar(string name){
            return $"Hola { name }";
        }
    }
    
}
