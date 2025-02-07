namespace Catalogue.Models
{
    using System;
    using System.Data.Entity;
    using System.Linq;
    /// <summary>
    /// 
    /// </summary>
    public class Context : DbContext
    {
        // Your context has been configured to use a 'Context' connection string from your application's 
        // configuration file (App.config or Web.config). By default, this connection string targets the 
        // 'Catalogue.Models.Context' database on your LocalDb instance. 
        // 
        // If you wish to target a different database and/or database provider, modify the 'Context' 
        // connection string in the application configuration file.
        /// <summary>
        /// 
        /// </summary>
        public Context()
            : base("name=Context")
        {
        }

        // Add a DbSet for each entity type that you want to include in your model. For more information 
        // on configuring and using a Code First model, see http://go.microsoft.com/fwlink/?LinkId=390109.
        /// <summary>
        /// Products Collection
        /// </summary>
        public DbSet<Product> Products { get; set; }

        /// <summary>
        /// Orders Collection
        /// </summary>
        public DbSet<Order> Orders { get; set; }

        /// <summary>
        /// Promotions Collection
        /// </summary>
        public DbSet<Promotion> Promotions { get; set; }
    }

    //public class MyEntity
    //{
    //    public int Id { get; set; }
    //    public string Name { get; set; }
    //}
}