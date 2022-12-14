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

        public int Id 
        { 
            get 
            { 
                return _id;
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
