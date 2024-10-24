using MePagaBack.Domain.Models.Base;

namespace MePagaBack.Domain.Models;

public class Devedor : BaseModel
{
    public string Nome { get; private set; } = string.Empty;
    public bool Ativa { get; set; } = true;

    public ICollection<Divida> Dividas { get; private set; } = [];

    public Devedor()
    {
    }

    public Devedor(string nome)
    {
        Nome = nome;
    }

    public Devedor(string nome, bool ativa)
    {
        Nome = nome;
        Ativa = ativa;
    }
}
