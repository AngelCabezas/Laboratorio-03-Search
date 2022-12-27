//namespace Lab03_Search;
namespace System.Diagnostics;
class BinarySearch
{
    static void Main2(string[] args)
    {
        Stopwatch tiempoInicio = new Stopwatch();
        Stopwatch tiempoFinal = new Stopwatch();

        tiempoInicio.Start();
        tiempoInicio.Stop();
        Console.WriteLine("tiempo de inicio:" + tiempoInicio.Elapsed.TotalMilliseconds);

        int[] A = { -8, 4, 5, 9, 12, 18, 25, 40, 60, 80 , 11 , 13 , 17, 18, 89, 18, 121, 191, 7, 1};
        Console.WriteLine("\nArreglo desordenado");
        for (int i = 0; i < A.Length; i++)
        {
            Console.Write($"A[{i}]={A[i]} ,");
        }
        Console.WriteLine("\n");
        Array.Sort(A);
        Console.WriteLine("Arreglo ordenado");
        for (int i = 0; i < A.Length; i++)
        {
            Console.Write($"A[{i}]={A[i]} ,");
        }
        tiempoFinal.Start();
        int num;
        Console.WriteLine("\n");
        Console.WriteLine("Ingrese el valor a encontrar:");
        num = Convert.ToInt32(Console.ReadLine());
        int posicionEncontrada = busquedaBinaria(A, A.Length, num);
        Console.WriteLine($"elemento encontrado en A [{posicionEncontrada}]= {A[posicionEncontrada]}");
        tiempoFinal.Stop();
        Console.WriteLine("tiempo de ejecucion:" + tiempoFinal.Elapsed.TotalMilliseconds);
    }


    static int busquedaBinaria(int[] lista, int n, int clave)
    {
        int central, bajo = 0, alto = n - 1;
        int valorCentral;
        while (bajo <= alto)
        {
            central = (bajo + alto) / 2;
            /* indice de elemento central */
            valorCentral = lista[central];
            /* valor del indice central */
            if (lista[central] == clave)
                return central; /* encontrado, devuelve posicion */
            else if (clave < lista[central])
                alto = central - 1; /* ir a sublista inferior */
            else
                bajo = central + 1; /* ir a sublista superior */
        }
        return -1;
        /* elemento no encontrado */
    }

}
