namespace Learn_0801_24.Forms
{
    partial class FormMain
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
            this.tbStatusSys = new System.Windows.Forms.TextBox();
            this.lbStatusSys = new System.Windows.Forms.Label();
            this.btnStart = new System.Windows.Forms.Button();
            this.btnStop = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.lbCounterBottle = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // tbStatusSys
            // 
            this.tbStatusSys.Location = new System.Drawing.Point(110, 525);
            this.tbStatusSys.Name = "tbStatusSys";
            this.tbStatusSys.Size = new System.Drawing.Size(1045, 22);
            this.tbStatusSys.TabIndex = 34;
            // 
            // lbStatusSys
            // 
            this.lbStatusSys.AutoSize = true;
            this.lbStatusSys.Location = new System.Drawing.Point(12, 531);
            this.lbStatusSys.Name = "lbStatusSys";
            this.lbStatusSys.Size = new System.Drawing.Size(92, 16);
            this.lbStatusSys.TabIndex = 33;
            this.lbStatusSys.Text = "Status System";
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(12, 30);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(148, 61);
            this.btnStart.TabIndex = 45;
            this.btnStart.Text = "Start System";
            this.btnStart.UseVisualStyleBackColor = true;
            // 
            // btnStop
            // 
            this.btnStop.Location = new System.Drawing.Point(173, 29);
            this.btnStop.Name = "btnStop";
            this.btnStop.Size = new System.Drawing.Size(148, 61);
            this.btnStop.TabIndex = 46;
            this.btnStop.Text = "Stop System";
            this.btnStop.UseVisualStyleBackColor = true;
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(173, 111);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(148, 61);
            this.btnReset.TabIndex = 47;
            this.btnReset.Text = "Reset System";
            this.btnReset.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(173, 198);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(240, 22);
            this.textBox1.TabIndex = 48;
            // 
            // lbCounterBottle
            // 
            this.lbCounterBottle.AutoSize = true;
            this.lbCounterBottle.Location = new System.Drawing.Point(9, 202);
            this.lbCounterBottle.Name = "lbCounterBottle";
            this.lbCounterBottle.Size = new System.Drawing.Size(90, 16);
            this.lbCounterBottle.TabIndex = 49;
            this.lbCounterBottle.Text = "Counter Bottle";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 254);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 16);
            this.label1.TabIndex = 51;
            this.label1.Text = "Counter Bottle";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(173, 250);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(240, 22);
            this.textBox2.TabIndex = 50;
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1167, 556);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.lbCounterBottle);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.btnStop);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.tbStatusSys);
            this.Controls.Add(this.lbStatusSys);
            this.Name = "FormMain";
            this.Text = "Main Screen";
            this.Load += new System.EventHandler(this.FormMain_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox tbStatusSys;
        private System.Windows.Forms.Label lbStatusSys;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Button btnStop;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label lbCounterBottle;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox2;
    }
}