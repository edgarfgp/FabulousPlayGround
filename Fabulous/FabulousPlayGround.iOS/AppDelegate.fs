// Copyright 2018 Fabulous contributors. See LICENSE.md for license.
namespace FabulousPlayGround.iOS

open System
open FabulousPlayGround
open UIKit
open Foundation
open Xamarin.Forms
open Xamarin.Forms.Platform.iOS
open Fabulous.XamarinForms

[<Register("AppDelegate")>]
type AppDelegate() =
    inherit FormsApplicationDelegate()

    override this.FinishedLaunching(app, options) =
        Forms.Init()
        let prg = App.program
        let appx = Program.create prg ()
        let application: Xamarin.Forms.Application = unbox appx
        this.LoadApplication application
        base.FinishedLaunching(app, options)

module Main =
    [<EntryPoint>]
    let main args =
        UIApplication.Main(args, null, typeof<AppDelegate>)
        0
