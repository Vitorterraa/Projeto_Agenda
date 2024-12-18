﻿using MySqlConnector;
using ProjetoAgenda.Controller;
using ProjetoAgenda.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetoAgenda
{
    public partial class frmCadastro : Form
    {
        public frmCadastro()
        {
            InitializeComponent();
        }
        private void MinimoDeCaracter()
        {
            if (txtSenha.Text.Length >= 8 && txtSenhaRep.Text.Length >= 8 && txtNome.Text.Length > 1 && txtUsuário.Text.Length > 2 && txtSenha.Text == txtSenhaRep.Text)
            {
                btnCadastro.Enabled = true;
            }
            else
            {
                btnCadastro.Enabled = false;
            }
        }

        private void frmCadastro_FormClosed(object sender, FormClosedEventArgs e)
        {

        }

        private void btnEntrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtSenha_TextChanged(object sender, EventArgs e)
        {
            MinimoDeCaracter();
        }



        private void txtNome_TextChanged(object sender, EventArgs e)
        {
            MinimoDeCaracter();
        }

        private void txtUsuário_TextChanged(object sender, EventArgs e)
        {
            MinimoDeCaracter();
        }

        private void txtTelefone_TextChanged(object sender, EventArgs e)
        {
            MinimoDeCaracter();
        }

        private void txtSenhaRep_TextChanged(object sender, EventArgs e)
        {
            MinimoDeCaracter();
        }

        private void btnCadastro_Click(object sender, EventArgs e)
        {
            string nome = txtNome.Text;
            string usuario = txtUsuário.Text;
            string telefone = txtTelefone.Text;
            string senha = txtSenha.Text;

            UsuarioController controleUsuario = new UsuarioController();

            bool resultado = controleUsuario.AddUsuario(nome, usuario, telefone, senha);

            if (resultado)
            {
                MessageBox.Show("Cadastro efetuado com sucesso!!");
            }
            
        }
    }
}
