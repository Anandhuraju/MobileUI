using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace MobileUI
{
    public partial class MainPage : ContentPage
    {
        private bool m_BtnClicked;

        public MainPage()
        {
            InitializeComponent();
        }
        //Navigating to next
        private void ImageButton_Clicked(object sender, EventArgs e)
        {
            if (!m_BtnClicked)
            {
                m_BtnClicked = true;

                Navigation.PushAsync(new MyPolicies());

            }
            else
            {
                m_BtnClicked = false;
            }

        }
    }
}
