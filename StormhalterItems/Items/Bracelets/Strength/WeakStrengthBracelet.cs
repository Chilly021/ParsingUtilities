using System;
using System.Collections.Generic;
using System.IO;




namespace Kesmai.Server.Items
{
	public partial class WeakStrengthBracelet : StrengthBracelet
	{
		/// <inheritdoc />
		public  uint BasePrice => 500;

		/// <inheritdoc />
		public  int Weight => 4;
		
		/// <inheritdoc />
		public  int StrengthBonus => 1;

		/// <summary>
		/// Initializes a new instance of the <see cref="WeakStrengthBracelet"/> class.
		/// </summary>
		public WeakStrengthBracelet() 
		{
		}
	
	}
}
