﻿namespace API_Serviciokankuamo.DTOs
{
    public class Usuario
    {
        public int IdUsuario { get; set; }
        public string Nombres { get; set; }
        public string Apellidos { get; set; }
        public string Correo { get; set; }
        public bool DeseaHabilitarServicio { get; set; }
    }
}
