using System;

namespace Task4._25
{
    public class Plaen
    {
        protected string name;
        protected int nomber_motor;
        protected int height;
        protected float q;

        public Plaen(string name, int nomber_motor, int height)
        {
            this.name = name;
            this.nomber_motor = nomber_motor;
            this.height = height;
            findQ();
        }

        protected virtual void findQ()
        {
            this.q = (float)nomber_motor * height/10000;
        }

        public virtual String getInfo()
        {
            return name + (name.Length >= 16 ? "\t" : "\t\t") + "Кол-во двигателей: " + nomber_motor + "\tВысота: " +   "\tq: " + q;
        }

        public string Name => name;

        public int Nomber_motor => nomber_motor;

        public int Height => height;

        public float Q => q;
    }
}

