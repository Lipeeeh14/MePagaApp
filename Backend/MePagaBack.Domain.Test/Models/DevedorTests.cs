using MePagaBack.Domain.ValueObjects;
using System.Text.RegularExpressions;

namespace MePagaBack.Domain.Test.Models;

public class DevedorTests
{
    [Theory]
    [InlineData(null)]
    [InlineData("")]
    public void DeveFalharQuandoEmailForNuloOuVazio(string email)
    {
        var error = "E-mail inválido.";

        void action() => new EmailValueObject(email);

        var exception = Assert.Throws<ArgumentNullException>(action);
        Assert.Equal(error, exception.ParamName);
    }

    [Fact]
    public void DeveFalharQuandoEmailForInvalido() 
    {
        var email = "testeemailinvalido";
        var error = "E-mail inválido.";

        void action() => new EmailValueObject(email);

        var exception = Assert.Throws<FormatException>(action);
        Assert.Contains(error, exception.Message);
    }

    [Fact]
    public void DevePassarQuandoEmailForValido()
    {
        var email = "teste@email.com";

        var emailVO = new EmailValueObject(email);

        Assert.NotNull(emailVO);
    }
}
