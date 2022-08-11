using System;
using System.Collections.Generic;
using System.IO;




namespace Kesmai.Server.Items
{
	public partial class PowerBracelet : Bracelet
	{
		/// <inheritdoc />
		public  uint BasePrice => 1;

		/// <inheritdoc />
		public  int Weight => 4;

		/// <summary>
		/// Initializes a new instance of the <see cref="PowerBracelet"/> class.
		/// </summary>
		public PowerBracelet()
		{ }
		
	}
}
