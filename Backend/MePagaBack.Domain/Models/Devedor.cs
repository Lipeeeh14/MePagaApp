using MePagaBack.Domain.Models.Base;

namespace MePagaBack.Domain.Models;

public class Devedor : BaseModel
{
    public string Nome { get; private set; } = string.Empty;
    public string? Email { get; private set; }
    public string NumeroTelefone { get; private set; } = string.Empty;

    public bool Ativa { get; set; } = true;

    public ICollection<Divida> Dividas { get; private set; } = [];

    public Devedor()
    {
    }

    public Devedor(string nome, string? email, string numeroTelefone)
    {
        Nome = nome;
        Email = email;
        NumeroTelefone = numeroTelefone;
    }

    public Devedor(string nome, string? email, string numeroTelefone, bool ativo)
    {
        Nome = nome;
        Email = email;
        NumeroTelefone = numeroTelefone;
        Ativa = ativo;
    }

    public void Atualizar(string nome, string? email, string numeroTelefone, bool ativo) 
    {
        Nome = nome;
        Email = email;
        NumeroTelefone = numeroTelefone;
        Ativa = ativo;
    }
}
