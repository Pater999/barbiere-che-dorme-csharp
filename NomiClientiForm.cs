using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BarbiereCheDorme
{
    public partial class NomiClientiForm : Form
    {

        List<ListaClienti> LstClienti;

        public NomiClientiForm(List<ListaClienti> ListaClienti)
        {
            InitializeComponent();
            LstClienti = ListaClienti;
            Inizializzazione();
        }

        private void Inizializzazione()
        {
            LblCliente1.ForeColor = LstClienti[0].Colore;
            TxtCliente1.Text = LstClienti[0].Nome;
            LblCliente2.ForeColor = LstClienti[1].Colore;
            TxtCliente2.Text = LstClienti[1].Nome;
            LblCliente3.ForeColor = LstClienti[2].Colore;
            TxtCliente3.Text = LstClienti[2].Nome;
            LblCliente4.ForeColor = LstClienti[3].Colore;
            TxtCliente4.Text = LstClienti[3].Nome;
            LblCliente5.ForeColor = LstClienti[4].Colore;
            TxtCliente5.Text = LstClienti[4].Nome;
        }

        private void BtnSalva_Click(object sender, EventArgs e)
        {
            LstClienti[0].Nome = TxtCliente1.Text;
            LstClienti[1].Nome = TxtCliente2.Text;
            LstClienti[2].Nome = TxtCliente3.Text;
            LstClienti[3].Nome = TxtCliente4.Text;
            LstClienti[4].Nome = TxtCliente5.Text;
        }

        private void ConvalidaTextbox(object sender, CancelEventArgs e)
        {
            TextBox x = sender as TextBox;
            if (!Vuoto(x.Text))
            {
                // Cancel the event and select the text to be corrected by the user.
                e.Cancel = true;
                x.Select(0, x.Text.Length);
            }
        }

        public bool Vuoto(string stringa)
        {
            if (stringa.Length == 0 || stringa.Length > 11)
            {
                return false;
            }
            else
            {
                return true;
            }
        }

    }
}
