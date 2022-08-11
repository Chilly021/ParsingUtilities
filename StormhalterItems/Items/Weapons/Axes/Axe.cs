using System.IO;



namespace Kesmai.Server.Items
{
	public abstract partial class Axe : MeleeWeapon
	{
		/// <inheritdoc />
		public  int LabelNumber => 6000005;
		
		/// <inheritdoc />
		public  int Category => 2;

		/// <inheritdoc />
		public Skill Skill => Skill.Mace;

		/// <inheritdoc />
		public  ShieldPenetration Penetration => ShieldPenetration.Light;
      
    }
}
