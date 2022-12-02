using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class User : Persona
    {
        public int id;
        private string usuario;
        private string contraseña;
        public string caracteristica;

        public User(int id,string usuario, string contraseña, string nombre, string apellido, int edad, int dni) : base(nombre, apellido, dni)
        {
            this.id = id;
            this.usuario = usuario;
            this.contraseña = contraseña;
            this.Edad = edad;
        }

        public string Usuario { get => this.usuario; set => usuario = value; }
        public string Contraseña { get => this.contraseña; set => contraseña = value; }

        public int Id { get => this.id; set => id = value; }


        public bool CheckPassword(string password)
        {
            return this.contraseña == password;
        }

        public override int GetHashCode()
        {
            return this.Dni;
        }

        public static explicit operator User(SqlDataReader v)
        {
            User a = new User(
                    Convert.ToInt32(v["iD"]),
                    v["usuario"].ToString() ?? "",
                    v["contraseña"].ToString() ?? "",
                    v["nombre"].ToString() ?? "",
                    v["apellido"].ToString() ?? "",
                    Convert.ToInt32(v["edad"]),
                    Convert.ToInt32(v["dni"])
                    );

            return a;
        }
    }

    
}
