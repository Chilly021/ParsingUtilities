using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;



namespace Kesmai.Server.Items
{
	
	public partial class OakGroveBow : Bow
	{
		/// <inheritdoc />
		public  int LabelNumber => 6000058;

		/// <inheritdoc />
		public  uint BasePrice => 6000;

		/// <inheritdoc />
		public  int Weight => 800;

		/// <inheritdoc />
		public  int Category => 1;

		/// <inheritdoc />
		public  ShieldPenetration Penetration => ShieldPenetration.VeryHeavy;

		/// <inheritdoc />
		public  int MinimumDamage => 6;

		/// <inheritdoc />
		public  int MaximumDamage => 17;

		/// <inheritdoc />
		public  int BaseAttackBonus => 5;

		/// <inheritdoc />
		public  WeaponFlags Flags => base.Flags | WeaponFlags.Silver 
		                                                | WeaponFlags.BlueGlowing | WeaponFlags.Neutral;

		/// <inheritdoc />
		public  bool CanBind => true;

		//todo pick a new bow model
		/// <inheritdoc />
		public  int NockedID => 113;

		/// <summary>
		/// Initializes a new instance of the <see cref="OakGroveBow"/> class.
		/// </summary>
		public OakGroveBow() 
		{

		}
		
		public  double GetSkillMultiplier()
		{
			return 1.5;
		}
	}
}