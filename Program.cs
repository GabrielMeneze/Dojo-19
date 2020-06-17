using System;

namespace Dojo_19
{
    class Program
    {                              
        static void Main(string[] args)
        {
            IngressoVip ing2 = new IngressoVip();
            Ingresso ing = new Ingresso();
            IngressoInfantil ing3 = new IngressoInfantil();
            ing.Valor = 110;                                   
            ing2.ValorVip = 90;
            ing3.IngressoInfan = 55;
            ing.MostrarValor();
            ing2.MostrarValorVip();
            ing3.MostrarInfan();
        }
    }
}
