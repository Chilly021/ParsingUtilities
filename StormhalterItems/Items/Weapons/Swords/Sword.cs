using System.IO;



namespace Kesmai.Server.Items
{
	public abstract partial class Sword : MeleeWeapon
	{
		/// <inheritdoc />
		public  int LabelNumber => 6000090;

		/// <inheritdoc />
		public  ShieldPenetration Penetration => ShieldPenetration.Light;

		/// <inheritdoc />
		public  int Category => 2;
		
		/// <inheritdoc />
		public  Skill Skill => Skill.Sword;
	}
}
