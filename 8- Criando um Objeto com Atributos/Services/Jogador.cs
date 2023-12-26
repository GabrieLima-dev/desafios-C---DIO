using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace _8__Criando_um_Objeto_com_Atributos.Services
{
    class Jogador
    {
        public string Nome { get; set; }
        public string Nacionalidade { get; set; }
        public int Idade { get; set; }
        public string Posicao { get; set; }

        public Jogador(string nome, string nacionalidade, int idade, string posicao)
        {
            Nome = nome;
            Nacionalidade = nacionalidade;
            Idade = idade;
            Posicao = posicao;
        }
    }
}