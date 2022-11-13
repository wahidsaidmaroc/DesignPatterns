﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DependencyInjection
{
    public class BonCommande : IPiece
    {
        public int IdCommande { get; set; }
        public DateOnly DateCommande { get; set; }
        public decimal total { get; set; }

        public decimal Total()
        {
            //
            //
            //
            return (total * 1.2M);
        }
    }
}
