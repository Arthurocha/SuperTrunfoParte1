using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SuperTrunfo.carta
{
    public class Jogador
    {
        public bool VencedorRodada { get; set; }
        public string Nome { get; set; }
        public int Pontos { get; set; }
        public List<Carta> cartas { get; set; }
    }
}
