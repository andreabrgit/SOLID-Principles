﻿using MySql.Data.MySqlClient;
using System.Data;
using System.Data.SqlClient;

namespace SOLID_Principles.DIP.Solucao
{
  public interface IClienteRepository
  {
    void AdicionarCliente(Cliente cliente);
  }
  
  public class ClienteRepository : IClienteRepository
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

  public class ClienteMySQLRepository : IClienteRepository
  {
    public void AdicionarCliente(Cliente cliente)
    {
      try
      {
        var connectionString = "";

        string query = "INSERT INTO Cliente (Id, Nome) " +
                          "VALUES (@Id, @Nome)";

        using (MySqlConnection cn = new MySqlConnection(connectionString))
        using (MySqlCommand cmd = new MySqlCommand(query, cn))
        {
          cmd.Parameters.Add("@Id", MySqlDbType.VarChar, 50).Value = cliente.Id;
          cmd.Parameters.Add("@Nome", MySqlDbType.VarChar, 50).Value = cliente.Nome;

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
