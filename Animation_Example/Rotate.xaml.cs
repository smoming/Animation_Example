using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace Animation_Example
{
	public partial class Rotate : ContentPage
	{
		public Rotate()
		{
			InitializeComponent();
		}

		void Rotate_Clicked(object sender, System.EventArgs e)
		{
			var button = sender as Button;
			var rotate = double.Parse(button.CommandParameter.ToString());
			pika.RotateTo(rotate);
		}

		void RelRotate_Clicked(object sender, System.EventArgs e)
		{
			var button = sender as Button;
			var rotate = double.Parse(button.CommandParameter.ToString());
			pika.RelRotateTo(rotate);
		}
	}
}
