using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ElencoVerifiche
{
    public class Verifica
    {
        private int _id; //primary key
        private string _materia;
        private double _voto;
        private string _data;
        //private Elenco elenco;

        public Verifica(int id, string materia, double voto, string data)
        {
            Id = id;
            Materia = materia; 
            Voto = voto;    
            Data = data;
        }

        public Verifica()
        {
            Id = _id;
            Data = DateTime.Now.ToString("dd/MM/yyyy"); //data attuale
        }
        /*
        public Elenco Elenco
        {
            set { elenco = value; }
            get { return elenco; }
        }
        */
        public int Id 
        { 
            get 
            { 
                return _id++;
            } 
            set 
            { 
                _id = value; 
            } 
        }

        public string Materia 
        { 
            get 
            { 
                return _materia;
            } 
            set 
            { 
                _materia = value; 
            } 
        }

        public double Voto
        {
            set 
            {
                /*
                double[] arrayvoti = elenco.VotiDisponibili;

                for (int i = 0; i < arrayvoti.Length; i++)
                {
                    if (_voto == arrayvoti[i])
                    {
                        _voto = value;
                        return;
                    }
                }*/
                _voto = value;
            }

            get { return _voto; }
        }

        public string Data
        {
            set { _data = value; }
            get { return _data; }
        }
    }
}
