using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Threading;
using System.Windows.Forms;

namespace BarbiereCheDorme
{
   

    public partial class BarbiereForm : Form
    {
        Random rnd = new Random();  // Usata in seguito per creare intervallo random

        string dir = Directory.GetCurrentDirectory() + @"\Immagini\";           // Per la cartella delle immagini
        List<ListaClienti> LstClienti;      // Lista che contiene le immagini per ogni situazione, un nome ed un colore per ogni cliente.         

        bool Automatica = true;    // Sapere se modalità è automatica o manuale

        int sedie = 4;      

#region Vari_Delay

        decimal GeneraOgniMax;        
        decimal GeneraOgniMin;
        decimal TempoTaglio;

#endregion

#region SEMAFORI:

        Semaphore SEM_clienti = new Semaphore(0, 4);
        Semaphore SEM_barbieri = new Semaphore(0, 1);
        Mutex mutex = new Mutex();
        int In_attesa = 0;

#endregion

        //                                    1      2      3      4
        bool[] SedieOccupate = new bool[] { false, false, false, false };  // Quali sedie sono libere -- Serve per dire al cliente dove sedersi!

        List<int> ClientiOrdineDiArrivo = new List<int>();  // Utile per capire l'ordine di arrivo --> per stabilire quale immagine usare dal barbiere.

        Thread Nuovo_Barbiere;  // Dichiarazione del thread Barbiere


        public BarbiereForm()
        {
            #region Lista Formata da tutti i Link delle immagini necessarie per ogni cliente, per ogni situazione; DA UN NOME E DAL COLORE ASSOCIATO SULL'IMMAGINE

                LstClienti = new List<ListaClienti>(new ListaClienti[] {
                    new ListaClienti(dir + "SedutoCliente1.png",     dir + "EntrataCliente1.png",     dir + "UscitaCliente1.png",    dir + "BarbiereCliente1.png",     dir + "AsciugaCliente1.png",      "Antonio",    Color.Blue),       // BLU 1
                    new ListaClienti(dir + "SedutoCliente2.png",     dir + "EntrataCliente2.png",     dir + "UscitaCliente2.png",    dir + "BarbiereCliente2.png",     dir + "AsciugaCliente2.png",      "Giacomo",    Color.Green),       // VERDE 2
                    new ListaClienti(dir + "SedutoCliente3.png",     dir + "EntrataCliente3.png",     dir + "UscitaCliente3.png",    dir + "BarbiereCliente3.png",     dir + "AsciugaCliente3.png",      "Pietro",     Color.Red),        // ROSSO 3
                    new ListaClienti(dir + "SedutoCliente4.png",     dir + "EntrataCliente4.png",     dir + "UscitaCliente4.png",    dir + "BarbiereCliente4.png",     dir + "AsciugaCliente4.png",      "Federico",   Color.Yellow),      // GIALLO 4
                    new ListaClienti(dir + "SedutoCliente5.png",     dir + "EntrataCliente5.png",     dir + "UscitaCliente5.png",    dir + "BarbiereCliente5.png",     dir + "AsciugaCliente5.png",      "Mattia",     Color.LightBlue),        // AZZURRO 5
                });

            #endregion

            InitializeComponent();
            ListView.CheckForIllegalCrossThreadCalls = false;   // EVITA DI CONTROLLARE ERRORI CROSS - THREAD!

            InizializzazionePictureBoxAndDelays();

            Nuovo_Barbiere = new Thread(new ThreadStart(Barbiere));                       // INIZIALIZZO THREAD BARBIERE
            Nuovo_Barbiere.IsBackground = true;
            Nuovo_Barbiere.Start();                                  // STARTO THREAD BARBIERE
        }

