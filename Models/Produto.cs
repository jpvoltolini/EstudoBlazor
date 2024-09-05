using System.ComponentModel.DataAnnotations;

namespace BlazorWebAssembCurso.Models
{
    public class Produto
    {
        [Required(ErrorMessage ="Campo Obrigatório")]
        public string Nome { get; set; }

        [Required]
        [Range(1,100, ErrorMessage ="Apenas até 100 unidades") ]
        public int Quantidade { get; set; }
        
        [Required]
        [Range(0.1, 100, ErrorMessage = "Apenas até 100 pila")]
        public double Preco { get; set; }
    
    
        public double ValorEstoqueTotal()
        {
            return Preco*Quantidade; 
        }


    }
}
