
namespace VentaDeMiel2022.Windows
{
    partial class FrmProvinciaAE
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
            this.components = new System.ComponentModel.Container();
            this.ProvinciaTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.CancelarIconButton = new System.Windows.Forms.Button();
            this.GuardarIconButton = new System.Windows.Forms.Button();
            this.PaisComboBox = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // ProvinciaTextBox
            // 
            this.ProvinciaTextBox.Font = new System.Drawing.Font("Tahoma", 10.8F);
            this.ProvinciaTextBox.Location = new System.Drawing.Point(118, 42);
            this.ProvinciaTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.ProvinciaTextBox.MaxLength = 120;
            this.ProvinciaTextBox.Name = "ProvinciaTextBox";
            this.ProvinciaTextBox.Size = new System.Drawing.Size(349, 29);
            this.ProvinciaTextBox.TabIndex = 0;
            this.ProvinciaTextBox.TextChanged += new System.EventHandler(this.ProvinciaTextBox_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 10.8F);
            this.label1.Location = new System.Drawing.Point(27, 42);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 23);
            this.label1.TabIndex = 9;
            this.label1.Text = "Provincia:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // CancelarIconButton
            // 
            this.CancelarIconButton.Location = new System.Drawing.Point(282, 182);
            this.CancelarIconButton.Name = "CancelarIconButton";
            this.CancelarIconButton.Size = new System.Drawing.Size(164, 57);
            this.CancelarIconButton.TabIndex = 3;
            this.CancelarIconButton.Text = "Cancelar";
            this.CancelarIconButton.UseVisualStyleBackColor = true;
            this.CancelarIconButton.Click += new System.EventHandler(this.CancelarIconButton_Click);
            // 
            // GuardarIconButton
            // 
            this.GuardarIconButton.Location = new System.Drawing.Point(46, 182);
            this.GuardarIconButton.Name = "GuardarIconButton";
            this.GuardarIconButton.Size = new System.Drawing.Size(164, 57);
            this.GuardarIconButton.TabIndex = 2;
            this.GuardarIconButton.Text = "Guardar";
            this.GuardarIconButton.UseVisualStyleBackColor = true;
            this.GuardarIconButton.Click += new System.EventHandler(this.GuardarIconButton_Click);
            // 
            // PaisComboBox
            // 
            this.PaisComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.PaisComboBox.Font = new System.Drawing.Font("Tahoma", 10.8F);
            this.PaisComboBox.FormattingEnabled = true;
            this.PaisComboBox.Location = new System.Drawing.Point(118, 91);
            this.PaisComboBox.Name = "PaisComboBox";
            this.PaisComboBox.Size = new System.Drawing.Size(349, 30);
            this.PaisComboBox.TabIndex = 1;
            this.PaisComboBox.SelectedIndexChanged += new System.EventHandler(this.PaisComboBox_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 10.8F);
            this.label2.Location = new System.Drawing.Point(63, 91);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 23);
            this.label2.TabIndex = 14;
            this.label2.Text = "Pais:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // FrmProvinciaAE
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(512, 272);
            this.ControlBox = false;
            this.Controls.Add(this.label2);
            this.Controls.Add(this.PaisComboBox);
            this.Controls.Add(this.ProvinciaTextBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.CancelarIconButton);
            this.Controls.Add(this.GuardarIconButton);
            this.Font = new System.Drawing.Font("Tahoma", 10.8F);
            this.Name = "FrmProvinciaAE";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.FrmProvinciaAE_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox ProvinciaTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.Button CancelarIconButton;
        private System.Windows.Forms.Button GuardarIconButton;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox PaisComboBox;
    }
}