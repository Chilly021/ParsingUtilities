using System.Collections.Generic;
using System.IO;


namespace Kesmai.Server.Items
{
	public partial class LeatherJacket : Jacket
	{
        /// <inheritdoc />
		public  uint BasePrice => 20;

        /// <inheritdoc />
		public  int Weight => 1200;

        /// <inheritdoc />
		public  int Hindrance => 1;

        /// <summary>
		/// Initializes a new instance of the <see cref="LeatherJacket"/> class.
		/// </summary>
		public LeatherJacket()
		{
		}
	}
}
