using System;
using System.Collections.Generic;
using System.IO;






namespace Kesmai.Server.Items
{
	public partial class StrengthRing : Ring
	{
		/// <summary>
		/// Gets the price.
		/// </summary>
		public  uint BasePrice => 1000;

		/// <summary>
		/// Gets the weight.
		/// </summary>
		public  int Weight => 20;

		
		
		public virtual int StrengthBonus => 3;

		public StrengthRing() 
		{
		}
		
	}
}
