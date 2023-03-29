
namespace PrimerchikRPM2
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;

    public partial class AbonentEntities : DbContext
    {
        private static AbonentEntities context;

        public static AbonentEntities GetContext()
        {
            if (context == null)
                context = new AbonentEntities();
            return context;
        }
    }
}

