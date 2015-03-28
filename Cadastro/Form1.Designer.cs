namespace Cadastro
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
            System.Windows.Forms.Label label1;
            System.Windows.Forms.Label label2;
            this.button1 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.comboBox3 = new System.Windows.Forms.ComboBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.comboBox4 = new System.Windows.Forms.ComboBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.textBox8 = new System.Windows.Forms.TextBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.textBox10 = new System.Windows.Forms.TextBox();
            this.textBox9 = new System.Windows.Forms.TextBox();
            this.textBox11 = new System.Windows.Forms.TextBox();
            this.comboBox5 = new System.Windows.Forms.ComboBox();
            this.comboBox6 = new System.Windows.Forms.ComboBox();
            this.comboBox7 = new System.Windows.Forms.ComboBox();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.Sal = new System.Windows.Forms.TextBox();
            this.Feminino = new System.Windows.Forms.RadioButton();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.button2 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.listBox2 = new System.Windows.Forms.ListBox();
            label1 = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new System.Drawing.Font("Arial", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label1.Location = new System.Drawing.Point(717, 21);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(181, 34);
            label1.TabIndex = 5;
            label1.Text = "Cadastre-se";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label2.Location = new System.Drawing.Point(721, 55);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(197, 18);
            label2.TabIndex = 6;
            label2.Text = "Ou procure alguém na lista.";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(661, 655);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(150, 50);
            this.button1.TabIndex = 2;
            this.button1.Text = "Cadastrar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.TestAll);
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.textBox1.Location = new System.Drawing.Point(723, 120);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(210, 29);
            this.textBox1.TabIndex = 4;
            this.textBox1.Text = "Nome";
            this.textBox1.Click += new System.EventHandler(this.Play);
            this.textBox1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.AprovadorText);
            // 
            // comboBox2
            // 
            this.comboBox2.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox2.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Items.AddRange(new object[] {
            "Jan",
            "Fev",
            "Mar",
            "Abr",
            "Mai",
            "Jun",
            "Jul",
            "Ago",
            "Set",
            "Out",
            "Nov",
            "Dez"});
            this.comboBox2.Location = new System.Drawing.Point(794, 155);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(69, 27);
            this.comboBox2.TabIndex = 9;
            this.comboBox2.Text = "Mês";
            this.comboBox2.TextChanged += new System.EventHandler(this.ComboPlay);
            this.comboBox2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Impedir);
            // 
            // comboBox3
            // 
            this.comboBox3.AutoCompleteCustomSource.AddRange(new string[] {
            "2014",
            "2013",
            "2012",
            "2011",
            "2010",
            "2009",
            "2008",
            "2007",
            "2006",
            "2005",
            "2004",
            "2003",
            "2002",
            "2001",
            "2000",
            "1999",
            "1998",
            "1997",
            "1996",
            "1995",
            "1994",
            "1993",
            "1992",
            "1991",
            "1990",
            "1989",
            "1988",
            "1987",
            "1986",
            "1985",
            "1984",
            "1983",
            "1982",
            "1981",
            "1980",
            "1979",
            "1978",
            "1977",
            "1976",
            "1975",
            "1974",
            "1973",
            "1972",
            "1971",
            "1970",
            "1969",
            "1968",
            "1967",
            "1966",
            "1965",
            "1964",
            "1963",
            "1962",
            "1961",
            "1960",
            "1959",
            "1958",
            "1957",
            "1956",
            "1955",
            "1954",
            "1953",
            "1952",
            "1951",
            "1950",
            "1949",
            "1948",
            "1947",
            "1946",
            "1945",
            "1944",
            "1943",
            "1942",
            "1941",
            "1940",
            "1939",
            "1938",
            "1937",
            "1936",
            "1935",
            "1934",
            "1933",
            "1932",
            "1931",
            "1930"});
            this.comboBox3.DropDownHeight = 290;
            this.comboBox3.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox3.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.comboBox3.FormattingEnabled = true;
            this.comboBox3.IntegralHeight = false;
            this.comboBox3.Items.AddRange(new object[] {
            "2014",
            "2013",
            "2012",
            "2011",
            "2010",
            "2009",
            "2008",
            "2007",
            "2006",
            "2005",
            "2004",
            "2003",
            "2002",
            "2001",
            "2000",
            "1999",
            "1998",
            "1997",
            "1996",
            "1995",
            "1994",
            "1993",
            "1992",
            "1991",
            "1990",
            "1989",
            "1988",
            "1987",
            "1986",
            "1985",
            "1984",
            "1983",
            "1982",
            "1981",
            "1980",
            "1979",
            "1978",
            "1977",
            "1976",
            "1975",
            "1974",
            "1973",
            "1972",
            "1971",
            "1970",
            "1969",
            "1968",
            "1967",
            "1966",
            "1965",
            "1964",
            "1963",
            "1962",
            "1961",
            "1960",
            "1959",
            "1958",
            "1957",
            "1956",
            "1955",
            "1954",
            "1953",
            "1952",
            "1951",
            "1950",
            "1949",
            "1948",
            "1947",
            "1946",
            "1945",
            "1944",
            "1943",
            "1942",
            "1941",
            "1940",
            "1939",
            "1938",
            "1937",
            "1936",
            "1935",
            "1934",
            "1933",
            "1932",
            "1931",
            "1930"});
            this.comboBox3.Location = new System.Drawing.Point(864, 155);
            this.comboBox3.Name = "comboBox3";
            this.comboBox3.Size = new System.Drawing.Size(69, 27);
            this.comboBox3.TabIndex = 10;
            this.comboBox3.Text = "Ano";
            this.comboBox3.TextChanged += new System.EventHandler(this.ComboPlay);
            this.comboBox3.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Impedir);
            // 
            // textBox2
            // 
            this.textBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox2.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.textBox2.Location = new System.Drawing.Point(723, 222);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(210, 29);
            this.textBox2.TabIndex = 13;
            this.textBox2.Text = "Profissão";
            this.textBox2.Click += new System.EventHandler(this.Play);
            this.textBox2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.AprovadorText);
            // 
            // comboBox4
            // 
            this.comboBox4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox4.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.comboBox4.FormattingEnabled = true;
            this.comboBox4.Items.AddRange(new object[] {
            "Casado",
            "Solteiro",
            "Viúvo"});
            this.comboBox4.Location = new System.Drawing.Point(723, 257);
            this.comboBox4.Name = "comboBox4";
            this.comboBox4.Size = new System.Drawing.Size(210, 32);
            this.comboBox4.TabIndex = 15;
            this.comboBox4.Text = "Estado Civil";
            this.comboBox4.TextChanged += new System.EventHandler(this.ComboPlay);
            this.comboBox4.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Impedir);
            // 
            // textBox3
            // 
            this.textBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox3.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.textBox3.Location = new System.Drawing.Point(723, 295);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(210, 29);
            this.textBox3.TabIndex = 16;
            this.textBox3.Text = "País";
            this.textBox3.Click += new System.EventHandler(this.Play);
            this.textBox3.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.AprovadorText);
            // 
            // textBox4
            // 
            this.textBox4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox4.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.textBox4.Location = new System.Drawing.Point(723, 330);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(69, 29);
            this.textBox4.TabIndex = 17;
            this.textBox4.Text = "RG";
            this.textBox4.Click += new System.EventHandler(this.Play);
            this.textBox4.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.AprovadorText);
            // 
            // textBox5
            // 
            this.textBox5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox5.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.textBox5.Location = new System.Drawing.Point(798, 330);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(135, 29);
            this.textBox5.TabIndex = 18;
            this.textBox5.Text = "Cidade";
            this.textBox5.Click += new System.EventHandler(this.Play);
            this.textBox5.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.AprovadorText);
            // 
            // textBox6
            // 
            this.textBox6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox6.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.textBox6.Location = new System.Drawing.Point(723, 365);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(210, 29);
            this.textBox6.TabIndex = 19;
            this.textBox6.Text = "Rua";
            this.textBox6.Click += new System.EventHandler(this.Play);
            this.textBox6.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.AprovadorText);
            // 
            // textBox7
            // 
            this.textBox7.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox7.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.textBox7.Location = new System.Drawing.Point(723, 400);
            this.textBox7.Name = "textBox7";
            this.textBox7.Size = new System.Drawing.Size(128, 29);
            this.textBox7.TabIndex = 20;
            this.textBox7.Text = "Complemento";
            this.textBox7.Click += new System.EventHandler(this.Play);
            this.textBox7.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.AprovadorText);
            // 
            // textBox8
            // 
            this.textBox8.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox8.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.textBox8.Location = new System.Drawing.Point(857, 400);
            this.textBox8.Name = "textBox8";
            this.textBox8.Size = new System.Drawing.Size(76, 29);
            this.textBox8.TabIndex = 21;
            this.textBox8.Text = "Nº";
            this.textBox8.Click += new System.EventHandler(this.Play);
            this.textBox8.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.AprovadorNum);
            // 
            // comboBox1
            // 
            this.comboBox1.AutoCompleteCustomSource.AddRange(new string[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15",
            "16",
            "17",
            "18",
            "19",
            "20",
            "21",
            "22",
            "23",
            "24",
            "25",
            "26",
            "27",
            "28",
            "29",
            "30",
            "31"});
            this.comboBox1.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.comboBox1.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.comboBox1.DropDownHeight = 290;
            this.comboBox1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox1.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.IntegralHeight = false;
            this.comboBox1.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15",
            "16",
            "17",
            "18",
            "19",
            "20",
            "21",
            "22",
            "23",
            "24",
            "25",
            "26",
            "27",
            "28",
            "29",
            "30",
            "31"});
            this.comboBox1.Location = new System.Drawing.Point(724, 155);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(69, 27);
            this.comboBox1.TabIndex = 22;
            this.comboBox1.Text = "Dia";
            this.comboBox1.TextChanged += new System.EventHandler(this.ComboPlay);
            this.comboBox1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Impedir);
            // 
            // textBox10
            // 
            this.textBox10.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox10.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.textBox10.Location = new System.Drawing.Point(776, 435);
            this.textBox10.Name = "textBox10";
            this.textBox10.Size = new System.Drawing.Size(157, 29);
            this.textBox10.TabIndex = 23;
            this.textBox10.Text = "Telefone";
            this.textBox10.Click += new System.EventHandler(this.Play);
            this.textBox10.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.AprovadorNum);
            // 
            // textBox9
            // 
            this.textBox9.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox9.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.textBox9.Location = new System.Drawing.Point(723, 435);
            this.textBox9.Name = "textBox9";
            this.textBox9.Size = new System.Drawing.Size(47, 29);
            this.textBox9.TabIndex = 24;
            this.textBox9.Text = "DDD";
            this.textBox9.Click += new System.EventHandler(this.Play);
            this.textBox9.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.AprovadorNum);
            // 
            // textBox11
            // 
            this.textBox11.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox11.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.textBox11.Location = new System.Drawing.Point(723, 470);
            this.textBox11.Name = "textBox11";
            this.textBox11.Size = new System.Drawing.Size(135, 29);
            this.textBox11.TabIndex = 25;
            this.textBox11.Text = "Email";
            this.textBox11.Click += new System.EventHandler(this.Play);
            // 
            // comboBox5
            // 
            this.comboBox5.DropDownHeight = 290;
            this.comboBox5.DropDownWidth = 200;
            this.comboBox5.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox5.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.comboBox5.FormattingEnabled = true;
            this.comboBox5.IntegralHeight = false;
            this.comboBox5.Items.AddRange(new object[] {
            "@gmail.com",
            "@gmail.com.br",
            "@hotmail.com",
            "@hotmail.com.br",
            "@live.com",
            "@yahoo.com",
            "@yahoo.com.br",
            "@outlook.com",
            "@outlook.com.br",
            "@cesar.org.br"});
            this.comboBox5.Location = new System.Drawing.Point(864, 470);
            this.comboBox5.Name = "comboBox5";
            this.comboBox5.Size = new System.Drawing.Size(69, 27);
            this.comboBox5.TabIndex = 26;
            this.comboBox5.Text = "@.";
            this.comboBox5.TextChanged += new System.EventHandler(this.ComboPlay);
            this.comboBox5.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Impedir);
            // 
            // comboBox6
            // 
            this.comboBox6.DropDownHeight = 290;
            this.comboBox6.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox6.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.comboBox6.FormattingEnabled = true;
            this.comboBox6.IntegralHeight = false;
            this.comboBox6.Items.AddRange(new object[] {
            "O-",
            "O+",
            "A-",
            "A+",
            "B-",
            "B+",
            "AB-",
            "AB+"});
            this.comboBox6.Location = new System.Drawing.Point(723, 505);
            this.comboBox6.Name = "comboBox6";
            this.comboBox6.Size = new System.Drawing.Size(88, 27);
            this.comboBox6.TabIndex = 27;
            this.comboBox6.Text = "Sangue";
            this.comboBox6.TextChanged += new System.EventHandler(this.ComboPlay);
            this.comboBox6.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Impedir);
            // 
            // comboBox7
            // 
            this.comboBox7.DropDownHeight = 290;
            this.comboBox7.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox7.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.comboBox7.FormattingEnabled = true;
            this.comboBox7.IntegralHeight = false;
            this.comboBox7.Items.AddRange(new object[] {
            "Humano",
            "Negro",
            "Asiático",
            "Indiano",
            "Índio",
            "Pobre",
            "Judeu",
            "Gay"});
            this.comboBox7.Location = new System.Drawing.Point(817, 505);
            this.comboBox7.Name = "comboBox7";
            this.comboBox7.Size = new System.Drawing.Size(116, 27);
            this.comboBox7.TabIndex = 28;
            this.comboBox7.Text = "Raça";
            this.comboBox7.TextChanged += new System.EventHandler(this.ComboPlay);
            this.comboBox7.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Impedir);
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.numericUpDown1.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.numericUpDown1.Location = new System.Drawing.Point(890, 538);
            this.numericUpDown1.Maximum = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(43, 26);
            this.numericUpDown1.TabIndex = 29;
            this.numericUpDown1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Impedir);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.label3.Location = new System.Drawing.Point(732, 540);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(119, 24);
            this.label3.TabIndex = 30;
            this.label3.Text = "Nº de Filhos:";
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.button3.Location = new System.Drawing.Point(747, 572);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(165, 30);
            this.button3.TabIndex = 32;
            this.button3.Text = "Verificar Salário";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // Sal
            // 
            this.Sal.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Sal.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.Sal.Location = new System.Drawing.Point(723, 608);
            this.Sal.Name = "Sal";
            this.Sal.Size = new System.Drawing.Size(210, 29);
            this.Sal.TabIndex = 33;
            this.Sal.Text = "Salário";
            // 
            // Feminino
            // 
            this.Feminino.AutoSize = true;
            this.Feminino.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.Feminino.Location = new System.Drawing.Point(723, 188);
            this.Feminino.Name = "Feminino";
            this.Feminino.Size = new System.Drawing.Size(108, 28);
            this.Feminino.TabIndex = 34;
            this.Feminino.Text = "Feminino";
            this.Feminino.UseVisualStyleBackColor = true;
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.radioButton1.Location = new System.Drawing.Point(830, 188);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(114, 28);
            this.radioButton1.TabIndex = 35;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Masculino";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(12, 56);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(465, 303);
            this.listBox1.TabIndex = 36;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(12, 12);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 37;
            this.button2.Text = "Voltar";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button4
            // 
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.Location = new System.Drawing.Point(820, 655);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(150, 50);
            this.button4.TabIndex = 38;
            this.button4.Text = "Pesquisar";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // listBox2
            // 
            this.listBox2.FormattingEnabled = true;
            this.listBox2.Location = new System.Drawing.Point(12, 56);
            this.listBox2.Name = "listBox2";
            this.listBox2.Size = new System.Drawing.Size(465, 303);
            this.listBox2.TabIndex = 39;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(982, 717);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.radioButton1);
            this.Controls.Add(this.Feminino);
            this.Controls.Add(this.Sal);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.numericUpDown1);
            this.Controls.Add(this.comboBox7);
            this.Controls.Add(this.comboBox6);
            this.Controls.Add(this.comboBox5);
            this.Controls.Add(this.textBox11);
            this.Controls.Add(this.textBox9);
            this.Controls.Add(this.textBox10);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.textBox8);
            this.Controls.Add(this.textBox7);
            this.Controls.Add(this.textBox6);
            this.Controls.Add(this.textBox5);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.comboBox4);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.comboBox3);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(label2);
            this.Controls.Add(label1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.listBox2);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.ComboBox comboBox3;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.ComboBox comboBox4;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.TextBox textBox7;
        private System.Windows.Forms.TextBox textBox8;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.TextBox textBox10;
        private System.Windows.Forms.TextBox textBox9;
        private System.Windows.Forms.TextBox textBox11;
        private System.Windows.Forms.ComboBox comboBox5;
        private System.Windows.Forms.ComboBox comboBox6;
        private System.Windows.Forms.ComboBox comboBox7;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.TextBox Sal;
        private System.Windows.Forms.RadioButton Feminino;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.ListBox listBox2;
    }
}

