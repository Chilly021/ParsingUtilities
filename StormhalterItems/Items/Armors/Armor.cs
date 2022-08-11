using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;





namespace Kesmai.Server.Items
{
	public abstract partial class Armor : Equipment, IArmored
	{
		/// <summary>
		/// Gets the label number.
		/// </summary>
		public  int LabelNumber => 6000004; /* armor */
		
		/// <summary>
		/// Gets the item category.
		/// </summary>
		public  int Category => 9;
		
		/// <inheritdoc />
		public  int Hindrance => 1;
		
		#region IArmored
		
		/// <inheritdoc />
		
		
		public virtual int BaseArmorBonus => 0;

		/// <inheritdoc />
		
		
		public virtual int SlashingProtection => 0;

		/// <inheritdoc />
		
		
		public virtual int PiercingProtection => 0;

		/// <inheritdoc />
		
		
		public virtual int BashingProtection => 0;

		/// <inheritdoc />
		
		
		public virtual int ProjectileProtection => 0;

		#endregion

		/// <summary>
		/// Initializes a new instance of the <see cref="Armor"/> class.
		/// </summary>
		protected Armor() 
		{
		}
		
		[Flags]
		private enum ArmorSaveFlag : int
		{
			None 		= 0x00000000,
			
			Quality		= 0x00000001,
		}
		
		private static void SetSaveFlag(ref ArmorSaveFlag flags, ArmorSaveFlag toSet, bool setIf)
		{
			if (setIf)
				flags |= toSet;
		}

		private static bool GetSaveFlag(ArmorSaveFlag flags, ArmorSaveFlag toGet)
		{
			return ((flags & toGet) != 0);
		}
	}
}
