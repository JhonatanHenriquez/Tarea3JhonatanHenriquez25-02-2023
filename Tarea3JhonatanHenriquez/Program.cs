using System;
using Tarea3JhonatanHenriquez.Entidades;
using Tarea3JhonatanHenriquez.Negocios;

namespace Tarea3JhonatanHenriquez
{
    class Program
    {
        static void Main(string[] args)
        {
            Numbers ObjNumbers = new Numbers();
            ClsNumbers ObjClsNumbers = new ClsNumbers();
            bool execute = true;
            do
            {
                Console.WriteLine("Ingresa un numero");
                ObjNumbers.Min = int.Parse(Console.ReadLine());

                Console.WriteLine("Ingresa un numero mayor al anterior");
                ObjNumbers.Max = int.Parse(Console.ReadLine());

                if(ObjNumbers.Min > ObjNumbers.Max)
                {
                    Console.WriteLine("Rango incorrecto!");
                    Console.WriteLine("Intentalo nuevamente!\n");
                    execute = true;
                }
                else{
                    execute = false;
                }
            } while (execute);

            ObjClsNumbers.Show(ObjNumbers);
        }
    }
}
