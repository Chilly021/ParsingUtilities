using System.Collections.Generic;
using System.IO;


namespace Kesmai.Server.Items
{
	public partial class WingedHelm : Helmet
	{
		private bool _provideNightVision;
		
		/// <inheritdoc />
		public  int LabelNumber => 6000049;

		/// <inheritdoc />
		public  uint BasePrice => 800;

		/// <inheritdoc />
		public  int Weight => 80;

		/// <inheritdoc />
		public  int ProtectionFromStun => 10;
		
		/// <inheritdoc />
		public  int ProtectionFromFire => 0;
		
		/// <inheritdoc />
		public  int ProtectionFromIce => 0;
		
		/// <inheritdoc />
		public  bool ProvidesNightVision => _provideNightVision;

		
		/// <summary>
		/// Initializes a new instance of the <see cref="WingedHelm"/> class.
		/// </summary>
		public WingedHelm() 
		{
	
		}

	}
}