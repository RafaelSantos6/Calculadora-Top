namespace Calculadora_Top
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            sidebarPanel = new Panel();
            btnTemp = new Button();
            btnMedia = new Button();
            btnIMC = new Button();
            btnCalcSimples = new Button();
            btnMenu = new Button();
            TimerSidebar = new System.Windows.Forms.Timer(components);
            btn1 = new Button();
            btn2 = new Button();
            btn3 = new Button();
            btn0 = new Button();
            btn4 = new Button();
            btn5 = new Button();
            btn6 = new Button();
            btn7 = new Button();
            btn8 = new Button();
            btn9 = new Button();
            txtResult = new TextBox();
            btnPonto = new Button();
            btnIgual = new Button();
            btnDiv = new Button();
            btnSub = new Button();
            btnSoma = new Button();
            btnMult = new Button();
            btnClear = new Button();
            lblOperacao = new Label();
            panel1 = new Panel();
            sidebarPanel.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout();
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
            sidebarPanel.TabIndex = 0;
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
            btnTemp.Click += button4_Click;
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
            btnIMC.Click += btnIMC_Click;
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
            // 
            // btnMenu
            // 
            btnMenu.Dock = DockStyle.Left;
            btnMenu.FlatStyle = FlatStyle.Flat;
            btnMenu.Location = new Point(131, 0);
            btnMenu.Name = "btnMenu";
            btnMenu.Size = new Size(64, 450);
            btnMenu.TabIndex = 1;
            btnMenu.Text = "Menu";
            btnMenu.UseVisualStyleBackColor = true;
            btnMenu.Click += button2_Click;
            // 
            // TimerSidebar
            // 
            TimerSidebar.Enabled = true;
            TimerSidebar.Interval = 10;
            TimerSidebar.Tag = "sidebarPanel";
            TimerSidebar.Tick += timer1_Tick;
            // 
            // btn1
            // 
            btn1.Location = new Point(52, 192);
            btn1.Name = "btn1";
            btn1.Size = new Size(50, 50);
            btn1.TabIndex = 2;
            btn1.Text = "1";
            btn1.UseVisualStyleBackColor = true;
            btn1.Click += btn1_Click;
            // 
            // btn2
            // 
            btn2.Location = new Point(108, 192);
            btn2.Name = "btn2";
            btn2.Size = new Size(50, 50);
            btn2.TabIndex = 3;
            btn2.Text = "2";
            btn2.UseVisualStyleBackColor = true;
            btn2.Click += btn2_Click;
            // 
            // btn3
            // 
            btn3.Location = new Point(164, 192);
            btn3.Name = "btn3";
            btn3.Size = new Size(50, 50);
            btn3.TabIndex = 4;
            btn3.Text = "3";
            btn3.UseVisualStyleBackColor = true;
            btn3.Click += btn3_Click;
            // 
            // btn0
            // 
            btn0.Location = new Point(108, 248);
            btn0.Name = "btn0";
            btn0.Size = new Size(50, 50);
            btn0.TabIndex = 5;
            btn0.Text = "0";
            btn0.UseVisualStyleBackColor = true;
            btn0.Click += btn0_Click;
            // 
            // btn4
            // 
            btn4.Location = new Point(52, 131);
            btn4.Name = "btn4";
            btn4.Size = new Size(50, 50);
            btn4.TabIndex = 6;
            btn4.Text = "4";
            btn4.UseVisualStyleBackColor = true;
            btn4.Click += btn4_Click;
            // 
            // btn5
            // 
            btn5.Location = new Point(108, 131);
            btn5.Name = "btn5";
            btn5.Size = new Size(50, 50);
            btn5.TabIndex = 7;
            btn5.Text = "5";
            btn5.UseVisualStyleBackColor = true;
            btn5.Click += btn5_Click;
            // 
            // btn6
            // 
            btn6.Location = new Point(164, 131);
            btn6.Name = "btn6";
            btn6.Size = new Size(50, 50);
            btn6.TabIndex = 8;
            btn6.Text = "6";
            btn6.UseVisualStyleBackColor = true;
            btn6.Click += btn6_Click;
            // 
            // btn7
            // 
            btn7.Location = new Point(52, 75);
            btn7.Name = "btn7";
            btn7.Size = new Size(50, 50);
            btn7.TabIndex = 9;
            btn7.Text = "7";
            btn7.UseVisualStyleBackColor = true;
            btn7.Click += btn7_Click;
            // 
            // btn8
            // 
            btn8.Location = new Point(108, 75);
            btn8.Name = "btn8";
            btn8.Size = new Size(50, 50);
            btn8.TabIndex = 10;
            btn8.Text = "8";
            btn8.UseVisualStyleBackColor = true;
            btn8.Click += btn8_Click;
            // 
            // btn9
            // 
            btn9.Location = new Point(164, 75);
            btn9.Name = "btn9";
            btn9.Size = new Size(50, 50);
            btn9.TabIndex = 11;
            btn9.Text = "9";
            btn9.UseVisualStyleBackColor = true;
            btn9.Click += btn9_Click;
            // 
            // txtResult
            // 
            txtResult.Location = new Point(52, 15);
            txtResult.Name = "txtResult";
            txtResult.Size = new Size(218, 23);
            txtResult.TabIndex = 12;
            txtResult.TextAlign = HorizontalAlignment.Right;
            txtResult.TextChanged += txtResult_TextChanged;
            // 
            // btnPonto
            // 
            btnPonto.Location = new Point(52, 248);
            btnPonto.Name = "btnPonto";
            btnPonto.Size = new Size(50, 50);
            btnPonto.TabIndex = 13;
            btnPonto.Text = ".";
            btnPonto.UseVisualStyleBackColor = true;
            btnPonto.Click += btnPonto_Click;
            // 
            // btnIgual
            // 
            btnIgual.Location = new Point(164, 248);
            btnIgual.Name = "btnIgual";
            btnIgual.Size = new Size(50, 50);
            btnIgual.TabIndex = 14;
            btnIgual.Text = "=";
            btnIgual.UseVisualStyleBackColor = true;
            btnIgual.Click += btnIgual_Click;
            // 
            // btnDiv
            // 
            btnDiv.Location = new Point(220, 75);
            btnDiv.Name = "btnDiv";
            btnDiv.Size = new Size(50, 50);
            btnDiv.TabIndex = 15;
            btnDiv.Text = "/";
            btnDiv.UseVisualStyleBackColor = true;
            btnDiv.Click += btnDiv_Click;
            // 
            // btnSub
            // 
            btnSub.Location = new Point(220, 192);
            btnSub.Name = "btnSub";
            btnSub.Size = new Size(50, 50);
            btnSub.TabIndex = 17;
            btnSub.Text = "-";
            btnSub.UseVisualStyleBackColor = true;
            btnSub.Click += btnSub_Click;
            // 
            // btnSoma
            // 
            btnSoma.Location = new Point(220, 248);
            btnSoma.Name = "btnSoma";
            btnSoma.Size = new Size(50, 50);
            btnSoma.TabIndex = 18;
            btnSoma.Text = "+";
            btnSoma.UseVisualStyleBackColor = true;
            btnSoma.Click += btnSoma_Click;
            // 
            // btnMult
            // 
            btnMult.Location = new Point(220, 131);
            btnMult.Name = "btnMult";
            btnMult.Size = new Size(50, 50);
            btnMult.TabIndex = 19;
            btnMult.Text = "X";
            btnMult.UseVisualStyleBackColor = true;
            btnMult.Click += btnMult_Click;
            // 
            // btnClear
            // 
            btnClear.Location = new Point(220, 44);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(50, 25);
            btnClear.TabIndex = 20;
            btnClear.Text = "C";
            btnClear.UseVisualStyleBackColor = true;
            btnClear.Click += btnClear_Click;
            // 
            // lblOperacao
            // 
            lblOperacao.AutoSize = true;
            lblOperacao.Location = new Point(62, 18);
            lblOperacao.Name = "lblOperacao";
            lblOperacao.Size = new Size(0, 15);
            lblOperacao.TabIndex = 21;
            // 
            // panel1
            // 
            panel1.Controls.Add(btnIgual);
            panel1.Controls.Add(lblOperacao);
            panel1.Controls.Add(btn1);
            panel1.Controls.Add(btnClear);
            panel1.Controls.Add(btn2);
            panel1.Controls.Add(btnMult);
            panel1.Controls.Add(btn3);
            panel1.Controls.Add(btnSoma);
            panel1.Controls.Add(btn0);
            panel1.Controls.Add(btnSub);
            panel1.Controls.Add(btn4);
            panel1.Controls.Add(btnDiv);
            panel1.Controls.Add(btn5);
            panel1.Controls.Add(btn6);
            panel1.Controls.Add(btnPonto);
            panel1.Controls.Add(btn7);
            panel1.Controls.Add(txtResult);
            panel1.Controls.Add(btn8);
            panel1.Controls.Add(btn9);
            panel1.Location = new Point(327, 84);
            panel1.Name = "panel1";
            panel1.Size = new Size(315, 304);
            panel1.TabIndex = 22;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(panel1);
            Controls.Add(btnMenu);
            Controls.Add(sidebarPanel);
            Name = "Form1";
            Text = "CalculadoraSimples";
            Load += Form1_Load;
            sidebarPanel.ResumeLayout(false);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel sidebarPanel;
        private Button btnCalcSimples;
        private Button btnMenu;
        private Button btnTemp;
        private Button btnMedia;
        private Button btnIMC;
        private System.Windows.Forms.Timer TimerSidebar;
        private Button btn1;
        private Button btn2;
        private Button btn3;
        private Button btn0;
        private Button btn4;
        private Button btn5;
        private Button btn6;
        private Button btn7;
        private Button btn8;
        private Button btn9;
        private TextBox txtResult;
        private Button btnPonto;
        private Button btnIgual;
        private Button btnDiv;
        private Button btnSub;
        private Button btnSoma;
        private Button btnMult;
        private Button btnClear;
        private Label lblOperacao;
        private Panel panel1;
    }
}
