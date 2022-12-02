using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Materia
    {
        public int id;
        private string nombre;
        private string cuatrimestre;
        
        private string materiaCorrelativa;

        public Materia(int id, string nombre, string cuatrimestre, string materiaCorrelativa)
        {
            this.id = id;
            this.nombre = nombre;       
            this.cuatrimestre = cuatrimestre;
            this.materiaCorrelativa = materiaCorrelativa;
            
            
        }

        public int Id { get => this.id; set => id = value; }
        public string Nombre { get => this.nombre; set => nombre = value; }
        public string Cuatrimestre { get => this.cuatrimestre; }
        public string MateriaCorrelativa { get => this.materiaCorrelativa; set => materiaCorrelativa = value; }

        public static explicit operator Materia(SqlDataReader v)
        {
            Materia a = new Materia(
                    Convert.ToInt32(v["id_materia"]),
                    v["nombre"].ToString() ?? "",
                    v["cuatrimestre"].ToString() ?? "",
                    v["materiaCorrelativa"].ToString() ?? ""
                     );

            return a;
        }
    }
}
