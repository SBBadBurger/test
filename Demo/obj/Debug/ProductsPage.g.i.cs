﻿#pragma checksum "..\..\ProductsPage.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "2F94C232BF6E67581785342F391EA40BA9083B0D9C5C63F212C13DDB6EA643DC"
//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан программой.
//     Исполняемая версия:4.0.30319.42000
//
//     Изменения в этом файле могут привести к неправильной работе и будут потеряны в случае
//     повторной генерации кода.
// </auto-generated>
//------------------------------------------------------------------------------

using Demo;
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


namespace Demo {
    
    
    /// <summary>
    /// ProductsPage
    /// </summary>
    public partial class ProductsPage : System.Windows.Controls.Page, System.Windows.Markup.IComponentConnector, System.Windows.Markup.IStyleConnector {
        
        
        #line 14 "..\..\ProductsPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.RowDefinition LowGridRow;
        
        #line default
        #line hidden
        
        
        #line 18 "..\..\ProductsPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox SearchTextBox;
        
        #line default
        #line hidden
        
        
        #line 20 "..\..\ProductsPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.RadioButton MinRadio;
        
        #line default
        #line hidden
        
        
        #line 21 "..\..\ProductsPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.RadioButton MaxRadio;
        
        #line default
        #line hidden
        
        
        #line 24 "..\..\ProductsPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock CurrentTextBlock;
        
        #line default
        #line hidden
        
        
        #line 25 "..\..\ProductsPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ListView ProductsList;
        
        #line default
        #line hidden
        
        
        #line 45 "..\..\ProductsPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.StackPanel LowStackPanel;
        
        #line default
        #line hidden
        
        
        #line 46 "..\..\ProductsPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button AddProductButton;
        
        #line default
        #line hidden
        
        
        #line 47 "..\..\ProductsPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button DeleteProductButton;
        
        #line default
        #line hidden
        
        
        #line 48 "..\..\ProductsPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button EditProductButton;
        
        #line default
        #line hidden
        
        
        #line 49 "..\..\ProductsPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button CurrentOrderButton;
        
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
            System.Uri resourceLocater = new System.Uri("/Demo;component/productspage.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\ProductsPage.xaml"
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
            case 1:
            this.LowGridRow = ((System.Windows.Controls.RowDefinition)(target));
            return;
            case 2:
            this.SearchTextBox = ((System.Windows.Controls.TextBox)(target));
            
            #line 18 "..\..\ProductsPage.xaml"
            this.SearchTextBox.TextChanged += new System.Windows.Controls.TextChangedEventHandler(this.SearchTextBox_TextChanged);
            
            #line default
            #line hidden
            return;
            case 3:
            this.MinRadio = ((System.Windows.Controls.RadioButton)(target));
            
            #line 20 "..\..\ProductsPage.xaml"
            this.MinRadio.Checked += new System.Windows.RoutedEventHandler(this.MinRadio_Checked);
            
            #line default
            #line hidden
            return;
            case 4:
            this.MaxRadio = ((System.Windows.Controls.RadioButton)(target));
            
            #line 21 "..\..\ProductsPage.xaml"
            this.MaxRadio.Checked += new System.Windows.RoutedEventHandler(this.MaxRadio_Checked);
            
            #line default
            #line hidden
            return;
            case 5:
            this.CurrentTextBlock = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 6:
            this.ProductsList = ((System.Windows.Controls.ListView)(target));
            return;
            case 8:
            this.LowStackPanel = ((System.Windows.Controls.StackPanel)(target));
            return;
            case 9:
            this.AddProductButton = ((System.Windows.Controls.Button)(target));
            
            #line 46 "..\..\ProductsPage.xaml"
            this.AddProductButton.Click += new System.Windows.RoutedEventHandler(this.AddProductButton_Click);
            
            #line default
            #line hidden
            return;
            case 10:
            this.DeleteProductButton = ((System.Windows.Controls.Button)(target));
            
            #line 47 "..\..\ProductsPage.xaml"
            this.DeleteProductButton.Click += new System.Windows.RoutedEventHandler(this.DeleteProductButton_Click);
            
            #line default
            #line hidden
            return;
            case 11:
            this.EditProductButton = ((System.Windows.Controls.Button)(target));
            
            #line 48 "..\..\ProductsPage.xaml"
            this.EditProductButton.Click += new System.Windows.RoutedEventHandler(this.EditProductButton_Click);
            
            #line default
            #line hidden
            return;
            case 12:
            this.CurrentOrderButton = ((System.Windows.Controls.Button)(target));
            
            #line 49 "..\..\ProductsPage.xaml"
            this.CurrentOrderButton.Click += new System.Windows.RoutedEventHandler(this.InfoButton_Click);
            
            #line default
            #line hidden
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
            switch (connectionId)
            {
            case 7:
            
            #line 40 "..\..\ProductsPage.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.Button_Click);
            
            #line default
            #line hidden
            break;
            }
        }
    }
}
