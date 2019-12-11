using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace ClubReg.Models
{
    public class ClubRegContext : DbContext
    {
        // You can add custom code to this file. Changes will not be overwritten.
        // 
        // If you want Entity Framework to drop and regenerate your database
        // automatically whenever you change your model schema, please use data migrations.
        // For more information refer to the documentation:
        // http://msdn.microsoft.com/en-us/data/jj591621.aspx
    
        public ClubRegContext() : base("name=ClubRegContext")
        {
        }

        public System.Data.Entity.DbSet<ClubReg.Models.Socios> Socios { get; set; }

        public System.Data.Entity.DbSet<ClubReg.Models.Afiliado> Afiliadoes { get; set; }

        
    }
}
