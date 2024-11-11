using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoPAS
{
    public class Corpo
    {
        public string Nome { get; set; }
        public double Massa { get; set; }
        public double Densidade { get; set; }
        public double Raio { get; set; }
        public double PosX { get; set; }
        public double PosY { get; set; }
        public double VelX { get; set; }
        public double VelY { get; set; }

        private static Random random = new Random();
        private static int contadorCorpos = 0;

        public Corpo()
        {
            contadorCorpos++;
            Nome = $"corpo {contadorCorpos}";
            Massa = GerarValorAleatorio(1.0, 100.0); // Massa aleatória entre 1.0 e 100.0
            Densidade = GerarValorAleatorio(0.09, 25.0); // Densidade aleatória entre 0.09 e 25 g/cm³
            Raio = CalcularRaio(Massa, Densidade);
            PosX = GerarValorAleatorio(0.0, 800.0); // Posição X aleatória (ajuste conforme o tamanho da tela)
            PosY = GerarValorAleatorio(0.0, 600.0); // Posição Y aleatória (ajuste conforme o tamanho da tela)
            VelX = 0.0;
            VelY = 0.0;
        }

        private double GerarValorAleatorio(double min, double max)
        {
            return random.NextDouble() * (max - min) + min;
        }

        private double CalcularRaio(double massa, double densidade)
        {
            // Fórmula para calcular o raio: Raio = (3 * Massa / (4 * π * Densidade))^(1/3)
            return Math.Pow((3 * massa) / (4 * Math.PI * densidade), 1.0 / 3.0);
        }
    }
}
