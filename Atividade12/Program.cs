using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atividade12
{
    internal class Program
    {
// Dados três valores X, Y, Z, verifiquem se eles podem ser os comprimentos dos lados de um triângulo
// e se forem escrever uma mensagem informando se é um triângulo eqüilátero, isósceles ou escaleno.
//Observações:
//O comprimento de um lado do triângulo é sempre menor do que a soma dos outros dois.
//•Eqüilátero: Todos os lados iguais
//•Isósceles: Dois lados iguais
//•Escaleno: Todos os lados diferentes

        static void Main(string[] args)
        {
            traingulo triangulo = new traingulo();
            Console.WriteLine("Digite o valor de X");
            triangulo.x = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite o valor de y");
            triangulo.y = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite o valor de z");
            triangulo.z = int.Parse(Console.ReadLine());
            Console.WriteLine(triangulo.ReceberTexto());
            Console.ReadLine();
            


        }
    }
}
