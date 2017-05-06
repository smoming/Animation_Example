using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace Animation_Example
{
	public partial class Scale : ContentPage
	{
		public Scale()
		{
			InitializeComponent();
		}

		void Scale_Clicked(object sender, System.EventArgs e)
		{
			var button = sender as Button;
			var scale = double.Parse(button.CommandParameter.ToString());
			pika.ScaleTo(scale);
		}

		void ReScale_Clicked(object sender, System.EventArgs e)
		{
			var button = sender as Button;
			var scale = double.Parse(button.CommandParameter.ToString());
			pika.RelScaleTo(scale);
		}
	}
}
