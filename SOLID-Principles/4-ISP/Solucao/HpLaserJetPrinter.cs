﻿namespace SOLID_Principles.ISP.Solucao
{
  public class HpLaserJetPrinter : IPrinterTasks, IFaxTasks, IPrintDuplexTasks
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
      Console.WriteLine(FaxContent);
    }

    public void PrintDuplex(string PrintDuplexContent)
    {
      Console.WriteLine(PrintDuplexContent);
    }
  }
}
