using System.Data;

namespace GridDemo
{
    public class ContextoCalculo
    {
        public DataRow Row { get; init; }
        public object this[string key] => this.Row[key];
    }
}
