namespace Bibloteka
{
    partial class LoansForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoansForm));
            this.dgvHuazimet = new System.Windows.Forms.DataGridView();
            this.txtSearchReaders = new System.Windows.Forms.TextBox();
            this.lblSearch = new System.Windows.Forms.Label();
            this.btnShto = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnShikoDetajet = new Bunifu.Framework.UI.BunifuFlatButton();
            this.dgvHuazimetDetajet = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHuazimet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHuazimetDetajet)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvHuazimet
            // 
            this.dgvHuazimet.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvHuazimet.Location = new System.Drawing.Point(98, 138);
            this.dgvHuazimet.Name = "dgvHuazimet";
            this.dgvHuazimet.RowHeadersWidth = 50;
            this.dgvHuazimet.RowTemplate.Height = 24;
            this.dgvHuazimet.Size = new System.Drawing.Size(1146, 596);
            this.dgvHuazimet.TabIndex = 72;
            // 
            // txtSearchReaders
            // 
            this.txtSearchReaders.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearchReaders.Location = new System.Drawing.Point(186, 78);
            this.txtSearchReaders.Name = "txtSearchReaders";
            this.txtSearchReaders.Size = new System.Drawing.Size(615, 28);
            this.txtSearchReaders.TabIndex = 70;
            // 
            // lblSearch
            // 
            this.lblSearch.AutoSize = true;
            this.lblSearch.BackColor = System.Drawing.Color.Transparent;
            this.lblSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSearch.Location = new System.Drawing.Point(93, 79);
            this.lblSearch.Name = "lblSearch";
            this.lblSearch.Size = new System.Drawing.Size(70, 25);
            this.lblSearch.TabIndex = 71;
            this.lblSearch.Text = "Kërko:";
            // 
            // btnShto
            // 
            this.btnShto.Activecolor = System.Drawing.Color.Lime;
            this.btnShto.BackColor = System.Drawing.Color.Green;
            this.btnShto.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnShto.BorderRadius = 0;
            this.btnShto.ButtonText = "                   Huazo-Kthe                          Liber";
            this.btnShto.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnShto.DisabledColor = System.Drawing.Color.Gray;
            this.btnShto.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
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
            this.btnShto.IconZoom = 60D;
            this.btnShto.IsTab = false;
            this.btnShto.Location = new System.Drawing.Point(1333, 134);
            this.btnShto.Margin = new System.Windows.Forms.Padding(4);
            this.btnShto.Name = "btnShto";
            this.btnShto.Normalcolor = System.Drawing.Color.Green;
            this.btnShto.OnHovercolor = System.Drawing.Color.Lime;
            this.btnShto.OnHoverTextColor = System.Drawing.Color.Black;
            this.btnShto.selected = false;
            this.btnShto.Size = new System.Drawing.Size(204, 69);
            this.btnShto.TabIndex = 73;
            this.btnShto.Text = "                   Huazo-Kthe                          Liber";
            this.btnShto.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnShto.Textcolor = System.Drawing.Color.White;
            this.btnShto.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnShto.Click += new System.EventHandler(this.btnShto_Click);
            // 
            // btnShikoDetajet
            // 
            this.btnShikoDetajet.Activecolor = System.Drawing.Color.Aqua;
            this.btnShikoDetajet.BackColor = System.Drawing.Color.DarkBlue;
            this.btnShikoDetajet.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnShikoDetajet.BorderRadius = 0;
            this.btnShikoDetajet.ButtonText = "                 ShikoDetajet";
            this.btnShikoDetajet.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnShikoDetajet.DisabledColor = System.Drawing.Color.Gray;
            this.btnShikoDetajet.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnShikoDetajet.ForeColor = System.Drawing.Color.Black;
            this.btnShikoDetajet.Iconcolor = System.Drawing.Color.Transparent;
            this.btnShikoDetajet.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnShikoDetajet.Iconimage")));
            this.btnShikoDetajet.Iconimage_right = null;
            this.btnShikoDetajet.Iconimage_right_Selected = null;
            this.btnShikoDetajet.Iconimage_Selected = null;
            this.btnShikoDetajet.IconMarginLeft = 0;
            this.btnShikoDetajet.IconMarginRight = 0;
            this.btnShikoDetajet.IconRightVisible = true;
            this.btnShikoDetajet.IconRightZoom = 0D;
            this.btnShikoDetajet.IconVisible = true;
            this.btnShikoDetajet.IconZoom = 65D;
            this.btnShikoDetajet.IsTab = false;
            this.btnShikoDetajet.Location = new System.Drawing.Point(1333, 253);
            this.btnShikoDetajet.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnShikoDetajet.Name = "btnShikoDetajet";
            this.btnShikoDetajet.Normalcolor = System.Drawing.Color.DarkBlue;
            this.btnShikoDetajet.OnHovercolor = System.Drawing.Color.Aqua;
            this.btnShikoDetajet.OnHoverTextColor = System.Drawing.Color.Black;
            this.btnShikoDetajet.selected = false;
            this.btnShikoDetajet.Size = new System.Drawing.Size(204, 69);
            this.btnShikoDetajet.TabIndex = 74;
            this.btnShikoDetajet.Text = "                 ShikoDetajet";
            this.btnShikoDetajet.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnShikoDetajet.Textcolor = System.Drawing.Color.White;
            this.btnShikoDetajet.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnShikoDetajet.Click += new System.EventHandler(this.btnShikoDetajet_Click);
            // 
            // dgvHuazimetDetajet
            // 
            this.dgvHuazimetDetajet.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvHuazimetDetajet.Location = new System.Drawing.Point(88, 150);
            this.dgvHuazimetDetajet.Name = "dgvHuazimetDetajet";
            this.dgvHuazimetDetajet.RowTemplate.Height = 24;
            this.dgvHuazimetDetajet.Size = new System.Drawing.Size(1170, 605);
            this.dgvHuazimetDetajet.TabIndex = 75;
            // 
            // LoansForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1564, 783);
            this.Controls.Add(this.dgvHuazimetDetajet);
            this.Controls.Add(this.btnShikoDetajet);
            this.Controls.Add(this.btnShto);
            this.Controls.Add(this.dgvHuazimet);
            this.Controls.Add(this.txtSearchReaders);
            this.Controls.Add(this.lblSearch);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Location = new System.Drawing.Point(334, 224);
            this.Name = "LoansForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Loan";
            this.Load += new System.EventHandler(this.LoansForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvHuazimet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHuazimetDetajet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvHuazimet;
        private System.Windows.Forms.TextBox txtSearchReaders;
        private System.Windows.Forms.Label lblSearch;
        private Bunifu.Framework.UI.BunifuFlatButton btnShto;
        private Bunifu.Framework.UI.BunifuFlatButton btnShikoDetajet;
        private System.Windows.Forms.DataGridView dgvHuazimetDetajet;
    }
}