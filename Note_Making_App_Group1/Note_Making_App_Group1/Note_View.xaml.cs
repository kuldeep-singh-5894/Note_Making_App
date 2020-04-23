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
    public partial class Note_View : ContentPage
    {
        public Note_View()
        {
            InitializeComponent();
        }

        
        async void OnEditButtonClicked(object sender, EventArgs e)
        {
            var note = (Note)BindingContext;

            await Navigation.PushAsync(new Edit_Note
            {
             BindingContext =  note
            });
        }

        async void OnDeleteButtonClicked(object sender, EventArgs e)
        {
            var note = (Note)BindingContext;

            if (File.Exists(note.Filename))
            {
                File.Delete(note.Filename);
            }

            await Navigation.PopAsync();
        }
    }
}