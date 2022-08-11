using System.IO;


namespace Kesmai.Server.Items
{
	public abstract partial class Staff : MeleeWeapon
	{
		/// <inheritdoc />
		public  int LabelNumber => 6000088;

		/// <inheritdoc />
		public  int Category => 1;
		
		/// <inheritdoc />
		public  Skill Skill => Skill.Staff;

		/// <inheritdoc />
		public  ShieldPenetration Penetration => ShieldPenetration.Light;

		/// <summary>
		/// Initializes a new instance of the <see cref="Staff"/> class.
		/// </summary>
		protected Staff() 
		{
		}
	}
}
