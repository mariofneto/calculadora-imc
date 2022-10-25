using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

public class Pessoa
{
    // atributos para classe adicionados
    public double peso;
    public double altura;

    /* esse é um construtor para facilitar o jeito de declarar os atributos
    
    public Pessoa(double peso, double altura)
    {
        this.peso = peso;
        this.altura = altura;
    }
    */

    // método para calculo de imc
    public double IMC()
    {
        return peso / (altura * altura);
    }

    // método para retornar uma situacao do imc
    public string situacao()
    {
        if (IMC() < 18.5)
        {
            return "Abaixo do peso";
        }
        else if (IMC() < 25)
        {
            return "Peso normal";
        }
        else if (IMC() < 30)
        {
            return "Acima do peso";
        }
        else if (IMC() < 35)
        {
            return "Obesidade I";
        }
        else if (IMC() < 40)
        {
            return "Obesidade II";
        }
        else
        {
            return "Obesidade III";
        }
    }

    // método de mensagem para exibir o calculo e a situação

    public void mensagem()
    {
        Console.WriteLine("O seu IMC é de: " + Math.Round(IMC(), 2) + " \nSua situação é: " + situacao());
    }


}
