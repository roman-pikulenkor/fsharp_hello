﻿namespace AppF

open System
open System.Windows
open System.Windows.Controls

type MainPage = class
    inherit UserControl
    
    new () as this = {} then
        // Add button and do something with it...
        let btn = new Button(HorizontalAlignment = HorizontalAlignment.Center,
                             VerticalAlignment = VerticalAlignment.Center)
        btn.Content <- "F#, Click me"                             
        btn.Click.Add(fun _ ->
                      btn.Content <- "The button has been clicked!")
        this.Content <- btn
        
end

type App = class
    inherit Application
    
    new () as this = {} then
        // this.Startup.Add(fun _ ->  this.RootVisual <- new MainPage())
        this.Startup.Add(fun _ ->  this.RootVisual <- new BuiltInControl())
end