
using System.ComponentModel.DataAnnotations;

namespace tallermvc.Models{

    public class UsuarioAcceso{

        [Required]
        public string usuario{ get;set; }
        [Required]
        public string password{ get;set; }

    }

}