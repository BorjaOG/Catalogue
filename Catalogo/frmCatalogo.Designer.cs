namespace Catalogo
{
    partial class frmCatalogo
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
            this.dgvArticulos = new System.Windows.Forms.DataGridView();
            this.pcbArticulo = new System.Windows.Forms.PictureBox();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.btnModify = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.lblFilter = new System.Windows.Forms.Label();
            this.txtFilter = new System.Windows.Forms.TextBox();
            this.btnFilter = new System.Windows.Forms.Button();
            this.lblcampo = new System.Windows.Forms.Label();
            this.lblCriterio = new System.Windows.Forms.Label();
            this.lblavanzado = new System.Windows.Forms.Label();
            this.cmbCampo = new System.Windows.Forms.ComboBox();
            this.cmbCriterio = new System.Windows.Forms.ComboBox();
            this.cmbAvanzado = new System.Windows.Forms.TextBox();
            this.btnDetail = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvArticulos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbArticulo)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvArticulos
            // 
            this.dgvArticulos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvArticulos.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvArticulos.Location = new System.Drawing.Point(38, 62);
            this.dgvArticulos.MultiSelect = false;
            this.dgvArticulos.Name = "dgvArticulos";
            this.dgvArticulos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvArticulos.Size = new System.Drawing.Size(643, 263);
            this.dgvArticulos.TabIndex = 0;
            this.dgvArticulos.SelectionChanged += new System.EventHandler(this.dgvArticulos_SelectionChanged);
            // 
            // pcbArticulo
            // 
            this.pcbArticulo.Location = new System.Drawing.Point(698, 62);
            this.pcbArticulo.Name = "pcbArticulo";
            this.pcbArticulo.Size = new System.Drawing.Size(242, 263);
            this.pcbArticulo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pcbArticulo.TabIndex = 1;
            this.pcbArticulo.TabStop = false;
            // 
            // btnAgregar
            // 
            this.btnAgregar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregar.Location = new System.Drawing.Point(181, 332);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(165, 34);
            this.btnAgregar.TabIndex = 1;
            this.btnAgregar.Text = "Add new article";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // btnModify
            // 
            this.btnModify.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModify.Location = new System.Drawing.Point(355, 331);
            this.btnModify.Name = "btnModify";
            this.btnModify.Size = new System.Drawing.Size(151, 34);
            this.btnModify.TabIndex = 3;
            this.btnModify.Text = "Modify article";
            this.btnModify.UseVisualStyleBackColor = true;
            this.btnModify.Click += new System.EventHandler(this.btnModify_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.ForeColor = System.Drawing.Color.IndianRed;
            this.btnDelete.Location = new System.Drawing.Point(541, 331);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(140, 34);
            this.btnDelete.TabIndex = 8;
            this.btnDelete.Text = "Delete article";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // lblFilter
            // 
            this.lblFilter.AutoSize = true;
            this.lblFilter.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFilter.Location = new System.Drawing.Point(38, 27);
            this.lblFilter.Name = "lblFilter";
            this.lblFilter.Size = new System.Drawing.Size(143, 20);
            this.lblFilter.TabIndex = 4;
            this.lblFilter.Text = "Search by name:";
            // 
            // txtFilter
            // 
            this.txtFilter.Location = new System.Drawing.Point(182, 27);
            this.txtFilter.Name = "txtFilter";
            this.txtFilter.Size = new System.Drawing.Size(277, 20);
            this.txtFilter.TabIndex = 2;
            this.txtFilter.TextChanged += new System.EventHandler(this.txtFilter_TextChanged);
            // 
            // btnFilter
            // 
            this.btnFilter.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFilter.Location = new System.Drawing.Point(847, 409);
            this.btnFilter.Name = "btnFilter";
            this.btnFilter.Size = new System.Drawing.Size(91, 28);
            this.btnFilter.TabIndex = 7;
            this.btnFilter.Text = "Search";
            this.btnFilter.UseVisualStyleBackColor = true;
            this.btnFilter.Click += new System.EventHandler(this.btnFilter_Click);
            // 
            // lblcampo
            // 
            this.lblcampo.AutoSize = true;
            this.lblcampo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblcampo.Location = new System.Drawing.Point(38, 417);
            this.lblcampo.Name = "lblcampo";
            this.lblcampo.Size = new System.Drawing.Size(53, 20);
            this.lblcampo.TabIndex = 7;
            this.lblcampo.Text = "Field:";
            // 
            // lblCriterio
            // 
            this.lblCriterio.AutoSize = true;
            this.lblCriterio.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCriterio.Location = new System.Drawing.Point(244, 416);
            this.lblCriterio.Name = "lblCriterio";
            this.lblCriterio.Size = new System.Drawing.Size(74, 20);
            this.lblCriterio.TabIndex = 9;
            this.lblCriterio.Text = "Column:";
            // 
            // lblavanzado
            // 
            this.lblavanzado.AutoSize = true;
            this.lblavanzado.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblavanzado.Location = new System.Drawing.Point(471, 415);
            this.lblavanzado.Name = "lblavanzado";
            this.lblavanzado.Size = new System.Drawing.Size(55, 20);
            this.lblavanzado.TabIndex = 11;
            this.lblavanzado.Text = "Filter:";
            // 
            // cmbCampo
            // 
            this.cmbCampo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCampo.FormattingEnabled = true;
            this.cmbCampo.Location = new System.Drawing.Point(107, 415);
            this.cmbCampo.Name = "cmbCampo";
            this.cmbCampo.Size = new System.Drawing.Size(121, 21);
            this.cmbCampo.TabIndex = 4;
            this.cmbCampo.SelectedIndexChanged += new System.EventHandler(this.cmbCampo_SelectedIndexChanged);
            // 
            // cmbCriterio
            // 
            this.cmbCriterio.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCriterio.FormattingEnabled = true;
            this.cmbCriterio.Location = new System.Drawing.Point(334, 415);
            this.cmbCriterio.Name = "cmbCriterio";
            this.cmbCriterio.Size = new System.Drawing.Size(121, 21);
            this.cmbCriterio.TabIndex = 5;
            // 
            // cmbAvanzado
            // 
            this.cmbAvanzado.Location = new System.Drawing.Point(542, 416);
            this.cmbAvanzado.Name = "cmbAvanzado";
            this.cmbAvanzado.Size = new System.Drawing.Size(122, 20);
            this.cmbAvanzado.TabIndex = 6;
            // 
            // btnDetail
            // 
            this.btnDetail.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDetail.Location = new System.Drawing.Point(38, 331);
            this.btnDetail.Name = "btnDetail";
            this.btnDetail.Size = new System.Drawing.Size(134, 33);
            this.btnDetail.TabIndex = 0;
            this.btnDetail.Text = "Details";
            this.btnDetail.UseVisualStyleBackColor = true;
            this.btnDetail.Click += new System.EventHandler(this.btnDetail_Click);
            // 
            // frmCatalogo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(961, 453);
            this.Controls.Add(this.btnDetail);
            this.Controls.Add(this.cmbAvanzado);
            this.Controls.Add(this.cmbCriterio);
            this.Controls.Add(this.cmbCampo);
            this.Controls.Add(this.lblavanzado);
            this.Controls.Add(this.lblCriterio);
            this.Controls.Add(this.lblcampo);
            this.Controls.Add(this.btnFilter);
            this.Controls.Add(this.txtFilter);
            this.Controls.Add(this.lblFilter);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnModify);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.pcbArticulo);
            this.Controls.Add(this.dgvArticulos);
            this.Name = "frmCatalogo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Catalogo";
            this.Load += new System.EventHandler(this.frmCatalogo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvArticulos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbArticulo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvArticulos;
        private System.Windows.Forms.PictureBox pcbArticulo;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Button btnModify;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Label lblFilter;
        private System.Windows.Forms.TextBox txtFilter;
        private System.Windows.Forms.Button btnFilter;
        private System.Windows.Forms.Label lblcampo;
        private System.Windows.Forms.Label lblCriterio;
        private System.Windows.Forms.Label lblavanzado;
        private System.Windows.Forms.ComboBox cmbCampo;
        private System.Windows.Forms.ComboBox cmbCriterio;
        private System.Windows.Forms.TextBox cmbAvanzado;
        private System.Windows.Forms.Button btnDetail;
    }
}

