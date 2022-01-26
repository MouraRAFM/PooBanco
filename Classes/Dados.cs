
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.IO;
using System.Globalization;
using static System.Console;

namespace PooBanco.Classes
{
    public class Dados
    {
        public Dados(string _Cliente, DateTime _Data, string _Operacao, double _Valor, double _Saldo)
        {
            this._Cliente = _Cliente;
            this._Data = _Data;
            this._Operacao = _Operacao;
            this._Valor = _Valor;
            this._Saldo=_Saldo;

        }
        public string _Cliente { get; set; }
        public DateTime _Data { get; set; }

        public string _Operacao { get; set; }

        public double _Valor { get; set; }

        public double _Saldo{get;set;}

        Dados()
        {
           _Cliente="Cliente";
           _Data=_Data;
           _Operacao="Saque/deposito";
           _Valor=0.0;
            
        }

    }
}