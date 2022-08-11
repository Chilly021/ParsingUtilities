using System;
using System.Collections.Generic;
using System.IO;





namespace Kesmai.Server.Items
{
	public partial class StunDeathProtectionBracelet : Bracelet
	{
		/// <inheritdoc />
		public  uint BasePrice => 3000;

		/// <inheritdoc />
		public  int Weight => 4;

		/// <summary>
		/// Initializes a new instance of the <see cref="StunDeathProtectionBracelet"/> class.
		/// </summary>
		public StunDeathProtectionBracelet() { }
		
	}
}
