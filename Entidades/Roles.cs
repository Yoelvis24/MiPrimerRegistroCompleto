using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;

namespace PrimerRegistroCompleto.Entidades
{
    public class Roles
    {
        [Key]

        public int RolId { get; set; }
        public DateTime FechaCreacion { get; set; }
        public string Descripcion { get; set; }

        public Roles()
        {
            RolId = 0;
            FechaCreacion = DateTime.Now;
            Descripcion = string.Empty;
        }
    }
}
