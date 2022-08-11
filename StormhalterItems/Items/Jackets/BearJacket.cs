using System.Collections.Generic;
using System.IO;


namespace Kesmai.Server.Items
{
	public partial class BearJacket : Jacket
	{
		/// <inheritdoc />
		public  uint BasePrice => 20;

		/// <inheritdoc />
		public  int Weight => 1600;

		/// <summary>
		/// Initializes a new instance of the <see cref="BearJacket"/> class.
		/// </summary>
		public BearJacket() 
		{
		}
	}
}