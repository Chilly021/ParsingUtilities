using System.Collections.Generic;
using System.IO;


namespace Kesmai.Server.Items
{
	public partial class SpiderJacket : Jacket
	{
        /// <inheritdoc />
		public  uint BasePrice => 20;

        /// <inheritdoc />
		public  int Weight => 1300;

        /// <summary>
		/// Initializes a new instance of the <see cref="SpiderJacket"/> class.
		/// </summary>
		public SpiderJacket() 
		{
		}
	}
}
