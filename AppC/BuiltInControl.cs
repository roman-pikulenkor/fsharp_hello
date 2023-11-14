using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Data;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Navigation;

[global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
public sealed class ǀǀAppcǀǀComponentǀǀBuiltincontrolǀǀXamlǀǀFactory : global::OpenSilver.Internal.Xaml.IXamlComponentFactory<global::AppC.BuiltInControlXaml>, global::OpenSilver.Internal.Xaml.IXamlComponentLoader<global::AppC.BuiltInControlXaml>
{
    public static object Instantiate()
    {
        return CreateComponentImpl();
    }

    global::AppC.BuiltInControlXaml global::OpenSilver.Internal.Xaml.IXamlComponentFactory<global::AppC.BuiltInControlXaml>.CreateComponent()
    {
        return CreateComponentImpl();
    }

    object global::OpenSilver.Internal.Xaml.IXamlComponentFactory.CreateComponent()
    {
        return CreateComponentImpl();
    }

    void global::OpenSilver.Internal.Xaml.IXamlComponentLoader<global::AppC.BuiltInControlXaml>.LoadComponent(global::AppC.BuiltInControlXaml component)
    {
        LoadComponentImpl(component);
    }

    void global::OpenSilver.Internal.Xaml.IXamlComponentLoader.LoadComponent(object component)
    {
        LoadComponentImpl((global::AppC.BuiltInControlXaml)component);
    }

    private static void LoadComponentImpl(global::AppC.BuiltInControlXaml UserControl_9756511f7b964cc6bca16016f5ccbd10)
    {
        if ((object)UserControl_9756511f7b964cc6bca16016f5ccbd10 is global::System.Windows.UIElement)
        {
            ((global::System.Windows.UIElement)(object)UserControl_9756511f7b964cc6bca16016f5ccbd10).XamlSourcePath = @"AppC\BuiltInControl.xaml";
        }

        var xamlContext_6c2ba423ae564ac1a826f7a1025ab7ea = global::OpenSilver.Internal.Xaml.RuntimeHelpers.Create_XamlContext();
        _ = global::OpenSilver.Internal.Xaml.RuntimeHelpers.XamlContext_WriteStartObject(xamlContext_6c2ba423ae564ac1a826f7a1025ab7ea, UserControl_9756511f7b964cc6bca16016f5ccbd10);
        var TextBlock_251845b9cb3e4d7a9572af9285f4da54 = global::OpenSilver.Internal.Xaml.RuntimeHelpers.XamlContext_WriteStartObject(xamlContext_6c2ba423ae564ac1a826f7a1025ab7ea, new global::System.Windows.Controls.TextBlock());
        TextBlock_251845b9cb3e4d7a9572af9285f4da54.Text = @"Here!";
        global::OpenSilver.Internal.Xaml.RuntimeHelpers.XamlContext_WriteEndObject(xamlContext_6c2ba423ae564ac1a826f7a1025ab7ea);
        UserControl_9756511f7b964cc6bca16016f5ccbd10.Content = TextBlock_251845b9cb3e4d7a9572af9285f4da54;
        global::OpenSilver.Internal.Xaml.RuntimeHelpers.XamlContext_WriteEndObject(xamlContext_6c2ba423ae564ac1a826f7a1025ab7ea);
        global::OpenSilver.Internal.Xaml.RuntimeHelpers.InitializeNameScope(UserControl_9756511f7b964cc6bca16016f5ccbd10);

    }

    private static global::AppC.BuiltInControlXaml CreateComponentImpl()
    {
        return (global::AppC.BuiltInControlXaml)global::CSHTML5.Internal.TypeInstantiationHelper.Instantiate(typeof(global::AppC.BuiltInControlXaml));
    }
}


namespace AppC
{

    public partial class BuiltInControlXaml : global::System.Windows.Controls.UserControl, global::OpenSilver.Internal.Xaml.IComponentConnector
    {

#pragma warning disable 169, 649, 0628 // Prevents warning CS0169 ('field ... is never used'), CS0649 ('field ... is never assigned to, and will always have its default value null'), and CS0628 ('member : new protected member declared in sealed class')

#pragma warning restore 169, 649, 0628




        private bool _contentLoaded;

        /// <summary>
        /// InitializeComponent
        /// </summary>
        public void InitializeComponent()
        {
            if (_contentLoaded)
            {
                return;
            }
            _contentLoaded = true;

            global::System.Windows.Application.LoadComponent(this, new global::ǀǀAppcǀǀComponentǀǀBuiltincontrolǀǀXamlǀǀFactory());

        }


        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        void global::OpenSilver.Internal.Xaml.IComponentConnector.Connect(int componentId, object target)
        {
        }




    }


    public partial class BuiltInControl : BuiltInControlXaml
    {
        public BuiltInControl()
        {
            this.InitializeComponent();
        }
    }
}