        // Inizializzazione Immagini e Delay:
        private void InizializzazionePictureBoxAndDelays()
        {
            // PictureBox
            ImgBoxBarbiere.Image = Image.FromFile(dir + "BarbiereDorme.png");
            ImgBoxEntrata.Image = Image.FromFile(dir + "PortaChiusa.png");
            ImgBoxUscita.Image = Image.FromFile(dir + "PortaChiusa.png");
            ImgBoxSedia1.Image = Image.FromFile(dir + "SediaVuota.png");
            ImgBoxSedia2.Image = Image.FromFile(dir + "SediaVuota.png");
            ImgBoxSedia3.Image = Image.FromFile(dir + "SediaVuota.png");
            ImgBoxSedia4.Image = Image.FromFile(dir + "SediaVuota.png");

            // Delay
            GeneraOgniMax = TxtMaxGenera.Value;
            GeneraOgniMin = TxtMinGenera.Value;
            TempoTaglio = TxtTempTaglio.Value;
        }

#region THREADS

        // THREAD CLIENTE
        private void Cliente()
        {
            int indexCliente = rnd.Next(0, 5);  // Prendo un cliente a caso dalla lista sopra dei clienti.
            Cliente_Entra(indexCliente);  // Il cliente entra nel negozio
            mutex.WaitOne();
            if (In_attesa < sedie)        // Controlla se ci sono sedie libere
            {
                In_attesa++;
                int SedutoSu = Cliente_Siediti(indexCliente);
                SEM_clienti.Release();
                mutex.ReleaseMutex();
                ClientiOrdineDiArrivo.Add(indexCliente);       // Aggiungi alla lista di arrivo quale cliente si è seduto
                SEM_barbieri.WaitOne();                         
                Cliente_Alzati(SedutoSu);                   // Il cliente si alza e va a tagliarsi i capelli
            }
            else                 // Non ci sono sedie libere
            {
                mutex.ReleaseMutex();
                Cliente_EsciScontento(indexCliente);
            }
        }

        // THREAD BARBIERE
        private void Barbiere()
        {     
            while (true)
            {
                SEM_clienti.WaitOne();
                mutex.WaitOne();
                In_attesa--;
                SEM_barbieri.Release();
                mutex.ReleaseMutex();
                Barbiere_TagliaCapelli(ClientiOrdineDiArrivo[0]);    // Il barbiere taglia i capelli al cliente
            }
        }

#endregion

#region Metodi Vari

        // Metodo entrata cliente nel negozio:
        private void Cliente_Entra(int indexCliente)
        {
            WriteConsole("++ Entra nuovo cliente: " + LstClienti[indexCliente].Nome, LstClienti[indexCliente].Colore); // Scrivi nella console
            LBoxClienti.Items.Insert(0, LstClienti[indexCliente].Nome);
            ImgBoxEntrata.Image = Image.FromFile(LstClienti[indexCliente].ClienteEntrata);
            Thread.Sleep(500);
            ImgBoxEntrata.Image = Image.FromFile(dir + "PortaChiusa.png");
        }

        // Medodo cliente siediti su una sedia libera:
        private int Cliente_Siediti(int indexCliente)
        {
            if (SedieOccupate[0] == false)
            {
                ImgBoxSedia1.Image = Image.FromFile(LstClienti[indexCliente].ClienteSeduto);
                SedieOccupate[0] = true;
                WriteConsole("$$ Il cliente " + LstClienti[indexCliente].Nome + " si è seduto sulla sedia 1.", LstClienti[indexCliente].Colore);
                return 1;
            }
            else if (SedieOccupate[1] == false)
            {
                ImgBoxSedia2.Image = Image.FromFile(LstClienti[indexCliente].ClienteSeduto);
                SedieOccupate[1] = true;
                WriteConsole("$$ Il cliente " + LstClienti[indexCliente].Nome + " si è seduto sulla sedia 2.", LstClienti[indexCliente].Colore);
                return 2;
            }
            else if (SedieOccupate[2] == false)
            {
                ImgBoxSedia3.Image = Image.FromFile(LstClienti[indexCliente].ClienteSeduto);
                SedieOccupate[2] = true;
                WriteConsole("$$ Il cliente " + LstClienti[indexCliente].Nome + " si è seduto sulla sedia 3.", LstClienti[indexCliente].Colore);
                return 3;
            }
            else
            {
                ImgBoxSedia4.Image = Image.FromFile(LstClienti[indexCliente].ClienteSeduto);
                SedieOccupate[3] = true;
                WriteConsole("$$ Il cliente " + LstClienti[indexCliente].Nome + " si è seduto sulla sedia 4.", LstClienti[indexCliente].Colore);
                return 4;
            }
        }

