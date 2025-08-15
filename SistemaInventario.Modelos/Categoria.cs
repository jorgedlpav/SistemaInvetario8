using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaInventario.Modelos
{
    public class Categoria
    {
        [Key]
        public int Id { get; set; }
        [Required(ErrorMessage ="Nombre Requerido")]
        [MaxLength(60, ErrorMessage ="el nombre debe ser maximo de 60 caracteres") ]
        public string Nombre { get; set; }
        [Required(ErrorMessage ="descripcion Requrido")]
        [MaxLength(100,ErrorMessage ="la descripcion debe ser maximo de 100 caracteres")]
        public string Descripcion { get; set; }
        [Required(ErrorMessage ="Estado es requerido")]
        public bool Estado { get; set; }


    }
}
