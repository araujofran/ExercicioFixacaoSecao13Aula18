using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Globalization; 

namespace ExercicioFixacaoSecao13Aula18
{
    internal class Program
    {
        static void Main(string[] args)
        {

            string produto1 = "Computador";
            string produto2 = "Mesa de escritório";
            byte idade = 30;
            int codigo = 5290;
            char genero = 'M';
            double preco1 = 2100.0;
            double preco2 = 650.500;
            double medida = 53.234567;


            Console.WriteLine("Produtos:");

            Console.WriteLine();

            Console.WriteLine( produto1 + ", cujo preço é R$ " + preco1 );
            Console.WriteLine( produto2 + ", cujo preço é R$ " + preco2);
            Console.WriteLine("Registro: " + idade + " anos de idade,código " + codigo + " e gênero :" + genero);

            Console.WriteLine("O valor da medida imprensa com 8 casas depois da vírgula "+ medida.ToString ("F8"));
            Console.WriteLine("O valor da medida imprensa com arredondamento de 3 casas depois da vírgula " + medida.ToString("F3"));
            Console.WriteLine("Separador decimal invariant culture aplicando na pratica " + medida.ToString("F8", CultureInfo.InvariantCulture));
            Console.WriteLine("Separador decimal invariant culture aplicando na pratica " + medida.ToString("F2", CultureInfo.InvariantCulture));

            Console.WriteLine("Abaixo Correção do Professor :");
            Console.WriteLine();

            Console.WriteLine("Produtos:");
            Console.WriteLine("{0}, cujo preço é $ {1:F2}", produto1, preco1);
            Console.WriteLine("{0}, cujo preco é $ {1:F2}", produto2, preco2);
            Console.WriteLine();
            Console.WriteLine("Registro: {0} anos de idade, código {1} e gênero: {2}", idade, codigo, genero);
            Console.WriteLine();
            Console.WriteLine("Medida com oito casas decimais: {0:F8}", medida);
            Console.WriteLine("Arredondado (três casas decimais): {0:F3}", medida);
            Console.WriteLine("Separador decimal invariant culture: " + medida.ToString("F3", CultureInfo.InvariantCulture));
        }
    }
}
