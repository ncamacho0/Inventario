using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inventario
{
    class Inventario
    {
        Producto [] vInvetario = new Producto [20];
        public int pos = 0;

        public void agregar(Producto p)
        {
            vInvetario[pos] = p;
            pos++;
        }
        public Producto buscar(string nombre)
        {
            Producto buffer;
            for (int i = 0; i < vInvetario.Length - 1; i++)
            {
                buffer = vInvetario[i];
                if (buffer != null)
                {                   
                    if (buffer.nombre==nombre)                        
                        return buffer;                  
                }
            }
            return null;
        }
        public void eliminar(string nombre)
        {
            Producto buffer;
            for (int i = 0; i < vInvetario.Length - 1; i++)
            {
                buffer = vInvetario[i];
                if(buffer!=null)
                {
                    if (buffer.nombre == nombre)
                    {
                        vInvetario[i] = null;
                        int x;
                        for ( x=i;x<pos; x++)
                            vInvetario[x] = vInvetario[x +1];
                        pos--;

                    }
                }                               
            }
        }
        public string reporte()
        {
            Producto buffer=null;
            string sBuffer = null;
             for(int i=0;i<vInvetario.Length-1;i++)
            {
                buffer = vInvetario[i];
                sBuffer += Convert.ToString(buffer) +" ";
            }
            return sBuffer;

        }

        public void insertar(Producto p,int posI)
        {
            posI--;   
            for (int i = vInvetario.Length - 1; i > posI; i--)
                vInvetario[i] = vInvetario[i-1];
            vInvetario[posI] = p;
            pos++;

        }

        public override string ToString()
        {
            int bandera = 0;
            for(int i=0;i<vInvetario.Length-1;i++)
            {
                if (vInvetario[i] != null)
                    bandera++;
            }                     
            return bandera.ToString();
        }

    }
}
