namespace Dojo_19
{
    public class IngressoVip : Ingresso
    {
        public float ValorVip=200;

        public void MostrarValorVip()
        {
            float resultado = Valor + ValorVip;
            System.Console.WriteLine("Valor do ingresso vip é: {0:c}",resultado);
        }
    }
}