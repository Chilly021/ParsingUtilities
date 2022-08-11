using System.Collections.Generic;
using System.IO;


namespace Kesmai.Server.Items
{
	public partial class PolarBearJacket : Jacket
	{
        /// <inheritdoc />
		public  uint BasePrice => 20;

        /// <inheritdoc />
		public  int Weight => 1600;

		/// <inheritdoc />
		public  int Hindrance => 0;
		
		/// <inheritdoc />
		public  int ProtectionFromIce => 10;

        /// <summary>
		/// Initializes a new instance of the <see cref="PolarBearJacket"/> class.
		/// </summary>
		public PolarBearJacket() 
		{
		}

       
	}
}
