﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Estacionamento.Models;

public class Estacionamentos {
    private decimal precoInicial = 0;
    private decimal precoPorHora = 0;
    private List<string> veiculos = new List<string>();

    public Estacionamentos(decimal precoInicial, decimal precoPorHora) {
        this.precoInicial = precoInicial;
        this.precoPorHora = precoPorHora;
    }

    public void AdicionarVeiculo() {
        Console.WriteLine("Digite a placa do veículo para estacionar: ");
        string placa = Console.ReadLine();

        // Verifica se o veículo já existe antes de adicionar
        if (veiculos.Any(x => x.ToUpper() == placa.ToUpper())) 
        {
            Console.WriteLine("Esse veículo já está estacionado!");
        } else {
            veiculos.Add(placa);
            Console.WriteLine("Veículo adicionado com sucesso!");
        }
    }

    public void RemoverVeiculo() {
        Console.WriteLine("Digite a placa do veículo para remover:");
        // Pedir para o usuário digitar a placa e armazenar na variável placa
        string placa = Console.ReadLine();

        // Verifica se o veículo existe
        if (veiculos.Any(x => x.ToUpper() == placa.ToUpper())) {
            Console.WriteLine("Digite a quantidade de horas que o veículo permaneceu estacionado:");

            int horas = Convert.ToInt32(Console.ReadLine());
            decimal valorTotal = precoInicial + (precoPorHora * horas);

            veiculos.RemoveAll(x => x.ToUpper() == placa.ToUpper());

            Console.WriteLine($"O veículo {placa} foi removido e o preço total foi de: R$ {valorTotal}.");
        }
        else {
            Console.WriteLine("Desculpe, esse veículo não está estacionado aqui. Confira se digitou a placa corretamente...");
        }
    }

    public void ListarVeiculos() {
        // Verifica se existem veículos no estacionamento
        if (veiculos.Any()) {
            Console.WriteLine("Os veículos estacionados são:");
            foreach (string veic in veiculos) {
                Console.WriteLine(veic);
            }
        }
        else {
            Console.WriteLine("Não há veículos estacionados.");
        }
    }
}
