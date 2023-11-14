namespace AppF

open System.Windows.Controls
open System.Windows

type AppFComponentBuiltinControlXamlFactory() = 
    interface OpenSilver.Internal.Xaml.IXamlComponentFactory<BuiltInControlXaml> with
        member this.CreateComponent(): obj = 
            this.CreateComponentImpl()
        member this.CreateComponent() = this.CreateComponentImpl()

    interface OpenSilver.Internal.Xaml.IXamlComponentLoader<BuiltInControlXaml> with
        member this.LoadComponent(_component: obj): unit = 
            this.LoadComponentImpl(_component :?> BuiltInControlXaml)
        member this.LoadComponent(_component: BuiltInControlXaml): unit = 
            this.LoadComponentImpl(_component)
    
    member private this.CreateComponentImpl() : BuiltInControlXaml =
        CSHTML5.Internal.TypeInstantiationHelper.Instantiate(typeof<BuiltInControlXaml>) :?> BuiltInControlXaml

    member private this.LoadComponentImpl(_component: BuiltInControlXaml) =
        if (_component :> System.Windows.UIElement) <> null then
            (_component :> System.Windows.UIElement).XamlSourcePath <- @"AppF\BuiltInControl.xaml"
            
        let xamlContext = OpenSilver.Internal.Xaml.RuntimeHelpers.Create_XamlContext()
        let textBlock = new System.Windows.Controls.TextBlock(Text = "Hello, F#!")
        OpenSilver.Internal.Xaml.RuntimeHelpers.XamlContext_WriteStartObject(xamlContext, _component) |> ignore
        OpenSilver.Internal.Xaml.RuntimeHelpers.XamlContext_WriteStartObject(xamlContext, textBlock) |> ignore
        OpenSilver.Internal.Xaml.RuntimeHelpers.XamlContext_WriteEndObject(xamlContext) |> ignore
        _component.Content <- textBlock
        OpenSilver.Internal.Xaml.RuntimeHelpers.XamlContext_WriteEndObject(xamlContext) |> ignore
        OpenSilver.Internal.Xaml.RuntimeHelpers.InitializeNameScope(_component) |> ignore
        OpenSilver.Internal.Xaml.RuntimeHelpers.RegisterName(_component, @"text1", textBlock) |> ignore

and BuiltInControlXaml() = 
    inherit UserControl()
    let mutable contentLoaded = false
    let mutable text1_local = Unchecked.defaultof<TextBlock>
    member this.text1
        with get() = text1_local
        and set(value) = text1_local <- value

    member this.InitializeComponent() =
        if contentLoaded then
            ()
        
        contentLoaded <- true
        Application.LoadComponent(this, AppFComponentBuiltinControlXamlFactory())
        text1_local <- this.FindName("text1") :?> TextBlock

type BuiltInControl() as this =
    inherit BuiltInControlXaml()
    
    do
        this.InitializeComponent()
        this.text1.FontSize <- 30

