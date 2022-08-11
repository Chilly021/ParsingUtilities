using System;
using System.Collections.Generic;
using System.IO;



namespace Kesmai.Server.Items
{
	public partial class WeakDexterityRing : DexterityRing
	{
		/// <inheritdoc />
		public  uint BasePrice => 1000;

		/// <inheritdoc />
		public  int BonusDexterity => 1;

		/// <summary>
		/// Initializes a new instance of the <see cref="WeakDexterityRing"/> class.
		/// </summary>
		public WeakDexterityRing() 
		{
		}

	}
}
