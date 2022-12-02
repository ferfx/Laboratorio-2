using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;


namespace Entidades
{
    public class UserDao
    {
        private static SqlConnection _sqlConnection;
        private static SqlCommand _sqlCommand;

        static UserDao()
        {
            _sqlConnection = new SqlConnection("Data Source=.;Database=parcial_dos;Trusted_Connection=true");


            _sqlCommand = new SqlCommand();
            _sqlCommand.Connection = _sqlConnection;
            _sqlCommand.CommandType = System.Data.CommandType.Text;
        }

        public static List<User> TraerAdmines()
        {


            List<User> list = new List<User>();

            try
            {
                _sqlCommand.CommandText = "SELECT * FROM Admins";

                _sqlConnection.Open();

                SqlDataReader reader = _sqlCommand.ExecuteReader();

                while (reader.Read())

                {
                    User aux = (User)reader;




                    //Console.WriteLine(persona);
                    list.Add(aux);



                }
            }
            catch (Exception)
            {
                throw new Exception("No se ha podido obtener la lista de admines");

            }
            finally
            {
                if (_sqlConnection.State == System.Data.ConnectionState.Open)
                {
                    _sqlConnection.Close();
                }
            }

            return list;
        }
        public static int AddAdmin(string usuario, string contraseña, string nombre, string apellido, int edad, int dni)
        {
            int filas = 0;
            try
            {
                _sqlCommand.Parameters.Clear();

                _sqlConnection.Open();

                _sqlCommand.CommandText = "INSERT INTO Admins (usuario,contraseña,nombre,apellido,edad,dni) VALUES(@usuario, @contraseña, @nombre, @apellido, @edad, @dni)";

                _sqlCommand.Parameters.AddWithValue("@usuario", usuario);
                _sqlCommand.Parameters.AddWithValue("@contraseña", contraseña);
                _sqlCommand.Parameters.AddWithValue("@nombre", nombre);
                _sqlCommand.Parameters.AddWithValue("@apellido", apellido);
                _sqlCommand.Parameters.AddWithValue("@edad", edad);
                _sqlCommand.Parameters.AddWithValue("@dni", dni);

                filas = _sqlCommand.ExecuteNonQuery();
            }
            catch (Exception)
            {

                throw new Exception("No se ha podido agergar al user");
            }
            finally
            {
                if (_sqlConnection.State == System.Data.ConnectionState.Open)
                {
                    _sqlConnection.Close();
                }
            }

            return filas;
        }




        public static List<User> TraerAlumnos()
        {


            List<User> list = new List<User>();

            try
            {
                _sqlCommand.CommandText = "SELECT * FROM Alumnos";

                _sqlConnection.Open();

                SqlDataReader reader = _sqlCommand.ExecuteReader();

                while (reader.Read())

                {
                    User aux = (User)reader;




                    //Console.WriteLine(persona);
                    list.Add(aux);



                }
            }
            catch (Exception)
            {
                throw new Exception("No se ha podido obtener la lista de jugadores de la base de alumnos");

            }
            finally
            {
                if (_sqlConnection.State == System.Data.ConnectionState.Open)
                {
                    _sqlConnection.Close();
                }
            }

            return list;
        }
        public static int AddAlumno(string usuario, string contraseña, string nombre, string apellido, int edad, int dni)
        {
            int filas = 0;
            try
            {
                _sqlCommand.Parameters.Clear();

                _sqlConnection.Open();

                _sqlCommand.CommandText = "INSERT INTO Alumnos (usuario,contraseña,nombre,apellido,edad,dni) VALUES(@usuario, @contraseña, @nombre, @apellido, @edad, @dni)";

                _sqlCommand.Parameters.AddWithValue("@usuario", usuario);
                _sqlCommand.Parameters.AddWithValue("@contraseña", contraseña);
                _sqlCommand.Parameters.AddWithValue("@nombre", nombre);
                _sqlCommand.Parameters.AddWithValue("@apellido", apellido);
                _sqlCommand.Parameters.AddWithValue("@edad", edad);
                _sqlCommand.Parameters.AddWithValue("@dni", dni);

                filas = _sqlCommand.ExecuteNonQuery();
            }
            catch (Exception)
            {

                throw new Exception("No se ha podido agregar al user");
            }
            finally
            {
                if (_sqlConnection.State == System.Data.ConnectionState.Open)
                {
                    _sqlConnection.Close();
                    
                }
                
            }

            return filas;
        }



