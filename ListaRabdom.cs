//namespace Lab03_Search;
namespace System.Diagnostics;
class ListaRandom
{
    static void Main(string[] args)
    {
        Stopwatch tiempoInicio = new Stopwatch();
        Stopwatch tiempoFinal = new Stopwatch();

        Random random1 = new Random();
        int[] lista = new int[100];
        int[] lista2 = new int[50];
        List<int> elementosComunes = new List<int>();
        int aux1=0,aux2=0, porcentajeExito=0, porcentajeFallido=0;

        tiempoInicio.Start();
        tiempoInicio.Stop();
        Console.WriteLine("tiempo de inicio:" + tiempoInicio.Elapsed.TotalMilliseconds);


        tiempoFinal.Start();
        Console.WriteLine("\nConjunto de 100 elementos:\n");
        for (int i = 0; i < 100; i++)
        {
            lista[i] = random1.Next(1, 201);

        }
        for (int i = 0; i < 100; i++)
        {
            Console.Write($"A[{i + 1}]={lista[i]}, ");
        }

        Console.WriteLine("\n\nConjunto de 50 elementos:\n");

        for (int j = 0; j < 50; j++)
        {
            lista2[j] = random1.Next(1, 201);

        }
        for (int j = 0; j < 50; j++)
        {
            Console.Write($"A[{j + 1}]={lista2[j]}, ");

        }
        
        foreach (int elemento in lista)
        {
            
            if (lista2.Contains(elemento))
            {
                elementosComunes.Add(elemento);
                aux1++;
            }else{
                aux2++;
            }
        }

        porcentajeExito=(aux1*100)/50;
        porcentajeFallido=((aux2-50)*100)/50;

        Console.WriteLine("\n\nBusquedas con exito: "+aux1);
        Console.WriteLine("Busquedas fallidas: "+(aux2-50));
        Console.WriteLine("Existe el: "+porcentajeExito+"% de exito y el "+porcentajeFallido+"% de fallas");

        Console.WriteLine("\nElementos comunes:");
        elementosComunes.Sort();
        for (int j = 0; j < 50; j++)
        {
            Console.Write($"{elementosComunes[j]}, ");

        }
        tiempoFinal.Stop();
        Console.WriteLine("tiempo de ejecucion:" + tiempoFinal.Elapsed.TotalMilliseconds);
    }
}
