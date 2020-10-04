using System;
using System.Security.Cryptography.X509Certificates;

namespace HB
{
    class Program
    {
        static void Main(string[] args)
        {
           int capacidad = -2;                //Si capacidad es < -1 se rompe.
           if (capacidad < -1) capacidad = -1;
           bool claseHeap = true;          
           HeapBinaria<int> heapBinaria = new HeapBinaria<int>(capacidad,claseHeap);

           //Comprobacion de esVacia()
           Console.WriteLine("La heap esta vacia?, {0}", heapBinaria.esVacia());

           Console.WriteLine("Presione una tecla para salir.");
           Console.ReadKey(true);
        }
    }  
}
