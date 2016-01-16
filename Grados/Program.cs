using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Grados
{
    class Program
    {
        static void Main(string[] args)
        {
            LibroDeCalificaciones libro = new LibroDeCalificaciones();
            libro.AddCalificacion(97);
            //Probando para hacer un push en githup
            Console.WriteLine("solo para githup");
        }
    }
}
