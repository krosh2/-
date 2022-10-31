namespace Практика
{
    partial class Form3
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.host3DataSet = new Практика.host3DataSet();
            this.paymentBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.paymentTableAdapter = new Практика.host3DataSetTableAdapters.PaymentTableAdapter();
            this.iDPaymentDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.datePriceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.priceYslugDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iDDopolnitelnyaeYslugiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iDPaymentMethodDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iDCustomersDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iDStaffDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.host3DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.paymentBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDPaymentDataGridViewTextBoxColumn,
            this.datePriceDataGridViewTextBoxColumn,
            this.priceYslugDataGridViewTextBoxColumn,
            this.iDDopolnitelnyaeYslugiDataGridViewTextBoxColumn,
            this.iDPaymentMethodDataGridViewTextBoxColumn,
            this.iDCustomersDataGridViewTextBoxColumn,
            this.iDStaffDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.paymentBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(23, 59);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(666, 263);
            this.dataGridView1.TabIndex = 0;
            // 
            // host3DataSet
            // 
            this.host3DataSet.DataSetName = "host3DataSet";
            this.host3DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // paymentBindingSource
            // 
            this.paymentBindingSource.DataMember = "Payment";
            this.paymentBindingSource.DataSource = this.host3DataSet;
            // 
            // paymentTableAdapter
            // 
            this.paymentTableAdapter.ClearBeforeFill = true;
            // 
            // iDPaymentDataGridViewTextBoxColumn
            // 
            this.iDPaymentDataGridViewTextBoxColumn.DataPropertyName = "ID_Payment";
            this.iDPaymentDataGridViewTextBoxColumn.HeaderText = "ID_Payment";
            this.iDPaymentDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.iDPaymentDataGridViewTextBoxColumn.Name = "iDPaymentDataGridViewTextBoxColumn";
            this.iDPaymentDataGridViewTextBoxColumn.Width = 150;
            // 
            // datePriceDataGridViewTextBoxColumn
            // 
            this.datePriceDataGridViewTextBoxColumn.DataPropertyName = "Date price";
            this.datePriceDataGridViewTextBoxColumn.HeaderText = "Date price";
            this.datePriceDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.datePriceDataGridViewTextBoxColumn.Name = "datePriceDataGridViewTextBoxColumn";
            this.datePriceDataGridViewTextBoxColumn.Width = 150;
            // 
            // priceYslugDataGridViewTextBoxColumn
            // 
            this.priceYslugDataGridViewTextBoxColumn.DataPropertyName = "Price yslug";
            this.priceYslugDataGridViewTextBoxColumn.HeaderText = "Price yslug";
            this.priceYslugDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.priceYslugDataGridViewTextBoxColumn.Name = "priceYslugDataGridViewTextBoxColumn";
            this.priceYslugDataGridViewTextBoxColumn.Width = 150;
            // 
            // iDDopolnitelnyaeYslugiDataGridViewTextBoxColumn
            // 
            this.iDDopolnitelnyaeYslugiDataGridViewTextBoxColumn.DataPropertyName = "ID_Dopolnitelnyae Yslugi";
            this.iDDopolnitelnyaeYslugiDataGridViewTextBoxColumn.HeaderText = "ID_Dopolnitelnyae Yslugi";
            this.iDDopolnitelnyaeYslugiDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.iDDopolnitelnyaeYslugiDataGridViewTextBoxColumn.Name = "iDDopolnitelnyaeYslugiDataGridViewTextBoxColumn";
            this.iDDopolnitelnyaeYslugiDataGridViewTextBoxColumn.Width = 150;
            // 
            // iDPaymentMethodDataGridViewTextBoxColumn
            // 
            this.iDPaymentMethodDataGridViewTextBoxColumn.DataPropertyName = "ID_Payment method";
            this.iDPaymentMethodDataGridViewTextBoxColumn.HeaderText = "ID_Payment method";
            this.iDPaymentMethodDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.iDPaymentMethodDataGridViewTextBoxColumn.Name = "iDPaymentMethodDataGridViewTextBoxColumn";
            this.iDPaymentMethodDataGridViewTextBoxColumn.Width = 150;
            // 
            // iDCustomersDataGridViewTextBoxColumn
            // 
            this.iDCustomersDataGridViewTextBoxColumn.DataPropertyName = "ID_Customers";
            this.iDCustomersDataGridViewTextBoxColumn.HeaderText = "ID_Customers";
            this.iDCustomersDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.iDCustomersDataGridViewTextBoxColumn.Name = "iDCustomersDataGridViewTextBoxColumn";
            this.iDCustomersDataGridViewTextBoxColumn.Width = 150;
            // 
            // iDStaffDataGridViewTextBoxColumn
            // 
            this.iDStaffDataGridViewTextBoxColumn.DataPropertyName = "ID_Staff";
            this.iDStaffDataGridViewTextBoxColumn.HeaderText = "ID_Staff";
            this.iDStaffDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.iDStaffDataGridViewTextBoxColumn.Name = "iDStaffDataGridViewTextBoxColumn";
            this.iDStaffDataGridViewTextBoxColumn.Width = 150;
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(882, 450);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form3";
            this.Text = "Оплата услуг";
            this.Load += new System.EventHandler(this.Form3_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.host3DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.paymentBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private host3DataSet host3DataSet;
        private System.Windows.Forms.BindingSource paymentBindingSource;
        private host3DataSetTableAdapters.PaymentTableAdapter paymentTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDPaymentDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn datePriceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn priceYslugDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDDopolnitelnyaeYslugiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDPaymentMethodDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDCustomersDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDStaffDataGridViewTextBoxColumn;
    }
}