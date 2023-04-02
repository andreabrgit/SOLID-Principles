using SOLID_Principles.SRP.Solucao;
using ViolacaoSRP = SOLID_Principles.SRP.Violacao;
using ViolacaoOCP = SOLID_Principles.OCP.Violacao;
using ViolacaoLSP = SOLID_Principles.LSP.Violacao;
using SOLID_Principles.OCP.Solucao;
using SOLID_Principles.LSP.Solucao;

string opcao = string.Empty;

while (opcao.ToUpper() != "Q")
{
  Console.WriteLine("1 - Single Responsibility Principle - Violação");
  Console.WriteLine("2 - Single Responsibility Principle - Violação Melhorada");
  Console.WriteLine("3 - Single Responsibility Principle - Solução");
  Console.WriteLine("--------------------------------------------------------");
  Console.WriteLine("4 - Open-closed Principle - Violação");
  Console.WriteLine("5 - Open-closed Principle - Solução");
  Console.WriteLine("--------------------------------------------------------");
  Console.WriteLine("6 - Liskov Substitution Principle - Violação");
  Console.WriteLine("7 - Liskov Substitution Principle - Solução");
  Console.WriteLine("--------------------------------------------------------");
  Console.WriteLine("8 - Interface Segregation Principle - Violação");
  Console.WriteLine("9 - Interface Segregation Principle - Solução");
  Console.WriteLine("--------------------------------------------------------");
  Console.WriteLine("10 - Dependency Inversion Principle - Violação");
  Console.WriteLine("11 - Dependency Inversion Principle - Solução");
  Console.WriteLine("--------------------------------------------------------");
  Console.WriteLine();
  Console.WriteLine("Opção selecionada");
  opcao = Console.ReadLine();
  Console.WriteLine();
  Console.WriteLine("--------------------------------------------------------");
  Console.WriteLine();

  switch (opcao)
  {
    //================== SRP ===========================
    case "1":     
      Console.WriteLine("1 - Single Responsibility Principle: Uma classe deve ter um, e somente um, motivo para mudar");
      Console.ReadKey();
      ViolacaoSRP.Cliente cliente = new ViolacaoSRP.Cliente("1", "Nome Teste");
      cliente.AdicionarCliente();
      Console.Clear();
      break;
    
    case "2":
      Console.WriteLine("2 - Single Responsibility Principle: Uma classe deve ter um, e somente um, motivo para mudar");
      Console.ReadKey();
      ViolacaoSRP.ClienteMelhorado clienteMelhorado = new ViolacaoSRP.ClienteMelhorado("1", "Nome Teste");
      clienteMelhorado.AdicionarCliente();
      Console.Clear();
      break;

    case "3":
      Console.WriteLine("3 - Single Responsibility Principle: Uma classe deve ter um, e somente um, motivo para mudar");
      Console.ReadKey();
      Cliente clienteSolucao = new Cliente("1", "Nome Teste");
      ClienteRepository clienteRepository = new ClienteRepository();
      MailService mailService = new MailService();
      ClienteService clienteService = new ClienteService(clienteRepository, mailService);
      clienteService.AdicionarCliente(clienteSolucao);
      Console.Clear();
      break;


    //================== OCP ===========================
    case "4":
      Console.WriteLine("4 - Open-closed Principle: Objetos ou entidades devem estar abertos para extensão, mas fechados para modificação");
      Console.ReadKey();
      ViolacaoOCP.DebitoConta debitoConta = new ViolacaoOCP.DebitoConta();
      debitoConta.Debitar(5, "1234", ViolacaoOCP.TipoConta.Corrente);
      Console.Clear();
      break;
    
    case "5":
      Console.WriteLine("5 - Open-closed Principle: Objetos ou entidades devem estar abertos para extensão, mas fechados para modificação");
      Console.ReadKey();
      DebitoConta debitoContaSolucao = new DebitoContaCorrente();
      debitoContaSolucao.Debitar(5, "1234");
      debitoContaSolucao = new DebitoContaPoupanca();
      debitoContaSolucao.Debitar(5, "1234");
      Console.Clear();
      break;


    //================== LSP ===========================
    case "6":
      Console.WriteLine("Liskov Substitution Principle: Se para cada objeto o1 do tipo S há um objeto o2 do tipo T de forma que, para todos os programas P definidos em termos de T, o comportamento de P é inalterado quando o1 é substituído por o2 então S é um subtipo de T");
      Console.WriteLine();
      Console.WriteLine("se S é um subtipo de T, então os objetos do tipo T, em um programa, podem ser substituídos pelos objetos de tipo S sem que seja necessário alterar as propriedades deste programa.");
      Console.ReadKey();
      Console.WriteLine();
      ViolacaoLSP.Retangulo retangulo = new ViolacaoLSP.Retangulo();
      retangulo.Altura = 5;
      Console.WriteLine($"Altura do retângulo: {retangulo.Altura}");
      retangulo.Largura = 4;      
      Console.WriteLine($"Largura do retângulo: {retangulo.Largura}");
      Console.WriteLine(ViolacaoLSP.CalculoArea.TestarCalcularAreaRetangulo(retangulo));
      ViolacaoLSP.Quadrado quadrado = new ViolacaoLSP.Quadrado();
      quadrado.Altura = 5;
      Console.WriteLine($"Altura do quadrado: {quadrado.Altura}");
      quadrado.Largura = 4;      
      Console.WriteLine($"Largura do quadrado: {quadrado.Largura}");
      Console.WriteLine(ViolacaoLSP.CalculoArea.TestarCalcularAreaRetangulo(quadrado));
      Console.ReadKey();
      ViolacaoLSP.Funcionario funcionario = new ViolacaoLSP.Gerente();
      Console.WriteLine(ViolacaoLSP.ProcessamentoMensal.CalculaPLR(funcionario));
      funcionario = new ViolacaoLSP.Estagiario();
      Console.WriteLine(ViolacaoLSP.ProcessamentoMensal.CalculaPLR(funcionario));
      Console.ReadKey();
      Console.Clear();
      break;
    
    case "7":
      Console.WriteLine("Liskov Substitution Principle: Se para cada objeto o1 do tipo S há um objeto o2 do tipo T de forma que, para todos os programas P definidos em termos de T, o comportamento de P é inalterado quando o1 é substituído por o2 então S é um subtipo de T");
      Console.WriteLine("se S é um subtipo de T, então os objetos do tipo T, em um programa, podem ser substituídos pelos objetos de tipo S sem que seja necessário alterar as propriedades deste programa.");
      Console.ReadKey();
      ElegivelPLR elegivelPLR = new Gerente();
      Console.WriteLine(ProcessamentoMensal.CalculaPLR(elegivelPLR));
      Console.ReadKey();
      Console.Clear();
      break;


    //================== ISP ===========================
    case "8":
      Console.WriteLine("Interface Segregation Principle: Uma classe não deve ser forçada a implementar interfaces e métodos que não irão utilizar");
      Console.ReadKey();
      Console.Clear();
      break;    
    case "9":
      Console.WriteLine("Interface Segregation Principle: Uma classe não deve ser forçada a implementar interfaces e métodos que não irão utilizar");
      Console.ReadKey();
      Console.Clear();
      break;

    
    //================== DIP ===========================
    case "10":
      Console.WriteLine("Dependency Inversion Principle: Dependa de abstrações e não de implementações");
      Console.ReadKey();
      Console.Clear();
      break;    
    case "11":
      Console.WriteLine("Dependency Inversion Principle: Dependa de abstrações e não de implementações");
      Console.ReadKey();
      Console.Clear();
      break;


    default:
      break;
  }
}