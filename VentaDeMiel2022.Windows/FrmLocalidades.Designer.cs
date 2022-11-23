
namespace VentaDeMiel2022.Windows
{
    partial class FrmLocalidades
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
            this.NuevoIconButton = new System.Windows.Forms.Button();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.PrecioDescIconButton = new FontAwesome.Sharp.IconButton();
            this.OredenarAZPorProductoiconButton = new FontAwesome.Sharp.IconButton();
            this.FiltrariconButton = new FontAwesome.Sharp.IconButton();
            this.CerrarButton = new System.Windows.Forms.Button();
            this.EditarIconButton = new System.Windows.Forms.Button();
            this.BorrarIconButton = new System.Windows.Forms.Button();
            this.DatosDataGridView = new System.Windows.Forms.DataGridView();
            this.colLocalidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colProvincia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DatosDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // NuevoIconButton
            // 
            this.NuevoIconButton.Location = new System.Drawing.Point(6, 10);
            this.NuevoIconButton.Name = "NuevoIconButton";
            this.NuevoIconButton.Size = new System.Drawing.Size(83, 69);
            this.NuevoIconButton.TabIndex = 0;
            this.NuevoIconButton.Text = "Nuevo";
            this.NuevoIconButton.UseVisualStyleBackColor = true;
            this.NuevoIconButton.Click += new System.EventHandler(this.NuevoIconButton_Click);
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Margin = new System.Windows.Forms.Padding(4);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.PrecioDescIconButton);
            this.splitContainer1.Panel1.Controls.Add(this.OredenarAZPorProductoiconButton);
            this.splitContainer1.Panel1.Controls.Add(this.FiltrariconButton);
            this.splitContainer1.Panel1.Controls.Add(this.CerrarButton);
            this.splitContainer1.Panel1.Controls.Add(this.EditarIconButton);
            this.splitContainer1.Panel1.Controls.Add(this.BorrarIconButton);
            this.splitContainer1.Panel1.Controls.Add(this.NuevoIconButton);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.DatosDataGridView);
            this.splitContainer1.Size = new System.Drawing.Size(1053, 498);
            this.splitContainer1.SplitterDistance = 90;
            this.splitContainer1.SplitterWidth = 5;
            this.splitContainer1.TabIndex = 6;
            // 
            // PrecioDescIconButton
            // 
            this.PrecioDescIconButton.BackColor = System.Drawing.Color.Transparent;
            this.PrecioDescIconButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.PrecioDescIconButton.IconChar = FontAwesome.Sharp.IconChar.SortAlphaDown;
            this.PrecioDescIconButton.IconColor = System.Drawing.Color.DodgerBlue;
            this.PrecioDescIconButton.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.PrecioDescIconButton.Location = new System.Drawing.Point(485, 12);
            this.PrecioDescIconButton.Margin = new System.Windows.Forms.Padding(4);
            this.PrecioDescIconButton.Name = "PrecioDescIconButton";
            this.PrecioDescIconButton.Size = new System.Drawing.Size(93, 71);
            this.PrecioDescIconButton.TabIndex = 11;
            this.PrecioDescIconButton.Text = "Z-A";
            this.PrecioDescIconButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.PrecioDescIconButton.UseVisualStyleBackColor = false;
            this.PrecioDescIconButton.Click += new System.EventHandler(this.PrecioDescIconButton_Click);
            // 
            // OredenarAZPorProductoiconButton
            // 
            this.OredenarAZPorProductoiconButton.BackColor = System.Drawing.Color.Transparent;
            this.OredenarAZPorProductoiconButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.OredenarAZPorProductoiconButton.IconChar = FontAwesome.Sharp.IconChar.SortAlphaDown;
            this.OredenarAZPorProductoiconButton.IconColor = System.Drawing.Color.DodgerBlue;
            this.OredenarAZPorProductoiconButton.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.OredenarAZPorProductoiconButton.Location = new System.Drawing.Point(384, 12);
            this.OredenarAZPorProductoiconButton.Margin = new System.Windows.Forms.Padding(4);
            this.OredenarAZPorProductoiconButton.Name = "OredenarAZPorProductoiconButton";
            this.OredenarAZPorProductoiconButton.Size = new System.Drawing.Size(93, 71);
            this.OredenarAZPorProductoiconButton.TabIndex = 14;
            this.OredenarAZPorProductoiconButton.Text = "A-Z";
            this.OredenarAZPorProductoiconButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.OredenarAZPorProductoiconButton.UseVisualStyleBackColor = false;
            this.OredenarAZPorProductoiconButton.Click += new System.EventHandler(this.OredenarAZPorProductoiconButton_Click);
            // 
            // FiltrariconButton
            // 
            this.FiltrariconButton.BackColor = System.Drawing.Color.Transparent;
            this.FiltrariconButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.FiltrariconButton.IconChar = FontAwesome.Sharp.IconChar.Filter;
            this.FiltrariconButton.IconColor = System.Drawing.Color.Blue;
            this.FiltrariconButton.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.FiltrariconButton.Location = new System.Drawing.Point(272, 11);
            this.FiltrariconButton.Margin = new System.Windows.Forms.Padding(4);
            this.FiltrariconButton.Name = "FiltrariconButton";
            this.FiltrariconButton.Size = new System.Drawing.Size(104, 72);
            this.FiltrariconButton.TabIndex = 10;
            this.FiltrariconButton.Text = "Filtrar";
            this.FiltrariconButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.FiltrariconButton.UseVisualStyleBackColor = false;
            this.FiltrariconButton.Click += new System.EventHandler(this.FiltrariconButton_Click);
            // 
            // CerrarButton
            // 
            this.CerrarButton.Location = new System.Drawing.Point(962, 10);
            this.CerrarButton.Name = "CerrarButton";
            this.CerrarButton.Size = new System.Drawing.Size(83, 71);
            this.CerrarButton.TabIndex = 3;
            this.CerrarButton.Text = "Cerrar";
            this.CerrarButton.UseVisualStyleBackColor = true;
            this.CerrarButton.Click += new System.EventHandler(this.CerrarButton_Click_1);
            // 
            // EditarIconButton
            // 
            this.EditarIconButton.Location = new System.Drawing.Point(184, 10);
            this.EditarIconButton.Name = "EditarIconButton";
            this.EditarIconButton.Size = new System.Drawing.Size(83, 69);
            this.EditarIconButton.TabIndex = 2;
            this.EditarIconButton.Text = "Editar";
            this.EditarIconButton.UseVisualStyleBackColor = true;
            this.EditarIconButton.Click += new System.EventHandler(this.EditarIconButton_Click);
            // 
            // BorrarIconButton
            // 
            this.BorrarIconButton.Location = new System.Drawing.Point(95, 10);
            this.BorrarIconButton.Name = "BorrarIconButton";
            this.BorrarIconButton.Size = new System.Drawing.Size(83, 69);
            this.BorrarIconButton.TabIndex = 1;
            this.BorrarIconButton.Text = "Borrar";
            this.BorrarIconButton.UseVisualStyleBackColor = true;
            this.BorrarIconButton.Click += new System.EventHandler(this.BorrarIconButton_Click);
            // 
            // DatosDataGridView
            // 
            this.DatosDataGridView.AllowUserToAddRows = false;
            this.DatosDataGridView.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.DatosDataGridView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Tahoma", 10.8F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.Padding = new System.Windows.Forms.Padding(2);
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DatosDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.DatosDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DatosDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colLocalidad,
            this.colProvincia});
            this.DatosDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DatosDataGridView.Location = new System.Drawing.Point(0, 0);
            this.DatosDataGridView.Margin = new System.Windows.Forms.Padding(4);
            this.DatosDataGridView.MultiSelect = false;
            this.DatosDataGridView.Name = "DatosDataGridView";
            this.DatosDataGridView.ReadOnly = true;
            this.DatosDataGridView.RowHeadersWidth = 51;
            this.DatosDataGridView.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DatosDataGridView.RowTemplate.Height = 28;
            this.DatosDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DatosDataGridView.Size = new System.Drawing.Size(1053, 403);
            this.DatosDataGridView.TabIndex = 0;
            // 
            // colLocalidad
            // 
            this.colLocalidad.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colLocalidad.HeaderText = "Localidad";
            this.colLocalidad.MinimumWidth = 6;
            this.colLocalidad.Name = "colLocalidad";
            this.colLocalidad.ReadOnly = true;
            this.colLocalidad.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // colProvincia
            // 
            this.colProvincia.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colProvincia.HeaderText = "Provincia";
            this.colProvincia.MinimumWidth = 6;
            this.colProvincia.Name = "colProvincia";
            this.colProvincia.ReadOnly = true;
            this.colProvincia.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // FrmLocalidades
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(1053, 498);
            this.ControlBox = false;
            this.Controls.Add(this.splitContainer1);
            this.Font = new System.Drawing.Font("Tahoma", 10.8F);
            this.Name = "FrmLocalidades";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.FrmLocalidades_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DatosDataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button NuevoIconButton;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private FontAwesome.Sharp.IconButton PrecioDescIconButton;
        private FontAwesome.Sharp.IconButton OredenarAZPorProductoiconButton;
        private FontAwesome.Sharp.IconButton FiltrariconButton;
        private System.Windows.Forms.Button CerrarButton;
        private System.Windows.Forms.Button EditarIconButton;
        private System.Windows.Forms.Button BorrarIconButton;
        private System.Windows.Forms.DataGridView DatosDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn colLocalidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn colProvincia;
    }
}