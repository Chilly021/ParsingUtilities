using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.IO;
using System.Linq;





namespace Kesmai.Server.Items
{
	public partial class RecallRing : Ring
	{
		private bool _isActive;
		private int _power;
		
		/// <summary>
		/// Gets the price.
		/// </summary>
		public  uint BasePrice => 150;

		/// <summary>
		/// Gets the weight.
		/// </summary>
		public  int Weight => 20;
		
		/// <summary>
		/// Gets or sets the segment bound to this ring.
		/// </summary>
		
		/// <summary>
		/// Gets a value indicating whether this ring is active.
		/// </summary>
		
		public bool IsActive => _isActive;

		/// <summary>
		/// Gets the recall power for this ring.
		/// </summary>
		
		public int Power => _power;


		/// <summary>
		/// Initializes a new instance of the <see cref="RecallRing"/> class.
		/// </summary>
		public RecallRing() 
		{
		
		}

	}
}
