﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_PBO_Kel_5.Model
{
    internal class Metode_pembayaran
    {
        [Key]
        public int id_metode_pembayaran { get; set; }
        public string metode_pembayaran { get; set; }
        public Metode_pembayaran(int id_metode_pembayaran, string metode_pembayaran)
        {
            this.id_metode_pembayaran = id_metode_pembayaran;
            this.metode_pembayaran = metode_pembayaran;
        }
    }
}
