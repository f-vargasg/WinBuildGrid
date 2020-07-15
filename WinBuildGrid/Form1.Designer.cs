namespace WinBuildGrid
{
    partial class Form1
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
            this.butTest = new System.Windows.Forms.Button();
            this.txtOutput = new System.Windows.Forms.TextBox();
            this.txtFormat = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtNumber = new System.Windows.Forms.TextBox();
            this.grid = new System.Windows.Forms.DataGridView();
            this.butFillData = new System.Windows.Forms.Button();
            this.buttManual = new System.Windows.Forms.Button();
            this.txtModel = new System.Windows.Forms.TextBox();
            this.airplaneBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.iDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fuelLeftKgDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.modelDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.grid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.airplaneBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // butTest
            // 
            this.butTest.Location = new System.Drawing.Point(375, 18);
            this.butTest.Name = "butTest";
            this.butTest.Size = new System.Drawing.Size(136, 33);
            this.butTest.TabIndex = 0;
            this.butTest.Text = "Test";
            this.butTest.UseVisualStyleBackColor = true;
            this.butTest.Click += new System.EventHandler(this.butTest_Click);
            // 
            // txtOutput
            // 
            this.txtOutput.Location = new System.Drawing.Point(12, 114);
            this.txtOutput.Multiline = true;
            this.txtOutput.Name = "txtOutput";
            this.txtOutput.Size = new System.Drawing.Size(1193, 96);
            this.txtOutput.TabIndex = 1;
            // 
            // txtFormat
            // 
            this.txtFormat.Location = new System.Drawing.Point(145, 72);
            this.txtFormat.Name = "txtFormat";
            this.txtFormat.Size = new System.Drawing.Size(195, 26);
            this.txtFormat.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 75);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "Format";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 31);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 20);
            this.label2.TabIndex = 5;
            this.label2.Text = "Numero:";
            // 
            // txtNumber
            // 
            this.txtNumber.Location = new System.Drawing.Point(145, 28);
            this.txtNumber.Name = "txtNumber";
            this.txtNumber.Size = new System.Drawing.Size(195, 26);
            this.txtNumber.TabIndex = 4;
            // 
            // grid
            // 
            this.grid.AutoGenerateColumns = false;
            this.grid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDDataGridViewTextBoxColumn,
            this.fuelLeftKgDataGridViewTextBoxColumn,
            this.modelDataGridViewTextBoxColumn});
            this.grid.DataSource = this.airplaneBindingSource;
            this.grid.Location = new System.Drawing.Point(12, 216);
            this.grid.Name = "grid";
            this.grid.Size = new System.Drawing.Size(1169, 396);
            this.grid.TabIndex = 6;
            // 
            // butFillData
            // 
            this.butFillData.Location = new System.Drawing.Point(546, 18);
            this.butFillData.Name = "butFillData";
            this.butFillData.Size = new System.Drawing.Size(136, 33);
            this.butFillData.TabIndex = 7;
            this.butFillData.Text = "FillData";
            this.butFillData.UseVisualStyleBackColor = true;
            this.butFillData.Click += new System.EventHandler(this.butFillData_Click);
            // 
            // buttManual
            // 
            this.buttManual.Location = new System.Drawing.Point(375, 69);
            this.buttManual.Name = "buttManual";
            this.buttManual.Size = new System.Drawing.Size(136, 33);
            this.buttManual.TabIndex = 8;
            this.buttManual.Text = "Manual Fill";
            this.buttManual.UseVisualStyleBackColor = true;
            this.buttManual.Click += new System.EventHandler(this.buttManual_Click);
            // 
            // txtModel
            // 
            this.txtModel.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.airplaneBindingSource, "Model", true));
            this.txtModel.Location = new System.Drawing.Point(19, 618);
            this.txtModel.Name = "txtModel";
            this.txtModel.Size = new System.Drawing.Size(164, 26);
            this.txtModel.TabIndex = 9;
            // 
            // airplaneBindingSource
            // 
            this.airplaneBindingSource.DataSource = typeof(WinBuildGrid.Airplane);
            // 
            // iDDataGridViewTextBoxColumn
            // 
            this.iDDataGridViewTextBoxColumn.DataPropertyName = "ID";
            this.iDDataGridViewTextBoxColumn.HeaderText = "ID";
            this.iDDataGridViewTextBoxColumn.Name = "iDDataGridViewTextBoxColumn";
            this.iDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // fuelLeftKgDataGridViewTextBoxColumn
            // 
            this.fuelLeftKgDataGridViewTextBoxColumn.DataPropertyName = "FuelLeftKg";
            this.fuelLeftKgDataGridViewTextBoxColumn.HeaderText = "FuelLeftKg";
            this.fuelLeftKgDataGridViewTextBoxColumn.Name = "fuelLeftKgDataGridViewTextBoxColumn";
            // 
            // modelDataGridViewTextBoxColumn
            // 
            this.modelDataGridViewTextBoxColumn.DataPropertyName = "Model";
            this.modelDataGridViewTextBoxColumn.HeaderText = "Model";
            this.modelDataGridViewTextBoxColumn.Name = "modelDataGridViewTextBoxColumn";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1200, 692);
            this.Controls.Add(this.txtModel);
            this.Controls.Add(this.buttManual);
            this.Controls.Add(this.butFillData);
            this.Controls.Add(this.grid);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtNumber);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtFormat);
            this.Controls.Add(this.txtOutput);
            this.Controls.Add(this.butTest);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.airplaneBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button butTest;
        private System.Windows.Forms.TextBox txtOutput;
        private System.Windows.Forms.TextBox txtFormat;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtNumber;
        private System.Windows.Forms.DataGridView grid;
        private System.Windows.Forms.Button butFillData;
        private System.Windows.Forms.Button buttManual;
        private System.Windows.Forms.TextBox txtModel;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fuelLeftKgDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn modelDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource airplaneBindingSource;
    }
}

