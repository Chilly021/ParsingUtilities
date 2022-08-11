using System;
using System.Collections.Generic;
using System.IO;



namespace Kesmai.Server.Items
{
	public partial class WeakStrengthRing : StrengthRing
	{
		/// <summary>
		/// Gets the price.
		/// </summary>
		public  uint BasePrice => 500;

		/// <summary>
		/// Gets the weight.
		/// </summary>
		public  int Weight => 20;

		public  int StrengthBonus => 1;

		/// <summary>
		/// Initializes a new instance of the <see cref="WeakStrengthRing"/> class.
		/// </summary>
		public WeakStrengthRing()
		{
		}

	}
}
