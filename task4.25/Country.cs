using System;

namespace Task4._25

{
    public class Country : Plaen
    {
        private int p;

        public Country(string name, int nomber_motor, int height, int p) : base(name, nomber_motor, height)
        {
            this.p = p;
            findQ();
        }

        protected override void findQ()
        {
            base.findQ();
            Random rnd = new Random();
            p = rnd.Next(1);
            if (p == 1)
            {
                this.q = this.q + 1;
            }
            else if (p == 0)
            {
                this.q = this.q + 1/2;
            }

      
        }

        public override string getInfo()
        {
            return base.getInfo() + "\t q c учетом страны производителя: " + p.ToString();
        }
    }
}

