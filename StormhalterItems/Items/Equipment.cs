using System.IO;




namespace Kesmai.Server.Items
{
	public abstract partial class Equipment 
	{
		/// <summary>
		/// Gets the hindrance penalty for this <see cref="Equipment"/>.
		/// </summary>	
		
		public virtual int Hindrance => 0;

		public virtual int ProtectionFromStun => 0;

		public virtual int ProtectionFromFire => 0;

		public virtual int ProtectionFromIce => 0;

		public virtual int ProtectionFromConcussion => 0;

		/// <summary>
		/// Gets a value indicating if this instance restricts spell casting for certain professions.
		/// </summary>
		
		
		public virtual bool RestrictSpellcast => false;

		/// <summary>
		/// Initializes a new instance of the <see cref="Equipment"/> class.
		/// </summary>
		protected Equipment() 
		{
		}
	}
}
