namespace Folyok
{
    partial class Folyok
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
            this.FolyokListBox = new System.Windows.Forms.ListBox();
            this.FolyokGBox = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.FolyokGBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // FolyokListBox
            // 
            this.FolyokListBox.Dock = System.Windows.Forms.DockStyle.Left;
            this.FolyokListBox.FormattingEnabled = true;
            this.FolyokListBox.Location = new System.Drawing.Point(0, 0);
            this.FolyokListBox.Name = "FolyokListBox";
            this.FolyokListBox.Size = new System.Drawing.Size(147, 450);
            this.FolyokListBox.TabIndex = 0;
            // 
            // FolyokGBox
            // 
            this.FolyokGBox.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.FolyokGBox.Controls.Add(this.label3);
            this.FolyokGBox.Controls.Add(this.label2);
            this.FolyokGBox.Controls.Add(this.label1);
            this.FolyokGBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.FolyokGBox.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.FolyokGBox.Location = new System.Drawing.Point(147, 0);
            this.FolyokGBox.Name = "FolyokGBox";
            this.FolyokGBox.Size = new System.Drawing.Size(653, 450);
            this.FolyokGBox.TabIndex = 1;
            this.FolyokGBox.TabStop = false;
            this.FolyokGBox.Text = "Folyók Adatai";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(38, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "ID:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(20, 76);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 19);
            this.label2.TabIndex = 1;
            this.label2.Text = "Neve:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(8, 118);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 19);
            this.label3.TabIndex = 2;
            this.label3.Text = "Hossza:";
            // 
            // Folyok
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.FolyokGBox);
            this.Controls.Add(this.FolyokListBox);
            this.Name = "Folyok";
            this.Text = "FolyókGUI";
            this.FolyokGBox.ResumeLayout(false);
            this.FolyokGBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox FolyokListBox;
        private System.Windows.Forms.GroupBox FolyokGBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}

