using System;
using System.Collections.Generic;
using System.Text;

namespace HB
{
    class HeapBinaria
    {
        int[] datos;

        //Contructor de la HeapBinaria

        public HeapBinaria(int capacidad)
        {
            this.datos = new int[capacidad + 1]; //Le sumo ya que considero la heap a partir de la pos 1.
        }
        
        //Metodos para obtener raices e hijos;

        private int getRaiz(){
            return this.datos[1];
        }

        private int getDatoPosicion(int i){
            return this.datos[i];
        }

        private int getHijoIzquierdo(int i){
            return this.datos[i * 2];
        }

        private int getHijoDerecho(int i){
            return this.datos[i * 2 + 1];
        }

        private bool tieneHijoIzquierdo(int i)
        {
            return this.datos.Length >= (i * 2); 
        }
        
        private bool tieneHijoDerecho(int i)
        {
            return this.datos.Length >= (i * 2 + 1);
        }
    }
}
