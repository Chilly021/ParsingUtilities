using System.IO;



namespace Kesmai.Server.Items
{
	public partial class Bow : ProjectileWeapon
	{
		/// <inheritdoc />
		public  int LabelNumber => 6000015;
		
		/// <inheritdoc />
		public  int Category => 2;

		/// <inheritdoc />
		public  Skill Skill => Skill.Bow;

		/// <inheritdoc />
		
		/// <inheritdoc />
		public  WeaponFlags Flags => WeaponFlags.TwoHanded | WeaponFlags.Bow;

		/// <summary>
		/// Initializes a new instance of the <see cref="Bow"/> class.
		/// </summary>
		public Bow() 
		{
        }
	}
}
