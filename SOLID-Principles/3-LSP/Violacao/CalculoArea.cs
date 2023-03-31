namespace SOLID_Principles.LSP.Violacao
{
  public class CalculoArea
  {

    public static string TestarCalcularAreaRetangulo(Retangulo retangulo)
    {
      Retangulo retanguloMock = new Retangulo();
      retanguloMock.Altura = 5;
      retanguloMock.Largura = 4;
      return $"A área deve ser igual a {retanguloMock.Largura * retanguloMock.Altura}. O cálculo é igual a {retangulo.CalculaArea()}";
    }
  }

  public class Retangulo
  {
    public virtual int Altura { get; set; }
    public virtual int Largura { get; set; }
    public virtual int CalculaArea()
    {
      return Altura * Largura;
    }
  }

  public class Quadrado : Retangulo
  {
    public override int Altura 
    { 
      set => base.Altura = base.Largura = value; 
    }

    public override int Largura
    {
      set => base.Largura = base.Altura = value;
    }

    public override int CalculaArea()
    {
      return Altura * Largura;
    }
  }
}
