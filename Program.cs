using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Threading.Tasks;
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
         Button buttonLimpar;
         Button buttonConfirmar;
         TextBox textBoxLogin;
         TextBox textBoxSenha;
         ComboBox comboOpcao;
         GroupBox groupRadios;
         RadioButton radioSim;
         RadioButton radioNao;
         CheckBox checkLi;

         public Formulario(){
            this.Text = "Login Sistema";
            this.BackColor = Color.FromArgb(200,200,200);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Size = new Size(200, 300);

            labelLogin = new Label();
            labelSenha = new Label();
            labelSelect = new Label();
            labelCheck = new Label();
            textBoxLogin = new TextBox();
            textBoxSenha = new TextBox();
            buttonLimpar = new Button ();
            buttonConfirmar = new Button ();
            comboOpcao = new ComboBox();
            radioSim = new RadioButton();
            radioNao = new RadioButton();
            groupRadios = new GroupBox();
            checkLi = new CheckBox();

            labelLogin.Text = "Login";
            labelLogin.Width = 50;
            labelSenha.Text = "Senha";
            labelSenha.Width = 50;
            labelSelect.Text = "Nivel";
            labelSelect.Width = 50;
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

            String[] niveis = {"Selecione", "Inicio", "Meio", "Fim"};
            foreach(String nivel in niveis){
                comboOpcao.SelectedItem = "Selecione";
                comboOpcao.Items.Add(nivel);
            }
            groupRadios.Controls.Add(radioNao);
            groupRadios.Controls.Add(radioSim);

            labelLogin.ForeColor = Color.FromArgb(50,50,200);
            labelSenha.ForeColor = Color.FromArgb(50,50,200);
            labelSelect.ForeColor = Color.FromArgb(50,50,200);
            buttonLimpar.BackColor = Color.FromArgb(200,50,50);
            buttonConfirmar.BackColor = Color.FromArgb(50,200,50);

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

            buttonConfirmar.Location = new Point(10, 220);
            buttonLimpar.Location = new Point (100, 220);

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
         }
        private void btnConfirmarClick(object sender, EventArgs args){

            List<RadioButton> radios = this.groupRadios.Controls.OfType<RadioButton>().ToList();
            RadioButton radio3 = radios.FirstOrDefault(radio3=> radio3.Checked);


            MessageBox.Show(
                $"Login: {this.textBoxLogin.Text} \n"+
                $"Senha: {this.textBoxLogin.Text} \n\n"+
                $"Selecionado: {this.comboOpcao.SelectedItem } \n\n"+
                $"Marcado: {(this.radioSim.Checked ? "Sim" : this.radioNao.Checked ? "Não" : "Não Selecionado" )} \n\n"+
                $"CheckBox: {(this.checkLi.Checked ? "Marcado" : "Desmarcado")}\n\n"/*+
                $"CheckBox: {(radio3.Text)}"*/,
                "Titulo",
                MessageBoxButtons.OK
            );
        }
        private void btnCancelarClick(object sender, EventArgs args){
            
        }
     }
}
