using System;

namespace ImpostodeRenda
{
    public class Imposto_de_Renda
    {
        public string CalcularImposto(double salario)
        {
            string calculo;
            double totalimposto;
            double deducao;
            if (salario <= 1903.98)
            {
                string insento = "Você está insento";
                return insento;
            }
            else if (salario > 1903.98 && salario <= 2826.65)
            {
                deducao = 142.80;
                totalimposto = (salario / 100 * 7.5) - deducao;
                calculo = $"Será deduzido o valor de {Math.Round(totalimposto, 2)}";
                return calculo;
            }
            else if (salario > 2826.66 && salario <= 3751.05)
            {
                deducao = 354.80;
                totalimposto = (salario / 100 * 15) - deducao;
                calculo = $"Será deduzido o valor de {Math.Round(totalimposto, 2)}";
                return calculo;
            }
            else if (salario > 3751.06 && salario <= 4664.68)
            {
                deducao = 636.13;
                totalimposto = (salario / 100 * 22.5) - deducao;
                calculo = $"Será deduzido o valor de {Math.Round(totalimposto, 2)}";
                return calculo;
            }
            else
            {
                deducao = 869.36;
                totalimposto = (salario / 100 * 27.5) - deducao;
                calculo = $"Será deduzido o valor de {Math.Round(totalimposto, 2)}";
                return calculo;
            }
        }
    }
}