
namespace Loan.FORMS
{
    partial class Frm_Employee
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
            this.Btn_Exit = new FontAwesome.Sharp.IconButton();
            this.panel_Content = new System.Windows.Forms.Panel();
            this.panel_Left = new System.Windows.Forms.Panel();
            this.panel_Content.SuspendLayout();
            this.SuspendLayout();
            // 
            // Btn_Exit
            // 
            this.Btn_Exit.FlatAppearance.BorderSize = 0;
            this.Btn_Exit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_Exit.Font = new System.Drawing.Font("Khmer OS Siemreap", 10F);
            this.Btn_Exit.ForeColor = System.Drawing.Color.MistyRose;
            this.Btn_Exit.IconChar = FontAwesome.Sharp.IconChar.WindowClose;
            this.Btn_Exit.IconColor = System.Drawing.Color.LightCoral;
            this.Btn_Exit.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.Btn_Exit.IconSize = 30;
            this.Btn_Exit.Location = new System.Drawing.Point(562, 3);
            this.Btn_Exit.Name = "Btn_Exit";
            this.Btn_Exit.Size = new System.Drawing.Size(35, 35);
            this.Btn_Exit.TabIndex = 6;
            this.Btn_Exit.UseVisualStyleBackColor = true;
            // 
            // panel_Content
            // 
            this.panel_Content.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel_Content.Controls.Add(this.Btn_Exit);
            this.panel_Content.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_Content.Location = new System.Drawing.Point(350, 0);
            this.panel_Content.Name = "panel_Content";
            this.panel_Content.Size = new System.Drawing.Size(600, 565);
            this.panel_Content.TabIndex = 8;
            // 
            // panel_Left
            // 
            this.panel_Left.BackColor = System.Drawing.Color.LightSteelBlue;
            this.panel_Left.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel_Left.Location = new System.Drawing.Point(0, 0);
            this.panel_Left.Name = "panel_Left";
            this.panel_Left.Size = new System.Drawing.Size(350, 565);
            this.panel_Left.TabIndex = 7;
            // 
            // Frm_Employee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 27F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(950, 565);
            this.Controls.Add(this.panel_Content);
            this.Controls.Add(this.panel_Left);
            this.Font = new System.Drawing.Font("Khmer OS Siemreap", 11F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.Name = "Frm_Employee";
            this.Text = "Frm_Employee";
            this.panel_Content.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private FontAwesome.Sharp.IconButton Btn_Exit;
        private System.Windows.Forms.Panel panel_Content;
        private System.Windows.Forms.Panel panel_Left;
    }
}