using System;
using System.Collections.Generic;
using System.IO;




namespace Kesmai.Server.Items
{
	public partial class RamSkull : Helmet
	{
		/// <inheritdoc />
		public  int LabelNumber => 6000085;
		
		/// <inheritdoc />
		public  uint BasePrice => 300;

		/// <inheritdoc />
		public  int Weight => 80;

		/// <inheritdoc />
		public  int ProtectionFromStun => 5;
		
		/// <inheritdoc />
		public  int ProtectionFromFire => 0;
		
		/// <inheritdoc />
		public  int ProtectionFromIce => 0;

		/// <summary>
		/// Initializes a new instance of the <see cref="RamSkull"/> class.
		/// </summary>
		public RamSkull()
		{
		}

	}
}