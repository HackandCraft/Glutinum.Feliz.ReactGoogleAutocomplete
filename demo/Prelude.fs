[<AutoOpen>]
module Prelude

open Fable.Core.JsInterop

let VITE_GOOGLE_MAP_API_KEY: string =
    emitJsExpr () "import.meta.env.VITE_GOOGLE_MAP_API_KEY"
