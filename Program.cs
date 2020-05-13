using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace FormsCSharpe
{
    
    static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        
        static void Main()
        {
            
            Application.SetHighDpiMode(HighDpiMode.SystemAware);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Formulario());
        }
    }
     public class Formulario : Form{

        Label labelLogin;
        Label labelSenha;
        Label labelSelect;
        Label labelCheck;
        Label labelNumeros;
        Label labelMascarado;
        Label labelTextArea;
        TextBox textBoxLogin;
        TextBox textBoxSenha;
        MaskedTextBox textBoxMascarado;
        Button buttonLimpar;
        Button buttonConfirmar;
        ComboBox comboOpcao;
        RadioButton radioSim;
        RadioButton radioNao;
        GroupBox groupRadios;
        CheckBox checkLi;
        NumericUpDown numeros;
        PictureBox imagem;
        RichTextBox textArea;
        LinkLabel linkLabel;
        ListBox listBox;
        String nomeAdd;
        ListView listView;

        CheckedListBox listChecked;

        public Formulario(){
            this.Text = "Login Sistema";
            this.BackColor = Color.FromArgb(200,200,200);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Size = new Size(200, 700);

            labelLogin = new Label();
            labelSenha = new Label();
            labelSelect = new Label();
            labelCheck = new Label();
            labelNumeros = new Label();
            labelMascarado = new Label();
            textBoxLogin = new TextBox();
            textBoxSenha = new TextBox();
            textBoxMascarado = new MaskedTextBox();
            buttonLimpar = new Button ();
            buttonConfirmar = new Button ();
            comboOpcao = new ComboBox();
            radioSim = new RadioButton();
            radioNao = new RadioButton();
            groupRadios = new GroupBox();
            checkLi = new CheckBox();
            numeros = new NumericUpDown();


            imagem = new PictureBox();
            imagem.BackColor = Color.Red;
            imagem.Location = new Point (0, 300);
            imagem.ClientSize = new Size(10,10);
            imagem.Text = "aqui";
            imagem.Load("./image.png");

            textArea = new RichTextBox();
            labelTextArea = new Label();
            labelTextArea.Width = 60;
            labelTextArea.Text = "TextArea";
            textArea.Size = new Size(100,40);
            labelTextArea.Location = new Point (0, 310);
            textArea.Location = new Point (60, 310);

            linkLabel = new LinkLabel();
            linkLabel.Location = new Point(0,360);
            linkLabel.Size = new Size(100, 30);
            linkLabel.Text="Linke Aqui";
            linkLabel.LinkClicked += new LinkLabelLinkClickedEventHandler(helpLink);
            
            listBox = new ListBox();
            listBox.Items.Add("teste");
            listBox.Items.Add("teste");
            listBox.Items.Add("teste");
            listBox.Location = new Point(0,390);
            listBox.Size = new Size(100,40);
            //listBox.SelectionMode = SelectionMode.MultiExtended;
            //listBox.Multicolumn = true;
            //listBox.endUpdate();
            foreach (var item in listBox.SelectedItems)
            {
                nomeAdd += item;
            }

            listView = new ListView();
            listView.Location = new Point(0,450);
            listView.Size = new Size(200,50);
            listView.View = View.Details;
            ListViewItem exemplo1 =  new ListViewItem("Exemplo 1");
            exemplo1.SubItems.Add("2");
            ListViewItem exemplo2 =  new ListViewItem("Exemplo 2");
            exemplo2.SubItems.Add("1");
            listView.Items.AddRange(new ListViewItem[]{exemplo1, exemplo2});
            listView.Columns.Add("Ex", -2, HorizontalAlignment.Left);
            listView.Columns.Add("Num", -2, HorizontalAlignment.Left);
            listView.FullRowSelect = true;
            listView.GridLines = true;
            listView.AllowColumnReorder = true;
            listView.Sorting = SortOrder.Ascending;

            listChecked = new CheckedListBox();
            listChecked.Location = new Point(0,500);
            listChecked.Size = new Size(200,50);
            string[] lista = {"exemplo1", "exemplo2"};
            listChecked.Items.AddRange(lista);
            listChecked.SelectionMode = SelectionMode.One;
            listChecked.CheckOnClick = true;
            //listCheked.ChekedItems;

            labelLogin.Text = "Login";
            labelLogin.Width = 50;
            labelSenha.Text = "Senha";
            labelSenha.Width = 50;
            labelSelect.Text = "Nivel";
            labelSelect.Width = 50;
            labelMascarado.Text = "Mascarado";
            labelMascarado.Width = 50;
            labelNumeros.Text = "Números";
            labelNumeros.Width = 60;
            groupRadios.Size = new Size(135, 35);
            radioNao.Text = "Não";
            radioSim.Text = "Sim";
            radioNao.Width = 50;
            radioSim.Width = 50;
            checkLi.Width = 20;
            labelCheck.Text = "Li e Aceito";
            labelCheck.Width = 70;
            buttonLimpar.Text = "Limpar";
            buttonConfirmar.Text = "Enviar";
            textBoxMascarado.Mask = "999.999.999-99";
            numeros.Minimum = 1;
            numeros.Maximum = 10;
            numeros.Increment = 2;

            String[] niveis = {"Selecione", "Inicio", "Meio", "Fim"};
            foreach(String nivel in niveis){
                comboOpcao.SelectedItem = "Selecione";
                comboOpcao.Items.Add(nivel);
            }
            groupRadios.Controls.Add(radioNao);
            groupRadios.Controls.Add(radioSim);

            buttonConfirmar.Click += new System.EventHandler(this.btnConfirmarClick);

            labelLogin.Location = new Point (10, 30);
            textBoxLogin.Location = new Point (60, 30);

            labelSenha.Location = new Point (10, 70);
            textBoxSenha.Location = new Point (60, 70);

            labelSelect.Location = new Point (10, 110);
            comboOpcao.Location = new Point (60, 110);
            
            groupRadios.Location = new Point (10,150);

            radioNao.Location = new Point (1, 8);

            radioSim.Location = new Point (radioNao.Width+10, 8);


            checkLi.Location = new Point (labelCheck.Width, 200);
            labelCheck.Location = new Point (1, 204);
            
            labelMascarado.Location  = new Point (0, 230);
            textBoxMascarado.Location = new Point(60 ,230);

            labelNumeros.Location = new Point (0, 260);
            numeros.Location =  new Point (60, 260);

            buttonConfirmar.Location = new Point(10, 550);
            buttonLimpar.Location = new Point (100, 550);

            // adiciona-se ele no form
            this.Controls.Add(labelLogin);
            this.Controls.Add(labelSenha);
            this.Controls.Add(textBoxLogin);
            this.Controls.Add(textBoxSenha);
            this.Controls.Add(buttonConfirmar);
            this.Controls.Add(buttonLimpar);
            this.Controls.Add(labelSelect);
            this.Controls.Add(comboOpcao);
            this.Controls.Add(groupRadios);
            this.Controls.Add(checkLi);
            this.Controls.Add(labelCheck);
            this.Controls.Add(labelMascarado);
            this.Controls.Add(textBoxMascarado);
            this.Controls.Add(labelNumeros);  
            this.Controls.Add(numeros);
            this.Controls.Add(imagem);   
            this.Controls.Add(labelTextArea);
            this.Controls.Add(textArea);
            this.Controls.Add(linkLabel);
            this.Controls.Add(listBox);
            this.Controls.Add(listView);
            this.Controls.Add(listChecked);            
         }

        private void helpLink(object sender, LinkLabelLinkClickedEventArgs e){
            this.linkLabel.LinkVisited = true;

            System.Diagnostics.Process.Start("C:/Program Files(x86)/Google/Chrome/Application/chrome.exe");
        }
        private void btnConfirmarClick(object sender, EventArgs args){

            List<RadioButton> radios = this.groupRadios.Controls.OfType<RadioButton>().ToList();
            RadioButton radio3 = radios.FirstOrDefault(radio3=> radio3.Checked);


            MessageBox.Show(
                $"Login: {this.textBoxLogin.Text} \n"+
                $"Senha: {this.textBoxLogin.Text} \n\n"+
                $"Selecionado: {this.comboOpcao.SelectedItem } \n\n"+
                $"Marcado: {(this.radioSim.Checked ? "Sim" : this.radioNao.Checked ? "Não" : "Não Selecionado" )} \n\n"+
                $"CheckBox: {(this.checkLi.Checked ? "Marcado" : "Desmarcado")}\n\n"+
                $"CheckBox: {this.textBoxMascarado.Text}\n\n"/*+
                $"CheckBox: {(radio3.Text)}"*/,
                "Titulo",
                MessageBoxButtons.OK
            );
        }
        private void btnCancelarClick(object sender, EventArgs args){
            
        }
     }
}
