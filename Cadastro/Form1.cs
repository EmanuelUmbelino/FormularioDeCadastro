using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cadastro
{
    public partial class Form1 : Form
    {
        List<string> funcionarios = new List<string>();
        public Form1()
        {
            InitializeComponent();
            // para pegar as caixar e executar suas funçoes quando selecionadas ou n
            foreach (Control ctrl in Controls)
            {
                if (ctrl.GetType().ToString().Equals("System.Windows.Forms.TextBox"))
                {
                    TextBox obj = (TextBox)ctrl;
                    obj.GotFocus += TextBoxGotFocus;
                    obj.LostFocus += TextBoxLostFocus;
                }
                else if (ctrl.GetType().ToString().Equals("System.Windows.Forms.ComboBox"))
                {
                    ComboBox obj = (ComboBox)ctrl;
                    obj.GotFocus += ComboBoxGotFocus;
                    obj.LostFocus += ComboBoxLostFocus;
                }
            }
        }
        // para zerar e mudar a cor quando clicada
        private void TextBoxGotFocus(object sender, EventArgs e)
        {
            TextBox obj = (TextBox)sender;
            if (obj.ForeColor != Color.Black)
            {
                obj.Text = "";
                obj.ForeColor = Color.Black;
            }
        }
        private void ComboBoxGotFocus(object sender, EventArgs e)
        {
            ComboBox obj = (ComboBox)sender;
            if (obj.ForeColor != Color.Black)
            {
                obj.Text = "";
                obj.ForeColor = Color.Black;
            }
        }
        // para caso nd esteja escrito quando deselecionado voltar a cor anterior e colocar o texto padrão
        private void TextBoxLostFocus(object sender, EventArgs e)
        {
            TextBox obj = (TextBox)sender;
            if (obj.ForeColor == Color.Black && obj.Text == "")
            {
                obj.Text = obj.Name;
                obj.ForeColor = Color.Gray;
            }
        }
        private void ComboBoxLostFocus(object sender, EventArgs e)
        {
            ComboBox obj = (ComboBox)sender;
            if (obj.ForeColor == Color.Black && obj.Text == "")
            {
                obj.Text = obj.Name;
                obj.ForeColor = Color.Gray;
            }
        }
        private void ComboPlay(object sender, EventArgs e)
        {
            ComboBox t = sender as ComboBox;
            if (t.ForeColor != Color.Black)
                t.ForeColor = Color.Black;
        }
        //testar nas caixas de texto que só podem escrever letras se escreveu só letrar ou backspace
        private void AprovadorText(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar) && e.KeyChar != 8)
                e.Handled = true;
        }
        // mesma coisa do anterior mas para numeros
        private void AprovadorNum(object sender, KeyPressEventArgs e)
        {
            if (!char.IsNumber(e.KeyChar) && e.KeyChar != 8)
                e.Handled = true;
        }
        //impedir que escreve em caixar q n podem ser escritas
        private void Impedir(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }
        // add para lista
        private void TestAll(object sender, EventArgs e)
        {
            bool testar = false;
            // testar se todos estão com algo escrito
            foreach (Control ctrl in Controls)
            {
                if (ctrl.GetType().ToString().Equals("System.Windows.Forms.TextBox"))
                {
                    TextBox obj = (TextBox)ctrl;
                    if (obj.Text.Equals(obj.Name))
                    {
                        testar = true;
                        break;
                    }
                }
                else if (ctrl.GetType().ToString().Equals("System.Windows.Forms.ComboBox"))
                {
                    ComboBox obj = (ComboBox)ctrl;
                    if (obj.Text.Equals(obj.Name))
                    {
                        testar = true;
                        break;
                    }
                }
            }
            if (!testar) 
            {
                List<string> pessoa = new List<string>();
   
                pessoa.Add(Nome.Text);
                pessoa.Add(Dia.Text);
                pessoa.Add(Mês.Text);
                pessoa.Add(Ano.Text);
                pessoa.Add(Sexualidade.Text);
                pessoa.Add(Profissão.Text);
                pessoa.Add(EstadoCivil.Text);
                pessoa.Add(País.Text);
                pessoa.Add(RG.Text);
                pessoa.Add(Cidade.Text);
                pessoa.Add(Rua.Text);
                pessoa.Add(Complemento.Text);
                pessoa.Add(Nº.Text);
                pessoa.Add(DDD.Text);
                pessoa.Add(Telefone.Text);
                pessoa.Add(Email.Text);
                pessoa.Add(Sangue.Text);
                pessoa.Add(Raça.Text);
                pessoa.Add(Filhos.Text);
                funcionarios.Add(pessoa[0] + "##" + pessoa[1] + "##" + pessoa[2] + "##" + pessoa[3] + "##" +
                    pessoa[4] + "##" + pessoa[5] + "##" + pessoa[6] + "##" + pessoa[7] + "##" + pessoa[8] + "##" +
                    pessoa[9] + "##" + pessoa[10] + "##" + pessoa[11] + "##" + pessoa[12] + "##" + pessoa[13] +
                    "##" + pessoa[14] + "##" + pessoa[15] + "##" + pessoa[16] + "##" + pessoa[17] +
                    "##" + pessoa[18]);
                listBox1.Items.Add(pessoa[0]);
                using (System.IO.StreamWriter file = new System.IO.StreamWriter(@"Text.txt", true))
                {
                    file.WriteLine(funcionarios.Last());
                }
            }
        }
        // pegar os funcionarios ja adcionados
        private void Recuperar(object sender, EventArgs e)
        {
            string[] lines = System.IO.File.ReadAllLines(@"Text.txt");
            foreach (string line in lines)
            {
                funcionarios.Add(line);
                listBox1.Items.Add(funcionarios.Last());
            }
        }
    }
}
