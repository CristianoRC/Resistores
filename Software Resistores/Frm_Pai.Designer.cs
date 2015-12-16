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
            this.Btm_Cores = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Btm_Cores
            // 
            this.Btm_Cores.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Btm_Cores.BackgroundImage")));
            this.Btm_Cores.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Btm_Cores.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.Btm_Cores.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btm_Cores.Location = new System.Drawing.Point(12, 12);
            this.Btm_Cores.Name = "Btm_Cores";
            this.Btm_Cores.Size = new System.Drawing.Size(117, 96);
            this.Btm_Cores.TabIndex = 0;
            this.Btm_Cores.Text = "Cálculo de cores";
            this.Btm_Cores.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.Btm_Cores.UseVisualStyleBackColor = true;
            this.Btm_Cores.Click += new System.EventHandler(this.Btm_Cores_Click);
            // 
            // Frm_Pai
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(1115, 503);
            this.Controls.Add(this.Btm_Cores);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.Name = "Frm_Pai";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Retisrores";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Btm_Cores;
    }
}