# Glutinum.Feliz.ReactGoogleAutocomplete

Binding for [react-google-autocomplete](https://github.com/thebuilder/react-google-autocomplete)

[![NuGet](https://img.shields.io/nuget/v/Glutinum.Feliz.ReactGoogleAutocomplete.svg)](https://www.nuget.org/packages/Glutinum.Feliz.ReactGoogleAutocomplete/)

## Development

In order to run the demo project, you need to set the env variable `VITE_GOOGLE_MAP_API_KEY` to your Google Maps API key.

## Usage

### Components

```fs
open Feliz
open Glutinum.Feliz.ReactGoogleAutocomplete
open type Glutinum.Feliz.ReactGoogleAutocomplete.Exports

[<ReactComponent>]
let private Component () =
    ReactGoogleAutocomplete [
        reactGoogleAutocomplete.apiKey VITE_GOOGLE_MAP_API_KEY
        reactGoogleAutocomplete.onPlaceSelected (fun places _ _ ->
            printfn "onPlaceSelected"
        )
    ]
```

### Hooks

```fs
open Feliz
open Glutinum.Feliz.ReactGoogleAutocomplete
open type Glutinum.Feliz.ReactGoogleAutocomplete.Exports

[<ReactComponent>]
let private Component () =
    let info = usePlacesWidget(ReactGoogleAutocompleteProps(
        apiKey = VITE_GOOGLE_MAP_API_KEY,
        onPlaceSelected = fun places _ _ ->
            printfn "onPlaceSelected"
    ))

    Html.input [
        prop.ref info.ref
    ]
```

### Service Hook

```fs
open Feliz
open Browser
open Glutinum.Feliz.ReactGoogleAutocomplete
open type Glutinum.Feliz.ReactGoogleAutocomplete.Exports

[<ReactComponent>]
let private Component () =
    let (placeDetailResult, setPlaceDetailResult) =
        React.useState (fun () -> None)

    let (placePredictions, setPlacePredictions) =
        React.useState (fun () ->
            ResizeArray<Google.Maps.Places.AutocompletePrediction>()
        )

    let response =
        usePlacesAutocompleteService (
            UsePlacesAutocompleteServiceConfig(
                apiKey = VITE_GOOGLE_MAP_API_KEY,
                debounce = 500
            )
        )

    React.useEffect (
        fun () -> setPlacePredictions response.placePredictions
        , [|
            box response.placePredictions
        |]
    )

    let handleOnChange (input: string) =
        setPlaceDetailResult None
        let request = Google.Maps.Places.AutocompletionRequest(input = input)
        response.getPlacePredictions request

    let getDetails (placeId: string) =
        match response.placesService with
        | Some service ->
            service.getDetails (
                Google.Maps.Places.PlaceDetailsRequest(placeId = placeId),
                fun (place: Google.Maps.Places.PlaceResult option) (status) ->
                    setPlaceDetailResult place
            )
            |> ignore
        | None -> ()


    Html.div [
        Html.input [
            prop.type' "text"
            prop.onChange handleOnChange
        ]

        if placePredictions.Count > 0 && placeDetailResult.IsNone then
            Html.ul (
                response.placePredictions
                |> Seq.map (fun prediction ->
                    Html.li [
                        Html.a [
                            prop.text prediction.description
                            prop.onClick (fun _ ->
                                getDetails prediction.place_id
                            )
                        ]
                    ]
                )
            )

        match placeDetailResult with
        | Some place ->
            Html.h1 [
                match place.name with
                | Some name -> Html.text name
                | None -> ()
            ]

            Html.div [
                match place.formatted_address with
                | Some address -> Html.text address
                | None -> ()
            ]
        | None -> ()
    ]
```
