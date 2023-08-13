using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using VirtuaConecta.Outbound.Business;
using VirtuaConecta.Livraria.Model;
using VirtuaConecta.Outbound.Utility;
using xDialog;

namespace VirtuaConecta.Outbound.AI
{
    public partial class Form_login : Form
    {
        String RevalidarLogin = "N";
        Business.BaseBis.IusuarioBll _iusuario;
        public Form_login()
        {
            InitializeComponent();
            _iusuario = Factory.CriaUsuarioBLL();
        }


        private void Ph_txt_userName_PlaceholderActiveChanged(object sender, PlaceholderActiveChangedEventArgs e)
        {

        }
        private void confirmar_Click()
        {
            var login = placeholderTextBox1.Text;
            var senha = placeholderTextBox2.Text;

            if (!String.IsNullOrEmpty(login) && !String.IsNullOrEmpty(senha))
            {

                //Captura os dados de login
                VarGlobal.LoginName = login;
                VarGlobal.Password = senha;

                var users = _iusuario.ListaUsuarios();

                var userExist = users.Where(x => x.LoginUsuario == login.ToLower()).FirstOrDefault();



                if (userExist != null && userExist.Bloqueado == 1)
                {
                    DialogResult result = MsgBox.Show("Usuario Bloqueado", "Erro ao logar", MsgBox.Buttons.OK, MsgBox.Icon.Error, MsgBox.AnimateStyle.FadeIn);
                }

                else if (userExist != null && userExist.Bloqueado == 0)
                {
                    var senhaCrypto = Conversoes.MD5Hash(senha);

                    // validando a senha do usuario
                    if (senhaCrypto == userExist.SenhaUsuario)
                    {



                        if (RevalidarLogin == "N")
                        {
                            this.DialogResult = DialogResult.OK;
                            VarGlobal.Id_usr = userExist.Id;
                        }
                        else
                        {
                            this.Close();
                        }

                    }
                    else
                    {
                        DialogResult result = MsgBox.Show("Necessário login e senha validos", "Erro ao logar", MsgBox.Buttons.OK, MsgBox.Icon.Error, MsgBox.AnimateStyle.FadeIn);

                        if (RevalidarLogin == "S")
                        {

                            this.Close();
                        }

                    }
                }
            }
            else
            {
                DialogResult result = MsgBox.Show("Necessário login e senha validos", "Erro ao logar", MsgBox.Buttons.OK, MsgBox.Icon.Error, MsgBox.AnimateStyle.FadeIn);


            }
        }

        private void btnLogar_Click(object sender, EventArgs e)
        {
            confirmar_Click();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Form_login_Load(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(VarGlobal.LoginName))
            {
                RevalidarLogin = "S";
            }
        }

        private void Form_login_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyValue.Equals(27)) //ESC
            {
                this.Close();
            }

            if (e.KeyValue.Equals(13)) //Enter
            {
                this.confirmar_Click();

            }
        }
    }
}
