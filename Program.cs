using Microsoft.VisualBasic;
using System;

namespace Pessoa{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("digite o  nome da pessoa:");
            var nome = Console.ReadLine();
            
            Console.WriteLine("digite a data de nascimento:");
            var dataNascimentoPessoa = Console.ReadLine();
            var dataNascimento = Convert.ToDateTime(dataNascimentoPessoa);


            var anoAtual = DateTime.Now.Year;
            var idade = anoAtual - dataNascimento.Year;

            Console.WriteLine("digite a altura: ");
            var altura = Convert.ToDecimal(Console.ReadLine());
            Console.WriteLine("digite o peso: ");
            var peso = Convert.ToDecimal( Console.ReadLine());
            var imc = Math.Round((peso / (altura * altura) * 10000), 2);
            var classificacao = "";

            if (imc < (Decimal) 18.50) {
                classificacao = "abaixo do peso";
            }
          else  if(imc > (Decimal) 18.50 &&  imc <= (Decimal) 25.90)
            {
                classificacao ="peso normal";

            }
            else   if ( imc >= (Decimal) 25.0 &&  imc <= (Decimal)29.90)
            {

                classificacao = " sobrepeso";
            }
             else  if( imc >= (Decimal)30.0 && imc <= (Decimal)34.90)
            {
                classificacao = "obesidade nivel I";
            }
           
              else if ( imc >=(Decimal) 35.0 && imc <= (Decimal)39.0)
            {

                classificacao = " obesidade nivel II";
            }
            else
            {
                classificacao = "obesidade nivel III";
            }






            Console.WriteLine("digite o salario bruto: ");
            var salario = Convert.ToDouble(Console.ReadLine());
            double desconto = 0.0;

            if (salario < 1.045)
            {
                desconto = 7.5;
            }
           else  if (salario >= 1.405 && salario< 2089.60)
            {
                desconto =  9;

            }
           else  if(salario >= 2089.61 &&  desconto < 3134.40)
            {
                desconto =  12;
            }

            else{ 
                desconto =  14;
            }

            var inss = (salario * desconto) / 100;


            var salarioLiquido = salario - inss;

            var dolar = (salarioLiquido / 5,22);


            Console.WriteLine("gostaria de ler seu saldo em dolar?");
            var sim = Console.ReadLine();

            if( sim == "sim")
            {

                Console.WriteLine(" seu salario em dolar é: " + dolar);
            }
            else
            {
                Console.WriteLine("ok");
            }



           
            Console.WriteLine(" o  nome da pessoa é:"  + nome);
            Console.WriteLine(" a idade da pessoa " + nome +  " é " + idade + " anos " );
            Console.WriteLine(" o imc da pessoa é : " + imc + "voce esta  " + classificacao);
            Console.WriteLine(" o seu  desconto do inss é de  " + desconto +  " logo..." + inss);
            Console.Write("O salario liquido é:" + salarioLiquido);
         



    
        }
    }

}