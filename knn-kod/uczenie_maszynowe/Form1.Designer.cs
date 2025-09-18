namespace uczenie_maszynowe
{
    partial class Machine_Learning
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            tableLayoutPanel1 = new TableLayoutPanel();
            dataGridView = new DataGridView();
            richTextBox_wyniki = new RichTextBox();
            tableLayoutPanel2 = new TableLayoutPanel();
            tableLayoutPanel4 = new TableLayoutPanel();
            tableLayoutPanel5 = new TableLayoutPanel();
            tableLayoutPanel6 = new TableLayoutPanel();
            richTextBox_info_plik = new RichTextBox();
            tableLayoutPanel7 = new TableLayoutPanel();
            button_standaryzacja = new Button();
            button_mieszaj = new Button();
            tableLayoutPanel3 = new TableLayoutPanel();
            odleglosci = new GroupBox();
            radio_button_euklides = new RadioButton();
            radio_button_cosinus = new RadioButton();
            metoda = new GroupBox();
            radio_button_knn = new RadioButton();
            tableLayoutPanel8 = new TableLayoutPanel();
            tableLayoutPanel11 = new TableLayoutPanel();
            numericUpDown_najblizszych = new NumericUpDown();
            tableLayoutPanel14 = new TableLayoutPanel();
            label1 = new Label();
            tableLayoutPanel10 = new TableLayoutPanel();
            numericUpDown_podzialy = new NumericUpDown();
            tableLayoutPanel15 = new TableLayoutPanel();
            label2 = new Label();
            tableLayoutPanel9 = new TableLayoutPanel();
            tableLayoutPanel12 = new TableLayoutPanel();
            button_testuj = new Button();
            tableLayoutPanel13 = new TableLayoutPanel();
            button_wyczysc = new Button();
            menuStrip1 = new MenuStrip();
            plikToolStripMenuItem = new ToolStripMenuItem();
            button_otworz = new ToolStripMenuItem();
            tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView).BeginInit();
            tableLayoutPanel2.SuspendLayout();
            tableLayoutPanel4.SuspendLayout();
            tableLayoutPanel5.SuspendLayout();
            tableLayoutPanel6.SuspendLayout();
            tableLayoutPanel7.SuspendLayout();
            tableLayoutPanel3.SuspendLayout();
            odleglosci.SuspendLayout();
            metoda.SuspendLayout();
            tableLayoutPanel8.SuspendLayout();
            tableLayoutPanel11.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDown_najblizszych).BeginInit();
            tableLayoutPanel14.SuspendLayout();
            tableLayoutPanel10.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDown_podzialy).BeginInit();
            tableLayoutPanel15.SuspendLayout();
            tableLayoutPanel9.SuspendLayout();
            tableLayoutPanel12.SuspendLayout();
            tableLayoutPanel13.SuspendLayout();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 1;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Controls.Add(dataGridView, 0, 0);
            tableLayoutPanel1.Controls.Add(richTextBox_wyniki, 0, 1);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(331, 3);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 2;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 70F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 30F));
            tableLayoutPanel1.Size = new Size(604, 510);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // dataGridView
            // 
            dataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView.Dock = DockStyle.Fill;
            dataGridView.Location = new Point(3, 3);
            dataGridView.Name = "dataGridView";
            dataGridView.RowHeadersWidth = 51;
            dataGridView.Size = new Size(598, 351);
            dataGridView.TabIndex = 0;
            // 
            // richTextBox_wyniki
            // 
            richTextBox_wyniki.Dock = DockStyle.Fill;
            richTextBox_wyniki.Location = new Point(3, 360);
            richTextBox_wyniki.Name = "richTextBox_wyniki";
            richTextBox_wyniki.ReadOnly = true;
            richTextBox_wyniki.Size = new Size(598, 147);
            richTextBox_wyniki.TabIndex = 1;
            richTextBox_wyniki.Text = "Wszystkie akcje programu:\n";
            richTextBox_wyniki.TextChanged += richTextBox_wyniki_TextChanged;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.ColumnCount = 2;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 35F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 65F));
            tableLayoutPanel2.Controls.Add(tableLayoutPanel1, 1, 0);
            tableLayoutPanel2.Controls.Add(tableLayoutPanel4, 0, 0);
            tableLayoutPanel2.Dock = DockStyle.Fill;
            tableLayoutPanel2.Location = new Point(0, 28);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 1;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel2.Size = new Size(938, 516);
            tableLayoutPanel2.TabIndex = 1;
            // 
            // tableLayoutPanel4
            // 
            tableLayoutPanel4.ColumnCount = 1;
            tableLayoutPanel4.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel4.Controls.Add(tableLayoutPanel5, 0, 0);
            tableLayoutPanel4.Controls.Add(tableLayoutPanel3, 0, 1);
            tableLayoutPanel4.Controls.Add(tableLayoutPanel8, 0, 2);
            tableLayoutPanel4.Controls.Add(tableLayoutPanel9, 0, 3);
            tableLayoutPanel4.Dock = DockStyle.Fill;
            tableLayoutPanel4.Location = new Point(3, 3);
            tableLayoutPanel4.Name = "tableLayoutPanel4";
            tableLayoutPanel4.RowCount = 4;
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Percent, 25.7731953F));
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Percent, 22.6804123F));
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Percent, 25.7731953F));
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Percent, 25.7731953F));
            tableLayoutPanel4.Size = new Size(322, 510);
            tableLayoutPanel4.TabIndex = 2;
            // 
            // tableLayoutPanel5
            // 
            tableLayoutPanel5.ColumnCount = 2;
            tableLayoutPanel5.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel5.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel5.Controls.Add(tableLayoutPanel6, 1, 0);
            tableLayoutPanel5.Controls.Add(tableLayoutPanel7, 0, 0);
            tableLayoutPanel5.Dock = DockStyle.Fill;
            tableLayoutPanel5.Location = new Point(3, 3);
            tableLayoutPanel5.Name = "tableLayoutPanel5";
            tableLayoutPanel5.RowCount = 1;
            tableLayoutPanel5.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel5.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel5.Size = new Size(316, 125);
            tableLayoutPanel5.TabIndex = 2;
            // 
            // tableLayoutPanel6
            // 
            tableLayoutPanel6.ColumnCount = 1;
            tableLayoutPanel6.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel6.Controls.Add(richTextBox_info_plik, 0, 0);
            tableLayoutPanel6.Dock = DockStyle.Fill;
            tableLayoutPanel6.Location = new Point(161, 3);
            tableLayoutPanel6.Name = "tableLayoutPanel6";
            tableLayoutPanel6.RowCount = 1;
            tableLayoutPanel6.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel6.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel6.Size = new Size(152, 119);
            tableLayoutPanel6.TabIndex = 2;
            // 
            // richTextBox_info_plik
            // 
            richTextBox_info_plik.Dock = DockStyle.Fill;
            richTextBox_info_plik.Location = new Point(3, 3);
            richTextBox_info_plik.Name = "richTextBox_info_plik";
            richTextBox_info_plik.ReadOnly = true;
            richTextBox_info_plik.Size = new Size(146, 113);
            richTextBox_info_plik.TabIndex = 0;
            richTextBox_info_plik.Text = "Dane pliku.";
            // 
            // tableLayoutPanel7
            // 
            tableLayoutPanel7.ColumnCount = 1;
            tableLayoutPanel7.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel7.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            tableLayoutPanel7.Controls.Add(button_standaryzacja, 0, 1);
            tableLayoutPanel7.Controls.Add(button_mieszaj, 0, 0);
            tableLayoutPanel7.Dock = DockStyle.Fill;
            tableLayoutPanel7.Location = new Point(3, 3);
            tableLayoutPanel7.Name = "tableLayoutPanel7";
            tableLayoutPanel7.RowCount = 2;
            tableLayoutPanel7.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel7.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel7.Size = new Size(152, 119);
            tableLayoutPanel7.TabIndex = 3;
            // 
            // button_standaryzacja
            // 
            button_standaryzacja.Cursor = Cursors.Hand;
            button_standaryzacja.Dock = DockStyle.Fill;
            button_standaryzacja.Location = new Point(3, 62);
            button_standaryzacja.Name = "button_standaryzacja";
            button_standaryzacja.Size = new Size(146, 54);
            button_standaryzacja.TabIndex = 1;
            button_standaryzacja.Text = "Standaryzacja";
            button_standaryzacja.UseVisualStyleBackColor = true;
            button_standaryzacja.Click += button_standaryzacja_Click;
            // 
            // button_mieszaj
            // 
            button_mieszaj.Cursor = Cursors.Hand;
            button_mieszaj.Dock = DockStyle.Fill;
            button_mieszaj.Location = new Point(3, 3);
            button_mieszaj.Name = "button_mieszaj";
            button_mieszaj.Size = new Size(146, 53);
            button_mieszaj.TabIndex = 2;
            button_mieszaj.Text = "Mieszaj dane";
            button_mieszaj.UseVisualStyleBackColor = true;
            button_mieszaj.Click += button_mieszaj_Click;
            // 
            // tableLayoutPanel3
            // 
            tableLayoutPanel3.ColumnCount = 2;
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel3.Controls.Add(odleglosci, 1, 0);
            tableLayoutPanel3.Controls.Add(metoda, 0, 0);
            tableLayoutPanel3.Dock = DockStyle.Fill;
            tableLayoutPanel3.Location = new Point(3, 134);
            tableLayoutPanel3.Name = "tableLayoutPanel3";
            tableLayoutPanel3.RowCount = 1;
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel3.Size = new Size(316, 109);
            tableLayoutPanel3.TabIndex = 3;
            // 
            // odleglosci
            // 
            odleglosci.Controls.Add(radio_button_euklides);
            odleglosci.Controls.Add(radio_button_cosinus);
            odleglosci.Dock = DockStyle.Fill;
            odleglosci.Location = new Point(161, 3);
            odleglosci.Name = "odleglosci";
            odleglosci.Size = new Size(152, 103);
            odleglosci.TabIndex = 2;
            odleglosci.TabStop = false;
            odleglosci.Text = "Odleglosc";
            // 
            // radio_button_euklides
            // 
            radio_button_euklides.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            radio_button_euklides.AutoSize = true;
            radio_button_euklides.Cursor = Cursors.Hand;
            radio_button_euklides.Location = new Point(10, 29);
            radio_button_euklides.Name = "radio_button_euklides";
            radio_button_euklides.Size = new Size(112, 24);
            radio_button_euklides.TabIndex = 0;
            radio_button_euklides.TabStop = true;
            radio_button_euklides.Text = "Euklidesowa";
            radio_button_euklides.UseVisualStyleBackColor = true;
            radio_button_euklides.CheckedChanged += radio_button_euklides_CheckedChanged;
            // 
            // radio_button_cosinus
            // 
            radio_button_cosinus.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            radio_button_cosinus.AutoSize = true;
            radio_button_cosinus.Cursor = Cursors.Hand;
            radio_button_cosinus.Location = new Point(10, 59);
            radio_button_cosinus.Name = "radio_button_cosinus";
            radio_button_cosinus.Size = new Size(108, 24);
            radio_button_cosinus.TabIndex = 1;
            radio_button_cosinus.TabStop = true;
            radio_button_cosinus.Text = "Cosinusowa";
            radio_button_cosinus.UseVisualStyleBackColor = true;
            radio_button_cosinus.CheckedChanged += radio_button_cosinus_CheckedChanged;
            // 
            // metoda
            // 
            metoda.Controls.Add(radio_button_knn);
            metoda.Dock = DockStyle.Fill;
            metoda.Location = new Point(3, 3);
            metoda.Name = "metoda";
            metoda.Size = new Size(152, 103);
            metoda.TabIndex = 3;
            metoda.TabStop = false;
            metoda.Text = "Metoda";
            // 
            // radio_button_knn
            // 
            radio_button_knn.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            radio_button_knn.AutoSize = true;
            radio_button_knn.Cursor = Cursors.Hand;
            radio_button_knn.Location = new Point(6, 29);
            radio_button_knn.Name = "radio_button_knn";
            radio_button_knn.Size = new Size(53, 24);
            radio_button_knn.TabIndex = 0;
            radio_button_knn.TabStop = true;
            radio_button_knn.Text = "knn";
            radio_button_knn.UseVisualStyleBackColor = true;
            radio_button_knn.CheckedChanged += radio_button_knn_CheckedChanged;
            // 
            // tableLayoutPanel8
            // 
            tableLayoutPanel8.ColumnCount = 2;
            tableLayoutPanel8.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 60F));
            tableLayoutPanel8.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 40F));
            tableLayoutPanel8.Controls.Add(tableLayoutPanel11, 1, 1);
            tableLayoutPanel8.Controls.Add(tableLayoutPanel14, 0, 0);
            tableLayoutPanel8.Controls.Add(tableLayoutPanel10, 1, 0);
            tableLayoutPanel8.Controls.Add(tableLayoutPanel15, 0, 1);
            tableLayoutPanel8.Dock = DockStyle.Fill;
            tableLayoutPanel8.Location = new Point(3, 249);
            tableLayoutPanel8.Name = "tableLayoutPanel8";
            tableLayoutPanel8.RowCount = 2;
            tableLayoutPanel8.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel8.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel8.Size = new Size(316, 125);
            tableLayoutPanel8.TabIndex = 0;
            // 
            // tableLayoutPanel11
            // 
            tableLayoutPanel11.ColumnCount = 1;
            tableLayoutPanel11.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel11.Controls.Add(numericUpDown_najblizszych, 0, 1);
            tableLayoutPanel11.Dock = DockStyle.Fill;
            tableLayoutPanel11.Location = new Point(192, 65);
            tableLayoutPanel11.Name = "tableLayoutPanel11";
            tableLayoutPanel11.RowCount = 3;
            tableLayoutPanel11.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tableLayoutPanel11.RowStyles.Add(new RowStyle(SizeType.Percent, 60F));
            tableLayoutPanel11.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tableLayoutPanel11.Size = new Size(121, 57);
            tableLayoutPanel11.TabIndex = 4;
            // 
            // numericUpDown_najblizszych
            // 
            numericUpDown_najblizszych.Dock = DockStyle.Fill;
            numericUpDown_najblizszych.Location = new Point(3, 14);
            numericUpDown_najblizszych.Name = "numericUpDown_najblizszych";
            numericUpDown_najblizszych.Size = new Size(115, 27);
            numericUpDown_najblizszych.TabIndex = 2;
            // 
            // tableLayoutPanel14
            // 
            tableLayoutPanel14.ColumnCount = 1;
            tableLayoutPanel14.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel14.Controls.Add(label1, 0, 1);
            tableLayoutPanel14.Dock = DockStyle.Fill;
            tableLayoutPanel14.Location = new Point(3, 3);
            tableLayoutPanel14.Name = "tableLayoutPanel14";
            tableLayoutPanel14.RowCount = 3;
            tableLayoutPanel14.RowStyles.Add(new RowStyle(SizeType.Percent, 16.32653F));
            tableLayoutPanel14.RowStyles.Add(new RowStyle(SizeType.Percent, 67.34694F));
            tableLayoutPanel14.RowStyles.Add(new RowStyle(SizeType.Percent, 15F));
            tableLayoutPanel14.Size = new Size(183, 56);
            tableLayoutPanel14.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Dock = DockStyle.Fill;
            label1.Location = new Point(3, 9);
            label1.Name = "label1";
            label1.Size = new Size(177, 38);
            label1.TabIndex = 0;
            label1.Text = "Liczba podzialow:";
            // 
            // tableLayoutPanel10
            // 
            tableLayoutPanel10.ColumnCount = 1;
            tableLayoutPanel10.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel10.Controls.Add(numericUpDown_podzialy, 0, 1);
            tableLayoutPanel10.Dock = DockStyle.Fill;
            tableLayoutPanel10.Location = new Point(192, 3);
            tableLayoutPanel10.Name = "tableLayoutPanel10";
            tableLayoutPanel10.RowCount = 3;
            tableLayoutPanel10.RowStyles.Add(new RowStyle(SizeType.Percent, 20.8333359F));
            tableLayoutPanel10.RowStyles.Add(new RowStyle(SizeType.Percent, 58.3333359F));
            tableLayoutPanel10.RowStyles.Add(new RowStyle(SizeType.Percent, 20.8333359F));
            tableLayoutPanel10.Size = new Size(121, 56);
            tableLayoutPanel10.TabIndex = 3;
            // 
            // numericUpDown_podzialy
            // 
            numericUpDown_podzialy.Dock = DockStyle.Fill;
            numericUpDown_podzialy.Location = new Point(3, 14);
            numericUpDown_podzialy.Name = "numericUpDown_podzialy";
            numericUpDown_podzialy.Size = new Size(115, 27);
            numericUpDown_podzialy.TabIndex = 2;
            // 
            // tableLayoutPanel15
            // 
            tableLayoutPanel15.ColumnCount = 1;
            tableLayoutPanel15.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel15.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            tableLayoutPanel15.Controls.Add(label2, 0, 1);
            tableLayoutPanel15.Dock = DockStyle.Fill;
            tableLayoutPanel15.Location = new Point(3, 65);
            tableLayoutPanel15.Name = "tableLayoutPanel15";
            tableLayoutPanel15.RowCount = 3;
            tableLayoutPanel15.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            tableLayoutPanel15.RowStyles.Add(new RowStyle(SizeType.Percent, 60F));
            tableLayoutPanel15.RowStyles.Add(new RowStyle(SizeType.Percent, 15F));
            tableLayoutPanel15.Size = new Size(183, 57);
            tableLayoutPanel15.TabIndex = 5;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Dock = DockStyle.Fill;
            label2.Location = new Point(3, 14);
            label2.Name = "label2";
            label2.Size = new Size(177, 34);
            label2.TabIndex = 1;
            label2.Text = "Liczba najblizszych:";
            // 
            // tableLayoutPanel9
            // 
            tableLayoutPanel9.ColumnCount = 2;
            tableLayoutPanel9.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel9.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel9.Controls.Add(tableLayoutPanel12, 1, 0);
            tableLayoutPanel9.Controls.Add(tableLayoutPanel13, 0, 0);
            tableLayoutPanel9.Dock = DockStyle.Fill;
            tableLayoutPanel9.Location = new Point(3, 380);
            tableLayoutPanel9.Name = "tableLayoutPanel9";
            tableLayoutPanel9.RowCount = 1;
            tableLayoutPanel9.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel9.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel9.Size = new Size(316, 127);
            tableLayoutPanel9.TabIndex = 4;
            // 
            // tableLayoutPanel12
            // 
            tableLayoutPanel12.ColumnCount = 1;
            tableLayoutPanel12.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel12.Controls.Add(button_testuj, 0, 1);
            tableLayoutPanel12.Dock = DockStyle.Fill;
            tableLayoutPanel12.Location = new Point(161, 3);
            tableLayoutPanel12.Name = "tableLayoutPanel12";
            tableLayoutPanel12.RowCount = 3;
            tableLayoutPanel12.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            tableLayoutPanel12.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel12.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            tableLayoutPanel12.Size = new Size(152, 121);
            tableLayoutPanel12.TabIndex = 0;
            // 
            // button_testuj
            // 
            button_testuj.Cursor = Cursors.Hand;
            button_testuj.Dock = DockStyle.Fill;
            button_testuj.Location = new Point(3, 33);
            button_testuj.Name = "button_testuj";
            button_testuj.Size = new Size(146, 54);
            button_testuj.TabIndex = 0;
            button_testuj.Text = "Testuj";
            button_testuj.UseVisualStyleBackColor = true;
            button_testuj.Click += button_testuj_Click;
            // 
            // tableLayoutPanel13
            // 
            tableLayoutPanel13.ColumnCount = 1;
            tableLayoutPanel13.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel13.Controls.Add(button_wyczysc, 0, 1);
            tableLayoutPanel13.Dock = DockStyle.Fill;
            tableLayoutPanel13.Location = new Point(3, 3);
            tableLayoutPanel13.Name = "tableLayoutPanel13";
            tableLayoutPanel13.RowCount = 3;
            tableLayoutPanel13.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            tableLayoutPanel13.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel13.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            tableLayoutPanel13.Size = new Size(152, 121);
            tableLayoutPanel13.TabIndex = 1;
            // 
            // button_wyczysc
            // 
            button_wyczysc.Cursor = Cursors.Hand;
            button_wyczysc.Dock = DockStyle.Fill;
            button_wyczysc.Location = new Point(3, 33);
            button_wyczysc.Name = "button_wyczysc";
            button_wyczysc.Size = new Size(146, 54);
            button_wyczysc.TabIndex = 0;
            button_wyczysc.Text = "Wyczysc";
            button_wyczysc.UseVisualStyleBackColor = true;
            button_wyczysc.Click += button_wyczysc_Click;
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { plikToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(938, 28);
            menuStrip1.TabIndex = 2;
            menuStrip1.Text = "menuStrip1";
            // 
            // plikToolStripMenuItem
            // 
            plikToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { button_otworz });
            plikToolStripMenuItem.Name = "plikToolStripMenuItem";
            plikToolStripMenuItem.Size = new Size(46, 24);
            plikToolStripMenuItem.Text = "Plik";
            // 
            // button_otworz
            // 
            button_otworz.Name = "button_otworz";
            button_otworz.Size = new Size(140, 26);
            button_otworz.Text = "Otworz";
            button_otworz.Click += button_otworz_Click;
            // 
            // Machine_Learning
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(938, 544);
            Controls.Add(tableLayoutPanel2);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "Machine_Learning";
            Text = "Machine Learning";
            tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView).EndInit();
            tableLayoutPanel2.ResumeLayout(false);
            tableLayoutPanel4.ResumeLayout(false);
            tableLayoutPanel5.ResumeLayout(false);
            tableLayoutPanel6.ResumeLayout(false);
            tableLayoutPanel7.ResumeLayout(false);
            tableLayoutPanel3.ResumeLayout(false);
            odleglosci.ResumeLayout(false);
            odleglosci.PerformLayout();
            metoda.ResumeLayout(false);
            metoda.PerformLayout();
            tableLayoutPanel8.ResumeLayout(false);
            tableLayoutPanel11.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)numericUpDown_najblizszych).EndInit();
            tableLayoutPanel14.ResumeLayout(false);
            tableLayoutPanel14.PerformLayout();
            tableLayoutPanel10.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)numericUpDown_podzialy).EndInit();
            tableLayoutPanel15.ResumeLayout(false);
            tableLayoutPanel15.PerformLayout();
            tableLayoutPanel9.ResumeLayout(false);
            tableLayoutPanel12.ResumeLayout(false);
            tableLayoutPanel13.ResumeLayout(false);
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private DataGridView dataGridView;
        private RichTextBox richTextBox_wyniki;
        private TableLayoutPanel tableLayoutPanel2;
        private TableLayoutPanel tableLayoutPanel4;
        private GroupBox odleglosci;
        private RadioButton radio_button_euklides;
        private RadioButton radio_button_cosinus;
        private TableLayoutPanel tableLayoutPanel3;
        private TableLayoutPanel tableLayoutPanel5;
        private TableLayoutPanel tableLayoutPanel6;
        private RichTextBox richTextBox_info_plik;
        private TableLayoutPanel tableLayoutPanel7;
        private Button button_standaryzacja;
        private GroupBox metoda;
        private RadioButton radio_button_knn;
        private Button button_mieszaj;
        private TableLayoutPanel tableLayoutPanel8;
        private TableLayoutPanel tableLayoutPanel9;
        private Label label2;
        private TableLayoutPanel tableLayoutPanel10;
        private NumericUpDown numericUpDown_podzialy;
        private TableLayoutPanel tableLayoutPanel11;
        private NumericUpDown numericUpDown_najblizszych;
        private TableLayoutPanel tableLayoutPanel12;
        private TableLayoutPanel tableLayoutPanel13;
        private Button button_testuj;
        private Button button_wyczysc;
        private TableLayoutPanel tableLayoutPanel14;
        private Label label1;
        private TableLayoutPanel tableLayoutPanel15;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem plikToolStripMenuItem;
        private ToolStripMenuItem button_otworz;
    }
}