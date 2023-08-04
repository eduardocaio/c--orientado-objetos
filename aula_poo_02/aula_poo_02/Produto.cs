using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace aula_poo_02
{
    internal class Produto
    {
        private string _nome;
        public double _preco { get; private set; }
        public int _quantidade { get; private set; }

        public Produto()
        {
            _quantidade = 10;
        }

        public Produto(string nome, double preco) : this() 
        {
            _nome = nome;
            _preco = preco;

        }

        public Produto(string nome, double preco, int quantidade) : this(nome, preco)
        {
            _quantidade = quantidade;
        }


        public double ValorTotalEmEstoque()
        {
            return _quantidade * _preco;
        }

        public void AdicionarProdutos(int adicionar)
        {
            _quantidade += adicionar;
        }

        public void RemoverProdutos(int remover)
        {
            _quantidade -= remover;
        }

        public override string ToString()
        {
            return _nome + ", $ " + _preco.ToString("F2", CultureInfo.InvariantCulture) + ", " + _quantidade + " unidades" +
    ", Total: $" + ValorTotalEmEstoque().ToString("F2", CultureInfo.InvariantCulture);
        }

    }
}
