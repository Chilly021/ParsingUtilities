using System.Collections.Generic;
using System.IO;


namespace Kesmai.Server.Items
{
	public partial class ManticoraJacket : Jacket
	{
        /// <inheritdoc />
		public  uint BasePrice => 20;

        /// <inheritdoc />
		public  int Weight => 1400;

        /// <inheritdoc />
		public  int Hindrance => 1;

        /// <summary>
		/// Initializes a new instance of the <see cref="ManticoraJacket"/> class.
		/// </summary>
		public ManticoraJacket() 
		{
		}

       
	}
}
