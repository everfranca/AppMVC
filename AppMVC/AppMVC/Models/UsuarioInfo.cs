using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;

namespace AppMVC.Models
{
    public class UsuarioInfo
    {
        [DisplayName("Código")]
        public int codigoUsuario { get; set; }

        [DisplayName("Nome")]
        [Required(ErrorMessage = "Campo obrigatório"), StringLength(20, ErrorMessage = "Tamanho máximo do campo é {1} caracter(s)")]
        public string Nome { get; set; }

        [DisplayName("Sobrenome")]
        [Required(ErrorMessage = "Campo obrigatório"), StringLength(50, ErrorMessage = "Tamanho máximo do campo é {1} caracter(s)")]
        public string Sobrenome { get; set; }

        [DisplayName("Data de Nascimento")]
        [Required(ErrorMessage = "Campo obrigatório")]
        public DateTime DataNascimento { get; set; }
    }
}