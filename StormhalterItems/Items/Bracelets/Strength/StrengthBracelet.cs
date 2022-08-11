using System;
using System.Collections.Generic;
using System.IO;


namespace Kesmai.Server.Items
{
	public partial class StrengthBracelet : Bracelet
	{
		/// <inheritdoc />
		public  uint BasePrice => 1000;

		/// <inheritdoc />
		public  int Weight => 4;
		
		/// <inheritdoc />
		
		
		public virtual int StrengthBonus => 3;

		/// <summary>
		/// Initializes a new instance of the <see cref="StrengthBracelet"/> class.
		/// </summary>
		public StrengthBracelet() 
		{
		}

	
	}
}
