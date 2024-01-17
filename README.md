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
