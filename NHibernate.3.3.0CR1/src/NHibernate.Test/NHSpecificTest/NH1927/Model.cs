using System;
using IESI = Iesi.Collections.Generic;

namespace NHibernate.Test.NHSpecificTest.NH1927
{
    public class Customer 
    {
        public virtual int ID { get; protected set; }
        public virtual IESI.ISet<Invoice> Invoices { get; set; }
        public virtual DateTime ValidUntil { get; set; }
    }

	public class Invoice
	{
		public virtual int ID { get; protected set; }
        public virtual DateTime ValidUntil { get; set; }
        public virtual Customer Customer { get; set; }
    }
}
