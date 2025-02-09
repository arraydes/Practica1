using System.Configuration;
using System.Runtime.InteropServices;

namespace Práctica1
{
    public partial class FrmCronometro : Form
    {
        // Se declara una variable que cuenta los segundos desde que se inicia el cronometro
        // Además de las variables correspondientes a los minutos y horas
        int seconds;
        int minutes;
        int hours;

        public FrmCronometro()
        {
            InitializeComponent();

            BtnRestart.Enabled = false;
            BtnPausa.Enabled = false;
            seconds = 0;
            minutes = 0;
            hours = 0;

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void BtnIniciar_Click(object sender, EventArgs e)
        {
            TmrCronometro.Start();
            
            BtnIniciar.Enabled = false;
            BtnPausa.Enabled = true;
        }

        private void BtnRestart_Click(object sender, EventArgs e)
        {
            TmrCronometro.Stop();
            seconds = 0;
            LblTiempo.Text = "00:00:00";
        }

        private void TmrCronometro_Tick(object sender, EventArgs e)
        {
            seconds++;

            if (seconds == 60)
            {
                seconds = 0;
                minutes++;
            }
            else if (minutes == 60)
            {
                minutes = 0;
                hours++;
            }

            LblTiempo.Text = string.Format("{0}:{1}:{2}", 
                                            hours.ToString().ToString().PadLeft(2, '0'),
                                            minutes.ToString().ToString().PadLeft(2, '0'), 
                                            seconds.ToString().ToString().PadLeft(2, '0'));
        }

        private void BtnPausa_Click(object sender, EventArgs e)
        {
            TmrCronometro.Stop();

            BtnPausa.Enabled = false;
            BtnRestart.Enabled = true;
            BtnIniciar.Enabled = true;
        }
    }
}
