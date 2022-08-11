using System.Collections.Generic;
using System.IO;



namespace Kesmai.Server.Items
{
	public partial class MainGauche : Dagger
	{
		
		/// <inheritdoc />
		public  int Weight => 20;

		/// <inheritdoc />
		public  uint BasePrice => 100;

		/// <inherit />
		public  Skill Skill => Skill.Dagger;

		/// <inherit />
		public  int BaseArmorBonus => 4;
		
		/// <inheritdoc />
		public  int BaseAttackBonus => 2;
		
		/// <inheritdoc />
		public  ShieldPenetration Penetration => ShieldPenetration.Light;
		
		/// <inheritdoc />
		protected  int PoisonedItemId => 901;
		
		/// <inherit />
		public  WeaponFlags Flags => WeaponFlags.Piercing | WeaponFlags.Silver | WeaponFlags.Neutral;

		/// <inherit />
		public  bool CanBind => true;

		/// <summary>
		/// Initializes a new instance of the <see cref="MainGauche"/> class.
		/// </summary>
		public MainGauche() 
		{
		}
	}
}
