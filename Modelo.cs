using System;
using System.Collections.Generic;
using System.Text;

namespace ShoeSale
{
    class Modelo
    {
        public int id { get; set; }

        public String Name { get; set; }

        public Boolean cadarco { get; set; }

        public String Material { get; set; }

        public String Cor { get; set; }

        public double Preco { get; set; }

        public Modelo(int id, string name, bool cadarco, string material, string cor, double preco)
        {
            this.id = id;
            Name = name;
            this.cadarco = cadarco;
            Material = material;
            Cor = cor;
            Preco = preco;
        }

        
    }
}
