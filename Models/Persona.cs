﻿namespace DockerMVC.Models
{
    public class Persona
    {
        public int Id { get; set; }
        public string Nombre { get; set; } = string.Empty;
        public string Apellido { get; set; } = string.Empty;
        public string NumeroDocumento {  get; set; } = string.Empty;
    }
}
