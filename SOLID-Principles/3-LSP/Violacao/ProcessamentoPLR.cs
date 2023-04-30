namespace SOLID_Principles.LSP.Violacao
{
  public class ProcessamentoPLR
  {
    public static decimal CalculaPLR(Funcionario funcionario)
    {
      decimal salario = 1000;

      if (funcionario.MultiplicadorPLR() == 0)
        throw new Exception("Valor esperado maior que zero.");

      return salario * funcionario.MultiplicadorPLR();
    }

    //public static decimal CalculaPLR(Funcionario funcionario)
    //{
    //  decimal salario = 1000;

    //  if ((int)funcionario.MultiplicadorPLR() == 0)
    //    throw new Exception("Valor esperado maior que zero.");

    //  return salario * (int)funcionario.MultiplicadorPLR();
    //}
  }

  public class Funcionario
  {
    public virtual decimal MultiplicadorPLR()
    {
      return 1;
    }
  }

  //public class Funcionario
  //{
  //  public virtual object MultiplicadorPLR()
  //  {
  //    return 1;
  //  }
  //}

  public class Gerente : Funcionario
  {
    public override decimal MultiplicadorPLR()
    {
      return 2;
    }
  }

  //public class Gerente : Funcionario
  //{
  //  public override object MultiplicadorPLR()
  //  {
  //    return "abc";
  //  }
  //}

  public class Estagiario : Funcionario
  {
    public override decimal MultiplicadorPLR()
    {
      //throw new NotImplementedException();
      //return 0;
      return 2;
    }
  }

  //public class Estagiario : Funcionario
  //{
  //  public override object MultiplicadorPLR()
  //  {
  //    //throw new NotImplementedException();
  //    //return 0;
  //    return 2;
  //  }
  //}
}
