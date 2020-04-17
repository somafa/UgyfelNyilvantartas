namespace UgyfelNyilvantartas
{
    partial class form_Ugyfel
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.button_fooldalra = new System.Windows.Forms.Button();
            this.button_mentes = new System.Windows.Forms.Button();
            this.button_modositas = new System.Windows.Forms.Button();
            this.button_ujUgyfel = new System.Windows.Forms.Button();
            this.button_hasznal = new System.Windows.Forms.Button();
            this.checkBox_ugyfel = new System.Windows.Forms.CheckBox();
            this.checkBox_kollega = new System.Windows.Forms.CheckBox();
            this.checkBox_VIP = new System.Windows.Forms.CheckBox();
            this.textBox_keresomezo = new System.Windows.Forms.TextBox();
            this.button_kereses = new System.Windows.Forms.Button();
            this.DG_Ugyfel_ugyfel = new System.Windows.Forms.DataGridView();
            this.DG_Ugyfel_ellenorzes = new System.Windows.Forms.DataGridView();
            this.megrendelesFelvetele = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ugyfelNeve = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.megrendelesLeiras = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kiindulasiNyelv = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.celNyelv = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.veglegesAr = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hatarido = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.eddigFizetveOsszeg = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.eddigFizetveDatum = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.elkeszultDatum = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.statusz = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateTimePicker_Kezdo = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker_Vegso = new System.Windows.Forms.DateTimePicker();
            this.button_Ellenorzes = new System.Windows.Forms.Button();
            this.checkedListBox_statusz = new System.Windows.Forms.CheckedListBox();
            this.UgyfelID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nev = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Telefonszam = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EmailCim = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MasElerhetoseg = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Adoszam = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cegjegyzekszam = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Szekhely = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Bank = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IBAN = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Kategoria = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Megjegyzes = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.DG_Ugyfel_ugyfel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DG_Ugyfel_ellenorzes)).BeginInit();
            this.SuspendLayout();
            // 
            // button_fooldalra
            // 
            this.button_fooldalra.BackColor = System.Drawing.Color.Red;
            this.button_fooldalra.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Red;
            this.button_fooldalra.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_fooldalra.ForeColor = System.Drawing.SystemColors.WindowText;
            this.button_fooldalra.Location = new System.Drawing.Point(1086, 12);
            this.button_fooldalra.Name = "button_fooldalra";
            this.button_fooldalra.Size = new System.Drawing.Size(104, 37);
            this.button_fooldalra.TabIndex = 1;
            this.button_fooldalra.Text = "Főoldalra";
            this.button_fooldalra.UseVisualStyleBackColor = false;
            this.button_fooldalra.Click += new System.EventHandler(this.button_fooldalra_Click);
            // 
            // button_mentes
            // 
            this.button_mentes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.button_mentes.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Red;
            this.button_mentes.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_mentes.ForeColor = System.Drawing.SystemColors.WindowText;
            this.button_mentes.Location = new System.Drawing.Point(895, 12);
            this.button_mentes.Name = "button_mentes";
            this.button_mentes.Size = new System.Drawing.Size(104, 37);
            this.button_mentes.TabIndex = 2;
            this.button_mentes.Text = "Mentés";
            this.button_mentes.UseVisualStyleBackColor = false;
            this.button_mentes.Click += new System.EventHandler(this.button_mentes_Click);
            // 
            // button_modositas
            // 
            this.button_modositas.BackColor = System.Drawing.Color.Yellow;
            this.button_modositas.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Red;
            this.button_modositas.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_modositas.ForeColor = System.Drawing.SystemColors.WindowText;
            this.button_modositas.Location = new System.Drawing.Point(552, 12);
            this.button_modositas.Name = "button_modositas";
            this.button_modositas.Size = new System.Drawing.Size(104, 37);
            this.button_modositas.TabIndex = 3;
            this.button_modositas.Text = "Módosítás";
            this.button_modositas.UseVisualStyleBackColor = false;
            this.button_modositas.Click += new System.EventHandler(this.button_modositas_Click);
            // 
            // button_ujUgyfel
            // 
            this.button_ujUgyfel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.button_ujUgyfel.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Red;
            this.button_ujUgyfel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_ujUgyfel.ForeColor = System.Drawing.SystemColors.WindowText;
            this.button_ujUgyfel.Location = new System.Drawing.Point(52, 12);
            this.button_ujUgyfel.Name = "button_ujUgyfel";
            this.button_ujUgyfel.Size = new System.Drawing.Size(104, 37);
            this.button_ujUgyfel.TabIndex = 4;
            this.button_ujUgyfel.Text = "Új ügyfél";
            this.button_ujUgyfel.UseVisualStyleBackColor = false;
            this.button_ujUgyfel.Click += new System.EventHandler(this.button_ujUgyfel_Click);
            // 
            // button_hasznal
            // 
            this.button_hasznal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.button_hasznal.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Red;
            this.button_hasznal.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_hasznal.ForeColor = System.Drawing.SystemColors.WindowText;
            this.button_hasznal.Location = new System.Drawing.Point(241, 12);
            this.button_hasznal.Name = "button_hasznal";
            this.button_hasznal.Size = new System.Drawing.Size(104, 37);
            this.button_hasznal.TabIndex = 5;
            this.button_hasznal.Text = "Használom";
            this.button_hasznal.UseVisualStyleBackColor = false;
            this.button_hasznal.Click += new System.EventHandler(this.button_hasznal_Click);
            // 
            // checkBox_ugyfel
            // 
            this.checkBox_ugyfel.AutoSize = true;
            this.checkBox_ugyfel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox_ugyfel.Location = new System.Drawing.Point(387, 64);
            this.checkBox_ugyfel.Name = "checkBox_ugyfel";
            this.checkBox_ugyfel.Size = new System.Drawing.Size(71, 22);
            this.checkBox_ugyfel.TabIndex = 7;
            this.checkBox_ugyfel.Text = "ügyfél";
            this.checkBox_ugyfel.UseVisualStyleBackColor = true;
            // 
            // checkBox_kollega
            // 
            this.checkBox_kollega.AutoSize = true;
            this.checkBox_kollega.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox_kollega.Location = new System.Drawing.Point(565, 64);
            this.checkBox_kollega.Name = "checkBox_kollega";
            this.checkBox_kollega.Size = new System.Drawing.Size(81, 22);
            this.checkBox_kollega.TabIndex = 7;
            this.checkBox_kollega.Text = "kolléga";
            this.checkBox_kollega.UseVisualStyleBackColor = true;
            // 
            // checkBox_VIP
            // 
            this.checkBox_VIP.AutoSize = true;
            this.checkBox_VIP.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox_VIP.Location = new System.Drawing.Point(736, 64);
            this.checkBox_VIP.Name = "checkBox_VIP";
            this.checkBox_VIP.Size = new System.Drawing.Size(101, 22);
            this.checkBox_VIP.TabIndex = 7;
            this.checkBox_VIP.Text = "VIP ügyfél";
            this.checkBox_VIP.UseVisualStyleBackColor = true;
            // 
            // textBox_keresomezo
            // 
            this.textBox_keresomezo.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_keresomezo.Location = new System.Drawing.Point(387, 96);
            this.textBox_keresomezo.Name = "textBox_keresomezo";
            this.textBox_keresomezo.Size = new System.Drawing.Size(175, 24);
            this.textBox_keresomezo.TabIndex = 8;
            // 
            // button_kereses
            // 
            this.button_kereses.BackColor = System.Drawing.Color.Chocolate;
            this.button_kereses.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Red;
            this.button_kereses.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_kereses.ForeColor = System.Drawing.SystemColors.WindowText;
            this.button_kereses.Location = new System.Drawing.Point(642, 90);
            this.button_kereses.Name = "button_kereses";
            this.button_kereses.Size = new System.Drawing.Size(104, 37);
            this.button_kereses.TabIndex = 5;
            this.button_kereses.Text = "Keresés";
            this.button_kereses.UseVisualStyleBackColor = false;
            this.button_kereses.Click += new System.EventHandler(this.button_kereses_Click);
            // 
            // DG_Ugyfel_ugyfel
            // 
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DG_Ugyfel_ugyfel.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.DG_Ugyfel_ugyfel.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DG_Ugyfel_ugyfel.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.UgyfelID,
            this.Nev,
            this.Telefonszam,
            this.EmailCim,
            this.MasElerhetoseg,
            this.Adoszam,
            this.Cegjegyzekszam,
            this.Szekhely,
            this.Bank,
            this.IBAN,
            this.Kategoria,
            this.Megjegyzes});
            this.DG_Ugyfel_ugyfel.Location = new System.Drawing.Point(12, 133);
            this.DG_Ugyfel_ugyfel.Name = "DG_Ugyfel_ugyfel";
            this.DG_Ugyfel_ugyfel.ReadOnly = true;
            this.DG_Ugyfel_ugyfel.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DG_Ugyfel_ugyfel.Size = new System.Drawing.Size(1230, 150);
            this.DG_Ugyfel_ugyfel.TabIndex = 9;
            this.DG_Ugyfel_ugyfel.SelectionChanged += new System.EventHandler(this.DG_Ugyfel_ugyfel_SelectionChanged);
            // 
            // DG_Ugyfel_ellenorzes
            // 
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DG_Ugyfel_ellenorzes.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.DG_Ugyfel_ellenorzes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DG_Ugyfel_ellenorzes.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.megrendelesFelvetele,
            this.ugyfelNeve,
            this.megrendelesLeiras,
            this.kiindulasiNyelv,
            this.celNyelv,
            this.veglegesAr,
            this.hatarido,
            this.eddigFizetveOsszeg,
            this.eddigFizetveDatum,
            this.elkeszultDatum,
            this.statusz});
            this.DG_Ugyfel_ellenorzes.Location = new System.Drawing.Point(12, 347);
            this.DG_Ugyfel_ellenorzes.Name = "DG_Ugyfel_ellenorzes";
            this.DG_Ugyfel_ellenorzes.ReadOnly = true;
            this.DG_Ugyfel_ellenorzes.Size = new System.Drawing.Size(1230, 177);
            this.DG_Ugyfel_ellenorzes.TabIndex = 10;
            // 
            // megrendelesFelvetele
            // 
            this.megrendelesFelvetele.HeaderText = "megrendelés felvétele";
            this.megrendelesFelvetele.Name = "megrendelesFelvetele";
            this.megrendelesFelvetele.ReadOnly = true;
            // 
            // ugyfelNeve
            // 
            this.ugyfelNeve.HeaderText = "ügyfél neve";
            this.ugyfelNeve.Name = "ugyfelNeve";
            this.ugyfelNeve.ReadOnly = true;
            // 
            // megrendelesLeiras
            // 
            this.megrendelesLeiras.HeaderText = "megrendelés rövid leírása";
            this.megrendelesLeiras.Name = "megrendelesLeiras";
            this.megrendelesLeiras.ReadOnly = true;
            // 
            // kiindulasiNyelv
            // 
            this.kiindulasiNyelv.HeaderText = "kiindulási nyelv";
            this.kiindulasiNyelv.Name = "kiindulasiNyelv";
            this.kiindulasiNyelv.ReadOnly = true;
            // 
            // celNyelv
            // 
            this.celNyelv.HeaderText = "célnyelv";
            this.celNyelv.Name = "celNyelv";
            this.celNyelv.ReadOnly = true;
            // 
            // veglegesAr
            // 
            this.veglegesAr.HeaderText = "végleges ár";
            this.veglegesAr.Name = "veglegesAr";
            this.veglegesAr.ReadOnly = true;
            // 
            // hatarido
            // 
            this.hatarido.HeaderText = "határidő";
            this.hatarido.Name = "hatarido";
            this.hatarido.ReadOnly = true;
            // 
            // eddigFizetveOsszeg
            // 
            this.eddigFizetveOsszeg.HeaderText = "eddig fizetve";
            this.eddigFizetveOsszeg.Name = "eddigFizetveOsszeg";
            this.eddigFizetveOsszeg.ReadOnly = true;
            // 
            // eddigFizetveDatum
            // 
            this.eddigFizetveDatum.HeaderText = "mikor";
            this.eddigFizetveDatum.Name = "eddigFizetveDatum";
            this.eddigFizetveDatum.ReadOnly = true;
            // 
            // elkeszultDatum
            // 
            this.elkeszultDatum.HeaderText = "elkészült";
            this.elkeszultDatum.Name = "elkeszultDatum";
            this.elkeszultDatum.ReadOnly = true;
            // 
            // statusz
            // 
            this.statusz.HeaderText = "státusz";
            this.statusz.Name = "statusz";
            this.statusz.ReadOnly = true;
            // 
            // dateTimePicker_Kezdo
            // 
            this.dateTimePicker_Kezdo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker_Kezdo.Location = new System.Drawing.Point(212, 310);
            this.dateTimePicker_Kezdo.Name = "dateTimePicker_Kezdo";
            this.dateTimePicker_Kezdo.Size = new System.Drawing.Size(154, 22);
            this.dateTimePicker_Kezdo.TabIndex = 11;
            this.dateTimePicker_Kezdo.Value = new System.DateTime(2010, 1, 1, 0, 0, 0, 0);
            // 
            // dateTimePicker_Vegso
            // 
            this.dateTimePicker_Vegso.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker_Vegso.Location = new System.Drawing.Point(552, 310);
            this.dateTimePicker_Vegso.Name = "dateTimePicker_Vegso";
            this.dateTimePicker_Vegso.Size = new System.Drawing.Size(154, 22);
            this.dateTimePicker_Vegso.TabIndex = 11;
            this.dateTimePicker_Vegso.Value = new System.DateTime(2020, 3, 11, 0, 0, 0, 0);
            // 
            // button_Ellenorzes
            // 
            this.button_Ellenorzes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.button_Ellenorzes.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Red;
            this.button_Ellenorzes.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_Ellenorzes.ForeColor = System.Drawing.SystemColors.WindowText;
            this.button_Ellenorzes.Location = new System.Drawing.Point(407, 304);
            this.button_Ellenorzes.Name = "button_Ellenorzes";
            this.button_Ellenorzes.Size = new System.Drawing.Size(104, 37);
            this.button_Ellenorzes.TabIndex = 5;
            this.button_Ellenorzes.Text = "Ellenőrzés";
            this.button_Ellenorzes.UseVisualStyleBackColor = false;
            // 
            // checkedListBox_statusz
            // 
            this.checkedListBox_statusz.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkedListBox_statusz.FormattingEnabled = true;
            this.checkedListBox_statusz.Items.AddRange(new object[] {
            "folyamatban",
            "elkészült",
            "letudva"});
            this.checkedListBox_statusz.Location = new System.Drawing.Point(879, 289);
            this.checkedListBox_statusz.Name = "checkedListBox_statusz";
            this.checkedListBox_statusz.Size = new System.Drawing.Size(120, 52);
            this.checkedListBox_statusz.TabIndex = 12;
            // 
            // UgyfelID
            // 
            this.UgyfelID.HeaderText = "UgyfelID";
            this.UgyfelID.Name = "UgyfelID";
            this.UgyfelID.ReadOnly = true;
            this.UgyfelID.Visible = false;
            // 
            // Nev
            // 
            this.Nev.HeaderText = "név";
            this.Nev.Name = "Nev";
            this.Nev.ReadOnly = true;
            // 
            // Telefonszam
            // 
            this.Telefonszam.HeaderText = "telefonszám";
            this.Telefonszam.Name = "Telefonszam";
            this.Telefonszam.ReadOnly = true;
            // 
            // EmailCim
            // 
            this.EmailCim.HeaderText = "e-mail cím";
            this.EmailCim.Name = "EmailCim";
            this.EmailCim.ReadOnly = true;
            // 
            // MasElerhetoseg
            // 
            this.MasElerhetoseg.HeaderText = "más elérhetőség";
            this.MasElerhetoseg.Name = "MasElerhetoseg";
            this.MasElerhetoseg.ReadOnly = true;
            // 
            // Adoszam
            // 
            this.Adoszam.HeaderText = "adószám";
            this.Adoszam.Name = "Adoszam";
            this.Adoszam.ReadOnly = true;
            // 
            // Cegjegyzekszam
            // 
            this.Cegjegyzekszam.HeaderText = "cégjegyzékszám";
            this.Cegjegyzekszam.Name = "Cegjegyzekszam";
            this.Cegjegyzekszam.ReadOnly = true;
            // 
            // Szekhely
            // 
            this.Szekhely.HeaderText = "székhely / cím";
            this.Szekhely.Name = "Szekhely";
            this.Szekhely.ReadOnly = true;
            // 
            // Bank
            // 
            this.Bank.HeaderText = "bank";
            this.Bank.Name = "Bank";
            this.Bank.ReadOnly = true;
            // 
            // IBAN
            // 
            this.IBAN.HeaderText = "IBAN";
            this.IBAN.Name = "IBAN";
            this.IBAN.ReadOnly = true;
            // 
            // Kategoria
            // 
            this.Kategoria.HeaderText = "kategória";
            this.Kategoria.Name = "Kategoria";
            this.Kategoria.ReadOnly = true;
            // 
            // Megjegyzes
            // 
            this.Megjegyzes.HeaderText = "megjegyzés";
            this.Megjegyzes.Name = "Megjegyzes";
            this.Megjegyzes.ReadOnly = true;
            // 
            // form_Ugyfel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1254, 536);
            this.Controls.Add(this.checkedListBox_statusz);
            this.Controls.Add(this.dateTimePicker_Vegso);
            this.Controls.Add(this.dateTimePicker_Kezdo);
            this.Controls.Add(this.DG_Ugyfel_ellenorzes);
            this.Controls.Add(this.DG_Ugyfel_ugyfel);
            this.Controls.Add(this.textBox_keresomezo);
            this.Controls.Add(this.checkBox_VIP);
            this.Controls.Add(this.checkBox_kollega);
            this.Controls.Add(this.checkBox_ugyfel);
            this.Controls.Add(this.button_fooldalra);
            this.Controls.Add(this.button_mentes);
            this.Controls.Add(this.button_modositas);
            this.Controls.Add(this.button_ujUgyfel);
            this.Controls.Add(this.button_Ellenorzes);
            this.Controls.Add(this.button_kereses);
            this.Controls.Add(this.button_hasznal);
            this.Name = "form_Ugyfel";
            this.Text = "Ügyfél";
            this.Load += new System.EventHandler(this.form_Ugyfel_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DG_Ugyfel_ugyfel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DG_Ugyfel_ellenorzes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button_fooldalra;
        private System.Windows.Forms.Button button_mentes;
        private System.Windows.Forms.Button button_modositas;
        private System.Windows.Forms.Button button_ujUgyfel;
        private System.Windows.Forms.Button button_hasznal;
        private System.Windows.Forms.CheckBox checkBox_ugyfel;
        private System.Windows.Forms.CheckBox checkBox_kollega;
        private System.Windows.Forms.CheckBox checkBox_VIP;
        private System.Windows.Forms.TextBox textBox_keresomezo;
        private System.Windows.Forms.Button button_kereses;
        private System.Windows.Forms.DataGridView DG_Ugyfel_ugyfel;
        private System.Windows.Forms.DataGridView DG_Ugyfel_ellenorzes;
        private System.Windows.Forms.DateTimePicker dateTimePicker_Kezdo;
        private System.Windows.Forms.DateTimePicker dateTimePicker_Vegso;
        private System.Windows.Forms.Button button_Ellenorzes;
        private System.Windows.Forms.CheckedListBox checkedListBox_statusz;
        private System.Windows.Forms.DataGridViewTextBoxColumn megrendelesFelvetele;
        private System.Windows.Forms.DataGridViewTextBoxColumn ugyfelNeve;
        private System.Windows.Forms.DataGridViewTextBoxColumn megrendelesLeiras;
        private System.Windows.Forms.DataGridViewTextBoxColumn kiindulasiNyelv;
        private System.Windows.Forms.DataGridViewTextBoxColumn celNyelv;
        private System.Windows.Forms.DataGridViewTextBoxColumn veglegesAr;
        private System.Windows.Forms.DataGridViewTextBoxColumn hatarido;
        private System.Windows.Forms.DataGridViewTextBoxColumn eddigFizetveOsszeg;
        private System.Windows.Forms.DataGridViewTextBoxColumn eddigFizetveDatum;
        private System.Windows.Forms.DataGridViewTextBoxColumn elkeszultDatum;
        private System.Windows.Forms.DataGridViewTextBoxColumn statusz;
        private System.Windows.Forms.DataGridViewTextBoxColumn UgyfelID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nev;
        private System.Windows.Forms.DataGridViewTextBoxColumn Telefonszam;
        private System.Windows.Forms.DataGridViewTextBoxColumn EmailCim;
        private System.Windows.Forms.DataGridViewTextBoxColumn MasElerhetoseg;
        private System.Windows.Forms.DataGridViewTextBoxColumn Adoszam;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cegjegyzekszam;
        private System.Windows.Forms.DataGridViewTextBoxColumn Szekhely;
        private System.Windows.Forms.DataGridViewTextBoxColumn Bank;
        private System.Windows.Forms.DataGridViewTextBoxColumn IBAN;
        private System.Windows.Forms.DataGridViewTextBoxColumn Kategoria;
        private System.Windows.Forms.DataGridViewTextBoxColumn Megjegyzes;
    }
}