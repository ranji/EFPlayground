namespace EFPlayground
{
    using System;
    using System.Data.Entity;
    using System.Linq;

    public class Affinity : DbContext
    {
        // Your context has been configured to use a 'Affinity' connection string from your application's 
        // configuration file (App.config or Web.config). By default, this connection string targets the 
        // 'EFPlayground.Affinity' database on your LocalDb instance. 
        // 
        // If you wish to target a different database and/or database provider, modify the 'Affinity' 
        // connection string in the application configuration file.
        public Affinity()
            : base("name=Affinity")
        {
        }

        // Add a DbSet for each entity type that you want to include in your model. For more information 
        // on configuring and using a Code First model, see http://go.microsoft.com/fwlink/?LinkId=390109.

        public virtual DbSet<BaseUserAffinity> UserAffinities { get; set; }
        public virtual DbSet<Content> Contents { get; set; }
     }
}