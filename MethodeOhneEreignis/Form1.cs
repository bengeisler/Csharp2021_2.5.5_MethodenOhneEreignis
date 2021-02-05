using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MethodeOhneEreignis
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		private int Addieren(int zahl1, int zahl2)
		{
			int ergebnis = zahl1 + zahl2;
			return ergebnis;
		}

		private int Dividieren(int zahl1, int zahl2)
		{
			int ergebnis;

			if (zahl2 != 0)
			{
				ergebnis = zahl1 / zahl2;
			}
			else
			{
				ergebnis = 0;
			}

			return ergebnis;
		}

		private void btnPlus_Click(object sender, EventArgs e)
		{
			// Textfelder einlesen, in int konvertieren und in 
			// lokalen Variablen speichern
			int ersteZahl = Convert.ToInt32(txtZahl1.Text);
			int zweiteZahl = Convert.ToInt32(txtZahl2.Text);

			// Addition durchführen: Eigene Methode aufrufen
			int ergebnis = Addieren(ersteZahl, zweiteZahl);

			// Ergebnis ausgeben
			lblErgebnis.Text = "Ergebnis: " + ergebnis;
		}

		private void btnDivision_Click(object sender, EventArgs e)
		{
			// Textfelder einlesen, in int konvertieren und in 
			// lokalen Variablen speichern
			int ersteZahl = Convert.ToInt32(txtZahl1.Text);
			int zweiteZahl = Convert.ToInt32(txtZahl2.Text);

			// Division durchführen: Eigene Methode aufrufen
			int ergebnis = Dividieren(ersteZahl, zweiteZahl);

			// Ergebnis ausgeben
			lblErgebnis.Text = "Ergebnis: " + ergebnis;
		}
	}
}
