namespace WindowsFormsApp1
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
            this.btn_Green = new System.Windows.Forms.Button();
            this.btn_Blue = new System.Windows.Forms.Button();
            this.btn_Red = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_Green
            // 
            this.btn_Green.Location = new System.Drawing.Point(345, 204);
            this.btn_Green.Name = "btn_Green";
            this.btn_Green.Size = new System.Drawing.Size(75, 23);
            this.btn_Green.TabIndex = 0;
            this.btn_Green.Text = "GREEN";
            this.btn_Green.UseVisualStyleBackColor = true;
            // 
            // btn_Blue
            // 
            this.btn_Blue.Location = new System.Drawing.Point(468, 204);
            this.btn_Blue.Name = "btn_Blue";
            this.btn_Blue.Size = new System.Drawing.Size(75, 23);
            this.btn_Blue.TabIndex = 1;
            this.btn_Blue.Text = "BLUE";
            this.btn_Blue.UseVisualStyleBackColor = true;
            // 
            // btn_Red
            // 
            this.btn_Red.Location = new System.Drawing.Point(225, 204);
            this.btn_Red.Name = "btn_Red";
            this.btn_Red.Size = new System.Drawing.Size(75, 23);
            this.btn_Red.TabIndex = 2;
            this.btn_Red.Text = "RED";
            this.btn_Red.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_Red);
            this.Controls.Add(this.btn_Blue);
            this.Controls.Add(this.btn_Green);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_Green;
        private System.Windows.Forms.Button btn_Blue;
        private System.Windows.Forms.Button btn_Red;
    }
}

