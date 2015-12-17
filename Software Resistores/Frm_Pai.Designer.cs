namespace SoftwareResistores
{
    partial class Frm_Pai
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_Pai));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.Btm_Mista = new System.Windows.Forms.Button();
            this.Btm_Paralelo = new System.Windows.Forms.Button();
            this.Btm_Serie = new System.Windows.Forms.Button();
            this.Btm_Cores = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(47, 103);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Código de cores";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(37, 230);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(104, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Associação em serie";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(30, 377);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(119, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Associação em paralelo";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(45, 506);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(89, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Associação mista";
            // 
            // Btm_Mista
            // 
            this.Btm_Mista.BackgroundImage = global::SoftwareResistores.Properties.Resources.Resistor3_1001;
            this.Btm_Mista.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Btm_Mista.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.Btm_Mista.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btm_Mista.Location = new System.Drawing.Point(40, 414);
            this.Btm_Mista.Name = "Btm_Mista";
            this.Btm_Mista.Size = new System.Drawing.Size(99, 89);
            this.Btm_Mista.TabIndex = 9;
            this.Btm_Mista.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.Btm_Mista.UseVisualStyleBackColor = true;
            // 
            // Btm_Paralelo
            // 
            this.Btm_Paralelo.BackgroundImage = global::SoftwareResistores.Properties.Resources.Resistor_Filled_100;
            this.Btm_Paralelo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Btm_Paralelo.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.Btm_Paralelo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btm_Paralelo.Location = new System.Drawing.Point(40, 285);
            this.Btm_Paralelo.Name = "Btm_Paralelo";
            this.Btm_Paralelo.Size = new System.Drawing.Size(99, 89);
            this.Btm_Paralelo.TabIndex = 6;
            this.Btm_Paralelo.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.Btm_Paralelo.UseVisualStyleBackColor = true;
            // 
            // Btm_Serie
            // 
            this.Btm_Serie.BackgroundImage = global::SoftwareResistores.Properties.Resources.Resistor2_100;
            this.Btm_Serie.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Btm_Serie.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.Btm_Serie.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btm_Serie.Location = new System.Drawing.Point(40, 138);
            this.Btm_Serie.Name = "Btm_Serie";
            this.Btm_Serie.Size = new System.Drawing.Size(99, 89);
            this.Btm_Serie.TabIndex = 4;
            this.Btm_Serie.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.Btm_Serie.UseVisualStyleBackColor = true;
            this.Btm_Serie.Click += new System.EventHandler(this.Btm_Serie_Click);
            // 
            // Btm_Cores
            // 
            this.Btm_Cores.BackgroundImage = global::SoftwareResistores.Properties.Resources.Resistor_100;
            this.Btm_Cores.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Btm_Cores.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.Btm_Cores.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btm_Cores.Location = new System.Drawing.Point(40, 11);
            this.Btm_Cores.Name = "Btm_Cores";
            this.Btm_Cores.Size = new System.Drawing.Size(99, 89);
            this.Btm_Cores.TabIndex = 0;
            this.Btm_Cores.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.Btm_Cores.UseVisualStyleBackColor = true;
            this.Btm_Cores.Click += new System.EventHandler(this.Btm_Cores_Click);
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.panel1.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.Btm_Cores);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.Btm_Mista);
            this.panel1.Controls.Add(this.Btm_Serie);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.Btm_Paralelo);
            this.panel1.Location = new System.Drawing.Point(1, 1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 610);
            this.panel1.TabIndex = 11;
            // 
            // Frm_Pai
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(1115, 614);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.Name = "Frm_Pai";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Retisrores";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Frm_Pai_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Btm_Cores;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button Btm_Serie;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button Btm_Paralelo;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button Btm_Mista;
        private System.Windows.Forms.Panel panel1;
    }
}