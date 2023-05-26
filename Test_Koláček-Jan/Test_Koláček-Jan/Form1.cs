using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Test_Koláček_Jan
{
    public partial class Form1 : Form
    {

        private List<Petiuhelnik> PetiuhelnikList = new List<Petiuhelnik>();
        private int Pozice = -1;
        private int pocet = 0;

        void VypisInformace(int poz)
        {
            if (poz < 0)
            {
                txt_vystup.Text = "Není nic načteno";
                nmr_strana.Value = 0;
                txt_jednotky.Text = "";
            }
            else
            {
                txt_vystup.Text = "Obvod: " + Math.Round(PetiuhelnikList[poz].Obvod(), 2) + " "
                    + PetiuhelnikList[poz].getJednotky() + Environment.NewLine;
                txt_vystup.Text += "Obsah: " + Math.Round(PetiuhelnikList[poz].Obsah(), 2) + " "
                    + PetiuhelnikList[poz].getJednotky() + "²" + Environment.NewLine;
                nmr_strana.Value = Convert.ToDecimal(PetiuhelnikList[poz].getStrana());
                txt_jednotky.Text = PetiuhelnikList[poz].getJednotky();
                lbl_pozice.Text = Convert.ToString(Pozice);
            }
        }

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            StreamReader sr = new StreamReader("file.csv");
            string radek;
            string[] polehodnot;
            while (!sr.EndOfStream)
            {
                Petiuhelnik k1 = new Petiuhelnik();
                radek = sr.ReadLine();
                polehodnot = radek.Split(';');
                k1.setStrana(Convert.ToDouble(polehodnot[0]));
                k1.setJednotky(polehodnot[1]);
                PetiuhelnikList.Add(k1);
                pocet++; Pozice++;
            }
            VypisInformace(Pozice);
            sr.Close();

        }

        private void btn_prev_Click(object sender, EventArgs e)
        {
            Pozice--;
            if (Pozice < 0 && pocet > 0) Pozice = 0;
            if (pocet <= 0) Pozice = -1;
            VypisInformace(Pozice);
        }

        private void btn_next_Click(object sender, EventArgs e)
        {
            Pozice++;
            if (Pozice >= pocet) Pozice = pocet - 1;
            VypisInformace(Pozice);
        }

        private void btn_novyzaznam_Click(object sender, EventArgs e)
        {
            Petiuhelnik k1 = new Petiuhelnik();
            try
            {
                k1.setStrana(Convert.ToDouble(nmr_strana.Value));
                k1.setJednotky(txt_jednotky.Text);
                PetiuhelnikList.Add(k1);
                pocet++;
                Pozice = pocet - 1;
                VypisInformace(pocet - 1);
            }
            catch
            {
                txt_vystup.Text = "Nelze vytvořit nový záznam";
            }
        }

        private void btn_smazzaznam_Click(object sender, EventArgs e)
        {
            if (Pozice >= 0) PetiuhelnikList.RemoveAt(Pozice);
            pocet--;
            if (Pozice > pocet - 1) Pozice = pocet - 1;
            if (pocet == 0) Pozice = -1;
            VypisInformace(Pozice);
        }

        private void btn_v_Click(object sender, EventArgs e)
        {
            PetiuhelnikList[Pozice].setStrana(Convert.ToDouble(nmr_strana.Value));
            PetiuhelnikList[Pozice].setJednotky(txt_jednotky.Text);
            VypisInformace(Pozice);
        }

        private void btn_do_Click(object sender, EventArgs e)
        {
            StreamWriter sw = new StreamWriter("file.csv");
            string radek = "";
            for (int i = 0; i< PetiuhelnikList.Count; i++)
            {
                radek += PetiuhelnikList[i].getStrana() + ";" + PetiuhelnikList[i].getJednotky();
                sw.WriteLine(radek);
                radek= "";
            }
            sw.Close();
        }
    }
}
