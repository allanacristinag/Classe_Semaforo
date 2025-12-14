using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Semaforo
{
    public class Semaforo
    {
        private byte estado;

        public Semaforo()
        {
            this.estado = 65;
        }
        public void setVerde(int rua)
        {
            if (rua == 1)
            {
                this.estado = 20;
            }
            else if (rua == 2)
            {
                this.estado = 65;
            }

        }
        public void setAmarelo(int rua)
        {
            if (rua == 1)
            {
                this.estado = 18;
            }
            else if (rua == 2)
            {
                this.estado = 33;
            }
        }


        public void setVermelho(int rua)
        {
            if (rua == 1)
            {
                setVerde(2);
            }
            else if (rua == 2)
            {
                setVerde(1);
            }
        }


        public byte getEstado()
        {
            return this.estado;
        }


        public int getEstado(int rua)
        {
            if (rua == 1)
            {

                if ((estado & 4) == 4) return 3;
                if ((estado & 2) == 2) return 2;
                if ((estado & 1) == 1) return 1;
            }
            else if (rua == 2)
            {

                if ((estado & 64) == 64) return 3;
                if ((estado & 32) == 32) return 2;
                if ((estado & 16) == 16) return 1;
            }

            return 0;
        }
    }
}