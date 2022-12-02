using System;
using System.Collections.Generic;
using System.Linq;
using System.Data.SqlClient;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;


namespace Entidades
{
    public static class Sistema
    {
        static List<User> listaAdmines;
        static List<User> listaProfesores;
        static List<User> listaAlumnos;
        static List<Materia> listaMaterias;
        static List<Cursante> listaCursantes;
        static List<User> listaAlumnosJson;


        static Sistema()
        {
            listaAdmines = new List<User>();
            listaProfesores = new List<User>();
            listaAlumnos = new List<User>();
            listaMaterias = new List<Materia>();
            listaCursantes = new List<Cursante>();


            

            Sistema.CargarAdmines();
            Sistema.CargarAlumnos();
            Sistema.CargarProfesores();
            Sistema.CargarMaterias();

            Sistema.CargarCursantes();

            






        }
        
        #region * -> GET LISTAS
        public static List<User> ListaAlumnosJson
        {
            get => listaAlumnosJson;
            set => listaAlumnosJson = value;
        }
        
       
        public static List<User> ListaAlumnos
        {
            get => listaAlumnos;
        }

        public static List<User> ListaProfesores
        {
            get => listaProfesores;
        }

        public static List<User> ListaAdmines
        {
            get => listaAdmines;
        }

        public static List<Materia> ListaMaterias
        {
            get => listaMaterias;
        }

        public static List<Cursante> ListaCursantes
        {
            get => listaCursantes;
        }

        #endregion

        #region * -> CARGA DE LISTAS
        public static List<User> CargarAdmines()
        {
             listaAdmines = UserDao.TraerAdmines();
             return listaAdmines;

        }

        public static List<User> CargarProfesores()
        {
            listaProfesores = UserDao.TraerProfesores();
            return listaProfesores;

        }

        public static List<User> CargarAlumnos()
        {
            listaAlumnos = UserDao.TraerAlumnos();
            return listaAlumnos;

        }


        public static List<Materia> CargarMaterias()
        {
           
            listaMaterias=MateriaDao.TraerMaterias();
            return listaMaterias;
        }

        public static List<Cursante> CargarCursantes()
        {

            listaCursantes=UserDao.TraerAlumnosMaterias();
            return listaCursantes;

        }

        #endregion

        #region * -> VALIDACIONES Y LOGINS
        public static bool Validar(string usuario, string contraseña)
        {
            bool retorno = true;
            if (string.IsNullOrEmpty(usuario) || string.IsNullOrEmpty(contraseña))
            {
                retorno = false;
            }
            return retorno;
        }

        public static User LoginTipoUsuario(string user, string contraseña)
        {

            User retorno=null;

            if (Validar(user, contraseña))
            {
                
                foreach (User aux in Sistema.listaAdmines)
                {
                    if (aux.Usuario == user && aux.CheckPassword(contraseña))
                    {
                        retorno = (User)aux;
                        retorno.caracteristica = "Admin";
                        break;
                    }

                    
                }

                foreach (User aux in Sistema.listaProfesores)
                {
                    if(aux.Usuario == user && aux.CheckPassword(contraseña)){

                        retorno = (User)aux;
                        retorno.caracteristica = "Profesor";
                        break;
                    }
                }

                foreach (User aux in Sistema.listaAlumnos)
                {
                    if(aux.Usuario == user && aux.CheckPassword(contraseña))
                    {
                        retorno = (User)aux;
                        retorno.caracteristica = "Alumno";
                        break;
                    }
                }
            }

            return retorno;
        }

        public static User ObtenerAdmin()
        {
            Random indiceRandom = new Random();
            int indice = indiceRandom.Next(0, Sistema.listaAdmines.Count);

            User adminRandom = Sistema.ListaAdmines.ElementAt(indice);

            return adminRandom;

        }

        public static User ObtenerProfesor()
        {
            Random indiceRandom = new Random();
            int indice = indiceRandom.Next(0, Sistema.listaProfesores.Count);

            User profeRandom = Sistema.listaProfesores.ElementAt(indice);

            return profeRandom;

        }

        public static User ObtenerAlumno()
        {
            Random indiceRandom = new Random();
            int indice = indiceRandom.Next(0, Sistema.listaAlumnos.Count);

            User alumnoRandom = Sistema.listaAlumnos.ElementAt(indice);

            return alumnoRandom;

        }
        #endregion

        





    }
}
