using System.Collections.Generic;
using System.IO;


namespace Kesmai.Server.Items
{
	public partial class FineCrossbow : Crossbow
	{
		/// <inheritdoc />
		public  uint BasePrice => 600;
		
		/// <inheritdoc />
		public  int BaseAttackBonus => 2;

		/// <inheritdoc />
		public  ShieldPenetration Penetration => ShieldPenetration.Light;

		/// <summary>
		/// Initializes a new instance of the <see cref="FineCrossbow"/> class.
		/// </summary>
		public FineCrossbow() 
		{
		}
		
	
	}
}