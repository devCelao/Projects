using DevIO.Business.Core.Models;
using DevIO.Business.Models.Fornecedores;
using System;

namespace DevIO.Business.Models.Produtos
{
    public  class Produto : Entity
    {
        public Guid FornecedorId { get; set; }
        public string Nome { get; set; }
        public string Descricao { get; set; }
        public string Imagem { get; set; }
        public string Valor { get; set; }
        public string UsuarioAUT { get; set; }
        public DateTime DataCadastro { get; set; }
        public DateTime DataAtualizacao { get; set; }
        public bool Ativo { get; set; }

        /* EF Relations */
        public Fornecedor Fornecedor { get; set; }
    }
}
