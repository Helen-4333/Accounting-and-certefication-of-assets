//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Assets
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class AssetsAccountingEntities : DbContext
    {
        private static AssetsAccountingEntities _context;

        public AssetsAccountingEntities()
            : base("name=AssetsAccountingEntities")
        {
        }

        public static AssetsAccountingEntities GetContext()
        {
            if (_context == null)
                _context = new AssetsAccountingEntities();
            return _context;
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Abonent> Abonent { get; set; }
        public virtual DbSet<AbonentsAddress> AbonentsAddress { get; set; }
        public virtual DbSet<Request> Request { get; set; }
        public virtual DbSet<Service> Service { get; set; }
    }
}
