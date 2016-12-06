using System;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Input;

namespace CombatTrackerClient
{
	public sealed partial class FilesButton : UserControl
	{
		public Type Type { get; private set; }
		public bool IsActive { get; private set; }
        public Action Function { get; private set; }

		public FilesButton()
		{
			this.InitializeComponent();
		}

		private void FilesGrid_PointerEntered(object sender, PointerRoutedEventArgs e)
		{
			if(!IsActive && !MainPage.IsClicking)
				FilesGrid.Background = App.Colors.BUTTON_HOVER;
			else if(MainPage.IsClicking && MainPage.BeingClicked == this)
				FilesGrid.Background = App.Colors.BUTTON_CLICK;
		}

		private void FilesGrid_PointerExited(object sender, PointerRoutedEventArgs e)
		{
			if(!IsActive)
				FilesGrid.Background = App.Colors.BUTTON_IDLE_LEFT;
		}

		public void SetLoadType(LoadType type)
		{
            switch (type)
            {
                case LoadType.NEW: Symbol.Text = "\xE302"; Text.Text = "New Character"; Function = new Action(Create); break;
                case LoadType.LOAD: Symbol.Text = "\xE13D"; Text.Text = "Load Character"; Function = new Action(Load); break;
                case LoadType.SORT: Symbol.Text = "\xE945"; Text.Text = "Sort Options"; Function = new Action(Sort); break;
            }
		}

		public void MakeActive(bool isActive)
		{
			FilesGrid.Background = isActive ? App.Colors.BUTTON_SELECTED : App.Colors.BUTTON_IDLE_LEFT;
			IsActive = isActive;
		}

		public void Clicked(bool clickDown)
		{
			FilesGrid.Background = App.Colors.BUTTON_CLICK;
		}

        private void Create()
        {
            System.Diagnostics.Debug.WriteLine("Created!");
        }

        private void Load()
        {
            System.Diagnostics.Debug.WriteLine("Load!");
        }

        private void Sort()
        {
            System.Diagnostics.Debug.WriteLine("Sorted!");
        }
    }
}
