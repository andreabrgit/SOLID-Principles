namespace SOLID_Principles.SRP.Solucao
{
  public class Cliente
  {
    public string Id { get; private set; }

    public string Nome { get; private set; }

    public Cliente(string id, string nome)
    {
      Id = id;
      Nome = nome;
    }

    public void ValidarCliente()
    {
      if (Nome.Length > 30)
        throw new Exception("O nome do cliente não pode ter mais do que 20 caracteres");
    }

  }
}
