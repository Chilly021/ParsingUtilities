using System.Collections.Generic;
using System.IO;



namespace Kesmai.Server.Items
{
	public partial class SpikedFlail : Flail
	{
		/// <inheritdoc />
		public  int LabelNumber => 6000063;

		/// <inheritdoc />
		public  uint BasePrice => 35;

		/// <inheritdoc />
		public  int Weight => 1800;
		
		/// <inheritdoc />
		public  int MinimumDamage => 3;

		/// <inheritdoc />
		public  int MaximumDamage => 12;

		/// <inheritdoc />
		public  int BaseArmorBonus => 1;
		
		/// <summary>
		/// Initializes a new instance of the <see cref="SpikedFlail"/> class.
		/// </summary>
		public SpikedFlail() 
		{
		}
		
	
	}
}