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

Public Class MainPage
    Inherits System.Windows.Controls.UserControl

    Friend WithEvents LayoutRoot As System.Windows.Controls.Grid

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

        btn = New Button()
        btn.HorizontalAlignment = HorizontalAlignment.Center
        btn.VerticalAlignment = VerticalAlignment.Center
        btn.Content = "VB.NET, Click me!"

        AddHandler btn.Click, AddressOf Button_Click
        Me.Content = btn
    End Sub

    Public Sub New()
        InitializeComponent()
    End Sub

    Private Sub Button_Click(sender As Object, e As RoutedEventArgs)
        btn.Content = "You clicked!"
    End Sub
End Class
