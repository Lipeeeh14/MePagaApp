using System.Net.Mail;
using System.Text.RegularExpressions;

namespace MePagaBack.Domain.ValueObjects;

public class EmailValueObject
{
    public string Email { get; private set; }

    private string EMAIL_REGEX = new("^\\S+@\\S+\\.\\S+$");

    public EmailValueObject(string email)
    {
        if (string.IsNullOrEmpty(email)) 
            throw new ArgumentNullException("E-mail inválido.");

        ValidarEmail(email);
        Email = email;
    }

    private void ValidarEmail(string email) 
    {
        Regex validateEmailRegex = new(EMAIL_REGEX);

        var isValid = validateEmailRegex.IsMatch(email);

        if (!isValid)
            throw new FormatException("E-mail inválido.");
    }
}
