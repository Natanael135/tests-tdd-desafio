using Calculadora.Models;
namespace Testes;

public class UnitTest1
{
    [Theory]
    [InlineData(1, 2, 3)]
    [InlineData(25, 25, 50)]
    public void TesteFuncaoSomar(int num1, int num2, int result)
    {
        CalculadoraImp calc = new CalculadoraImp();
        int resultadoCalculadora = calc.Somar(num1, num2);
        Assert.Equal(result, resultadoCalculadora);
    }
    [Theory]
    [InlineData(2, 1, 1)]
    [InlineData(30, 20, 10)]
    public void TesteFuncaoSubtrair(int num1, int num2, int result)
    {
        CalculadoraImp calc = new CalculadoraImp();
        int resultadoCalculadora = calc.Subtrair(num1, num2);
        Assert.Equal(result, resultadoCalculadora);
    }
    [Theory]
    [InlineData(1, 2, 2)]
    [InlineData(5, 5, 25)]
    public void TesteFuncaoMultiplicar(int num1, int num2, int result)
    {
        CalculadoraImp calc = new CalculadoraImp();
        int resultadoCalculadora = calc.Multiplicar(num1, num2);
        Assert.Equal(result, resultadoCalculadora);
    }
    [Theory]
    [InlineData(3, 3, 1)]
    [InlineData(20, 20, 1)]
    public void TesteFuncaoDividir(int num1, int num2, int result)
    {
        CalculadoraImp calc = new CalculadoraImp();
        int resultadoCalculadora = calc.Dividir(num1, num2);
        Assert.Equal(result, resultadoCalculadora);
    }
    [Fact]
    public void TesteFuncaoDividirPor0()
    {
        CalculadoraImp calc = new CalculadoraImp();
        Assert.Throws<DivideByZeroException>(() => calc.Dividir(3, 0));
    }
}