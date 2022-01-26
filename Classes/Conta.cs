using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.IO;
using System.Globalization;
using static System.Console;


namespace PooBanco.Classes
{
    public class Conta
    {
        static List<Dados> historico;
       
        public string _cliente { get; set; }
        public double _saldo { get; set; }
        public double _credito { get; set; }
        public string _conta { get; set; }


        internal int Desicao;
        internal double valorX;
        internal int errosEntradaINPUT;



        public Conta(string _Nome, double _saldo, double _credito, string conta)
        {
            this._cliente = _Nome;
            this._saldo = _saldo;
            this._credito = _credito;
            this._conta = conta;
            

        }


        public Conta()
        {
            this._cliente = "RONALDO ALMEIDA";
            this._saldo = 1500;
            this._credito = 2500;
            this._conta = "DIGITAL";
            historico= new List<Dados>();
        }



        public void TelaInicial()
        {
            layoutDEV();

            Console.WriteLine("                  OPÇÕES:");
            Console.WriteLine("    _______________________________________\n");
            Console.WriteLine("    | Aperte (1) Simular Conta Existente. |");
            Console.WriteLine("    | Aperte (2) Simular Criar Conta.     |");
            Console.WriteLine("    | Aperte (0) Encerrar Simulador       |\n");
            ConsoleKey escolha = ConsoleKey.X;
            errosEntradaINPUT = 1;
            while (errosEntradaINPUT == 1)
            {
                escolha = Console.ReadKey().Key;
                if (escolha == ConsoleKey.D0 || escolha == ConsoleKey.D1
                || escolha == ConsoleKey.D2 || escolha == ConsoleKey.NumPad0
                || escolha == ConsoleKey.NumPad1 || escolha == ConsoleKey.NumPad2)
                {
                    errosEntradaINPUT = 0;
                }
                else
                {
                    Console.Write("\r        Escolha (1) ou (2) ou (0) :");
                }
            }

            if (escolha == ConsoleKey.D1 || escolha == ConsoleKey.NumPad1)
            {
                opcoes();

            }
            else if (escolha == ConsoleKey.D2 || escolha == ConsoleKey.NumPad2)
            {

                Desicao = 0;
                Console.WriteLine("\n       |-------------------------| ");
                Console.WriteLine("       |-----CRIANDO CONTA-------| ");
                Console.WriteLine("       |-------------------------|\n");
                Console.Write("\r       Informe Titular da Conta: ");
                var nome = Console.ReadLine();
                while (nome.Length == 0)
                {

                    Console.Write("\r       Informe Titular da Conta: ");
                    nome = Console.ReadLine();
                }

                Console.Write("\r       Informe Tipo da Conta: ");
                var conta = Console.ReadLine();
                while (conta.Length == 0)
                {

                    Console.Write("\r       Informe tipo da Conta: ");
                    conta = Console.ReadLine();
                }

                double valorsaldo = -1;
                Console.Write("\r       Informe Saldo da Conta: ");
                errosEntradaINPUT = 1;
                while (errosEntradaINPUT == 1)
                {

                    while (!double.TryParse(Console.ReadLine(), out valorsaldo))
                    {
                        Console.Write("\r       Informe valor numérico: ");
                    }

                    if (valorsaldo < 0)
                    {
                        Console.Write("\r       Informe valor Posítivo: ");
                    }
                    else
                    {
                        errosEntradaINPUT = 0;
                    }


                }

                double valorCredito = -1;
                Console.Write("\r       Informe Crédito da Conta: ");
                errosEntradaINPUT = 1;
                while (errosEntradaINPUT == 1)
                {
                    while (!double.TryParse(Console.ReadLine(), out valorCredito))
                    {
                        Console.Write("\r       Informe valor numérico: ");
                    }

                    if (valorCredito < 0)
                    {
                        Console.Write("\r       Informe valor Posítivo: ");
                    }
                    else
                    {
                        errosEntradaINPUT = 0;
                    }



                }

                Conta objConta = new Conta(nome, valorsaldo, valorCredito, conta);
                objConta.opcoes();

            }
            else
            {
                Desicao = 0;
            }

        }

        private void layoutDEV()
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("************SIMULADOR TERMINAL BANCÁRIO***********");
            Console.WriteLine("          ***********Versão 1.0**********");
            Console.WriteLine("            **Dev: Ronaldo Almeida**");
            Console.WriteLine("          GitHub: https://github.com/mourarafm");
            Console.WriteLine("          Email: Ronaldo.A.F.Moura@Gmail.com");
            Console.WriteLine("  APLICANDO CONHECIMENTOS POO .net C# FULL-STACK");
            Console.WriteLine("**************************************************");
            Console.ResetColor();

        }

