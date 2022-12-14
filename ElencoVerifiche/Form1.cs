using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.Design;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace ElencoVerifiche
{
    public partial class Form1 : Form
    {
        private Elenco elenco;
        double[] votiNum = new double[] { 1, 1.15, 1.5, 1.85, 2, 2.15, 2.5, 2.85, 3, 3.15, 3.5, 3.85, 4, 4.15, 4.5, 4.85, 5, 5.15, 5.5, 5.85, 6, 6.15, 6.5, 6.85, 7, 7.15, 7.5, 7.85, 8, 8.15, 8.5, 8.85, 9, 9.15, 9.5, 9.85, 10 };
        string[] votiString = new string[] { "1", "1+", "1.5", "2-", "2", "2+", "2.5", "3-", "3", "3+", "3.5", "4-", "4", "4+", "4.5", "5-", "5", "5+", "5.5", "6-", "6", "6+", "6.5", "7-", "7", "7+", "7.5", "8-", "8", "8+", "8.5", "9-", "9", "9+", "9.5", "10-", "10" };
        string[] materie = new string[] { "Italiano", "Storia", "Inglese", "Matematica", "Informatica", "Motoria", "Religione" };
        private Verifica[] verifiche;
        double media = 0;
        public Form1()
        {
            InitializeComponent();
            elenco = new Elenco();
            verifiche = new Verifica[100];
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            panelElimina.Hide();
            for (int i = 0; i < votiString.Length; i++)
            {
                comboBoxVoto.Items.Add(votiString[i]);
            }
            for (int i = 0; i < materie.Length; i++)
            {
                comboBoxMateria.Items.Add(materie[i]);
            }
            for (int i = 0; i < materie.Length; i++)
            {
                comboBoxMedia.Items.Add(materie[i]);
            }

            Verifica v0 = new Verifica(getIdDisponibile(), "Italiano", 10, "12/12/2022");
            verifiche[0] = v0;
            Verifica v1 = new Verifica(getIdDisponibile(), "Italiano", 4, "9/12/2022");
            verifiche[1] = v1;
            Verifica v2 = new Verifica(getIdDisponibile(), "Storia", 8, "13/12/2022");
            verifiche[2] = v2;

            aggiungiVerificaElenco(v0);
            aggiungiVerificaElenco(v1);
            aggiungiVerificaElenco(v2);

            textBoxId.Text = Convert.ToString(getIdDisponibile());
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

            int index = comboBoxVoto.SelectedIndex;

            Verifica v = new Verifica(Convert.ToInt32(textBoxId.Text), comboBoxMateria.SelectedItem.ToString(), votiNum[index], textBoxData.Text);

            verifiche[getIdDisponibile()] = v;

            textBoxId.Text = getIdDisponibile().ToString();

            elenco.aggiungiVerifica(v);

        }

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
        }

        private void comboBoxMedia_SelectedIndexChanged(object sender, EventArgs e)
        {
            int tmp = comboBoxMedia.SelectedIndex;
            string materia = materie[tmp];

            media = 0;
            calcolaMedia(materia);
            textBoxMedia.Text = Convert.ToString(media);
        }


        public void calcolaMedia(string materia)
        {
            double m;
            double voti = 0;
            int cont = 0;

            for (int i = 0; verifiche[i] != null; i++)
            {
                if (verifiche[i].Materia == materia)
                {
                    voti = voti + verifiche[i].Voto;
                    cont++;
                    m = voti / cont;

                    media = m;
                }
            }
        }

        private void buttonElimina_Click(object sender, EventArgs e)
        {
            for (int i = 0; verifiche[i] != null ; i++)
            {
                comboBoxEliminaId.Items.Add(verifiche[i].Id);
            }
            panelElimina.Show();
            buttonElimina.Hide();
        }

        private void buttonX_Click(object sender, EventArgs e)
        {
            //comboBoxEliminaId.Items.Clear();
            panelElimina.Hide();
            buttonElimina.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            elenco.eliminaVerifica(Convert.ToInt32(comboBoxEliminaId.SelectedItem), verifiche);
            listView1.Clear();
            refreshListView();
        }


        public void refreshListView()
        {
            for (int i = 0; verifiche[i] != null; i++)
            {
                ListViewItem oggetto = new ListViewItem(Convert.ToString(verifiche[i].Id));
                oggetto.SubItems.Add(verifiche[i].Materia);
                oggetto.SubItems.Add(Convert.ToString(verifiche[i].Voto));
                oggetto.SubItems.Add(verifiche[i].Data);
                listView1.Items.Add(oggetto);
            }
        }

        private void buttonModifica_Click(object sender, EventArgs e)
        {

        }
    }
}
