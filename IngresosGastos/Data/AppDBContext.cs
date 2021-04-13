using IngresosGastos.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace IngresosGastos.Data
{
    public class AppDBContext : DbContext
    {
        public AppDBContext() : base("DefaultConnection") //del connectionStrings que agregamos en el webconfig, especificamos cual es el que utilizara
        {
                
        }

        public DbSet<IngresosGastosJRC> IngresosGastos { get; set; }

        /**
         * tutorial https://www.udemy.com/course/aprende-aspnet-mvc-framework-y-base-de-datos-ms-sql-server
         Comandos para la consola del administrador de paquetes 
        enable-migrations
         */
    }
}