using SOLID_Principles.SRP.Solucao;
using ViolacaoSRP = SOLID_Principles.SRP.Violacao;
using ViolacaoOCP = SOLID_Principles.OCP.Violacao;
using ViolacaoLSP = SOLID_Principles.LSP.Violacao;
using SOLID_Principles.OCP.Solucao;
using SOLID_Principles.LSP.Solucao;

string opcao = string.Empty;

while (opcao.ToUpper() != "Q")
{
  Console.WriteLine("1 - Single Responsibility Principle - Conceito");
  Console.WriteLine("2 - Single Responsibility Principle - Violação");
  Console.WriteLine("3 - Single Responsibility Principle - Violação Melhorada");
  Console.WriteLine("4 - Single Responsibility Principle - Solução");
  Console.WriteLine("--------------------------------------------------------");
  Console.WriteLine("5 - Open-closed Principle - Conceito");
  Console.WriteLine("6 - Open-closed Principle - Violação");
  Console.WriteLine("7 - Open-closed Principle - Solução");
  Console.WriteLine("--------------------------------------------------------");
  Console.WriteLine("8 - Liskov Substitution Principle - Conceito");
  Console.WriteLine("9 - Liskov Substitution Principle - Violação");
  Console.WriteLine("10 - Liskov Substitution Principle - Solução");
  Console.WriteLine("--------------------------------------------------------");
  Console.WriteLine("11 - Interface Segregation Principle - Conceito");
  Console.WriteLine("12 - Interface Segregation Principle - Violação");
  Console.WriteLine("13 - Interface Segregation Principle - Solução");
  Console.WriteLine("--------------------------------------------------------");
  Console.WriteLine("14 - Dependency Inversion Principle - Violação");
  Console.WriteLine("15 - Dependency Inversion Principle - Violação");
  Console.WriteLine("16 - Dependency Inversion Principle - Solução");
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
      Console.Clear();
      break;

    case "2":
      ViolacaoSRP.Cliente cliente = new ViolacaoSRP.Cliente("1", "Nome Teste");
      cliente.AdicionarCliente();
      Console.Clear();
      break;
    
    case "3":
      ViolacaoSRP.ClienteMelhorado clienteMelhorado = new ViolacaoSRP.ClienteMelhorado("1", "Nome Teste");
      clienteMelhorado.AdicionarCliente();
      Console.Clear();
      break;

    case "4":
      Cliente clienteSolucao = new Cliente("1", "Nome Teste");
      ClienteRepository clienteRepository = new ClienteRepository();
      MailService mailService = new MailService();
      ClienteService clienteService = new ClienteService(clienteRepository, mailService);
      clienteService.AdicionarCliente(clienteSolucao);
      Console.Clear();
      break;


    //================== OCP ===========================
    case "5":
      Console.WriteLine("4 - Open-closed Principle: Objetos ou entidades devem estar abertos para extensão, mas fechados para modificação");
      Console.ReadKey();
      Console.Clear();
      break;

    case "6":
      ViolacaoOCP.DebitoConta debitoConta = new ViolacaoOCP.DebitoConta();
      debitoConta.Debitar(5, "1234", ViolacaoOCP.TipoConta.Corrente);
      Console.Clear();
      break;
    
    case "7":
      DebitoConta debitoContaSolucao = new DebitoContaCorrente();
      debitoContaSolucao.Debitar(5, "1234");
      debitoContaSolucao = new DebitoContaPoupanca();
      debitoContaSolucao.Debitar(5, "1234");
      Console.Clear();
      break;


    //================== LSP ===========================
    case "8":
      Console.WriteLine("Liskov Substitution Principle: Se para cada objeto o1 do tipo S há um objeto o2 do tipo T de forma que, para todos os programas P definidos em termos de T, o comportamento de P é inalterado quando o1 é substituído por o2 então S é um subtipo de T");
      Console.WriteLine("se S é um subtipo de T, então os objetos do tipo T, em um programa, podem ser substituídos pelos objetos de tipo S sem que seja necessário alterar as propriedades deste programa.");
      Console.ReadKey();
      Console.Clear();
      break;

    case "9":
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
      Console.WriteLine(ViolacaoLSP.ProcessamentoPLR.CalculaPLR(funcionario));
      funcionario = new ViolacaoLSP.Estagiario();
      Console.WriteLine(ViolacaoLSP.ProcessamentoPLR.CalculaPLR(funcionario));
      Console.ReadKey();
      Console.Clear();
      break;
    
    case "10":
      ElegivelPLR elegivelPLR = new Gerente();
      Console.WriteLine(ProcessamentoPLR.CalculaPLR(elegivelPLR));
      Console.ReadKey();
      Console.Clear();
      break;


    //================== ISP ===========================
    case "11":
      Console.WriteLine("Interface Segregation Principle: Uma classe não deve ser forçada a implementar interfaces e métodos que não irão utilizar");
      Console.ReadKey();
      Console.Clear();
      break;

    case "12":
      Console.Clear();
      break;    

    case "13":
      Console.Clear();
      break;


    //================== DIP ===========================
    case "14":
      Console.WriteLine("Dependency Inversion Principle: Dependa de abstrações e não de implementações");
      Console.ReadKey();
      Console.Clear();
      break;

    case "15":
      Console.Clear();
      break;    

    case "16":
      Console.Clear();
      break;


    default:
      break;
  }
}