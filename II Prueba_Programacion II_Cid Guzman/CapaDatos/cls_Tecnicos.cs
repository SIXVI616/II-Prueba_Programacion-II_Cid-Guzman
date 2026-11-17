using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace II_Prueba_Programacion_II_Cid_Guzman.CapaDatos
{
    public class cls_Tecnicos
    {
        private int tecnicoID;
        private string nombre;
        private string especialidad;

        public int TecnicoID
        {
            get { return tecnicoID; }
            set { tecnicoID = value; }
        }

        public string Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }

        public string Especialidad
        {
            get { return especialidad; }
            set { especialidad = value; }
        }
    }
}