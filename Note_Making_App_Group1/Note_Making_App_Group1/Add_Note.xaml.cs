using System;
using System.IO;
using Xamarin.Forms;
using Notes.Models;
using Note_Making_App_Group1;

namespace Note_Making_App_Group1
{
    public partial class Add_Note : ContentPage
    {
        public Add_Note()
        {
            InitializeComponent();
        }

     

        async void OnSaveButtonClicked(object sender, EventArgs e)
        {
            var note = (Note)BindingContext;

                // Save
                var filename = Path.Combine(App.FolderPath, $"{Path.GetRandomFileName()}.notes.txt");
                File.WriteAllText(filename, note.Text);
           
            await Navigation.PopAsync();
        }

    }
}
