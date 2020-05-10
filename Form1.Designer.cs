namespace BarbiereCheDorme
{
    partial class BarbiereForm
    {
        /// <summary>
        /// Variabile di progettazione necessaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Pulire le risorse in uso.
        /// </summary>
        /// <param name="disposing">ha valore true se le risorse gestite devono essere eliminate, false in caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Codice generato da Progettazione Windows Form

        /// <summary>
        /// Metodo necessario per il supporto della finestra di progettazione. Non modificare
        /// il contenuto del metodo con l'editor di codice.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BarbiereForm));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.LConsole = new System.Windows.Forms.ListView();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label7 = new System.Windows.Forms.Label();
            this.TxtMaxGenera = new System.Windows.Forms.NumericUpDown();
            this.label6 = new System.Windows.Forms.Label();
            this.TxtMinGenera = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.BtnNuovoCliente = new System.Windows.Forms.Button();
            this.RadioAutomatica = new System.Windows.Forms.RadioButton();
            this.BtnReset = new System.Windows.Forms.Button();
            this.RadioManuale = new System.Windows.Forms.RadioButton();
            this.BtnAvvia = new System.Windows.Forms.Button();
            this.GNegozio = new System.Windows.Forms.GroupBox();
            this.label9 = new System.Windows.Forms.Label();
            this.TxtTempTaglio = new System.Windows.Forms.NumericUpDown();
            this.label8 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.ImgBoxUscita = new System.Windows.Forms.PictureBox();
            this.ImgBoxBarbiere = new System.Windows.Forms.PictureBox();
            this.ImgBoxSedia4 = new System.Windows.Forms.PictureBox();
            this.ImgBoxSedia3 = new System.Windows.Forms.PictureBox();
            this.ImgBoxSedia1 = new System.Windows.Forms.PictureBox();
            this.ImgBoxSedia2 = new System.Windows.Forms.PictureBox();
            this.ImgBoxEntrata = new System.Windows.Forms.PictureBox();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripSplitButton2 = new System.Windows.Forms.ToolStripSplitButton();
            this.BtnEsci = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripSplitButton1 = new System.Windows.Forms.ToolStripSplitButton();
            this.BtnNomiClienti = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.BtnInfo = new System.Windows.Forms.ToolStripButton();
            this.LBoxClienti = new System.Windows.Forms.ListBox();
            this.label10 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TxtMaxGenera)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtMinGenera)).BeginInit();
            this.GNegozio.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TxtTempTaglio)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ImgBoxUscita)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ImgBoxBarbiere)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ImgBoxSedia4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ImgBoxSedia3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ImgBoxSedia1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ImgBoxSedia2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ImgBoxEntrata)).BeginInit();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.LConsole);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Font = new System.Drawing.Font("Open Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(945, 29);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox1.Size = new System.Drawing.Size(390, 582);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Impostazioni";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Open Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(167, 377);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 18);
            this.label1.TabIndex = 6;
            this.label1.Text = "Console";
            // 
            // LConsole
            // 
            this.LConsole.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.LConsole.Font = new System.Drawing.Font("Open Sans", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LConsole.ForeColor = System.Drawing.Color.White;
            this.LConsole.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.None;
            this.LConsole.Location = new System.Drawing.Point(20, 398);
            this.LConsole.Margin = new System.Windows.Forms.Padding(5);
            this.LConsole.MultiSelect = false;
            this.LConsole.Name = "LConsole";
            this.LConsole.Size = new System.Drawing.Size(354, 177);
            this.LConsole.TabIndex = 2;
            this.LConsole.TileSize = new System.Drawing.Size(320, 14);
            this.LConsole.UseCompatibleStateImageBehavior = false;
            this.LConsole.View = System.Windows.Forms.View.Tile;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.TxtMaxGenera);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.TxtMinGenera);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.BtnNuovoCliente);
            this.groupBox2.Controls.Add(this.RadioAutomatica);
            this.groupBox2.Controls.Add(this.BtnReset);
            this.groupBox2.Controls.Add(this.RadioManuale);
            this.groupBox2.Controls.Add(this.BtnAvvia);
            this.groupBox2.Location = new System.Drawing.Point(20, 42);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(354, 332);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Modalità";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Open Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(274, 118);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(30, 18);
            this.label7.TabIndex = 10;
            this.label7.Text = "sec.";
            // 
            // TxtMaxGenera
            // 
            this.TxtMaxGenera.AutoSize = true;
            this.TxtMaxGenera.DecimalPlaces = 1;
            this.TxtMaxGenera.Font = new System.Drawing.Font("Open Sans", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtMaxGenera.Increment = new decimal(new int[] {
            5,
            0,
            0,
            65536});
            this.TxtMaxGenera.Location = new System.Drawing.Point(211, 114);
            this.TxtMaxGenera.Maximum = new decimal(new int[] {
            50,
            0,
            0,
            0});
            this.TxtMaxGenera.Minimum = new decimal(new int[] {
            5,
            0,
            0,
            65536});
            this.TxtMaxGenera.Name = "TxtMaxGenera";
            this.TxtMaxGenera.ReadOnly = true;
            this.TxtMaxGenera.Size = new System.Drawing.Size(57, 22);
            this.TxtMaxGenera.TabIndex = 8;
            this.TxtMaxGenera.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.TxtMaxGenera.ValueChanged += new System.EventHandler(this.ValoreCambiatoTextbox);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Open Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(274, 83);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(30, 18);
            this.label6.TabIndex = 9;
            this.label6.Text = "sec.";
            // 
            // TxtMinGenera
            // 
            this.TxtMinGenera.AutoSize = true;
            this.TxtMinGenera.DecimalPlaces = 1;
            this.TxtMinGenera.Font = new System.Drawing.Font("Open Sans", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtMinGenera.Increment = new decimal(new int[] {
            5,
            0,
            0,
            65536});
            this.TxtMinGenera.Location = new System.Drawing.Point(211, 79);
            this.TxtMinGenera.Maximum = new decimal(new int[] {
            50,
            0,
            0,
            0});
            this.TxtMinGenera.Minimum = new decimal(new int[] {
            5,
            0,
            0,
            65536});
            this.TxtMinGenera.Name = "TxtMinGenera";
            this.TxtMinGenera.ReadOnly = true;
            this.TxtMinGenera.Size = new System.Drawing.Size(57, 22);
            this.TxtMinGenera.TabIndex = 7;
            this.TxtMinGenera.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.TxtMinGenera.ValueChanged += new System.EventHandler(this.ValoreCambiatoTextbox);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Open Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(50, 118);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(117, 18);
            this.label5.TabIndex = 6;
            this.label5.Text = "Max - genera ogni:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Open Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(50, 83);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(114, 18);
            this.label4.TabIndex = 5;
            this.label4.Text = "Min - genera ogni:";
            // 
            // BtnNuovoCliente
            // 
            this.BtnNuovoCliente.BackColor = System.Drawing.Color.Cyan;
            this.BtnNuovoCliente.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnNuovoCliente.Enabled = false;
            this.BtnNuovoCliente.Font = new System.Drawing.Font("Open Sans Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnNuovoCliente.Location = new System.Drawing.Point(50, 270);
            this.BtnNuovoCliente.Name = "BtnNuovoCliente";
            this.BtnNuovoCliente.Size = new System.Drawing.Size(260, 47);
            this.BtnNuovoCliente.TabIndex = 4;
            this.BtnNuovoCliente.Text = "+      Nuovo Cliente      +";
            this.BtnNuovoCliente.UseVisualStyleBackColor = false;
            this.BtnNuovoCliente.Click += new System.EventHandler(this.BtnNuovoCliente_Click);
            // 
            // RadioAutomatica
            // 
            this.RadioAutomatica.AutoSize = true;
            this.RadioAutomatica.Checked = true;
            this.RadioAutomatica.Cursor = System.Windows.Forms.Cursors.Hand;
            this.RadioAutomatica.Location = new System.Drawing.Point(24, 37);
            this.RadioAutomatica.Name = "RadioAutomatica";
            this.RadioAutomatica.Size = new System.Drawing.Size(115, 26);
            this.RadioAutomatica.TabIndex = 1;
            this.RadioAutomatica.TabStop = true;
            this.RadioAutomatica.Text = "Automatica";
            this.RadioAutomatica.UseVisualStyleBackColor = true;
            this.RadioAutomatica.CheckedChanged += new System.EventHandler(this.RadioAutomatica_CheckedChanged);
            // 
            // BtnReset
            // 
            this.BtnReset.BackColor = System.Drawing.Color.OrangeRed;
            this.BtnReset.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnReset.Font = new System.Drawing.Font("Open Sans Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnReset.Location = new System.Drawing.Point(198, 155);
            this.BtnReset.Name = "BtnReset";
            this.BtnReset.Size = new System.Drawing.Size(112, 47);
            this.BtnReset.TabIndex = 3;
            this.BtnReset.Text = "Reset";
            this.BtnReset.UseVisualStyleBackColor = false;
            this.BtnReset.Click += new System.EventHandler(this.BtnReset_Click);
            // 
            // RadioManuale
            // 
            this.RadioManuale.AutoSize = true;
            this.RadioManuale.Cursor = System.Windows.Forms.Cursors.Hand;
            this.RadioManuale.Location = new System.Drawing.Point(24, 224);
            this.RadioManuale.Name = "RadioManuale";
            this.RadioManuale.Size = new System.Drawing.Size(93, 26);
            this.RadioManuale.TabIndex = 0;
            this.RadioManuale.Text = "Manuale";
            this.RadioManuale.UseVisualStyleBackColor = true;
            // 
            // BtnAvvia
            // 
            this.BtnAvvia.BackColor = System.Drawing.Color.LimeGreen;
            this.BtnAvvia.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnAvvia.Font = new System.Drawing.Font("Open Sans Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnAvvia.Location = new System.Drawing.Point(50, 155);
            this.BtnAvvia.Name = "BtnAvvia";
            this.BtnAvvia.Size = new System.Drawing.Size(111, 47);
            this.BtnAvvia.TabIndex = 2;
            this.BtnAvvia.Text = "Start";
            this.BtnAvvia.UseVisualStyleBackColor = false;
            this.BtnAvvia.Click += new System.EventHandler(this.BtnAvvia_Click);
            // 
            // GNegozio
            // 
            this.GNegozio.Controls.Add(this.label10);
            this.GNegozio.Controls.Add(this.LBoxClienti);
            this.GNegozio.Controls.Add(this.label9);
            this.GNegozio.Controls.Add(this.TxtTempTaglio);
            this.GNegozio.Controls.Add(this.label8);
            this.GNegozio.Controls.Add(this.label3);
            this.GNegozio.Controls.Add(this.label2);
            this.GNegozio.Controls.Add(this.ImgBoxUscita);
            this.GNegozio.Controls.Add(this.ImgBoxBarbiere);
            this.GNegozio.Controls.Add(this.ImgBoxSedia4);
            this.GNegozio.Controls.Add(this.ImgBoxSedia3);
            this.GNegozio.Controls.Add(this.ImgBoxSedia1);
            this.GNegozio.Controls.Add(this.ImgBoxSedia2);
            this.GNegozio.Controls.Add(this.ImgBoxEntrata);
            this.GNegozio.Font = new System.Drawing.Font("Open Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GNegozio.Location = new System.Drawing.Point(12, 29);
            this.GNegozio.Name = "GNegozio";
            this.GNegozio.Size = new System.Drawing.Size(926, 583);
            this.GNegozio.TabIndex = 2;
            this.GNegozio.TabStop = false;
            this.GNegozio.Text = "Salone";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Open Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(512, 557);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(30, 18);
            this.label9.TabIndex = 11;
            this.label9.Text = "sec.";
            // 
            // TxtTempTaglio
            // 
            this.TxtTempTaglio.AutoSize = true;
            this.TxtTempTaglio.DecimalPlaces = 1;
            this.TxtTempTaglio.Font = new System.Drawing.Font("Open Sans", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtTempTaglio.Increment = new decimal(new int[] {
            5,
            0,
            0,
            65536});
            this.TxtTempTaglio.Location = new System.Drawing.Point(449, 555);
            this.TxtTempTaglio.Maximum = new decimal(new int[] {
            40,
            0,
            0,
            0});
            this.TxtTempTaglio.Minimum = new decimal(new int[] {
            5,
            0,
            0,
            65536});
            this.TxtTempTaglio.Name = "TxtTempTaglio";
            this.TxtTempTaglio.ReadOnly = true;
            this.TxtTempTaglio.Size = new System.Drawing.Size(57, 22);
            this.TxtTempTaglio.TabIndex = 10;
            this.TxtTempTaglio.Value = new decimal(new int[] {
            3,
            0,
            0,
            0});
            this.TxtTempTaglio.ValueChanged += new System.EventHandler(this.TxtTempTaglio_ValueChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Open Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(345, 557);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(89, 18);
            this.label8.TabIndex = 9;
            this.label8.Text = "Tempo taglio:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Open Sans Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Gold;
            this.label3.Location = new System.Drawing.Point(767, 264);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 26);
            this.label3.TabIndex = 8;
            this.label3.Text = "Uscita";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Open Sans Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Gold;
            this.label2.Location = new System.Drawing.Point(76, 264);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 26);
            this.label2.TabIndex = 7;
            this.label2.Text = "Entrata";
            // 
            // ImgBoxUscita
            // 
            this.ImgBoxUscita.Location = new System.Drawing.Point(690, 264);
            this.ImgBoxUscita.Name = "ImgBoxUscita";
            this.ImgBoxUscita.Size = new System.Drawing.Size(208, 311);
            this.ImgBoxUscita.TabIndex = 6;
            this.ImgBoxUscita.TabStop = false;
            // 
            // ImgBoxBarbiere
            // 
            this.ImgBoxBarbiere.ErrorImage = null;
            this.ImgBoxBarbiere.InitialImage = null;
            this.ImgBoxBarbiere.Location = new System.Drawing.Point(339, 312);
            this.ImgBoxBarbiere.Name = "ImgBoxBarbiere";
            this.ImgBoxBarbiere.Size = new System.Drawing.Size(220, 220);
            this.ImgBoxBarbiere.TabIndex = 5;
            this.ImgBoxBarbiere.TabStop = false;
            // 
            // ImgBoxSedia4
            // 
            this.ImgBoxSedia4.Location = new System.Drawing.Point(723, 59);
            this.ImgBoxSedia4.Name = "ImgBoxSedia4";
            this.ImgBoxSedia4.Size = new System.Drawing.Size(150, 150);
            this.ImgBoxSedia4.TabIndex = 4;
            this.ImgBoxSedia4.TabStop = false;
            // 
            // ImgBoxSedia3
            // 
            this.ImgBoxSedia3.Location = new System.Drawing.Point(550, 59);
            this.ImgBoxSedia3.Name = "ImgBoxSedia3";
            this.ImgBoxSedia3.Size = new System.Drawing.Size(150, 150);
            this.ImgBoxSedia3.TabIndex = 3;
            this.ImgBoxSedia3.TabStop = false;
            // 
            // ImgBoxSedia1
            // 
            this.ImgBoxSedia1.Location = new System.Drawing.Point(189, 59);
            this.ImgBoxSedia1.Name = "ImgBoxSedia1";
            this.ImgBoxSedia1.Size = new System.Drawing.Size(150, 150);
            this.ImgBoxSedia1.TabIndex = 2;
            this.ImgBoxSedia1.TabStop = false;
            // 
            // ImgBoxSedia2
            // 
            this.ImgBoxSedia2.Location = new System.Drawing.Point(373, 59);
            this.ImgBoxSedia2.Name = "ImgBoxSedia2";
            this.ImgBoxSedia2.Size = new System.Drawing.Size(150, 150);
            this.ImgBoxSedia2.TabIndex = 1;
            this.ImgBoxSedia2.TabStop = false;
            // 
            // ImgBoxEntrata
            // 
            this.ImgBoxEntrata.Location = new System.Drawing.Point(17, 266);
            this.ImgBoxEntrata.Name = "ImgBoxEntrata";
            this.ImgBoxEntrata.Size = new System.Drawing.Size(208, 311);
            this.ImgBoxEntrata.TabIndex = 0;
            this.ImgBoxEntrata.TabStop = false;
            // 
            // toolStrip1
            // 
            this.toolStrip1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.toolStrip1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.toolStrip1.Font = new System.Drawing.Font("Open Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripSplitButton2,
            this.toolStripSeparator2,
            this.toolStripSplitButton1,
            this.toolStripSeparator1,
            this.BtnInfo});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1347, 25);
            this.toolStrip1.TabIndex = 3;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripSplitButton2
            // 
            this.toolStripSplitButton2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripSplitButton2.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.BtnEsci});
            this.toolStripSplitButton2.Font = new System.Drawing.Font("Open Sans", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStripSplitButton2.Image = ((System.Drawing.Image)(resources.GetObject("toolStripSplitButton2.Image")));
            this.toolStripSplitButton2.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripSplitButton2.Name = "toolStripSplitButton2";
            this.toolStripSplitButton2.Size = new System.Drawing.Size(43, 22);
            this.toolStripSplitButton2.Text = "File";
            // 
            // BtnEsci
            // 
            this.BtnEsci.Name = "BtnEsci";
            this.BtnEsci.Size = new System.Drawing.Size(98, 22);
            this.BtnEsci.Text = "Esci";
            this.BtnEsci.Click += new System.EventHandler(this.BtnEsci_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripSplitButton1
            // 
            this.toolStripSplitButton1.BackColor = System.Drawing.Color.White;
            this.toolStripSplitButton1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.toolStripSplitButton1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.BtnNomiClienti});
            this.toolStripSplitButton1.Font = new System.Drawing.Font("Open Sans", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStripSplitButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripSplitButton1.Image")));
            this.toolStripSplitButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripSplitButton1.Name = "toolStripSplitButton1";
            this.toolStripSplitButton1.Size = new System.Drawing.Size(88, 22);
            this.toolStripSplitButton1.Text = "Modifica";
            // 
            // BtnNomiClienti
            // 
            this.BtnNomiClienti.Name = "BtnNomiClienti";
            this.BtnNomiClienti.Size = new System.Drawing.Size(152, 22);
            this.BtnNomiClienti.Text = "Nomi clienti";
            this.BtnNomiClienti.Click += new System.EventHandler(this.BtnNomiClienti_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // BtnInfo
            // 
            this.BtnInfo.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.BtnInfo.Font = new System.Drawing.Font("Open Sans", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnInfo.Image = ((System.Drawing.Image)(resources.GetObject("BtnInfo.Image")));
            this.BtnInfo.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.BtnInfo.Name = "BtnInfo";
            this.BtnInfo.Size = new System.Drawing.Size(23, 22);
            this.BtnInfo.Text = "?";
            this.BtnInfo.ToolTipText = "Help\r\n";
            // 
            // LBoxClienti
            // 
            this.LBoxClienti.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.LBoxClienti.Font = new System.Drawing.Font("Open Sans Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBoxClienti.ForeColor = System.Drawing.SystemColors.ControlText;
            this.LBoxClienti.FormattingEnabled = true;
            this.LBoxClienti.ItemHeight = 18;
            this.LBoxClienti.Location = new System.Drawing.Point(17, 79);
            this.LBoxClienti.Name = "LBoxClienti";
            this.LBoxClienti.Size = new System.Drawing.Size(116, 130);
            this.LBoxClienti.TabIndex = 12;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Open Sans", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(13, 56);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(114, 20);
            this.label10.TabIndex = 13;
            this.label10.Text = "Clienti negozio:";
            // 
            // BarbiereForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1347, 619);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.GNegozio);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Open Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "BarbiereForm";
            this.Text = "Barbiere che dorme";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.BarbiereForm_FormClosed);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TxtMaxGenera)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtMinGenera)).EndInit();
            this.GNegozio.ResumeLayout(false);
            this.GNegozio.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TxtTempTaglio)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ImgBoxUscita)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ImgBoxBarbiere)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ImgBoxSedia4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ImgBoxSedia3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ImgBoxSedia1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ImgBoxSedia2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ImgBoxEntrata)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button BtnNuovoCliente;
        private System.Windows.Forms.Button BtnReset;
        private System.Windows.Forms.Button BtnAvvia;
        private System.Windows.Forms.RadioButton RadioAutomatica;
        private System.Windows.Forms.RadioButton RadioManuale;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ListView LConsole;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox GNegozio;
        private System.Windows.Forms.PictureBox ImgBoxBarbiere;
        private System.Windows.Forms.PictureBox ImgBoxSedia4;
        private System.Windows.Forms.PictureBox ImgBoxSedia3;
        private System.Windows.Forms.PictureBox ImgBoxSedia1;
        private System.Windows.Forms.PictureBox ImgBoxSedia2;
        private System.Windows.Forms.PictureBox ImgBoxEntrata;
        private System.Windows.Forms.PictureBox ImgBoxUscita;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown TxtMaxGenera;
        private System.Windows.Forms.NumericUpDown TxtMinGenera;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.NumericUpDown TxtTempTaglio;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripSplitButton toolStripSplitButton2;
        private System.Windows.Forms.ToolStripMenuItem BtnEsci;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripSplitButton toolStripSplitButton1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton BtnInfo;
        private System.Windows.Forms.ToolStripMenuItem BtnNomiClienti;
        private System.Windows.Forms.ListBox LBoxClienti;
        private System.Windows.Forms.Label label10;
    }
}

