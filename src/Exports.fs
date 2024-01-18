namespace Glutinum.Feliz.ReactGoogleAutocomplete

open Feliz
open Fable.Core
open Fable.Core.JsInterop

[<Erase>]
type Exports =

    [<Hook; Import("usePlacesWidget", "react-google-autocomplete")>]
    static member usePlacesWidget<'T>
        (_props: ReactGoogleAutocompleteProps)
        : {|
              ref: IRefValue<'T>
              autocompleteRef: IRefValue<obj>
          |}
        // autocompleteRef: IRefValue<Google.Maps.Places.Autocomplete>
        =
        nativeOnly

    [<Hook;
      Import("default",
             "react-google-autocomplete/lib/usePlacesAutocompleteService")>]
    static member usePlacesAutocompleteService
        (options: UsePlacesAutocompleteServiceConfig)
        : UsePlacesAutocompleteServiceResponse
        =
        nativeOnly

    static member inline ReactGoogleAutocomplete
        (properties: #IReactProperty list)
        =
        Interop.reactApi.createElement (
            import "default" "react-google-autocomplete",
            createObj !!properties
        )
