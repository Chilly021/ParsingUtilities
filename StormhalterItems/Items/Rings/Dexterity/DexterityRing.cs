using System.Collections.Generic;
using System.IO;




namespace Kesmai.Server.Items
{
	public partial class DexterityRing : Ring
	{
		/// <inheritdoc />
		public  uint BasePrice => 1500;

		/// <inheritdoc />
		public  int Weight => 20;

		/// <summary>
		/// The dexterity bonus provided by this ring.
		/// </summary>
		
		
		public virtual int BonusDexterity => 2;
		
		/// <summary>
        /// Initializes a new instance of the <see cref="DexterityRing"/> class.
        /// </summary>
        public DexterityRing() 
        {
        }

	}
}
