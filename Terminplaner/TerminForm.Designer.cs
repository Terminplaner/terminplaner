namespace Terminplaner
{
    partial class TerminForm
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
<<<<<<< HEAD
            this.label7 = new System.Windows.Forms.Label();
            this.title_tb = new System.Windows.Forms.TextBox();
            this.start_dt = new System.Windows.Forms.DateTimePicker();
            this.ort_tb = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.ende_dt = new System.Windows.Forms.DateTimePicker();
            this.save_bt = new System.Windows.Forms.Button();
            this.exit = new System.Windows.Forms.Button();
            this.termintype = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(12, 9);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(27, 13);
            this.label7.TabIndex = 0;
            this.label7.Text = "Titel";
            // 
            // title_tb
            // 
            this.title_tb.Location = new System.Drawing.Point(12, 25);
            this.title_tb.Name = "title_tb";
            this.title_tb.Size = new System.Drawing.Size(200, 20);
            this.title_tb.TabIndex = 0;
            // 
            // start_dt
            // 
            this.start_dt.Location = new System.Drawing.Point(12, 122);
            this.start_dt.Name = "start_dt";
            this.start_dt.Size = new System.Drawing.Size(200, 20);
            this.start_dt.TabIndex = 2;
            // 
            // ort_tb
            // 
            this.ort_tb.Location = new System.Drawing.Point(12, 74);
            this.ort_tb.Name = "ort_tb";
            this.ort_tb.Size = new System.Drawing.Size(200, 20);
            this.ort_tb.TabIndex = 1;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(12, 58);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(21, 13);
            this.label8.TabIndex = 3;
            this.label8.Text = "Ort";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(12, 106);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(58, 13);
            this.label9.TabIndex = 5;
            this.label9.Text = "Startdatum";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(15, 157);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(55, 13);
            this.label10.TabIndex = 7;
            this.label10.Text = "Enddatum";
            // 
            // ende_dt
            // 
            this.ende_dt.Location = new System.Drawing.Point(15, 173);
            this.ende_dt.Name = "ende_dt";
            this.ende_dt.Size = new System.Drawing.Size(197, 20);
            this.ende_dt.TabIndex = 3;
            // 
            // save_bt
            // 
            this.save_bt.Location = new System.Drawing.Point(137, 276);
            this.save_bt.Name = "save_bt";
            this.save_bt.Size = new System.Drawing.Size(75, 23);
            this.save_bt.TabIndex = 5;
            this.save_bt.Text = "Speichern";
            this.save_bt.UseVisualStyleBackColor = true;
            this.save_bt.Click += new System.EventHandler(this.save_bt_Click);
            // 
            // exit
            // 
            this.exit.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.exit.Location = new System.Drawing.Point(15, 276);
            this.exit.Name = "exit";
            this.exit.Size = new System.Drawing.Size(75, 23);
            this.exit.TabIndex = 6;
            this.exit.Text = "Abbrechen";
            this.exit.UseVisualStyleBackColor = true;
            this.exit.Click += new System.EventHandler(this.exit_Click);
            // 
            // termintype
            // 
            this.termintype.FormattingEnabled = true;
            this.termintype.Location = new System.Drawing.Point(18, 228);
            this.termintype.Name = "termintype";
            this.termintype.Size = new System.Drawing.Size(194, 21);
            this.termintype.TabIndex = 4;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(15, 212);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(52, 13);
            this.label11.TabIndex = 11;
            this.label11.Text = "Kategorie";
            // 
            // TerminForm
            // 
            this.CancelButton = this.exit;
            this.ClientSize = new System.Drawing.Size(225, 311);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.termintype);
            this.Controls.Add(this.exit);
            this.Controls.Add(this.save_bt);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.ende_dt);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.ort_tb);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.start_dt);
            this.Controls.Add(this.title_tb);
            this.Controls.Add(this.label7);
            this.Name = "TerminForm";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Text = "Termin erstellen";
            this.Load += new System.EventHandler(this.TerminForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();
=======
            this.SuspendLayout();
            // 
            // TerminForm
            // 
            this.ClientSize = new System.Drawing.Size(611, 289);
            this.Name = "TerminForm";
            this.ResumeLayout(false);
>>>>>>> 1e2e46601e189be22929636b1ed697972d861f9f

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
<<<<<<< HEAD
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox title_tb;
        private System.Windows.Forms.DateTimePicker start_dt;
        private System.Windows.Forms.TextBox ort_tb;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.DateTimePicker ende_dt;
        private System.Windows.Forms.Button save_bt;
        private System.Windows.Forms.Button exit;
        private System.Windows.Forms.ComboBox termintype;
        private System.Windows.Forms.Label label11;
=======
>>>>>>> 1e2e46601e189be22929636b1ed697972d861f9f
    }
}