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
Imports OpenSilver.Internal.Xaml.Context

Public Class MainPage
    Inherits System.Windows.Controls.UserControl

    Public Sub New()
        InitializeComponent()
    End Sub

    Private Sub Button_Click(sender As Object, e As RoutedEventArgs)
        btn.Content = "You clicked!"
    End Sub

    Private Sub TextBoxName_TextChanged(sender As Object, e As TextChangedEventArgs)
        Console.WriteLine("TextBoxName_TextChanged")
    End Sub

    Private Sub ChangeText_Click(sender As Object, e As RoutedEventArgs)
        Console.WriteLine("ChangeText_Click")
    End Sub

    Private Sub TextBox2_TextChanged(sender As Object, e As TextChangedEventArgs)
        Console.WriteLine("TextBox2_TextChanged")
    End Sub
End Class
