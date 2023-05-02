namespace SOLID_Principles.OCP.Solucao
{
  public class OperacaoFinanceira
  {
    public void RealizarDebito(DebitoConta debitoConta)
    {
      debitoConta.Debitar(5, "1234");
    }
  }
  
  public abstract class DebitoConta
  {
    public string NumeroTransacao { get; set; }
    public abstract string Debitar(decimal valor, string conta);

    public string FormatarTransacao()
    {
      const string chars = "ABCasDEFGHIJKLMNOPQRSTUVWXYZ0123456789";
      var random = new Random();
      NumeroTransacao = new string(Enumerable.Repeat(chars, 15)
        .Select(s => s[random.Next(s.Length)]).ToArray());

      // Numero de transacao formatado
      return NumeroTransacao;
    }
  }
}
