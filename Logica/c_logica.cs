﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logica
{
    public class c_logica
    {
        public string MtdFechaHoy()
        {
            return DateTime.Now.ToString("d");
        }


        public static int MtdPrecioPorDia(int posicion)
        {
            int precio = 0;
            switch (posicion)
            {
                case 0:
                    precio = 200;
                    break;

                case 1:
                    precio = 500;
                    break;

                case 2:
                    precio = 1000;
                    break;

                case 3:
                    precio = 2000;
                    break;
                default:
                    precio = 0;
                    break;
            }
            return precio;
        }

    }

}
