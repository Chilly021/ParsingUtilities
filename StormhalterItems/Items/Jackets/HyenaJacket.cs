using System.Collections.Generic;
using System.IO;


namespace Kesmai.Server.Items
{
	public partial class HyenaJacket : Jacket
	{
        /// <inheritdoc />
		public  uint BasePrice => 20;

        /// <inheritdoc />
		public  int Weight => 1300;

        /// <inheritdoc />
		public  int Category => 10;

        /// <summary>
		/// Initializes a new instance of the <see cref="HyenaJacket"/> class.
		/// </summary>
		public HyenaJacket() 
		{
		}
        
	}
}