        public void opcoes()
        {
            layoutDEV();


            Console.WriteLine("        | TERMINAL  BANCO S/A |");
            Console.WriteLine("        -----------------------");
            Console.WriteLine("             Data:{0}", DateTime.Now.ToShortDateString());
            Console.WriteLine("Cliente:{0} /Conta:{1}", this._cliente, this._conta);
            Console.WriteLine("Saldo: ({0}) /Crédito: ({1})", this._saldo.ToString("C2", CultureInfo.CurrentCulture), this._credito.ToString("C2", CultureInfo.CurrentCulture));
            Console.WriteLine("--------------------------------------");
            Console.WriteLine("                OPÇÕES:");
            Console.WriteLine("    ______________________________\n");
            Console.WriteLine("    |  Aperte (1) para saque.    |");
            Console.WriteLine("    |  Aperte (2) para depósito. |");
            Console.WriteLine("    |  Aperte (3) para extrato.  |");
            Console.WriteLine("    |  Aperte (0) para encerrar. |\n\n");
            ConsoleKey escolha = ConsoleKey.X;
            errosEntradaINPUT = 1;
            while (errosEntradaINPUT == 1)
            {
                escolha = Console.ReadKey().Key;
                if (escolha == ConsoleKey.D0 || escolha == ConsoleKey.D1
                || escolha == ConsoleKey.D2 || escolha == ConsoleKey.D3
                || escolha == ConsoleKey.NumPad0 || escolha == ConsoleKey.NumPad1
                || escolha == ConsoleKey.NumPad2 || escolha == ConsoleKey.NumPad3)
                {
                    errosEntradaINPUT = 0;
                }
                else
                {
                    Console.Write("\r        Escolha (1) ou (2) ou (3) ou (0) :");
                }
            }

            if (escolha == ConsoleKey.D1 || escolha == ConsoleKey.NumPad1)
            {

                sacarValor();
                opcoes();

            }
            else if (escolha == ConsoleKey.D2 || escolha == ConsoleKey.NumPad2)
            {
                depositarValor();
                opcoes();

            }
            else if (escolha == ConsoleKey.D3 || escolha == ConsoleKey.NumPad3)
            {
                exibirExtrato();
                opcoes();
            }
            else
            {
                TelaInicial();
            }


        }


        private void exibirExtrato()
        {
              Console.WriteLine("                                EXTRATO:\n\n");
              Console.WriteLine("Cliente: {0}  /Conta: {1}  /Saldo atual: {2}\n",this._cliente,this._conta,this._saldo.ToString("C2",CultureInfo.CurrentCulture));
              Console.WriteLine("       DATA          |    Operação       |     Valor           |    Saldo\n");
              List<Dados>cliente=historico.FindAll(delegate(Dados dc){return dc._Cliente==this._cliente;});
              cliente.ForEach(delegate (Dados dc)
              {
                 
                    if(dc._Valor<100)
                    {
                    Console.WriteLine(dc._Data+"  |  "+dc._Operacao+"|  "+dc._Valor.ToString("C2", CultureInfo.CurrentCulture)+"           |  "+dc._Saldo.ToString("C2", CultureInfo.CurrentCulture));
                    }
                    else if (dc._Valor<1000)
                    {
                           Console.WriteLine(dc._Data+"  |  "+dc._Operacao+"|  "+dc._Valor.ToString("C2", CultureInfo.CurrentCulture)+"          |  "+dc._Saldo.ToString("C2", CultureInfo.CurrentCulture));
               
                    }
                    else if (dc._Valor<10000)
                    {
                         Console.WriteLine(dc._Data+"  |  "+dc._Operacao+"|  "+dc._Valor.ToString("C2", CultureInfo.CurrentCulture)+"        |  "+dc._Saldo.ToString("C2", CultureInfo.CurrentCulture));
               
                    }
                    else if(dc._Valor<100000)
                    {
                          Console.WriteLine(dc._Data+"  |  "+dc._Operacao+"|  "+dc._Valor.ToString("C2", CultureInfo.CurrentCulture)+"       |  "+dc._Saldo.ToString("C2", CultureInfo.CurrentCulture));
               
                    }
                    else if(dc._Valor<1000000)
                    {
                           Console.WriteLine(dc._Data+"  |  "+dc._Operacao+"|  "+dc._Valor.ToString("C2", CultureInfo.CurrentCulture)+"      |  "+dc._Saldo.ToString("C2", CultureInfo.CurrentCulture));
               
                    }
                    else{
                         
                          Console.WriteLine(dc._Data+"  |  "+dc._Operacao+"|  "+dc._Valor.ToString("C2", CultureInfo.CurrentCulture)+"  |  "+dc._Saldo.ToString("C2", CultureInfo.CurrentCulture));
               
                    }
              });
              mensagemFeito();
        }

