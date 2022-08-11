using System.Collections.Generic;
using System.IO;




namespace Kesmai.Server.Items
{
	public partial class GriffinJacket : Jacket
	{
		/// <inheritdoc />
		public  uint BasePrice => 30;

        /// <inheritdoc />
		public  int Weight => 1500;
		
		/// <inheritdoc />
		/// <remarks>Robes have a default <see cref="Hindrance"/> value of 1.</remarks>
		public  int Hindrance => 0;
		
        /// <summary>
		/// Initializes a new instance of the <see cref="GriffinJacket"/> class.
		/// </summary>
		public GriffinJacket() 
		{
		}
        
	
	}
}
