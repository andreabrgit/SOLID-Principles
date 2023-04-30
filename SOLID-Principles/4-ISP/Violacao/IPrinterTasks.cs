namespace SOLID_Principles.ISP.Violacao
{
  public interface IPrinterTasks
  {
    void Print(string PrintContent);
    void Scan(string ScanContent);
    void Fax(string FaxContent);
    void PrintDuplex(string PrintDuplexContent);
  }
}
