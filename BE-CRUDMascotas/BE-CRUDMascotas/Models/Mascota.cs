﻿using System.Data;

namespace BE_CRUDMascotas.Models
{
    public class Mascota
    {
        public int Id { get; set; }
        public string Raza { get; set; }

        public string Color { get; set; }
        public int Edad { get; set; }

        public float Peso { get; set; }

        public DateTime FechaCreacion { get; set; }
    }
}
