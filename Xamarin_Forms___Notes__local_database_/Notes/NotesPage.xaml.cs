using System;
using Xamarin.Forms;
using Notes.Models;
using System.Collections.Generic;

namespace Notes
{
    public partial class NotesPage : ContentPage
    {
        public NotesPage()
        {
            InitializeComponent();
        }

        protected override async void OnAppearing()
        {
            base.OnAppearing();

            listView.ItemsSource = await App.Database.GetNotesAsync();
            var li = await App.Database.GetNotesAsync();
            List<string> gs = new List<string>();
            foreach (var i in li)
            {
                gs.Add(i.Text);
            }
            jdb.ItemsSource = gs;
        }

        async void OnNoteAddedClicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new NoteEntryPage
            {
                BindingContext = new Note()
            });
        }

        async void OnListViewItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            if (e.SelectedItem != null)
            {
                await Navigation.PushAsync(new NoteEntryPage
                {
                    BindingContext = e.SelectedItem as Note
                });
            }
        }

        private void Jdb_SelectedIndexChanged(object sender, EventArgs e)
        {
            var picker = (Picker)sender;
            int selectedIndex = picker.SelectedIndex;

            if (selectedIndex != -1)
            {
                label.Text =label.Text+" + "+ (string)picker.ItemsSource[selectedIndex];
            }
        }
    }
}
