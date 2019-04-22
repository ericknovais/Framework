using System;

namespace BancoDoBrasil.Contas
{
    public enum TipoConta
    {
        ContaCorrente,
        ContaPoupanca
    };

    public class Conta
    {
        // atributos
        private string Num;
        private double _saldo;
        private TipoConta Tipo;

        //construtor
        public Conta(TipoConta tipo, string num)
        {
            this.Num = num;
            this.Tipo = tipo;
            this._saldo = 0;
        }

        //metodos
        public void Sacar(double valor)
        {
            _saldo = _saldo - valor;
        }

        public void Deposistar(double valor)
        {
            _saldo = _saldo + valor;
        }

        public double getSaldo()
        {
            return _saldo;
        }
    }
}
