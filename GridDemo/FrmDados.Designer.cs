
namespace GridDemo
{
    partial class FrmDados
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmDados));
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.btnExecutarCalculos = new System.Windows.Forms.Button();
            this.btnAddColunasCalculadas = new System.Windows.Forms.Button();
            this.txbCalculo = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView
            // 
            this.dataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Location = new System.Drawing.Point(12, 12);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.RowTemplate.Height = 25;
            this.dataGridView.Size = new System.Drawing.Size(854, 472);
            this.dataGridView.TabIndex = 0;
            // 
            // btnExecutarCalculos
            // 
            this.btnExecutarCalculos.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnExecutarCalculos.Location = new System.Drawing.Point(872, 461);
            this.btnExecutarCalculos.Name = "btnExecutarCalculos";
            this.btnExecutarCalculos.Size = new System.Drawing.Size(313, 23);
            this.btnExecutarCalculos.TabIndex = 1;
            this.btnExecutarCalculos.Text = "Executar Calculo";
            this.btnExecutarCalculos.UseVisualStyleBackColor = true;
            this.btnExecutarCalculos.Click += new System.EventHandler(this.btnExecutarCalculos_Click);
            // 
            // btnAddColunasCalculadas
            // 
            this.btnAddColunasCalculadas.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnAddColunasCalculadas.Location = new System.Drawing.Point(12, 511);
            this.btnAddColunasCalculadas.Name = "btnAddColunasCalculadas";
            this.btnAddColunasCalculadas.Size = new System.Drawing.Size(256, 23);
            this.btnAddColunasCalculadas.TabIndex = 1;
            this.btnAddColunasCalculadas.Text = "Adicionar Colunas Calculadas";
            this.btnAddColunasCalculadas.UseVisualStyleBackColor = true;
            this.btnAddColunasCalculadas.Click += new System.EventHandler(this.btnAddColunasCalculadas_Click);
            // 
            // txbCalculo
            // 
            this.txbCalculo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txbCalculo.Location = new System.Drawing.Point(879, 30);
            this.txbCalculo.Multiline = true;
            this.txbCalculo.Name = "txbCalculo";
            this.txbCalculo.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txbCalculo.Size = new System.Drawing.Size(480, 354);
            this.txbCalculo.TabIndex = 2;
            this.txbCalculo.Text = resources.GetString("txbCalculo.Text");
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(879, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(227, 15);
            this.label1.TabIndex = 3;
            this.label1.Text = "Formula para cáculo do salario reajustado";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(883, 404);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(245, 45);
            this.label2.TabIndex = 4;
            this.label2.Text = "Altera a fórmula acima para mudar o calculo \r\nAltere os valores no grid\r\nClique e" +
    "m executar cáculo";
            // 
            // FrmDados
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1364, 540);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txbCalculo);
            this.Controls.Add(this.btnAddColunasCalculadas);
            this.Controls.Add(this.btnExecutarCalculos);
            this.Controls.Add(this.dataGridView);
            this.Name = "FrmDados";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.Button btnExecutarCalculos;
        private System.Windows.Forms.Button btnAddColunasCalculadas;
        private System.Windows.Forms.TextBox txbCalculo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}

