namespace SOLID_Principles.ISP.Solucao
{
  public class Client
  {
    public void Print(IPrinterTasks print)
    {
      print.Print("Impressão");
      print.Scan("Documento");
    }

    public void EnviarFax(IFaxTasks fax)
    {
      fax.Fax("Documento do Fax");
    }

    public void ImprimirDoisLados(IPrintDuplexTasks printDuplexTasks)
    {
      printDuplexTasks.PrintDuplex("Impressão dos dois lados");
    }
  }
}
