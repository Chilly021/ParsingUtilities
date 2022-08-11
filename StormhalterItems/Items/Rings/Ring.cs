using System.IO;



namespace Kesmai.Server.Items
{
	public abstract partial class Ring 
	{
		/// <summary>
		/// Gets the label number.
		/// </summary>
		public  int LabelNumber => 6000073;

		/// <summary>
		/// Gets the item category.
		/// </summary>
		public  int Category => 4;

		/// <summary>
		/// Initializes a new instance of the <see cref="Ring"/> class.
		/// </summary>
		protected Ring() 
		{
		}
	}
}