        // Metodo cliente esce scontento perchè il negozio è pieno
        private void Cliente_EsciScontento(int indexCliente)
        {
            ImgBoxUscita.Image = Image.FromFile(LstClienti[indexCliente].ClienteEntrata);
            WriteConsole("-- Sedie piene esce cliente: " + LstClienti[indexCliente].Nome, LstClienti[indexCliente].Colore);
            LBoxClienti.Items.RemoveAt(0);
            Thread.Sleep(500);
            ImgBoxUscita.Image = Image.FromFile(dir + "PortaChiusa.png");
        }

        // Metodo il cliente si alza dalla sedia e va a tagliarsi i capelli
        private void Cliente_Alzati(int SedutoSu)
        {
            if (SedutoSu == 1)
            {
                ImgBoxSedia1.Image = Image.FromFile(dir + "SediaVuota.png");
                SedieOccupate[0] = false;
            }
            else if (SedutoSu == 2)
            {
                ImgBoxSedia2.Image = Image.FromFile(dir + "SediaVuota.png");
                SedieOccupate[1] = false;
            }
            else if (SedutoSu == 3)
            {
                ImgBoxSedia3.Image = Image.FromFile(dir + "SediaVuota.png");
                SedieOccupate[2] = false;
            }
            else if (SedutoSu == 4)
            {
                ImgBoxSedia4.Image = Image.FromFile(dir + "SediaVuota.png");
                SedieOccupate[3] = false;
            }
        }

        // Metodo taglia capelli barbiere + uscita del cliente dal negozio felice!
        private void Barbiere_TagliaCapelli(int indexCliente)
        {
            ClientiOrdineDiArrivo.RemoveAt(0);      // Rimuovo il cliente dalla lista di arrivo

            WriteConsole(">> Il cliente " + LstClienti[indexCliente].Nome + " sta tagliando i capelli.", LstClienti[indexCliente].Colore);

            ImgBoxBarbiere.Image = Image.FromFile(LstClienti[indexCliente].ClienteBarbiere);
            Thread.Sleep(Convert.ToInt32(TempoTaglio * 500));  // TEMPO TAGLIA I CAPELLI

            ImgBoxBarbiere.Image = Image.FromFile(LstClienti[indexCliente].ClienteAsciuga);
            Thread.Sleep(Convert.ToInt32(TempoTaglio * 500));  // TEMPO ASCIUGA I CAPELLI

            ImgBoxUscita.Image = Image.FromFile(LstClienti[indexCliente].ClienteUscita);
            ImgBoxBarbiere.Image = Image.FromFile(dir + "BarbiereAspetta.png");

            WriteConsole(">> Il cliente " + LstClienti[indexCliente].Nome + " ha finito di tagliare i capelli!!", LstClienti[indexCliente].Colore);

            Thread.Sleep(500);
            WriteConsole("-- Il cliente " + LstClienti[indexCliente].Nome + " è uscito dal negozio!", LstClienti[indexCliente].Colore);
            LBoxClienti.Items.RemoveAt(LBoxClienti.Items.Count - 1);

            ImgBoxUscita.Image = Image.FromFile(dir + "PortaChiusa.png");
            ImgBoxBarbiere.Image = Image.FromFile(dir + "BarbiereDorme.png");
        }

        // Metodo per scrivere nella console
        private void WriteConsole(string Testo, Color Colore)
        {
            ListViewItem temp = new ListViewItem();
            temp.Text = Testo;
            temp.ForeColor = Colore;
            LConsole.Items.Insert(0, temp);
            LConsole.EnsureVisible(0);
        }

