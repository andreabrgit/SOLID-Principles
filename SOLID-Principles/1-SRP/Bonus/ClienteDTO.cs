namespace SOLID_Principles.SRP.Bonus
{
  public class ClienteDTO //Falar sobre DRY
  {
    public string Id { get; set; }

    public string Nome { get; private set; }
  }

  public class ClienteCadastroDTO
  {
    public string Id { get; set; }

    public string Nome { get; private set; }
  }

  public class ClienteFinanceiroDTO
  {
    public string Id { get; set; }

    public string Nome { get; private set; }

    //public decimal Saldo { get; private set; }
  }
}
