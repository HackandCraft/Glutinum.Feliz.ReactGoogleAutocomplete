module Demo.RenderProps

open Feliz
open Browser
open Fable.Core.JsInterop
open Glutinum.Feliz.ReactGoogleAutocomplete
open type Glutinum.Feliz.ReactGoogleAutocomplete.Exports
open Fable.Core.JS

[<ReactComponent>]
let private Component () =
    let info =
        usePlacesWidget (
            ReactGoogleAutocompleteProps(
                apiKey = VITE_GOOGLE_MAP_API_KEY,
                onPlaceSelected =
                    fun places _ _ ->
                        console.log places
                        printfn "onPlaceSelected"
            )
        )

    Html.input [
        prop.ref info.ref
    ]

let root = document.getElementById ("root") |> ReactDOM.createRoot

root.render (Component())
