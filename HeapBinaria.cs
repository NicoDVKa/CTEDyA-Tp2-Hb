using System;
using System.Collections.Generic;
using System.Text;

namespace HB
{
    class HeapBinaria<T>
    {
        T[] datos;
        bool claseHeap; //Sirve para chequear si es una maxHeap(true) o MinHeap(false)
        
        //Contructor de la HeapBinaria

        public HeapBinaria(int capacidad, bool claseHeap)
        {
            this.datos = new T[capacidad + 1]; //Le sumo ya que considero la heap a partir de la pos 1.
            this.claseHeap = claseHeap;
        }
        
        //Metodos para obtener raices e hijos;

        private int getRaiz(){
            return int.Parse(this.datos[1].ToString());
        }

        private int getDatoPosicion(int i){
            return int.Parse(this.datos[1].ToString());
        }

        private int getHijoIzquierdo(int i){
            return int.Parse(this.datos[i * 2].ToString());
        }

        private int getHijoDerecho(int i){
            return int.Parse(this.datos[i * 2 + 1].ToString());
        }

        private bool tieneHijoIzquierdo(int i)
        {
            return this.datos.Length >= (i * 2); 
        }
        
        private bool tieneHijoDerecho(int i)
        {
            return this.datos.Length >= (i * 2 + 1);
        }

        //Metodo es vacia
        public bool esVacia()
        {
            return this.datos.Length <= 1;
        }

        //AgregarElementos a la Heap
        public bool agregarElementos(){
            
            

            return true;
        }



    }
}
