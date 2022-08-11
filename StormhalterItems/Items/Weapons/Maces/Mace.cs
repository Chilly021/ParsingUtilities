using System.IO;



namespace Kesmai.Server.Items
{
	public abstract partial class Mace : MeleeWeapon
	{
		/// <inheritdoc />
		public  int LabelNumber => 6000060;

		/// <inheritdoc />
		public  int Category => 2;

		/// <inheritdoc />
		public  ShieldPenetration Penetration => ShieldPenetration.Light;

		/// <inheritdoc />
		public  Skill Skill => Skill.Mace;
	
	}
}
