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
        Pessoa novoObjetoPessoa = new("Maria", "Silva", DateTime.Now);
        Console.WriteLine($"O nome da nova pessoa é: {novoObjetoPessoa.Nome} {novoObjetoPessoa.Sobrenome}, Data de nascimento: {novoObjetoPessoa.DataNascimento}");
        }
    }
}