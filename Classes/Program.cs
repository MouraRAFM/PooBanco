using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.IO;

namespace PooBanco.Classes
{
    public class Program
    {
         
         
        public static void Main(string[] args)
        {

           
            int exit=4;
            while(exit!=0)
            {     
                   
                  Conta objtInicial=new Conta();
                  objtInicial.TelaInicial();
                  exit=objtInicial.Desicao;
                 
            }
            
           
           
        }

        
    }
}