using System.IO;




namespace Kesmai.Server.Items
{
	public abstract partial class Shield 
	{
		/// <summary>
		/// Gets the label number.
		/// </summary>
		public  int LabelNumber => 6000082;

		/// <summary>
		/// Gets the base armor bonus provided by this <see cref="Armor"/>.
		/// </summary>
		
		
		public virtual int BaseArmorBonus { get { return 0; } }

		/// <summary>
		/// Gets the protection provided against slashing attacks.
		/// </summary>
		
		
		public virtual int SlashingProtection { get { return 0; } }

		/// <summary>
		/// Gets the protection provided against peircing attacks.
		/// </summary>
		
		
		public virtual int PiercingProtection { get { return 0; } }

		/// <summary>
		/// Gets the protection provided against bashing attacks.
		/// </summary>
		
		
		public virtual int BashingProtection { get { return 0; } }

		/// <summary>
		/// Gets the protection provided against projectile attacks.
		/// </summary>
		
		
		public virtual int ProjectileProtection { get { return 0; } }

		/// <summary>
		/// Initializes a new instance of the <see cref="Shield"/> class.
		/// </summary>
		protected Shield() 
		{
		}
	}
}
