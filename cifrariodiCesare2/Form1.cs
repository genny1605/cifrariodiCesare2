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
	public partial class lbl_risu : Form
	{
		public lbl_risu()
		{
			InitializeComponent();
		}

		private void btn_cripta_Click(object sender, EventArgs e)
		{
			// DICHIARAZIONI VARIABILI 
			string frase = txt_n1.Text;
			string fraseCifrata = "";
			string chiave = txt_n2.Text;

			// MESSAGGIO PER QUANDO NON CI SONO I DATI
			if (string.IsNullOrEmpty(frase) || string.IsNullOrEmpty(chiave))
			{
				MessageBox.Show("Inserisci i parametri");
			}
			else
			{
				int chiaveNum = int.Parse(chiave) % 26;

				for (int i = 0; i < frase.Length; i++)
				{
					char lettera = frase[i];

					if (lettera >= 'A' && lettera <= 'Z') // Se è MAIUSCOLA
					{
						char nuovaLett = (char)(lettera + chiaveNum);
						if (nuovaLett > 'Z')
						{
							nuovaLett = (char)(nuovaLett - 26);
						}
						fraseCifrata += nuovaLett;
					}
					else if (lettera >= 'a' && lettera <= 'z') // Se è MINUSCOLA
					{
						char nuovaLett = (char)(lettera + chiaveNum);
						if (nuovaLett > 'z')
						{
							nuovaLett = (char)(nuovaLett - 26);
						}
						fraseCifrata += nuovaLett;
					}
					else
					{
						
						fraseCifrata += lettera;
					}
				}
			}
			lbl_n1.Text = fraseCifrata;
		}

		private void button1_Click(object sender, EventArgs e)
		{
			// DICHIARAZIONI VARIABILI
			string fraseCifrata = txt_n3.Text;
			string chiave = txt_n4.Text;
			string fraseDecifrata = "";

			if (string.IsNullOrEmpty(fraseCifrata) || string.IsNullOrEmpty(chiave))
			{
				MessageBox.Show("Inserisci i parametri");
			}
			else
			{
				int chiaveNum = int.Parse(chiave) % 26;

				for (int i = 0; i < fraseCifrata.Length; i++)
				{
					char lettera = fraseCifrata[i];

					if (lettera >= 'A' && lettera <= 'Z') // Se è MAIUSCOLA
					{
						char nuovaLett = (char)(lettera - chiaveNum);
						if (nuovaLett < 'A')
						{
							nuovaLett = (char)(nuovaLett + 26);
						}
						fraseDecifrata += nuovaLett;
					}
					else if (lettera >= 'a' && lettera <= 'z') // Se è MINUSCOLA
					{
						char nuovaLett = (char)(lettera - chiaveNum);
						if (nuovaLett < 'a')
						{
							nuovaLett = (char)(nuovaLett + 26);
						}
						fraseDecifrata += nuovaLett;
					}
					else
					{
						
						fraseDecifrata += lettera;
					}
				}
			}
			lbl_ris.Text = fraseDecifrata;
		}
		private void btn_n1_Click(object sender, EventArgs e)
		{
			// DICHIARAZIONI VARIABILI
			string frase = txt_n5.Text;
			string fraseCifrata = "";
			string chiave = txt_n6.Text;
			// MESSAGGIO PER QUANDO NON CI SONO I DATI
			if (string.IsNullOrEmpty(frase) || string.IsNullOrEmpty(chiave))
			{
				MessageBox.Show("Inserisci i parametri");
			}
			else
			{
				// CONVERTO LA CHIAVE IN NUMERO 
				int sommaChiave = 0;
				foreach (char c in chiave.ToUpper())
				{
					if (char.IsLetter(c))
					{
						sommaChiave += (c - 'A');
					}
				}
				int chiaveNum = sommaChiave % 26;

				
				for (int i = 0; i < frase.Length; i++)
				{
					char lettera = frase[i];

					if (lettera >= 'A' && lettera <= 'Z') // Se è MAIUSCOLA
					{
						char nuovaLett = (char)(lettera + chiaveNum);
						if (nuovaLett > 'Z')
						{
							nuovaLett = (char)(nuovaLett - 26);
						}
						fraseCifrata += nuovaLett;
					}
					else if (lettera >= 'a' && lettera <= 'z') // Se è MINUSCOLA
					{
						char nuovaLett = (char)(lettera + chiaveNum);
						if (nuovaLett > 'z')
						{
							nuovaLett = (char)(nuovaLett - 26);
						}
						fraseCifrata += nuovaLett;
					}
					else
					{
						
						fraseCifrata += lettera;
					}
				}
			}
			lbl_r.Text = fraseCifrata;
		}

		private void btn_n2_Click(object sender, EventArgs e)
		{
			// DICHIARAZIONI VARIABILI
			string fraseCifrata = txt_n10.Text;
			string chiave = txt_n12.Text;
			string fraseDecifrata = "";
			// MESSAGGIO PER QUANDO NON CI SONO I DATI
			if (string.IsNullOrEmpty(fraseCifrata) || string.IsNullOrEmpty(chiave))
			{
				MessageBox.Show("Inserisci i parametri");
			}
			else
			{
				int sommaChiave = 0;
				foreach (char c in chiave.ToUpper())
				{
					if (char.IsLetter(c))
					{
						sommaChiave += (c - 'A');
					}
				}
				int chiaveNum = sommaChiave % 26;

				// CICLO SULLA FRASE CIFRATA
				for (int i = 0; i < fraseCifrata.Length; i++)
				{
					char lettera = fraseCifrata[i];

					if (lettera >= 'A' && lettera <= 'Z') // Se è MAIUSCOLA
					{
						char nuovaLett = (char)(lettera - chiaveNum);
						if (nuovaLett < 'A')
						{
							nuovaLett = (char)(nuovaLett + 26);
						}
						fraseDecifrata += nuovaLett;
					}
					else if (lettera >= 'a' && lettera <= 'z') // Se è MINUSCOLA
					{
						char nuovaLett = (char)(lettera - chiaveNum);
						if (nuovaLett < 'a')
						{
							nuovaLett = (char)(nuovaLett + 26);
						}
						fraseDecifrata += nuovaLett;
					}
					else
					{
						
						fraseDecifrata += lettera;
					}
				}
			}
			lbl_risul.Text = fraseDecifrata;
		}
	}
}
