
namespace TermProject
{
    partial class frmMarketSelection
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
            this.btnNieuwmarkt = new System.Windows.Forms.Button();
            this.btnNoordermarkt = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnNieuwmarkt
            // 
            this.btnNieuwmarkt.Location = new System.Drawing.Point(68, 90);
            this.btnNieuwmarkt.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnNieuwmarkt.Name = "btnNieuwmarkt";
            this.btnNieuwmarkt.Size = new System.Drawing.Size(165, 65);
            this.btnNieuwmarkt.TabIndex = 1;
            this.btnNieuwmarkt.Text = "Nieuwmarkt";
            this.btnNieuwmarkt.UseVisualStyleBackColor = true;
            this.btnNieuwmarkt.Click += new System.EventHandler(this.btnNieuwmarkt_Click);
            // 
            // btnNoordermarkt
            // 
            this.btnNoordermarkt.Location = new System.Drawing.Point(68, 183);
            this.btnNoordermarkt.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnNoordermarkt.Name = "btnNoordermarkt";
            this.btnNoordermarkt.Size = new System.Drawing.Size(165, 65);
            this.btnNoordermarkt.TabIndex = 2;
            this.btnNoordermarkt.Text = "Noordermarkt";
            this.btnNoordermarkt.UseVisualStyleBackColor = true;
            this.btnNoordermarkt.Click += new System.EventHandler(this.btnNoordermarkt_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(44, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(227, 29);
            this.label1.TabIndex = 3;
            this.label1.Text = "Select Your Market";
            // 
            // frmMarketSelection
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(312, 311);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnNoordermarkt);
            this.Controls.Add(this.btnNieuwmarkt);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "frmMarketSelection";
            this.Text = "frmMarketSelection";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnNieuwmarkt;
        private System.Windows.Forms.Button btnNoordermarkt;
        private System.Windows.Forms.Label label1;
    }
}