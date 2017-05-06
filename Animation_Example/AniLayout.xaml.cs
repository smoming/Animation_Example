using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace Animation_Example
{
	public partial class AniLayout : ContentPage
	{
		public AniLayout()
		{
			InitializeComponent();
		}

		void Handle_Clicked(object sender, System.EventArgs e)
		{
			//throw new NotImplementedException();
			pika.LayoutTo(new Rectangle() { X = pika.X, Y = pika.Y, Width = 300, Height = pika.Height }, 1000);
		}
	}
}
