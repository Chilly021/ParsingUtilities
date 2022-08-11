using System.IO;



namespace Kesmai.Server.Items
{
	public abstract partial class Dagger : MeleeWeapon
	{
		/// <inheritdoc />
		public  int LabelNumber => 6000032;

		/// <inheritdoc />
		public  int Weight => 100;
		
		/// <inheritdoc />
		public  int Category => 14;

		/// <inheritdoc />
		public  int MinimumDamage => 1;

		/// <inheritdoc />
		public  int MaximumDamage => 4;

		/// <inheritdoc />
		public  ShieldPenetration Penetration => ShieldPenetration.Light;

		/// <inheritdoc />
		public  Skill Skill => Skill.Dagger;

		/// <inheritdoc />
		public  WeaponFlags Flags => WeaponFlags.Piercing | WeaponFlags.Throwable | WeaponFlags.QuickThrow;
		
		/// <summary>
		/// Initializes a new instance of the <see cref="Dagger"/> class.
		/// </summary>
		protected Dagger()
		{
		}
	}
}
