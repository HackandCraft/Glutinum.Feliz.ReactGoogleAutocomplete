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
        ?options: Google.Maps.Places.AutocompleteOptions,
        ?onPlaceSelected:
            (Google.Maps.Places.PlaceResult
                -> IRefValue<HTMLInputElement>
                -> IRefValue<Google.Maps.Places.Autocomplete>
                -> unit),
        ?libraries: ResizeArray<string>,
        ?apiKey: string,
        ?language: string,
        ?googleMapsScriptBaseUrl: string
    )
    =

    member val inputAutocompleteValue: string option = nativeOnly with get, set

    member val options: Google.Maps.Places.AutocompleteOptions option =
        nativeOnly with get, set

    member val onPlaceSelected: (Google.Maps.Places.PlaceResult
        -> IRefValue<HTMLInputElement>
        -> IRefValue<Google.Maps.Places.Autocomplete>
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
        ?options: Google.Maps.Places.AutocompletionRequest, // google.maps.places.AutocompletionRequest
        ?sessionToken: bool,
        ?language: string
    )
    =
    member val apiKey: string option = nativeOnly with get, set
    member val libraries: ResizeArray<string> option = nativeOnly with get, set
    member val googleMapsScriptBaseUrl: string option = nativeOnly with get, set
    member val debounce: int option = nativeOnly with get, set

    member val options: Google.Maps.Places.AutocompletionRequest option =
        nativeOnly with get, set

    member val sessionToken: bool option = nativeOnly with get, set
    member val language: string option = nativeOnly with get, set

[<AllowNullLiteral>]
type UsePlacesAutocompleteServiceResponse =
    abstract getPlacePredictions:
        (Google.Maps.Places.AutocompletionRequest -> unit) with get, set

    abstract getQueryPredictions:
        (Google.Maps.Places.QueryAutocompletionRequest -> unit) with get, set

    abstract refreshSessionToken: (unit -> unit) with get, set

    abstract placesService: Google.Maps.Places.PlacesService option with get, set

    abstract autocompleteSessionToken:
        Google.Maps.Places.AutocompleteSessionToken option with get, set

    abstract placesAutocompleteService: Google.Maps.Places.AutocompleteService with get, set

    abstract placePredictions:
        ResizeArray<Google.Maps.Places.AutocompletePrediction> with get, set

    abstract isPlacePredictionsLoading: bool with get, set

    abstract queryPredictions:
        ResizeArray<Google.Maps.Places.QueryAutocompletePrediction> with get, set

    abstract isQueryPredictionsLoading: bool with get, set


[<Erase>]
type reactGoogleAutocomplete =

    static member inline inputAutocompleteValue(value: string) =
        Interop.mkAttr "inputAutocompleteValue" value

    static member inline options
        (value: Google.Maps.Places.AutocompleteOptions)
        =
        Interop.mkAttr "options" value

    static member inline onPlaceSelected
        (value:
            Google.Maps.Places.PlaceResult
                -> IRefValue<HTMLInputElement>
                -> IRefValue<Google.Maps.Places.Autocomplete>
                -> unit)
        =
        Interop.mkAttr
            "onPlaceSelected"
            (Func<Google.Maps.Places.PlaceResult, IRefValue<HTMLInputElement>, IRefValue<Google.Maps.Places.Autocomplete>, unit>(
                value
            ))

    static member inline libraries(value: ResizeArray<string>) =
        Interop.mkAttr "libraries" value

    static member inline apiKey(value: string) = Interop.mkAttr "apiKey" value

    static member inline language(value: string) =
        Interop.mkAttr "language" value

    static member inline googleMapsScriptBaseUrl(value: string) =
        Interop.mkAttr "googleMapsScriptBaseUrl" value
