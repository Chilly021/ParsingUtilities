using System.IO;



namespace Kesmai.Server.Items
{
	/* Nunchakus, morning stars and flails are included in the flail weapon type. */
	/* These weapons are popular with Martial Artists and Thieves because of their compactness. */
	public abstract partial class Flail : MeleeWeapon
	{
		/// <inheritdoc />
		public  int Category => 2;
		
		/// <inheritdoc />
		public  int LabelNumber => 6000037;

		/// <inheritdoc />
		public  Skill Skill => Skill.Flail;
		
		/// <inheritdoc />
		public  ShieldPenetration Penetration => ShieldPenetration.Medium;

		/// <inheritdoc />
		public  WeaponFlags Flags => WeaponFlags.Bashing;
		
		
		/// <summary>
		/// Initializes a new instance of the <see cref="Flail"/> class.
		/// </summary>
		protected Flail() 
		{
		}
	}
}
