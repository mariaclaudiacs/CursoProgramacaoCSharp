using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AulasCSharp
{
    public enum Operadores
    {
        Soma = 1,
        Subtracao = 2,
        Multiplicacao = 3,
        Divisao = 4,
        Raiz = 5,
        Elevar = 6,
        AreaTriangulo = 7,
        AreaCubo = 8,
        AreaCirculo = 9,
    }

    internal class Calculadora_230822
    {
        internal double Soma(double valor1, double valor2)
        {
            return valor1 + valor2;
        }

        internal double Subtracao(double valor1, double valor2)
        {
            return valor1 - valor2;
        }

        internal double Multiplicao(double valor1, double valor2)
        {
            return valor1 * valor2;
        }

        internal double Divisao(double valor1, double valor2)
        {
            return valor1 / valor2;
        }

        internal double Elevar(double valor, double expoente)
        {
            return Math.Pow(valor, expoente);
        }

        internal double Raiz(double valor)
        {
            return Math.Sqrt(valor);
        }

        internal double AreaCubo(double areaFace)
        {
            return (6 * Math.Pow(areaFace, 2));
        }

        internal double AreaTriangulo(double comprimento, double altura)
        {
            return (comprimento * altura) / 2;
        }

        internal double AreaCirculo(double raio)
        {
            return Math.Pow(raio, 2) * Math.PI;
        }
    }
}
