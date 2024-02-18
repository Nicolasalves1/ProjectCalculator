using System.ComponentModel.DataAnnotations;
using System.Data;

namespace CrudOperations.Models
{
    public class Calculadora
    {
        public int id { get; set; }

        public string operator_name { get; set; }

        public int resultad { get; set; }

        public string result_even_odd { get; set; }

        public string resultadoPrime { get; set; }

        public DateTime data { get; set; }
    }
}
