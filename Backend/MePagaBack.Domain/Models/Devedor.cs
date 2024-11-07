using MePagaBack.Domain.Models.Base;
using MePagaBack.Domain.ValueObjects;

namespace MePagaBack.Domain.Models;

public class Devedor : BaseModel
{
    public string Nome { get; private set; } = string.Empty;
    public EmailValueObject? Email { get; private set; }
    public string NumeroTelefone { get; private set; } = string.Empty;

    public bool Ativa { get; set; } = true;

    public ICollection<Divida> Dividas { get; private set; } = [];

    public Devedor()
    {
    }

    public Devedor(string nome, string? email, string numeroTelefone)
    {
        Nome = nome;
        NumeroTelefone = numeroTelefone;
        
        AtribuirEmail(email);
    }

    public Devedor(string nome, string? email, string numeroTelefone, bool ativo)
    {
        Nome = nome;
        NumeroTelefone = numeroTelefone;
        Ativa = ativo;

        AtribuirEmail(email);
    }

    public void Atualizar(string nome, string? email, string numeroTelefone, bool ativo) 
    {
        Nome = nome;
        NumeroTelefone = numeroTelefone;
        Ativa = ativo;

        Atualizar();
        AtribuirEmail(email);
    }

    public void AtribuirEmail(string? email) => 
        Email = !string.IsNullOrEmpty(email) ? new(email) : null;
}
