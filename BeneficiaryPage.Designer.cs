﻿namespace Sistema_de_Cheques
{
    partial class BeneficiaryPage
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
			this.label1 = new System.Windows.Forms.Label();
			this.txtName = new System.Windows.Forms.TextBox();
			this.txtPhone = new System.Windows.Forms.TextBox();
			this.txtAddress = new System.Windows.Forms.TextBox();
			this.txtDescription = new System.Windows.Forms.TextBox();
			this.btnDepositar = new System.Windows.Forms.Button();
			this.btnAdd = new System.Windows.Forms.Button();
			this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Celular = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Dirección = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Descripción = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Estado = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.button1 = new System.Windows.Forms.Button();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.beneficiariesTable = new System.Windows.Forms.DataGridView();
			this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.name = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.address = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.active = new System.Windows.Forms.DataGridViewTextBoxColumn();
			((System.ComponentModel.ISupportInitialize)(this.beneficiariesTable)).BeginInit();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
			this.label1.Location = new System.Drawing.Point(34, 17);
			this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(156, 20);
			this.label1.TabIndex = 0;
			this.label1.Text = "Datos del beneficiario";
			// 
			// txtName
			// 
			this.txtName.BackColor = System.Drawing.Color.White;
			this.txtName.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.txtName.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.txtName.ForeColor = System.Drawing.Color.Black;
			this.txtName.Location = new System.Drawing.Point(103, 47);
			this.txtName.Margin = new System.Windows.Forms.Padding(2);
			this.txtName.MaxLength = 50;
			this.txtName.Name = "txtName";
			this.txtName.Size = new System.Drawing.Size(244, 20);
			this.txtName.TabIndex = 2;
			// 
			// txtPhone
			// 
			this.txtPhone.BackColor = System.Drawing.Color.White;
			this.txtPhone.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.txtPhone.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.txtPhone.ForeColor = System.Drawing.Color.Black;
			this.txtPhone.Location = new System.Drawing.Point(103, 82);
			this.txtPhone.Margin = new System.Windows.Forms.Padding(2);
			this.txtPhone.MaxLength = 16;
			this.txtPhone.Name = "txtPhone";
			this.txtPhone.Size = new System.Drawing.Size(244, 20);
			this.txtPhone.TabIndex = 4;
			// 
			// txtAddress
			// 
			this.txtAddress.BackColor = System.Drawing.Color.White;
			this.txtAddress.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.txtAddress.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.txtAddress.ForeColor = System.Drawing.Color.Black;
			this.txtAddress.Location = new System.Drawing.Point(433, 47);
			this.txtAddress.Margin = new System.Windows.Forms.Padding(2);
			this.txtAddress.MaxLength = 80;
			this.txtAddress.Name = "txtAddress";
			this.txtAddress.Size = new System.Drawing.Size(297, 20);
			this.txtAddress.TabIndex = 3;
			// 
			// txtDescription
			// 
			this.txtDescription.BackColor = System.Drawing.Color.White;
			this.txtDescription.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.txtDescription.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.txtDescription.ForeColor = System.Drawing.Color.Black;
			this.txtDescription.Location = new System.Drawing.Point(433, 82);
			this.txtDescription.Margin = new System.Windows.Forms.Padding(2);
			this.txtDescription.MaxLength = 60;
			this.txtDescription.Name = "txtDescription";
			this.txtDescription.Size = new System.Drawing.Size(297, 20);
			this.txtDescription.TabIndex = 5;
			// 
			// btnDepositar
			// 
			this.btnDepositar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
			this.btnDepositar.FlatAppearance.BorderSize = 0;
			this.btnDepositar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
			this.btnDepositar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
			this.btnDepositar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnDepositar.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.btnDepositar.ForeColor = System.Drawing.Color.Gainsboro;
			this.btnDepositar.Location = new System.Drawing.Point(310, 117);
			this.btnDepositar.Margin = new System.Windows.Forms.Padding(2);
			this.btnDepositar.Name = "btnDepositar";
			this.btnDepositar.Size = new System.Drawing.Size(161, 25);
			this.btnDepositar.TabIndex = 16;
			this.btnDepositar.Text = "Cancelar";
			this.btnDepositar.UseVisualStyleBackColor = false;
			this.btnDepositar.Click += new System.EventHandler(this.btnDepositar_Click);
			// 
			// btnAdd
			// 
			this.btnAdd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
			this.btnAdd.FlatAppearance.BorderSize = 0;
			this.btnAdd.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
			this.btnAdd.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
			this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnAdd.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.btnAdd.ForeColor = System.Drawing.Color.Gainsboro;
			this.btnAdd.Location = new System.Drawing.Point(34, 117);
			this.btnAdd.Margin = new System.Windows.Forms.Padding(2);
			this.btnAdd.Name = "btnAdd";
			this.btnAdd.Size = new System.Drawing.Size(156, 25);
			this.btnAdd.TabIndex = 6;
			this.btnAdd.Text = "Agregar";
			this.btnAdd.UseVisualStyleBackColor = false;
			this.btnAdd.Click += new System.EventHandler(this.btnActualizar_Click);
			// 
			// Id
			// 
			this.Id.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
			this.Id.HeaderText = "Id";
			this.Id.MinimumWidth = 8;
			this.Id.Name = "Id";
			// 
			// Nombre
			// 
			this.Nombre.HeaderText = "Nombre";
			this.Nombre.MinimumWidth = 8;
			this.Nombre.Name = "Nombre";
			this.Nombre.Width = 150;
			// 
			// Celular
			// 
			this.Celular.HeaderText = "Celular";
			this.Celular.MinimumWidth = 8;
			this.Celular.Name = "Celular";
			this.Celular.Width = 150;
			// 
			// Dirección
			// 
			this.Dirección.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
			this.Dirección.HeaderText = "Dirección";
			this.Dirección.MinimumWidth = 8;
			this.Dirección.Name = "Dirección";
			// 
			// Descripción
			// 
			this.Descripción.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
			this.Descripción.HeaderText = "Descripción";
			this.Descripción.MinimumWidth = 8;
			this.Descripción.Name = "Descripción";
			// 
			// Estado
			// 
			this.Estado.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
			this.Estado.HeaderText = "Estado";
			this.Estado.MinimumWidth = 8;
			this.Estado.Name = "Estado";
			// 
			// button1
			// 
			this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
			this.button1.FlatAppearance.BorderSize = 0;
			this.button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
			this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
			this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.button1.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.button1.ForeColor = System.Drawing.Color.Gainsboro;
			this.button1.Location = new System.Drawing.Point(580, 117);
			this.button1.Margin = new System.Windows.Forms.Padding(2);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(150, 25);
			this.button1.TabIndex = 19;
			this.button1.Text = "Buscar";
			this.button1.UseVisualStyleBackColor = false;
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
			this.label2.Location = new System.Drawing.Point(34, 50);
			this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(51, 15);
			this.label2.TabIndex = 20;
			this.label2.Text = "Nombre";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
			this.label3.Location = new System.Drawing.Point(34, 85);
			this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(44, 15);
			this.label3.TabIndex = 21;
			this.label3.Text = "Celular";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
			this.label4.Location = new System.Drawing.Point(367, 48);
			this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(57, 15);
			this.label4.TabIndex = 22;
			this.label4.Text = "Dirección";
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
			this.label5.Location = new System.Drawing.Point(358, 83);
			this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(69, 15);
			this.label5.TabIndex = 23;
			this.label5.Text = "Descripción";
			// 
			// beneficiariesTable
			// 
			this.beneficiariesTable.ColumnHeadersHeight = 34;
			this.beneficiariesTable.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.name,
            this.address,
            this.active});
			this.beneficiariesTable.Location = new System.Drawing.Point(34, 156);
			this.beneficiariesTable.Margin = new System.Windows.Forms.Padding(2);
			this.beneficiariesTable.Name = "beneficiariesTable";
			this.beneficiariesTable.RowHeadersWidth = 62;
			this.beneficiariesTable.Size = new System.Drawing.Size(732, 282);
			this.beneficiariesTable.TabIndex = 25;
			this.beneficiariesTable.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.beneficiariesTable_CellContentClick_1);
			// 
			// dataGridViewTextBoxColumn1
			// 
			this.dataGridViewTextBoxColumn1.HeaderText = "Id";
			this.dataGridViewTextBoxColumn1.MinimumWidth = 8;
			this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
			this.dataGridViewTextBoxColumn1.ReadOnly = true;
			this.dataGridViewTextBoxColumn1.Width = 30;
			// 
			// name
			// 
			this.name.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
			this.name.FillWeight = 130F;
			this.name.HeaderText = "Nombre";
			this.name.MinimumWidth = 8;
			this.name.Name = "name";
			this.name.ReadOnly = true;
			// 
			// address
			// 
			this.address.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
			this.address.HeaderText = "Dirección";
			this.address.Name = "address";
			this.address.ReadOnly = true;
			// 
			// active
			// 
			this.active.HeaderText = "Estado";
			this.active.MinimumWidth = 8;
			this.active.Name = "active";
			this.active.ReadOnly = true;
			this.active.Width = 60;
			// 
			// BeneficiaryPage
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
			this.ClientSize = new System.Drawing.Size(808, 449);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.beneficiariesTable);
			this.Controls.Add(this.btnDepositar);
			this.Controls.Add(this.btnAdd);
			this.Controls.Add(this.txtDescription);
			this.Controls.Add(this.txtAddress);
			this.Controls.Add(this.txtPhone);
			this.Controls.Add(this.txtName);
			this.Controls.Add(this.label1);
			this.Margin = new System.Windows.Forms.Padding(2);
			this.Name = "BeneficiaryPage";
			this.Text = "Beneficiarios";
			this.Load += new System.EventHandler(this.Form2_Load);
			((System.ComponentModel.ISupportInitialize)(this.beneficiariesTable)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private Label label1;
        private TextBox txtName;
        private TextBox txtPhone;
        private TextBox txtAddress;
        private TextBox txtDescription;
        private Button btnDepositar;
        private Button btnAdd;
        private Button button1;
        private DataGridViewTextBoxColumn Id;
        private DataGridViewTextBoxColumn Nombre;
        private DataGridViewTextBoxColumn Celular;
        private DataGridViewTextBoxColumn Dirección;
        private DataGridViewTextBoxColumn Descripción;
        private DataGridViewTextBoxColumn Estado;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private DataGridView beneficiariesTable;
		private DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
		private DataGridViewTextBoxColumn name;
		private DataGridViewTextBoxColumn address;
		private DataGridViewTextBoxColumn active;
	}
}