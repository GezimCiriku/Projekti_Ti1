namespace Bibloteka
{
    partial class Issue_ReturnForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Issue_ReturnForm));
            this.dgvBooks = new System.Windows.Forms.DataGridView();
            this.txtSearchBook = new System.Windows.Forms.TextBox();
            this.dgvReaders = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.txtSearchReaders = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblSearch = new System.Windows.Forms.Label();
            this.btnBack = new System.Windows.Forms.Button();
            this.btnHuazo = new Bunifu.Framework.UI.BunifuThinButton2();
            this.btnKthe = new Bunifu.Framework.UI.BunifuThinButton2();
            this.lblLibri = new System.Windows.Forms.Label();
            this.lblLexuesi = new System.Windows.Forms.Label();
            this.lblLibriID = new System.Windows.Forms.Label();
            this.lblPmID = new System.Windows.Forms.Label();
            this.lblKopjaID = new System.Windows.Forms.Label();
            this.lblDataHuazimit = new System.Windows.Forms.Label();
            this.lblAfatiKthimit = new System.Windows.Forms.Label();
            this.lblDataKthimit = new System.Windows.Forms.Label();
            this.lblVerejtje = new System.Windows.Forms.Label();
            this.lblLibriID1 = new System.Windows.Forms.Label();
            this.lblPmID1 = new System.Windows.Forms.Label();
            this.lblLexuesi1 = new System.Windows.Forms.Label();
            this.lblLibri1 = new System.Windows.Forms.Label();
            this.DataHuazimit1 = new System.Windows.Forms.DateTimePicker();
            this.AfatiKthimit1 = new System.Windows.Forms.DateTimePicker();
            this.DataKthimit1 = new System.Windows.Forms.DateTimePicker();
            this.txtVerejtej = new System.Windows.Forms.TextBox();
            this.txtKopjaID = new System.Windows.Forms.TextBox();
            this.lblNumriKopjeve = new System.Windows.Forms.Label();
            this.lblNumriKopjeve1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBooks)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvReaders)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvBooks
            // 
            this.dgvBooks.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBooks.Location = new System.Drawing.Point(536, 460);
            this.dgvBooks.Name = "dgvBooks";
            this.dgvBooks.RowTemplate.Height = 24;
            this.dgvBooks.Size = new System.Drawing.Size(998, 239);
            this.dgvBooks.TabIndex = 79;
            this.dgvBooks.RowHeaderMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvBooks_RowHeaderMouseDoubleClick);
            // 
            // txtSearchBook
            // 
            this.txtSearchBook.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearchBook.Location = new System.Drawing.Point(624, 412);
            this.txtSearchBook.Name = "txtSearchBook";
            this.txtSearchBook.Size = new System.Drawing.Size(547, 28);
            this.txtSearchBook.TabIndex = 73;
            this.txtSearchBook.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtSearchBook_KeyUp);
            // 
            // dgvReaders
            // 
            this.dgvReaders.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvReaders.Location = new System.Drawing.Point(536, 109);
            this.dgvReaders.Name = "dgvReaders";
            this.dgvReaders.RowTemplate.Height = 24;
            this.dgvReaders.Size = new System.Drawing.Size(998, 245);
            this.dgvReaders.TabIndex = 80;
            this.dgvReaders.RowHeaderMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvReaders_RowHeaderMouseDoubleClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(531, 413);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 25);
            this.label1.TabIndex = 75;
            this.label1.Text = "Kërko:";
            // 
            // txtSearchReaders
            // 
            this.txtSearchReaders.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearchReaders.Location = new System.Drawing.Point(624, 60);
            this.txtSearchReaders.Name = "txtSearchReaders";
            this.txtSearchReaders.Size = new System.Drawing.Size(547, 28);
            this.txtSearchReaders.TabIndex = 74;
            this.txtSearchReaders.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtSearchReaders_KeyUp);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(532, 702);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(280, 20);
            this.label3.TabIndex = 76;
            this.label3.Text = "Zgjedhni nje liber duke klikuar 2 here";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(532, 357);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(296, 20);
            this.label2.TabIndex = 77;
            this.label2.Text = "Zgjedhni nje lexues duke klikuar 2 here";
            // 
            // lblSearch
            // 
            this.lblSearch.AutoSize = true;
            this.lblSearch.BackColor = System.Drawing.Color.Transparent;
            this.lblSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSearch.Location = new System.Drawing.Point(531, 61);
            this.lblSearch.Name = "lblSearch";
            this.lblSearch.Size = new System.Drawing.Size(70, 25);
            this.lblSearch.TabIndex = 78;
            this.lblSearch.Text = "Kërko:";
            // 
            // btnBack
            // 
            this.btnBack.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnBack.BackgroundImage")));
            this.btnBack.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnBack.Location = new System.Drawing.Point(1479, 12);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(55, 52);
            this.btnBack.TabIndex = 81;
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // btnHuazo
            // 
            this.btnHuazo.ActiveBorderThickness = 1;
            this.btnHuazo.ActiveCornerRadius = 20;
            this.btnHuazo.ActiveFillColor = System.Drawing.Color.Lime;
            this.btnHuazo.ActiveForecolor = System.Drawing.Color.DarkBlue;
            this.btnHuazo.ActiveLineColor = System.Drawing.Color.DarkBlue;
            this.btnHuazo.BackColor = System.Drawing.SystemColors.Control;
            this.btnHuazo.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnHuazo.BackgroundImage")));
            this.btnHuazo.ButtonText = "Huazo";
            this.btnHuazo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnHuazo.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHuazo.ForeColor = System.Drawing.Color.DarkMagenta;
            this.btnHuazo.IdleBorderThickness = 1;
            this.btnHuazo.IdleCornerRadius = 20;
            this.btnHuazo.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnHuazo.IdleForecolor = System.Drawing.Color.Black;
            this.btnHuazo.IdleLineColor = System.Drawing.Color.RoyalBlue;
            this.btnHuazo.Location = new System.Drawing.Point(61, 646);
            this.btnHuazo.Margin = new System.Windows.Forms.Padding(5);
            this.btnHuazo.Name = "btnHuazo";
            this.btnHuazo.Size = new System.Drawing.Size(176, 53);
            this.btnHuazo.TabIndex = 82;
            this.btnHuazo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnHuazo.Click += new System.EventHandler(this.btnHuazo_Click);
            // 
            // btnKthe
            // 
            this.btnKthe.ActiveBorderThickness = 1;
            this.btnKthe.ActiveCornerRadius = 20;
            this.btnKthe.ActiveFillColor = System.Drawing.Color.Lime;
            this.btnKthe.ActiveForecolor = System.Drawing.Color.DarkBlue;
            this.btnKthe.ActiveLineColor = System.Drawing.Color.DarkBlue;
            this.btnKthe.BackColor = System.Drawing.SystemColors.Control;
            this.btnKthe.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnKthe.BackgroundImage")));
            this.btnKthe.ButtonText = "Kthe";
            this.btnKthe.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnKthe.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnKthe.ForeColor = System.Drawing.Color.DarkMagenta;
            this.btnKthe.IdleBorderThickness = 1;
            this.btnKthe.IdleCornerRadius = 20;
            this.btnKthe.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnKthe.IdleForecolor = System.Drawing.Color.Black;
            this.btnKthe.IdleLineColor = System.Drawing.Color.RoyalBlue;
            this.btnKthe.Location = new System.Drawing.Point(296, 646);
            this.btnKthe.Margin = new System.Windows.Forms.Padding(5);
            this.btnKthe.Name = "btnKthe";
            this.btnKthe.Size = new System.Drawing.Size(176, 53);
            this.btnKthe.TabIndex = 82;
            this.btnKthe.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnKthe.Click += new System.EventHandler(this.btnKthe_Click);
            // 
            // lblLibri
            // 
            this.lblLibri.AutoSize = true;
            this.lblLibri.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLibri.Location = new System.Drawing.Point(68, 330);
            this.lblLibri.Name = "lblLibri";
            this.lblLibri.Size = new System.Drawing.Size(50, 24);
            this.lblLibri.TabIndex = 84;
            this.lblLibri.Text = "Libri:";
            // 
            // lblLexuesi
            // 
            this.lblLexuesi.AutoSize = true;
            this.lblLexuesi.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLexuesi.Location = new System.Drawing.Point(68, 272);
            this.lblLexuesi.Name = "lblLexuesi";
            this.lblLexuesi.Size = new System.Drawing.Size(81, 24);
            this.lblLexuesi.TabIndex = 91;
            this.lblLexuesi.Text = "Lexuesi:";
            // 
            // lblLibriID
            // 
            this.lblLibriID.AutoSize = true;
            this.lblLibriID.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLibriID.Location = new System.Drawing.Point(68, 95);
            this.lblLibriID.Name = "lblLibriID";
            this.lblLibriID.Size = new System.Drawing.Size(67, 24);
            this.lblLibriID.TabIndex = 89;
            this.lblLibriID.Text = "LibriID:";
            // 
            // lblPmID
            // 
            this.lblPmID.AutoSize = true;
            this.lblPmID.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPmID.Location = new System.Drawing.Point(68, 213);
            this.lblPmID.Name = "lblPmID";
            this.lblPmID.Size = new System.Drawing.Size(60, 24);
            this.lblPmID.TabIndex = 89;
            this.lblPmID.Text = "PmID:";
            // 
            // lblKopjaID
            // 
            this.lblKopjaID.AutoSize = true;
            this.lblKopjaID.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblKopjaID.Location = new System.Drawing.Point(68, 152);
            this.lblKopjaID.Name = "lblKopjaID";
            this.lblKopjaID.Size = new System.Drawing.Size(112, 24);
            this.lblKopjaID.TabIndex = 89;
            this.lblKopjaID.Text = "Identifikuesi:";
            // 
            // lblDataHuazimit
            // 
            this.lblDataHuazimit.AutoSize = true;
            this.lblDataHuazimit.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDataHuazimit.Location = new System.Drawing.Point(68, 393);
            this.lblDataHuazimit.Name = "lblDataHuazimit";
            this.lblDataHuazimit.Size = new System.Drawing.Size(142, 24);
            this.lblDataHuazimit.TabIndex = 89;
            this.lblDataHuazimit.Text = "Data e huazimit:";
            // 
            // lblAfatiKthimit
            // 
            this.lblAfatiKthimit.AutoSize = true;
            this.lblAfatiKthimit.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAfatiKthimit.Location = new System.Drawing.Point(68, 452);
            this.lblAfatiKthimit.Name = "lblAfatiKthimit";
            this.lblAfatiKthimit.Size = new System.Drawing.Size(116, 24);
            this.lblAfatiKthimit.TabIndex = 91;
            this.lblAfatiKthimit.Text = "Afati i kthimit:";
            // 
            // lblDataKthimit
            // 
            this.lblDataKthimit.AutoSize = true;
            this.lblDataKthimit.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDataKthimit.Location = new System.Drawing.Point(68, 510);
            this.lblDataKthimit.Name = "lblDataKthimit";
            this.lblDataKthimit.Size = new System.Drawing.Size(125, 24);
            this.lblDataKthimit.TabIndex = 84;
            this.lblDataKthimit.Text = "Data e kthimit:";
            // 
            // lblVerejtje
            // 
            this.lblVerejtje.AutoSize = true;
            this.lblVerejtje.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVerejtje.Location = new System.Drawing.Point(68, 562);
            this.lblVerejtje.Name = "lblVerejtje";
            this.lblVerejtje.Size = new System.Drawing.Size(79, 24);
            this.lblVerejtje.TabIndex = 84;
            this.lblVerejtje.Text = "Verejtje:";
            // 
            // lblLibriID1
            // 
            this.lblLibriID1.AutoSize = true;
            this.lblLibriID1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLibriID1.ForeColor = System.Drawing.Color.DarkBlue;
            this.lblLibriID1.Location = new System.Drawing.Point(268, 95);
            this.lblLibriID1.Name = "lblLibriID1";
            this.lblLibriID1.Size = new System.Drawing.Size(67, 24);
            this.lblLibriID1.TabIndex = 89;
            this.lblLibriID1.Text = "LibriID:";
            // 
            // lblPmID1
            // 
            this.lblPmID1.AutoSize = true;
            this.lblPmID1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPmID1.ForeColor = System.Drawing.Color.DarkBlue;
            this.lblPmID1.Location = new System.Drawing.Point(268, 213);
            this.lblPmID1.Name = "lblPmID1";
            this.lblPmID1.Size = new System.Drawing.Size(60, 24);
            this.lblPmID1.TabIndex = 89;
            this.lblPmID1.Text = "PmID:";
            // 
            // lblLexuesi1
            // 
            this.lblLexuesi1.AutoSize = true;
            this.lblLexuesi1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLexuesi1.ForeColor = System.Drawing.Color.DarkBlue;
            this.lblLexuesi1.Location = new System.Drawing.Point(268, 272);
            this.lblLexuesi1.Name = "lblLexuesi1";
            this.lblLexuesi1.Size = new System.Drawing.Size(81, 24);
            this.lblLexuesi1.TabIndex = 91;
            this.lblLexuesi1.Text = "Lexuesi:";
            // 
            // lblLibri1
            // 
            this.lblLibri1.AutoSize = true;
            this.lblLibri1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLibri1.ForeColor = System.Drawing.Color.DarkBlue;
            this.lblLibri1.Location = new System.Drawing.Point(268, 330);
            this.lblLibri1.Name = "lblLibri1";
            this.lblLibri1.Size = new System.Drawing.Size(50, 24);
            this.lblLibri1.TabIndex = 84;
            this.lblLibri1.Text = "Libri:";
            // 
            // DataHuazimit1
            // 
            this.DataHuazimit1.Location = new System.Drawing.Point(272, 393);
            this.DataHuazimit1.Name = "DataHuazimit1";
            this.DataHuazimit1.Size = new System.Drawing.Size(200, 22);
            this.DataHuazimit1.TabIndex = 92;
            // 
            // AfatiKthimit1
            // 
            this.AfatiKthimit1.Location = new System.Drawing.Point(272, 452);
            this.AfatiKthimit1.Name = "AfatiKthimit1";
            this.AfatiKthimit1.Size = new System.Drawing.Size(200, 22);
            this.AfatiKthimit1.TabIndex = 92;
            // 
            // DataKthimit1
            // 
            this.DataKthimit1.Location = new System.Drawing.Point(272, 510);
            this.DataKthimit1.Name = "DataKthimit1";
            this.DataKthimit1.Size = new System.Drawing.Size(200, 22);
            this.DataKthimit1.TabIndex = 92;
            // 
            // txtVerejtej
            // 
            this.txtVerejtej.Location = new System.Drawing.Point(272, 563);
            this.txtVerejtej.Multiline = true;
            this.txtVerejtej.Name = "txtVerejtej";
            this.txtVerejtej.Size = new System.Drawing.Size(200, 58);
            this.txtVerejtej.TabIndex = 93;
            // 
            // txtKopjaID
            // 
            this.txtKopjaID.Location = new System.Drawing.Point(272, 153);
            this.txtKopjaID.Name = "txtKopjaID";
            this.txtKopjaID.Size = new System.Drawing.Size(200, 22);
            this.txtKopjaID.TabIndex = 94;
            // 
            // lblNumriKopjeve
            // 
            this.lblNumriKopjeve.AutoSize = true;
            this.lblNumriKopjeve.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumriKopjeve.Location = new System.Drawing.Point(68, 40);
            this.lblNumriKopjeve.Name = "lblNumriKopjeve";
            this.lblNumriKopjeve.Size = new System.Drawing.Size(104, 24);
            this.lblNumriKopjeve.TabIndex = 89;
            this.lblNumriKopjeve.Text = "NrKopjeve:";
            // 
            // lblNumriKopjeve1
            // 
            this.lblNumriKopjeve1.AutoSize = true;
            this.lblNumriKopjeve1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumriKopjeve1.ForeColor = System.Drawing.Color.DarkBlue;
            this.lblNumriKopjeve1.Location = new System.Drawing.Point(268, 40);
            this.lblNumriKopjeve1.Name = "lblNumriKopjeve1";
            this.lblNumriKopjeve1.Size = new System.Drawing.Size(104, 24);
            this.lblNumriKopjeve1.TabIndex = 89;
            this.lblNumriKopjeve1.Text = "NrKopjeve:";
            // 
            // Issue_ReturnForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1558, 736);
            this.Controls.Add(this.txtKopjaID);
            this.Controls.Add(this.txtVerejtej);
            this.Controls.Add(this.DataKthimit1);
            this.Controls.Add(this.AfatiKthimit1);
            this.Controls.Add(this.DataHuazimit1);
            this.Controls.Add(this.lblVerejtje);
            this.Controls.Add(this.lblDataKthimit);
            this.Controls.Add(this.lblLibri1);
            this.Controls.Add(this.lblLibri);
            this.Controls.Add(this.lblAfatiKthimit);
            this.Controls.Add(this.lblLexuesi1);
            this.Controls.Add(this.lblLexuesi);
            this.Controls.Add(this.lblKopjaID);
            this.Controls.Add(this.lblPmID1);
            this.Controls.Add(this.lblDataHuazimit);
            this.Controls.Add(this.lblPmID);
            this.Controls.Add(this.lblNumriKopjeve1);
            this.Controls.Add(this.lblNumriKopjeve);
            this.Controls.Add(this.lblLibriID1);
            this.Controls.Add(this.lblLibriID);
            this.Controls.Add(this.btnKthe);
            this.Controls.Add(this.btnHuazo);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.dgvBooks);
            this.Controls.Add(this.txtSearchBook);
            this.Controls.Add(this.dgvReaders);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtSearchReaders);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblSearch);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Location = new System.Drawing.Point(334, 224);
            this.Name = "Issue_ReturnForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Issue_ReturnForm";
            this.Load += new System.EventHandler(this.Issue_ReturnForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvBooks)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvReaders)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvBooks;
        private System.Windows.Forms.TextBox txtSearchBook;
        private System.Windows.Forms.DataGridView dgvReaders;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtSearchReaders;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblSearch;
        private System.Windows.Forms.Button btnBack;
        private Bunifu.Framework.UI.BunifuThinButton2 btnHuazo;
        private Bunifu.Framework.UI.BunifuThinButton2 btnKthe;
        private System.Windows.Forms.Label lblLibri;
        private System.Windows.Forms.Label lblLexuesi;
        private System.Windows.Forms.Label lblLibriID;
        private System.Windows.Forms.Label lblPmID;
        private System.Windows.Forms.Label lblKopjaID;
        private System.Windows.Forms.Label lblDataHuazimit;
        private System.Windows.Forms.Label lblAfatiKthimit;
        private System.Windows.Forms.Label lblDataKthimit;
        private System.Windows.Forms.Label lblVerejtje;
        private System.Windows.Forms.Label lblLibriID1;
        private System.Windows.Forms.Label lblPmID1;
        private System.Windows.Forms.Label lblLexuesi1;
        private System.Windows.Forms.Label lblLibri1;
        private System.Windows.Forms.DateTimePicker DataHuazimit1;
        private System.Windows.Forms.DateTimePicker AfatiKthimit1;
        private System.Windows.Forms.DateTimePicker DataKthimit1;
        private System.Windows.Forms.TextBox txtVerejtej;
        private System.Windows.Forms.TextBox txtKopjaID;
        private System.Windows.Forms.Label lblNumriKopjeve;
        private System.Windows.Forms.Label lblNumriKopjeve1;
    }
}