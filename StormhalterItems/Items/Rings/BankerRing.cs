using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace Kesmai.Server.Items
{
	public partial class BankerRing : Ring
	{
		private static uint _carryLimit = 4000000000;
			
		private uint _consumed;
		
		/// <inheritdoc />
		public  uint BasePrice => 5000;

		/// <summary>
		/// Gets the gold held by this ring.
		/// </summary>
		
		
		public uint Consumed
		{
			get => _consumed;
			set => _consumed = Math.Min(value, _carryLimit); /* The amount can never be greater than the limit. */
		}

		/// <summary>
		/// Initializes a new instance of the <see cref="BankerRing"/> class.
		/// </summary>
		public BankerRing() 
		{
		}
	}
}