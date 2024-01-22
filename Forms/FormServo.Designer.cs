namespace Learn_0801_24.Forms
{
    partial class FormServo
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
            this.lbJogSpeed = new System.Windows.Forms.Label();
            this.tbJogSpeed = new System.Windows.Forms.TextBox();
            this.btnHomeServo = new System.Windows.Forms.Button();
            this.btnOffServo = new System.Windows.Forms.Button();
            this.btnOnServo = new System.Windows.Forms.Button();
            this.lbHomeSpeed = new System.Windows.Forms.Label();
            this.tbHomeSpeed = new System.Windows.Forms.TextBox();
            this.rdoHomeDone = new System.Windows.Forms.RadioButton();
            this.lbVelocitySpeed = new System.Windows.Forms.Label();
            this.tbVelocity = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbJogSpeed
            // 
            this.lbJogSpeed.AutoSize = true;
            this.lbJogSpeed.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lbJogSpeed.Location = new System.Drawing.Point(26, 155);
            this.lbJogSpeed.Name = "lbJogSpeed";
            this.lbJogSpeed.Size = new System.Drawing.Size(134, 29);
            this.lbJogSpeed.TabIndex = 56;
            this.lbJogSpeed.Text = "Jog Speed";
            // 
            // tbJogSpeed
            // 
            this.tbJogSpeed.Location = new System.Drawing.Point(182, 163);
            this.tbJogSpeed.Name = "tbJogSpeed";
            this.tbJogSpeed.Size = new System.Drawing.Size(240, 22);
            this.tbJogSpeed.TabIndex = 55;
            // 
            // btnHomeServo
            // 
            this.btnHomeServo.Location = new System.Drawing.Point(581, 55);
            this.btnHomeServo.Name = "btnHomeServo";
            this.btnHomeServo.Size = new System.Drawing.Size(148, 61);
            this.btnHomeServo.TabIndex = 54;
            this.btnHomeServo.Text = "Home Servo";
            this.btnHomeServo.UseVisualStyleBackColor = true;
            // 
            // btnOffServo
            // 
            this.btnOffServo.Location = new System.Drawing.Point(182, 55);
            this.btnOffServo.Name = "btnOffServo";
            this.btnOffServo.Size = new System.Drawing.Size(148, 61);
            this.btnOffServo.TabIndex = 53;
            this.btnOffServo.Text = "Off Servo";
            this.btnOffServo.UseVisualStyleBackColor = true;
            this.btnOffServo.Click += new System.EventHandler(this.btnOffServo_Click);
            // 
            // btnOnServo
            // 
            this.btnOnServo.Location = new System.Drawing.Point(12, 55);
            this.btnOnServo.Name = "btnOnServo";
            this.btnOnServo.Size = new System.Drawing.Size(148, 61);
            this.btnOnServo.TabIndex = 52;
            this.btnOnServo.Text = "On Servo";
            this.btnOnServo.UseVisualStyleBackColor = true;
            this.btnOnServo.Click += new System.EventHandler(this.btnOnServo_Click);
            // 
            // lbHomeSpeed
            // 
            this.lbHomeSpeed.AutoSize = true;
            this.lbHomeSpeed.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lbHomeSpeed.Location = new System.Drawing.Point(-1, 205);
            this.lbHomeSpeed.Name = "lbHomeSpeed";
            this.lbHomeSpeed.Size = new System.Drawing.Size(161, 29);
            this.lbHomeSpeed.TabIndex = 60;
            this.lbHomeSpeed.Text = "Home Speed";
            // 
            // tbHomeSpeed
            // 
            this.tbHomeSpeed.Location = new System.Drawing.Point(182, 213);
            this.tbHomeSpeed.Name = "tbHomeSpeed";
            this.tbHomeSpeed.Size = new System.Drawing.Size(240, 22);
            this.tbHomeSpeed.TabIndex = 59;
            // 
            // rdoHomeDone
            // 
            this.rdoHomeDone.AutoSize = true;
            this.rdoHomeDone.FlatAppearance.BorderSize = 0;
            this.rdoHomeDone.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.rdoHomeDone.Location = new System.Drawing.Point(581, 163);
            this.rdoHomeDone.Name = "rdoHomeDone";
            this.rdoHomeDone.Size = new System.Drawing.Size(169, 33);
            this.rdoHomeDone.TabIndex = 61;
            this.rdoHomeDone.TabStop = true;
            this.rdoHomeDone.Text = "Home Done";
            this.rdoHomeDone.UseVisualStyleBackColor = true;
            // 
            // lbVelocitySpeed
            // 
            this.lbVelocitySpeed.AutoSize = true;
            this.lbVelocitySpeed.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lbVelocitySpeed.Location = new System.Drawing.Point(57, 253);
            this.lbVelocitySpeed.Name = "lbVelocitySpeed";
            this.lbVelocitySpeed.Size = new System.Drawing.Size(103, 29);
            this.lbVelocitySpeed.TabIndex = 63;
            this.lbVelocitySpeed.Text = "Velocity";
            // 
            // tbVelocity
            // 
            this.tbVelocity.Location = new System.Drawing.Point(182, 260);
            this.tbVelocity.Name = "tbVelocity";
            this.tbVelocity.Size = new System.Drawing.Size(240, 22);
            this.tbVelocity.TabIndex = 62;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(97, 352);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(148, 61);
            this.button1.TabIndex = 64;
            this.button1.Text = "Home Servo";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(274, 352);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(148, 61);
            this.button2.TabIndex = 65;
            this.button2.Text = "Home Servo";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(462, 352);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(148, 61);
            this.button3.TabIndex = 66;
            this.button3.Text = "Home Servo";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // FormServo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lbVelocitySpeed);
            this.Controls.Add(this.tbVelocity);
            this.Controls.Add(this.rdoHomeDone);
            this.Controls.Add(this.lbHomeSpeed);
            this.Controls.Add(this.tbHomeSpeed);
            this.Controls.Add(this.lbJogSpeed);
            this.Controls.Add(this.tbJogSpeed);
            this.Controls.Add(this.btnHomeServo);
            this.Controls.Add(this.btnOffServo);
            this.Controls.Add(this.btnOnServo);
            this.Name = "FormServo";
            this.Text = "FormServo";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lbJogSpeed;
        private System.Windows.Forms.TextBox tbJogSpeed;
        private System.Windows.Forms.Button btnHomeServo;
        private System.Windows.Forms.Button btnOffServo;
        private System.Windows.Forms.Button btnOnServo;
        private System.Windows.Forms.Label lbHomeSpeed;
        private System.Windows.Forms.TextBox tbHomeSpeed;
        private System.Windows.Forms.RadioButton rdoHomeDone;
        private System.Windows.Forms.Label lbVelocitySpeed;
        private System.Windows.Forms.TextBox tbVelocity;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
    }
}