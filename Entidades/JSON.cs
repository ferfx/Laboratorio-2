using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Entidades
{
    public static class JSON
    {
        public static StreamWriter writer;
        public static StreamReader reader;
        public static string path;

        public static string pathDos;


        static JSON()
        {
            path = Environment.CurrentDirectory;
            path += "\\AlumnosImportadosJSON.json";

            pathDos = Environment.CurrentDirectory;
            pathDos += "\\ArchivosJSON2.json";
        }

        public static bool SerializarJSON(User aux)
        {
            bool validacion = false;

            try
            {
                using (JSON.writer = new StreamWriter(JSON.path, true))
                {
                    string json = JsonSerializer.Serialize(aux);

                    JSON.writer.WriteLine(json);
                    validacion = true;
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                validacion = false;
            }

            return validacion;
        }

        public static List<User> DeserializarJSON()
        {
            List<User> lista = new List<User>();
            User aux;
            string json;

            try
            {
                using (JSON.reader = new StreamReader(JSON.pathDos))
                {
                    while ((json = JSON.reader.ReadLine()) is not null)
                    {
                        aux = JsonSerializer.Deserialize<User>(json);

                        lista.Add(aux);
                    }

                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

            return lista;
        }
    }
}