namespace SOLID_Principles.OCP.Violacao
{
  public class CalculadoraDeSalario
  {
    private readonly IEnumerable<DesenvolvedorRelatorio> _desenvolvedorRelatorios;
    public CalculadoraDeSalario(List<DesenvolvedorRelatorio> desenvolvedorRelatorios)
    {
      _desenvolvedorRelatorios = desenvolvedorRelatorios;
    }
    public double CalcularTotalSalarios()
    {
      double totalSalarios = 0D;
      foreach (var devRelatorio in _desenvolvedorRelatorios)
      {
        totalSalarios += devRelatorio.TaxaDaHora * devRelatorio.HorasDeTrabalho;

        //if (devRelatorio.Nivel == "Senior developer")
        //{
        //  totalSalarios += devRelatorio.TaxaDaHora * devRelatorio.HorasDeTrabalho * 1.2;
        //}
        //else
        //{
        //  totalSalarios += devRelatorio.TaxaDaHora * devRelatorio.HorasDeTrabalho;
        //}
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
}
