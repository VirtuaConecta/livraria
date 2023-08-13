using MaterialSkin;
using MaterialSkin.Controls;
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

namespace VirtuaConecta.Outbound.AI.Configuracoes
{
    public partial class Form_Detalhe_User : MaterialForm
    {
        Form_listaUser _formListUser = new Form_listaUser();
        UsuariosDTO _user = new UsuariosDTO();
        Business.BaseBis.IusuarioBll _iusuario;
        String Acao = "EDITAR";
        public Form_Detalhe_User(Form_listaUser form, UsuariosDTO user)
        {
            InitializeComponent();
            MaterialSkinManager materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = new ColorScheme(
              Primary.Teal400, Primary.Cyan900, Primary.Teal200,
                Accent.Teal700, TextShade.WHITE);

            _formListUser = form;
            _user = user;

            _iusuario = Factory.CriaUsuarioBLL();
        }

        private void Form_Detalhe_User_Load(object sender, EventArgs e)
        {
            ckb_bloqueado.Checked = false;

            if (_user == null)
            {
                Acao = "INSERIR";
                lblAcao.Text = "Inserir usuário";
                mtxtLogin.Enabled = true;
            }
            else
            {
                mtxtLogin.Enabled = false;

                lblAcao.Text = "Editar usuário";
                txtId.Text = _user.Id.ToString();
                mtxtLogin.Text = _user.LoginUsuario;
                mtxtNome.Text = _user.NomeUsuario;
                txtobs.Text = _user.Obs;
                mtxtTelefone.Text = _user.Telefone;
                mtxtEmail.Text = _user.Email;
                ckb_bloqueado.Checked = Convert.ToBoolean(_user.Bloqueado);
                if (_user.IdPerfil == 1)
                {
                    cmbTipoUser.Text = "Usuário Operador";

                }
                else if (_user.IdPerfil == 2)
                {
                    cmbTipoUser.Text = "Usuário Administrador";
                }
             //   mtxtSenha.Text = _user.SenhaUsuario;
            }
        }

        private void btnconfirmar_Click(object sender, EventArgs e)
        {
            String resp = "";
           var userCapturado=  CapturaTela();
            // valida campos
            var respVAlidar = _iusuario.validaUsuario(userCapturado, Acao);
         
            if (respVAlidar == "OK")
            {
        
                if (Acao == "INSERIR")
                {
                    userCapturado.SenhaUsuario = Conversoes.MD5Hash(userCapturado.SenhaUsuario);
                    resp = _iusuario.InsereUsuarios(userCapturado);
                }
                else
                {
                    resp = _iusuario.AtualizaUsuarios(userCapturado);
                }
                if (resp == "OK")
                {
                    MsgBox.Show("Operação bem sucedida!", "Sucesso", MsgBox.Buttons.OK, MsgBox.Icon.Exclamation);
                    this.Encerrar();
                }
                else
                {

                    MsgBox.Show(resp, "Falha", MsgBox.Buttons.OK, MsgBox.Icon.Error);
                }

            }
            else
            {
                MsgBox.Show(respVAlidar, "Erro", MsgBox.Buttons.OK, MsgBox.Icon.Error);
            }
        }

        private UsuariosDTO CapturaTela()
        {

          
            var _user1 = new UsuariosDTO();
            if (String.IsNullOrEmpty(txtId.Text))
            {
                _user1.Id = 0;
            }
            else
            {
                _user1.Id = Convert.ToInt32(txtId.Text);
            }

            if (cmbTipoUser.SelectedItem.ToString() == "Usuário Operador")
            {
                _user1.IdPerfil = 1;
            }
            else if (cmbTipoUser.SelectedItem.ToString() == "Usuário Administrador")
            {
                _user1.IdPerfil = 2;
            }

            _user1.LoginUsuario = mtxtLogin.Text;
            _user1.NomeUsuario = mtxtNome.Text;
            _user1.Obs = txtobs.Text;

            _user1.SenhaUsuario = mtxtSenha.Text;

            _user1.Telefone = mtxtTelefone.Text;
            _user1.Email = mtxtEmail.Text;
            _user1.Bloqueado = Convert.ToInt32(ckb_bloqueado.Checked);


            return _user1;
        }


        private void Encerrar()
        {

            _formListUser.CarregaGrid(null);
            this.Close();
        }
    }
}
