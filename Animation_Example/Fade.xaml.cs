using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace Animation_Example
{
	public partial class Fade : ContentPage
	{
		public Fade()
		{
			InitializeComponent();
		}

		void FadeIn_Clicked(object sender, System.EventArgs e)
		{
			var button = sender as Button;
			var fate = double.Parse(button.CommandParameter.ToString());
			pika.FadeTo(fate, 2000);
		}
	}
}
