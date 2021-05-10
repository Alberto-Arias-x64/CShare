namespace CoreEscuela.Entidades
{
    class Escuela {
       
        // encapsulamiento tradicional
        public string nombre{get;set;}
        public int AñoDeCreacion{get;set;}
        public string pais{get;set;}
        public string ciudad{get;set;}
        public Tipos_De_Escuela tipoescuela {get;set;}

        public Escuela(string nombre, int año)
        {
            this.nombre = nombre;
            this.AñoDeCreacion = año;
        }

        public override string ToString()
        {
            return $"nombre: {nombre}, tipo: {tipoescuela}, pais: {pais}, ciudad: {ciudad}";
        }
    }
}