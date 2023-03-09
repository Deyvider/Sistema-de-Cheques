namespace Sistema_de_Cheques
{
	partial class SelectAccount
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
			this.label5 = new System.Windows.Forms.Label();
			this.button1 = new System.Windows.Forms.Button();
			this.accountsTable = new System.Windows.Forms.DataGridView();
			this.UserName = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Balance = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.BankName = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.AccountNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.labelAccount = new System.Windows.Forms.Label();
			((System.ComponentModel.ISupportInitialize)(this.accountsTable)).BeginInit();
			this.SuspendLayout();
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Font = new System.Drawing.Font("Century Gothic", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
			this.label5.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
			this.label5.Location = new System.Drawing.Point(200, 9);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(426, 41);
			this.label5.TabIndex = 16;
			this.label5.Text = "Añade cuenta bancaria";
			// 
			// button1
			// 
			this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
			this.button1.FlatAppearance.BorderSize = 0;
			this.button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
			this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
			this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.button1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.button1.ForeColor = System.Drawing.Color.Gainsboro;
			this.button1.Location = new System.Drawing.Point(511, 333);
			this.button1.Margin = new System.Windows.Forms.Padding(2);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(190, 37);
			this.button1.TabIndex = 17;
			this.button1.Text = "Salir";
			this.button1.UseVisualStyleBackColor = false;
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// accountsTable
			// 
			this.accountsTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.accountsTable.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.UserName,
            this.Balance,
            this.BankName,
            this.AccountNumber,
            this.id});
			this.accountsTable.Location = new System.Drawing.Point(80, 72);
			this.accountsTable.Name = "accountsTable";
			this.accountsTable.RowTemplate.Height = 25;
			this.accountsTable.Size = new System.Drawing.Size(621, 256);
			this.accountsTable.TabIndex = 18;
			this.accountsTable.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.accountsTable_CellContentClick);
			// 
			// UserName
			// 
			this.UserName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
			this.UserName.HeaderText = "Nombre";
			this.UserName.Name = "UserName";
			this.UserName.ReadOnly = true;
			// 
			// Balance
			// 
			this.Balance.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
			this.Balance.FillWeight = 70F;
			this.Balance.HeaderText = "Balance";
			this.Balance.Name = "Balance";
			this.Balance.ReadOnly = true;
			// 
			// BankName
			// 
			this.BankName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
			this.BankName.HeaderText = "Banco";
			this.BankName.Name = "BankName";
			this.BankName.ReadOnly = true;
			// 
			// AccountNumber
			// 
			this.AccountNumber.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
			this.AccountNumber.FillWeight = 60F;
			this.AccountNumber.HeaderText = "Número de cuenta";
			this.AccountNumber.Name = "AccountNumber";
			this.AccountNumber.ReadOnly = true;
			// 
			// id
			// 
			this.id.HeaderText = "Id";
			this.id.Name = "id";
			this.id.ReadOnly = true;
			this.id.Visible = false;
			// 
			// labelAccount
			// 
			this.labelAccount.AutoSize = true;
			this.labelAccount.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
			this.labelAccount.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
			this.labelAccount.Location = new System.Drawing.Point(80, 344);
			this.labelAccount.Name = "labelAccount";
			this.labelAccount.Size = new System.Drawing.Size(163, 25);
			this.labelAccount.TabIndex = 19;
			this.labelAccount.Text = "Cuenta activa:";
			// 
			// SelectAccount
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.labelAccount);
			this.Controls.Add(this.accountsTable);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.label5);
			this.Name = "SelectAccount";
			this.Text = "Cuentas de usuario";
			this.Load += new System.EventHandler(this.SelectAccount_Load);
			((System.ComponentModel.ISupportInitialize)(this.accountsTable)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private Label label5;
		private Button button1;
		private DataGridView accountsTable;
		private Label labelAccount;
		private DataGridViewTextBoxColumn UserName;
		private DataGridViewTextBoxColumn Balance;
		private DataGridViewTextBoxColumn BankName;
		private DataGridViewTextBoxColumn AccountNumber;
		private DataGridViewTextBoxColumn id;
	}
}