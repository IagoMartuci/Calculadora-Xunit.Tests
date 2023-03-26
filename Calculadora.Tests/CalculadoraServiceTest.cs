namespace Calculadora.Tests;
public class CalculadoraServiceTest
{
    // TDD: Todos os testes devem ser feitos antes da programacao dos metodos
    [Fact]
    public void SomaDoisNumeros()
    {
        var primeiroNum = 10;
        var segundoNum = 5;
        var resultado = CalculadoraService.Soma(primeiroNum, segundoNum);
        Assert.Equal(15, resultado);
    }

    [Fact]
    public void SomaNumeroNegativoComNumeroPositivo()
    {
        var primeiroNum = -10;
        var segundoNum = 5;
        var resultado = CalculadoraService.Soma(primeiroNum, segundoNum);
        Assert.Equal(-5, resultado);
    }

    [Fact]
    public void SomaDoisNumerosNegativos()
    {
        var primeiroNum = -10;
        var segundoNum = -5;
        var resultado = CalculadoraService.Soma(primeiroNum, segundoNum);
        Assert.Equal(-15, resultado);
    }

    [Fact]
    public void SubtracaoDoisNumeros()
    {
        var primeiroNum = 10;
        var segundoNum = 5;
        var resultado = CalculadoraService.Subtracao(primeiroNum, segundoNum);
        Assert.Equal(5, resultado);
    }

    [Fact]
    public void SubtracaoNumeroNegativoComNumeroPositivo()
    {
        var primeiroNum = -10;
        var segundoNum = 5;
        var resultado = CalculadoraService.Subtracao(primeiroNum, segundoNum);
        Assert.Equal(-15, resultado);
    }

    [Fact]
    public void SubtracaoDoisNumerosNegativos()
    {
        var primeiroNum = -10;
        var segundoNum = -5;
        var resultado = CalculadoraService.Subtracao(primeiroNum, segundoNum);
        Assert.Equal(-5, resultado);
    }

    [Fact]
    public void MultiplicacaoDoisNumeros()
    {
        var primeiroNum = 2.0;
        var segundoNum = 5.0;
        var resultado = CalculadoraService.Multiplicacao(primeiroNum, segundoNum);
        Assert.Equal(10.0, resultado);
    }

    [Fact]
    public void MultiplicacaoNumeroNegativoComNumeroPositivo()
    {
        var primeiroNum = -2.0;
        var segundoNum = 5.0;
        var resultado = CalculadoraService.Multiplicacao(primeiroNum, segundoNum);
        Assert.Equal(-10.0, resultado);
    }

    [Fact]
    public void MultiplicacaoDoisNumerosNegativos()
    {
        var primeiroNum = -2.0;
        var segundoNum = -5.0;
        var resultado = CalculadoraService.Multiplicacao(primeiroNum, segundoNum);
        Assert.Equal(10.0, resultado);
    }

    [Fact]
    public void DivisaoDoisNumeros()
    {
        var primeiroNum = 10.0;
        var segundoNum = 2.0;
        var resultado = CalculadoraService.Divisao(primeiroNum, segundoNum);
        Assert.Equal(5.0, resultado);
    }

    [Fact]
    public void DivisaoNumeroNegativoComNumeroPositivo()
    {
        var primeiroNum = -10.0;
        var segundoNum = 2.0;
        var resultado = CalculadoraService.Divisao(primeiroNum, segundoNum);
        Assert.Equal(-5.0, resultado);
    }

    [Fact]
    public void DivisaoDoisNumerosNegativos()
    {
        var primeiroNum = -10.0;
        var segundoNum = -2.0;
        var resultado = CalculadoraService.Divisao(primeiroNum, segundoNum);
        Assert.Equal(5.0, resultado);
    }
}