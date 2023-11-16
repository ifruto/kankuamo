using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace API_Serviciokankuamo.Models
{
    [Table("tbl_usuario")]
    public class UsuarioModel
    {
        [Key]
        [Column("IdUsuario")]
        public int IdUsuario { get; set; }

        [Column("Nombres")]
        public string Nombres { get; set; }

        [Column("Apellidos")]
        public string Apellidos { get; set; }

        [Column("Correo")]
        public string Correo { get; set; }

        [Column("DeseaHabilitarServicio")]
        public bool DeseaHabilitarServicio { get; set; }
    }
}
