using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Semente.Models
{
    class Usuario
    {
        private int con_id;
        private string con_nome, con_email, con_senha;
        private bool con_admin;

        public Usuario()
        {
            this.Id = 0;
            this.Nome = "";
            this.Email = "";
            this.Senha = "";
            this.Admin = false;
        }

        public Usuario(int id, string nome, string email, string senha, bool admin)
        {
            this.Id = id;
            this.Nome = nome;
            this.Email = email;
            this.Senha = senha;
            this.Admin = admin;
        }
        
        public int Id
        {
            get { return con_id; }
            set { con_id = value; }
        }

        public string Nome
        {
            get { return con_nome; }
            set { con_nome = value; }
        }

        public string Email
        {
            get { return con_email; }
            set { con_email = value; }
        }

        public string Senha
        {
            get { return con_senha; }
            set { con_senha = value; }
        }

        public bool Admin
        {
            get { return con_admin; }
            set { con_admin = value; }
        }

    }
}
