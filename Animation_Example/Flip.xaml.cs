using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace Animation_Example
{
	public partial class Flip : ContentPage
	{
		public Flip()
		{
			InitializeComponent();
		}

		void FlipX_Clicked(object sender, System.EventArgs e)
		{
			var button = sender as Button;
			var flip = double.Parse(button.CommandParameter.ToString());
			pika.RotateXTo(flip);
		}

		void FlipY_Clicked(object sender, System.EventArgs e)
		{
			var button = sender as Button;
			var flip = double.Parse(button.CommandParameter.ToString());
			pika.RotateYTo(flip);
		}
	}
}