        // Metodo per la generazione automatica dei clienti
        private void ModalitàAutomatica()
        {
            while(Automatica == true)
            {
                int GeneraOgni = rnd.Next(Convert.ToInt32(GeneraOgniMin * 1000), Convert.ToInt32(GeneraOgniMax * 1000));
                Thread.Sleep(GeneraOgni);
                Thread Nuovo_cliente = new Thread(new ThreadStart(Cliente));            // Crea un thread cliente dopo un certo intervallo
                Nuovo_cliente.IsBackground = true;
                Nuovo_cliente.Start();                  // Lo starta
            }
        }

#endregion

#region EventiForm

        // Stabilisce quale modalità è stata selezionata e la cambia se viene cambiata.
        private void RadioAutomatica_CheckedChanged(object sender, EventArgs e)
        {
            if (RadioAutomatica.Checked == true)
            {
                Automatica = true;
                BtnAvvia.Enabled = true;
                BtnReset.Enabled = true;
                BtnNuovoCliente.Enabled = false;
                LConsole.Items.Add("Modalità automatica inserita;");
            }
            else
            {
                Automatica = false;
                BtnNuovoCliente.Enabled = true;
                BtnAvvia.BackColor = Color.LimeGreen;
                BtnAvvia.Text = "Start";
                BtnAvvia.Enabled = false;
                BtnReset.Enabled = false;
                LConsole.Items.Add("Modalità manuale inserita;");
            }
            
        }

        // Crea un cliente ogni volta che si preme il bottone --> SOLO MODALITà MANUALE
        private void BtnNuovoCliente_Click(object sender, EventArgs e)
        {
            Thread Nuovo_cliente = new Thread(new ThreadStart(Cliente));
            Nuovo_cliente.IsBackground = true;
            Nuovo_cliente.Start();
        }

        // Evento bottone che crea un thread per la modalità automatica
        private void BtnAvvia_Click(object sender, EventArgs e)
        {
            if (RadioAutomatica.Checked == true && BtnAvvia.Text == "Start")
            {
                Thread Mod_Automatica = new Thread(new ThreadStart(ModalitàAutomatica));
                Mod_Automatica.IsBackground = true;
                Mod_Automatica.Start();
                BtnAvvia.BackColor = Color.Yellow;
                BtnAvvia.Text = "Stop";
            }
            else if (RadioAutomatica.Checked == true && BtnAvvia.Text == "Stop")
            {
                Automatica = false;
                BtnAvvia.BackColor = Color.LimeGreen;
                BtnAvvia.Text = "Start";
            }
        }

        // Resetta tutto --> Chiude il form attuale e ne apre uno nuovo
        private void BtnReset_Click(object sender, EventArgs e)
        {
            var NewForm = new BarbiereForm();
            this.Dispose(false);
            NewForm.Show();          
        }

        // Controlla che il valore della generazione minore sia minore di quello maggiore altrimenti resetta le 2 textbox --> cambia i valori del delay
        private void ValoreCambiatoTextbox(object sender, EventArgs e)  
        {
            if (TxtMinGenera.Value > TxtMaxGenera.Value)
            {
                TxtMaxGenera.Value = 10;
                TxtMinGenera.Value = 1;
            }
            GeneraOgniMax = TxtMaxGenera.Value;
            GeneraOgniMin = TxtMinGenera.Value;
        }

        // Cambia il tempo necessario al taglio dei capelli
        private void TxtTempTaglio_ValueChanged(object sender, EventArgs e)
        {
            TempoTaglio = TxtTempTaglio.Value;
        }

        // Bottone file esci --> chiude tutto
        private void BtnEsci_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        // Chiude tutti i processi
        private void BarbiereForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            BarbiereForm.ActiveForm.Dispose();
        }

        // Cambia nomi clienti
        private void BtnNomiClienti_Click(object sender, EventArgs e)
        {
            var NuovoForm = new NomiClientiForm(LstClienti);
            NuovoForm.ShowDialog();
        }

#endregion


    }
}
