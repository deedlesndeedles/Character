﻿#pragma checksum "C:\Users\Mark\Desktop\Character\CombatTrackerClient\Pages\MainPage.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "2F94C7B82A5491FC7BCE795D14406475"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace CombatTrackerClient
{
    partial class MainPage : 
        global::Windows.UI.Xaml.Controls.Page, 
        global::Windows.UI.Xaml.Markup.IComponentConnector,
        global::Windows.UI.Xaml.Markup.IComponentConnector2
    {
        /// <summary>
        /// Connect()
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 14.0.0.0")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public void Connect(int connectionId, object target)
        {
            switch(connectionId)
            {
            case 1:
                {
                    this.Page = (global::Windows.UI.Xaml.Controls.Page)(target);
                    #line 8 "..\..\..\Pages\MainPage.xaml"
                    ((global::Windows.UI.Xaml.Controls.Page)this.Page).PointerReleased += this.Pointer_Released;
                    #line default
                }
                break;
            case 2:
                {
                    this.MainGrid = (global::Windows.UI.Xaml.Controls.Grid)(target);
                }
                break;
            case 3:
                {
                    this.gridView = (global::Windows.UI.Xaml.Controls.GridView)(target);
                }
                break;
            case 4:
                {
                    this.gridFiles = (global::Windows.UI.Xaml.Controls.Grid)(target);
                }
                break;
            case 5:
                {
                    this.Expand1 = (global::Windows.UI.Xaml.Controls.Grid)(target);
                    #line 62 "..\..\..\Pages\MainPage.xaml"
                    ((global::Windows.UI.Xaml.Controls.Grid)this.Expand1).PointerEntered += this.Hover_Enter;
                    #line 62 "..\..\..\Pages\MainPage.xaml"
                    ((global::Windows.UI.Xaml.Controls.Grid)this.Expand1).PointerReleased += this.Expand_Released;
                    #line 62 "..\..\..\Pages\MainPage.xaml"
                    ((global::Windows.UI.Xaml.Controls.Grid)this.Expand1).PointerExited += this.Hover_Exit;
                    #line 62 "..\..\..\Pages\MainPage.xaml"
                    ((global::Windows.UI.Xaml.Controls.Grid)this.Expand1).PointerPressed += this.Expand_Pressed;
                    #line default
                }
                break;
            case 6:
                {
                    this.NewCharacter = (global::CombatTrackerClient.FilesButton)(target);
                    #line 77 "..\..\..\Pages\MainPage.xaml"
                    ((global::CombatTrackerClient.FilesButton)this.NewCharacter).PointerReleased += this.LoadPointer_Released;
                    #line 77 "..\..\..\Pages\MainPage.xaml"
                    ((global::CombatTrackerClient.FilesButton)this.NewCharacter).PointerPressed += this.LoadButton_Pressed;
                    #line default
                }
                break;
            case 7:
                {
                    this.LoadCharacter = (global::CombatTrackerClient.FilesButton)(target);
                    #line 78 "..\..\..\Pages\MainPage.xaml"
                    ((global::CombatTrackerClient.FilesButton)this.LoadCharacter).PointerReleased += this.LoadPointer_Released;
                    #line 78 "..\..\..\Pages\MainPage.xaml"
                    ((global::CombatTrackerClient.FilesButton)this.LoadCharacter).PointerPressed += this.LoadButton_Pressed;
                    #line default
                }
                break;
            case 8:
                {
                    this.DeleteCharacter = (global::CombatTrackerClient.FilesButton)(target);
                    #line 79 "..\..\..\Pages\MainPage.xaml"
                    ((global::CombatTrackerClient.FilesButton)this.DeleteCharacter).PointerReleased += this.LoadPointer_Released;
                    #line 79 "..\..\..\Pages\MainPage.xaml"
                    ((global::CombatTrackerClient.FilesButton)this.DeleteCharacter).PointerPressed += this.LoadButton_Pressed;
                    #line default
                }
                break;
            case 9:
                {
                    this.SortOptions = (global::CombatTrackerClient.FilesButton)(target);
                    #line 80 "..\..\..\Pages\MainPage.xaml"
                    ((global::CombatTrackerClient.FilesButton)this.SortOptions).PointerReleased += this.LoadPointer_Released;
                    #line 80 "..\..\..\Pages\MainPage.xaml"
                    ((global::CombatTrackerClient.FilesButton)this.SortOptions).PointerPressed += this.LoadButton_Pressed;
                    #line default
                }
                break;
            case 10:
                {
                    this.NavSettings1 = (global::CombatTrackerClient.NavigationButton)(target);
                    #line 81 "..\..\..\Pages\MainPage.xaml"
                    ((global::CombatTrackerClient.NavigationButton)this.NavSettings1).PointerReleased += this.Pointer_Released;
                    #line 81 "..\..\..\Pages\MainPage.xaml"
                    ((global::CombatTrackerClient.NavigationButton)this.NavSettings1).PointerPressed += this.Navigation_Pressed;
                    #line default
                }
                break;
            case 11:
                {
                    this.Content = (global::Windows.UI.Xaml.Controls.Frame)(target);
                }
                break;
            case 12:
                {
                    this.Expand = (global::Windows.UI.Xaml.Controls.Grid)(target);
                    #line 20 "..\..\..\Pages\MainPage.xaml"
                    ((global::Windows.UI.Xaml.Controls.Grid)this.Expand).PointerEntered += this.Hover_Enter;
                    #line 20 "..\..\..\Pages\MainPage.xaml"
                    ((global::Windows.UI.Xaml.Controls.Grid)this.Expand).PointerReleased += this.Expand_Released;
                    #line 20 "..\..\..\Pages\MainPage.xaml"
                    ((global::Windows.UI.Xaml.Controls.Grid)this.Expand).PointerExited += this.Hover_Exit;
                    #line 20 "..\..\..\Pages\MainPage.xaml"
                    ((global::Windows.UI.Xaml.Controls.Grid)this.Expand).PointerPressed += this.Expand_Pressed;
                    #line default
                }
                break;
            case 13:
                {
                    this.NavCharacter = (global::CombatTrackerClient.NavigationButton)(target);
                    #line 37 "..\..\..\Pages\MainPage.xaml"
                    ((global::CombatTrackerClient.NavigationButton)this.NavCharacter).PointerReleased += this.Pointer_Released;
                    #line 37 "..\..\..\Pages\MainPage.xaml"
                    ((global::CombatTrackerClient.NavigationButton)this.NavCharacter).PointerPressed += this.Navigation_Pressed;
                    #line default
                }
                break;
            case 14:
                {
                    this.NavBase = (global::CombatTrackerClient.NavigationButton)(target);
                    #line 38 "..\..\..\Pages\MainPage.xaml"
                    ((global::CombatTrackerClient.NavigationButton)this.NavBase).PointerReleased += this.Pointer_Released;
                    #line 38 "..\..\..\Pages\MainPage.xaml"
                    ((global::CombatTrackerClient.NavigationButton)this.NavBase).PointerPressed += this.Navigation_Pressed;
                    #line default
                }
                break;
            case 15:
                {
                    this.NavCombat = (global::CombatTrackerClient.NavigationButton)(target);
                    #line 39 "..\..\..\Pages\MainPage.xaml"
                    ((global::CombatTrackerClient.NavigationButton)this.NavCombat).PointerReleased += this.Pointer_Released;
                    #line 39 "..\..\..\Pages\MainPage.xaml"
                    ((global::CombatTrackerClient.NavigationButton)this.NavCombat).PointerPressed += this.Navigation_Pressed;
                    #line default
                }
                break;
            case 16:
                {
                    this.NavSkills = (global::CombatTrackerClient.NavigationButton)(target);
                    #line 40 "..\..\..\Pages\MainPage.xaml"
                    ((global::CombatTrackerClient.NavigationButton)this.NavSkills).PointerReleased += this.Pointer_Released;
                    #line 40 "..\..\..\Pages\MainPage.xaml"
                    ((global::CombatTrackerClient.NavigationButton)this.NavSkills).PointerPressed += this.Navigation_Pressed;
                    #line default
                }
                break;
            case 17:
                {
                    this.NavFeats = (global::CombatTrackerClient.NavigationButton)(target);
                    #line 41 "..\..\..\Pages\MainPage.xaml"
                    ((global::CombatTrackerClient.NavigationButton)this.NavFeats).PointerReleased += this.Pointer_Released;
                    #line 41 "..\..\..\Pages\MainPage.xaml"
                    ((global::CombatTrackerClient.NavigationButton)this.NavFeats).PointerPressed += this.Navigation_Pressed;
                    #line default
                }
                break;
            case 18:
                {
                    this.NavInventory = (global::CombatTrackerClient.NavigationButton)(target);
                    #line 42 "..\..\..\Pages\MainPage.xaml"
                    ((global::CombatTrackerClient.NavigationButton)this.NavInventory).PointerReleased += this.Pointer_Released;
                    #line 42 "..\..\..\Pages\MainPage.xaml"
                    ((global::CombatTrackerClient.NavigationButton)this.NavInventory).PointerPressed += this.Navigation_Pressed;
                    #line default
                }
                break;
            case 19:
                {
                    this.NavSpells = (global::CombatTrackerClient.NavigationButton)(target);
                    #line 43 "..\..\..\Pages\MainPage.xaml"
                    ((global::CombatTrackerClient.NavigationButton)this.NavSpells).PointerReleased += this.Pointer_Released;
                    #line 43 "..\..\..\Pages\MainPage.xaml"
                    ((global::CombatTrackerClient.NavigationButton)this.NavSpells).PointerPressed += this.Navigation_Pressed;
                    #line default
                }
                break;
            case 20:
                {
                    this.NavParty = (global::CombatTrackerClient.NavigationButton)(target);
                    #line 44 "..\..\..\Pages\MainPage.xaml"
                    ((global::CombatTrackerClient.NavigationButton)this.NavParty).PointerReleased += this.Pointer_Released;
                    #line 44 "..\..\..\Pages\MainPage.xaml"
                    ((global::CombatTrackerClient.NavigationButton)this.NavParty).PointerPressed += this.Navigation_Pressed;
                    #line default
                }
                break;
            case 21:
                {
                    this.NavSettings = (global::CombatTrackerClient.NavigationButton)(target);
                    #line 45 "..\..\..\Pages\MainPage.xaml"
                    ((global::CombatTrackerClient.NavigationButton)this.NavSettings).PointerReleased += this.Pointer_Released;
                    #line 45 "..\..\..\Pages\MainPage.xaml"
                    ((global::CombatTrackerClient.NavigationButton)this.NavSettings).PointerPressed += this.Navigation_Pressed;
                    #line default
                }
                break;
            case 22:
                {
                    this.NavCharactersMenu = (global::CombatTrackerClient.FilesButton)(target);
                    #line 46 "..\..\..\Pages\MainPage.xaml"
                    ((global::CombatTrackerClient.FilesButton)this.NavCharactersMenu).PointerReleased += this.LoadPointer_Released;
                    #line 46 "..\..\..\Pages\MainPage.xaml"
                    ((global::CombatTrackerClient.FilesButton)this.NavCharactersMenu).PointerPressed += this.LoadButton_Pressed;
                    #line default
                }
                break;
            default:
                break;
            }
            this._contentLoaded = true;
        }

        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 14.0.0.0")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public global::Windows.UI.Xaml.Markup.IComponentConnector GetBindingConnector(int connectionId, object target)
        {
            global::Windows.UI.Xaml.Markup.IComponentConnector returnValue = null;
            return returnValue;
        }
    }
}

