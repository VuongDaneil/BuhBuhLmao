﻿#pragma checksum "..\..\..\LevelView\CustomPlaying.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "1D2C9B386BF9597E674E8B74AE1C9B53CB49194AF951635877B4A7CEE52C14CB"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using BuBuLmao;
using MaterialDesignThemes.Wpf;
using MaterialDesignThemes.Wpf.Converters;
using MaterialDesignThemes.Wpf.Transitions;
using System;
using System.Diagnostics;
using System.Windows;
using System.Windows.Automation;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Ink;
using System.Windows.Input;
using System.Windows.Markup;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Media.Effects;
using System.Windows.Media.Imaging;
using System.Windows.Media.Media3D;
using System.Windows.Media.TextFormatting;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Windows.Shell;


namespace BuBuLmao.LevelView {
    
    
    /// <summary>
    /// CustomPlaying
    /// </summary>
    public partial class CustomPlaying : System.Windows.Window, System.Windows.Markup.IComponentConnector, System.Windows.Markup.IStyleConnector {
        
        
        #line 59 "..\..\..\LevelView\CustomPlaying.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ListBox itemsList;
        
        #line default
        #line hidden
        
        
        #line 80 "..\..\..\LevelView\CustomPlaying.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Canvas puzzlePart1;
        
        #line default
        #line hidden
        
        
        #line 82 "..\..\..\LevelView\CustomPlaying.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Canvas puzzlePart2;
        
        #line default
        #line hidden
        
        
        #line 84 "..\..\..\LevelView\CustomPlaying.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Canvas puzzlePart3;
        
        #line default
        #line hidden
        
        
        #line 87 "..\..\..\LevelView\CustomPlaying.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Canvas puzzlePart4;
        
        #line default
        #line hidden
        
        
        #line 89 "..\..\..\LevelView\CustomPlaying.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Canvas puzzlePart5;
        
        #line default
        #line hidden
        
        
        #line 91 "..\..\..\LevelView\CustomPlaying.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Canvas puzzlePart6;
        
        #line default
        #line hidden
        
        
        #line 94 "..\..\..\LevelView\CustomPlaying.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Canvas puzzlePart7;
        
        #line default
        #line hidden
        
        
        #line 96 "..\..\..\LevelView\CustomPlaying.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Canvas puzzlePart8;
        
        #line default
        #line hidden
        
        
        #line 98 "..\..\..\LevelView\CustomPlaying.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Canvas puzzlePart9;
        
        #line default
        #line hidden
        
        private bool _contentLoaded;
        
        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "4.0.0.0")]
        public void InitializeComponent() {
            if (_contentLoaded) {
                return;
            }
            _contentLoaded = true;
            System.Uri resourceLocater = new System.Uri("/BuBuLmao;component/levelview/customplaying.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\LevelView\CustomPlaying.xaml"
            System.Windows.Application.LoadComponent(this, resourceLocater);
            
            #line default
            #line hidden
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "4.0.0.0")]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
        void System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target) {
            switch (connectionId)
            {
            case 2:
            
            #line 49 "..\..\..\LevelView\CustomPlaying.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.Button_Click);
            
            #line default
            #line hidden
            return;
            case 3:
            this.itemsList = ((System.Windows.Controls.ListBox)(target));
            
            #line 61 "..\..\..\LevelView\CustomPlaying.xaml"
            this.itemsList.PreviewMouseLeftButtonDown += new System.Windows.Input.MouseButtonEventHandler(this.itemList_PreviewMouseLeftButtonDown);
            
            #line default
            #line hidden
            return;
            case 4:
            this.puzzlePart1 = ((System.Windows.Controls.Canvas)(target));
            return;
            case 5:
            this.puzzlePart2 = ((System.Windows.Controls.Canvas)(target));
            return;
            case 6:
            this.puzzlePart3 = ((System.Windows.Controls.Canvas)(target));
            return;
            case 7:
            this.puzzlePart4 = ((System.Windows.Controls.Canvas)(target));
            return;
            case 8:
            this.puzzlePart5 = ((System.Windows.Controls.Canvas)(target));
            return;
            case 9:
            this.puzzlePart6 = ((System.Windows.Controls.Canvas)(target));
            return;
            case 10:
            this.puzzlePart7 = ((System.Windows.Controls.Canvas)(target));
            return;
            case 11:
            this.puzzlePart8 = ((System.Windows.Controls.Canvas)(target));
            return;
            case 12:
            this.puzzlePart9 = ((System.Windows.Controls.Canvas)(target));
            return;
            }
            this._contentLoaded = true;
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "4.0.0.0")]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        void System.Windows.Markup.IStyleConnector.Connect(int connectionId, object target) {
            System.Windows.EventSetter eventSetter;
            switch (connectionId)
            {
            case 1:
            eventSetter = new System.Windows.EventSetter();
            eventSetter.Event = System.Windows.UIElement.DropEvent;
            
            #line 39 "..\..\..\LevelView\CustomPlaying.xaml"
            eventSetter.Handler = new System.Windows.DragEventHandler(this.PuzzleItemDrop);
            
            #line default
            #line hidden
            ((System.Windows.Style)(target)).Setters.Add(eventSetter);
            eventSetter = new System.Windows.EventSetter();
            eventSetter.Event = System.Windows.UIElement.PreviewMouseLeftButtonDownEvent;
            
            #line 40 "..\..\..\LevelView\CustomPlaying.xaml"
            eventSetter.Handler = new System.Windows.Input.MouseButtonEventHandler(this.PzItmCvs_MouseLeftButtonDown);
            
            #line default
            #line hidden
            ((System.Windows.Style)(target)).Setters.Add(eventSetter);
            break;
            }
        }
    }
}

