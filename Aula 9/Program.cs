using System;

namespace ExemploCarros
{
    // 1. Definição da classe 'Carro'
    public class Carro
    {
        public string Chassis { get; set; }
        public string LicensePlate { get; set; }
        public string Cor { get; set; }
        public string Motor { get; set; }

        public Carro(string chassis, string licensePlate, string cor, string motor)
        {
            Chassis = chassis;
            LicensePlate = licensePlate;
            Cor = cor;
            Motor = motor;
        }

        public override string ToString()
        {
            return $"Detalhes do carro: Chassis: {Chassis} Placa: {LicensePlate} Cor: {Cor} Motor: {Motor}";
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            // 2. Criar um array (carList) com 10 carros
            Carro[] carList = new Carro[10];

            carList[0] = new Carro("Sedan", "ABC123", "Vermelho", "V6");
            carList[1] = new Carro("SUV", "XYZ789", "Azul", "Elétrico");
            carList[2] = new Carro("Hatchback", "QWE456", "Preto", "I4");
            carList[3] = new Carro("Coupé", "JKL321", "Branco", "V8");
            carList[4] = new Carro("Conversível", "RST987", "Amarelo", "Turbodiesel");
            carList[5] = new Carro("Station Wagon", "HJK654", "Verde", "Híbrido");
            carList[6] = new Carro("Pick-up", "MNB852", "Prata", "Turbodiesel V6");
            carList[7] = new Carro("Minivan", "PLK369", "Roxo", "I4 Híbrido");
            carList[8] = new Carro("Esportivo", "ZXC951", "Laranja", "V10");
            carList[9] = new Carro("Microcar", "BRT741", "Cinza", "Elétrico Compacto");

            // 3. Exibir as informações de cada carro
            foreach (Carro carro in carList)
            {
                Console.WriteLine(carro.ToString());
            }
        }
    }
}
