namespace Terminplaner
{
    partial class Hauptform
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.new_bt = new System.Windows.Forms.Button();
            this.gridView = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.user_name = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.terminBox = new System.Windows.Forms.ComboBox();
            this.titleDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ortDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.startDatumDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.endDatumDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tempTypeNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.terminBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.gridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.terminBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // new_bt
            // 
            this.new_bt.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.new_bt.BackColor = System.Drawing.SystemColors.ControlLight;
            this.new_bt.Location = new System.Drawing.Point(722, 12);
            this.new_bt.Name = "new_bt";
            this.new_bt.Size = new System.Drawing.Size(50, 23);
            this.new_bt.TabIndex = 0;
            this.new_bt.Text = "NEU!";
            this.new_bt.UseVisualStyleBackColor = false;
            this.new_bt.Click += new System.EventHandler(this.new_bt_Click);
            // 
            // gridView
            // 
            this.gridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gridView.AutoGenerateColumns = false;
            this.gridView.BackgroundColor = System.Drawing.Color.MintCream;
            this.gridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.titleDataGridViewTextBoxColumn,
            this.ortDataGridViewTextBoxColumn,
            this.startDatumDataGridViewTextBoxColumn,
            this.endDatumDataGridViewTextBoxColumn,
            this.tempTypeNameDataGridViewTextBoxColumn});
            this.gridView.DataSource = this.terminBindingSource;
            this.gridView.Location = new System.Drawing.Point(16, 41);
            this.gridView.MultiSelect = false;
            this.gridView.Name = "gridView";
            this.gridView.ReadOnly = true;
            this.gridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gridView.Size = new System.Drawing.Size(756, 290);
            this.gridView.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 17);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Eingeloggt als: ";
            // 
            // user_name
            // 
            this.user_name.AutoSize = true;
            this.user_name.Location = new System.Drawing.Point(98, 17);
            this.user_name.Name = "user_name";
            this.user_name.Size = new System.Drawing.Size(0, 13);
            this.user_name.TabIndex = 8;
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.Location = new System.Drawing.Point(552, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 9;
            this.button1.Text = "Filtern";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button2.Location = new System.Drawing.Point(633, 12);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 10;
            this.button2.Text = "Löschen";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // terminBox
            // 
            this.terminBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.terminBox.FormattingEnabled = true;
            this.terminBox.Location = new System.Drawing.Point(425, 14);
            this.terminBox.Name = "terminBox";
            this.terminBox.Size = new System.Drawing.Size(121, 21);
            this.terminBox.TabIndex = 11;
            // 
            // titleDataGridViewTextBoxColumn
            // 
            this.titleDataGridViewTextBoxColumn.DataPropertyName = "Title";
            this.titleDataGridViewTextBoxColumn.HeaderText = "Title";
            this.titleDataGridViewTextBoxColumn.Name = "titleDataGridViewTextBoxColumn";
            this.titleDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // ortDataGridViewTextBoxColumn
            // 
            this.ortDataGridViewTextBoxColumn.DataPropertyName = "Ort";
            this.ortDataGridViewTextBoxColumn.HeaderText = "Ort";
            this.ortDataGridViewTextBoxColumn.Name = "ortDataGridViewTextBoxColumn";
            this.ortDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // startDatumDataGridViewTextBoxColumn
            // 
            this.startDatumDataGridViewTextBoxColumn.DataPropertyName = "StartDatum";
            this.startDatumDataGridViewTextBoxColumn.HeaderText = "StartDatum";
            this.startDatumDataGridViewTextBoxColumn.Name = "startDatumDataGridViewTextBoxColumn";
            this.startDatumDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // endDatumDataGridViewTextBoxColumn
            // 
            this.endDatumDataGridViewTextBoxColumn.DataPropertyName = "EndDatum";
            this.endDatumDataGridViewTextBoxColumn.HeaderText = "EndDatum";
            this.endDatumDataGridViewTextBoxColumn.Name = "endDatumDataGridViewTextBoxColumn";
            this.endDatumDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // tempTypeNameDataGridViewTextBoxColumn
            // 
            this.tempTypeNameDataGridViewTextBoxColumn.DataPropertyName = "TempTypeName";
            this.tempTypeNameDataGridViewTextBoxColumn.HeaderText = "Termintyp";
            this.tempTypeNameDataGridViewTextBoxColumn.Name = "tempTypeNameDataGridViewTextBoxColumn";
            this.tempTypeNameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // terminBindingSource
            // 
            this.terminBindingSource.DataSource = typeof(Terminplaner.Termin);
            // 
            // Hauptform
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(784, 343);
            this.Controls.Add(this.terminBox);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.user_name);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.gridView);
            this.Controls.Add(this.new_bt);
            this.Enabled = false;
            this.Name = "Hauptform";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Terminplaner";
            this.WindowState = System.Windows.Forms.FormWindowState.Minimized;
            this.Load += new System.EventHandler(this.Hauptform_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.terminBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button new_bt;
        private System.Windows.Forms.DataGridView gridView;
        private System.Windows.Forms.Label label2;
        public System.Windows.Forms.Label user_name;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridViewTextBoxColumn titleDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ortDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn startDatumDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn endDatumDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tempTypeNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource terminBindingSource;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ComboBox terminBox;
    }
}

