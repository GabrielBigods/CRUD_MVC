using System.ComponentModel.DataAnnotations.Schema;

namespace CrudMvc.Models
{

    [Table("Cliente")]
    public class Cliente
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public string Email { get; set; }

        public string CPF { get; set; }
        
        public string RG { get; set; }

        public string Rua { get; set; }

        public int Numero { get; set; }

        public string Bairro { get; set; }  

        public string Cidade { get; set; }



    }
}
