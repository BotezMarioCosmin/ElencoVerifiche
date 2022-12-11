using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ElencoVerifiche
{
    public partial class Form1 : Form
    {
        private Elenco elenco;
        double[] votiNum = new double[] { 1, 1.15, 1.5, 1.85, 2, 2.15, 2.5, 2.85, 3, 3.15, 3.5, 3.85, 4, 4.15, 4.5, 4.85, 5, 5.15, 5.5, 5.85, 6, 6.15, 6.5, 6.85, 7, 7.15, 7.5, 7.85, 8, 8.15, 8.5, 8.85, 9, 9.15, 9.5, 9.85, 10 };
        string[] votiString = new string[] { "1", "1+", "1.5", "2-", "2", "2+", "2.5", "3-", "3", "3+", "3.5", "4-", "4", "4+", "4.5", "5-", "5", "5+", "5.5", "6-", "6", "6+", "6.5", "7-", "7", "7+", "7.5", "8-", "8", "8+", "8.5", "9-", "9", "9+", "9.5", "10-", "10" };
        string[] materie = new string[] {"Italiano","Storia","Inglese","Matematica","Informatica","Motoria","Religione" };
        Verifica[] verifiche = new Verifica[100];

        public Form1()
        {
            InitializeComponent();

            for (int i = 0; i < votiString.Length; i++)
            {
                comboBoxVoto.Items.Add(votiString[i]);
            }
            for (int i = 0; i < materie.Length; i++)
            {
                comboBoxMateria.Items.Add(materie[i]);
            }

            Verifica v = new Verifica(getIdDisponibile(), "Italiano", 10, "12/12/2022");
            verifiche[0] = v;

            aggiungiVerificaElenco(v);
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void buttonOggi_Click(object sender, EventArgs e)
        {
            textBoxData.Text = DateTime.Now.ToString("dd/MM/yyyy");
        }

        public void aggiungiVerificaElenco(Verifica v)
        {
            ListViewItem item = new ListViewItem(Convert.ToString(v.Id));
            item.SubItems.Add(v.Materia);
            item.SubItems.Add(Convert.ToString(v.Voto));
            item.SubItems.Add(v.Data);
            listView1.Items.Add(item);
        }

        private void buttonAggiungi_Click(object sender, EventArgs e)
        {
            ListViewItem oggetto = new ListViewItem(textBoxId.Text);
            oggetto.SubItems.Add(comboBoxMateria.SelectedItem.ToString());
            oggetto.SubItems.Add(Convert.ToString(comboBoxVoto.SelectedItem));
            oggetto.SubItems.Add(textBoxData.Text);
            listView1.Items.Add(oggetto);
        }

        public int getIdDisponibile()
        {
            for (int i = 0; i < verifiche.Length; i++)
            {
                if (verifiche[i] == null)
                {
                    return i+1;                
                }
            }
            return -1;
        }
    }
}
