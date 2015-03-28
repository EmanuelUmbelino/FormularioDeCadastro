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
            this.Nome = new System.Windows.Forms.TextBox();
            this.Mês = new System.Windows.Forms.ComboBox();
            this.Ano = new System.Windows.Forms.ComboBox();
            this.Profissão = new System.Windows.Forms.TextBox();
            this.EstadoCivil = new System.Windows.Forms.ComboBox();
            this.País = new System.Windows.Forms.TextBox();
            this.RG = new System.Windows.Forms.TextBox();
            this.Cidade = new System.Windows.Forms.TextBox();
            this.Rua = new System.Windows.Forms.TextBox();
            this.Complemento = new System.Windows.Forms.TextBox();
            this.Nº = new System.Windows.Forms.TextBox();
            this.Dia = new System.Windows.Forms.ComboBox();
            this.Telefone = new System.Windows.Forms.TextBox();
            this.DDD = new System.Windows.Forms.TextBox();
            this.Email = new System.Windows.Forms.TextBox();
            this.Rest = new System.Windows.Forms.ComboBox();
            this.Sangue = new System.Windows.Forms.ComboBox();
            this.Raça = new System.Windows.Forms.ComboBox();
            this.Filhos = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.Sal = new System.Windows.Forms.TextBox();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.button4 = new System.Windows.Forms.Button();
            this.Sexualidade = new System.Windows.Forms.ComboBox();
            label1 = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.Filhos)).BeginInit();
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
            // Nome
            // 
            this.Nome.BackColor = System.Drawing.Color.WhiteSmoke;
            this.Nome.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Nome.ForeColor = System.Drawing.Color.Silver;
            this.Nome.Location = new System.Drawing.Point(723, 116);
            this.Nome.Name = "Nome";
            this.Nome.Size = new System.Drawing.Size(210, 29);
            this.Nome.TabIndex = 4;
            this.Nome.Text = "Nome";
            this.Nome.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.AprovadorText);
            // 
            // Mês
            // 
            this.Mês.BackColor = System.Drawing.Color.WhiteSmoke;
            this.Mês.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Mês.ForeColor = System.Drawing.Color.Silver;
            this.Mês.FormattingEnabled = true;
            this.Mês.Items.AddRange(new object[] {
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
            this.Mês.Location = new System.Drawing.Point(794, 151);
            this.Mês.Name = "Mês";
            this.Mês.Size = new System.Drawing.Size(69, 27);
            this.Mês.TabIndex = 9;
            this.Mês.Text = "Mês";
            this.Mês.TextChanged += new System.EventHandler(this.ComboPlay);
            this.Mês.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Impedir);
            // 
            // Ano
            // 
            this.Ano.AutoCompleteCustomSource.AddRange(new string[] {
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
            this.Ano.BackColor = System.Drawing.Color.WhiteSmoke;
            this.Ano.DropDownHeight = 290;
            this.Ano.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Ano.ForeColor = System.Drawing.Color.Silver;
            this.Ano.FormattingEnabled = true;
            this.Ano.IntegralHeight = false;
            this.Ano.Items.AddRange(new object[] {
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
            this.Ano.Location = new System.Drawing.Point(864, 151);
            this.Ano.Name = "Ano";
            this.Ano.Size = new System.Drawing.Size(69, 27);
            this.Ano.TabIndex = 10;
            this.Ano.Text = "Ano";
            this.Ano.TextChanged += new System.EventHandler(this.ComboPlay);
            this.Ano.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Impedir);
            // 
            // Profissão
            // 
            this.Profissão.BackColor = System.Drawing.Color.WhiteSmoke;
            this.Profissão.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Profissão.ForeColor = System.Drawing.Color.Silver;
            this.Profissão.Location = new System.Drawing.Point(723, 222);
            this.Profissão.Name = "Profissão";
            this.Profissão.Size = new System.Drawing.Size(210, 29);
            this.Profissão.TabIndex = 13;
            this.Profissão.Text = "Profissão";
            this.Profissão.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.AprovadorText);
            // 
            // EstadoCivil
            // 
            this.EstadoCivil.BackColor = System.Drawing.Color.WhiteSmoke;
            this.EstadoCivil.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EstadoCivil.ForeColor = System.Drawing.Color.Silver;
            this.EstadoCivil.FormattingEnabled = true;
            this.EstadoCivil.Items.AddRange(new object[] {
            "Casado",
            "Solteiro",
            "Viúvo"});
            this.EstadoCivil.Location = new System.Drawing.Point(723, 257);
            this.EstadoCivil.Name = "EstadoCivil";
            this.EstadoCivil.Size = new System.Drawing.Size(210, 32);
            this.EstadoCivil.TabIndex = 15;
            this.EstadoCivil.Text = "Estado Civil";
            this.EstadoCivil.TextChanged += new System.EventHandler(this.ComboPlay);
            this.EstadoCivil.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Impedir);
            // 
            // País
            // 
            this.País.BackColor = System.Drawing.Color.WhiteSmoke;
            this.País.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.País.ForeColor = System.Drawing.Color.Silver;
            this.País.Location = new System.Drawing.Point(723, 295);
            this.País.Name = "País";
            this.País.Size = new System.Drawing.Size(210, 29);
            this.País.TabIndex = 16;
            this.País.Text = "País";
            this.País.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.AprovadorText);
            // 
            // RG
            // 
            this.RG.BackColor = System.Drawing.Color.WhiteSmoke;
            this.RG.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RG.ForeColor = System.Drawing.Color.Silver;
            this.RG.Location = new System.Drawing.Point(723, 330);
            this.RG.Name = "RG";
            this.RG.Size = new System.Drawing.Size(69, 29);
            this.RG.TabIndex = 17;
            this.RG.Text = "RG";
            this.RG.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.AprovadorText);
            // 
            // Cidade
            // 
            this.Cidade.BackColor = System.Drawing.Color.WhiteSmoke;
            this.Cidade.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Cidade.ForeColor = System.Drawing.Color.Silver;
            this.Cidade.Location = new System.Drawing.Point(798, 330);
            this.Cidade.Name = "Cidade";
            this.Cidade.Size = new System.Drawing.Size(135, 29);
            this.Cidade.TabIndex = 18;
            this.Cidade.Text = "Cidade";
            this.Cidade.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.AprovadorText);
            // 
            // Rua
            // 
            this.Rua.BackColor = System.Drawing.Color.WhiteSmoke;
            this.Rua.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Rua.ForeColor = System.Drawing.Color.Silver;
            this.Rua.Location = new System.Drawing.Point(723, 365);
            this.Rua.Name = "Rua";
            this.Rua.Size = new System.Drawing.Size(210, 29);
            this.Rua.TabIndex = 19;
            this.Rua.Text = "Rua";
            this.Rua.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.AprovadorText);
            // 
            // Complemento
            // 
            this.Complemento.BackColor = System.Drawing.Color.WhiteSmoke;
            this.Complemento.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Complemento.ForeColor = System.Drawing.Color.Silver;
            this.Complemento.Location = new System.Drawing.Point(723, 400);
            this.Complemento.Name = "Complemento";
            this.Complemento.Size = new System.Drawing.Size(128, 29);
            this.Complemento.TabIndex = 20;
            this.Complemento.Text = "Complemento";
            // 
            // Nº
            // 
            this.Nº.BackColor = System.Drawing.Color.WhiteSmoke;
            this.Nº.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Nº.ForeColor = System.Drawing.Color.Silver;
            this.Nº.Location = new System.Drawing.Point(857, 400);
            this.Nº.Name = "Nº";
            this.Nº.Size = new System.Drawing.Size(76, 29);
            this.Nº.TabIndex = 21;
            this.Nº.Text = "Nº";
            this.Nº.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.AprovadorNum);
            // 
            // Dia
            // 
            this.Dia.AutoCompleteCustomSource.AddRange(new string[] {
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
            this.Dia.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.Dia.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.Dia.BackColor = System.Drawing.Color.WhiteSmoke;
            this.Dia.DropDownHeight = 290;
            this.Dia.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Dia.ForeColor = System.Drawing.Color.Silver;
            this.Dia.FormattingEnabled = true;
            this.Dia.IntegralHeight = false;
            this.Dia.Items.AddRange(new object[] {
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
            this.Dia.Location = new System.Drawing.Point(724, 151);
            this.Dia.Name = "Dia";
            this.Dia.Size = new System.Drawing.Size(69, 27);
            this.Dia.TabIndex = 22;
            this.Dia.Text = "Dia";
            this.Dia.TextChanged += new System.EventHandler(this.ComboPlay);
            this.Dia.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Impedir);
            // 
            // Telefone
            // 
            this.Telefone.BackColor = System.Drawing.Color.WhiteSmoke;
            this.Telefone.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Telefone.ForeColor = System.Drawing.Color.Silver;
            this.Telefone.Location = new System.Drawing.Point(776, 435);
            this.Telefone.Name = "Telefone";
            this.Telefone.Size = new System.Drawing.Size(157, 29);
            this.Telefone.TabIndex = 23;
            this.Telefone.Text = "Telefone";
            this.Telefone.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.AprovadorNum);
            // 
            // DDD
            // 
            this.DDD.BackColor = System.Drawing.Color.WhiteSmoke;
            this.DDD.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DDD.ForeColor = System.Drawing.Color.Silver;
            this.DDD.Location = new System.Drawing.Point(723, 435);
            this.DDD.Name = "DDD";
            this.DDD.Size = new System.Drawing.Size(47, 29);
            this.DDD.TabIndex = 24;
            this.DDD.Text = "DDD";
            this.DDD.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.AprovadorNum);
            // 
            // Email
            // 
            this.Email.BackColor = System.Drawing.Color.WhiteSmoke;
            this.Email.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Email.ForeColor = System.Drawing.Color.Silver;
            this.Email.Location = new System.Drawing.Point(723, 470);
            this.Email.Name = "Email";
            this.Email.Size = new System.Drawing.Size(135, 29);
            this.Email.TabIndex = 25;
            this.Email.Text = "Email";
            // 
            // Rest
            // 
            this.Rest.BackColor = System.Drawing.Color.WhiteSmoke;
            this.Rest.DropDownHeight = 290;
            this.Rest.DropDownWidth = 200;
            this.Rest.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Rest.ForeColor = System.Drawing.Color.Silver;
            this.Rest.FormattingEnabled = true;
            this.Rest.IntegralHeight = false;
            this.Rest.Items.AddRange(new object[] {
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
            this.Rest.Location = new System.Drawing.Point(864, 470);
            this.Rest.Name = "Rest";
            this.Rest.Size = new System.Drawing.Size(69, 27);
            this.Rest.TabIndex = 26;
            this.Rest.Text = "@.";
            this.Rest.TextChanged += new System.EventHandler(this.ComboPlay);
            this.Rest.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Impedir);
            // 
            // Sangue
            // 
            this.Sangue.BackColor = System.Drawing.Color.WhiteSmoke;
            this.Sangue.DropDownHeight = 290;
            this.Sangue.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Sangue.ForeColor = System.Drawing.Color.Silver;
            this.Sangue.FormattingEnabled = true;
            this.Sangue.IntegralHeight = false;
            this.Sangue.Items.AddRange(new object[] {
            "O-",
            "O+",
            "A-",
            "A+",
            "B-",
            "B+",
            "AB-",
            "AB+"});
            this.Sangue.Location = new System.Drawing.Point(723, 505);
            this.Sangue.Name = "Sangue";
            this.Sangue.Size = new System.Drawing.Size(88, 27);
            this.Sangue.TabIndex = 27;
            this.Sangue.Text = "Sangue";
            this.Sangue.TextChanged += new System.EventHandler(this.ComboPlay);
            this.Sangue.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Impedir);
            // 
            // Raça
            // 
            this.Raça.BackColor = System.Drawing.Color.WhiteSmoke;
            this.Raça.DropDownHeight = 290;
            this.Raça.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Raça.ForeColor = System.Drawing.Color.Silver;
            this.Raça.FormattingEnabled = true;
            this.Raça.IntegralHeight = false;
            this.Raça.Items.AddRange(new object[] {
            "Humano",
            "Negro",
            "Asiático",
            "Indiano",
            "Índio",
            "Pobre",
            "Judeu",
            "Gay"});
            this.Raça.Location = new System.Drawing.Point(817, 505);
            this.Raça.Name = "Raça";
            this.Raça.Size = new System.Drawing.Size(116, 27);
            this.Raça.TabIndex = 28;
            this.Raça.Text = "Raça";
            this.Raça.TextChanged += new System.EventHandler(this.ComboPlay);
            this.Raça.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Impedir);
            // 
            // Filhos
            // 
            this.Filhos.BackColor = System.Drawing.Color.WhiteSmoke;
            this.Filhos.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.Filhos.ForeColor = System.Drawing.Color.Silver;
            this.Filhos.Location = new System.Drawing.Point(890, 538);
            this.Filhos.Maximum = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.Filhos.Name = "Filhos";
            this.Filhos.Size = new System.Drawing.Size(43, 26);
            this.Filhos.TabIndex = 29;
            this.Filhos.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Impedir);
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
            this.Sal.BackColor = System.Drawing.Color.WhiteSmoke;
            this.Sal.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Sal.ForeColor = System.Drawing.Color.Silver;
            this.Sal.Location = new System.Drawing.Point(723, 608);
            this.Sal.Name = "Sal";
            this.Sal.Size = new System.Drawing.Size(210, 29);
            this.Sal.TabIndex = 33;
            this.Sal.Text = "Salário";
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(12, 56);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(465, 303);
            this.listBox1.TabIndex = 36;
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
            // Sexualidade
            // 
            this.Sexualidade.BackColor = System.Drawing.Color.WhiteSmoke;
            this.Sexualidade.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Sexualidade.ForeColor = System.Drawing.Color.Silver;
            this.Sexualidade.FormattingEnabled = true;
            this.Sexualidade.Items.AddRange(new object[] {
            "Homem",
            "Mulher",
            "Viado",
            "Gata",
            "Sapatão",
            "Indeciso"});
            this.Sexualidade.Location = new System.Drawing.Point(723, 184);
            this.Sexualidade.Name = "Sexualidade";
            this.Sexualidade.Size = new System.Drawing.Size(210, 32);
            this.Sexualidade.TabIndex = 39;
            this.Sexualidade.Text = "Sexualidade";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(982, 717);
            this.Controls.Add(this.Sexualidade);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.Sal);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Filhos);
            this.Controls.Add(this.Raça);
            this.Controls.Add(this.Sangue);
            this.Controls.Add(this.Rest);
            this.Controls.Add(this.Email);
            this.Controls.Add(this.DDD);
            this.Controls.Add(this.Telefone);
            this.Controls.Add(this.Dia);
            this.Controls.Add(this.Nº);
            this.Controls.Add(this.Complemento);
            this.Controls.Add(this.Rua);
            this.Controls.Add(this.Cidade);
            this.Controls.Add(this.RG);
            this.Controls.Add(this.País);
            this.Controls.Add(this.EstadoCivil);
            this.Controls.Add(this.Profissão);
            this.Controls.Add(this.Ano);
            this.Controls.Add(this.Mês);
            this.Controls.Add(label2);
            this.Controls.Add(label1);
            this.Controls.Add(this.Nome);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Recuperar);
            ((System.ComponentModel.ISupportInitialize)(this.Filhos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox Nome;
        private System.Windows.Forms.ComboBox Mês;
        private System.Windows.Forms.ComboBox Ano;
        private System.Windows.Forms.TextBox Profissão;
        private System.Windows.Forms.ComboBox EstadoCivil;
        private System.Windows.Forms.TextBox País;
        private System.Windows.Forms.TextBox RG;
        private System.Windows.Forms.TextBox Cidade;
        private System.Windows.Forms.TextBox Rua;
        private System.Windows.Forms.TextBox Complemento;
        private System.Windows.Forms.TextBox Nº;
        private System.Windows.Forms.ComboBox Dia;
        private System.Windows.Forms.TextBox Telefone;
        private System.Windows.Forms.TextBox DDD;
        private System.Windows.Forms.TextBox Email;
        private System.Windows.Forms.ComboBox Rest;
        private System.Windows.Forms.ComboBox Sangue;
        private System.Windows.Forms.ComboBox Raça;
        private System.Windows.Forms.NumericUpDown Filhos;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.TextBox Sal;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.ComboBox Sexualidade;
    }
}

