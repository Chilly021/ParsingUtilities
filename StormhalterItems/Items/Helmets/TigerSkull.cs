using System;
using System.Collections.Generic;
using System.IO;




namespace Kesmai.Server.Items
{
	public partial class TigerSkull : Helmet
	{
		/// <inheritdoc />
		public  int LabelNumber => 6000085;

		/// <inheritdoc />
		public  uint BasePrice => 500;

		/// <inheritdoc />
		public  int Weight => 80;

		/// <inheritdoc />
		public  int ProtectionFromStun => 7;
		
		/// <inheritdoc />
		public  int ProtectionFromFire => 0;
		
		/// <inheritdoc />
		public  int ProtectionFromIce => 0;

		/// <summary>
		/// Initializes a new instance of the <see cref="TigerSkull"/> class.
		/// </summary>
		public TigerSkull() 
		{
		}
	}
}