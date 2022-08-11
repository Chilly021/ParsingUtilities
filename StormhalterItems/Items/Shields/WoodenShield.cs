using System.Collections.Generic;
using System.IO;



namespace Kesmai.Server.Items
{
	public partial class WoodenShield : Shield
	{
		/// <summary>
		/// Gets the price.
		/// </summary>
		public  uint BasePrice => 25;

		/// <summary>
		/// Gets the weight for this instance.
		/// </summary>
		public  int Weight => 1000;

		/// <summary>
		/// Gets the base armor bonus provided by this <see cref="IArmored" />.
		/// </summary>
		public  int BaseArmorBonus => 1;


		public  int ProjectileProtection => 1;

		/// <summary>
		/// Initializes a new instance of the <see cref="WoodenShield"/> class.
		/// </summary>
		public WoodenShield() 
		{
		}

	
	}
}
