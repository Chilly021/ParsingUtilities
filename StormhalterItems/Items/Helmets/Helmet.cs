using System.IO;





namespace Kesmai.Server.Items
{
	public abstract partial class Helmet : Equipment
	{
		/// <summary>
		/// Gets the label number.
		/// </summary>
		public  int LabelNumber => 6000049;

		/// <summary>
		/// Gets the item category.
		/// </summary>
		public  int Category => 5;

		/// <summary>
		/// Gets or sets a value indication if this instance provides <see cref="NightVisionStatus"/>
		/// </summary>
		
		
		public virtual bool ProvidesNightVision => false;
		
		/// <summary>
		/// Initializes a new instance of the <see cref="Helmet"/> class.
		/// </summary>
		protected Helmet() 
		{
		}

	}
}
