using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
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
            Application.EnableVisualStyles();
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
        MonthCalendar calendario;
        DateTimePicker dtPicker;
        ProgressBar barraLoading;
        TabControl tabContral;
        TabPage tabPagePrincipal;
        TabPage tabPageSecundario;
        ToolTip toolTipNome = new ToolTip();
        TrackBar trackBar;
        Button openFile;
        MenuStrip menu;

        public Formulario(){
            this.Text = "Login Sistema";
            this.BackColor = Color.FromArgb(200,200,200);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Size = new Size(600, 650);

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
            groupRadios.Controls.Add(radioNao);
            groupRadios.Controls.Add(radioSim);

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

            calendario = new MonthCalendar();
            calendario.Location = new Point(300, 0);
            //calendario.MaxSelectionCount = 10;
            //calendario.MinDate = new DateTime(2020,05,10);
            //calendario.MaxDate = new DateTime(2020,05,20);
            calendario.SelectionRange = new SelectionRange(new DateTime(2020,05,10), new DateTime(2020,05,20));

            dtPicker = new DateTimePicker();
            dtPicker.Location= new Point(300,200);
            //dtPicker.Format = DateTimePickerFormat.Long;
            dtPicker.Format = DateTimePickerFormat.Short;
            //dtPicker.CustomFormat = "dd/MM/yyyy HH:mm";
            //dtPicker.ShowUpDown = true;
            //dtPicker.ShowCheckBox = true;

            barraLoading = new ProgressBar();
            barraLoading.Value = 50;
            barraLoading.Maximum = 100;
            barraLoading.Size = new Size(200,30);
            barraLoading.Location = new Point(300, 250);
            barraLoading.Style = ProgressBarStyle.Blocks;

    // ------------------ Tab control -------------------- //
            tabPagePrincipal = new TabPage();
            tabPagePrincipal.Text = "Principal";
            tabPagePrincipal.Size = new Size(200,100);
            tabPagePrincipal.Controls.Add(labelLogin);
            tabPagePrincipal.Controls.Add(textBoxLogin);

            tabPageSecundario = new TabPage();
            tabPageSecundario.Text = "Secundario";
            tabPageSecundario.Size = new Size(200,100);
            tabPageSecundario.Controls.Add(labelSenha);
            tabPageSecundario.Controls.Add(textBoxSenha);
            
            tabContral = new TabControl();
            tabContral.Size =new Size(200,100);
            tabContral.Controls.Add(tabPagePrincipal);
            tabContral.Controls.Add(tabPageSecundario);
    // ------------------ fim  Tab control -------------------- //

            toolTipNome.AutoPopDelay = 5000;
            toolTipNome.InitialDelay  =1000;
            toolTipNome.ReshowDelay = 500;
            toolTipNome.ShowAlways = true;
            toolTipNome.SetToolTip(labelLogin, "Login - preencha com alguma coisa");

            trackBar = new TrackBar();
            trackBar.Location = new Point (300,300);
            trackBar.Size = new Size(100,100);
            trackBar.Maximum = 30;
            trackBar.TickFrequency = 5;
            trackBar.LargeChange = 5;
            trackBar.SmallChange = 5;

            openFile = new Button();
            openFile.Location = new Point(300,350);
            openFile.Text = "Abrir Arquivo";
            openFile.Click += new System.EventHandler(this.openFileFunc);

            //menu = new MenuStrip();
            //ToolStripMenuItem windowMenu = new ToolStripMenuItem("window", null, new EventHandler());

            buttonConfirmar.Click += new System.EventHandler(this.btnConfirmarClick);

            labelLogin.Location = new Point (10, 30);
            textBoxLogin.Location = new Point (60, 30);

            labelSenha.Location = new Point (10, 30);
            textBoxSenha.Location = new Point (60, 30);

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
            //this.Controls.Add(labelLogin);
            //this.Controls.Add(labelSenha);
            ///this.Controls.Add(textBoxLogin);
            ///this.Controls.Add(textBoxSenha);
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
            this.Controls.Add(calendario);
            this.Controls.Add(dtPicker);  
            this.Controls.Add(barraLoading); 
            this.Controls.Add(tabContral);
            this.Controls.Add(trackBar);
            this.Controls.Add(openFile);
         }

        private void helpLink(object sender, LinkLabelLinkClickedEventArgs e){
            this.linkLabel.LinkVisited = true;

            System.Diagnostics.Process.Start("C:/Program Files(x86)/Google/Chrome/Application/chrome.exe");
        }

        public void openFileFunc(object sender, EventArgs args){
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Filter = "Arquivo de Texto (*.TXT)| *.txt";
            if(dialog.ShowDialog( )!= DialogResult.Cancel){
                StreamReader arquivo = new StreamReader(dialog.FileName);
                String conteudo = arquivo.ReadLine();
                arquivo.Dispose();

                MessageBox.Show(conteudo);
                this.textBoxLogin.Text = conteudo;

            }
        }

        private void btnConfirmarClick(object sender, EventArgs args){

            List<RadioButton> radios = this.groupRadios.Controls.OfType<RadioButton>().ToList();
            RadioButton radio3 = radios.FirstOrDefault(radio3=> radio3.Checked);

            for(int i=0; i<=50; i++){
                barraLoading.PerformStep();
            }

            MessageBox.Show(
                $"Login: {this.textBoxLogin.Text} \n"+
                $"Senha: {this.textBoxSenha.Text} \n\n"+
                $"Selecionado: {this.comboOpcao.SelectedItem } \n\n"+
                $"Marcado: {(this.radioSim.Checked ? "Sim" : this.radioNao.Checked ? "Não" : "Não Selecionado" )} \n\n"+
                $"CheckBox: {(this.checkLi.Checked ? "Marcado" : "Desmarcado")}\n\n"+
                $"CheckBox: {this.textBoxMascarado.Text}\n\n"+
                $"Calendario: {(this.calendario.SelectionRange.Start)}\n\n"+
                $"Calendario: {(this.calendario.SelectionRange.End)}\n\n"+
                $"Date Piker: {(this.dtPicker.Value)}",
                "Titulo",
                MessageBoxButtons.OK
            );
        }
        private void btnCancelarClick(object sender, EventArgs args){
            
        }
     }
}
