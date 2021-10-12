// Copyright 2018 Fabulous contributors. See LICENSE.md for license.
namespace FabulousPlayGround.iOS

open System
open UIKit
open Foundation
open Xamarin.Forms
open Xamarin.Forms.Platform.iOS

[<Register ("AppDelegate")>]
type AppDelegate () =
    inherit FormsApplicationDelegate ()

    override this.FinishedLaunching (app, options) =
        Forms.Init()
        let appCore = new FabulousPlayGround.App()
        this.LoadApplication (appCore)
        base.FinishedLaunching(app, options)

module Main =
    [<EntryPoint>]
    let main args =
        UIApplication.Main(args, null, nameof(AppDelegate))
        0

