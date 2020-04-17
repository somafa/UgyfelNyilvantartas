namespace UgyfelNyilvantartas
{
    partial class form_Fooldal
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.button_kollega = new System.Windows.Forms.Button();
            this.DG_Fooldal = new System.Windows.Forms.DataGridView();
            this.MunkaID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MunkaFelvetel = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UgyfelNev = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Leiras = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ForrasNyelv = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CelNyelv = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.KollegaNev = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.VeglegesAr = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Hatarido = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EddigFizetve = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ElkeszultDatum = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Statusz = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.lekerdezesekToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.vIPÜgyfélnekMilyenMunkákatKellKiszámlázniToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ügyfélMilyenMunkákÁrávalTartozikToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ügyfélnekMilyenMunkákatCsináltunkEddigToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ügyfélnekMilyenAktívMunkáiVannakToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kollégaEgyenlegeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mennyiATartozásunkToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mennyivelTartoznakNekünkToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.milyenMunkákVannakFolyamatbanToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.milyenMunkákKészültekElÉsMégNemFizettékKiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kinekCsináltunkBizonyosMunkátToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ugyfelToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kollegaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reszletekToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ujmunkaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.frissitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kilepToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.button_ugyfel = new System.Windows.Forms.Button();
            this.button_ujMunka = new System.Windows.Forms.Button();
            this.button_frissit = new System.Windows.Forms.Button();
            this.button_kilep = new System.Windows.Forms.Button();
            this.button_reszletek = new System.Windows.Forms.Button();
            this.checkBox_Aktiv = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.DG_Fooldal)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // button_kollega
            // 
            this.button_kollega.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.button_kollega.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Red;
            this.button_kollega.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_kollega.ForeColor = System.Drawing.SystemColors.WindowText;
            this.button_kollega.Location = new System.Drawing.Point(240, 32);
            this.button_kollega.Name = "button_kollega";
            this.button_kollega.Size = new System.Drawing.Size(104, 37);
            this.button_kollega.TabIndex = 0;
            this.button_kollega.Text = "Kolléga";
            this.button_kollega.UseVisualStyleBackColor = false;
            this.button_kollega.Click += new System.EventHandler(this.button_kollega_Click);
            // 
            // DG_Fooldal
            // 
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DG_Fooldal.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.DG_Fooldal.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DG_Fooldal.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MunkaID,
            this.MunkaFelvetel,
            this.UgyfelNev,
            this.Leiras,
            this.ForrasNyelv,
            this.CelNyelv,
            this.KollegaNev,
            this.VeglegesAr,
            this.Hatarido,
            this.EddigFizetve,
            this.ElkeszultDatum,
            this.Statusz});
            this.DG_Fooldal.Location = new System.Drawing.Point(12, 91);
            this.DG_Fooldal.Name = "DG_Fooldal";
            this.DG_Fooldal.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DG_Fooldal.Size = new System.Drawing.Size(1228, 424);
            this.DG_Fooldal.TabIndex = 1;
            this.DG_Fooldal.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DG_Fooldal_CellContentClick);
            this.DG_Fooldal.SelectionChanged += new System.EventHandler(this.DG_Fooldal_SelectionChanged);
            // 
            // MunkaID
            // 
            this.MunkaID.HeaderText = "MunkaID";
            this.MunkaID.Name = "MunkaID";
            this.MunkaID.ReadOnly = true;
            this.MunkaID.Visible = false;
            // 
            // MunkaFelvetel
            // 
            this.MunkaFelvetel.HeaderText = "Munka felvétele";
            this.MunkaFelvetel.Name = "MunkaFelvetel";
            this.MunkaFelvetel.ReadOnly = true;
            this.MunkaFelvetel.Width = 99;
            // 
            // UgyfelNev
            // 
            this.UgyfelNev.HeaderText = "Ügyfél neve";
            this.UgyfelNev.Name = "UgyfelNev";
            this.UgyfelNev.ReadOnly = true;
            // 
            // Leiras
            // 
            this.Leiras.HeaderText = "Munka rövid leírása";
            this.Leiras.Name = "Leiras";
            this.Leiras.ReadOnly = true;
            // 
            // ForrasNyelv
            // 
            this.ForrasNyelv.HeaderText = "Forrásnyelv";
            this.ForrasNyelv.Name = "ForrasNyelv";
            this.ForrasNyelv.ReadOnly = true;
            // 
            // CelNyelv
            // 
            this.CelNyelv.HeaderText = "Célnyelv";
            this.CelNyelv.Name = "CelNyelv";
            this.CelNyelv.ReadOnly = true;
            // 
            // KollegaNev
            // 
            this.KollegaNev.HeaderText = "Kolléga neve";
            this.KollegaNev.Name = "KollegaNev";
            this.KollegaNev.ReadOnly = true;
            // 
            // VeglegesAr
            // 
            this.VeglegesAr.HeaderText = "Végleges ár";
            this.VeglegesAr.Name = "VeglegesAr";
            this.VeglegesAr.ReadOnly = true;
            // 
            // Hatarido
            // 
            this.Hatarido.HeaderText = "Határidő";
            this.Hatarido.Name = "Hatarido";
            this.Hatarido.ReadOnly = true;
            // 
            // EddigFizetve
            // 
            this.EddigFizetve.HeaderText = "Eddig fizetve";
            this.EddigFizetve.Name = "EddigFizetve";
            this.EddigFizetve.ReadOnly = true;
            // 
            // ElkeszultDatum
            // 
            this.ElkeszultDatum.HeaderText = "Elkészült";
            this.ElkeszultDatum.Name = "ElkeszultDatum";
            this.ElkeszultDatum.ReadOnly = true;
            // 
            // Statusz
            // 
            this.Statusz.HeaderText = "Munka státusza";
            this.Statusz.Name = "Statusz";
            this.Statusz.ReadOnly = true;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lekerdezesekToolStripMenuItem,
            this.ugyfelToolStripMenuItem,
            this.kollegaToolStripMenuItem,
            this.reszletekToolStripMenuItem,
            this.ujmunkaToolStripMenuItem,
            this.frissitToolStripMenuItem,
            this.kilepToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1252, 28);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // lekerdezesekToolStripMenuItem
            // 
            this.lekerdezesekToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.vIPÜgyfélnekMilyenMunkákatKellKiszámlázniToolStripMenuItem,
            this.ügyfélMilyenMunkákÁrávalTartozikToolStripMenuItem,
            this.ügyfélnekMilyenMunkákatCsináltunkEddigToolStripMenuItem,
            this.ügyfélnekMilyenAktívMunkáiVannakToolStripMenuItem,
            this.kollégaEgyenlegeToolStripMenuItem,
            this.mennyiATartozásunkToolStripMenuItem,
            this.mennyivelTartoznakNekünkToolStripMenuItem,
            this.milyenMunkákVannakFolyamatbanToolStripMenuItem,
            this.milyenMunkákKészültekElÉsMégNemFizettékKiToolStripMenuItem,
            this.kinekCsináltunkBizonyosMunkátToolStripMenuItem});
            this.lekerdezesekToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lekerdezesekToolStripMenuItem.Name = "lekerdezesekToolStripMenuItem";
            this.lekerdezesekToolStripMenuItem.Size = new System.Drawing.Size(109, 24);
            this.lekerdezesekToolStripMenuItem.Text = "Lekérdezések";
            // 
            // vIPÜgyfélnekMilyenMunkákatKellKiszámlázniToolStripMenuItem
            // 
            this.vIPÜgyfélnekMilyenMunkákatKellKiszámlázniToolStripMenuItem.Name = "vIPÜgyfélnekMilyenMunkákatKellKiszámlázniToolStripMenuItem";
            this.vIPÜgyfélnekMilyenMunkákatKellKiszámlázniToolStripMenuItem.Size = new System.Drawing.Size(417, 24);
            this.vIPÜgyfélnekMilyenMunkákatKellKiszámlázniToolStripMenuItem.Text = "VIP ügyfélnek milyen munkákat kell kiszámlázni?";
            // 
            // ügyfélMilyenMunkákÁrávalTartozikToolStripMenuItem
            // 
            this.ügyfélMilyenMunkákÁrávalTartozikToolStripMenuItem.Name = "ügyfélMilyenMunkákÁrávalTartozikToolStripMenuItem";
            this.ügyfélMilyenMunkákÁrávalTartozikToolStripMenuItem.Size = new System.Drawing.Size(417, 24);
            this.ügyfélMilyenMunkákÁrávalTartozikToolStripMenuItem.Text = "Ügyfél milyen munkák árával tartozik?";
            // 
            // ügyfélnekMilyenMunkákatCsináltunkEddigToolStripMenuItem
            // 
            this.ügyfélnekMilyenMunkákatCsináltunkEddigToolStripMenuItem.Name = "ügyfélnekMilyenMunkákatCsináltunkEddigToolStripMenuItem";
            this.ügyfélnekMilyenMunkákatCsináltunkEddigToolStripMenuItem.Size = new System.Drawing.Size(417, 24);
            this.ügyfélnekMilyenMunkákatCsináltunkEddigToolStripMenuItem.Text = "Ügyfélnek milyen munkákat csináltunk eddig?";
            // 
            // ügyfélnekMilyenAktívMunkáiVannakToolStripMenuItem
            // 
            this.ügyfélnekMilyenAktívMunkáiVannakToolStripMenuItem.Name = "ügyfélnekMilyenAktívMunkáiVannakToolStripMenuItem";
            this.ügyfélnekMilyenAktívMunkáiVannakToolStripMenuItem.Size = new System.Drawing.Size(417, 24);
            this.ügyfélnekMilyenAktívMunkáiVannakToolStripMenuItem.Text = "Ügyfélnek milyen aktív munkái vannak?";
            // 
            // kollégaEgyenlegeToolStripMenuItem
            // 
            this.kollégaEgyenlegeToolStripMenuItem.Name = "kollégaEgyenlegeToolStripMenuItem";
            this.kollégaEgyenlegeToolStripMenuItem.Size = new System.Drawing.Size(417, 24);
            this.kollégaEgyenlegeToolStripMenuItem.Text = "Kolléga egyenlege?";
            // 
            // mennyiATartozásunkToolStripMenuItem
            // 
            this.mennyiATartozásunkToolStripMenuItem.Name = "mennyiATartozásunkToolStripMenuItem";
            this.mennyiATartozásunkToolStripMenuItem.Size = new System.Drawing.Size(417, 24);
            this.mennyiATartozásunkToolStripMenuItem.Text = "Mennyi a tartozásunk?";
            // 
            // mennyivelTartoznakNekünkToolStripMenuItem
            // 
            this.mennyivelTartoznakNekünkToolStripMenuItem.Name = "mennyivelTartoznakNekünkToolStripMenuItem";
            this.mennyivelTartoznakNekünkToolStripMenuItem.Size = new System.Drawing.Size(417, 24);
            this.mennyivelTartoznakNekünkToolStripMenuItem.Text = "Mennyivel tartoznak nekünk?";
            // 
            // milyenMunkákVannakFolyamatbanToolStripMenuItem
            // 
            this.milyenMunkákVannakFolyamatbanToolStripMenuItem.Name = "milyenMunkákVannakFolyamatbanToolStripMenuItem";
            this.milyenMunkákVannakFolyamatbanToolStripMenuItem.Size = new System.Drawing.Size(417, 24);
            this.milyenMunkákVannakFolyamatbanToolStripMenuItem.Text = "Milyen munkák vannak folyamatban?";
            // 
            // milyenMunkákKészültekElÉsMégNemFizettékKiToolStripMenuItem
            // 
            this.milyenMunkákKészültekElÉsMégNemFizettékKiToolStripMenuItem.Name = "milyenMunkákKészültekElÉsMégNemFizettékKiToolStripMenuItem";
            this.milyenMunkákKészültekElÉsMégNemFizettékKiToolStripMenuItem.Size = new System.Drawing.Size(417, 24);
            this.milyenMunkákKészültekElÉsMégNemFizettékKiToolStripMenuItem.Text = "Milyen munkák készültek el és még nem fizették ki?";
            // 
            // kinekCsináltunkBizonyosMunkátToolStripMenuItem
            // 
            this.kinekCsináltunkBizonyosMunkátToolStripMenuItem.Name = "kinekCsináltunkBizonyosMunkátToolStripMenuItem";
            this.kinekCsináltunkBizonyosMunkátToolStripMenuItem.Size = new System.Drawing.Size(417, 24);
            this.kinekCsináltunkBizonyosMunkátToolStripMenuItem.Text = "Kinek csináltunk bizonyos munkát";
            // 
            // ugyfelToolStripMenuItem
            // 
            this.ugyfelToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ugyfelToolStripMenuItem.Name = "ugyfelToolStripMenuItem";
            this.ugyfelToolStripMenuItem.Size = new System.Drawing.Size(64, 24);
            this.ugyfelToolStripMenuItem.Text = "Ügyfél";
            this.ugyfelToolStripMenuItem.Click += new System.EventHandler(this.ugyfelToolStripMenuItem_Click);
            // 
            // kollegaToolStripMenuItem
            // 
            this.kollegaToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kollegaToolStripMenuItem.Name = "kollegaToolStripMenuItem";
            this.kollegaToolStripMenuItem.Size = new System.Drawing.Size(72, 24);
            this.kollegaToolStripMenuItem.Text = "Kolléga";
            this.kollegaToolStripMenuItem.Click += new System.EventHandler(this.kollegaToolStripMenuItem_Click);
            // 
            // reszletekToolStripMenuItem
            // 
            this.reszletekToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.reszletekToolStripMenuItem.Name = "reszletekToolStripMenuItem";
            this.reszletekToolStripMenuItem.Size = new System.Drawing.Size(83, 24);
            this.reszletekToolStripMenuItem.Text = "Részletek";
            this.reszletekToolStripMenuItem.Click += new System.EventHandler(this.reszletekToolStripMenuItem_Click);
            // 
            // ujmunkaToolStripMenuItem
            // 
            this.ujmunkaToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ujmunkaToolStripMenuItem.Name = "ujmunkaToolStripMenuItem";
            this.ujmunkaToolStripMenuItem.Size = new System.Drawing.Size(83, 24);
            this.ujmunkaToolStripMenuItem.Text = "Új munka";
            this.ujmunkaToolStripMenuItem.Click += new System.EventHandler(this.ujmunkaToolStripMenuItem_Click);
            // 
            // frissitToolStripMenuItem
            // 
            this.frissitToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.frissitToolStripMenuItem.Name = "frissitToolStripMenuItem";
            this.frissitToolStripMenuItem.Size = new System.Drawing.Size(58, 24);
            this.frissitToolStripMenuItem.Text = "Frissít";
            this.frissitToolStripMenuItem.Click += new System.EventHandler(this.frissitToolStripMenuItem_Click);
            // 
            // kilepToolStripMenuItem
            // 
            this.kilepToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kilepToolStripMenuItem.Name = "kilepToolStripMenuItem";
            this.kilepToolStripMenuItem.Size = new System.Drawing.Size(55, 24);
            this.kilepToolStripMenuItem.Text = "Kilép";
            // 
            // button_ugyfel
            // 
            this.button_ugyfel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.button_ugyfel.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Red;
            this.button_ugyfel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_ugyfel.ForeColor = System.Drawing.SystemColors.WindowText;
            this.button_ugyfel.Location = new System.Drawing.Point(51, 32);
            this.button_ugyfel.Name = "button_ugyfel";
            this.button_ugyfel.Size = new System.Drawing.Size(104, 37);
            this.button_ugyfel.TabIndex = 0;
            this.button_ugyfel.Text = "Ügyfél";
            this.button_ugyfel.UseVisualStyleBackColor = false;
            this.button_ugyfel.Click += new System.EventHandler(this.button_ugyfel_Click);
            // 
            // button_ujMunka
            // 
            this.button_ujMunka.BackColor = System.Drawing.Color.Yellow;
            this.button_ujMunka.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Red;
            this.button_ujMunka.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_ujMunka.ForeColor = System.Drawing.SystemColors.WindowText;
            this.button_ujMunka.Location = new System.Drawing.Point(689, 32);
            this.button_ujMunka.Name = "button_ujMunka";
            this.button_ujMunka.Size = new System.Drawing.Size(104, 37);
            this.button_ujMunka.TabIndex = 0;
            this.button_ujMunka.Text = "Új munka";
            this.button_ujMunka.UseVisualStyleBackColor = false;
            this.button_ujMunka.Click += new System.EventHandler(this.button_ujMunka_Click);
            // 
            // button_frissit
            // 
            this.button_frissit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.button_frissit.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Red;
            this.button_frissit.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_frissit.ForeColor = System.Drawing.SystemColors.WindowText;
            this.button_frissit.Location = new System.Drawing.Point(894, 32);
            this.button_frissit.Name = "button_frissit";
            this.button_frissit.Size = new System.Drawing.Size(104, 37);
            this.button_frissit.TabIndex = 0;
            this.button_frissit.Text = "Frissít";
            this.button_frissit.UseVisualStyleBackColor = false;
            this.button_frissit.Click += new System.EventHandler(this.button_frissit_Click);
            // 
            // button_kilep
            // 
            this.button_kilep.BackColor = System.Drawing.Color.Red;
            this.button_kilep.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Red;
            this.button_kilep.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_kilep.ForeColor = System.Drawing.SystemColors.WindowText;
            this.button_kilep.Location = new System.Drawing.Point(1085, 32);
            this.button_kilep.Name = "button_kilep";
            this.button_kilep.Size = new System.Drawing.Size(104, 37);
            this.button_kilep.TabIndex = 0;
            this.button_kilep.Text = "Kilép";
            this.button_kilep.UseVisualStyleBackColor = false;
            this.button_kilep.Click += new System.EventHandler(this.button_kilep_Click);
            // 
            // button_reszletek
            // 
            this.button_reszletek.BackColor = System.Drawing.Color.Chocolate;
            this.button_reszletek.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Red;
            this.button_reszletek.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_reszletek.ForeColor = System.Drawing.SystemColors.WindowText;
            this.button_reszletek.Location = new System.Drawing.Point(445, 32);
            this.button_reszletek.Name = "button_reszletek";
            this.button_reszletek.Size = new System.Drawing.Size(104, 37);
            this.button_reszletek.TabIndex = 6;
            this.button_reszletek.Text = "Részletek";
            this.button_reszletek.UseVisualStyleBackColor = false;
            this.button_reszletek.Click += new System.EventHandler(this.button_reszletek_Click);
            // 
            // checkBox_Aktiv
            // 
            this.checkBox_Aktiv.AutoSize = true;
            this.checkBox_Aktiv.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox_Aktiv.Location = new System.Drawing.Point(590, 42);
            this.checkBox_Aktiv.Name = "checkBox_Aktiv";
            this.checkBox_Aktiv.Size = new System.Drawing.Size(63, 22);
            this.checkBox_Aktiv.TabIndex = 7;
            this.checkBox_Aktiv.Text = "Aktív";
            this.checkBox_Aktiv.UseVisualStyleBackColor = true;
            this.checkBox_Aktiv.CheckedChanged += new System.EventHandler(this.checkBox_Aktiv_CheckedChanged);
            // 
            // form_Fooldal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1252, 527);
            this.Controls.Add(this.checkBox_Aktiv);
            this.Controls.Add(this.button_reszletek);
            this.Controls.Add(this.DG_Fooldal);
            this.Controls.Add(this.button_kilep);
            this.Controls.Add(this.button_frissit);
            this.Controls.Add(this.button_ujMunka);
            this.Controls.Add(this.button_ugyfel);
            this.Controls.Add(this.button_kollega);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "form_Fooldal";
            this.Text = "Főoldal";
            this.Load += new System.EventHandler(this.form_Fooldal_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DG_Fooldal)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button_kollega;
        private System.Windows.Forms.DataGridView DG_Fooldal;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem lekerdezesekToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem vIPÜgyfélnekMilyenMunkákatKellKiszámlázniToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ügyfélMilyenMunkákÁrávalTartozikToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ügyfélnekMilyenMunkákatCsináltunkEddigToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ügyfélnekMilyenAktívMunkáiVannakToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem kollégaEgyenlegeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mennyiATartozásunkToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mennyivelTartoznakNekünkToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem milyenMunkákVannakFolyamatbanToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem milyenMunkákKészültekElÉsMégNemFizettékKiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem kinekCsináltunkBizonyosMunkátToolStripMenuItem;
        private System.Windows.Forms.Button button_ugyfel;
        private System.Windows.Forms.Button button_ujMunka;
        private System.Windows.Forms.Button button_frissit;
        private System.Windows.Forms.Button button_kilep;
        private System.Windows.Forms.ToolStripMenuItem ugyfelToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem kollegaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reszletekToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ujmunkaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem frissitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem kilepToolStripMenuItem;
        private System.Windows.Forms.Button button_reszletek;
        private System.Windows.Forms.CheckBox checkBox_Aktiv;
        private System.Windows.Forms.DataGridViewTextBoxColumn MunkaID;
        private System.Windows.Forms.DataGridViewTextBoxColumn MunkaFelvetel;
        private System.Windows.Forms.DataGridViewTextBoxColumn UgyfelNev;
        private System.Windows.Forms.DataGridViewTextBoxColumn Leiras;
        private System.Windows.Forms.DataGridViewTextBoxColumn ForrasNyelv;
        private System.Windows.Forms.DataGridViewTextBoxColumn CelNyelv;
        private System.Windows.Forms.DataGridViewTextBoxColumn KollegaNev;
        private System.Windows.Forms.DataGridViewTextBoxColumn VeglegesAr;
        private System.Windows.Forms.DataGridViewTextBoxColumn Hatarido;
        private System.Windows.Forms.DataGridViewTextBoxColumn EddigFizetve;
        private System.Windows.Forms.DataGridViewTextBoxColumn ElkeszultDatum;
        private System.Windows.Forms.DataGridViewTextBoxColumn Statusz;
    }
}

