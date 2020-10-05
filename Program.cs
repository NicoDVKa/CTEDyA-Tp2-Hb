using System;
using System.Linq;
using System.Security.Cryptography.X509Certificates;

namespace HB
{
    class Program
    {
        static void Main(string[] args)
        {
            int capacidad = -1;                //Si capacidad es < -1 se rompe.
            if (capacidad < 0) capacidad = 0;
            bool claseHeap = true;
            HeapBinaria<int> heapBinaria = new HeapBinaria<int>(capacidad, claseHeap);

            //Comprobacion de esVacia()
            Console.WriteLine("La heap esta vacia?, {0}", heapBinaria.esVacia());

            //Comprobacion de agregarElemento() MaxHeap
            heapBinaria.agregarElemento(1);
            heapBinaria.agregarElemento(6);
            heapBinaria.agregarElemento(5);
            heapBinaria.agregarElemento(3);
            heapBinaria.agregarElemento(4);
            heapBinaria.agregarElemento(7);
            heapBinaria.agregarElemento(7);
            heapBinaria.agregarElemento(9);

            //Comprobacion de verDatos()
            Console.Write("maxHeap: "); heapBinaria.verDatos();

            //Comprobacion de verTope()
            Console.WriteLine("El dato de la raiz es: {0}", heapBinaria.verTope());


            //Comprobacion eliminar()
            Console.WriteLine("El dato de la raiz es: {0}",heapBinaria.eliminar());
            Console.Write("maxHeap luego de la eliminacion de la raiz: "); heapBinaria.verDatos();


            Console.WriteLine("Presione una tecla para salir.");
            Console.ReadKey(true);

        }
    }  
}
