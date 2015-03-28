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
        public Form1()
        {
            InitializeComponent();
        }
        // quando clicar, zerar o texto e mudar sua cor.
        private void Play(object sender, EventArgs e)
        {
            TextBox t = sender as TextBox;
            if (t.ForeColor != Color.Black)
            {
                t.Text = "";
                t.ForeColor = Color.Black;
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
        // testar o masculino e o feminino
        private void Check(object sender, EventArgs e)
        {
            if (CheckMas.Checked)
                CheckFem.Checked = false;
        }
        private void Check2(object sender, EventArgs e)
        {
            if (CheckFem.Checked)
                CheckMas.Checked = false;
        }
        // parte para testar os valores incompleta
        private void TestAll(object sender, EventArgs e)
        {
            for (int i = 0; i < 11; i++)
            {
            }
        }
    }
}
