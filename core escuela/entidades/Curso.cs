using System;
namespace CoreEscuela.Entidades
{
    public class Curso
    {
        public string nombre{get;set;}
        public string UniqueID{get;private set;}
        public Tipos_De_Jornada Jornada{get;set;}

        public Curso()
        {
            UniqueID = Guid.NewGuid().ToString();
        }
    }
}