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

'Partial Public Class App
'    Inherits System.Windows.Application

'    Private _contentLoaded As Boolean

'    '''<summary>
'    '''InitializeComponent
'    '''</summary>
'    <System.Diagnostics.DebuggerNonUserCodeAttribute()>
'    Public Sub InitializeComponent()
'        If _contentLoaded Then
'            Return
'        End If
'        _contentLoaded = True
'    End Sub

'    Private Sub Application_Exit(ByVal o As Object, ByVal e As EventArgs) Handles Me.Exit

'    End Sub

'    Private Sub Application_UnhandledException(ByVal sender As Object, ByVal e As ApplicationUnhandledExceptionEventArgs) Handles Me.UnhandledException

'        ' If the app is running outside of the debugger then report the exception using
'        ' the browser's exception mechanism. On IE this will display it a yellow alert 
'        ' icon in the status bar and Firefox will display a script error.
'        If Not System.Diagnostics.Debugger.IsAttached Then

'            ' NOTE: This will allow the application to continue running after an exception has been thrown
'            ' but not handled. 
'            ' For production applications this error handling should be replaced with something that will 
'            ' report the error to the website and stop the application.
'            e.Handled = True
'            Deployment.Current.Dispatcher.BeginInvoke(New Action(Of ApplicationUnhandledExceptionEventArgs)(AddressOf ReportErrorToDOM), e)
'        End If
'    End Sub

'    Private Sub ReportErrorToDOM(ByVal e As ApplicationUnhandledExceptionEventArgs)

'        Try
'            Dim errorMsg As String = e.ExceptionObject.Message + e.ExceptionObject.StackTrace
'            errorMsg = errorMsg.Replace(""""c, "'"c).Replace(ChrW(13) & ChrW(10), "\n")

'            System.Windows.Browser.HtmlPage.Window.Eval("throw new Error(""Unhandled Error in Silverlight Application " + errorMsg + """);")
'        Catch

'        End Try
'    End Sub
'End Class


Partial Public Class App
    Public Sub New()
        InitializeComponent()
    End Sub

    Private Sub Application_Startup(ByVal o As Object, ByVal e As StartupEventArgs) Handles Me.Startup
        Me.RootVisual = New MainPage()
    End Sub
End Class