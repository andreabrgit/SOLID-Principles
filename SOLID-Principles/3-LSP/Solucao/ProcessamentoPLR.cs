namespace SOLID_Principles.LSP.Solucao
{
  public class ProcessamentoPLR
  {
    public static decimal CalculaPLR(ElegivelPLR elegivelPLR)
    {
      decimal salario = 1000;

      if (elegivelPLR.MultiplicadorPLR() == 0)
        throw new Exception("Valor esperado maior que zero.");

      return salario * elegivelPLR.MultiplicadorPLR();
    }
  }

  public interface ElegivelPLR
  {
    decimal MultiplicadorPLR();
  }

  public class Funcionario
  {

  }

  public class Gerente : Funcionario, ElegivelPLR
  {
    public decimal MultiplicadorPLR()
    {
      return 2;
    }
  }

  public class Estagiario : Funcionario
  {

  }
}
