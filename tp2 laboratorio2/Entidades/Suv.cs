﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Suv : Vehiculo
    {
        public Suv(EMarca marca, string chasis, ConsoleColor color) : base(chasis, marca, color)
        {
        }
        /// <summary>
        /// SUV son 'Grande'
        /// prpiedad get
        /// </summary>
        protected override ETamanio Tamanio 
        {
            get
            {
                return ETamanio.Grande;
            }
        }


        /// <summary>
        /// metodo que muestra los parametros
        /// </summary>
        /// <returns>objeto string  </returns>
        public override string Mostrar()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine("SUV");
            sb.AppendLine(string.Format(base.Mostrar()));
            sb.AppendLine(string.Format("TAMAÑO : {0}", this.Tamanio));
            sb.AppendLine("");
            sb.AppendLine("---------------------");

            return sb.ToString();
        }
    }
}