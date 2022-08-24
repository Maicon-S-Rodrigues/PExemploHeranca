using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PExemploHeranca
{
    internal class Moto : Veiculo //Classe moto (os dois pontos mostram a qual classe ela referencia/herda a estrutura. no caso Moto referencia: Veiculo
    {
        int Cilindradas;
        bool Partida_Eletrica;

        public Moto(string marca, string modelo, int rodas, int capacidade, float preco, string cor, int cilindradas, bool partida)
            : base(marca, modelo, rodas, capacidade, preco, cor)
        {
            Cilindradas = cilindradas;
            Partida_Eletrica = partida;
        }

        public override string ToString()
        {
            string mensagem;

            if (Partida_Eletrica) {mensagem = "Sim";}
            else {mensagem = "Não";}

            return base.ToString() + "\nCilindradas: " + Cilindradas + "\nPartida Elétrica: " + mensagem;


        }
    }
}
