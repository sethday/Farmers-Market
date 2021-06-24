
namespace TermProject
{
    partial class frmNieuwmarktVendorSelection
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
            this.btnSallysSalsa = new System.Windows.Forms.Button();
            this.btnFruitGiant = new System.Windows.Forms.Button();
            this.btnFresherThanFresh = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnSallysSalsa
            // 
            this.btnSallysSalsa.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSallysSalsa.Location = new System.Drawing.Point(92, 85);
            this.btnSallysSalsa.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnSallysSalsa.Name = "btnSallysSalsa";
            this.btnSallysSalsa.Size = new System.Drawing.Size(161, 58);
            this.btnSallysSalsa.TabIndex = 1;
            this.btnSallysSalsa.Text = "Sally\'s Salsa";
            this.btnSallysSalsa.UseVisualStyleBackColor = true;
            this.btnSallysSalsa.Click += new System.EventHandler(this.btnSallysSalsa_Click);
            // 
            // btnFruitGiant
            // 
            this.btnFruitGiant.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFruitGiant.Location = new System.Drawing.Point(92, 151);
            this.btnFruitGiant.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnFruitGiant.Name = "btnFruitGiant";
            this.btnFruitGiant.Size = new System.Drawing.Size(161, 58);
            this.btnFruitGiant.TabIndex = 2;
            this.btnFruitGiant.Text = "Fruit Giant";
            this.btnFruitGiant.UseVisualStyleBackColor = true;
            this.btnFruitGiant.Click += new System.EventHandler(this.btnFruitGiant_Click);
            // 
            // btnFresherThanFresh
            // 
            this.btnFresherThanFresh.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFresherThanFresh.Location = new System.Drawing.Point(92, 217);
            this.btnFresherThanFresh.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnFresherThanFresh.Name = "btnFresherThanFresh";
            this.btnFresherThanFresh.Size = new System.Drawing.Size(161, 58);
            this.btnFresherThanFresh.TabIndex = 3;
            this.btnFresherThanFresh.Text = "Fresher Than Fresh";
            this.btnFresherThanFresh.UseVisualStyleBackColor = true;
            this.btnFresherThanFresh.Click += new System.EventHandler(this.btnFresherThanFresh_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(40, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(278, 25);
            this.label1.TabIndex = 4;
            this.label1.Text = "Where would you like to shop?";
            // 
            // frmNieuwmarktVendorSelection
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(357, 333);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnFresherThanFresh);
            this.Controls.Add(this.btnFruitGiant);
            this.Controls.Add(this.btnSallysSalsa);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "frmNieuwmarktVendorSelection";
            this.Text = "frmNieuwmarktVendorSelection";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnSallysSalsa;
        private System.Windows.Forms.Button btnFruitGiant;
        private System.Windows.Forms.Button btnFresherThanFresh;
        private System.Windows.Forms.Label label1;
    }
}