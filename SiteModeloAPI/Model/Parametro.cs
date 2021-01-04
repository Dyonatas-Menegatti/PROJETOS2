using System;
using System.ComponentModel.DataAnnotations;
using Microsoft.EntityFrameworkCore;

namespace SiteModeloAPI.Model
{
    public class Parametro
    {
        [Key]
        public int PessoaId { get; set; }

        public string Nome { get; set; }

        public string Cidade { get; set; }

    }
}