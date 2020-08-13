using System.Collections.Generic;
using System.Linq;

namespace TesteCandidatoTriangulo
{
    public class Triangulo
    {
        /// <summary>
        ///    6
        ///   3 5
        ///  9 7 1
        /// 4 6 8 4
        /// Um elemento somente pode ser somado com um dos dois elementos da próxima linha. Como o elemento 5 na Linha 2 pode ser somado com 7 e 1, mas não com o 9.
        /// Neste triangulo o total máximo é 6 + 5 + 7 + 8 = 26
        /// 
        /// Seu código deverá receber uma matriz (multidimensional) como entrada. O triângulo acima seria: [[6],[3,5],[9,7,1],[4,6,8,4]]
        /// </summary>
        /// <param name="dadosTriangulo"></param>
        /// <returns>Retorna o resultado do calculo conforme regra acima</returns>
        public int ResultadoTriangulo(string dadosTriangulo)
        {

            /*
             * Tive dificuldade para converter manualmente a string 'dadosTriangulo' em array multidimensional e usei o pacote Newtonsoft.Json
             * Essa linha de conversão tirei de:
             * https://stackoverflow.com/questions/33822264/c-sharp-convert-string-to-a-two-dimensional-string-array
             * 
             * var result = Newtonsoft.Json.JsonConvert.DeserializeObject<string[][]>(foobarString);
             * 
             */
            var multiArray = Newtonsoft.Json.JsonConvert.DeserializeObject<List<List<int>>>(dadosTriangulo);

            List<int> valores = new List<int>();    // armazena a lista de valores encontrados para somar.
            int posicaoAnterior = 0;                // armazena a posição do último valor encontrado para soma.


            multiArray.ForEach(a =>
            {
                var v = a.Skip(posicaoAnterior).Take(2).Max();      // ignora o número de elementos antes da variável posicaoAnterior e recupera o número máximo entre os próximos 2 números.
                posicaoAnterior = a.IndexOf(v);                     // captura a posição do número encontrado
                valores.Add(v);
            });


            return valores.Sum();
        }
    }
}
