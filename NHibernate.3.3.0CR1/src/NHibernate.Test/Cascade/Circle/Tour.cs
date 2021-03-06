﻿using System;
using IESI = Iesi.Collections.Generic;

namespace NHibernate.Test.Cascade.Circle
{
	public class Tour
	{
		private long tourId;
		private long version;
		private string name;
		private IESI.ISet<Node> nodes = new IESI.HashedSet<Node>();
		
		public virtual long TourId
		{
			get { return tourId; }
			set { tourId = value; }
		}
		
		public virtual long Version
		{
			get { return version; }
			set { version = value; }
		}
		
		public virtual string Name
		{
			get { return name; }
			set { name = value; }
		}
		
		public virtual IESI.ISet<Node> Nodes
		{
			get { return nodes; }
			set { nodes = value; }
		}
	}
}