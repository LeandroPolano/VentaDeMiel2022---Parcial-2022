
namespace VentaDeMiel2022.Windows
{
    partial class FrmPais
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
            this.OrdenarPrecioAsciIconButton = new FontAwesome.Sharp.IconButton();
            this.OrdenarZAPorProductoiconButton = new FontAwesome.Sharp.IconButton();
            this.OredenarAZPorProductoiconButton = new FontAwesome.Sharp.IconButton();
            this.FiltrariconButton = new FontAwesome.Sharp.IconButton();
            this.CerrarButton = new System.Windows.Forms.Button();
            this.EditarIconButton = new System.Windows.Forms.Button();
            this.BorrarIconButton = new System.Windows.Forms.Button();
            this.DatosDataGridView = new System.Windows.Forms.DataGridView();
            this.colPais = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DatosDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // NuevoIconButton
            // 
            this.NuevoIconButton.Location = new System.Drawing.Point(3, 4);
            this.NuevoIconButton.Name = "NuevoIconButton";
            this.NuevoIconButton.Size = new System.Drawing.Size(83, 77);
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
            this.splitContainer1.Panel1.Controls.Add(this.OrdenarPrecioAsciIconButton);
            this.splitContainer1.Panel1.Controls.Add(this.OrdenarZAPorProductoiconButton);
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
            this.splitContainer1.Size = new System.Drawing.Size(942, 477);
            this.splitContainer1.SplitterDistance = 83;
            this.splitContainer1.SplitterWidth = 5;
            this.splitContainer1.TabIndex = 3;
            // 
            // PrecioDescIconButton
            // 
            this.PrecioDescIconButton.BackColor = System.Drawing.Color.Transparent;
            this.PrecioDescIconButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.PrecioDescIconButton.IconChar = FontAwesome.Sharp.IconChar.SortNumericDesc;
            this.PrecioDescIconButton.IconColor = System.Drawing.Color.DodgerBlue;
            this.PrecioDescIconButton.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.PrecioDescIconButton.Location = new System.Drawing.Point(625, 4);
            this.PrecioDescIconButton.Margin = new System.Windows.Forms.Padding(4);
            this.PrecioDescIconButton.Name = "PrecioDescIconButton";
            this.PrecioDescIconButton.Size = new System.Drawing.Size(93, 76);
            this.PrecioDescIconButton.TabIndex = 6;
            this.PrecioDescIconButton.Text = " Asc";
            this.PrecioDescIconButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.PrecioDescIconButton.UseVisualStyleBackColor = false;
            // 
            // OrdenarPrecioAsciIconButton
            // 
            this.OrdenarPrecioAsciIconButton.BackColor = System.Drawing.Color.Transparent;
            this.OrdenarPrecioAsciIconButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.OrdenarPrecioAsciIconButton.IconChar = FontAwesome.Sharp.IconChar.ArrowDown19;
            this.OrdenarPrecioAsciIconButton.IconColor = System.Drawing.Color.DodgerBlue;
            this.OrdenarPrecioAsciIconButton.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.OrdenarPrecioAsciIconButton.Location = new System.Drawing.Point(726, 5);
            this.OrdenarPrecioAsciIconButton.Margin = new System.Windows.Forms.Padding(4);
            this.OrdenarPrecioAsciIconButton.Name = "OrdenarPrecioAsciIconButton";
            this.OrdenarPrecioAsciIconButton.Size = new System.Drawing.Size(93, 75);
            this.OrdenarPrecioAsciIconButton.TabIndex = 7;
            this.OrdenarPrecioAsciIconButton.Text = " Asc";
            this.OrdenarPrecioAsciIconButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.OrdenarPrecioAsciIconButton.UseVisualStyleBackColor = false;
            // 
            // OrdenarZAPorProductoiconButton
            // 
            this.OrdenarZAPorProductoiconButton.BackColor = System.Drawing.Color.Transparent;
            this.OrdenarZAPorProductoiconButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.OrdenarZAPorProductoiconButton.IconChar = FontAwesome.Sharp.IconChar.SortAlphaDesc;
            this.OrdenarZAPorProductoiconButton.IconColor = System.Drawing.Color.DodgerBlue;
            this.OrdenarZAPorProductoiconButton.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.OrdenarZAPorProductoiconButton.Location = new System.Drawing.Point(423, 5);
            this.OrdenarZAPorProductoiconButton.Margin = new System.Windows.Forms.Padding(4);
            this.OrdenarZAPorProductoiconButton.Name = "OrdenarZAPorProductoiconButton";
            this.OrdenarZAPorProductoiconButton.Size = new System.Drawing.Size(93, 75);
            this.OrdenarZAPorProductoiconButton.TabIndex = 8;
            this.OrdenarZAPorProductoiconButton.Text = "Alfa Z-A";
            this.OrdenarZAPorProductoiconButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.OrdenarZAPorProductoiconButton.UseVisualStyleBackColor = false;
            // 
            // OredenarAZPorProductoiconButton
            // 
            this.OredenarAZPorProductoiconButton.BackColor = System.Drawing.Color.Transparent;
            this.OredenarAZPorProductoiconButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.OredenarAZPorProductoiconButton.IconChar = FontAwesome.Sharp.IconChar.SortAlphaDown;
            this.OredenarAZPorProductoiconButton.IconColor = System.Drawing.Color.DodgerBlue;
            this.OredenarAZPorProductoiconButton.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.OredenarAZPorProductoiconButton.Location = new System.Drawing.Point(524, 5);
            this.OredenarAZPorProductoiconButton.Margin = new System.Windows.Forms.Padding(4);
            this.OredenarAZPorProductoiconButton.Name = "OredenarAZPorProductoiconButton";
            this.OredenarAZPorProductoiconButton.Size = new System.Drawing.Size(93, 75);
            this.OredenarAZPorProductoiconButton.TabIndex = 9;
            this.OredenarAZPorProductoiconButton.Text = "Alfa A-Z";
            this.OredenarAZPorProductoiconButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.OredenarAZPorProductoiconButton.UseVisualStyleBackColor = false;
            // 
            // FiltrariconButton
            // 
            this.FiltrariconButton.BackColor = System.Drawing.Color.Transparent;
            this.FiltrariconButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.FiltrariconButton.IconChar = FontAwesome.Sharp.IconChar.Filter;
            this.FiltrariconButton.IconColor = System.Drawing.Color.Blue;
            this.FiltrariconButton.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.FiltrariconButton.Location = new System.Drawing.Point(296, 2);
            this.FiltrariconButton.Margin = new System.Windows.Forms.Padding(4);
            this.FiltrariconButton.Name = "FiltrariconButton";
            this.FiltrariconButton.Size = new System.Drawing.Size(104, 78);
            this.FiltrariconButton.TabIndex = 5;
            this.FiltrariconButton.Text = "Filtrar";
            this.FiltrariconButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.FiltrariconButton.UseVisualStyleBackColor = false;
            // 
            // CerrarButton
            // 
            this.CerrarButton.Location = new System.Drawing.Point(853, 3);
            this.CerrarButton.Name = "CerrarButton";
            this.CerrarButton.Size = new System.Drawing.Size(83, 75);
            this.CerrarButton.TabIndex = 3;
            this.CerrarButton.Text = "Cerrar";
            this.CerrarButton.UseVisualStyleBackColor = true;
            this.CerrarButton.Click += new System.EventHandler(this.CerrarButton_Click);
            // 
            // EditarIconButton
            // 
            this.EditarIconButton.Location = new System.Drawing.Point(181, 4);
            this.EditarIconButton.Name = "EditarIconButton";
            this.EditarIconButton.Size = new System.Drawing.Size(83, 77);
            this.EditarIconButton.TabIndex = 2;
            this.EditarIconButton.Text = "Editar";
            this.EditarIconButton.UseVisualStyleBackColor = true;
            this.EditarIconButton.Click += new System.EventHandler(this.EditarIconButton_Click);
            // 
            // BorrarIconButton
            // 
            this.BorrarIconButton.Location = new System.Drawing.Point(92, 4);
            this.BorrarIconButton.Name = "BorrarIconButton";
            this.BorrarIconButton.Size = new System.Drawing.Size(83, 77);
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
            this.colPais});
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
            this.DatosDataGridView.Size = new System.Drawing.Size(942, 389);
            this.DatosDataGridView.TabIndex = 0;
            // 
            // colPais
            // 
            this.colPais.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colPais.HeaderText = "Pais";
            this.colPais.MinimumWidth = 6;
            this.colPais.Name = "colPais";
            this.colPais.ReadOnly = true;
            this.colPais.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // FrmPais
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(942, 477);
            this.ControlBox = false;
            this.Controls.Add(this.splitContainer1);
            this.Font = new System.Drawing.Font("Tahoma", 10.8F);
            this.Name = "FrmPais";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.FrmPais_Load);
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
        private System.Windows.Forms.Button EditarIconButton;
        private System.Windows.Forms.Button BorrarIconButton;
        private System.Windows.Forms.DataGridView DatosDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPais;
        private System.Windows.Forms.Button CerrarButton;
        private FontAwesome.Sharp.IconButton PrecioDescIconButton;
        private FontAwesome.Sharp.IconButton OrdenarPrecioAsciIconButton;
        private FontAwesome.Sharp.IconButton OrdenarZAPorProductoiconButton;
        private FontAwesome.Sharp.IconButton OredenarAZPorProductoiconButton;
        private FontAwesome.Sharp.IconButton FiltrariconButton;
    }
}