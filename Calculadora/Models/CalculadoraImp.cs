namespace Calculadora.Models
{
    public class CalculadoraImp
    {
        public int Somar(int numero1, int numero2)
        {
            int result = numero1 + numero2;
            return result;

        }
        public int Subtrair(int numero1, int numero2)
        {
            int result = numero1 - numero2;
            return result;

        }
        public int Multiplicar(int numero1, int numero2)
        {
            int result = numero1 * numero2;
            return result;
        }
        public int Dividir(int numero1, int numero2)
        {
            int result = numero1 / numero2;
            return result;
        }
    }
}
