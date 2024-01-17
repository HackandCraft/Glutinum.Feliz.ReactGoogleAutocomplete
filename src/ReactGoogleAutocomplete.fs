namespace rec Glutinum.Feliz.ReactGoogleAutocomplete

open Fable.Core
open Fable.Core.JsInterop
open Browser.Types
open Fable.React
open Feliz
open System

[<AllowNullLiteral>]
[<Global>]
type ReactGoogleAutocompleteProps
    [<ParamObject; Emit("$0")>]
    (
        ?inputAutocompleteValue: string,
        ?options: obj, // google.maps.places.AutocompleteOptions
        ?onPlaceSelected:
            (obj -> IRefValue<HTMLInputElement> -> IRefValue<obj> -> unit),
        ?libraries: ResizeArray<string>,
        ?apiKey: string,
        ?language: string,
        ?googleMapsScriptBaseUrl: string
    )
    =

    member val inputAutocompleteValue: string option = nativeOnly with get, set
    member val options: obj option = nativeOnly with get, set

    member val onPlaceSelected: (obj
        -> IRefValue<HTMLInputElement>
        -> IRefValue<obj>
        -> unit) option = nativeOnly with get, set

    member val libraries: ResizeArray<string> option = nativeOnly with get, set
    member val apiKey: string option = nativeOnly with get, set
    member val language: string option = nativeOnly with get, set
    member val googleMapsScriptBaseUrl: string option = nativeOnly with get, set

[<Erase>]
type reactGoogleAutocomplete =

    static member inline inputAutocompleteValue(value: string) =
        Interop.mkAttr "inputAutocompleteValue" value

    static member inline options(value: obj) = Interop.mkAttr "options" value

    static member inline onPlaceSelected
        (value: obj -> IRefValue<HTMLInputElement> -> IRefValue<obj> -> unit)
        =
        Interop.mkAttr "onPlaceSelected" (Func<_, _, _, _>(value))

    static member inline libraries(value: ResizeArray<string>) =
        Interop.mkAttr "libraries" value

    static member inline apiKey(value: string) = Interop.mkAttr "apiKey" value

    static member inline language(value: string) =
        Interop.mkAttr "language" value

    static member inline googleMapsScriptBaseUrl(value: string) =
        Interop.mkAttr "googleMapsScriptBaseUrl" value
