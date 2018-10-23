using System;
using System.Collections.Generic;
using System.Configuration;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Utilidades
{
    public static class UtilidadesAuditoria
    {
        public static void GenerarLog(string mensaje)
        {
            try
            {
                //Pass the filepath and filename to the StreamWriter Constructor
                StreamWriter sw = new StreamWriter(ConfigurationManager.AppSettings["RutaArchivoLog"].ToString()+"LogProyectoGrado.txt");

                //Write a line of text
                sw.WriteLine(mensaje);
                
                //Close the file
                sw.Close();
            }
            catch (Exception e)
            {
                Console.WriteLine("Exception: " + e.Message);
            }
            finally
            {
                Console.WriteLine("Executing finally block.");
            }
        }
    }
}
