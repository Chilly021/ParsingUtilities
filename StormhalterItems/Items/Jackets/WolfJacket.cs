using System.Collections.Generic;
using System.IO;


namespace Kesmai.Server.Items
{
	public partial class WolfJacket : Jacket
	{
        /// <inheritdoc />
		public  uint BasePrice => 20;

        /// <inheritdoc />
		public  int Weight => 1300;

        /// <inheritdoc />
		public  int Hindrance => 1;

        /// <summary>
		/// Initializes a new instance of the <see cref="WolfJacket"/> class.
		/// </summary>
		public WolfJacket() 
		{
		}

	}
}
