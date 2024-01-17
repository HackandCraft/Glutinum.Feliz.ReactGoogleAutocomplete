module Demo.ServiceHook

open Feliz
open Browser
open Fable.Core.JsInterop
open Glutinum.Feliz.ReactGoogleAutocomplete
open type Glutinum.Feliz.ReactGoogleAutocomplete.Exports
open Fable.Core.JS

[<ReactComponent>]
let private Component () =
    let response =
        usePlacesAutocompleteService (
            UsePlacesAutocompleteServiceConfig(
                apiKey = VITE_GOOGLE_MAP_API_KEY,
                debounce = 300
            )
        )

    let handleOnChange =
        fun (e: Types.Event) ->
            let target = e.target
            let input = target?value

            response.getPlacePredictions (
                {|
                    input = input
                |}
            )

    Html.div [
        prop.children [
            Html.input [
                prop.type' "text"
                prop.onChange handleOnChange
            ]
            match response.placePredictions with
            | Some predictions ->
                console.log predictions
                Html.ul [
                    prop.children (
                        predictions
                        |> Seq.map (fun prediction ->
                            Html.li [
                                prop.children [
                                    Html.a [
                                        prop.children [
                                            Html.text (sprintf "%A" prediction)
                                        ]
                                    ]
                                ]
                            ]
                        )
                    )
                ]
            | None -> Html.text "No predictions"
        ]
    ]

let root = document.getElementById ("root") |> ReactDOM.createRoot

root.render (Component())
