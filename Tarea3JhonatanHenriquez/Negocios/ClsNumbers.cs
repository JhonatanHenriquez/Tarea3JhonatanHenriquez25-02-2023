using System;
using System.Collections.Generic;
using System.Text;
using Tarea3JhonatanHenriquez.Entidades;

namespace Tarea3JhonatanHenriquez.Negocios
{
    public class ClsNumbers
    {
        public void Show(Numbers numbers)
        {
            for(int i = numbers.Min; i<=numbers.Max; i++)
            {
                if(i % 2 == 0)
                {
                    Console.WriteLine($"Numero {i}");
                }
            }
        }
    }
}
