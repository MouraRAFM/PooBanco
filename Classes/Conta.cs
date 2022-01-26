namespace poobanco.Classes
{
    public class Conta
    {
        //atributos da classe
      public string _Nome{get;private set;}
      public tipoCliente _tipoCliente{get;set;}
      public double _saldo{get; private set;}
      public double _credito{get;set;}
        public Conta()
        {
            this._Nome = "Ronaldo";
            this._tipoCliente =tipoCliente.definir;
            this._saldo = 10.10;
            this._credito = 150.00;
        }

      internal string defout()
      {
           string dados = this._Nome + Convert.ToString(this._saldo); 
           return dados;
      }


    }
       
}