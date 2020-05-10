using System;
using System.Drawing;

namespace BarbiereCheDorme
{
    public class ListaClienti
    {
        private Color colore;

        public Color Colore
        {
            get { return colore; }
            set { colore = value; }
        }

        private string nome;

        public string Nome
        {
            get { return nome; }
            set { nome = value; }
        }

        private string clienteSeduto;

        public string ClienteSeduto
        {
            get { return clienteSeduto; }
            set { clienteSeduto = value; }
        }

        private string clienteEntrata;

        public string ClienteEntrata
        {
            get { return clienteEntrata; }
            set { clienteEntrata = value; }
        }

        private string clienteUscita;

        public string ClienteUscita
        {
            get { return clienteUscita; }
            set { clienteUscita = value; }
        }

        private string clienteBarbiere;

        public string ClienteBarbiere
        {
            get { return clienteBarbiere; }
            set { clienteBarbiere = value; }
        }

        private string clienteAsciuga;

        public string ClienteAsciuga
        {
            get { return clienteAsciuga; }
            set { clienteAsciuga = value; }
        }

        public ListaClienti()
        {

        }

        public ListaClienti(string Seduto, string Entrata, string Uscita, string Barbiere, string asciuga, string Nome, Color Colore)
        {
            clienteSeduto = Seduto;
            clienteEntrata = Entrata;
            clienteUscita = Uscita;
            clienteBarbiere = Barbiere;
            clienteAsciuga = asciuga;
            nome = Nome;
            colore = Colore;
        }
    }
}
