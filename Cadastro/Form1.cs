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
        // add para lista
        private void TestAll(object sender, EventArgs e)
        {
            List<string> todos = new List<string>();
            todos.Add(textBox1.Text);
            todos.Add(comboBox1.Text);
            todos.Add(comboBox2.Text);
            todos.Add(comboBox3.Text);
            if (Feminino.Checked) todos.Add(Feminino.Text);
            else todos.Add(radioButton1.Text);
            todos.Add(textBox2.Text);
            todos.Add(comboBox4.Text);
            todos.Add(textBox3.Text);
            todos.Add(textBox4.Text);
            todos.Add(textBox5.Text);
            todos.Add(textBox6.Text);
            todos.Add(textBox7.Text);
            todos.Add(textBox8.Text);
            todos.Add(textBox9.Text);
            todos.Add(textBox10.Text);
            todos.Add(textBox11.Text);
            todos.Add(comboBox5.Text);
            todos.Add(comboBox6.Text);
            todos.Add(comboBox7.Text);
            todos.Add(numericUpDown1.Value.ToString());
            listBox1.Items.Add(todos[0] + "   " + todos[1] + "/" + todos[2] + "/" + todos[3] + "   " + 
                todos[4] + "   " + todos[5] + "   " + todos[6] + "   " + todos[7] + "   " + todos[8] + "   " +
                todos[9] + "   " + todos[10] + "   " + todos[11] + "   " + todos[12] + "   " + todos[13] +
                "   " + todos[14] + "   " + todos[15] + todos[16] + "   " + todos[17] +
                "   " + todos[18] + "   " + todos[19]);
            if(listBox1.Size.Height < 600)
                listBox1.Size += listBox1.Size;
        }
        // mudar o tamanho no voltar e n
        private void button2_Click(object sender, EventArgs e)
        {
            if (listBox1.Size.Height > 600)
                listBox1.Size = listBox2.Size;
        }
    }
}
