namespace Bibloteka
{
    partial class AddCategoryForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddCategoryForm));
            this.gb1 = new System.Windows.Forms.GroupBox();
            this.btnClose = new Bunifu.Framework.UI.BunifuImageButton();
            this.lblID = new System.Windows.Forms.Label();
            this.dgvCategories = new System.Windows.Forms.DataGridView();
            this.txtID = new System.Windows.Forms.TextBox();
            this.txtKategoria = new System.Windows.Forms.TextBox();
            this.lblKategoria = new System.Windows.Forms.Label();
            this.btnDelete = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnShto = new Bunifu.Framework.UI.BunifuFlatButton();
            this.gb1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnClose)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCategories)).BeginInit();
            this.SuspendLayout();
            // 
            // gb1
            // 
            this.gb1.Controls.Add(this.btnClose);
            this.gb1.Controls.Add(this.lblID);
            this.gb1.Controls.Add(this.dgvCategories);
            this.gb1.Controls.Add(this.txtID);
            this.gb1.Controls.Add(this.txtKategoria);
            this.gb1.Controls.Add(this.lblKategoria);
            this.gb1.Controls.Add(this.btnDelete);
            this.gb1.Controls.Add(this.btnShto);
            this.gb1.Location = new System.Drawing.Point(12, 12);
            this.gb1.Name = "gb1";
            this.gb1.Size = new System.Drawing.Size(476, 576);
            this.gb1.TabIndex = 20;
            this.gb1.TabStop = false;
            this.gb1.Text = "Shto Kategori";
            // 
            // btnClose
            // 
            this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClose.BackColor = System.Drawing.Color.Transparent;
            this.btnClose.Image = ((System.Drawing.Image)(resources.GetObject("btnClose.Image")));
            this.btnClose.ImageActive = null;
            this.btnClose.Location = new System.Drawing.Point(420, 21);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(38, 38);
            this.btnClose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnClose.TabIndex = 27;
            this.btnClose.TabStop = false;
            this.btnClose.Zoom = 10;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // lblID
            // 
            this.lblID.AutoSize = true;
            this.lblID.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblID.Location = new System.Drawing.Point(61, 71);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(31, 20);
            this.lblID.TabIndex = 26;
            this.lblID.Text = "ID:";
            // 
            // dgvCategories
            // 
            this.dgvCategories.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCategories.Location = new System.Drawing.Point(64, 238);
            this.dgvCategories.Name = "dgvCategories";
            this.dgvCategories.RowTemplate.Height = 24;
            this.dgvCategories.Size = new System.Drawing.Size(324, 307);
            this.dgvCategories.TabIndex = 25;
            this.dgvCategories.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvCategories_RowHeaderMouseClick);
            // 
            // txtID
            // 
            this.txtID.Enabled = false;
            this.txtID.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtID.Location = new System.Drawing.Point(170, 68);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(218, 26);
            this.txtID.TabIndex = 23;
            // 
            // txtKategoria
            // 
            this.txtKategoria.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtKategoria.Location = new System.Drawing.Point(170, 119);
            this.txtKategoria.Name = "txtKategoria";
            this.txtKategoria.Size = new System.Drawing.Size(218, 26);
            this.txtKategoria.TabIndex = 24;
            this.txtKategoria.TextChanged += new System.EventHandler(this.txtKategoria_TextChanged);
            // 
            // lblKategoria
            // 
            this.lblKategoria.AutoSize = true;
            this.lblKategoria.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblKategoria.Location = new System.Drawing.Point(60, 125);
            this.lblKategoria.Name = "lblKategoria";
            this.lblKategoria.Size = new System.Drawing.Size(85, 20);
            this.lblKategoria.TabIndex = 22;
            this.lblKategoria.Text = "Kategoria:";
            // 
            // btnDelete
            // 
            this.btnDelete.Activecolor = System.Drawing.Color.LightCoral;
            this.btnDelete.BackColor = System.Drawing.Color.DarkRed;
            this.btnDelete.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnDelete.BorderRadius = 0;
            this.btnDelete.ButtonText = "             ";
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
            this.btnDelete.Location = new System.Drawing.Point(328, 173);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Normalcolor = System.Drawing.Color.DarkRed;
            this.btnDelete.OnHovercolor = System.Drawing.Color.LightCoral;
            this.btnDelete.OnHoverTextColor = System.Drawing.Color.Black;
            this.btnDelete.selected = false;
            this.btnDelete.Size = new System.Drawing.Size(60, 58);
            this.btnDelete.TabIndex = 21;
            this.btnDelete.Text = "             ";
            this.btnDelete.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDelete.Textcolor = System.Drawing.Color.White;
            this.btnDelete.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnShto
            // 
            this.btnShto.Activecolor = System.Drawing.Color.Lime;
            this.btnShto.BackColor = System.Drawing.Color.Green;
            this.btnShto.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnShto.BorderRadius = 0;
            this.btnShto.ButtonText = "            ";
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
            this.btnShto.Location = new System.Drawing.Point(64, 173);
            this.btnShto.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnShto.Name = "btnShto";
            this.btnShto.Normalcolor = System.Drawing.Color.Green;
            this.btnShto.OnHovercolor = System.Drawing.Color.Lime;
            this.btnShto.OnHoverTextColor = System.Drawing.Color.Black;
            this.btnShto.selected = false;
            this.btnShto.Size = new System.Drawing.Size(59, 58);
            this.btnShto.TabIndex = 20;
            this.btnShto.Text = "            ";
            this.btnShto.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnShto.Textcolor = System.Drawing.Color.White;
            this.btnShto.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnShto.Click += new System.EventHandler(this.btnShto_Click);
            // 
            // AddCategoryForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(500, 600);
            this.Controls.Add(this.gb1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Location = new System.Drawing.Point(350, 315);
            this.Name = "AddCategoryForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "AddCategoryForm";
            this.Load += new System.EventHandler(this.AddCategoryForm_Load);
            this.gb1.ResumeLayout(false);
            this.gb1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnClose)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCategories)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gb1;
        private Bunifu.Framework.UI.BunifuImageButton btnClose;
        private System.Windows.Forms.Label lblID;
        private System.Windows.Forms.DataGridView dgvCategories;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.TextBox txtKategoria;
        private System.Windows.Forms.Label lblKategoria;
        private Bunifu.Framework.UI.BunifuFlatButton btnDelete;
        private Bunifu.Framework.UI.BunifuFlatButton btnShto;
    }
}