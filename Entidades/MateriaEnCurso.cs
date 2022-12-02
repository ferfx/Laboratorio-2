using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class MateriaEnCurso
    {
        public string nombre;
        public string estadoAlumno;

        public MateriaEnCurso(string nombre, string estado)
        {
            this.nombre = nombre;
            this.estadoAlumno = estado;
        }

    }
}
