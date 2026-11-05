using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
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
        {
            string frase = txt_n2.Text;
            string fraseCifrata = " ";
            string chiave = txt_n1.Text;
            if (string.IsNullOrEmpty(frase) || (string.IsNullOrEmpty(chiave)))
            {
                MessageBox.Show(" inserisci i parametri");
            }
            else
            {
                int chiveNum = int.Parse(chiave);
                for (int i = 0; i < frase.Length; i++)
                {
                    char lettera = frase[i];
                    char nuovaLett = (char)(lettera + chiveNum);
                    if ((nuovaLett > 'Z') || (nuovaLett > 'z'))
                    {
                        nuovaLett = (char)(nuovaLett - 26);
                    }
                    fraseCifrata = fraseCifrata + (char)nuovaLett;
                }
            }
            lbl_n1.Text = fraseCifrata;


        }
    }
}
    

