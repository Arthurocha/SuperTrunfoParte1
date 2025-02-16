namespace SuperTrunfo
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
            label1 = new Label();
            label2 = new Label();
            BtnDistribuirCartas = new Button();
            LstCartasJogador1 = new ListBox();
            LstCartasJogador2 = new ListBox();
            RdoAtaque = new RadioButton();
            RdoDefesa = new RadioButton();
            RdoMagia = new RadioButton();
            LblTotalCartasJogador1 = new Label();
            LblTotalCartasJogador2 = new Label();
            BtnNovaRodada = new Button();
            BtnDesafiar = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(29, 24);
            label1.Name = "label1";
            label1.Size = new Size(89, 15);
            label1.TabIndex = 0;
            label1.Text = "Carta Jogador 1";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(196, 24);
            label2.Name = "label2";
            label2.Size = new Size(89, 15);
            label2.TabIndex = 1;
            label2.Text = "Carta Jogador 2";
            // 
            // BtnDistribuirCartas
            // 
            BtnDistribuirCartas.Location = new Point(175, 257);
            BtnDistribuirCartas.Name = "BtnDistribuirCartas";
            BtnDistribuirCartas.Size = new Size(66, 56);
            BtnDistribuirCartas.TabIndex = 4;
            BtnDistribuirCartas.Text = "Distribuir Cartas";
            BtnDistribuirCartas.UseVisualStyleBackColor = true;
            BtnDistribuirCartas.Click += BtnDistribuirCartas_Click;
            // 
            // LstCartasJogador1
            // 
            LstCartasJogador1.Enabled = false;
            LstCartasJogador1.FormattingEnabled = true;
            LstCartasJogador1.ItemHeight = 15;
            LstCartasJogador1.Location = new Point(29, 42);
            LstCartasJogador1.Name = "LstCartasJogador1";
            LstCartasJogador1.Size = new Size(120, 199);
            LstCartasJogador1.TabIndex = 5;
            // 
            // LstCartasJogador2
            // 
            LstCartasJogador2.Enabled = false;
            LstCartasJogador2.FormattingEnabled = true;
            LstCartasJogador2.ItemHeight = 15;
            LstCartasJogador2.Location = new Point(196, 42);
            LstCartasJogador2.Name = "LstCartasJogador2";
            LstCartasJogador2.Size = new Size(120, 199);
            LstCartasJogador2.TabIndex = 6;
            // 
            // RdoAtaque
            // 
            RdoAtaque.AutoSize = true;
            RdoAtaque.Location = new Point(29, 257);
            RdoAtaque.Name = "RdoAtaque";
            RdoAtaque.Size = new Size(63, 19);
            RdoAtaque.TabIndex = 7;
            RdoAtaque.TabStop = true;
            RdoAtaque.Text = "Ataque";
            RdoAtaque.UseVisualStyleBackColor = true;
            // 
            // RdoDefesa
            // 
            RdoDefesa.AutoSize = true;
            RdoDefesa.Location = new Point(98, 257);
            RdoDefesa.Name = "RdoDefesa";
            RdoDefesa.Size = new Size(60, 19);
            RdoDefesa.TabIndex = 8;
            RdoDefesa.TabStop = true;
            RdoDefesa.Text = "Defesa";
            RdoDefesa.UseVisualStyleBackColor = true;
            // 
            // RdoMagia
            // 
            RdoMagia.AutoSize = true;
            RdoMagia.Location = new Point(29, 294);
            RdoMagia.Name = "RdoMagia";
            RdoMagia.Size = new Size(58, 19);
            RdoMagia.TabIndex = 9;
            RdoMagia.TabStop = true;
            RdoMagia.Text = "Magia";
            RdoMagia.UseVisualStyleBackColor = true;
            // 
            // LblTotalCartasJogador1
            // 
            LblTotalCartasJogador1.AutoSize = true;
            LblTotalCartasJogador1.Location = new Point(136, 24);
            LblTotalCartasJogador1.Name = "LblTotalCartasJogador1";
            LblTotalCartasJogador1.Size = new Size(13, 15);
            LblTotalCartasJogador1.TabIndex = 10;
            LblTotalCartasJogador1.Text = "0";
            // 
            // LblTotalCartasJogador2
            // 
            LblTotalCartasJogador2.AutoSize = true;
            LblTotalCartasJogador2.Location = new Point(303, 24);
            LblTotalCartasJogador2.Name = "LblTotalCartasJogador2";
            LblTotalCartasJogador2.Size = new Size(13, 15);
            LblTotalCartasJogador2.TabIndex = 11;
            LblTotalCartasJogador2.Text = "0";
            // 
            // BtnNovaRodada
            // 
            BtnNovaRodada.Enabled = false;
            BtnNovaRodada.Location = new Point(260, 257);
            BtnNovaRodada.Name = "BtnNovaRodada";
            BtnNovaRodada.Size = new Size(56, 56);
            BtnNovaRodada.TabIndex = 12;
            BtnNovaRodada.Text = "Nova Rodada";
            BtnNovaRodada.UseVisualStyleBackColor = true;
            BtnNovaRodada.Click += BtnNovaRodada_Click;
            // 
            // BtnDesafiar
            // 
            BtnDesafiar.Enabled = false;
            BtnDesafiar.Location = new Point(95, 286);
            BtnDesafiar.Name = "BtnDesafiar";
            BtnDesafiar.Size = new Size(63, 27);
            BtnDesafiar.TabIndex = 13;
            BtnDesafiar.Text = "Desafiar";
            BtnDesafiar.UseVisualStyleBackColor = true;
            BtnDesafiar.Click += BtnDesafiar_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(356, 325);
            Controls.Add(BtnDesafiar);
            Controls.Add(BtnNovaRodada);
            Controls.Add(LblTotalCartasJogador2);
            Controls.Add(LblTotalCartasJogador1);
            Controls.Add(RdoMagia);
            Controls.Add(RdoDefesa);
            Controls.Add(RdoAtaque);
            Controls.Add(LstCartasJogador2);
            Controls.Add(LstCartasJogador1);
            Controls.Add(BtnDistribuirCartas);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "SuperTrunfo";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Button BtnDistribuirCartas;
        private ListBox LstCartasJogador1;
        private ListBox LstCartasJogador2;
        private RadioButton RdoAtaque;
        private RadioButton RdoDefesa;
        private RadioButton RdoMagia;
        private Label LblTotalCartasJogador1;
        private Label LblTotalCartasJogador2;
        private Button BtnNovaRodada;
        private Button BtnDesafiar;
    }
}
