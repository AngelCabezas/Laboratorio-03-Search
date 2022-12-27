//namespace Lab03_Search;
namespace System.Diagnostics;
class Program
{
    static void Main1(string[] args)
    {
        Stopwatch tiempoInicio = new Stopwatch();
        Stopwatch tiempoFinal = new Stopwatch();

        tiempoInicio.Start();
        tiempoInicio.Stop();
        Console.WriteLine("tiempo de inicio:" + tiempoInicio.Elapsed.TotalMilliseconds);


        Console.WriteLine("BUSQUEDA LINEAL");
        int[] A = { 79, 21, 15, 99, 88, 65, 75, 85, 76, 46, 84, 24, 40, 23, 12, 57, 88, 99, 102, 23 };

        Console.WriteLine("Arreglo desordenado");
        for (int i = 0; i < A.Length; i++)
        {
            Console.WriteLine($"A[{i}]={A[i]}");
        }

        tiempoFinal.Start();
        int num;
        Console.WriteLine("Ingrese el valor a encontrar:");
        num = Convert.ToInt32(Console.ReadLine());
        int posicionEncontrada = BusquedaLinealID(A, A.Length, num);
        Console.WriteLine($"elemento encontrado en A [{posicionEncontrada}]= {A[posicionEncontrada]}");
        tiempoFinal.Stop();
        Console.WriteLine("tiempo de ejecucion:" + tiempoFinal.Elapsed.TotalMilliseconds);

        static int BusquedaLinealID(int[] A, int n, int clave)
        {
            int i;
            for (i = 0; i < n; i++)
                if (A[i] == clave)
                    return i;
            return -1;
        }
    }
}
