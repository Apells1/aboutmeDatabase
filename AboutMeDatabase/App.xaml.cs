using System;
using System.Collections.Generic;
using AboutMeDatabase.Data;
using AboutMeDatabase.Models;
using Xamarin.Forms;


namespace AboutMeDatabase
{
    public partial class App : Application
    {
        static PersonalItemDatabase database;
        public App()
        {
            InitializeComponent();

            MainPage = new MainPage();
        }

        public static PersonalItemDatabase Database
        {
            get
            {
                if (database == null)
                {
                    database = new PersonalItemDatabase(); 
                    prefillDatabase();

                }
                return database;
            }
        }
        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }

        static void prefillDatabase()
        {
            database.ClearAllAsync();
            List<PersonalItem> items = new List<PersonalItem>();
                items.Add(new PersonalItem() { Title = "Name", Detail = "Andre Pells" });
                items.Add(new PersonalItem() { Title = "Job", Detail = "Barista" });
                items.Add(new PersonalItem() { Title = "Hobbies", Detail = "Gaming, Art, Animation" });
                items.Add(new PersonalItem() { Title = "Favorite Foods", Detail = "Anything with noodles or rice!" });
                database.InsertList(items);

        }
    }
}
