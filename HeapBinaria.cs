using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
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

        private int getPadre(int i)
        {
            return int.Parse(datos[i / 2].ToString());
        }
        
        private bool tienePadre(int i){
            return i > 1;
        }
        
        private int getHijoIzquierdo(int i){
            return int.Parse(this.datos[i * 2].ToString());
        }

        private int getHijoDerecho(int i){
            return int.Parse(this.datos[i * 2 + 1].ToString());
        }

        private bool tieneHijoIzquierdo(int i)
        {
            return this.datos.Length > (i * 2); 
        }
        
        private bool tieneHijoDerecho(int i)
        {
            return this.datos.Length > (i * 2 + 1);
        }

        //=====================================================================
        //Metodo swap
        public void swap(int posA , int posB)
        {
            T temporal = this.datos[posA];
            this.datos[posA] = this.datos[posB];
            this.datos[posB] = temporal;
        }

        //Metodo es vacia
        public bool esVacia()
        {
            return this.datos.Length <= 1;
        }

        //AgregarElementos a la Heap
        public bool agregarElemento(T elemento){

            T[] arregloTemporal = new T[] { elemento };   
            datos = datos.Concat(arregloTemporal).ToArray();  //Agrego el elemento al final del arreglo
            int posInsertada = datos.Length - 1;
            
            if (this.claseHeap) //En caso de ser una maxHeap
            {
                 while (this.tienePadre(posInsertada) && this.getPadre(posInsertada) < int.Parse(elemento.ToString()))
                 {
                    swap(posInsertada, posInsertada / 2);
                    posInsertada = posInsertada/ 2;
                 }

                
            }

            if (!this.claseHeap) //En caso de ser una minHeap
            {
                while (this.tienePadre(posInsertada) && this.getPadre(posInsertada) > int.Parse(elemento.ToString()))
                {
                    swap(posInsertada, posInsertada / 2);
                    posInsertada = posInsertada / 2;
                }
            }

            return true;
        }

        //Ver los datos de la Heap
        public void verDatos()
        {
            foreach (T i in this.datos)
            {
                Console.Write(i + " " );
            }
            Console.WriteLine();
        }

        //Ver tope de la Heap
        public string verTope(){
            if (!this.esVacia())
            {
                return this.getRaiz().ToString();
            }
            else
            {
                return "null";
            }
       
        }

        //Elimina la raiz y reordena
        public string eliminar()
        {
            if (!this.esVacia())//Compruebo que no este vacia
            {
                string datoRaiz = this.getRaiz().ToString();   //Guardo el dato de la raiz
                this.datos[1] = datos[datos.Length - 1];       //El ultimo dato pasa a ser la raiz
                Array.Resize(ref this.datos, datos.Length - 1);//Se elimina el ultimo elemento
                int posACambiar = 1;
                
                if (this.claseHeap)
                {
                   
                    while(this.tieneHijoIzquierdo(posACambiar) && this.tieneHijoDerecho(posACambiar))
                    {
                        if (this.getHijoIzquierdo(posACambiar) > this.getHijoDerecho(posACambiar)) 
                        {
                            swap(posACambiar,posACambiar * 2); //Cambiamos con el hijo Izquierdo
                            posACambiar = posACambiar * 2;
                        }
                        else
                        {
                            swap(posACambiar, posACambiar * 2 + 1); //Cambiamos con el hijo derecho
                            posACambiar = posACambiar * 2 + 1;
                        }
                    }
                }
                if (!this.claseHeap)
                {
                    while (this.tieneHijoIzquierdo(posACambiar) && this.tieneHijoDerecho(posACambiar))
                    {
                        if (this.getHijoIzquierdo(posACambiar) < this.getHijoDerecho(posACambiar))
                        {
                            swap(posACambiar, posACambiar * 2); //Cambiamos con el hijo Izquierdo
                            posACambiar = posACambiar * 2;
                        }
                        else
                        {
                            swap(posACambiar, posACambiar * 2 + 1); //Cambiamos con el hijo derecho
                            posACambiar = posACambiar * 2 + 1;
                        }
                    }
                }

                return datoRaiz;
            }
            else
            {
                return "null";
            }

            
        }
    }
}
