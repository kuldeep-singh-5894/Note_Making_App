using Notes.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Note_Making_App_Group1
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Edit_Note : ContentPage
    {
        public Edit_Note()
        {
            InitializeComponent();
        }

        async void OnUpdateButtonClicked(object sender, EventArgs e)
        {
            var note = (Note)BindingContext;

            // Update 
            File.WriteAllText(note.Filename, note.Text);


            await Navigation.PopToRootAsync();
        }
    }
}