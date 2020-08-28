using System;
using System.ComponentModel.DataAnnotations;

namespace UCDB.Models
{
    public class Pedido
    {
        [Key]
        public int Id { get; set; }

        [MaxLength(50, ErrorMessage ="O campo nao pode ser maior que {1} caracteres")]
        [MinLength(3, ErrorMessage = "O campo nao pode ser menor que {1} caracteres")]
        public string NomeProduto { get; set; }

        public decimal Valor { get; set; }

        public DateTime Vencimento { get; set; }
    }
}