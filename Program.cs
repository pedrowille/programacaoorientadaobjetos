using System;
using ProgramacaoOrientadaObjetos.Cadastros;

namespace ProgramacaoOrientadaObjetos
{
    public class Program
    {
        public static void Main(string[] args)
        {
Pessoa objetoPessoa = new ();
        objetoPessoa.Nome = "meunome";
        objetoPessoa.Sobrenome = "meu sobrenome";
        Console.WriteLine($"O nome da pessoa é: {objetoPessoa.Nome} {objetoPessoa.Sobrenome}");
        }
    }
}