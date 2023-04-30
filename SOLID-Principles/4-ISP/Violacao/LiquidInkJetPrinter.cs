namespace SOLID_Principles.ISP.Violacao
{
  public class LiquidInkJetPrinter : IPrinterTasks
  {
    public void Print(string PrintContent)
    {
      Console.WriteLine(PrintContent);
    }

    public void Scan(string ScanContent)
    {
      Console.WriteLine(ScanContent);
    }

    public void Fax(string FaxContent)
    {
      Console.WriteLine("Não tem essa funcionalidade");
    }

    public void PrintDuplex(string PrintDuplexContent)
    {
      throw new NotImplementedException();
    }
  }
}
