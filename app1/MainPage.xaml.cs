using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace app1
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        void fname_Completed(System.Object sender, System.EventArgs e)
        {
            string fname = ((Entry)sender).Text;
            Console.WriteLine(fname);
  
        }

        void fname_TextChanged(System.Object sender, Xamarin.Forms.TextChangedEventArgs e)
        {
            string oldText = e.OldTextValue;
            string newText = e.NewTextValue;
        }

        void lname_Completed(System.Object sender, System.EventArgs e)
        {
        }

        void lname_TextChanged(System.Object sender, Xamarin.Forms.TextChangedEventArgs e)
        {
        }

        void email_Completed(System.Object sender, System.EventArgs e)
        {
        }

        void email_TextChanged(System.Object sender, Xamarin.Forms.TextChangedEventArgs e)
        {
        }

        void password_Completed(System.Object sender, System.EventArgs e)
        {
        }

        void password_TextChanged(System.Object sender, Xamarin.Forms.TextChangedEventArgs e)
        {
        }

        void password2_Completed(System.Object sender, System.EventArgs e)
        {
        }

        void password2_TextChanged(System.Object sender, Xamarin.Forms.TextChangedEventArgs e)
        {
        }
    }
}
