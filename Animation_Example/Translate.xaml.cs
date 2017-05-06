using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace Animation_Example
{
	public partial class Translate : ContentPage
	{
		public Translate()
		{
			InitializeComponent();
		}

		void TranslateX_Clicked(object sender, System.EventArgs e)
		{
			var button = sender as Button;
			var offset = double.Parse(button.CommandParameter.ToString());
			pika.TranslateTo(offset, 0);
		}

		void TranslateY_Clicked(object sender, System.EventArgs e)
		{
			var button = sender as Button;
			var offset = double.Parse(button.CommandParameter.ToString());
			pika.TranslateTo(0, offset);
		}
	}
}
