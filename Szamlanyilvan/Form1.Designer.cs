namespace Szamlanyilvan
{
    partial class Form1
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
            this.listBox_szamlak = new System.Windows.Forms.ListBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.delete = new System.Windows.Forms.Button();
            this.update = new System.Windows.Forms.Button();
            this.insert = new System.Windows.Forms.Button();
            this.dateTimePicker_nyitas = new System.Windows.Forms.DateTimePicker();
            this.numericUpDown_egyenleg = new System.Windows.Forms.NumericUpDown();
            this.textBox_tulajnev = new System.Windows.Forms.TextBox();
            this.textBox_id = new System.Windows.Forms.TextBox();
            this.nyitas = new System.Windows.Forms.Label();
            this.egyen = new System.Windows.Forms.Label();
            this.tulajdonos = new System.Windows.Forms.Label();
            this.id = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_egyenleg)).BeginInit();
            this.SuspendLayout();
            // 
            // listBox_szamlak
            // 
            this.listBox_szamlak.Dock = System.Windows.Forms.DockStyle.Left;
            this.listBox_szamlak.FormattingEnabled = true;
            this.listBox_szamlak.Location = new System.Drawing.Point(0, 0);
            this.listBox_szamlak.Name = "listBox_szamlak";
            this.listBox_szamlak.Size = new System.Drawing.Size(151, 474);
            this.listBox_szamlak.TabIndex = 1;
            this.listBox_szamlak.SelectedIndexChanged += new System.EventHandler(this.listBox_szamlak_SelectedIndexChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.delete);
            this.groupBox1.Controls.Add(this.update);
            this.groupBox1.Controls.Add(this.insert);
            this.groupBox1.Controls.Add(this.dateTimePicker_nyitas);
            this.groupBox1.Controls.Add(this.numericUpDown_egyenleg);
            this.groupBox1.Controls.Add(this.textBox_tulajnev);
            this.groupBox1.Controls.Add(this.textBox_id);
            this.groupBox1.Controls.Add(this.nyitas);
            this.groupBox1.Controls.Add(this.egyen);
            this.groupBox1.Controls.Add(this.tulajdonos);
            this.groupBox1.Controls.Add(this.id);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(151, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(378, 474);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // delete
            // 
            this.delete.Location = new System.Drawing.Point(98, 391);
            this.delete.Name = "delete";
            this.delete.Size = new System.Drawing.Size(115, 36);
            this.delete.TabIndex = 10;
            this.delete.Text = "Törlés";
            this.delete.UseVisualStyleBackColor = true;
            this.delete.Click += new System.EventHandler(this.delete_Click);
            // 
            // update
            // 
            this.update.Location = new System.Drawing.Point(98, 331);
            this.update.Name = "update";
            this.update.Size = new System.Drawing.Size(115, 37);
            this.update.TabIndex = 9;
            this.update.Text = "Módosítás";
            this.update.UseVisualStyleBackColor = true;
            this.update.Click += new System.EventHandler(this.update_Click);
            // 
            // insert
            // 
            this.insert.Location = new System.Drawing.Point(98, 268);
            this.insert.Name = "insert";
            this.insert.Size = new System.Drawing.Size(115, 37);
            this.insert.TabIndex = 8;
            this.insert.Text = "Új adat";
            this.insert.UseVisualStyleBackColor = true;
            this.insert.Click += new System.EventHandler(this.insert_Click);
            // 
            // dateTimePicker_nyitas
            // 
            this.dateTimePicker_nyitas.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker_nyitas.Location = new System.Drawing.Point(154, 212);
            this.dateTimePicker_nyitas.MaxDate = new System.DateTime(2022, 12, 25, 0, 0, 0, 0);
            this.dateTimePicker_nyitas.MinDate = new System.DateTime(1940, 1, 1, 0, 0, 0, 0);
            this.dateTimePicker_nyitas.Name = "dateTimePicker_nyitas";
            this.dateTimePicker_nyitas.Size = new System.Drawing.Size(106, 20);
            this.dateTimePicker_nyitas.TabIndex = 7;
            this.dateTimePicker_nyitas.Value = new System.DateTime(2022, 11, 21, 0, 0, 0, 0);
            // 
            // numericUpDown_egyenleg
            // 
            this.numericUpDown_egyenleg.Location = new System.Drawing.Point(145, 160);
            this.numericUpDown_egyenleg.Maximum = new decimal(new int[] {
            1000000000,
            0,
            0,
            0});
            this.numericUpDown_egyenleg.Name = "numericUpDown_egyenleg";
            this.numericUpDown_egyenleg.Size = new System.Drawing.Size(90, 20);
            this.numericUpDown_egyenleg.TabIndex = 6;
            // 
            // textBox_tulajnev
            // 
            this.textBox_tulajnev.Location = new System.Drawing.Point(183, 105);
            this.textBox_tulajnev.Name = "textBox_tulajnev";
            this.textBox_tulajnev.Size = new System.Drawing.Size(152, 20);
            this.textBox_tulajnev.TabIndex = 5;
            // 
            // textBox_id
            // 
            this.textBox_id.Location = new System.Drawing.Point(121, 60);
            this.textBox_id.Name = "textBox_id";
            this.textBox_id.ReadOnly = true;
            this.textBox_id.Size = new System.Drawing.Size(65, 20);
            this.textBox_id.TabIndex = 4;
            // 
            // nyitas
            // 
            this.nyitas.AutoSize = true;
            this.nyitas.Location = new System.Drawing.Point(60, 218);
            this.nyitas.Name = "nyitas";
            this.nyitas.Size = new System.Drawing.Size(73, 13);
            this.nyitas.TabIndex = 3;
            this.nyitas.Text = "Nyitás Dátum:";
            // 
            // egyen
            // 
            this.egyen.AutoSize = true;
            this.egyen.Location = new System.Drawing.Point(60, 162);
            this.egyen.Name = "egyen";
            this.egyen.Size = new System.Drawing.Size(54, 13);
            this.egyen.TabIndex = 2;
            this.egyen.Text = "Egyenleg:";
            // 
            // tulajdonos
            // 
            this.tulajdonos.AutoSize = true;
            this.tulajdonos.Location = new System.Drawing.Point(60, 108);
            this.tulajdonos.Name = "tulajdonos";
            this.tulajdonos.Size = new System.Drawing.Size(91, 13);
            this.tulajdonos.TabIndex = 1;
            this.tulajdonos.Text = "Tulajdonos Neve:";
            // 
            // id
            // 
            this.id.AutoSize = true;
            this.id.Location = new System.Drawing.Point(60, 63);
            this.id.Name = "id";
            this.id.Size = new System.Drawing.Size(21, 13);
            this.id.TabIndex = 0;
            this.id.Text = "ID:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(529, 474);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.listBox_szamlak);
            this.Name = "Form1";
            this.Text = "Számla Nyilvántartás";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_egyenleg)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox listBox_szamlak;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button delete;
        private System.Windows.Forms.Button update;
        private System.Windows.Forms.Button insert;
        private System.Windows.Forms.DateTimePicker dateTimePicker_nyitas;
        private System.Windows.Forms.NumericUpDown numericUpDown_egyenleg;
        private System.Windows.Forms.TextBox textBox_tulajnev;
        private System.Windows.Forms.TextBox textBox_id;
        private System.Windows.Forms.Label nyitas;
        private System.Windows.Forms.Label egyen;
        private System.Windows.Forms.Label tulajdonos;
        private System.Windows.Forms.Label id;
    }
}

