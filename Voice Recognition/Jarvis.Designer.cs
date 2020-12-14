
namespace Voice_Recognition
{
    partial class Jarvis
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Jarvis));
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.B_active = new System.Windows.Forms.Button();
            this.B_disable = new System.Windows.Forms.Button();
            this.B_settings = new System.Windows.Forms.Button();
            this.B_commands = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // richTextBox1
            // 
            this.richTextBox1.BackColor = System.Drawing.Color.Maroon;
            this.richTextBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.richTextBox1.Font = new System.Drawing.Font("Adobe Heiti Std R", 14.25F, System.Drawing.FontStyle.Bold);
            this.richTextBox1.ForeColor = System.Drawing.SystemColors.Info;
            this.richTextBox1.Location = new System.Drawing.Point(12, 12);
            this.richTextBox1.Margin = new System.Windows.Forms.Padding(0);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(776, 340);
            this.richTextBox1.TabIndex = 0;
            this.richTextBox1.Text = "----LOG----";
            // 
            // B_active
            // 
            this.B_active.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.B_active.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.B_active.Location = new System.Drawing.Point(12, 364);
            this.B_active.Name = "B_active";
            this.B_active.Size = new System.Drawing.Size(284, 48);
            this.B_active.TabIndex = 1;
            this.B_active.Text = "Activate Voice Recognition";
            this.B_active.UseVisualStyleBackColor = false;
            this.B_active.Click += new System.EventHandler(this.B_active_Click);
            // 
            // B_disable
            // 
            this.B_disable.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.B_disable.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.B_disable.Location = new System.Drawing.Point(302, 364);
            this.B_disable.Name = "B_disable";
            this.B_disable.Size = new System.Drawing.Size(284, 48);
            this.B_disable.TabIndex = 2;
            this.B_disable.Text = "Disable Voice Recognition";
            this.B_disable.UseVisualStyleBackColor = false;
            this.B_disable.Click += new System.EventHandler(this.B_disable_Click);
            // 
            // B_settings
            // 
            this.B_settings.BackColor = System.Drawing.Color.DarkGray;
            this.B_settings.ForeColor = System.Drawing.SystemColors.ControlText;
            this.B_settings.Image = ((System.Drawing.Image)(resources.GetObject("B_settings.Image")));
            this.B_settings.Location = new System.Drawing.Point(669, 364);
            this.B_settings.Margin = new System.Windows.Forms.Padding(1);
            this.B_settings.Name = "B_settings";
            this.B_settings.Size = new System.Drawing.Size(54, 48);
            this.B_settings.TabIndex = 3;
            this.B_settings.UseVisualStyleBackColor = false;
            this.B_settings.Click += new System.EventHandler(this.B_settings_Click);
            // 
            // B_commands
            // 
            this.B_commands.BackColor = System.Drawing.Color.DarkGray;
            this.B_commands.ForeColor = System.Drawing.SystemColors.ControlText;
            this.B_commands.Image = ((System.Drawing.Image)(resources.GetObject("B_commands.Image")));
            this.B_commands.Location = new System.Drawing.Point(734, 364);
            this.B_commands.Margin = new System.Windows.Forms.Padding(1);
            this.B_commands.Name = "B_commands";
            this.B_commands.Size = new System.Drawing.Size(54, 48);
            this.B_commands.TabIndex = 4;
            this.B_commands.UseVisualStyleBackColor = false;
            this.B_commands.Click += new System.EventHandler(this.B_commands_Click);
            // 
            // Jarvis
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Crimson;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.B_commands);
            this.Controls.Add(this.B_settings);
            this.Controls.Add(this.B_disable);
            this.Controls.Add(this.B_active);
            this.Controls.Add(this.richTextBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Jarvis";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Voice Recognition";
            this.Load += new System.EventHandler(this.Jarvis_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Button B_active;
        private System.Windows.Forms.Button B_disable;
        private System.Windows.Forms.Button B_settings;
        private System.Windows.Forms.Button B_commands;
    }
}

