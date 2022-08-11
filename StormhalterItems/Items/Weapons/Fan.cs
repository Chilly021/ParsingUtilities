using System.Collections.Generic;
using System.IO;



namespace Kesmai.Server.Items
{
	public partial class Fan : Weapon
	{
		/// <inheritdoc />
		public  int LabelNumber => 6000034;
		
		/// <inheritdoc />
		public  int Weight => 20;

		/// <inheritdoc />
		public  uint BasePrice => 100;

		/// <inherit />
		public  Skill Skill => Skill.Hand;

		/// <inherit />
		public  int BaseArmorBonus => 4;

		/// <inherit />
		public  int ProjectileProtection => 4;
		
		/// <inheritdoc />
		public  ShieldPenetration Penetration => ShieldPenetration.None;

		/// <inherit />
		public  int MinimumDamage => 1;
		
		/// <inherit />
		public  int MaximumDamage => 2;
		
		/// <inherit />
		public  WeaponFlags Flags => WeaponFlags.Slashing | WeaponFlags.Bashing | WeaponFlags.Neutral;

		/// <inherit />
		public  bool CanBind => true;

		/// <summary>
		/// Initializes a new instance of the <see cref="Fan"/> class.
		/// </summary>
		public Fan() 
		{
		}
		
	}
}