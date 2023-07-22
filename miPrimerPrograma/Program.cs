// See https://aka.ms/new-console-template for more information
using System.Numerics;
using System.Collections;


class Proyecto {
    public static void Main(){

        //Primero va la columna (letra) y después la fila (número)
        Console.Write("Ingresa la posición del caballo: ");
        string posicion = Convert.ToString(Console.ReadLine())  ?? "Unknown answer";

        string[] columnas ={"a","b","c","d","e","f","g","h"};
        string columnaString = posicion.Substring(0,1);
        
        int columnaInt = Array.IndexOf(columnas,columnaString)+1; //Se busca el índice y se le suma 1
        int fila =Int32.Parse(Convert.ToString(posicion[1]));
        
        Console.Write(columnaInt+"\n");
        Console.Write(fila+"\n");



        ArrayList movimientos = new ArrayList();

        if(fila-1 > 0)
        {
            if(columnaInt-2 > 0 )
            {
                int nuevaFila = fila-1;

                int nuevaColumna = columnaInt-2;
                //movimientos.Add(columnas[nuevaColumna-1]+Convert.ToString(nuevaFila));

                Console.Write(columnas[nuevaColumna-1]);
                Console.Write(nuevaFila+"\n");
                
                if(fila-2>0)
                {
                    nuevaFila -=1;
                    nuevaColumna+=1;
                    //movimientos.Add(columnas[nuevaColumna-1]+Convert.ToString(nuevaFila));
                    Console.Write(columnas[nuevaColumna-1]);
                    Console.Write(nuevaFila+"\n");
                }

            }if(columnaInt+2 <= 8)
            {
                int nuevaFila = fila-1;
                int nuevaColumna = columnaInt+2;

               // movimientos.Add(columnas[nuevaColumna-1]+Convert.ToString(nuevaFila));
                Console.Write(columnas[nuevaColumna-1]);
                Console.Write(nuevaFila+"\n");
                if(fila-2 > 0)
                {
                nuevaFila -=1;
                nuevaColumna-=1;
               // movimientos.Add(columnas[nuevaColumna-1]+Convert.ToString(nuevaFila));
                Console.Write(columnas[nuevaColumna-1]);
                Console.Write(nuevaFila+"\n");
                }
            }
        }if(fila+1 <= 8)
        {
            if(columnaInt-2 > 0)
            {
                int nuevaFila = fila+1;

                int nuevaColumna = columnaInt-2;
               // movimientos.Add(columnas[nuevaColumna-1]+Convert.ToString(nuevaFila));
                Console.Write(columnas[nuevaColumna-1]);
                Console.Write(nuevaFila+"\n");
                
                if(fila+2 <= 8)
                {
                    nuevaFila +=1;
                    nuevaColumna+=1;
                    //movimientos.Add(columnas[nuevaColumna-1]+Convert.ToString(nuevaFila));
                    Console.Write(columnas[nuevaColumna-1]);
                    Console.Write(nuevaFila+"\n");
                }

            }if(columnaInt+2 <= 8)
            {
                int nuevaFila = fila+1;
                int nuevaColumna = columnaInt+2;

               // movimientos.Add(columnas[nuevaColumna-1]+Convert.ToString(nuevaFila));
                Console.Write(columnas[nuevaColumna-1]);
                Console.Write(nuevaFila+"\n");
                if(fila+2 <= 8)
                {
                nuevaFila +=1;
                nuevaColumna-=1;
                //movimientos.Add(columnas[nuevaColumna-1]+Convert.ToString(nuevaFila));
                Console.Write(columnas[nuevaColumna-1]);
                Console.Write(nuevaFila+"\n");
                }
            }

        }
        //Console.Write(movimientos);
        
    }
}