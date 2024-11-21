using System;
using System.Threading.Tasks;

namespace TasksOperaciones
{
    internal class Program
    {
        static async Task Main(string[] args)
        {
            Console.WriteLine("Digite el primer valor a calcular");
            int x = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite el segundo valor a calcular:");
            int y = int.Parse(Console.ReadLine());

            Task<int> SumTasks = Task.Run(() =>
            {
               
                Task.Delay(1000).Wait();  
                return x + y;

            });

            Task<int> RestaTasks = Task.Run(() =>
            {
                Task.Delay(1000).Wait();
                return x - y;

            });

            Task<int> MultiplicacionTasks = Task.Run(() =>
            {
                Task.Delay(1000).Wait();
                return x * y;

            });
            Task<int> DivisiónTasks = Task.Run(() =>
            {
                Task.Delay(1000).Wait();
                return x % y;

            });


            int suma = await SumTasks;
            int resta = await RestaTasks;
            int multiplicación = await MultiplicacionTasks;
            int división = await DivisiónTasks;

            
            Console.WriteLine($"El resultado de la suma es: {suma}");
            Console.WriteLine($"El resultado de la resta es: {resta}");
            Console.WriteLine($"El resultado de la multiplicación es: {multiplicación}");
            Console.WriteLine($"El resultado de la división es: {división}");




            Console.WriteLine("Fin del programa.");
        }
    }
}