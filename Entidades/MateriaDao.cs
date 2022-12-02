using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Entidades
{
    public class MateriaDao
    {
        private static SqlConnection _sqlConnection;
        private static SqlCommand _sqlCommand;

        static MateriaDao()
        {
            _sqlConnection = new SqlConnection("Data Source=.;Database=parcial_dos;Trusted_Connection=true");


            _sqlCommand = new SqlCommand();
            _sqlCommand.Connection = _sqlConnection;
            _sqlCommand.CommandType = System.Data.CommandType.Text;
        }

        public static List<Materia> TraerMaterias()
        {


            List<Materia> list = new List<Materia>();

            try
            {
                _sqlCommand.CommandText = "SELECT * FROM Materias";

                _sqlConnection.Open();

                SqlDataReader reader = _sqlCommand.ExecuteReader();

                while (reader.Read())

                {
                    Materia aux = (Materia)reader;




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


        public static int AddMateria(string nombre, string cuatrimestre, string materiaCorrelativa)
        {
            int filas = 0;
            try
            {
                _sqlCommand.Parameters.Clear();

                _sqlConnection.Open();

                _sqlCommand.CommandText = "INSERT INTO Materias (nombre,cuatrimestre,materiaCorrelativa) VALUES(@nombre, @cuatrimestre, @materiaCorrelativa)";

                _sqlCommand.Parameters.AddWithValue("@nombre", nombre);
                _sqlCommand.Parameters.AddWithValue("@cuatrimestre", cuatrimestre);
                _sqlCommand.Parameters.AddWithValue("@materiaCorrelativa", materiaCorrelativa);
                

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
    }
}