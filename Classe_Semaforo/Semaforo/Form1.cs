using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Semaforo
{
    public partial class Form1 : Form
    {
        private Semaforo semaforo = new Semaforo();
        public Form1()
        {
            InitializeComponent();
            AtualizarInterface();
        }
        private void AtualizarInterface()
        {
            int estadoRua1 = semaforo.getEstado(1);
            int estadoRua2 = semaforo.getEstado(2);

            if (estadoRua1 == 1)
            {
                picrua1.Image = Properties.Resources.semaforovermelho;
            }
            else if (estadoRua1 == 2)
            {
                picrua1.Image = Properties.Resources.semaforoamarelo;
            }
            else if (estadoRua1 == 3)
            {
                picrua1.Image = Properties.Resources.semaforoverde;
            }

            
            if (estadoRua2 == 1)
            {
                picrua2.Image = Properties.Resources.semaforovermelho;
            }
            else if (estadoRua2 == 2)
            {
                picrua2.Image = Properties.Resources.semaforoamarelo;
            }
            else if (estadoRua2 == 3)
            {
                picrua2.Image = Properties.Resources.semaforoverde;
            }
        }

        private void btnRua1Verde_Click(object sender, EventArgs e)
        {
            semaforo.setVerde(1);
            AtualizarInterface();
        }

        private void btnRua1Amarelo_Click(object sender, EventArgs e)
        {
            semaforo.setAmarelo(1);
            AtualizarInterface();
        }

        private void btnRua1Vermelho_Click(object sender, EventArgs e)
        {
            semaforo.setVermelho(1);
            AtualizarInterface();
        }

       
    }
}
