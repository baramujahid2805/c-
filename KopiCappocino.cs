using System;
using System.Collections.Generic;
using System.Text;

namespace KopiCappocino
{
    class KopiCappocino
    {
        private BubukKopi bubukKopi;
        private AirPanas airPanas;
        private Susu susu;

        public KopiCappocino(BubukKopi kopi, AirPanas panas, Susu susu)
        {
            this.bubukKopi = kopi;
            this.airPanas = panas;
            this.susu = susu;
        }

        public String makeKopiCappocino()
        {
            if (!this.airPanas.isAvailable())
            {
                return "Sorry, the water is empty";
            }
            if (!this.bubukKopi.isAvailable())
            {
                return "Sorry, the coffe is empty";
            }
            if (!this.susu.isAvailable())
            {
                return "Sorry, the coffe is empty";
            }

            this.airPanas.makeOneCup();
            this.bubukKopi.makeOneCup();
            this.susu.makeOneCup();
            return "Yey! your coffe is ready";
        }

        public String checkAvailability()
        {
            return $"the air :{this.airPanas.getVolume()} and the bubuk : {this.bubukKopi.getNetto()} and the susu : {this.susu.getVolume()}";
        }
    }
}
