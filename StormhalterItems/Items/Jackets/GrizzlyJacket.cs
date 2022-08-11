using System.Collections.Generic;
using System.IO;


namespace Kesmai.Server.Items
{
	public partial class GrizzlyJacket : Jacket
	{
		/// <inheritdoc />
		public  uint BasePrice => 40;

        /// <inheritdoc />
		public  int Weight => 2000;
        
		/// <inheritdoc />
		public  int Hindrance => 0;
		
		/// <inheritdoc />
		public  int ProtectionFromFire => 10;

		/// <summary>
		/// Initializes a new instance of the <see cref="GrizzlyJacket"/> class.
		/// </summary>
		public GrizzlyJacket() 
		{
		}

	}
}
