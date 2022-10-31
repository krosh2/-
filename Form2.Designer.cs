namespace Практика
{
    partial class Form2
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label1 = new System.Windows.Forms.Label();
            this.host3DataSet = new Практика.host3DataSet();
            this.checkinBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.check_inTableAdapter = new Практика.host3DataSetTableAdapters.Check_inTableAdapter();
            this.host3DataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.checkinBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.checkinBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.iDChechinDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fIODataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateupDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.numberOfPeopleDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.priceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.locationDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.numberDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateoutDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iDDopolnitelnyaeYslugiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iDCustomersDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iDStaffDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.host3DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkinBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.host3DataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkinBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkinBindingSource2)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label1.Location = new System.Drawing.Point(25, 26);
            this.label1.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(352, 45);
            this.label1.TabIndex = 0;
            this.label1.Text = "Заселение клиента";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // host3DataSet
            // 
            this.host3DataSet.DataSetName = "host3DataSet";
            this.host3DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // checkinBindingSource
            // 
            this.checkinBindingSource.DataMember = "Check-in";
            this.checkinBindingSource.DataSource = this.host3DataSet;
            // 
            // check_inTableAdapter
            // 
            this.check_inTableAdapter.ClearBeforeFill = true;
            // 
            // host3DataSetBindingSource
            // 
            this.host3DataSetBindingSource.DataSource = this.host3DataSet;
            this.host3DataSetBindingSource.Position = 0;
            // 
            // checkinBindingSource1
            // 
            this.checkinBindingSource1.DataMember = "Check-in";
            this.checkinBindingSource1.DataSource = this.host3DataSetBindingSource;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDChechinDataGridViewTextBoxColumn,
            this.fIODataGridViewTextBoxColumn,
            this.dateupDataGridViewTextBoxColumn,
            this.numberOfPeopleDataGridViewTextBoxColumn,
            this.priceDataGridViewTextBoxColumn,
            this.locationDataGridViewTextBoxColumn,
            this.numberDataGridViewTextBoxColumn,
            this.dateoutDataGridViewTextBoxColumn,
            this.iDDopolnitelnyaeYslugiDataGridViewTextBoxColumn,
            this.iDCustomersDataGridViewTextBoxColumn,
            this.iDStaffDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.checkinBindingSource2;
            this.dataGridView1.Location = new System.Drawing.Point(30, 55);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(910, 261);
            this.dataGridView1.TabIndex = 1;
            // 
            // checkinBindingSource2
            // 
            this.checkinBindingSource2.DataMember = "Check-in";
            this.checkinBindingSource2.DataSource = this.host3DataSet;
            // 
            // iDChechinDataGridViewTextBoxColumn
            // 
            this.iDChechinDataGridViewTextBoxColumn.DataPropertyName = "ID_Chech-in";
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 4F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.iDChechinDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle2;
            this.iDChechinDataGridViewTextBoxColumn.HeaderText = "ID_Chech-in";
            this.iDChechinDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.iDChechinDataGridViewTextBoxColumn.Name = "iDChechinDataGridViewTextBoxColumn";
            this.iDChechinDataGridViewTextBoxColumn.Width = 50;
            // 
            // fIODataGridViewTextBoxColumn
            // 
            this.fIODataGridViewTextBoxColumn.DataPropertyName = "FIO";
            this.fIODataGridViewTextBoxColumn.HeaderText = "FIO";
            this.fIODataGridViewTextBoxColumn.MinimumWidth = 8;
            this.fIODataGridViewTextBoxColumn.Name = "fIODataGridViewTextBoxColumn";
            this.fIODataGridViewTextBoxColumn.Width = 150;
            // 
            // dateupDataGridViewTextBoxColumn
            // 
            this.dateupDataGridViewTextBoxColumn.DataPropertyName = "Dateup";
            this.dateupDataGridViewTextBoxColumn.HeaderText = "Dateup";
            this.dateupDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.dateupDataGridViewTextBoxColumn.Name = "dateupDataGridViewTextBoxColumn";
            this.dateupDataGridViewTextBoxColumn.Width = 150;
            // 
            // numberOfPeopleDataGridViewTextBoxColumn
            // 
            this.numberOfPeopleDataGridViewTextBoxColumn.DataPropertyName = "Number of people";
            this.numberOfPeopleDataGridViewTextBoxColumn.HeaderText = "Number of people";
            this.numberOfPeopleDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.numberOfPeopleDataGridViewTextBoxColumn.Name = "numberOfPeopleDataGridViewTextBoxColumn";
            this.numberOfPeopleDataGridViewTextBoxColumn.Width = 150;
            // 
            // priceDataGridViewTextBoxColumn
            // 
            this.priceDataGridViewTextBoxColumn.DataPropertyName = "Price";
            this.priceDataGridViewTextBoxColumn.HeaderText = "Price";
            this.priceDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.priceDataGridViewTextBoxColumn.Name = "priceDataGridViewTextBoxColumn";
            this.priceDataGridViewTextBoxColumn.Width = 150;
            // 
            // locationDataGridViewTextBoxColumn
            // 
            this.locationDataGridViewTextBoxColumn.DataPropertyName = "Location";
            this.locationDataGridViewTextBoxColumn.HeaderText = "Location";
            this.locationDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.locationDataGridViewTextBoxColumn.Name = "locationDataGridViewTextBoxColumn";
            this.locationDataGridViewTextBoxColumn.Width = 150;
            // 
            // numberDataGridViewTextBoxColumn
            // 
            this.numberDataGridViewTextBoxColumn.DataPropertyName = "Number";
            this.numberDataGridViewTextBoxColumn.HeaderText = "Number";
            this.numberDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.numberDataGridViewTextBoxColumn.Name = "numberDataGridViewTextBoxColumn";
            this.numberDataGridViewTextBoxColumn.Width = 150;
            // 
            // dateoutDataGridViewTextBoxColumn
            // 
            this.dateoutDataGridViewTextBoxColumn.DataPropertyName = "Dateout";
            this.dateoutDataGridViewTextBoxColumn.HeaderText = "Dateout";
            this.dateoutDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.dateoutDataGridViewTextBoxColumn.Name = "dateoutDataGridViewTextBoxColumn";
            this.dateoutDataGridViewTextBoxColumn.Width = 150;
            // 
            // iDDopolnitelnyaeYslugiDataGridViewTextBoxColumn
            // 
            this.iDDopolnitelnyaeYslugiDataGridViewTextBoxColumn.DataPropertyName = "ID_Dopolnitelnyae Yslugi";
            this.iDDopolnitelnyaeYslugiDataGridViewTextBoxColumn.HeaderText = "ID_Dopolnitelnyae Yslugi";
            this.iDDopolnitelnyaeYslugiDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.iDDopolnitelnyaeYslugiDataGridViewTextBoxColumn.Name = "iDDopolnitelnyaeYslugiDataGridViewTextBoxColumn";
            this.iDDopolnitelnyaeYslugiDataGridViewTextBoxColumn.Width = 150;
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
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(21F, 40F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(970, 390);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.Name = "Form2";
            this.Text = "Заселение клиента";
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.host3DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkinBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.host3DataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkinBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkinBindingSource2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private host3DataSet host3DataSet;
        private System.Windows.Forms.BindingSource checkinBindingSource;
        private host3DataSetTableAdapters.Check_inTableAdapter check_inTableAdapter;
        private System.Windows.Forms.BindingSource checkinBindingSource1;
        private System.Windows.Forms.BindingSource host3DataSetBindingSource;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource checkinBindingSource2;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDChechinDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fIODataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateupDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn numberOfPeopleDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn priceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn locationDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn numberDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateoutDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDDopolnitelnyaeYslugiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDCustomersDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDStaffDataGridViewTextBoxColumn;
    }
}