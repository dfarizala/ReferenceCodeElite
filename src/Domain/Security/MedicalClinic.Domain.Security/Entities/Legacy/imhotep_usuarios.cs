using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MedicalClinic.Domain.Security.Entities.Legacy{

    [Table("imhotep_usuarios")]
    public class imhotep_usuarios
    {
        [Key]
        public string cod_usuario { get; set; }

        public string nom_usuario { get; set; }

        public string carg_usuario { get; set; }

        public string clave_usuario { get; set; }

        public string activo { get; set; }

        public string e_mail { get; set; }
    }
}