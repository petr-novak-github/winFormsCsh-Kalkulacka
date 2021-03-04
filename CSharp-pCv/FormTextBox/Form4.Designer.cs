namespace FormTextBox
{
    partial class Form4
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
            this.button1 = new System.Windows.Forms.Button();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.mujTextBox1 = new FormTextBox.MujTextBox();
            this.mujTextBox2 = new FormTextBox.MujTextBox();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(54, 117);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(99, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "secti";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(53, 160);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(100, 20);
            this.textBox3.TabIndex = 3;
            // 
            // mujTextBox1
            // 
            this.mujTextBox1.Location = new System.Drawing.Point(54, 33);
            this.mujTextBox1.Name = "mujTextBox1";
            this.mujTextBox1.PosledniPlatnyText = null;
            this.mujTextBox1.Size = new System.Drawing.Size(124, 20);
            this.mujTextBox1.TabIndex = 4;
            this.mujTextBox1.TextChanged += new System.EventHandler(this.mujTextBox_TextChanged);
            // 
            // mujTextBox2
            // 
            this.mujTextBox2.Location = new System.Drawing.Point(53, 75);
            this.mujTextBox2.Name = "mujTextBox2";
            this.mujTextBox2.PosledniPlatnyText = null;
            this.mujTextBox2.Size = new System.Drawing.Size(124, 20);
            this.mujTextBox2.TabIndex = 5;
            this.mujTextBox2.TextChanged += new System.EventHandler(this.mujTextBox_TextChanged);
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.mujTextBox2);
            this.Controls.Add(this.mujTextBox1);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.button1);
            this.Name = "Form4";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox3;
        private MujTextBox mujTextBox1;
        private MujTextBox mujTextBox2;
    }
}

