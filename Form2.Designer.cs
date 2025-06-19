namespace Calculadora_Top
{
    partial class Form2
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
            btnMenu = new Button();
            sidebarPanel = new Panel();
            btnTemp = new Button();
            btnMedia = new Button();
            btnIMC = new Button();
            btnCalcSimples = new Button();
            sidebarPanel.SuspendLayout();
            SuspendLayout();
            // 
            // btnMenu
            // 
            btnMenu.Dock = DockStyle.Left;
            btnMenu.FlatStyle = FlatStyle.Flat;
            btnMenu.Location = new Point(131, 0);
            btnMenu.Name = "btnMenu";
            btnMenu.Size = new Size(64, 450);
            btnMenu.TabIndex = 3;
            btnMenu.Text = "Menu";
            btnMenu.UseVisualStyleBackColor = true;
            btnMenu.Click += btnMenu_Click;
            // 
            // sidebarPanel
            // 
            sidebarPanel.BackColor = SystemColors.ActiveBorder;
            sidebarPanel.Controls.Add(btnTemp);
            sidebarPanel.Controls.Add(btnMedia);
            sidebarPanel.Controls.Add(btnIMC);
            sidebarPanel.Controls.Add(btnCalcSimples);
            sidebarPanel.Dock = DockStyle.Left;
            sidebarPanel.Location = new Point(0, 0);
            sidebarPanel.Name = "sidebarPanel";
            sidebarPanel.Size = new Size(131, 450);
            sidebarPanel.TabIndex = 2;
            sidebarPanel.Paint += sidebarPanel_Paint;
            // 
            // btnTemp
            // 
            btnTemp.Dock = DockStyle.Top;
            btnTemp.Location = new Point(0, 69);
            btnTemp.Name = "btnTemp";
            btnTemp.Size = new Size(131, 23);
            btnTemp.TabIndex = 3;
            btnTemp.Text = "C º Para F °";
            btnTemp.UseVisualStyleBackColor = true;
            // 
            // btnMedia
            // 
            btnMedia.Dock = DockStyle.Top;
            btnMedia.Location = new Point(0, 46);
            btnMedia.Name = "btnMedia";
            btnMedia.Size = new Size(131, 23);
            btnMedia.TabIndex = 2;
            btnMedia.Text = "Media";
            btnMedia.UseVisualStyleBackColor = true;
            // 
            // btnIMC
            // 
            btnIMC.Dock = DockStyle.Top;
            btnIMC.Location = new Point(0, 23);
            btnIMC.Name = "btnIMC";
            btnIMC.Size = new Size(131, 23);
            btnIMC.TabIndex = 1;
            btnIMC.Text = "IMC";
            btnIMC.UseVisualStyleBackColor = true;
            // 
            // btnCalcSimples
            // 
            btnCalcSimples.Dock = DockStyle.Top;
            btnCalcSimples.Location = new Point(0, 0);
            btnCalcSimples.Name = "btnCalcSimples";
            btnCalcSimples.Size = new Size(131, 23);
            btnCalcSimples.TabIndex = 0;
            btnCalcSimples.Text = "Calculadora Simples";
            btnCalcSimples.UseVisualStyleBackColor = true;
            btnCalcSimples.Click += btnCalcSimples_Click;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnMenu);
            Controls.Add(sidebarPanel);
            Name = "Form2";
            Text = "Form2";
            sidebarPanel.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Button btnMenu;
        private Panel sidebarPanel;
        private Button btnTemp;
        private Button btnMedia;
        private Button btnIMC;
        private Button btnCalcSimples;
    }
}