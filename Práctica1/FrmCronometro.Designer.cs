namespace Práctica1
{
    partial class FrmCronometro
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
            LblTiempo = new Label();
            BtnIniciar = new Button();
            BtnPausa = new Button();
            BtnRestart = new Button();
            TmrCronometro = new System.Windows.Forms.Timer(components);
            SuspendLayout();
            // 
            // LblTiempo
            // 
            LblTiempo.Font = new Font("Bahnschrift", 48F, FontStyle.Bold, GraphicsUnit.Point, 0);
            LblTiempo.ForeColor = SystemColors.ButtonFace;
            LblTiempo.Location = new Point(37, 9);
            LblTiempo.Name = "LblTiempo";
            LblTiempo.Size = new Size(270, 77);
            LblTiempo.TabIndex = 0;
            LblTiempo.Text = "00:00:00";
            // 
            // BtnIniciar
            // 
            BtnIniciar.BackgroundImage = Properties.Resources.play_icon;
            BtnIniciar.Font = new Font("Bahnschrift", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            BtnIniciar.Location = new Point(143, 126);
            BtnIniciar.Name = "BtnIniciar";
            BtnIniciar.Size = new Size(40, 40);
            BtnIniciar.TabIndex = 1;
            BtnIniciar.UseVisualStyleBackColor = true;
            BtnIniciar.Click += BtnIniciar_Click;
            // 
            // BtnPausa
            // 
            BtnPausa.BackgroundImage = Properties.Resources.pause_icon;
            BtnPausa.Font = new Font("Bahnschrift", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            BtnPausa.Location = new Point(225, 126);
            BtnPausa.Name = "BtnPausa";
            BtnPausa.Size = new Size(40, 40);
            BtnPausa.TabIndex = 2;
            BtnPausa.UseVisualStyleBackColor = true;
            BtnPausa.Click += BtnPausa_Click;
            // 
            // BtnRestart
            // 
            BtnRestart.BackgroundImage = Properties.Resources.restart_icon;
            BtnRestart.Location = new Point(55, 123);
            BtnRestart.Margin = new Padding(4);
            BtnRestart.Name = "BtnRestart";
            BtnRestart.Size = new Size(45, 43);
            BtnRestart.TabIndex = 3;
            BtnRestart.Text = "button1";
            BtnRestart.UseVisualStyleBackColor = true;
            BtnRestart.Click += BtnRestart_Click;
            // 
            // TmrCronometro
            // 
            TmrCronometro.Interval = 1000;
            TmrCronometro.Tick += TmrCronometro_Tick;
            // 
            // FrmCronometro
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaptionText;
            ClientSize = new Size(331, 201);
            Controls.Add(BtnRestart);
            Controls.Add(BtnPausa);
            Controls.Add(BtnIniciar);
            Controls.Add(LblTiempo);
            Name = "FrmCronometro";
            Text = "Cronómetro";
            Load += Form1_Load;
            ResumeLayout(false);
        }

        #endregion

        private Label LblTiempo;
        private Button BtnIniciar;
        private Button BtnPausa;
        private Button BtnRestart;
        private System.Windows.Forms.Timer TmrCronometro;
    }
}
