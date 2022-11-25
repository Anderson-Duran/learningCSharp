namespace Aula60
{
    partial class Form1
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
            this.btn_adicionar = new System.Windows.Forms.Button();
            this.tb_veiculo = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.listaPrimaria = new System.Windows.Forms.TextBox();
            this.btn_limpar = new System.Windows.Forms.Button();
            this.btn_listaVeiculos = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_adicionar
            // 
            this.btn_adicionar.Location = new System.Drawing.Point(276, 38);
            this.btn_adicionar.Name = "btn_adicionar";
            this.btn_adicionar.Size = new System.Drawing.Size(75, 23);
            this.btn_adicionar.TabIndex = 0;
            this.btn_adicionar.Text = "Adicionar";
            this.btn_adicionar.UseVisualStyleBackColor = true;
            this.btn_adicionar.Click += new System.EventHandler(this.btn_adicionar_Click);
            // 
            // tb_veiculo
            // 
            this.tb_veiculo.Location = new System.Drawing.Point(23, 38);
            this.tb_veiculo.Name = "tb_veiculo";
            this.tb_veiculo.Size = new System.Drawing.Size(247, 23);
            this.tb_veiculo.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 15);
            this.label1.TabIndex = 2;
            this.label1.Text = "Insira o Veículo";
            // 
            // listaPrimaria
            // 
            this.listaPrimaria.Location = new System.Drawing.Point(23, 67);
            this.listaPrimaria.Multiline = true;
            this.listaPrimaria.Name = "listaPrimaria";
            this.listaPrimaria.Size = new System.Drawing.Size(328, 337);
            this.listaPrimaria.TabIndex = 3;
            // 
            // btn_limpar
            // 
            this.btn_limpar.Location = new System.Drawing.Point(23, 412);
            this.btn_limpar.Name = "btn_limpar";
            this.btn_limpar.Size = new System.Drawing.Size(328, 30);
            this.btn_limpar.TabIndex = 4;
            this.btn_limpar.Text = "Limpar";
            this.btn_limpar.UseVisualStyleBackColor = true;
            this.btn_limpar.Click += new System.EventHandler(this.btn_limpar_Click);
            // 
            // btn_listaVeiculos
            // 
            this.btn_listaVeiculos.Location = new System.Drawing.Point(23, 448);
            this.btn_listaVeiculos.Name = "btn_listaVeiculos";
            this.btn_listaVeiculos.Size = new System.Drawing.Size(328, 30);
            this.btn_listaVeiculos.TabIndex = 5;
            this.btn_listaVeiculos.Text = "Lista de Veiculos";
            this.btn_listaVeiculos.UseVisualStyleBackColor = true;
            this.btn_listaVeiculos.Click += new System.EventHandler(this.btn_listaVeiculos_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(372, 486);
            this.Controls.Add(this.btn_listaVeiculos);
            this.Controls.Add(this.btn_limpar);
            this.Controls.Add(this.listaPrimaria);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tb_veiculo);
            this.Controls.Add(this.btn_adicionar);
            this.Name = "Form1";
            this.Text = "CBC Cursos";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button btn_adicionar;
        private TextBox tb_veiculo;
        private Label label1;
        private TextBox listaPrimaria;
        private Button btn_limpar;
        private Button btn_listaVeiculos;
    }
}