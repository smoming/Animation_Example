using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace Animation_Example
{
	public partial class PokemonTransition : ContentPage
	{
		public PokemonTransition()
		{
			InitializeComponent();
		}

		async void Handle_Clicked(object sender, System.EventArgs e)
		{
			//throw new NotImplementedException();

			await pika.ScaleTo(0.3, 500);
			await pika.RotateYTo(90, 500);
			pika.Source = "https://goo.gl/oP80eP";
			await pika.RotateYTo(180, 500);
			await pika.ScaleTo(1, 500);
			await pika.FadeTo(0, 500);
		}
	}
}
