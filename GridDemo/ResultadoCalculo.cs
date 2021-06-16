using System;
using System.Collections.Generic;

namespace GridDemo
{
    public class ResultadoCalculo
    {
        public Dictionary<string, object> Dados { get; } = new Dictionary<string, object>();

        public void AddValor(string chave, object valor)
        {
            this.Dados.Add(chave, valor);
        }

        public object GetValor(string chave)
        {
            return this.Dados.TryGetValue(chave, out var valor) ? valor : 0;
        }

        public void Reset()
        {
            this.Dados.Clear();
        }
    }
}
