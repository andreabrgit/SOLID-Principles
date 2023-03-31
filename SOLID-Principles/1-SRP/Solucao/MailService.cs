using System.Net.Mail;
using System.Net;

namespace SOLID_Principles.SRP.Solucao
{
  public interface IMailService
  {
    void SendMail();
  }

  public class MailService: IMailService
  {
    public void SendMail()
    {
      SmtpClient smtp = new SmtpClient();

      smtp.Host = "smtp.gmail.com";
      smtp.Port = 587;
      smtp.EnableSsl = true;
      smtp.UseDefaultCredentials = false;
      smtp.DeliveryMethod = SmtpDeliveryMethod.Network;
      smtp.Credentials = new NetworkCredential("mail@totvs.com.br",
        "password");

      using (var mensagem = new MailMessage())
      {
        mensagem.From = new MailAddress("rementente");
        mensagem.To.Add("destinatarios");
        mensagem.Subject = "assunto";
        mensagem.Body = "body";
        mensagem.IsBodyHtml = true;
        smtp.Send(mensagem);
      }
    }
  }
}
