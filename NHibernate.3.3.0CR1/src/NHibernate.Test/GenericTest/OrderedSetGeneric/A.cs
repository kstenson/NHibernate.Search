using IESI = Iesi.Collections.Generic;

namespace NHibernate.Test.GenericTest.OrderedSetGeneric
{
	public class A
	{
		private ISet<B> _items = new OrderedSet<B>();

		public int Id { get; set; }

		public string Name { get; set; }

		public virtual ISet<B> Items
		{
			get { return _items; }
			set { _items = value; }
		}
	}
}
