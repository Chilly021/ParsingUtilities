using System.ComponentModel;
using System.Drawing;
using System.IO;



namespace Kesmai.Server.Items
{
	public abstract partial class ProjectileWeapon : Weapon
	{

	

    }

	public class ShootItemTarget 
	{
		private ProjectileWeapon _weapon;

		/// <summary>
		/// Initializes a new instance of the <see cref="ShootItemTarget"/> class.
		/// </summary>
		public ShootItemTarget(ProjectileWeapon weapon)
		{
			_weapon = weapon;
		}

	}
}
