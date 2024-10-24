using MePagaBack.Domain.Models.Base;

namespace MePagaBack.Domain.Models;

public class Divida : BaseModel
{
    public decimal Valor { get; private set; }
    public bool Quitada { get; private set; }

    public long DevedorId { get; private set; }
    public Devedor? Devedor { get; private set; }

    public Divida()
    {
    }

    public void DividaQuitada()
    {
        Atualizar();
        Quitada = false;
    }
}
