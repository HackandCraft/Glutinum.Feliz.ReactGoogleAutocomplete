// ts2fable 0.9.0
module rec Google.Maps

#nowarn "3390" // disable warnings for invalid XML comments
#nowarn "0044" // disable warnings for `Obsolete` usage

open System
open Fable.Core
open Fable.Core.JS
open Browser.Types


[<AllowNullLiteral>]
type AutocompletePrediction =
    /// This is the unformatted version of the query suggested by the Places
    /// service.
    abstract description: string with get, set
    /// <summary>The distance in meters of the place from the <see cref="*">google.maps.places.AutocompletionRequest.origin</see>.</summary>
    abstract distance_meters: float option with get, set
    /// A set of substrings in the place&#39;s description that match elements in
    /// the user&#39;s input, suitable for use in highlighting those substrings.
    /// Each substring is identified by an offset and a length, expressed in
    /// unicode characters.
    abstract matched_substrings: ResizeArray<Places.PredictionSubstring> with get, set
    /// <summary>
    /// A place ID that can be used to retrieve details about this place using
    /// the place details service (see <see cref="*">google.maps.places.PlacesService.getDetails</see>).
    /// </summary>
    abstract place_id: string with get, set
    /// Structured information about the place&#39;s description, divided into a
    /// main text and a secondary text, including an array of matched substrings
    /// from the autocomplete input, identified by an offset and a length,
    /// expressed in unicode characters.
    abstract structured_formatting: Places.StructuredFormatting with get, set
    /// Information about individual terms in the above description, from most to
    /// least specific. For example, "Taco Bell", "Willitis",
    /// and "CA".
    abstract terms: ResizeArray<Places.PredictionTerm> with get, set
    /// An array of types that the prediction belongs to, for example
    /// <code>'establishment'</code> or <code>'geocode'</code>.
    abstract types: ResizeArray<string> with get, set

module Places =

    /// Represents a prediction substring.
    [<AllowNullLiteral>]
    type PredictionSubstring =
        /// The length of the substring.
        abstract length: float with get, set
        /// The offset to the substring&#39;s start within the description string.
        abstract offset: float with get, set

    /// Contains structured information about the place&#39;s description, divided
    /// into a main text and a secondary text, including an array of matched
    /// substrings from the autocomplete input, identified by an offset and a
    /// length, expressed in unicode characters.
    [<AllowNullLiteral>]
    type StructuredFormatting =
        /// This is the main text part of the unformatted description of the place
        /// suggested by the Places service. Usually the name of the place.
        abstract main_text: string with get, set

        /// A set of substrings in the main text that match elements in the
        /// user&#39;s input, suitable for use in highlighting those substrings. Each
        /// substring is identified by an offset and a length, expressed in unicode
        /// characters.
        abstract main_text_matched_substrings:
            ResizeArray<Places.PredictionSubstring> with get, set

        /// This is the secondary text part of the unformatted description of the
        /// place suggested by the Places service. Usually the location of the place.
        abstract secondary_text: string with get, set

    /// Represents a prediction term.
    [<AllowNullLiteral>]
    type PredictionTerm =
        /// The offset, in unicode characters, of the start of this term in the
        /// description of the place.
        abstract offset: float with get, set
        /// The value of this term, for example, &quot;Taco Bell&quot;.
        abstract value: string with get, set
