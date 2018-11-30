namespace evaluation6
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
            this.usrnm = new System.Windows.Forms.TextBox();
            this.pass = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.log = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // usrnm
            // 
            this.usrnm.Location = new System.Drawing.Point(200, 65);
            this.usrnm.Name = "usrnm";
            this.usrnm.Size = new System.Drawing.Size(100, 20);
            this.usrnm.TabIndex = 0;
            // 
            // pass
            // 
            this.pass.Location = new System.Drawing.Point(200, 117);
            this.pass.Name = "pass";
            this.pass.Size = new System.Drawing.Size(100, 20);
            this.pass.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(77, 75);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Username";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(79, 117);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Password";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // log
            // 
            this.log.Location = new System.Drawing.Point(155, 195);
            this.log.Name = "log";
            this.log.Size = new System.Drawing.Size(75, 23);
            this.log.TabIndex = 4;
            this.log.Text = "LOGIN";
            this.log.UseVisualStyleBackColor = true;
            this.log.Click += new System.EventHandler(this.log_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.log);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pass);
            this.Controls.Add(this.usrnm);
            this.Name = "Form1";
            this.Text = "Login Page";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox usrnm;
        private System.Windows.Forms.TextBox pass;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button log;
    }
}

