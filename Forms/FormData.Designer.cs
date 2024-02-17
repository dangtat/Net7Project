namespace Learn_0801_24.Forms
{
    partial class FormData
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
            this.dtgvreport = new System.Windows.Forms.DataGridView();
            this.btnExportReport = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvreport)).BeginInit();
            this.SuspendLayout();
            // 
            // dtgvreport
            // 
            this.dtgvreport.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvreport.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dtgvreport.Location = new System.Drawing.Point(0, 0);
            this.dtgvreport.Name = "dtgvreport";
            this.dtgvreport.RowHeadersWidth = 51;
            this.dtgvreport.RowTemplate.Height = 24;
            this.dtgvreport.Size = new System.Drawing.Size(679, 444);
            this.dtgvreport.TabIndex = 0;
            // 
            // btnExportReport
            // 
            this.btnExportReport.Location = new System.Drawing.Point(495, 98);
            this.btnExportReport.Name = "btnExportReport";
            this.btnExportReport.Size = new System.Drawing.Size(75, 23);
            this.btnExportReport.TabIndex = 1;
            this.btnExportReport.Text = "Export";
            this.btnExportReport.UseVisualStyleBackColor = true;
            this.btnExportReport.Click += new System.EventHandler(this.btnExportReport_Click);
            // 
            // FormData
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(679, 444);
            this.Controls.Add(this.btnExportReport);
            this.Controls.Add(this.dtgvreport);
            this.Name = "FormData";
            this.Text = "Data Screen";
            this.Load += new System.EventHandler(this.FormData_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgvreport)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridView dtgvreport;
        private System.Windows.Forms.Button btnExportReport;
    }
}