using System;
using System.Collections.Generic;
using System.IO;




namespace Kesmai.Server.Items
{
	public partial class StrongStrengthBracelet : StrengthBracelet
	{
		/// <inheritdoc />
		public  uint BasePrice => 1500;

		/// <inheritdoc />
		public  int Weight => 4;
		
		/// <inheritdoc />
		public  int StrengthBonus => 6;

		/// <summary>
		/// Initializes a new instance of the <see cref="StrongStrengthBracelet"/> class.
		/// </summary>
		public StrongStrengthBracelet() 
		{
		}
	}
}
