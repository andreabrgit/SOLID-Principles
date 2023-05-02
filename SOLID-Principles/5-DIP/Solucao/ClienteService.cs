namespace SOLID_Principles.DIP.Solucao
{
  public interface IClienteService
  {
    void AdicionarCliente(Cliente cliente);
  }
  
  public class ClienteService
  {
    private readonly IClienteRepository _clienteRepository;
    private readonly IMailService _mailService;

    public ClienteService(IClienteRepository clienteRepository, IMailService mailService)
    {
      _clienteRepository = clienteRepository;
      _mailService = mailService;
    }

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
