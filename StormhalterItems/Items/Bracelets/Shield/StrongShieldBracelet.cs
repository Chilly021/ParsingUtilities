using System;
using System.Collections.Generic;
using System.IO;




namespace Kesmai.Server.Items
{
	public partial class StrongShieldBracelet : ShieldBracelet
	{
		/// <inheritdoc />
		public  uint BasePrice => 2500;

		/// <inheritdoc />
		public  int Weight => 4;
		
		/// <inheritdoc />
		public  int Shield => 6;
		
		/// <summary>
		/// Initializes a new instance of the <see cref="StrongShieldBracelet"/> class.
		/// </summary>
		public StrongShieldBracelet() 
		{
		}

	
	}
}
