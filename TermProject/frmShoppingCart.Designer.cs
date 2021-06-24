
namespace TermProject
{
    partial class frmShoppingCart
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
            this.components = new System.ComponentModel.Container();
            this.btnConfirmYourOrder = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.dataSet1 = new TermProject.DataSet1();
            this.shoppingCartTableBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.shoppingCartTableTableAdapter = new TermProject.DataSet1TableAdapters.ShoppingCartTableTableAdapter();
            this.shoppingCartIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.userIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.shoppingCartTableBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // btnConfirmYourOrder
            // 
            this.btnConfirmYourOrder.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConfirmYourOrder.Location = new System.Drawing.Point(32, 373);
            this.btnConfirmYourOrder.Name = "btnConfirmYourOrder";
            this.btnConfirmYourOrder.Size = new System.Drawing.Size(369, 44);
            this.btnConfirmYourOrder.TabIndex = 1;
            this.btnConfirmYourOrder.Text = "Confirm Your Order";
            this.btnConfirmYourOrder.UseVisualStyleBackColor = true;
            this.btnConfirmYourOrder.Click += new System.EventHandler(this.btnConfirmYourOrder_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.shoppingCartIDDataGridViewTextBoxColumn,
            this.userIDDataGridViewTextBoxColumn,
            this.productIDDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.shoppingCartTableBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(12, 25);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(560, 333);
            this.dataGridView1.TabIndex = 2;
            // 
            // dataSet1
            // 
            this.dataSet1.DataSetName = "DataSet1";
            this.dataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // shoppingCartTableBindingSource
            // 
            this.shoppingCartTableBindingSource.DataMember = "ShoppingCartTable";
            this.shoppingCartTableBindingSource.DataSource = this.dataSet1;
            // 
            // shoppingCartTableTableAdapter
            // 
            this.shoppingCartTableTableAdapter.ClearBeforeFill = true;
            // 
            // shoppingCartIDDataGridViewTextBoxColumn
            // 
            this.shoppingCartIDDataGridViewTextBoxColumn.DataPropertyName = "ShoppingCartID";
            this.shoppingCartIDDataGridViewTextBoxColumn.HeaderText = "ShoppingCartID";
            this.shoppingCartIDDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.shoppingCartIDDataGridViewTextBoxColumn.Name = "shoppingCartIDDataGridViewTextBoxColumn";
            this.shoppingCartIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.shoppingCartIDDataGridViewTextBoxColumn.Width = 125;
            // 
            // userIDDataGridViewTextBoxColumn
            // 
            this.userIDDataGridViewTextBoxColumn.DataPropertyName = "UserID";
            this.userIDDataGridViewTextBoxColumn.HeaderText = "UserID";
            this.userIDDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.userIDDataGridViewTextBoxColumn.Name = "userIDDataGridViewTextBoxColumn";
            this.userIDDataGridViewTextBoxColumn.Width = 125;
            // 
            // productIDDataGridViewTextBoxColumn
            // 
            this.productIDDataGridViewTextBoxColumn.DataPropertyName = "ProductID";
            this.productIDDataGridViewTextBoxColumn.HeaderText = "ProductID";
            this.productIDDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.productIDDataGridViewTextBoxColumn.Name = "productIDDataGridViewTextBoxColumn";
            this.productIDDataGridViewTextBoxColumn.Width = 125;
            // 
            // frmShoppingCart
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(593, 453);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnConfirmYourOrder);
            this.Name = "frmShoppingCart";
            this.Text = "frmShoppingCart";
            this.Load += new System.EventHandler(this.frmShoppingCart_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.shoppingCartTableBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnConfirmYourOrder;
        private System.Windows.Forms.DataGridView dataGridView1;
        private DataSet1 dataSet1;
        private System.Windows.Forms.BindingSource shoppingCartTableBindingSource;
        private DataSet1TableAdapters.ShoppingCartTableTableAdapter shoppingCartTableTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn shoppingCartIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn userIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn productIDDataGridViewTextBoxColumn;
    }
}