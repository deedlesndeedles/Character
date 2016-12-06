﻿using CombatTrackerClient.Tools;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

namespace CombatTrackerClient
{
	public sealed partial class CharacterPage : Page
	{
		public CharacterPage()
		{
			this.InitializeComponent();
		}

        private void Page_Loaded(object sender, RoutedEventArgs e)
        {
            CharacterSerializer.Deserialize();

            textName.Text = MainPage.CHARACTER.Name;
            textPlayer.Text = MainPage.CHARACTER.Player;
            textCampaign.Text = MainPage.CHARACTER.Campaign;
        }

        private void textName_LostFocus(object sender, RoutedEventArgs e)
        {
            MainPage.CHARACTER.Name = textName.Text;
        }

        private void textPlayer_LostFocus(object sender, RoutedEventArgs e)
        {
            MainPage.CHARACTER.Player = textPlayer.Text;
        }

        private void textCampaign_LostFocus(object sender, RoutedEventArgs e)
        {
            MainPage.CHARACTER.Campaign = textCampaign.Text;
        }
    }
}
