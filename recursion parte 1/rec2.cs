using System;
using System.Collections.Generic;


class Program {
  public static void Main (string[] args) {
    Console.WriteLine ("Hello World");
  }
}
public static void OrdenamientoPorInsercion(int[] arreglo, int index)
{
    // Si el índice es mayor que la longitud del arreglo, significa que todos los elementos del arreglo ya están ordenados.
    if (index >= arreglo.Length)
    {
        return;
    }

    // Si el elemento actual en el índice 'index' es menor que el elemento anterior, se intercambian sus posiciones.
    if (index > 0 && arreglo[index] < arreglo[index - 1])
    {
        int temp = arreglo[index];
        arreglo[index] = arreglo[index - 1];
        arreglo[index - 1] = temp;

        // Ahora el elemento en la posición 'index' ya está ordenado. Entonces, llamamos al método de nuevo con el índice actualizado.
        OrdenamientoPorInsercion(arreglo, index - 1);
    }
    else
    {
        // Si el elemento actual en el índice 'index' no es menor que el elemento anterior, significa que el elemento ya está ordenado.
        // Entonces, llamamos al método de nuevo con el índice actualizado.
        OrdenamientoPorInsercion(arreglo, index + 1);
    }
}