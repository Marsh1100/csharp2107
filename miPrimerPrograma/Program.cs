// See https://aka.ms/new-console-template for more information
using System.Numerics;
using System.Collections;


class Proyecto {
    public static void Main(){

        //Primero va la columna (letra) y después la fila (número)
        Console.Write("Ingresa la posición del caballo: ");
        string posicion = Convert.ToString(Console.ReadLine())  ?? "Unknown answer";

        string[] columnas ={"a","b","c","d","e","f","g","h"};
        char columnaChar = Convert.ToChar(posicion[0]);
        //string columnaChar = posicion.Substring(0,1);
        
        int columnaInt = Array.IndexOf(columnas,columnaChar); //Se busca el índice y se le suma 1
        int fila = posicion[1];
        Console.Write(columnaChar);
        Console.Write(columnas[3]);


        ArrayList movimientos = new ArrayList();

        if(fila-1 > 0)
        {
            if(columnaInt-2 > 0 )
            {
                int nuevaFila = fila-1;

                int nuevaColumna = columnaInt-2;
                movimientos.Add(columnas[nuevaColumna-1]+Convert.ToString(nuevaFila));
                
                if(fila-2>0)
                {
                    nuevaFila -=1;
                    nuevaColumna+=1;
                    movimientos.Add(columnas[nuevaColumna-1]+Convert.ToString(nuevaFila));
                }

            }if(columnaInt+2 <= 8)
            {
                int nuevaFila = fila-1;
                int nuevaColumna = columnaInt+2;

                movimientos.Add(columnas[nuevaColumna-1]+Convert.ToString(nuevaFila));
                if(fila-2>0)
                {
                nuevaFila -=1;
                nuevaColumna-=1;
                movimientos.Add(columnas[nuevaColumna-1]+Convert.ToString(nuevaFila));
                }
            }
        }else if(fila+1 <= 8)
        {
            if(columnaInt-2 > 0)
            {
                int nuevaFila = fila+1;

                int nuevaColumna = columnaInt-2;
                movimientos.Add(columnas[nuevaColumna-1]+Convert.ToString(nuevaFila));
                
                if(fila+2 <= 8)
                {
                    nuevaFila +=1;
                    nuevaColumna+=1;
                    movimientos.Add(columnas[nuevaColumna-1]+Convert.ToString(nuevaFila));
                }

            }if(columnaInt+2 <= 8)
            {
                int nuevaFila = fila+1;
                int nuevaColumna = columnaInt+2;

                movimientos.Add(columnas[nuevaColumna-1]+Convert.ToString(nuevaFila));
                if(fila+2 <= 8)
                {
                nuevaFila +=1;
                nuevaColumna-=1;
                movimientos.Add(columnas[nuevaColumna-1]+Convert.ToString(nuevaFila));
                }
            }

        }
        Console.Write(movimientos);
        
    }
}