﻿#pragma checksum "F:\uwp.vtnorton.com\redmond\ProjectRedmonde\Views\SendFeedback.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "782E353EAA0427772CBDE30F2F30E0FA"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ProjectRedmonde.Views
{
    partial class SendFeedback : 
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
            case 1: // Views\SendFeedback.xaml line 10
                {
                    this.gdrSendFeedback = (global::Windows.UI.Xaml.Controls.Grid)(target);
                }
                break;
            case 2: // Views\SendFeedback.xaml line 23
                {
                    this.txtEmail = (global::Windows.UI.Xaml.Controls.TextBox)(target);
                }
                break;
            case 3: // Views\SendFeedback.xaml line 24
                {
                    this.txtSubject = (global::Windows.UI.Xaml.Controls.TextBox)(target);
                }
                break;
            case 4: // Views\SendFeedback.xaml line 25
                {
                    this.txtMenssage = (global::Windows.UI.Xaml.Controls.RichEditBox)(target);
                }
                break;
            case 5: // Views\SendFeedback.xaml line 28
                {
                    this.btnSend = (global::Windows.UI.Xaml.Controls.Button)(target);
                    ((global::Windows.UI.Xaml.Controls.Button)this.btnSend).Click += this.btnSend_Click;
                }
                break;
            case 6: // Views\SendFeedback.xaml line 29
                {
                    this.lblMenssage = (global::Windows.UI.Xaml.Controls.TextBlock)(target);
                }
                break;
            default:
                break;
            }
            this._contentLoaded = true;
        }

        /// <summary>
        /// GetBindingConnector(int connectionId, object target)
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 14.0.0.0")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public global::Windows.UI.Xaml.Markup.IComponentConnector GetBindingConnector(int connectionId, object target)
        {
            global::Windows.UI.Xaml.Markup.IComponentConnector returnValue = null;
            return returnValue;
        }
    }
}
