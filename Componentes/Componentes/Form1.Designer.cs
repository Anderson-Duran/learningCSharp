namespace Componentes
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
            this.btn_add = new System.Windows.Forms.Button();
            this.btn_Clear = new System.Windows.Forms.Button();
            this.lb_title = new System.Windows.Forms.Label();
            this.tb_vehicle = new System.Windows.Forms.TextBox();
            this.tb_vehicleList = new System.Windows.Forms.TextBox();
            this.tb_year = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn_add
            // 
            this.btn_add.Location = new System.Drawing.Point(164, 97);
            this.btn_add.Name = "btn_add";
            this.btn_add.Size = new System.Drawing.Size(143, 51);
            this.btn_add.TabIndex = 0;
            this.btn_add.Text = "Adicionar";
            this.btn_add.UseVisualStyleBackColor = true;
            this.btn_add.Click += new System.EventHandler(this.btn_add_Click);
            // 
            // btn_Clear
            // 
            this.btn_Clear.Location = new System.Drawing.Point(27, 494);
            this.btn_Clear.Name = "btn_Clear";
            this.btn_Clear.Size = new System.Drawing.Size(280, 50);
            this.btn_Clear.TabIndex = 1;
            this.btn_Clear.Text = "Limpar";
            this.btn_Clear.UseVisualStyleBackColor = true;
            this.btn_Clear.Click += new System.EventHandler(this.btn_Clear_Click);
            // 
            // lb_title
            // 
            this.lb_title.AutoSize = true;
            this.lb_title.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lb_title.Location = new System.Drawing.Point(27, 31);
            this.lb_title.Name = "lb_title";
            this.lb_title.Size = new System.Drawing.Size(119, 20);
            this.lb_title.TabIndex = 2;
            this.lb_title.Text = "Digite o Veículo";
            // 
            // tb_vehicle
            // 
            this.tb_vehicle.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tb_vehicle.Location = new System.Drawing.Point(27, 54);
            this.tb_vehicle.Name = "tb_vehicle";
            this.tb_vehicle.Size = new System.Drawing.Size(280, 29);
            this.tb_vehicle.TabIndex = 3;
            // 
            // tb_vehicleList
            // 
            this.tb_vehicleList.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tb_vehicleList.Location = new System.Drawing.Point(27, 159);
            this.tb_vehicleList.Multiline = true;
            this.tb_vehicleList.Name = "tb_vehicleList";
            this.tb_vehicleList.Size = new System.Drawing.Size(280, 329);
            this.tb_vehicleList.TabIndex = 4;
            // 
            // tb_year
            // 
            this.tb_year.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tb_year.Location = new System.Drawing.Point(27, 120);
            this.tb_year.Name = "tb_year";
            this.tb_year.Size = new System.Drawing.Size(116, 29);
            this.tb_year.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(27, 97);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(116, 20);
            this.label1.TabIndex = 6;
            this.label1.Text = "Ano do Veículo";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(332, 565);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tb_year);
            this.Controls.Add(this.tb_vehicleList);
            this.Controls.Add(this.tb_vehicle);
            this.Controls.Add(this.lb_title);
            this.Controls.Add(this.btn_Clear);
            this.Controls.Add(this.btn_add);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Componentes - Curso C#";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button btn_add;
        private Button btn_Clear;
        private Label lb_title;
        private TextBox tb_vehicle;
        private TextBox tb_vehicleList;
        private TextBox tb_year;
        private Label label1;
    }
}