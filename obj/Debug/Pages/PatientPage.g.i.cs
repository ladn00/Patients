﻿#pragma checksum "..\..\..\Pages\PatientPage.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "05B2D6FF222773D189C6FF6C59DA0835C57B982CE857A42E5C970B716A235BD8"
//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан программой.
//     Исполняемая версия:4.0.30319.42000
//
//     Изменения в этом файле могут привести к неправильной работе и будут потеряны в случае
//     повторной генерации кода.
// </auto-generated>
//------------------------------------------------------------------------------

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
using Проверочная_работа_2.Pages;


namespace Проверочная_работа_2.Pages {
    
    
    /// <summary>
    /// PatientPage
    /// </summary>
    public partial class PatientPage : System.Windows.Controls.Page, System.Windows.Markup.IComponentConnector {
        
        
        #line 17 "..\..\..\Pages\PatientPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox cbInsurance;
        
        #line default
        #line hidden
        
        
        #line 18 "..\..\..\Pages\PatientPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox cbCountry;
        
        #line default
        #line hidden
        
        
        #line 19 "..\..\..\Pages\PatientPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox cbSocialType;
        
        #line default
        #line hidden
        
        
        #line 20 "..\..\..\Pages\PatientPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox tbLogin;
        
        #line default
        #line hidden
        
        
        #line 21 "..\..\..\Pages\PatientPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox tbFIO;
        
        #line default
        #line hidden
        
        
        #line 23 "..\..\..\Pages\PatientPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ListView lw1;
        
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
            System.Uri resourceLocater = new System.Uri("/Проверочная работа 2;component/pages/patientpage.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\Pages\PatientPage.xaml"
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
            this.cbInsurance = ((System.Windows.Controls.ComboBox)(target));
            
            #line 17 "..\..\..\Pages\PatientPage.xaml"
            this.cbInsurance.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.cbInsurance_SelectionChanged);
            
            #line default
            #line hidden
            return;
            case 2:
            this.cbCountry = ((System.Windows.Controls.ComboBox)(target));
            
            #line 18 "..\..\..\Pages\PatientPage.xaml"
            this.cbCountry.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.cbCountry_SelectionChanged);
            
            #line default
            #line hidden
            return;
            case 3:
            this.cbSocialType = ((System.Windows.Controls.ComboBox)(target));
            
            #line 19 "..\..\..\Pages\PatientPage.xaml"
            this.cbSocialType.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.cbSocialType_SelectionChanged);
            
            #line default
            #line hidden
            return;
            case 4:
            this.tbLogin = ((System.Windows.Controls.TextBox)(target));
            
            #line 20 "..\..\..\Pages\PatientPage.xaml"
            this.tbLogin.TextChanged += new System.Windows.Controls.TextChangedEventHandler(this.loginSearch_TextChanged);
            
            #line default
            #line hidden
            return;
            case 5:
            this.tbFIO = ((System.Windows.Controls.TextBox)(target));
            
            #line 21 "..\..\..\Pages\PatientPage.xaml"
            this.tbFIO.TextChanged += new System.Windows.Controls.TextChangedEventHandler(this.FIOSearch_TextChanged);
            
            #line default
            #line hidden
            return;
            case 6:
            this.lw1 = ((System.Windows.Controls.ListView)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}

