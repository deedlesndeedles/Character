using CombatTrackerClient.Custom_Controls;
using CombatTrackerClient.Tools;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Popups;
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
        private int selected; 

        public PartyPage()
		{
			this.InitializeComponent();

            LoadMembers();
		}

        private void LoadMembers()
        {
            gridView.Items.Clear();

            gridView.Items.Add(new PartyItem(MainPage.CHARACTERloaded));

            foreach (Character c in MainPage.CHARACTERloaded.Party)
            {
                gridView.Items.Add(new PartyItem(c));
            }

            gridView.SelectedIndex = MainPage.SELECTEDparty;
        }

        private void buttonAddMember_Click(object sender, RoutedEventArgs e)
        {
            MainPage.CHARACTERcurrent.Party.Add(new Character(MainPage.CHARACTERloaded.ID));

            CharacterSerializer.Serialize();

            LoadMembers();
        }

        private void buttonEditMember_Click(object sender, RoutedEventArgs e)
        {
            if (gridView.SelectedItem != null)
            {
                if (MainPage.CHARACTERcurrent != ((PartyItem)gridView.SelectedItem).PartyMember)
                {
                    MainPage.CHARACTERcurrent = ((PartyItem)gridView.SelectedItem).PartyMember;
                    MainPage.SELECTEDparty = gridView.SelectedIndex;
                }
                else
                {
                    MessageDialog dialog = new MessageDialog("Character already selected.");
                    dialog.ShowAsync();
                }
            }
            else
            {
                MessageDialog dialog = new MessageDialog("Select a character to edit.");
                dialog.ShowAsync();
            }
        }
    }
}
