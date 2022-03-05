namespace TpTreading
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
            this.btntread1 = new System.Windows.Forms.Button();
            this.btnthread2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btntread1
            // 
            this.btntread1.Location = new System.Drawing.Point(12, 12);
            this.btntread1.Name = "btntread1";
            this.btntread1.Size = new System.Drawing.Size(75, 23);
            this.btntread1.TabIndex = 0;
            this.btntread1.Text = "Thread1";
            this.btntread1.UseVisualStyleBackColor = true;
            this.btntread1.Click += new System.EventHandler(this.btntread1_Click);
            // 
            // btnthread2
            // 
            this.btnthread2.Location = new System.Drawing.Point(93, 12);
            this.btnthread2.Name = "btnthread2";
            this.btnthread2.Size = new System.Drawing.Size(75, 23);
            this.btnthread2.TabIndex = 1;
            this.btnthread2.Text = "Thread2";
            this.btnthread2.UseVisualStyleBackColor = true;
            this.btnthread2.Click += new System.EventHandler(this.btnthread2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(638, 367);
            this.Controls.Add(this.btnthread2);
            this.Controls.Add(this.btntread1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btntread1;
        private System.Windows.Forms.Button btnthread2;
    }
}

