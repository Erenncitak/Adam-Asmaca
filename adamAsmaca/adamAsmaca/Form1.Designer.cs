﻿namespace adamAsmaca
{
    partial class Form1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_kapat = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.button10 = new System.Windows.Forms.Button();
            this.button11 = new System.Windows.Forms.Button();
            this.button12 = new System.Windows.Forms.Button();
            this.button13 = new System.Windows.Forms.Button();
            this.button14 = new System.Windows.Forms.Button();
            this.button15 = new System.Windows.Forms.Button();
            this.button16 = new System.Windows.Forms.Button();
            this.button17 = new System.Windows.Forms.Button();
            this.button18 = new System.Windows.Forms.Button();
            this.button19 = new System.Windows.Forms.Button();
            this.button20 = new System.Windows.Forms.Button();
            this.button21 = new System.Windows.Forms.Button();
            this.button22 = new System.Windows.Forms.Button();
            this.button23 = new System.Windows.Forms.Button();
            this.button24 = new System.Windows.Forms.Button();
            this.button25 = new System.Windows.Forms.Button();
            this.button26 = new System.Windows.Forms.Button();
            this.button27 = new System.Windows.Forms.Button();
            this.button28 = new System.Windows.Forms.Button();
            this.button29 = new System.Windows.Forms.Button();
            this.button30 = new System.Windows.Forms.Button();
            this.button31 = new System.Windows.Forms.Button();
            this.button32 = new System.Windows.Forms.Button();
            this.lbl_tahmin = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Black;
            this.panel1.Controls.Add(this.btn_kapat);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(602, 55);
            this.panel1.TabIndex = 0;
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseDown);
            this.panel1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseMove);
            this.panel1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseUp);
            // 
            // btn_kapat
            // 
            this.btn_kapat.FlatAppearance.BorderSize = 3;
            this.btn_kapat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_kapat.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_kapat.Location = new System.Drawing.Point(524, 0);
            this.btn_kapat.Name = "btn_kapat";
            this.btn_kapat.Size = new System.Drawing.Size(78, 53);
            this.btn_kapat.TabIndex = 1;
            this.btn_kapat.Text = "X";
            this.btn_kapat.UseVisualStyleBackColor = true;
            this.btn_kapat.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(189, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "Adam Asmaca";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(12, 62);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(206, 202);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // button1
            // 
            this.button1.FlatAppearance.BorderSize = 3;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button1.Location = new System.Drawing.Point(18, 293);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(42, 56);
            this.button1.TabIndex = 1;
            this.button1.Text = "Q";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.harf);
            // 
            // button2
            // 
            this.button2.FlatAppearance.BorderSize = 3;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button2.Location = new System.Drawing.Point(61, 293);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(42, 56);
            this.button2.TabIndex = 1;
            this.button2.Text = "W";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.harf);
            // 
            // button3
            // 
            this.button3.FlatAppearance.BorderSize = 3;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button3.Location = new System.Drawing.Point(104, 293);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(42, 56);
            this.button3.TabIndex = 1;
            this.button3.Text = "E";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.harf);
            // 
            // button4
            // 
            this.button4.FlatAppearance.BorderSize = 3;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button4.Location = new System.Drawing.Point(147, 293);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(42, 56);
            this.button4.TabIndex = 1;
            this.button4.Text = "R";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.harf);
            // 
            // button5
            // 
            this.button5.FlatAppearance.BorderSize = 3;
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button5.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button5.Location = new System.Drawing.Point(190, 293);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(42, 56);
            this.button5.TabIndex = 1;
            this.button5.Text = "T";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.harf);
            // 
            // button6
            // 
            this.button6.FlatAppearance.BorderSize = 3;
            this.button6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button6.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button6.Location = new System.Drawing.Point(233, 293);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(42, 56);
            this.button6.TabIndex = 1;
            this.button6.Text = "Y";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.harf);
            // 
            // button7
            // 
            this.button7.FlatAppearance.BorderSize = 3;
            this.button7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button7.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button7.Location = new System.Drawing.Point(276, 293);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(42, 56);
            this.button7.TabIndex = 1;
            this.button7.Text = "U";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.harf);
            // 
            // button8
            // 
            this.button8.FlatAppearance.BorderSize = 3;
            this.button8.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button8.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button8.Location = new System.Drawing.Point(319, 293);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(42, 56);
            this.button8.TabIndex = 1;
            this.button8.Text = "I";
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.harf);
            // 
            // button9
            // 
            this.button9.FlatAppearance.BorderSize = 3;
            this.button9.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button9.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button9.Location = new System.Drawing.Point(362, 293);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(42, 56);
            this.button9.TabIndex = 1;
            this.button9.Text = "O";
            this.button9.UseVisualStyleBackColor = true;
            this.button9.Click += new System.EventHandler(this.harf);
            // 
            // button10
            // 
            this.button10.FlatAppearance.BorderSize = 3;
            this.button10.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button10.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button10.Location = new System.Drawing.Point(405, 293);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(42, 56);
            this.button10.TabIndex = 1;
            this.button10.Text = "P";
            this.button10.UseVisualStyleBackColor = true;
            this.button10.Click += new System.EventHandler(this.harf);
            // 
            // button11
            // 
            this.button11.FlatAppearance.BorderSize = 3;
            this.button11.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button11.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button11.Location = new System.Drawing.Point(448, 293);
            this.button11.Name = "button11";
            this.button11.Size = new System.Drawing.Size(42, 56);
            this.button11.TabIndex = 1;
            this.button11.Text = "Ğ";
            this.button11.UseVisualStyleBackColor = true;
            this.button11.Click += new System.EventHandler(this.harf);
            // 
            // button12
            // 
            this.button12.FlatAppearance.BorderSize = 3;
            this.button12.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button12.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button12.Location = new System.Drawing.Point(491, 293);
            this.button12.Name = "button12";
            this.button12.Size = new System.Drawing.Size(42, 56);
            this.button12.TabIndex = 1;
            this.button12.Text = "Ü";
            this.button12.UseVisualStyleBackColor = true;
            this.button12.Click += new System.EventHandler(this.harf);
            // 
            // button13
            // 
            this.button13.FlatAppearance.BorderSize = 3;
            this.button13.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button13.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button13.Location = new System.Drawing.Point(18, 346);
            this.button13.Name = "button13";
            this.button13.Size = new System.Drawing.Size(42, 56);
            this.button13.TabIndex = 1;
            this.button13.Text = "A";
            this.button13.UseVisualStyleBackColor = true;
            this.button13.Click += new System.EventHandler(this.harf);
            // 
            // button14
            // 
            this.button14.FlatAppearance.BorderSize = 3;
            this.button14.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button14.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button14.Location = new System.Drawing.Point(61, 346);
            this.button14.Name = "button14";
            this.button14.Size = new System.Drawing.Size(42, 56);
            this.button14.TabIndex = 1;
            this.button14.Text = "S";
            this.button14.UseVisualStyleBackColor = true;
            this.button14.Click += new System.EventHandler(this.harf);
            // 
            // button15
            // 
            this.button15.FlatAppearance.BorderSize = 3;
            this.button15.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button15.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button15.Location = new System.Drawing.Point(190, 346);
            this.button15.Name = "button15";
            this.button15.Size = new System.Drawing.Size(42, 56);
            this.button15.TabIndex = 1;
            this.button15.Text = "G";
            this.button15.UseVisualStyleBackColor = true;
            this.button15.Click += new System.EventHandler(this.harf);
            // 
            // button16
            // 
            this.button16.FlatAppearance.BorderSize = 3;
            this.button16.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button16.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button16.Location = new System.Drawing.Point(104, 346);
            this.button16.Name = "button16";
            this.button16.Size = new System.Drawing.Size(42, 56);
            this.button16.TabIndex = 1;
            this.button16.Text = "D";
            this.button16.UseVisualStyleBackColor = true;
            this.button16.Click += new System.EventHandler(this.harf);
            // 
            // button17
            // 
            this.button17.FlatAppearance.BorderSize = 3;
            this.button17.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button17.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button17.Location = new System.Drawing.Point(362, 346);
            this.button17.Name = "button17";
            this.button17.Size = new System.Drawing.Size(42, 56);
            this.button17.TabIndex = 1;
            this.button17.Text = "L";
            this.button17.UseVisualStyleBackColor = true;
            this.button17.Click += new System.EventHandler(this.harf);
            // 
            // button18
            // 
            this.button18.FlatAppearance.BorderSize = 3;
            this.button18.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button18.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button18.Location = new System.Drawing.Point(233, 346);
            this.button18.Name = "button18";
            this.button18.Size = new System.Drawing.Size(42, 56);
            this.button18.TabIndex = 1;
            this.button18.Text = "H";
            this.button18.UseVisualStyleBackColor = true;
            this.button18.Click += new System.EventHandler(this.harf);
            // 
            // button19
            // 
            this.button19.FlatAppearance.BorderSize = 3;
            this.button19.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button19.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button19.Location = new System.Drawing.Point(147, 346);
            this.button19.Name = "button19";
            this.button19.Size = new System.Drawing.Size(42, 56);
            this.button19.TabIndex = 1;
            this.button19.Text = "F";
            this.button19.UseVisualStyleBackColor = true;
            this.button19.Click += new System.EventHandler(this.harf);
            // 
            // button20
            // 
            this.button20.FlatAppearance.BorderSize = 3;
            this.button20.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button20.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button20.Location = new System.Drawing.Point(405, 346);
            this.button20.Name = "button20";
            this.button20.Size = new System.Drawing.Size(42, 56);
            this.button20.TabIndex = 1;
            this.button20.Text = "Ş";
            this.button20.UseVisualStyleBackColor = true;
            this.button20.Click += new System.EventHandler(this.harf);
            // 
            // button21
            // 
            this.button21.FlatAppearance.BorderSize = 3;
            this.button21.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button21.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button21.Location = new System.Drawing.Point(276, 346);
            this.button21.Name = "button21";
            this.button21.Size = new System.Drawing.Size(42, 56);
            this.button21.TabIndex = 1;
            this.button21.Text = "J";
            this.button21.UseVisualStyleBackColor = true;
            this.button21.Click += new System.EventHandler(this.harf);
            // 
            // button22
            // 
            this.button22.FlatAppearance.BorderSize = 3;
            this.button22.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button22.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button22.Location = new System.Drawing.Point(319, 346);
            this.button22.Name = "button22";
            this.button22.Size = new System.Drawing.Size(42, 56);
            this.button22.TabIndex = 1;
            this.button22.Text = "K";
            this.button22.UseVisualStyleBackColor = true;
            this.button22.Click += new System.EventHandler(this.harf);
            // 
            // button23
            // 
            this.button23.FlatAppearance.BorderSize = 3;
            this.button23.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button23.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button23.Location = new System.Drawing.Point(448, 346);
            this.button23.Name = "button23";
            this.button23.Size = new System.Drawing.Size(42, 56);
            this.button23.TabIndex = 1;
            this.button23.Text = "İ";
            this.button23.UseVisualStyleBackColor = true;
            this.button23.Click += new System.EventHandler(this.harf);
            // 
            // button24
            // 
            this.button24.FlatAppearance.BorderSize = 3;
            this.button24.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button24.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button24.Location = new System.Drawing.Point(18, 399);
            this.button24.Name = "button24";
            this.button24.Size = new System.Drawing.Size(42, 56);
            this.button24.TabIndex = 1;
            this.button24.Text = "Z";
            this.button24.UseVisualStyleBackColor = true;
            this.button24.Click += new System.EventHandler(this.harf);
            // 
            // button25
            // 
            this.button25.FlatAppearance.BorderSize = 3;
            this.button25.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button25.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button25.Location = new System.Drawing.Point(61, 399);
            this.button25.Name = "button25";
            this.button25.Size = new System.Drawing.Size(42, 56);
            this.button25.TabIndex = 1;
            this.button25.Text = "X";
            this.button25.UseVisualStyleBackColor = true;
            this.button25.Click += new System.EventHandler(this.harf);
            // 
            // button26
            // 
            this.button26.FlatAppearance.BorderSize = 3;
            this.button26.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button26.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button26.Location = new System.Drawing.Point(190, 399);
            this.button26.Name = "button26";
            this.button26.Size = new System.Drawing.Size(42, 56);
            this.button26.TabIndex = 1;
            this.button26.Text = "B";
            this.button26.UseVisualStyleBackColor = true;
            this.button26.Click += new System.EventHandler(this.harf);
            // 
            // button27
            // 
            this.button27.FlatAppearance.BorderSize = 3;
            this.button27.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button27.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button27.Location = new System.Drawing.Point(104, 399);
            this.button27.Name = "button27";
            this.button27.Size = new System.Drawing.Size(42, 56);
            this.button27.TabIndex = 1;
            this.button27.Text = "C";
            this.button27.UseVisualStyleBackColor = true;
            this.button27.Click += new System.EventHandler(this.harf);
            // 
            // button28
            // 
            this.button28.FlatAppearance.BorderSize = 3;
            this.button28.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button28.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button28.Location = new System.Drawing.Point(362, 399);
            this.button28.Name = "button28";
            this.button28.Size = new System.Drawing.Size(42, 56);
            this.button28.TabIndex = 1;
            this.button28.Text = "Ç";
            this.button28.UseVisualStyleBackColor = true;
            this.button28.Click += new System.EventHandler(this.harf);
            // 
            // button29
            // 
            this.button29.FlatAppearance.BorderSize = 3;
            this.button29.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button29.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button29.Location = new System.Drawing.Point(233, 399);
            this.button29.Name = "button29";
            this.button29.Size = new System.Drawing.Size(42, 56);
            this.button29.TabIndex = 1;
            this.button29.Text = "N";
            this.button29.UseVisualStyleBackColor = true;
            this.button29.Click += new System.EventHandler(this.harf);
            // 
            // button30
            // 
            this.button30.FlatAppearance.BorderSize = 3;
            this.button30.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button30.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button30.Location = new System.Drawing.Point(147, 399);
            this.button30.Name = "button30";
            this.button30.Size = new System.Drawing.Size(42, 56);
            this.button30.TabIndex = 1;
            this.button30.Text = "V";
            this.button30.UseVisualStyleBackColor = true;
            this.button30.Click += new System.EventHandler(this.harf);
            // 
            // button31
            // 
            this.button31.FlatAppearance.BorderSize = 3;
            this.button31.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button31.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button31.Location = new System.Drawing.Point(276, 399);
            this.button31.Name = "button31";
            this.button31.Size = new System.Drawing.Size(42, 56);
            this.button31.TabIndex = 1;
            this.button31.Text = "M";
            this.button31.UseVisualStyleBackColor = true;
            this.button31.Click += new System.EventHandler(this.harf);
            // 
            // button32
            // 
            this.button32.FlatAppearance.BorderSize = 3;
            this.button32.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button32.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button32.Location = new System.Drawing.Point(319, 399);
            this.button32.Name = "button32";
            this.button32.Size = new System.Drawing.Size(42, 56);
            this.button32.TabIndex = 1;
            this.button32.Text = "Ö";
            this.button32.UseVisualStyleBackColor = true;
            this.button32.Click += new System.EventHandler(this.harf);
            // 
            // lbl_tahmin
            // 
            this.lbl_tahmin.AutoSize = true;
            this.lbl_tahmin.Location = new System.Drawing.Point(228, 74);
            this.lbl_tahmin.Name = "lbl_tahmin";
            this.lbl_tahmin.Size = new System.Drawing.Size(0, 25);
            this.lbl_tahmin.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(231, 115);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 25);
            this.label2.TabIndex = 3;
            this.label2.Text = "Kategori:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(314, 115);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 25);
            this.label3.TabIndex = 3;
            this.label3.Text = "Meyve";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(231, 140);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(109, 25);
            this.label4.TabIndex = 3;
            this.label4.Text = "Kalan Hak:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(336, 140);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(34, 25);
            this.label5.TabIndex = 3;
            this.label5.Text = "10";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(231, 165);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(64, 25);
            this.label7.TabIndex = 3;
            this.label7.Text = "Puan:";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(295, 165);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(23, 25);
            this.label8.TabIndex = 3;
            this.label8.Text = "0";
            this.label8.Click += new System.EventHandler(this.label8_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkGreen;
            this.ClientSize = new System.Drawing.Size(602, 475);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lbl_tahmin);
            this.Controls.Add(this.button12);
            this.Controls.Add(this.button23);
            this.Controls.Add(this.button11);
            this.Controls.Add(this.button32);
            this.Controls.Add(this.button22);
            this.Controls.Add(this.button8);
            this.Controls.Add(this.button31);
            this.Controls.Add(this.button21);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.button20);
            this.Controls.Add(this.button10);
            this.Controls.Add(this.button30);
            this.Controls.Add(this.button19);
            this.Controls.Add(this.button29);
            this.Controls.Add(this.button18);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button28);
            this.Controls.Add(this.button17);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button27);
            this.Controls.Add(this.button16);
            this.Controls.Add(this.button9);
            this.Controls.Add(this.button26);
            this.Controls.Add(this.button15);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button25);
            this.Controls.Add(this.button14);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button24);
            this.Controls.Add(this.button13);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Adam Asmaca";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btn_kapat;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Button button10;
        private System.Windows.Forms.Button button11;
        private System.Windows.Forms.Button button12;
        private System.Windows.Forms.Button button13;
        private System.Windows.Forms.Button button14;
        private System.Windows.Forms.Button button15;
        private System.Windows.Forms.Button button16;
        private System.Windows.Forms.Button button17;
        private System.Windows.Forms.Button button18;
        private System.Windows.Forms.Button button19;
        private System.Windows.Forms.Button button20;
        private System.Windows.Forms.Button button21;
        private System.Windows.Forms.Button button22;
        private System.Windows.Forms.Button button23;
        private System.Windows.Forms.Button button24;
        private System.Windows.Forms.Button button25;
        private System.Windows.Forms.Button button26;
        private System.Windows.Forms.Button button27;
        private System.Windows.Forms.Button button28;
        private System.Windows.Forms.Button button29;
        private System.Windows.Forms.Button button30;
        private System.Windows.Forms.Button button31;
        private System.Windows.Forms.Button button32;
        private System.Windows.Forms.Label lbl_tahmin;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
    }
}

