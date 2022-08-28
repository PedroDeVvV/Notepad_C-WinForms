/*
 * Criado por SharpDevelop.
 * Usuário: Alunos
 * Data: 23/08/2022
 * Hora: 21:13
 * 
 * Para alterar este modelo use Ferramentas | Opções | Codificação | Editar Cabeçalhos Padrão.
 */
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace ArqTexto
{
	public partial class MainForm : Form
	{
		public MainForm()
		{
			InitializeComponent();
		}
		void Button1Click(object sender, EventArgs e) //método
		{
			richTextBox1.SaveFile(textBox1.Text,RichTextBoxStreamType.PlainText); //RichTextBoxStreamType.PlainText serve para converter o formato de .rtf em .txt
			MessageBox.Show("Arquivo salvo com sucesso! Para abrí-lo novamente basta inserir o nome na caixa de texto menor e clicar em abrir.");
			label2.Text = "Para abrir esse arquivo basta digitar o nome corretemante e clicar em Abrir!";
		}
		void Button2Click(object sender, EventArgs e)//método
		{
			richTextBox1.LoadFile(textBox1.Text,RichTextBoxStreamType.PlainText);
			label2.Text ="";
		}
		void Button3Click(object sender, EventArgs e)//método
		{
			richTextBox1.Text ="";
			label2.Text = "";
			textBox1.Text = "";
		}
		void Button4Click(object sender, EventArgs e)
		{
			int numLinha;
			numLinha = int.Parse(textBox2.Text);
			textBox3.Text = richTextBox1.Lines[numLinha - 1];
			textBox4.Text = richTextBox1.Lines[numLinha - 1][0].ToString();
		}
		
	}
}
