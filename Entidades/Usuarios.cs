using System;
using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;
using System.Text;

namespace PrimerRegistroCompleto.Entidades
{
    public class Usuarios
    {
        public int UsuarioId { get; set; }
        public float Costo { get; set; }
        public string Alias { get; set; }
        public string Nombres { get; set; }
        public string Email { get; set; }
        public string Clave { get; set; }
        public bool Activo { get; set; }
        public string Rol { get; set; }
    }
}
