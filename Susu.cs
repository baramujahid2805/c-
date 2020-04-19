using System;
using System.Collections.Generic;
using System.Text;

namespace KopiCappocino
{
    class Susu
    {
        private int volume = 0;//mililiter
        private int volumeOneCup = 100;

        public Susu(int volume)
        {
            this.volume = volume;
        }

        public Boolean isAvailable()
        {
            return volume >= volumeOneCup;
        }

        public void addWater(int volume)
        {
            this.volume += volume;
        }

        public int makeOneCup()
        {
            this.volume = this.volume - this.volumeOneCup;
            return volumeOneCup;
        }

        public int getVolume()
        {
            return this.volume;
        }
    }
}
