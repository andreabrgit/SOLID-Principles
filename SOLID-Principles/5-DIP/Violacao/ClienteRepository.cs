using System.Data;
using System.Data.SqlClient;

namespace SOLID_Principles.DIP.Violacao
{ 
  public class ClienteRepository
  {
    public void AdicionarCliente(Cliente cliente)
    {
      try
      {
        var connectionString = "";

        string query = "INSERT INTO Cliente (Id, Nome) " +
                          "VALUES (@Id, @Nome)";

        using (SqlConnection cn = new SqlConnection(connectionString))
        using (SqlCommand cmd = new SqlCommand(query, cn))
        {
          cmd.Parameters.Add("@Id", SqlDbType.VarChar, 50).Value = cliente.Id;
          cmd.Parameters.Add("@Nome", SqlDbType.VarChar, 50).Value = cliente.Nome;

          cn.Open();
          cmd.ExecuteNonQuery();
          cn.Close();
        }
      }
      catch (Exception)
      {
        
      }
    }
  }
}
