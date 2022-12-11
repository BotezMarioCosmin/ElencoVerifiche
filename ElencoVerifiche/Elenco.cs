using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ElencoVerifiche
{
    public class Elenco
    {
        private string _id; //primary key
        private double[] votiDisponibili = new double[] { 1, 1.15, 1.5, 1.85, 2, 2.15, 2.5, 2.85, 3, 3.15, 3.5, 3.85, 4, 4.15, 4.5, 4.85, 5, 5.15, 5.5, 5.85, 6, 6.15, 6.5, 6.85, 7, 7.15, 7.5, 7.85, 8, 8.15, 8.5, 8.85, 9, 9.15, 9.5, 9.85, 10 };
        private Verifica[] verifiche;

        public Elenco(string id, Verifica[] ver) 
        {
            Id = id;
            verifiche = ver;
        }

        public Elenco()
        {
            Id = "el0";
            verifiche = new Verifica[100];
        }

        public string Id
        {
            get { return _id; }
            private set { _id = value; }
        }

        public Verifica[] Verifiche
        {
            get { return verifiche; }
            set { verifiche = value; }
        }

        public double[] VotiDisponibili
        { 
            get { return votiDisponibili; }
        }

        /*
        public int getIdDisponibile()
        {
            for (int i = 0; i < verifiche.Length; i++)
            {
                if (verifiche[i] == null)
                {
                    return i++;
                }
            }
            return -1;
        }*/
    }
}
