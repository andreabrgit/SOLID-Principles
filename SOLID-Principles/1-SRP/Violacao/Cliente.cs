using System.Data;
using System.Data.SqlClient;
using System.Net;
using System.Net.Mail;

namespace SOLID_Principles.SRP.Violacao
{
  public class Cliente
  {
    public string Id { get; private set; }

    public string Nome { get; private set; }

    public Cliente(string id, string nome)
    {
      Id = id;
      Nome = nome;
    }

    public void AdicionarCliente()
    {
      try
      {
        if (Nome.Length > 20)
          throw new Exception("O nome do cliente não pode ter mais do que 20 caracteres");

        var connectionString = "";

        string query = "INSERT INTO Cliente (Id, Nome) " +
                          "VALUES (@Id, @Nome)";

        using (SqlConnection cn = new SqlConnection(connectionString))
        using (SqlCommand cmd = new SqlCommand(query, cn))
        {
          cmd.Parameters.Add("@Id", SqlDbType.VarChar, 50).Value = Id;
          cmd.Parameters.Add("@Nome", SqlDbType.VarChar, 50).Value = Nome;

          cn.Open();
          cmd.ExecuteNonQuery();
          cn.Close();
        }

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
      catch { }
    }
  }
}
