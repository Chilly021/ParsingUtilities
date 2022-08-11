using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;

namespace Kesmai.Server.Items
{
	public partial class JewelerRing : Ring
	{
		public static int TransmuteDelayRounds = 60;
		
		/// <inheritdoc />
		public  uint BasePrice => 2000;

		private ulong _transmuted;
		private Timer _cooldownTimer;
		
		/// <summary>
		/// Gets the total gold value converted by this ring.
		/// </summary>
		
		
		public ulong Transmuted
		{
			get => _transmuted;
			set => _transmuted = value; /* The amount has been transmuted. */
		}

		public bool CanTransmute => _cooldownTimer is null;
		
		/// <summary>
		/// Initializes a new instance of the <see cref="JewelerRing"/> class.
		/// </summary>
		public JewelerRing()
		{
		}

		
	}
}