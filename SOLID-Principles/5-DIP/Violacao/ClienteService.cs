namespace SOLID_Principles.DIP.Violacao
{ 
  public class ClienteService
  {
    private readonly ClienteRepository _clienteRepository = new ClienteRepository();
    private readonly MailService _mailService = new MailService();

    public void AdicionarCliente(Cliente cliente)
    {
      try
      {
        cliente.ValidarCliente();

        _clienteRepository.AdicionarCliente(cliente);

        _mailService.SendMail();
      }
      catch { }
    }

  }
}
