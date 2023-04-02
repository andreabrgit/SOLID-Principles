namespace SOLID_Principles.LSP.Violacao
{
  public class ProcessamentoMensal
  {
    public static decimal CalculaPLR(Funcionario funcionario)
    {
      decimal salario = 1000;

      if (funcionario.MultiplicadorPLR() == 0)
        throw new Exception("Valor esperado maior que zero.");

      return salario * funcionario.MultiplicadorPLR();
    }
  }

  public class Funcionario
  {
    public virtual decimal MultiplicadorPLR()
    {
      return 1;
    }
  }

  public class Gerente : Funcionario
  {
    public override decimal MultiplicadorPLR()
    {
      return 2;
    }
  }

  public class Estagiario : Funcionario
  {
    public override decimal MultiplicadorPLR()
    {
      //throw new NotImplementedException();
      //return 0;
      return 2;
    }
  }
}
