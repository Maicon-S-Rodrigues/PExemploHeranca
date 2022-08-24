using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PExemploHeranca
{
    internal class Veiculo
    {
        //////////////////////////////////////////////////////////////////////////////////////////////////////
        ///
        /// Atributos:
        String Marca;
        String Modelo;
        int Rodas;
        int Capacidade;
        float Preco;
        String Cor;

        //////////////////////////////////////////////////////////////////////////////////////////////////////
        ///
        /// Método Construtor (não pode esquecer) recebendo os dados por parâmetros:
        public Veiculo(string marca, string modelo, int rodas, int capacidade, float preco, string cor)
        {
            Marca = marca;
            Modelo = modelo;
            Rodas = rodas;
            Capacidade = capacidade;
            Preco = preco;
            Cor = cor;
        }
        //////////////////////////////////////////////////////////////////////////////////////////////////////
        ///
        /// Método para escrever os valores na tela:
        public override string ToString()
        {
            return "\nMarca: " + Marca + "\nModelo: " + Modelo + "\nRodas: " + Rodas +
                   "\nCapacidade: " + Capacidade + "\nCor: " + Cor + "\nPreço: " + Preco;
        }
        //////////////////////////////////////////////////////////////////////////////////////////////////////
    }
}
