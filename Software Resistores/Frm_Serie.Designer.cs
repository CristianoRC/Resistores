namespace SoftwareResistores
{
    partial class Frm_Serie
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_Serie));
            this.listResistores = new System.Windows.Forms.ListBox();
            this.Lbl_Req = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Txt_Resistor = new System.Windows.Forms.TextBox();
            this.Btm_Adicionar = new System.Windows.Forms.Button();
            this.Btm_Remover = new System.Windows.Forms.Button();
            this.Lbl_CorrenteTotal = new System.Windows.Forms.Label();
            this.Btm_Calcular = new System.Windows.Forms.Button();
            this.Txt_Tensão = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // listResistores
            // 
            this.listResistores.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.listResistores.FormattingEnabled = true;
            this.listResistores.Location = new System.Drawing.Point(494, 0);
            this.listResistores.Name = "listResistores";
            this.listResistores.Size = new System.Drawing.Size(198, 173);
            this.listResistores.TabIndex = 2;
            // 
            // Lbl_Req
            // 
            this.Lbl_Req.AutoSize = true;
            this.Lbl_Req.Location = new System.Drawing.Point(12, 92);
            this.Lbl_Req.Name = "Lbl_Req";
            this.Lbl_Req.Size = new System.Drawing.Size(92, 13);
            this.Lbl_Req.TabIndex = 3;
            this.Lbl_Req.Text = "Resistência Total:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(5, 47);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Resistor(Ω)";
            // 
            // Txt_Resistor
            // 
            this.Txt_Resistor.Location = new System.Drawing.Point(94, 42);
            this.Txt_Resistor.Name = "Txt_Resistor";
            this.Txt_Resistor.Size = new System.Drawing.Size(167, 20);
            this.Txt_Resistor.TabIndex = 5;
            // 
            // Btm_Adicionar
            // 
            this.Btm_Adicionar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightGray;
            this.Btm_Adicionar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btm_Adicionar.Location = new System.Drawing.Point(283, 42);
            this.Btm_Adicionar.Name = "Btm_Adicionar";
            this.Btm_Adicionar.Size = new System.Drawing.Size(75, 23);
            this.Btm_Adicionar.TabIndex = 6;
            this.Btm_Adicionar.Text = "Adicionar";
            this.Btm_Adicionar.UseVisualStyleBackColor = true;
            this.Btm_Adicionar.Click += new System.EventHandler(this.Btm_Adicionar_Click);
            // 
            // Btm_Remover
            // 
            this.Btm_Remover.BackColor = System.Drawing.Color.DarkSlateGray;
            this.Btm_Remover.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Teal;
            this.Btm_Remover.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btm_Remover.ForeColor = System.Drawing.SystemColors.Control;
            this.Btm_Remover.Location = new System.Drawing.Point(494, 179);
            this.Btm_Remover.Name = "Btm_Remover";
            this.Btm_Remover.Size = new System.Drawing.Size(198, 23);
            this.Btm_Remover.TabIndex = 11;
            this.Btm_Remover.Text = "Remover";
            this.Btm_Remover.UseVisualStyleBackColor = false;
            this.Btm_Remover.Click += new System.EventHandler(this.Btm_Remover_Click);
            // 
            // Lbl_CorrenteTotal
            // 
            this.Lbl_CorrenteTotal.AutoSize = true;
            this.Lbl_CorrenteTotal.Location = new System.Drawing.Point(12, 125);
            this.Lbl_CorrenteTotal.Name = "Lbl_CorrenteTotal";
            this.Lbl_CorrenteTotal.Size = new System.Drawing.Size(50, 13);
            this.Lbl_CorrenteTotal.TabIndex = 12;
            this.Lbl_CorrenteTotal.Text = "Corrente:";
            // 
            // Btm_Calcular
            // 
            this.Btm_Calcular.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightGray;
            this.Btm_Calcular.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btm_Calcular.Location = new System.Drawing.Point(53, 179);
            this.Btm_Calcular.Name = "Btm_Calcular";
            this.Btm_Calcular.Size = new System.Drawing.Size(223, 23);
            this.Btm_Calcular.TabIndex = 13;
            this.Btm_Calcular.Text = "Cálcular";
            this.Btm_Calcular.UseVisualStyleBackColor = true;
            this.Btm_Calcular.Click += new System.EventHandler(this.Btm_Calcular_Click);
            // 
            // Txt_Tensão
            // 
            this.Txt_Tensão.Location = new System.Drawing.Point(94, 12);
            this.Txt_Tensão.Name = "Txt_Tensão";
            this.Txt_Tensão.Size = new System.Drawing.Size(167, 20);
            this.Txt_Tensão.TabIndex = 15;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(10, 15);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(28, 13);
            this.label3.TabIndex = 14;
            this.label3.Text = "VAB";
            // 
            // Frm_Serie
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.ClientSize = new System.Drawing.Size(704, 217);
            this.Controls.Add(this.Txt_Tensão);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Btm_Calcular);
            this.Controls.Add(this.Lbl_CorrenteTotal);
            this.Controls.Add(this.Btm_Remover);
            this.Controls.Add(this.Btm_Adicionar);
            this.Controls.Add(this.Txt_Resistor);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Lbl_Req);
            this.Controls.Add(this.listResistores);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Frm_Serie";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Associação Série";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ListBox listResistores;
        private System.Windows.Forms.Label Lbl_Req;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox Txt_Resistor;
        private System.Windows.Forms.Button Btm_Adicionar;
        private System.Windows.Forms.Button Btm_Remover;
        private System.Windows.Forms.Label Lbl_CorrenteTotal;
        private System.Windows.Forms.Button Btm_Calcular;
        private System.Windows.Forms.TextBox Txt_Tensão;
        private System.Windows.Forms.Label label3;
    }
}