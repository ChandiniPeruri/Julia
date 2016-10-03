namespace Julia
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
            this.c0Val = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.c1Val = new System.Windows.Forms.Label();
            this.Graph_Button = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // c0Val
            // 
            this.c0Val.AutoSize = true;
            this.c0Val.Location = new System.Drawing.Point(12, 101);
            this.c0Val.Name = "c0Val";
            this.c0Val.Size = new System.Drawing.Size(25, 13);
            this.c0Val.TabIndex = 0;
            this.c0Val.Text = "c0 :";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(43, 98);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(48, 20);
            this.textBox1.TabIndex = 1;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(43, 151);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(48, 20);
            this.textBox2.TabIndex = 2;
            // 
            // c1Val
            // 
            this.c1Val.AutoSize = true;
            this.c1Val.Location = new System.Drawing.Point(12, 154);
            this.c1Val.Name = "c1Val";
            this.c1Val.Size = new System.Drawing.Size(25, 13);
            this.c1Val.TabIndex = 3;
            this.c1Val.Text = "c1 :";
            // 
            // Graph_Button
            // 
            this.Graph_Button.Location = new System.Drawing.Point(12, 201);
            this.Graph_Button.Name = "Graph_Button";
            this.Graph_Button.Size = new System.Drawing.Size(75, 23);
            this.Graph_Button.TabIndex = 4;
            this.Graph_Button.TabStop = false;
            this.Graph_Button.Text = "Graph";
            this.Graph_Button.UseVisualStyleBackColor = true;
            this.Graph_Button.Click += new System.EventHandler(this.Graph_Button_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(109, 6);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(800, 800);
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Paint += new System.Windows.Forms.PaintEventHandler(this.PictureBox_PaintEvent);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(983, 920);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.Graph_Button);
            this.Controls.Add(this.c1Val);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.c0Val);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label c0Val;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label c1Val;
        private System.Windows.Forms.Button Graph_Button;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

