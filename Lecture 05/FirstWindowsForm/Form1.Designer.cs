namespace FirstWindowsForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnChangeBackgroundColor = new System.Windows.Forms.Button();
            this.btnFillText = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Email: ";
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(107, 5);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(307, 20);
            this.txtEmail.TabIndex = 1;
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(107, 49);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(307, 20);
            this.txtPassword.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 57);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Password: ";
            // 
            // btnChangeBackgroundColor
            // 
            this.btnChangeBackgroundColor.Location = new System.Drawing.Point(107, 91);
            this.btnChangeBackgroundColor.Name = "btnChangeBackgroundColor";
            this.btnChangeBackgroundColor.Size = new System.Drawing.Size(307, 23);
            this.btnChangeBackgroundColor.TabIndex = 4;
            this.btnChangeBackgroundColor.Text = "Change Background Color";
            this.btnChangeBackgroundColor.UseVisualStyleBackColor = true;
            this.btnChangeBackgroundColor.Click += new System.EventHandler(this.btnChangeBackgroundColor_Click);
            // 
            // btnFillText
            // 
            this.btnFillText.Location = new System.Drawing.Point(107, 135);
            this.btnFillText.Name = "btnFillText";
            this.btnFillText.Size = new System.Drawing.Size(307, 23);
            this.btnFillText.TabIndex = 5;
            this.btnFillText.Text = "Fill Dummy Text";
            this.btnFillText.UseVisualStyleBackColor = true;
            this.btnFillText.Click += new System.EventHandler(this.btnFillText_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(107, 179);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(307, 23);
            this.btnExit.TabIndex = 6;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(426, 310);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnFillText);
            this.Controls.Add(this.btnChangeBackgroundColor);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnChangeBackgroundColor;
        private System.Windows.Forms.Button btnFillText;
        private System.Windows.Forms.Button btnExit;
    }
}

