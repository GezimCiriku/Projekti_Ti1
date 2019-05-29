namespace Bibloteka
{
    partial class BooksForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BooksForm));
            this.dgvBooks = new System.Windows.Forms.DataGridView();
            this.txtVitiBotimit = new System.Windows.Forms.TextBox();
            this.cmbKategoriaID = new System.Windows.Forms.ComboBox();
            this.btnClear = new Bunifu.Framework.UI.BunifuThinButton2();
            this.txtMbiemriAutori = new System.Windows.Forms.TextBox();
            this.txtEmriAutori = new System.Windows.Forms.TextBox();
            this.txtNrKopjeve = new System.Windows.Forms.TextBox();
            this.txtGjuha = new System.Windows.Forms.TextBox();
            this.txtShtepiaBotuese = new System.Windows.Forms.TextBox();
            this.lblMbiemriAutori = new System.Windows.Forms.Label();
            this.txtISBN = new System.Windows.Forms.TextBox();
            this.lblEmriAutori = new System.Windows.Forms.Label();
            this.txtTitulli = new System.Windows.Forms.TextBox();
            this.lblNrKopjeve = new System.Windows.Forms.Label();
            this.txtLibriID = new System.Windows.Forms.TextBox();
            this.lblVitiBotimit = new System.Windows.Forms.Label();
            this.lblKategoriaID = new System.Windows.Forms.Label();
            this.lblGjuha = new System.Windows.Forms.Label();
            this.lblShtepiaBotuese = new System.Windows.Forms.Label();
            this.lblISBN = new System.Windows.Forms.Label();
            this.lblTitulli = new System.Windows.Forms.Label();
            this.lblLibriID = new System.Windows.Forms.Label();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.lblSearch = new System.Windows.Forms.Label();
            this.btnDelete = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnEdit = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnShto = new Bunifu.Framework.UI.BunifuFlatButton();
            this.lblInfo = new System.Windows.Forms.Label();
            this.btnAddCategory = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBooks)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvBooks
            // 
            this.dgvBooks.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBooks.Location = new System.Drawing.Point(536, 127);
            this.dgvBooks.Name = "dgvBooks";
            this.dgvBooks.RowTemplate.Height = 24;
            this.dgvBooks.Size = new System.Drawing.Size(1044, 451);
            this.dgvBooks.TabIndex = 40;
            this.dgvBooks.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvBooks_RowHeaderMouseClick);
            // 
            // txtVitiBotimit
            // 
            this.txtVitiBotimit.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtVitiBotimit.Location = new System.Drawing.Point(232, 410);
            this.txtVitiBotimit.Name = "txtVitiBotimit";
            this.txtVitiBotimit.Size = new System.Drawing.Size(236, 26);
            this.txtVitiBotimit.TabIndex = 6;
            this.txtVitiBotimit.TextChanged += new System.EventHandler(this.txtLibriID_TextChanged);
            // 
            // cmbKategoriaID
            // 
            this.cmbKategoriaID.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbKategoriaID.FormattingEnabled = true;
            this.cmbKategoriaID.Location = new System.Drawing.Point(232, 362);
            this.cmbKategoriaID.Name = "cmbKategoriaID";
            this.cmbKategoriaID.Size = new System.Drawing.Size(236, 28);
            this.cmbKategoriaID.TabIndex = 5;
            // 
            // btnClear
            // 
            this.btnClear.ActiveBorderThickness = 1;
            this.btnClear.ActiveCornerRadius = 20;
            this.btnClear.ActiveFillColor = System.Drawing.Color.Lime;
            this.btnClear.ActiveForecolor = System.Drawing.Color.DarkBlue;
            this.btnClear.ActiveLineColor = System.Drawing.Color.DarkBlue;
            this.btnClear.BackColor = System.Drawing.SystemColors.Control;
            this.btnClear.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnClear.BackgroundImage")));
            this.btnClear.ButtonText = "Pastro ";
            this.btnClear.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClear.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.ForeColor = System.Drawing.Color.DarkMagenta;
            this.btnClear.IdleBorderThickness = 1;
            this.btnClear.IdleCornerRadius = 20;
            this.btnClear.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnClear.IdleForecolor = System.Drawing.Color.Black;
            this.btnClear.IdleLineColor = System.Drawing.Color.RoyalBlue;
            this.btnClear.Location = new System.Drawing.Point(260, 650);
            this.btnClear.Margin = new System.Windows.Forms.Padding(5);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(176, 53);
            this.btnClear.TabIndex = 10;
            this.btnClear.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // txtMbiemriAutori
            // 
            this.txtMbiemriAutori.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMbiemriAutori.Location = new System.Drawing.Point(232, 549);
            this.txtMbiemriAutori.Name = "txtMbiemriAutori";
            this.txtMbiemriAutori.Size = new System.Drawing.Size(236, 28);
            this.txtMbiemriAutori.TabIndex = 9;
            this.txtMbiemriAutori.TextChanged += new System.EventHandler(this.txtLibriID_TextChanged);
            // 
            // txtEmriAutori
            // 
            this.txtEmriAutori.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmriAutori.Location = new System.Drawing.Point(232, 503);
            this.txtEmriAutori.Name = "txtEmriAutori";
            this.txtEmriAutori.Size = new System.Drawing.Size(236, 28);
            this.txtEmriAutori.TabIndex = 8;
            this.txtEmriAutori.TextChanged += new System.EventHandler(this.txtLibriID_TextChanged);
            // 
            // txtNrKopjeve
            // 
            this.txtNrKopjeve.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNrKopjeve.Location = new System.Drawing.Point(232, 455);
            this.txtNrKopjeve.Name = "txtNrKopjeve";
            this.txtNrKopjeve.Size = new System.Drawing.Size(236, 28);
            this.txtNrKopjeve.TabIndex = 7;
            this.txtNrKopjeve.TextChanged += new System.EventHandler(this.txtLibriID_TextChanged);
            // 
            // txtGjuha
            // 
            this.txtGjuha.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtGjuha.Location = new System.Drawing.Point(232, 317);
            this.txtGjuha.Name = "txtGjuha";
            this.txtGjuha.Size = new System.Drawing.Size(236, 28);
            this.txtGjuha.TabIndex = 4;
            this.txtGjuha.TextChanged += new System.EventHandler(this.txtLibriID_TextChanged);
            // 
            // txtShtepiaBotuese
            // 
            this.txtShtepiaBotuese.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtShtepiaBotuese.Location = new System.Drawing.Point(232, 268);
            this.txtShtepiaBotuese.Name = "txtShtepiaBotuese";
            this.txtShtepiaBotuese.Size = new System.Drawing.Size(236, 28);
            this.txtShtepiaBotuese.TabIndex = 3;
            this.txtShtepiaBotuese.TextChanged += new System.EventHandler(this.txtLibriID_TextChanged);
            // 
            // lblMbiemriAutori
            // 
            this.lblMbiemriAutori.AutoSize = true;
            this.lblMbiemriAutori.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMbiemriAutori.Location = new System.Drawing.Point(49, 554);
            this.lblMbiemriAutori.Name = "lblMbiemriAutori";
            this.lblMbiemriAutori.Size = new System.Drawing.Size(150, 24);
            this.lblMbiemriAutori.TabIndex = 31;
            this.lblMbiemriAutori.Text = "Mbiemri i Autorit:";
            // 
            // txtISBN
            // 
            this.txtISBN.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtISBN.Location = new System.Drawing.Point(232, 220);
            this.txtISBN.Name = "txtISBN";
            this.txtISBN.Size = new System.Drawing.Size(236, 28);
            this.txtISBN.TabIndex = 2;
            this.txtISBN.TextChanged += new System.EventHandler(this.txtLibriID_TextChanged);
            // 
            // lblEmriAutori
            // 
            this.lblEmriAutori.AutoSize = true;
            this.lblEmriAutori.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmriAutori.Location = new System.Drawing.Point(49, 508);
            this.lblEmriAutori.Name = "lblEmriAutori";
            this.lblEmriAutori.Size = new System.Drawing.Size(121, 24);
            this.lblEmriAutori.TabIndex = 22;
            this.lblEmriAutori.Text = "Emri i Autorit:";
            // 
            // txtTitulli
            // 
            this.txtTitulli.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTitulli.Location = new System.Drawing.Point(232, 173);
            this.txtTitulli.Name = "txtTitulli";
            this.txtTitulli.Size = new System.Drawing.Size(236, 28);
            this.txtTitulli.TabIndex = 1;
            this.txtTitulli.TextChanged += new System.EventHandler(this.txtLibriID_TextChanged);
            // 
            // lblNrKopjeve
            // 
            this.lblNrKopjeve.AutoSize = true;
            this.lblNrKopjeve.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNrKopjeve.Location = new System.Drawing.Point(49, 460);
            this.lblNrKopjeve.Name = "lblNrKopjeve";
            this.lblNrKopjeve.Size = new System.Drawing.Size(146, 24);
            this.lblNrKopjeve.TabIndex = 29;
            this.lblNrKopjeve.Text = "Numri i kopjeve:";
            // 
            // txtLibriID
            // 
            this.txtLibriID.Enabled = false;
            this.txtLibriID.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLibriID.Location = new System.Drawing.Point(232, 127);
            this.txtLibriID.Name = "txtLibriID";
            this.txtLibriID.Size = new System.Drawing.Size(236, 28);
            this.txtLibriID.TabIndex = 0;
            this.txtLibriID.TextChanged += new System.EventHandler(this.txtLibriID_TextChanged);
            // 
            // lblVitiBotimit
            // 
            this.lblVitiBotimit.AutoSize = true;
            this.lblVitiBotimit.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVitiBotimit.Location = new System.Drawing.Point(49, 413);
            this.lblVitiBotimit.Name = "lblVitiBotimit";
            this.lblVitiBotimit.Size = new System.Drawing.Size(109, 24);
            this.lblVitiBotimit.TabIndex = 27;
            this.lblVitiBotimit.Text = "Viti i Botimit:";
            // 
            // lblKategoriaID
            // 
            this.lblKategoriaID.AutoSize = true;
            this.lblKategoriaID.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblKategoriaID.Location = new System.Drawing.Point(49, 367);
            this.lblKategoriaID.Name = "lblKategoriaID";
            this.lblKategoriaID.Size = new System.Drawing.Size(94, 24);
            this.lblKategoriaID.TabIndex = 26;
            this.lblKategoriaID.Text = "Kategoria:";
            // 
            // lblGjuha
            // 
            this.lblGjuha.AutoSize = true;
            this.lblGjuha.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGjuha.Location = new System.Drawing.Point(49, 322);
            this.lblGjuha.Name = "lblGjuha";
            this.lblGjuha.Size = new System.Drawing.Size(65, 24);
            this.lblGjuha.TabIndex = 25;
            this.lblGjuha.Text = "Gjuha:";
            // 
            // lblShtepiaBotuese
            // 
            this.lblShtepiaBotuese.AutoSize = true;
            this.lblShtepiaBotuese.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblShtepiaBotuese.Location = new System.Drawing.Point(49, 273);
            this.lblShtepiaBotuese.Name = "lblShtepiaBotuese";
            this.lblShtepiaBotuese.Size = new System.Drawing.Size(152, 24);
            this.lblShtepiaBotuese.TabIndex = 24;
            this.lblShtepiaBotuese.Text = "Shtepia Botuese:";
            // 
            // lblISBN
            // 
            this.lblISBN.AutoSize = true;
            this.lblISBN.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblISBN.Location = new System.Drawing.Point(49, 225);
            this.lblISBN.Name = "lblISBN";
            this.lblISBN.Size = new System.Drawing.Size(57, 24);
            this.lblISBN.TabIndex = 23;
            this.lblISBN.Text = "ISBN:";
            // 
            // lblTitulli
            // 
            this.lblTitulli.AutoSize = true;
            this.lblTitulli.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulli.Location = new System.Drawing.Point(49, 178);
            this.lblTitulli.Name = "lblTitulli";
            this.lblTitulli.Size = new System.Drawing.Size(58, 24);
            this.lblTitulli.TabIndex = 30;
            this.lblTitulli.Text = "Titulli:";
            // 
            // lblLibriID
            // 
            this.lblLibriID.AutoSize = true;
            this.lblLibriID.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLibriID.Location = new System.Drawing.Point(49, 132);
            this.lblLibriID.Name = "lblLibriID";
            this.lblLibriID.Size = new System.Drawing.Size(67, 24);
            this.lblLibriID.TabIndex = 28;
            this.lblLibriID.Text = "LibriID:";
            // 
            // txtSearch
            // 
            this.txtSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearch.Location = new System.Drawing.Point(624, 72);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(593, 28);
            this.txtSearch.TabIndex = 14;
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
            // 
            // lblSearch
            // 
            this.lblSearch.AutoSize = true;
            this.lblSearch.BackColor = System.Drawing.Color.Transparent;
            this.lblSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSearch.Location = new System.Drawing.Point(536, 75);
            this.lblSearch.Name = "lblSearch";
            this.lblSearch.Size = new System.Drawing.Size(70, 25);
            this.lblSearch.TabIndex = 18;
            this.lblSearch.Text = "Kërko:";
            // 
            // btnDelete
            // 
            this.btnDelete.Activecolor = System.Drawing.Color.LightCoral;
            this.btnDelete.BackColor = System.Drawing.Color.DarkRed;
            this.btnDelete.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnDelete.BorderRadius = 0;
            this.btnDelete.ButtonText = "               Fshij";
            this.btnDelete.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDelete.DisabledColor = System.Drawing.Color.Gray;
            this.btnDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.ForeColor = System.Drawing.Color.Black;
            this.btnDelete.Iconcolor = System.Drawing.Color.Transparent;
            this.btnDelete.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnDelete.Iconimage")));
            this.btnDelete.Iconimage_right = null;
            this.btnDelete.Iconimage_right_Selected = null;
            this.btnDelete.Iconimage_Selected = null;
            this.btnDelete.IconMarginLeft = 0;
            this.btnDelete.IconMarginRight = 0;
            this.btnDelete.IconRightVisible = true;
            this.btnDelete.IconRightZoom = 0D;
            this.btnDelete.IconVisible = true;
            this.btnDelete.IconZoom = 70D;
            this.btnDelete.IsTab = false;
            this.btnDelete.Location = new System.Drawing.Point(1118, 645);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Normalcolor = System.Drawing.Color.DarkRed;
            this.btnDelete.OnHovercolor = System.Drawing.Color.LightCoral;
            this.btnDelete.OnHoverTextColor = System.Drawing.Color.Black;
            this.btnDelete.selected = false;
            this.btnDelete.Size = new System.Drawing.Size(173, 58);
            this.btnDelete.TabIndex = 13;
            this.btnDelete.Text = "               Fshij";
            this.btnDelete.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDelete.Textcolor = System.Drawing.Color.White;
            this.btnDelete.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.Activecolor = System.Drawing.Color.Aqua;
            this.btnEdit.BackColor = System.Drawing.Color.DarkBlue;
            this.btnEdit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnEdit.BorderRadius = 0;
            this.btnEdit.ButtonText = "               Përditso";
            this.btnEdit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEdit.DisabledColor = System.Drawing.Color.Gray;
            this.btnEdit.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEdit.ForeColor = System.Drawing.Color.Black;
            this.btnEdit.Iconcolor = System.Drawing.Color.Transparent;
            this.btnEdit.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnEdit.Iconimage")));
            this.btnEdit.Iconimage_right = null;
            this.btnEdit.Iconimage_right_Selected = null;
            this.btnEdit.Iconimage_Selected = null;
            this.btnEdit.IconMarginLeft = 0;
            this.btnEdit.IconMarginRight = 0;
            this.btnEdit.IconRightVisible = true;
            this.btnEdit.IconRightZoom = 0D;
            this.btnEdit.IconVisible = true;
            this.btnEdit.IconZoom = 65D;
            this.btnEdit.IsTab = false;
            this.btnEdit.Location = new System.Drawing.Point(884, 645);
            this.btnEdit.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Normalcolor = System.Drawing.Color.DarkBlue;
            this.btnEdit.OnHovercolor = System.Drawing.Color.Aqua;
            this.btnEdit.OnHoverTextColor = System.Drawing.Color.Black;
            this.btnEdit.selected = false;
            this.btnEdit.Size = new System.Drawing.Size(173, 58);
            this.btnEdit.TabIndex = 12;
            this.btnEdit.Text = "               Përditso";
            this.btnEdit.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEdit.Textcolor = System.Drawing.Color.White;
            this.btnEdit.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnShto
            // 
            this.btnShto.Activecolor = System.Drawing.Color.Lime;
            this.btnShto.BackColor = System.Drawing.Color.Green;
            this.btnShto.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnShto.BorderRadius = 0;
            this.btnShto.ButtonText = "               Shto";
            this.btnShto.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnShto.DisabledColor = System.Drawing.Color.Gray;
            this.btnShto.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnShto.ForeColor = System.Drawing.Color.Black;
            this.btnShto.Iconcolor = System.Drawing.Color.Transparent;
            this.btnShto.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnShto.Iconimage")));
            this.btnShto.Iconimage_right = null;
            this.btnShto.Iconimage_right_Selected = null;
            this.btnShto.Iconimage_Selected = null;
            this.btnShto.IconMarginLeft = 0;
            this.btnShto.IconMarginRight = 0;
            this.btnShto.IconRightVisible = true;
            this.btnShto.IconRightZoom = 0D;
            this.btnShto.IconVisible = true;
            this.btnShto.IconZoom = 70D;
            this.btnShto.IsTab = false;
            this.btnShto.Location = new System.Drawing.Point(650, 645);
            this.btnShto.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnShto.Name = "btnShto";
            this.btnShto.Normalcolor = System.Drawing.Color.Green;
            this.btnShto.OnHovercolor = System.Drawing.Color.Lime;
            this.btnShto.OnHoverTextColor = System.Drawing.Color.Black;
            this.btnShto.selected = false;
            this.btnShto.Size = new System.Drawing.Size(173, 58);
            this.btnShto.TabIndex = 11;
            this.btnShto.Text = "               Shto";
            this.btnShto.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnShto.Textcolor = System.Drawing.Color.White;
            this.btnShto.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnShto.Click += new System.EventHandler(this.btnShto_Click);
            // 
            // lblInfo
            // 
            this.lblInfo.AutoSize = true;
            this.lblInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInfo.ForeColor = System.Drawing.Color.DarkBlue;
            this.lblInfo.Location = new System.Drawing.Point(571, 9);
            this.lblInfo.Name = "lblInfo";
            this.lblInfo.Size = new System.Drawing.Size(239, 29);
            this.lblInfo.TabIndex = 11;
            this.lblInfo.Text = "Menaxhimi i Librave";
            // 
            // btnAddCategory
            // 
            this.btnAddCategory.BackColor = System.Drawing.SystemColors.Control;
            this.btnAddCategory.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnAddCategory.BackgroundImage")));
            this.btnAddCategory.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnAddCategory.ForeColor = System.Drawing.Color.Transparent;
            this.btnAddCategory.Location = new System.Drawing.Point(475, 353);
            this.btnAddCategory.Name = "btnAddCategory";
            this.btnAddCategory.Size = new System.Drawing.Size(46, 44);
            this.btnAddCategory.TabIndex = 41;
            this.btnAddCategory.UseVisualStyleBackColor = false;
            // 
            // BooksForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1600, 806);
            this.Controls.Add(this.btnAddCategory);
            this.Controls.Add(this.dgvBooks);
            this.Controls.Add(this.txtVitiBotimit);
            this.Controls.Add(this.cmbKategoriaID);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.txtMbiemriAutori);
            this.Controls.Add(this.txtEmriAutori);
            this.Controls.Add(this.txtNrKopjeve);
            this.Controls.Add(this.txtGjuha);
            this.Controls.Add(this.txtShtepiaBotuese);
            this.Controls.Add(this.lblMbiemriAutori);
            this.Controls.Add(this.txtISBN);
            this.Controls.Add(this.lblEmriAutori);
            this.Controls.Add(this.txtTitulli);
            this.Controls.Add(this.lblNrKopjeve);
            this.Controls.Add(this.txtLibriID);
            this.Controls.Add(this.lblVitiBotimit);
            this.Controls.Add(this.lblKategoriaID);
            this.Controls.Add(this.lblGjuha);
            this.Controls.Add(this.lblShtepiaBotuese);
            this.Controls.Add(this.lblISBN);
            this.Controls.Add(this.lblTitulli);
            this.Controls.Add(this.lblLibriID);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.lblSearch);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.btnShto);
            this.Controls.Add(this.lblInfo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Location = new System.Drawing.Point(334, 224);
            this.Name = "BooksForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "BooksForm";
            this.Load += new System.EventHandler(this.BooksForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvBooks)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvBooks;
        private System.Windows.Forms.TextBox txtVitiBotimit;
        private System.Windows.Forms.ComboBox cmbKategoriaID;
        private Bunifu.Framework.UI.BunifuThinButton2 btnClear;
        private System.Windows.Forms.TextBox txtMbiemriAutori;
        private System.Windows.Forms.TextBox txtEmriAutori;
        private System.Windows.Forms.TextBox txtNrKopjeve;
        private System.Windows.Forms.TextBox txtGjuha;
        private System.Windows.Forms.TextBox txtShtepiaBotuese;
        private System.Windows.Forms.Label lblMbiemriAutori;
        private System.Windows.Forms.TextBox txtISBN;
        private System.Windows.Forms.Label lblEmriAutori;
        private System.Windows.Forms.TextBox txtTitulli;
        private System.Windows.Forms.Label lblNrKopjeve;
        private System.Windows.Forms.TextBox txtLibriID;
        private System.Windows.Forms.Label lblVitiBotimit;
        private System.Windows.Forms.Label lblKategoriaID;
        private System.Windows.Forms.Label lblGjuha;
        private System.Windows.Forms.Label lblShtepiaBotuese;
        private System.Windows.Forms.Label lblISBN;
        private System.Windows.Forms.Label lblTitulli;
        private System.Windows.Forms.Label lblLibriID;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Label lblSearch;
        private Bunifu.Framework.UI.BunifuFlatButton btnDelete;
        private Bunifu.Framework.UI.BunifuFlatButton btnEdit;
        private Bunifu.Framework.UI.BunifuFlatButton btnShto;
        private System.Windows.Forms.Label lblInfo;
        private System.Windows.Forms.Button btnAddCategory;
    }
}