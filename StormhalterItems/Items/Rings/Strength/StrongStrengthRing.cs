using System;
using System.Collections.Generic;
using System.IO;



namespace Kesmai.Server.Items
{
	public partial class StrongStrengthRing : StrengthRing
	{
		/// <summary>
		/// Gets the price.
		/// </summary>
		public  uint BasePrice => 1500;

		/// <summary>
		/// Gets the weight.
		/// </summary>
		public  int Weight => 20;

		public  int StrengthBonus => 6;
		
		/// <summary>
		/// Initializes a new instance of the <see cref="StrongStrengthRing"/> class.
		/// </summary>
		public StrongStrengthRing() 
		{
		}

	}
}
