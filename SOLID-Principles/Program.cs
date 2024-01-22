using ViolacaoSRP = SOLID_Principles.SRP.Violacao;
using ViolacaoOCP = SOLID_Principles.OCP.Violacao;
using ViolacaoLSP = SOLID_Principles.LSP.Violacao;
using ViolacaoISP = SOLID_Principles.ISP.Violacao;
using ViolacaoDIP = SOLID_Principles.DIP.Violacao;
using SolucaoSRP = SOLID_Principles.SRP.Solucao;
using SOLID_Principles.OCP.Solucao;
using SOLID_Principles.LSP.Solucao;
using SOLID_Principles.ISP.Solucao;
using SolucaoDIP = SOLID_Principles.DIP.Solucao;

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
  Console.WriteLine("14 - Dependency Inversion Principle - Conceito");
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
      Console.WriteLine("Single Responsibility Principle: Uma classe deve ter um, e somente um, motivo para mudar");
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
      SolucaoSRP.Cliente clienteSolucao = new SolucaoSRP.Cliente("1", "Nome Teste");
      SolucaoSRP.ClienteService clienteService = new SolucaoSRP.ClienteService();
      clienteService.AdicionarCliente(clienteSolucao);
      Console.Clear();
      break;


    //================== OCP ===========================
    case "5":
      Console.WriteLine("Open-closed Principle: Objetos ou entidades devem estar abertos para extensão, mas fechados para modificação");
      Console.ReadKey();
      Console.Clear();
      break;

    case "6":
      ViolacaoOCP.DebitoConta debitoConta = new ViolacaoOCP.DebitoConta();
      debitoConta.Debitar(5, "1234", ViolacaoOCP.TipoConta.Corrente);

      var devRelatorios = new List<ViolacaoOCP.DesenvolvedorRelatorio>
      {
        new ViolacaoOCP.DesenvolvedorRelatorio {Id = 1, Nome = "Dev1", Nivel = "Senior developer", TaxaDaHora  = 30.5, HorasDeTrabalho = 160 }, //4880
        new ViolacaoOCP.DesenvolvedorRelatorio {Id = 2, Nome = "Dev2", Nivel = "Junior developer", TaxaDaHora  = 20, HorasDeTrabalho = 150 }, //3000
        new ViolacaoOCP.DesenvolvedorRelatorio {Id = 3, Nome = "Dev3", Nivel = "Senior developer", TaxaDaHora  = 30.5, HorasDeTrabalho = 180 } //5490
      };
      var calculadora = new ViolacaoOCP.CalculadoraDeSalario(devRelatorios);
      Console.WriteLine($"Soma do salário de todos os desenvolvedores é {calculadora.CalcularTotalSalarios()} reais");
      Console.ReadKey();
      Console.Clear();
      break;

    case "7":
      OperacaoFinanceira operacaoFinanceira = new OperacaoFinanceira();
      operacaoFinanceira.RealizarDebito(new DebitoContaCorrente());
      operacaoFinanceira.RealizarDebito(new DebitoContaPoupanca());

      var devCalculadoras = new List<CalculadoraSalarioBase>
      {
        new SeniorCalculadoraSalario(new DesenvolvedorRelatorio {Id = 1, Nome = "Dev1", Nivel = "Senior developer", TaxaDaHora  = 30.5, HorasDeTrabalho = 160 }), //4880
        new JuniorCalculadoraSalario(new DesenvolvedorRelatorio {Id = 2, Nome = "Dev2", Nivel = "Junior developer", TaxaDaHora  = 20, HorasDeTrabalho = 150 }), //3000
        new SeniorCalculadoraSalario(new DesenvolvedorRelatorio {Id = 3, Nome = "Dev3", Nivel = "Senior developer", TaxaDaHora  = 30.5, HorasDeTrabalho = 180 }) //5490
      };
      var calculadoraSolucao = new CalculadoraDeSalario(devCalculadoras);
      Console.WriteLine($"Soma do salário de todos os desenvolvedores é {calculadoraSolucao.CalcularTotalSalarios()} reais");
      Console.ReadKey();
      Console.Clear();
      break;


    //================== LSP ===========================
    case "8":
      Console.WriteLine("Liskov Substitution Principle: Se para cada objeto o1 do tipo S há um objeto o2 do tipo T de forma que, para todos os programas P definidos em termos de T, o comportamento de P é inalterado quando o1 é substituído por o2 então S é um subtipo de T");
      Console.WriteLine();
      Console.WriteLine("As classes derivadas devem ser substituíveis por suas classes bases.");
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
      retangulo = new ViolacaoLSP.Quadrado();
      retangulo.Altura = 5;
      Console.WriteLine($"Altura do quadrado: {retangulo.Altura}");
      retangulo.Largura = 4;
      Console.WriteLine($"Largura do quadrado: {retangulo.Largura}");
      Console.WriteLine(ViolacaoLSP.CalculoArea.TestarCalcularAreaRetangulo(retangulo));
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
      ViolacaoISP.Client client = new ViolacaoISP.Client();
      ViolacaoISP.HpLaserJetPrinter hpLaserJet = new ViolacaoISP.HpLaserJetPrinter();
      client.Print(hpLaserJet);
      client.EnviarFax(hpLaserJet);
      client.ImprimirDoisLados(hpLaserJet);
      Console.ReadKey();
      ViolacaoISP.LiquidInkJetPrinter inkJet = new ViolacaoISP.LiquidInkJetPrinter();
      client.Print(inkJet);
      client.EnviarFax(inkJet);
      client.ImprimirDoisLados(inkJet);
      Console.ReadKey();
      Console.Clear();
      break;

    case "13":
      Client clientPrint = new Client();
      HpLaserJetPrinter hpLaserJetPrinter = new HpLaserJetPrinter();
      clientPrint.Print(hpLaserJetPrinter);
      clientPrint.EnviarFax(hpLaserJetPrinter);
      clientPrint.ImprimirDoisLados(hpLaserJetPrinter);
      Console.ReadKey();
      LiquidInkJetPrinter inkJetPrinter = new LiquidInkJetPrinter();
      clientPrint.Print(inkJetPrinter);
      //clientPrint.EnviarFax(inkJetPrinter);
      //clientPrint.ImprimirDoisLados(inkJetPrinter);
      Console.ReadKey();
      Console.Clear();
      break;


    //================== DIP ===========================
    case "14":
      Console.WriteLine("Dependency Inversion Principle: Dependa de abstrações e não de implementações");
      Console.WriteLine("Módulos de alto nível não devem depender de módulos de baixo nível. Ambos devem depender da abstração");
      Console.ReadKey();
      Console.Clear();
      break;

    case "15":
      ViolacaoDIP.Cliente clienteViolacaoDIP = new ViolacaoDIP.Cliente("1", "Nome Teste");
      ViolacaoDIP.ClienteService clienteServiceViolacaoDIP = new ViolacaoDIP.ClienteService();
      clienteServiceViolacaoDIP.AdicionarCliente(clienteViolacaoDIP);
      Console.Clear();
      break;

    case "16":
      SolucaoDIP.Cliente clienteSolucaoDIP = new SolucaoDIP.Cliente("1", "Nome Teste");
      SolucaoDIP.IClienteRepository clienteRepository = new SolucaoDIP.ClienteRepository();
      //SolucaoDIP.IClienteRepository clienteRepository = new SolucaoDIP.ClienteMySQLRepository();
      SolucaoDIP.MailService mailService = new SolucaoDIP.MailService();
      SolucaoDIP.ClienteService clienteServiceSolucaoDIP = new SolucaoDIP.ClienteService(clienteRepository, mailService);
      clienteServiceSolucaoDIP.AdicionarCliente(clienteSolucaoDIP);
      Console.Clear();
      break;


    default:
      Console.Clear();
      break;
  }
}