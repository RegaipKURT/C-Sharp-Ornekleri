namespace delegate_form
{
    partial class Giris
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Giris));
            this.giris_button = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pars_ico_buton = new System.Windows.Forms.Button();
            this.exit = new System.Windows.Forms.Button();
            this.small = new System.Windows.Forms.Button();
            this.ayarla = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // giris_button
            // 
            resources.ApplyResources(this.giris_button, "giris_button");
            this.giris_button.BackColor = System.Drawing.Color.OliveDrab;
            this.giris_button.Name = "giris_button";
            this.giris_button.UseVisualStyleBackColor = false;
            this.giris_button.Click += new System.EventHandler(this.Giris_Click);
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.ForeColor = System.Drawing.Color.DarkGreen;
            this.label1.Name = "label1";
            // 
            // panel1
            // 
            this.panel1.AccessibleRole = System.Windows.Forms.AccessibleRole.TitleBar;
            this.panel1.AllowDrop = true;
            resources.ApplyResources(this.panel1, "panel1");
            this.panel1.BackColor = System.Drawing.Color.LightSeaGreen;
            this.panel1.Controls.Add(this.pars_ico_buton);
            this.panel1.Controls.Add(this.exit);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.small);
            this.panel1.Name = "panel1";
            // 
            // pars_ico_buton
            // 
            this.pars_ico_buton.AccessibleRole = System.Windows.Forms.AccessibleRole.TitleBar;
            resources.ApplyResources(this.pars_ico_buton, "pars_ico_buton");
            this.pars_ico_buton.BackgroundImage = global::delegate_form.Properties.Resources.pars_ico;
            this.pars_ico_buton.Name = "pars_ico_buton";
            this.pars_ico_buton.UseVisualStyleBackColor = true;
            // 
            // exit
            // 
            resources.ApplyResources(this.exit, "exit");
            this.exit.BackColor = System.Drawing.Color.Transparent;
            this.exit.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.exit.Name = "exit";
            this.exit.UseVisualStyleBackColor = false;
            this.exit.Click += new System.EventHandler(this.exit_Click);
            // 
            // small
            // 
            resources.ApplyResources(this.small, "small");
            this.small.BackColor = System.Drawing.Color.Transparent;
            this.small.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveBorder;
            this.small.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ActiveBorder;
            this.small.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.small.Name = "small";
            this.small.UseVisualStyleBackColor = false;
            this.small.Click += new System.EventHandler(this.small_Click);
            // 
            // ayarla
            // 
            resources.ApplyResources(this.ayarla, "ayarla");
            this.ayarla.Name = "ayarla";
            this.ayarla.UseVisualStyleBackColor = true;
            this.ayarla.Click += new System.EventHandler(this.ayarla_Click);
            // 
            // Giris
            // 
            this.AcceptButton = this.giris_button;
            this.AccessibleRole = System.Windows.Forms.AccessibleRole.Window;
            this.AllowDrop = true;
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.CancelButton = this.exit;
            this.Controls.Add(this.ayarla);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.giris_button);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Giris";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button giris_button;
        private System.Windows.Forms.Button small;
        private System.Windows.Forms.Button exit;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button ayarla;
        private System.Windows.Forms.Button pars_ico_buton;
    }
}

