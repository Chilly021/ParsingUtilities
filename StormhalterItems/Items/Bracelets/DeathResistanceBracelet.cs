using System;
using System.Collections.Generic;
using System.IO;





namespace Kesmai.Server.Items
{
	public partial class DeathResistanceBracelet : Bracelet
	{
		/// <inheritdoc />
		public  uint BasePrice => 1500;

		/// <inheritdoc />
		public  int Weight => 4;

		/// <summary>
		/// Initializes a new instance of the <see cref="DeathResistanceBracelet"/> class.
		/// </summary>
		public DeathResistanceBracelet() 
		{
		}

	}
}
