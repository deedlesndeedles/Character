using CombatTrackerClient.Custom_Controls;
using CombatTrackerClient.Tools;
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

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=234238

namespace CombatTrackerClient
{
	/// <summary>
	/// An empty page that can be used on its own or navigated to within a Frame.
	/// </summary>
	public sealed partial class PartyPage : Page
	{
		public PartyPage()
		{
			this.InitializeComponent();

            LoadMembers();
		}

        private void LoadMembers()
        {
            gridView.Items.Clear();

            gridView.Items.Add(MainPage.CHARACTER);

            foreach (Character c in MainPage.CHARACTER.Party)
            {
                gridView.Items.Add(c);
            }
        }

        private void buttonAddMember_Click(object sender, RoutedEventArgs e)
        {
            MainPage.CHARACTER.Party.Add(new Character(MainPage.CHARACTER));

            LoadMembers();
        }
    }
}
