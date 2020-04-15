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
         Label label1;
        Label label2;
         Button buttonLimpar;
         Button buttonConfirmar;

         TextBox textBoxLogin;
         TextBox textBoxSenha;
         public Formulario(){
            this.Text = "Login Sistema";
            this.BackColor = Color.FromArgb(200,200,200);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Height = 200;

            label1 = new Label();
            label2 = new Label();
            textBoxLogin = new TextBox();
            textBoxSenha = new TextBox();
            buttonLimpar = new Button ();
            buttonConfirmar = new Button ();

            // Define a localização da label
            label1.Location = new Point (this.Width/3, 5);
            label2.Location = new Point (label1.Left, label1.Height + textBoxLogin.Height + label1.Top + 10);
            // Define o texto que será mostrado
            label1.Text = "Login";
            label2.Text = "Senha";
            label1.ForeColor = Color.FromArgb(50,50,200);
            label2.ForeColor = Color.FromArgb(50,50,200);
            // Adiciona a label no form

            // permite que ele tenha retorno de informação
            textBoxLogin.AcceptsReturn = true;
            textBoxSenha.AcceptsReturn = true;
            // nao permite a utilização de tab
            textBoxLogin.AcceptsTab = false;
            textBoxSenha.AcceptsTab = false;
            // da a posição para o textbox
            textBoxLogin.Location = new Point (this.Width/3, label1.Height+ 10);
            textBoxSenha.Location = new Point (textBoxLogin.Left, textBoxLogin.Height + label1.Height + label2.Height + label1.Top + 10);

            buttonLimpar.Text = "Limpar";
            // Define a localização em tela com coordenadas X e Y do botão
            buttonLimpar.Location = new Point (this.Width/5,  label1.Height + textBoxLogin.Height +  label2.Height + textBoxLogin.Height + label1.Top + 20);

            buttonConfirmar.Text = "Enviar";
            // Define a localização botão 2 baseado no botão 1
            buttonConfirmar.Location = new Point(buttonLimpar.Left + buttonLimpar.Width + 20, buttonLimpar.Top);

            buttonLimpar.BackColor = Color.FromArgb(200,50,50);
            buttonConfirmar.BackColor = Color.FromArgb(50,200,50);

            buttonConfirmar.Click += new System.EventHandler(this.btnConfirmarClick);

            // adiciona-se ele no form
            this.Controls.Add(label1);
            this.Controls.Add(label2);
            this.Controls.Add(textBoxLogin);
            this.Controls.Add(textBoxSenha);
            this.Controls.Add(buttonConfirmar);
            this.Controls.Add(buttonLimpar);
         }
        private void btnConfirmarClick(object sender, EventArgs args){
            MessageBox.Show(
                $"Login: {this.textBoxLogin.Text} \n"+
                $"Senha: {this.textBoxLogin.Text} \n",
                "Titulo",
                MessageBoxButtons.OK
            );
        }
        private void btnCancelarClick(object sender, EventArgs args){
            
        }
     }
}
