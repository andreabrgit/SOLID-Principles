namespace SOLID_Principles.OCP.Solucao
{
  public class DebitoContaPoupanca : DebitoConta
  {
    public override string Debitar(decimal valor, string conta)
    {
      // Valida Aniversário da Conta
      // Debita Poupança
      return FormatarTransacao();
    }
  }
}
