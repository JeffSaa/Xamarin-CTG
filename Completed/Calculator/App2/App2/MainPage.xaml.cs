using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace App2
{
	public partial class MainPage : ContentPage
	{
        Calculator c;
        Label mResult;

		public MainPage()
		{
			InitializeComponent();
            c = new Calculator();
            mResult = this.FindByName<Label>("result");
		}

        public void calculate(object sender, EventArgs args)
        {
            Button b = (Button)sender;
            mResult.Text = c.addValue(b.Text).ToString();
        }

	}
}
