using System.Collections.Generic;
using System.IO;


namespace Kesmai.Server.Items
{
	public partial class DragonSkull : Helmet
	{
		/// <inheritdoc />
		public  int LabelNumber => 6000085;

		/// <inheritdoc />
		public  uint BasePrice => 1000;

		/// <inheritdoc />
		public  int Weight => 80;

		/// <inheritdoc />
		public  int ProtectionFromStun => 10;
		
		/// <inheritdoc />
		public  int ProtectionFromFire => 5;
		
		/// <inheritdoc />
		public  int ProtectionFromIce => 0;
		
		/// <inheritdoc />
        public  bool ProvidesNightVision => true;

		/// <summary>
		/// Initializes a new instance of the <see cref="DragonSkull"/> class.
		/// </summary>
		public DragonSkull() 
		{
		}		
	}
}