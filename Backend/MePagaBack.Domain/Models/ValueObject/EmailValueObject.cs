using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MePagaBack.Domain.Models.ValueObject;

public class EmailValueObject
{
    public string Email { get; private set; } = string.Empty;

    public EmailValueObject(string email)
    {
        Validate(email);
        Email = email;
    }

    private void Validate(string email) 
    {
        if (string.IsNullOrEmpty(email))
            throw new ArgumentNullException(nameof(Email));
    }
}
