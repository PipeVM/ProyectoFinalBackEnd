using BackEndPCI.Models;
using Microsoft.EntityFrameworkCore;

namespace BackEndPCI
{   
    // CONTEXT O DB CONTEXT SE SUELE UTILIZAR PARA DEFINIR A LA CLASE QUE SE ENCARGA DE VINCULAR EL BACKEND CON LA BASE DE DATOS
    public class AppDBContext: DbContext 
    // Importacion de DbContext con EntityFrameworkCore - Crea una instancia en la DataBase 
   
    {
        public DbSet<TarjetaCredito> TarjetaCredito { get; set; }
        // TarjetaCredito {get;set} -> Defino el Nombre de la Tabla de la DataBase
        // Configuracion de DBSet - Mapear Modelo (TarjetaCredito) Con la tabla de DataBase
        
        
        public AppDBContext(DbContextOptions<AppDBContext> options): base(options)
        // Controlador que recibe como parametro DbContextOptions<AppDBContext>
        {
        }
    }
}
