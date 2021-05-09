﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    /// <summary>
    /// No podrá tener clases heredadas.
    /// </summary>
    public sealed class Taller
    {
        
        public enum ETipo
        {
            Moto, Automovil, Camioneta, Todos
        }

        List<Vehiculo> vehiculos;
        int espacioDisponible;

        #region "Constructores"



        /// <summary>
        /// constructor por defecto que instancia la lista
        /// </summary>
        private Taller()
        {
            this.vehiculos = new List<Vehiculo>();
        }

        /// <summary>
        /// constructor con parametros
        /// </summary>
        /// <param name="espacioDisponible"></param>
        public Taller(int espacioDisponible):this()
        {
            this.espacioDisponible = espacioDisponible;
        }
        #endregion

        #region "Sobrecargas"
        /// <summary>
        /// Muestro el estacionamiento y TODOS los vehículos
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return Listar(this, ETipo.Todos);
        }
        #endregion

        #region "Métodos"

        /// <summary>
        /// Expone los datos del elemento y su lista (incluidas sus herencias)
        /// SOLO del tipo requerido
        /// </summary>
        /// <param name="taller">Elemento a exponer</param>
        /// <param name="ETipo">Tipos de ítems de la lista a mostrar</param>
        /// <returns>objeto string de la lista correspondiente</returns>
        public string Listar(Taller taller, ETipo tipo)
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendFormat("Tenemos {0} lugares ocupados de un total de {1} disponibles", taller.vehiculos.Count, taller.espacioDisponible);
            sb.AppendLine("");
            foreach (Vehiculo v in taller.vehiculos)
            {
                switch (tipo)
                {
                    case ETipo.Camioneta:
                        sb.AppendLine(v.Mostrar());
                        break;
                    case ETipo.Moto:
                        sb.AppendLine(v.Mostrar());
                        break;
                    case ETipo.Automovil:
                        sb.AppendLine(v.Mostrar());
                        break;
                    default:
                        sb.AppendLine(v.Mostrar());
                        break;
                }
            }

            return sb.ToString();
        }
        #endregion

        #region "Operadores"
        /// <summary>
        /// Agregará un elemento a la lista
        /// </summary>
        /// <param name="taller">Objeto donde se agregará el elemento</param>
        /// <param name="vehiculo">Objeto a agregar</param>
        /// <returns>lista taller </returns>
        public static Taller operator +(Taller taller, Vehiculo vehiculo)
        {
            if(taller.vehiculos.Count < taller.espacioDisponible) 
            {
                foreach (Vehiculo v in taller.vehiculos)
                {
                    if (v == vehiculo) 
                    {
                        return taller;
                    }
                        
                }

                taller.vehiculos.Add(vehiculo);
            }

            
            return taller;
        }
        /// <summary>
        /// Quitará un elemento de la lista
        /// </summary>
        /// <param name="taller">Objeto donde se quitará el elemento</param>
        /// <param name="vehiculo">Objeto a quitar</param>
        /// <returns>regresa la lista taller</returns>
        public static Taller operator -(Taller taller, Vehiculo vehiculo)
        {
            foreach (Vehiculo v in taller.vehiculos)
            {
                if (v == vehiculo)
                {
                    taller.vehiculos.Remove(v);
                    return taller;
                  
                }
            }

            return taller;
        }
        #endregion
    }
}
