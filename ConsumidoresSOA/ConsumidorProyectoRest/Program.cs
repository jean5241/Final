using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using LogicaNegocio;
namespace ConsumidorProyectoRest
{
    class Program
    {
        static void Main(string[] args)
        {
            GestorCita obj1 = new GestorCita();
            GestorPaciente obj2 = new GestorPaciente();
            string usuario = "";
            string contrasena="";
            int opcion = 0;
            int terminar = 0;
            int envio = 0;
            string nombreCSV = "";
            string rutaCSV = "";
            int credenciales = 0;
            while (credenciales != 1)
            {
                Console.WriteLine("Usuario: ");
                usuario = Console.ReadLine();
                Console.WriteLine("Contraseña: ");
                contrasena = Console.ReadLine();
                if (obj1.sesion(usuario, contrasena))
                {
                    while (terminar != 4)
                    {
                        Console.WriteLine("");
                        Console.WriteLine("Menu de opciones");
                        Console.WriteLine("");
                        Console.WriteLine("1. Consultar la lista de usuarios que no encontraron citas disponibles cuando deseaban reservar");
                        Console.WriteLine("2. Consultar la lista de usuarios que han iniciado sesión en la aplicación móvil o web");
                        Console.WriteLine("3. Consultar el número de veces que han intentado iniciar sesión en una cuenta existente de forma erronéa");
                        Console.WriteLine("4. Terminar");
                        opcion = Convert.ToInt32(Console.ReadLine());
                        switch (opcion)
                        {
                            case 1:
                                DataTable dt = new DataTable();
                                dt = obj1.Nocita();
                                Console.WriteLine("Id  Nombre  Apellido  Cedula   Fecha");
                                foreach (DataRow row in dt.Rows)
                                {
                                    Console.WriteLine();
                                    for (int x = 0; x < dt.Columns.Count; x++)
                                    {
                                        Console.Write(row[x].ToString() + " ");
                                    }
                                }
                                Console.WriteLine("");
                                Console.WriteLine("Digite 1 si desea enviar los datos a un CSV");
                                envio = Convert.ToInt32(Console.ReadLine());
                                if (envio == 1)
                                {
                                    //Console.WriteLine("Digite el nombre que desea darle al archivo: ");
                                    //nombreCSV = Console.ReadLine();
                                    Console.WriteLine("Digite la ruta donde desea que se guarde al final de la ruta debe especificar el nombre del archivo .csv : ");
                                    rutaCSV = Console.ReadLine();
                                    dt.ToCSV(rutaCSV);
                                }

                                break;
                            case 2:
                                DataTable dt1 = new DataTable();
                                dt1 = obj2.LoginRegistro();
                                Console.WriteLine("Id  cedula     Fecha");
                                foreach (DataRow row in dt1.Rows)
                                {
                                    Console.WriteLine();
                                    for (int x = 0; x < dt1.Columns.Count; x++)
                                    {
                                        Console.Write(row[x].ToString() + " ");
                                    }
                                }
                                Console.WriteLine("");
                                Console.WriteLine("Digite 1 si desea enviar los datos a un CSV");
                                envio = Convert.ToInt32(Console.ReadLine());
                                if (envio == 1)
                                {
                                    //Console.WriteLine("Digite el nombre que desea darle al archivo: ");
                                    //nombreCSV = Console.ReadLine();
                                    Console.WriteLine("Digite la ruta donde desea que se guarde al final de la ruta debe especificar el nombre del archivo .csv : ");
                                    rutaCSV = Console.ReadLine();
                                    dt1.ToCSV(rutaCSV);
                                }

                                break;
                            case 3:
                                DataTable dt2 = new DataTable();
                                dt2 = obj2.LoginError();
                                Console.WriteLine("Id  cedula    ip     Fecha");
                                foreach (DataRow row in dt2.Rows)
                                {
                                    Console.WriteLine();
                                    for (int x = 0; x < dt2.Columns.Count; x++)
                                    {
                                        Console.Write(row[x].ToString() + " ");
                                    }
                                }
                                Console.WriteLine("");
                                Console.WriteLine("Digite 1 si desea enviar los datos a un CSV");
                                envio = Convert.ToInt32(Console.ReadLine());
                                if (envio == 1)
                                {
                                    //Console.WriteLine("Digite el nombre que desea darle al archivo: ");
                                    //nombreCSV = Console.ReadLine();
                                    Console.WriteLine("Digite la ruta donde desea que se guarde al final de la ruta debe especificar el nombre del archivo .csv : ");
                                    rutaCSV = Console.ReadLine();
                                    dt2.ToCSV(rutaCSV);
                                }
                                break;
                            case 4:
                                terminar = 4;
                                credenciales = 1;
                                break;
                        }
                    }
                }
                else
                {
                    Console.WriteLine("Credenciales incorrectas");

                }
            }
           

        }
       
    }
}
