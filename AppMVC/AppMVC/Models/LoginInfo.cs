using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace AppMVC.Models
{
    public class LoginInfo:UsuarioInfo
    {
        [DisplayName("Login")]
        [Required(ErrorMessage = "Informe o seu nome de usuário"), StringLength(20, ErrorMessage = "Tamanho máximo do campo é {1} caracter(s)")]
        public string Login { get; set; }

        [DisplayName("Senha")]
        [Required(ErrorMessage = "Informe a sua senha"), StringLength(20, ErrorMessage = "Tamanho máximo do campo é {1} caracter(s)")]
        [DataType(DataType.Password)]
        public string Senha { get; set; }

        public bool Ativo { get; set; }

        public bool Logado { get; set; }
    }
}