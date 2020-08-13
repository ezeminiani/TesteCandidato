using System;

namespace TesteCandidatoTriangulo
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                var resultado = new Triangulo().ResultadoTriangulo("[[6],[3,5],[9,7,1],[4,6,8,4]]");
                Console.WriteLine($"Resultado do triangulo: {resultado}");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Falha na execução do método ResultadoTriangulo: ", ex.Message);
            }

            Console.ReadLine();

        }
    }
}
