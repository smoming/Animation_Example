using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace Animation_Example
{
	public partial class Index : ContentPage
	{
		public Index()
		{
			InitializeComponent();
		}

		void Translate_Click(object sender, EventArgs e)
		{
			Navigation.PushAsync(new Translate());
		}

		void Scale_Click(object sender, EventArgs e)
		{
			Navigation.PushAsync(new Scale());
		}

		void Rotate_Click(object sender, EventArgs e)
		{
			Navigation.PushAsync(new Rotate());
		}

		void Flip_Click(object sender, EventArgs e)
		{
			Navigation.PushAsync(new Flip());
		}

		void Fade_Click(object sender, EventArgs e)
		{
			Navigation.PushAsync(new Fade());
		}

		void Transition_Click(object sender, EventArgs e)
		{
			Navigation.PushAsync(new PokemonTransition());
		}

		void Layout_Click(object sender, EventArgs e)
		{
			Navigation.PushAsync(new AniLayout());
		}

		//void CustomAnimation_Click(object sender, EventArgs e)
		//{
		//	Navigation.PushAsync(new CustomAnimationPage())
		//}
	}
}
