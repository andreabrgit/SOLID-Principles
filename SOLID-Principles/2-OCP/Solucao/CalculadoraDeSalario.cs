namespace SOLID_Principles.OCP.Solucao
{
  public class CalculadoraDeSalario
  {
    private readonly IEnumerable<CalculadoraSalarioBase> _desenvolvedorCalculadoras;
    public CalculadoraDeSalario(List<CalculadoraSalarioBase> desenvolvedorCalculadoras)
    {
      _desenvolvedorCalculadoras = desenvolvedorCalculadoras;
    }
    public double CalcularTotalSalarios()
    {
      double totalSalarios = 0D;
      foreach (var devCalculadora in _desenvolvedorCalculadoras)
      {
        totalSalarios += devCalculadora.CalculaSalario();
      }
      return totalSalarios;
    }
  }

  public class DesenvolvedorRelatorio
  {
    public int Id { get; set; }
    public string Nome { get; set; }
    public string Nivel { get; set; }
    public int HorasDeTrabalho { get; set; }
    public double TaxaDaHora { get; set; }
  }

  public abstract class CalculadoraSalarioBase
  {
    protected DesenvolvedorRelatorio DesenvolvedorRelatorio { get; private set; }
    public CalculadoraSalarioBase(DesenvolvedorRelatorio desenvolvedorRelatorio)
    {
      DesenvolvedorRelatorio = desenvolvedorRelatorio;
    }
    public abstract double CalculaSalario();
  }

  public class SeniorCalculadoraSalario : CalculadoraSalarioBase
  {
    public SeniorCalculadoraSalario(DesenvolvedorRelatorio report)
        : base(report)
    {
    }
    public override double CalculaSalario() => DesenvolvedorRelatorio.TaxaDaHora * DesenvolvedorRelatorio.HorasDeTrabalho * 1.2;
  }

  public class JuniorCalculadoraSalario : CalculadoraSalarioBase
  {
    public JuniorCalculadoraSalario(DesenvolvedorRelatorio report)
        : base(report)
    {
    }
    public override double CalculaSalario() => DesenvolvedorRelatorio.TaxaDaHora * DesenvolvedorRelatorio.HorasDeTrabalho;
  }
}
