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

[<AllowNullLiteral>]
[<Global>]
type UsePlacesAutocompleteServiceConfig
    [<ParamObject; Emit("$0")>]
    (
        ?apiKey: string,
        ?libraries: ResizeArray<string>,
        ?googleMapsScriptBaseUrl: string,
        ?debounce: int,
        ?options: obj, // google.maps.places.AutocompletionRequest
        ?sessionToken: bool,
        ?language: string
    )
    =
    member val apiKey: string option = nativeOnly with get, set
    member val libraries: ResizeArray<string> option = nativeOnly with get, set
    member val googleMapsScriptBaseUrl: string option = nativeOnly with get, set
    member val debounce: int option = nativeOnly with get, set
    member val options: obj option = nativeOnly with get, set
    member val sessionToken: bool option = nativeOnly with get, set
    member val language: string option = nativeOnly with get, set

[<AllowNullLiteral>]
[<Global>]
type UsePlacesAutocompleteServiceResponse
    [<ParamObject; Emit("$0")>]
    (
        getPlacePredictions: (obj -> unit), // google.maps.places.AutocompletionRequest
        getQueryPredictions: (obj -> unit), // google.maps.places.QueryAutocompletionRequest
        refreshSessionToken: (unit -> unit),
        ?placeService: obj, // google.maps.places.PlacesService
        ?autocompleteSessionToken: obj, // google.maps.places.AutocompleteSessionToken
        ?placesAutocompleteService: obj, // google.maps.places.AutocompleteService
        ?placePredictions: ResizeArray<Google.Maps.AutocompletePrediction>,
        ?isPlacePredictionsLoading: bool,
        ?queryPredictions: ResizeArray<obj>, // google.maps.places.QueryAutocompletePrediction
        ?isQueryPredictionsLoading: bool
    )
    =
    member val getPlacePredictions: (obj -> unit) = nativeOnly with get, set
    member val getQueryPredictions: (obj -> unit) = nativeOnly with get, set
    member val refreshSessionToken: (unit -> unit) = nativeOnly with get, set
    member val placeService: obj option = nativeOnly with get, set
    member val autocompleteSessionToken: obj option = nativeOnly with get, set
    member val placesAutocompleteService: obj option = nativeOnly with get, set

    member val placePredictions: ResizeArray<Google.Maps.AutocompletePrediction> option =
        nativeOnly with get, set

    member val isPlacePredictionsLoading: bool option = nativeOnly with get, set

    member val queryPredictions: ResizeArray<obj> option =
        nativeOnly with get, set

    member val isQueryPredictionsLoading: bool option = nativeOnly with get, set


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
