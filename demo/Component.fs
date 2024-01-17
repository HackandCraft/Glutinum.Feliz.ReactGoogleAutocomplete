module Demo.PlainChild

open Feliz
open Browser
open Glutinum.Feliz.ReactGoogleAutocomplete
open type Glutinum.Feliz.ReactGoogleAutocomplete.Exports
open Fable.Core.JS

[<ReactComponent>]
let private Component () =
    ReactGoogleAutocomplete [
        reactGoogleAutocomplete.apiKey VITE_GOOGLE_MAP_API_KEY
        reactGoogleAutocomplete.onPlaceSelected (fun places _ _ ->
            console.log places
            printfn "onPlaceSelected"
        )
    ]

let root = document.getElementById ("root") |> ReactDOM.createRoot

root.render (Component())