        private void depositarValor()
        {
            Console.WriteLine("\n       |-----------------------------| ");
            Console.WriteLine("       |-------DEPOSITAR VALOR-------|\n ");
            Console.WriteLine("CLiente: {0} /Conta: {1}", this._cliente, this._conta);
            Console.WriteLine("Saldo: ({0}) /Limite Disponível: ({1})", this._saldo.ToString("C2", CultureInfo.CurrentCulture), this._credito.ToString("C2", CultureInfo.CurrentCulture));
            Console.WriteLine("-----------------------------------------------\n");
            Console.Write("\r       Informe valor Depósito R$: ");
            errosEntradaINPUT = 1;
            while (errosEntradaINPUT == 1)
            {
                while (!double.TryParse(Console.ReadLine(), out valorX))
                {
                    Console.Write("\r       Informe valor numérico: ");
                }
                if (valorX <= 0.0)
                {
                    Console.Write("\r       Informe valor Posítivo: ");
                }
                else
                {

                    double valorInicial = this._saldo;
                    Desicao = 1;
                    this._saldo = this._saldo + valorX;
                    if (this._saldo > 0)
                    {
                        Desicao = 2;
                    }

                    if (this._saldo <= 0.0)
                    {

                        this._credito = this._credito + valorX;
                    }
                    else
                    {
                        if (valorInicial <= 0.0 && Desicao == 2)
                        {
                            this._credito = (this._credito + valorX) - (this._saldo);
                        }
                        else
                        {
                            this._credito = (this._credito + valorX) - (this._saldo - valorInicial);
                        }


                    }
                   
                    historico.Add(new Dados(this._cliente,DateTime.Now,"Depósito         ",valorX,this._saldo));
                    mensagemFeito();
                    errosEntradaINPUT = 0;
                }
            }

        }

        private void sacarValor()
        {
            Console.WriteLine("\n       |-------------------------| ");
            Console.WriteLine("       |-------SACAR VALOR-------|\n ");
            Console.WriteLine("CLiente: {0} /Conta: {1}", this._cliente, this._conta);
            Console.WriteLine("Saldo: ({0}) /Crédito Disponível: ({1})", this._saldo.ToString("C2", CultureInfo.CurrentCulture), this._credito.ToString("C2", CultureInfo.CurrentCulture));
            Console.WriteLine("-----------------------------------------------\n");
            Console.Write("\r       Informe valor saque R$: ");
            errosEntradaINPUT = 1;
            while (errosEntradaINPUT == 1)
            {
                while (!double.TryParse(Console.ReadLine(), out valorX))
                {
                    Console.Write("\r       Informe valor numérico: ");
                }

                if (valorX <= 0.0)
                {
                    Console.Write("\r       Informe valor Posítivo: ");
                }
                else if (this._saldo >= valorX)
                {
                    this._saldo -= valorX;
                    historico.Add(new Dados(this._cliente,DateTime.Now,"Saque            ",valorX,this._saldo));
                   
                    mensagemFeito();
                    errosEntradaINPUT = 0;
                }

                else if (this._saldo > 0.0 && this._saldo < valorX && (this._credito + this._saldo) >= valorX)
                {

                    if (DesicaoLimite() == true)
                    {   
                       
                        this._saldo -= valorX;
                        this._credito += this._saldo;
                        historico.Add(new Dados(this._cliente,DateTime.Now,"Saque+Limite     ",valorX,this._saldo));
                  
                        mensagemFeito();

                    }
                    errosEntradaINPUT = 0;
                }
                else if (this._saldo <= 0.0 && this._credito >= valorX)
                {

                    if (DesicaoLimite() == true)
                    {
                        this._credito -= valorX;
                        this._saldo -= valorX;
                        historico.Add(new Dados(this._cliente,DateTime.Now,"Saque do Limite  ",valorX,this._saldo));
                       
                        mensagemFeito();

                    }
                    errosEntradaINPUT = 0;

                }
                else
                {
                    Console.WriteLine("\r    (Saldo + Crédito) insuficiente para operação.\nAperte uma (tecla) para sair...");
                    Console.ReadKey();
                    errosEntradaINPUT = 0;

                }
            }
        }


        private Boolean DesicaoLimite()
        {
            Console.WriteLine("\r       Saldo disponível :{0}, é menor que valor desejado para saque({1})", this._saldo.ToString("C2", CultureInfo.CurrentCulture), valorX.ToString("C2", CultureInfo.CurrentCulture));
            Console.WriteLine("\r       Deseja utilizar limite de crédito, Crédito disponivel: {0}", this._credito.ToString("C2", CultureInfo.CurrentCulture));
            Console.WriteLine("\nAperte(S) para sacar do limite");
            Console.WriteLine("\rAperte(X) para cancelar saque");
            errosEntradaINPUT = 1;
            bool valor = false;
            while (errosEntradaINPUT == 1)
            {
                ConsoleKey bt = Console.ReadKey().Key;

                if (bt == ConsoleKey.S || bt == ConsoleKey.X)
                {
                    errosEntradaINPUT = 0;
                    if (bt == ConsoleKey.S)
                    {
                        valor = true;
                    }
                    else
                    {

                        valor = false;
                    }


                }
                else
                {
                    Console.Write("\r       Escolha (S) ou (X) : ");
                }
            }

            return valor;

        }

        private void mensagemFeito()
        {
            Console.WriteLine("\n       Operação realizada com sucesso.\n\rAperte uma (tecla) para sair...");
            Console.ReadKey();
        }
    }

}