using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace cifrariodiCesare2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_cripta_Click(object sender, EventArgs e)
        {    // DICHIARAZIONI VARIABILI
            string frase = txt_n1.Text.ToUpper();
            string fraseCifrata = "";
            string chiave = txt_n2.Text;
            // MESSAGGIO PER QUANDO NON CI SONO I DATI
            if (string.IsNullOrEmpty(frase) || (string.IsNullOrEmpty(chiave)))
            {
                MessageBox.Show(" inserisci i parametri");
            }
            else
            {
                int chiaveNum = int.Parse(chiave);
                for (int i = 0; i < frase.Length; i++)
                {
                    char lettera = frase[i];
                    char nuovaLett = (char)(lettera + chiaveNum);
                    if ((nuovaLett > 'Z') || (nuovaLett > 'z'))
                    {
                        nuovaLett = (char)(nuovaLett - 26);
                    }
                    fraseCifrata = fraseCifrata + (char)nuovaLett;
                }
            }
            lbl_n1.Text = fraseCifrata;


        }

        private void btn_decripta_Click(object sender, EventArgs e)
        {
            string frase = txt_n3.Text.ToUpper();
            string fraseCifrata = txt_n3.Text.ToUpper();
            string chiave = txt_n4.Text;
            string fraseDecifrata = "";
            if (string.IsNullOrEmpty(frase) || (string.IsNullOrEmpty(chiave)))
            {
                MessageBox.Show(" inserisci i parametri");
            }
            else
            {
                int chiaveNum = int.Parse(chiave);
                for (int i = 0; i < frase.Length; i++)
                {
                    char lettera = fraseCifrata[i];
                    if (lettera != ' ')
                    {
                        if (lettera >= 'A' && lettera <= 'z')
                        {
                            char nuovaLett = (char)(lettera - chiaveNum);
                            if (nuovaLett < 'A')
                            {
                                nuovaLett = (char)(nuovaLett + 26);
                            }
                            fraseDecifrata = fraseDecifrata + (char)nuovaLett;
                        }
                        else
                        {
                            fraseDecifrata = fraseDecifrata + (char)lettera;
                        }
                    }
                    else
                    {
                        fraseDecifrata = fraseDecifrata + ' ';
                    }
                   

                }

            }
            lbl_ris.Text = fraseDecifrata;

        }
        

    }
}
    

