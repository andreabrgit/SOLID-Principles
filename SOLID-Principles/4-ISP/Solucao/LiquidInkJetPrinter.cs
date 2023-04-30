namespace SOLID_Principles.ISP.Solucao
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
  }
}