        public static List<User> TraerProfesores()
        {


            List<User> list = new List<User>();

            try
            {
                _sqlCommand.CommandText = "SELECT * FROM Profesores";

                _sqlConnection.Open();

                SqlDataReader reader = _sqlCommand.ExecuteReader();

                while (reader.Read())

                {
                    User aux = (User)reader;




                    //Console.WriteLine(persona);
                    list.Add(aux);



                }
            }
            catch (Exception)
            {


            }
            finally
            {
                if (_sqlConnection.State == System.Data.ConnectionState.Open)
                {
                    _sqlConnection.Close();
                }
            }

            return list;
        }
        public static int AddProfesor(string usuario, string contraseña, string nombre, string apellido, int edad, int dni)
        {
            int filas = 0;
            try
            {
                _sqlCommand.Parameters.Clear();

                _sqlConnection.Open();

                _sqlCommand.CommandText = "INSERT INTO Profesores (usuario,contraseña,nombre,apellido,edad,dni) VALUES(@usuario, @contraseña, @nombre, @apellido, @edad, @dni)";

                _sqlCommand.Parameters.AddWithValue("@usuario", usuario);
                _sqlCommand.Parameters.AddWithValue("@contraseña", contraseña);
                _sqlCommand.Parameters.AddWithValue("@nombre", nombre);
                _sqlCommand.Parameters.AddWithValue("@apellido", apellido);
                _sqlCommand.Parameters.AddWithValue("@edad", edad);
                _sqlCommand.Parameters.AddWithValue("@dni", dni);

                filas = _sqlCommand.ExecuteNonQuery();
            }
            catch (Exception)
            {

                throw;
            }
            finally
            {
                if (_sqlConnection.State == System.Data.ConnectionState.Open)
                {
                    _sqlConnection.Close();
                }
            }

            return filas;
        }



        public static List<Cursante> TraerAlumnosMaterias()
        {
            List<Cursante> list = new List<Cursante>();

            try
            {


                //_sqlCommand.CommandText = "SELECT * FROM cursantes";
                _sqlCommand.CommandText = "SELECT alumnos_materias.id iD, Alumnos.nombre nombreA, Alumnos.apellido nombreB, Materias.nombre Materia, alumnos_materias.estado Estado FROM alumnos_materias INNER JOIN Materias on alumnos_materias.id_materia = Materias.id INNER JOIN Alumnos on Alumnos.id=alumnos_materias.id_alumno";

                _sqlConnection.Open();

                SqlDataReader reader = _sqlCommand.ExecuteReader();

                while (reader.Read())

                {
                    Cursante aux = (Cursante)reader;

                    

                    list.Add(aux);
                    
                    



                }
            }
            catch (Exception)
            {


            }
            finally
            {
                if (_sqlConnection.State == System.Data.ConnectionState.Open)
                {
                    _sqlConnection.Close();
                }
            }

            return list;

        }

        public static void ModificarEstadoMateria(int id,string estado)
        {
            try
            {
                
                _sqlConnection.Open();
                _sqlCommand.CommandText = $"UPDATE alumnos_materias SET estado = {estado} WHERE id = {id}";
                //_sqlCommand.Parameters.AddWithValue("@estado", estado);

            }
            catch (Exception) 
            {
            
            }
            finally
            {
                if (_sqlConnection.State == System.Data.ConnectionState.Open)
                {
                    _sqlConnection.Close();
                }
            }
        }

        
            
    }



    

}