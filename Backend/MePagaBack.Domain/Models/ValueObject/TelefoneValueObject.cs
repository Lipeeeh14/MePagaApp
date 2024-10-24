namespace MePagaBack.Domain.Models.ValueObject;

public class TelefoneValueObject
{
    public string Numero { get; private set; } = string.Empty;

    public TelefoneValueObject(string numero)
    {
        Validate(numero);
        Numero = numero;
    }

    public void Validate(string numero) 
    {
        if (string.IsNullOrEmpty(numero))
            throw new ArgumentNullException(nameof(Numero));
    }
}
