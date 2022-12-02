using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Cursante
    {
        public int id;
        public string nombre;
        public string apellido;
        public string materia;
        public string estado;

        public Cursante(int id, string nombre, string apellido,string materia, string estado)
        {
            this.id = id;
            this.nombre = nombre;
            this.apellido = apellido;
            this.materia = materia;
            this.estado= estado;    
        }


        public int Id { get => this.id; set => id = value; }
        public string Nombre { get => this.nombre; set => nombre = value; }
        public string Apellido { get => this.apellido; set => apellido = value; }

        public string Materia { get => this.materia; set => materia = value; }

        public string Estado { get => this.estado; set => estado = value; }

        



        public static explicit operator Cursante(SqlDataReader v)
        {
            Cursante a = new Cursante(
                    Convert.ToInt32(v["id"]),
                    v["nombreA"].ToString() ?? "",
                    v["nombreB"].ToString() ?? "",
                    v["Materia"].ToString() ?? "",
                    v["Estado"].ToString() ?? ""
                    );

            return a;
        }
    }




    /*Cursante a = new Cursante(
            v["Alumnos.nombre"].ToString() ?? "",
            v["Alumnos.apellido"].ToString() ?? "",
            v["Materias.nombre"].ToString() ?? "",
            v["alumnos_materias.estado"].ToString() ?? ""
            );*/


}


   




