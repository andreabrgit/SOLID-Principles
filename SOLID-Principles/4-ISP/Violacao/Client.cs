namespace SOLID_Principles.ISP.Violacao
{
  public class Client
  {
    public void Print(IPrinterTasks print)
    {
      print.Print("Impressão");
      print.Scan("Documento");
    }

    public void EnviarFax(IPrinterTasks fax)
    {
      fax.Fax("Documento de Fax");
    }

    public void ImprimirDoisLados(IPrinterTasks printDuplexTasks)
    {
      printDuplexTasks.PrintDuplex("Impressão dos dois lados");
    }
  }
}
