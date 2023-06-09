﻿using System;
using System.Collections.Generic;
using System.Threading;
using Xamarin.Forms;
using Xamarin.Essentials;

namespace NeMonopolia3
{
    public partial class Registration : ContentPage
    {
        public Registration()
        {
            InitializeComponent();
            Iconimage.Source = ImageSource.FromFile("newicon.png");
            
        }

        private async void Button_Clicked(System.Object sender, System.EventArgs e)
        {
            await Navigation.PushAsync(new Authorization());
        }
        
        private async void Button_Clicked_1(System.Object sender, System.EventArgs e)
        {
            
            Player player = new Player() { UserName = name.Text, Login = login.Text, Password = password.Text, Phone = "89", isBanned = false, Persons = new List<Pers>() { new Pers() } };
            //player.Persons = new List<Pers>();
            CurrentPlayerData.CurPlayer = player;
            
           // DBContext.SetPlayers(player);
           // DBContext.SetPlayersByParams(player);
            // DBContext.GetPlayer(2);
            // LocationType location = new LocationType() { Latitude = 56.702538, Longitude = 53.264639 };
            // DBContext.GetStop(location);
            await Navigation.PushAsync(new NavigationPage(new TeamMenu()));
            

        }
    }
}

