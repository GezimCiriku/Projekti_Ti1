namespace Bibloteka
{
    partial class StaffForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StaffForm));
            this.dtpDateRregj = new System.Windows.Forms.DateTimePicker();
            this.dgvStaff = new System.Windows.Forms.DataGridView();
            this.txtFjalekalimi = new System.Windows.Forms.TextBox();
            this.btnClear = new Bunifu.Framework.UI.BunifuThinButton2();
            this.txtNofka = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtNrTel = new System.Windows.Forms.TextBox();
            this.txtMbiemri = new System.Windows.Forms.TextBox();
            this.txtID = new System.Windows.Forms.TextBox();
            this.txtEmri = new System.Windows.Forms.TextBox();
            this.lblFjalekalimi = new System.Windows.Forms.Label();
            this.lblNofka = new System.Windows.Forms.Label();
            this.lblDataRegj = new System.Windows.Forms.Label();
            this.lblEmail = new System.Windows.Forms.Label();
            this.lblNrTel = new System.Windows.Forms.Label();
            this.lblID = new System.Windows.Forms.Label();
            this.lblMbiemri = new System.Windows.Forms.Label();
            this.lblEmri = new System.Windows.Forms.Label();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.lblSearch = new System.Windows.Forms.Label();
            this.btnDelete = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnEdit = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnShto = new Bunifu.Framework.UI.BunifuFlatButton();
            this.lblInfo = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStaff)).BeginInit();
            this.SuspendLayout();
            // 
            // dtpDateRregj
            // 
            this.dtpDateRregj.Location = new System.Drawing.Point(201, 373);
            this.dtpDateRregj.MinDate = new System.DateTime(2019, 4, 1, 0, 0, 0, 0);
            this.dtpDateRregj.Name = "dtpDateRregj";
            this.dtpDateRregj.Size = new System.Drawing.Size(236, 22);
            this.dtpDateRregj.TabIndex = 95;
            // 
            // dgvStaff
            // 
            this.dgvStaff.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvStaff.Location = new System.Drawing.Point(502, 127);
            this.dgvStaff.Name = "dgvStaff";
            this.dgvStaff.RowTemplate.Height = 24;
            this.dgvStaff.Size = new System.Drawing.Size(990, 451);
            this.dgvStaff.TabIndex = 94;
            this.dgvStaff.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvStaff_RowHeaderMouseClick);
            // 
            // txtFjalekalimi
            // 
            this.txtFjalekalimi.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFjalekalimi.Location = new System.Drawing.Point(201, 460);
            this.txtFjalekalimi.Name = "txtFjalekalimi";
            this.txtFjalekalimi.Size = new System.Drawing.Size(236, 26);
            this.txtFjalekalimi.TabIndex = 78;
            this.txtFjalekalimi.TextChanged += new System.EventHandler(this.txtID_TextChanged);
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
            this.btnClear.Location = new System.Drawing.Point(228, 536);
            this.btnClear.Margin = new System.Windows.Forms.Padding(5);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(176, 53);
            this.btnClear.TabIndex = 79;
            this.btnClear.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // txtNofka
            // 
            this.txtNofka.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNofka.Location = new System.Drawing.Point(201, 413);
            this.txtNofka.Name = "txtNofka";
            this.txtNofka.Size = new System.Drawing.Size(236, 28);
            this.txtNofka.TabIndex = 76;
            this.txtNofka.TextChanged += new System.EventHandler(this.txtID_TextChanged);
            // 
            // txtEmail
            // 
            this.txtEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmail.Location = new System.Drawing.Point(201, 318);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(236, 28);
            this.txtEmail.TabIndex = 77;
            this.txtEmail.TextChanged += new System.EventHandler(this.txtID_TextChanged);
            // 
            // txtNrTel
            // 
            this.txtNrTel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNrTel.Location = new System.Drawing.Point(201, 270);
            this.txtNrTel.Name = "txtNrTel";
            this.txtNrTel.Size = new System.Drawing.Size(236, 28);
            this.txtNrTel.TabIndex = 75;
            this.txtNrTel.TextChanged += new System.EventHandler(this.txtID_TextChanged);
            // 
            // txtMbiemri
            // 
            this.txtMbiemri.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMbiemri.Location = new System.Drawing.Point(201, 223);
            this.txtMbiemri.Name = "txtMbiemri";
            this.txtMbiemri.Size = new System.Drawing.Size(236, 28);
            this.txtMbiemri.TabIndex = 74;
            this.txtMbiemri.TextChanged += new System.EventHandler(this.txtID_TextChanged);
            // 
            // txtID
            // 
            this.txtID.Enabled = false;
            this.txtID.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtID.Location = new System.Drawing.Point(201, 131);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(236, 28);
            this.txtID.TabIndex = 72;
            this.txtID.TextChanged += new System.EventHandler(this.txtID_TextChanged);
            // 
            // txtEmri
            // 
            this.txtEmri.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmri.Location = new System.Drawing.Point(201, 177);
            this.txtEmri.Name = "txtEmri";
            this.txtEmri.Size = new System.Drawing.Size(236, 28);
            this.txtEmri.TabIndex = 73;
            this.txtEmri.TextChanged += new System.EventHandler(this.txtID_TextChanged);
            // 
            // lblFjalekalimi
            // 
            this.lblFjalekalimi.AutoSize = true;
            this.lblFjalekalimi.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFjalekalimi.Location = new System.Drawing.Point(18, 463);
            this.lblFjalekalimi.Name = "lblFjalekalimi";
            this.lblFjalekalimi.Size = new System.Drawing.Size(103, 24);
            this.lblFjalekalimi.TabIndex = 90;
            this.lblFjalekalimi.Text = "Fjalekalimi:";
            // 
            // lblNofka
            // 
            this.lblNofka.AutoSize = true;
            this.lblNofka.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNofka.Location = new System.Drawing.Point(18, 417);
            this.lblNofka.Name = "lblNofka";
            this.lblNofka.Size = new System.Drawing.Size(63, 24);
            this.lblNofka.TabIndex = 89;
            this.lblNofka.Text = "Nofka:";
            // 
            // lblDataRegj
            // 
            this.lblDataRegj.AutoSize = true;
            this.lblDataRegj.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDataRegj.Location = new System.Drawing.Point(18, 372);
            this.lblDataRegj.Name = "lblDataRegj";
            this.lblDataRegj.Size = new System.Drawing.Size(162, 24);
            this.lblDataRegj.TabIndex = 88;
            this.lblDataRegj.Text = "Data e rregjistrimit:";
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmail.Location = new System.Drawing.Point(18, 323);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(127, 24);
            this.lblEmail.TabIndex = 87;
            this.lblEmail.Text = "Email Adresa:";
            // 
            // lblNrTel
            // 
            this.lblNrTel.AutoSize = true;
            this.lblNrTel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNrTel.Location = new System.Drawing.Point(18, 275);
            this.lblNrTel.Name = "lblNrTel";
            this.lblNrTel.Size = new System.Drawing.Size(152, 24);
            this.lblNrTel.TabIndex = 86;
            this.lblNrTel.Text = "Numri i Telefonit:";
            // 
            // lblID
            // 
            this.lblID.AutoSize = true;
            this.lblID.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblID.Location = new System.Drawing.Point(18, 136);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(32, 24);
            this.lblID.TabIndex = 91;
            this.lblID.Text = "ID:";
            // 
            // lblMbiemri
            // 
            this.lblMbiemri.AutoSize = true;
            this.lblMbiemri.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMbiemri.Location = new System.Drawing.Point(18, 228);
            this.lblMbiemri.Name = "lblMbiemri";
            this.lblMbiemri.Size = new System.Drawing.Size(83, 24);
            this.lblMbiemri.TabIndex = 93;
            this.lblMbiemri.Text = "Mbiemri:";
            // 
            // lblEmri
            // 
            this.lblEmri.AutoSize = true;
            this.lblEmri.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmri.Location = new System.Drawing.Point(18, 182);
            this.lblEmri.Name = "lblEmri";
            this.lblEmri.Size = new System.Drawing.Size(54, 24);
            this.lblEmri.TabIndex = 92;
            this.lblEmri.Text = "Emri:";
            // 
            // txtSearch
            // 
            this.txtSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearch.Location = new System.Drawing.Point(590, 72);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(593, 28);
            this.txtSearch.TabIndex = 84;
            this.txtSearch.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtSearch_KeyUp);
            // 
            // lblSearch
            // 
            this.lblSearch.AutoSize = true;
            this.lblSearch.BackColor = System.Drawing.Color.Transparent;
            this.lblSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSearch.Location = new System.Drawing.Point(502, 75);
            this.lblSearch.Name = "lblSearch";
            this.lblSearch.Size = new System.Drawing.Size(70, 25);
            this.lblSearch.TabIndex = 85;
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
            this.btnDelete.Location = new System.Drawing.Point(1084, 645);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Normalcolor = System.Drawing.Color.DarkRed;
            this.btnDelete.OnHovercolor = System.Drawing.Color.LightCoral;
            this.btnDelete.OnHoverTextColor = System.Drawing.Color.Black;
            this.btnDelete.selected = false;
            this.btnDelete.Size = new System.Drawing.Size(173, 58);
            this.btnDelete.TabIndex = 83;
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
            this.btnEdit.Location = new System.Drawing.Point(850, 645);
            this.btnEdit.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Normalcolor = System.Drawing.Color.DarkBlue;
            this.btnEdit.OnHovercolor = System.Drawing.Color.Aqua;
            this.btnEdit.OnHoverTextColor = System.Drawing.Color.Black;
            this.btnEdit.selected = false;
            this.btnEdit.Size = new System.Drawing.Size(173, 58);
            this.btnEdit.TabIndex = 82;
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
            this.btnShto.Location = new System.Drawing.Point(616, 645);
            this.btnShto.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnShto.Name = "btnShto";
            this.btnShto.Normalcolor = System.Drawing.Color.Green;
            this.btnShto.OnHovercolor = System.Drawing.Color.Lime;
            this.btnShto.OnHoverTextColor = System.Drawing.Color.Black;
            this.btnShto.selected = false;
            this.btnShto.Size = new System.Drawing.Size(173, 58);
            this.btnShto.TabIndex = 80;
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
            this.lblInfo.Location = new System.Drawing.Point(537, 9);
            this.lblInfo.Name = "lblInfo";
            this.lblInfo.Size = new System.Drawing.Size(214, 29);
            this.lblInfo.TabIndex = 81;
            this.lblInfo.Text = "Menaxhimi i Stafit";
            // 
            // StaffForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1564, 712);
            this.Controls.Add(this.dtpDateRregj);
            this.Controls.Add(this.dgvStaff);
            this.Controls.Add(this.txtFjalekalimi);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.txtNofka);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.txtNrTel);
            this.Controls.Add(this.txtMbiemri);
            this.Controls.Add(this.txtID);
            this.Controls.Add(this.txtEmri);
            this.Controls.Add(this.lblFjalekalimi);
            this.Controls.Add(this.lblNofka);
            this.Controls.Add(this.lblDataRegj);
            this.Controls.Add(this.lblEmail);
            this.Controls.Add(this.lblNrTel);
            this.Controls.Add(this.lblID);
            this.Controls.Add(this.lblMbiemri);
            this.Controls.Add(this.lblEmri);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.lblSearch);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.btnShto);
            this.Controls.Add(this.lblInfo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Location = new System.Drawing.Point(334, 224);
            this.Name = "StaffForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "StaffForm";
            this.Load += new System.EventHandler(this.StaffForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvStaff)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dtpDateRregj;
        private System.Windows.Forms.DataGridView dgvStaff;
        private System.Windows.Forms.TextBox txtFjalekalimi;
        private Bunifu.Framework.UI.BunifuThinButton2 btnClear;
        private System.Windows.Forms.TextBox txtNofka;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtNrTel;
        private System.Windows.Forms.TextBox txtMbiemri;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.TextBox txtEmri;
        private System.Windows.Forms.Label lblFjalekalimi;
        private System.Windows.Forms.Label lblNofka;
        private System.Windows.Forms.Label lblDataRegj;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label lblNrTel;
        private System.Windows.Forms.Label lblID;
        private System.Windows.Forms.Label lblMbiemri;
        private System.Windows.Forms.Label lblEmri;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Label lblSearch;
        private Bunifu.Framework.UI.BunifuFlatButton btnDelete;
        private Bunifu.Framework.UI.BunifuFlatButton btnEdit;
        private Bunifu.Framework.UI.BunifuFlatButton btnShto;
        private System.Windows.Forms.Label lblInfo;
    }
}