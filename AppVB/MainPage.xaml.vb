Imports System
Imports System.Windows
Imports System.Windows.Automation
Imports System.Windows.Automation.Peers
Imports System.Windows.Automation.Provider
Imports System.Windows.Controls
Imports System.Windows.Controls.Primitives
Imports System.Windows.Data
Imports System.Windows.Documents
Imports System.Windows.Ink
Imports System.Windows.Input
Imports System.Windows.Interop
Imports System.Windows.Markup
Imports System.Windows.Media
Imports System.Windows.Media.Animation
Imports System.Windows.Media.Imaging
Imports System.Windows.Resources
Imports System.Windows.Shapes
Imports System.Windows.Threading
Imports OpenSilver.Internal.Xaml

<System.Diagnostics.DebuggerNonUserCodeAttribute()>
<System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)>
Public NotInheritable Class ǀǀAppcǀǀComponentǀǀMainpageǀǀXamlǀǀFactory
    Implements IXamlComponentFactory(Of AppVB.MainPage), IXamlComponentLoader(Of AppVB.MainPage)

    Public Shared Function Instantiate() As Object
        Return CreateComponentImpl()
    End Function

    Private Function IXamlComponentFactory_CreateComponent() As Object Implements IXamlComponentFactory.CreateComponent
        Return CreateComponentImpl()
    End Function

    Private Function IXamlComponentFactory_CreateComponent1() As MainPage Implements IXamlComponentFactory(Of MainPage).CreateComponent
        Return CreateComponentImpl()
    End Function

    Private Sub IXamlComponentLoader_LoadComponent(component As MainPage) Implements IXamlComponentLoader(Of MainPage).LoadComponent
        LoadComponentImpl(component)
    End Sub

    Private Sub IXamlComponentLoader_LoadComponent1(component As Object) Implements IXamlComponentLoader.LoadComponent
        LoadComponentImpl(component)
    End Sub

    Private Shared Sub LoadComponentImpl(ByVal Page_2a308af15f3640f99021986feb152ee6 As AppVB.MainPage)
        If TypeOf Page_2a308af15f3640f99021986feb152ee6 Is System.Windows.UIElement Then
            ' (CType(CObj(Page_2a308af15f3640f99021986feb152ee6), System.Windows.UIElement)).XamlSourcePath = "AppVB\MainPage.xaml"
        End If

        Dim xamlContext_b6101df8b6e24c29bc3049db9faa6847 = OpenSilver.Internal.Xaml.RuntimeHelpers.Create_XamlContext()
        OpenSilver.Internal.Xaml.RuntimeHelpers.XamlContext_PushScope(xamlContext_b6101df8b6e24c29bc3049db9faa6847, Page_2a308af15f3640f99021986feb152ee6)
        Dim Button_ac63f88b908d4b35a05c5c14c66ac320 = OpenSilver.Internal.Xaml.RuntimeHelpers.XamlContext_PushScope(xamlContext_b6101df8b6e24c29bc3049db9faa6847, New System.Windows.Controls.Button())
        Button_ac63f88b908d4b35a05c5c14c66ac320.Name = "btn"
        Button_ac63f88b908d4b35a05c5c14c66ac320.VerticalAlignment = System.Windows.VerticalAlignment.Center
        Button_ac63f88b908d4b35a05c5c14c66ac320.HorizontalAlignment = System.Windows.HorizontalAlignment.Center
        OpenSilver.Internal.Xaml.RuntimeHelpers.XamlContext_SetConnectionId(xamlContext_b6101df8b6e24c29bc3049db9faa6847, 0, Button_ac63f88b908d4b35a05c5c14c66ac320)
        Button_ac63f88b908d4b35a05c5c14c66ac320.Content = OpenSilver.Internal.Xaml.RuntimeHelpers.GetPropertyValue(Of System.Object)(GetType(System.Windows.Controls.Button), "Content", "VB.NET, Click Here!", Function() "VB.NET, Click Here!")
        OpenSilver.Internal.Xaml.RuntimeHelpers.XamlContext_PopScope(xamlContext_b6101df8b6e24c29bc3049db9faa6847)
        Page_2a308af15f3640f99021986feb152ee6.Content = Button_ac63f88b908d4b35a05c5c14c66ac320
        OpenSilver.Internal.Xaml.RuntimeHelpers.XamlContext_PopScope(xamlContext_b6101df8b6e24c29bc3049db9faa6847)
        OpenSilver.Internal.Xaml.RuntimeHelpers.InitializeNameScope(Page_2a308af15f3640f99021986feb152ee6)
        OpenSilver.Internal.Xaml.RuntimeHelpers.RegisterName(Page_2a308af15f3640f99021986feb152ee6, "btn", Button_ac63f88b908d4b35a05c5c14c66ac320)
    End Sub

    Private Shared Function CreateComponentImpl() As AppVB.MainPage
        Return CType(CSHTML5.Internal.TypeInstantiationHelper.Instantiate(GetType(AppVB.MainPage)), AppVB.MainPage)
    End Function
End Class

Partial Public Class MainPage
    Inherits System.Windows.Controls.Page
    Implements OpenSilver.Internal.Xaml.IComponentConnector

    Private _contentLoaded As Boolean

    Private btn As Button

    '''<summary>
    '''InitializeComponent
    '''</summary>
    <System.Diagnostics.DebuggerNonUserCodeAttribute()>
    Public Sub InitializeComponent()
        If _contentLoaded Then
            Return
        End If
        _contentLoaded = True

        Application.LoadComponent(Me, New ǀǀAppcǀǀComponentǀǀMainpageǀǀXamlǀǀFactory())
        btn = Me.FindName("btn")
    End Sub

    <System.Diagnostics.DebuggerNonUserCodeAttribute()>
    <System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)>
    Private Sub IComponentConnector_Connect(componentId As Integer, target As Object) Implements IComponentConnector.Connect
        Select Case componentId
            Case 0
                AddHandler CType(target, Button).Click, AddressOf Button_Click
                Return
        End Select
    End Sub
End Class

Public Class MainPage
    Inherits System.Windows.Controls.Page

    Public Sub New()
        InitializeComponent()
    End Sub

    Private Sub Button_Click(sender As Object, e As RoutedEventArgs)
        btn.Content = "You clicked!"
    End Sub
End Class
