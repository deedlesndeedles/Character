using System;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Input;

namespace CombatTrackerClient
{
	public sealed partial class NavigationButton : UserControl
	{
		public Type Type { get; private set; }
		public bool IsActive { get; private set; }

		public NavigationButton()
		{
			this.InitializeComponent();
		}

		private void NavigationGrid_PointerEntered(object sender, PointerRoutedEventArgs e)
		{
			if(!IsActive && !MainPage.IsClicking)
				NavigationGrid.Background = App.Colors.BUTTON_HOVER;
			else if(MainPage.IsClicking && MainPage.BeingClicked == this)
				NavigationGrid.Background = App.Colors.BUTTON_CLICK;
		}

		private void NavigationGrid_PointerExited(object sender, PointerRoutedEventArgs e)
		{
			if(!IsActive)
				NavigationGrid.Background = App.Colors.BUTTON_IDLE_LEFT;
		}

		public void SetPageType(PageType type)
		{
			switch(type)
			{
				case PageType.BASE: Symbol.Text = "\xE302"; Text.Text = "Base Stats"; Type = typeof(BasePage); break;
				case PageType.CHARACTER: Symbol.Text = "\xE13D"; Text.Text = "Character"; Type = typeof(CharacterPage); break;
				case PageType.COMBAT: Symbol.Text = "\xE945"; Text.Text = "Combat"; Type = typeof(CombatPage); break;
				case PageType.SKILLS: Symbol.Text = "\xE13D"; Text.Text = "Skills"; Type = typeof(SkillsPage); break;
				case PageType.SETTINGS: Symbol.Text = "\xE115"; Text.Text = "Settings"; Type = typeof(SettingsPage); break;
                case PageType.FEATS: Symbol.Text = "\xE125"; Text.Text = "Feats"; Type = typeof(FeatsPage); break;
                case PageType.INVENTORY: Symbol.Text = "\xE125"; Text.Text = "Inventory"; Type = typeof(InventoryPage); break;
                case PageType.SPELLS: Symbol.Text = "\xE91A"; Text.Text = "Spells"; Type = typeof(SpellsPage); break;
                case PageType.BLANK: Type = typeof(Page); break;
			}
		}

		public void MakeActive(bool isActive)
		{
			NavigationGrid.Background = isActive ? App.Colors.BUTTON_SELECTED : App.Colors.BUTTON_IDLE_LEFT;
			IsActive = isActive;
		}

		public void Clicked(bool clickDown)
		{
			NavigationGrid.Background = App.Colors.BUTTON_CLICK;
		}
	}
}
