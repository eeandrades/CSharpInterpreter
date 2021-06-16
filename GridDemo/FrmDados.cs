using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace GridDemo
{
    public partial class FrmDados : Form
    {
        DataTable _dados;
        private static DataTable CarregaDados()
        {
            var appDir = System.IO.Path.GetDirectoryName(Application.ExecutablePath);

            string xmlPath = System.IO.Path.Combine(appDir,  "dados.xml");

            var dts = new DataSet();

            dts.ReadXml(xmlPath);

            return dts.Tables[0];
        }
        public FrmDados()
        {
            InitializeComponent();
            this._dados = CarregaDados();
            this.dataGridView.AutoGenerateColumns = true;
            this.dataGridView.DataSource = _dados;

            this.btnExecutarCalculos.Enabled = false;
        }


        private void btnAddColunasCalculadas_Click(object sender, EventArgs e)
        {
            if (!this._dados.Columns.Contains("salarioReajustado"))
                this._dados.Columns.Add("salarioReajustado", typeof(decimal));
            this.btnExecutarCalculos.Enabled = true;
        }

        private void btnExecutarCalculos_Click(object sender, EventArgs e)
        {
            var salarioReajustadoInterpreter = new Interpreter.InterpreterAgent<ContextoCalculo, ResultadoCalculo>(this.txbCalculo.Text);

            if (salarioReajustadoInterpreter.Validate(out var messages))
            {
                foreach (DataRow row in this._dados.Rows)
                {
                    var contexto = new ContextoCalculo()
                    {
                        Row = row
                    };

                    var result = salarioReajustadoInterpreter.Execute(contexto);


                    row["salarioReajustado"] = result.GetValor("salarioReajustado");
                }
                this._dados.AcceptChanges();
            }
            else
            {
                string strMessages = string.Join(Environment.NewLine, messages.Select(m => m.Text));
                MessageBox.Show(strMessages);

            }
        }
    }
}
