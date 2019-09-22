using System;
using System.Collections.Generic;
using System.Text;

namespace ShoeSale
{
    class Sapato
    {
        public int MyProperty { get; set; }

        public int Tamanho { get; set; }

        public int Quantidade { get; set; }

        public ICollection<Modelo> Modelos { get; set; } = new List<Modelo>();

        public Sapato()
        {

        }

        public Sapato(int myProperty, int tamanho, int quantidade, ICollection<Modelo> modelos)
        {
            MyProperty = myProperty;
            Tamanho = tamanho;
            Quantidade = quantidade;
            Modelos = modelos;
        }

        public void AddModelos(Modelo modelo)
        {
            Modelos.Add(modelo);
        }
    }
}
