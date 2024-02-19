// ts2fable 0.9.0
module rec Google.Maps

#nowarn "3390" // disable warnings for invalid XML comments
#nowarn "0044" // disable warnings for `Obsolete` usage

open System
open Fable.Core
open Fable.Core.JS
open Browser.Types

type Array<'T> = System.Collections.Generic.IList<'T>
type Error = System.Exception
type Function = System.Action



let [<Import("maps","module/google")>] maps: Maps.IExports = jsNative

/// <summary>
/// A layer for displaying geospatial data. Points, line-strings and polygons
/// can be displayed. &lt;p&gt; Every &lt;code&gt;Map&lt;/code&gt; has a &lt;code&gt;Data&lt;/code&gt; object
/// by default, so most of the time there is no need to construct one. For
/// example: &lt;pre&gt; var myMap = new google.maps.Map(...);&lt;br&gt;
/// myMap.data.addGeoJson(...);&lt;br&gt; myMap.data.setStyle(...); &lt;/pre&gt; The
/// &lt;code&gt;Data&lt;/code&gt; object is a collection of &lt;a
/// href="#Data.Feature"&gt;&lt;code&gt;Features&lt;/code&gt;&lt;/a&gt;.
///
/// Access by calling <c>const {Data} = await google.maps.importLibrary("maps")</c>.
/// See <see href="https://developers.google.com/maps/documentation/javascript/libraries." />
/// </summary>
let [<Import("Data","module/google/maps")>] data: Data.IExports = jsNative
let [<Import("drawing","module/google/maps")>] drawing: Drawing.IExports = jsNative
let [<Import("journeySharing","module/google/maps")>] journeySharing: JourneySharing.IExports = jsNative
let [<Import("localContext","module/google/maps")>] localContext: LocalContext.IExports = jsNative
let [<Import("marker","module/google/maps")>] marker: Marker.IExports = jsNative
let [<Import("places","module/google/maps")>] places: Places.IExports = jsNative
let [<Import("visualization","module/google/maps")>] visualization: Visualization.IExports = jsNative

type [<AllowNullLiteral>] IExports =
    /// <summary>
    /// A layer showing bike lanes and paths.
    ///
    /// Access by calling `const {BicyclingLayer} = await
    /// google.maps.importLibrary("maps")`. See
    /// <see href="https://developers.google.com/maps/documentation/javascript/libraries." />
    /// </summary>
    abstract BicyclingLayer: BicyclingLayerStatic
    /// <summary>
    /// A circle on the Earth&amp;#39;s surface; also known as a &amp;quot;spherical
    /// cap&amp;quot;.
    ///
    /// Access by calling `const {Circle} = await
    /// google.maps.importLibrary("maps")`. See
    /// <see href="https://developers.google.com/maps/documentation/javascript/libraries." />
    /// </summary>
    abstract Circle: CircleStatic
    /// <summary>
    /// A layer for displaying geospatial data. Points, line-strings and polygons
    /// can be displayed. &lt;p&gt; Every &lt;code&gt;Map&lt;/code&gt; has a &lt;code&gt;Data&lt;/code&gt; object
    /// by default, so most of the time there is no need to construct one. For
    /// example: &lt;pre&gt; var myMap = new google.maps.Map(...);&lt;br&gt;
    /// myMap.data.addGeoJson(...);&lt;br&gt; myMap.data.setStyle(...); &lt;/pre&gt; The
    /// &lt;code&gt;Data&lt;/code&gt; object is a collection of &lt;a
    /// href="#Data.Feature"&gt;&lt;code&gt;Features&lt;/code&gt;&lt;/a&gt;.
    ///
    /// Access by calling <c>const {Data} = await google.maps.importLibrary("maps")</c>.
    /// See <see href="https://developers.google.com/maps/documentation/javascript/libraries." />
    /// </summary>
    abstract Data: DataStatic
    /// <summary>
    /// Renders directions obtained from the &lt;code&gt;&lt;a
    /// href="#DirectionsService"&gt;DirectionsService&lt;/a&gt;&lt;/code&gt;.
    ///
    /// Access by calling `const {DirectionsRenderer} = await
    /// google.maps.importLibrary("routes")`. See
    /// <see href="https://developers.google.com/maps/documentation/javascript/libraries." />
    /// </summary>
    abstract DirectionsRenderer: DirectionsRendererStatic
    /// <summary>
    /// A service for computing directions between two or more places.
    ///
    /// Access by calling `const {DirectionsService} = await
    /// google.maps.importLibrary("routes")`. See
    /// <see href="https://developers.google.com/maps/documentation/javascript/libraries." />
    /// </summary>
    abstract DirectionsService: DirectionsServiceStatic
    /// <summary>
    /// A service for computing distances between multiple origins and
    /// destinations.
    ///
    /// Access by calling `const {DistanceMatrixService} = await
    /// google.maps.importLibrary("routes")`. See
    /// <see href="https://developers.google.com/maps/documentation/javascript/libraries." />
    /// </summary>
    abstract DistanceMatrixService: DistanceMatrixServiceStatic
    /// <summary>
    /// Defines a service class that talks directly to Google servers for
    /// requesting elevation data.
    ///
    /// Access by calling `const {ElevationService} = await
    /// google.maps.importLibrary("elevation")`. See
    /// <see href="https://developers.google.com/maps/documentation/javascript/libraries." />
    /// </summary>
    abstract ElevationService: ElevationServiceStatic
    /// <summary>
    /// A service for converting between an address and a &lt;code&gt;LatLng&lt;/code&gt;.
    ///
    /// Access by calling `const {Geocoder} = await
    /// google.maps.importLibrary("geocoding")`. See
    /// <see href="https://developers.google.com/maps/documentation/javascript/libraries." />
    /// </summary>
    abstract Geocoder: GeocoderStatic
    /// <summary>
    /// A rectangular image overlay on the map.
    ///
    /// Access by calling `const {GroundOverlay} = await
    /// google.maps.importLibrary("maps")`. See
    /// <see href="https://developers.google.com/maps/documentation/javascript/libraries." />
    /// </summary>
    abstract GroundOverlay: GroundOverlayStatic
    /// <summary>
    /// This class implements the MapType interface and is provided for rendering
    /// image tiles.
    ///
    /// Access by calling `const {ImageMapType} = await
    /// google.maps.importLibrary("maps")`. See
    /// <see href="https://developers.google.com/maps/documentation/javascript/libraries." />
    /// </summary>
    abstract ImageMapType: ImageMapTypeStatic
    /// <summary>
    /// An overlay that looks like a bubble and is often connected to a marker.
    ///
    /// Access by calling `const {InfoWindow} = await
    /// google.maps.importLibrary("maps")<c> or </c>const {InfoWindow} = await
    /// google.maps.importLibrary("streetView")`. See
    /// <see href="https://developers.google.com/maps/documentation/javascript/libraries." />
    /// </summary>
    abstract InfoWindow: InfoWindowStatic
    /// <summary>
    /// A &lt;code&gt;KmlLayer&lt;/code&gt; adds geographic markup to the map from a KML, KMZ
    /// or GeoRSS file that is hosted on a publicly accessible web server. A
    /// &lt;code&gt;KmlFeatureData&lt;/code&gt; object is provided for each feature when
    /// clicked.
    ///
    /// Access by calling `const {KmlLayer} = await
    /// google.maps.importLibrary("maps")`. See
    /// <see href="https://developers.google.com/maps/documentation/javascript/libraries." />
    /// </summary>
    abstract KmlLayer: KmlLayerStatic
    /// <summary>
    /// A &lt;code&gt;LatLng&lt;/code&gt; is a point in geographical coordinates: latitude and
    /// longitude.&lt;br&gt; &lt;ul&gt; &lt;li&gt;Latitude ranges between -90 and 90 degrees,
    /// inclusive. Values above or below this range will be clamped to the range
    /// [-90, 90]. This means that if the value specified is less than -90, it will
    /// be set to -90. And if the value is greater than 90, it will be set
    /// to 90.&lt;/li&gt; &lt;li&gt;Longitude ranges between -180 and 180 degrees, inclusive.
    /// Values above or below this range will be wrapped so that they fall within
    /// the range. For example, a value of -190 will be converted to 170. A value
    /// of 190 will be converted to -170. This reflects the fact that longitudes
    /// wrap around the globe.&lt;/li&gt; &lt;/ul&gt; Although the default map projection
    /// associates longitude with the x-coordinate of the map, and latitude with
    /// the y-coordinate, the latitude coordinate is always written &lt;em&gt;first&lt;/em&gt;,
    /// followed by the longitude.&lt;br&gt; Notice that you cannot modify the
    /// coordinates of a &lt;code&gt;LatLng&lt;/code&gt;. If you want to compute another point,
    /// you have to create a new one.&lt;br&gt; &lt;p&gt; Most methods that accept
    /// &lt;code&gt;LatLng&lt;/code&gt; objects also accept a <see cref="google.maps.LatLngLiteral" />
    /// object, so that the following are equivalent: &lt;pre&gt; map.setCenter(new
    /// google.maps.LatLng(-34, 151));&lt;br&gt; map.setCenter({lat: -34, lng: 151});
    /// &lt;/pre&gt; &lt;p&gt; The constructor also accepts <see cref="google.maps.LatLngLiteral" />
    /// and &lt;code&gt;LatLng&lt;/code&gt; objects. If a &lt;code&gt;LatLng&lt;/code&gt; instance is
    /// passed to the constructor, a copy is created. &lt;p&gt; The possible calls to the
    /// constructor are below: &lt;pre&gt; new google.maps.LatLng(-34, 151);&lt;br&gt; new
    /// google.maps.LatLng(-34, 151, true);&lt;br&gt; new google.maps.LatLng({lat: -34,
    /// lng: 151});&lt;br&gt; new google.maps.LatLng({lat: -34, lng: 151}, true);&lt;br&gt; new
    /// google.maps.LatLng(new google.maps.LatLng(-34, 151));&lt;br&gt; new
    /// google.maps.LatLng(new google.maps.LatLng(-34, 151), true);&lt;br&gt; &lt;/pre&gt;
    ///
    /// Access by calling `const {LatLng} = await
    /// google.maps.importLibrary("core")`. See
    /// <see href="https://developers.google.com/maps/documentation/javascript/libraries." />
    /// </summary>
    abstract LatLng: LatLngStatic
    /// <summary>
    /// A &lt;code&gt;LatLngAltitude&lt;/code&gt; is a 3D point in geographical coordinates:
    /// latitude, longitude, and altitude.&lt;br&gt; &lt;ul&gt; &lt;li&gt;Latitude ranges between -90
    /// and 90 degrees, inclusive. Values above or below this range will be clamped
    /// to the range [-90, 90]. This means that if the value specified is less than
    /// -90, it will be set to -90. And if the value is greater than 90, it will be
    /// set to 90.&lt;/li&gt; &lt;li&gt;Longitude ranges between -180 and 180 degrees,
    /// inclusive. Values above or below this range will be wrapped so that they
    /// fall within the range. For example, a value of -190 will be converted to
    /// 170. A value of 190 will be converted to -170. This reflects the fact that
    /// longitudes wrap around the globe.&lt;/li&gt; &lt;li&gt;Altitude is measured in meters.
    /// Positive values denote heights above ground level, and negative values
    /// denote heights underneath the ground surface.&lt;/li&gt; &lt;/ul&gt;
    ///
    /// Access by calling `const {LatLngAltitude} = await
    /// google.maps.importLibrary("core")`. See
    /// <see href="https://developers.google.com/maps/documentation/javascript/libraries." />
    /// </summary>
    abstract LatLngAltitude: LatLngAltitudeStatic
    /// <summary>
    /// A &lt;code&gt;&lt;a href="#LatLngBounds"&gt;LatLngBounds&lt;/a&gt;&lt;/code&gt; instance represents
    /// a rectangle in geographical coordinates, including one that crosses the 180
    /// degrees longitudinal meridian.
    ///
    /// Access by calling `const {LatLngBounds} = await
    /// google.maps.importLibrary("core")`. See
    /// <see href="https://developers.google.com/maps/documentation/javascript/libraries." />
    /// </summary>
    abstract LatLngBounds: LatLngBoundsStatic
    /// <summary>
    /// Access by calling `const {MVCArray} = await
    /// google.maps.importLibrary("core")`. See
    /// <see href="https://developers.google.com/maps/documentation/javascript/libraries." />
    /// </summary>
    abstract MVCArray: MVCArrayStatic
    /// <summary>
    /// Base class implementing KVO. &lt;br&gt;&lt;br&gt;The &lt;code&gt;MVCObject&lt;/code&gt; constructor
    /// is guaranteed to be an empty function, and so you may inherit from
    /// &lt;code&gt;MVCObject&lt;/code&gt; by writing &lt;code&gt;MySubclass.prototype = new
    /// google.maps.MVCObject();&lt;/code&gt;. Unless otherwise noted, this is not true
    /// of other classes in the API, and inheriting from other classes in the API
    /// is not supported.
    ///
    /// Access by calling `const {MVCObject} = await
    /// google.maps.importLibrary("core")`. See
    /// <see href="https://developers.google.com/maps/documentation/javascript/libraries." />
    /// </summary>
    abstract MVCObject: MVCObjectStatic
    /// <summary>
    /// Access by calling <c>const {Map} = await google.maps.importLibrary("maps")</c>.
    /// See <see href="https://developers.google.com/maps/documentation/javascript/libraries." />
    /// </summary>
    abstract Map: MapStatic
    /// <summary>
    /// Available only in the v=beta channel: <see href="https://goo.gle/3oAthT3." />
    ///
    /// MapElement is an &lt;code&gt;HTMLElement&lt;/code&gt; subclass for rendering maps.
    /// After loading the &lt;code&gt;maps&lt;/code&gt; library, a map can be created in HTML.
    /// For example: &lt;pre&gt;&lt;code&gt;&amp;lt;gmp-map
    /// center=&amp;quot;37.4220656,-122.0840897&amp;quot; zoom=&amp;quot;10&amp;quot;
    /// map-id=&amp;quot;DEMO_MAP_ID&amp;quot;&amp;gt;&lt;br&gt;&amp;nbsp;&amp;nbsp;&amp;lt;button
    /// slot=&amp;quot;control-block-start-inline-end&amp;quot;&amp;gt;Custom
    /// Control&amp;lt;/button&amp;gt;&lt;br&gt;&amp;lt;/gmp-map&amp;gt;&lt;/code&gt;&lt;/pre&gt; &lt;br&gt; Internally, it
    /// uses <see cref="google.maps.Map" />, which can be accessed with the
    /// &lt;code&gt;innerMap&lt;/code&gt; property.
    ///
    /// Access by calling `const {MapElement} = await
    /// google.maps.importLibrary("maps")`. See
    /// <see href="https://developers.google.com/maps/documentation/javascript/libraries." />
    /// </summary>
    abstract MapElement: MapElementStatic
    /// <summary>
    /// A registry for MapType instances, keyed by MapType id.
    ///
    /// Access by calling `const {MapTypeRegistry} = await
    /// google.maps.importLibrary("maps")`. See
    /// <see href="https://developers.google.com/maps/documentation/javascript/libraries." />
    /// </summary>
    abstract MapTypeRegistry: MapTypeRegistryStatic
    /// <summary>
    /// Base class for managing network errors in Maps.
    ///
    /// Access by calling `const {MapsNetworkError} = await
    /// google.maps.importLibrary("core")`. See
    /// <see href="https://developers.google.com/maps/documentation/javascript/libraries." />
    /// </summary>
    abstract MapsNetworkError: MapsNetworkErrorStatic
    /// <summary>
    /// Represents a request error from a web service (i.e. the equivalent of a 4xx
    /// code in HTTP).
    ///
    /// Access by calling `const {MapsRequestError} = await
    /// google.maps.importLibrary("core")`. See
    /// <see href="https://developers.google.com/maps/documentation/javascript/libraries." />
    /// </summary>
    abstract MapsRequestError: MapsRequestErrorStatic
    /// <summary>
    /// Represents a server-side error from a web service (i.e. the equivalent of a
    /// 5xx code in HTTP).
    ///
    /// Access by calling `const {MapsServerError} = await
    /// google.maps.importLibrary("core")`. See
    /// <see href="https://developers.google.com/maps/documentation/javascript/libraries." />
    /// </summary>
    abstract MapsServerError: MapsServerErrorStatic
    /// <summary>
    /// Access by calling `const {Marker} = await
    /// google.maps.importLibrary("marker")`. See
    /// <see href="https://developers.google.com/maps/documentation/javascript/libraries." />
    /// </summary>
    abstract Marker: MarkerStatic
    /// <summary>
    /// A service for obtaining the highest zoom level at which satellite imagery
    /// is available for a given location.
    ///
    /// Access by calling `const {MaxZoomService} = await
    /// google.maps.importLibrary("maps")`. See
    /// <see href="https://developers.google.com/maps/documentation/javascript/libraries." />
    /// </summary>
    abstract MaxZoomService: MaxZoomServiceStatic
    /// <summary>
    /// You can implement this class if you want to display custom types of overlay
    /// objects on the map. &lt;br&gt;&lt;br&gt;Inherit from this class by setting your
    /// overlay&amp;#39;s prototype: &lt;code&gt;MyOverlay.prototype = new
    /// google.maps.OverlayView();&lt;/code&gt;. The &lt;code&gt;OverlayView&lt;/code&gt; constructor
    /// is guaranteed to be an empty function. &lt;br&gt;&lt;br&gt;You must implement three
    /// methods: &lt;code&gt;onAdd()&lt;/code&gt;, &lt;code&gt;draw()&lt;/code&gt;, and
    /// &lt;code&gt;onRemove()&lt;/code&gt;. &lt;ul&gt; &lt;li&gt;In the &lt;code&gt;onAdd()&lt;/code&gt; method, you
    /// should create DOM objects and append them as children of the panes.&lt;/li&gt;
    /// &lt;li&gt;In the &lt;code&gt;draw()&lt;/code&gt; method, you should position these
    /// elements.&lt;/li&gt; &lt;li&gt;In the &lt;code&gt;onRemove()&lt;/code&gt; method, you should remove
    /// the objects from the DOM.&lt;/li&gt; &lt;/ul&gt; You must call &lt;code&gt;setMap()&lt;/code&gt;
    /// with a valid &lt;code&gt;Map&lt;/code&gt; object to trigger the call to the
    /// &lt;code&gt;onAdd()&lt;/code&gt; method and &lt;code&gt;setMap(null)&lt;/code&gt; in order to
    /// trigger the &lt;code&gt;onRemove()&lt;/code&gt; method. The &lt;code&gt;setMap()&lt;/code&gt;
    /// method can be called at the time of construction or at any point afterward
    /// when the overlay should be re-shown after removing. The &lt;code&gt;draw()&lt;/code&gt;
    /// method will then be called whenever a map property changes that could
    /// change the position of the element, such as zoom, center, or map type.
    ///
    /// Access by calling `const {OverlayView} = await
    /// google.maps.importLibrary("maps")<c> or </c>const {OverlayView} = await
    /// google.maps.importLibrary("streetView")`. See
    /// <see href="https://developers.google.com/maps/documentation/javascript/libraries." />
    /// </summary>
    abstract OverlayView: OverlayViewStatic
    /// <summary>
    /// Access by calling `const {Point} = await
    /// google.maps.importLibrary("core")`. See
    /// <see href="https://developers.google.com/maps/documentation/javascript/libraries." />
    /// </summary>
    abstract Point: PointStatic
    /// <summary>
    /// A polygon (like a polyline) defines a series of connected coordinates in an
    /// ordered sequence. Additionally, polygons form a closed loop and define a
    /// filled region. See the samples in the developer&amp;#39;s guide, starting with
    /// a &lt;a
    /// href="<see href="https://developers.google.com/maps/documentation/javascript/examples/polygon-simple"&gt;simple" />
    /// polygon&lt;/a&gt;, a &lt;a
    /// href="<see href="https://developers.google.com/maps/documentation/javascript/examples/polygon-hole"&gt;polygon" />
    /// with a hole&lt;/a&gt;, and more. Note that you can also use the &lt;a
    /// href="#Data.Polygon"&gt;Data layer&lt;/a&gt; to create a polygon. The Data layer
    /// offers a simpler way of creating holes because it handles the order of the
    /// inner and outer paths for you.
    ///
    /// Access by calling `const {Polygon} = await
    /// google.maps.importLibrary("maps")`. See
    /// <see href="https://developers.google.com/maps/documentation/javascript/libraries." />
    /// </summary>
    abstract Polygon: PolygonStatic
    /// <summary>
    /// A polyline is a linear overlay of connected line segments on the map.
    ///
    /// Access by calling `const {Polyline} = await
    /// google.maps.importLibrary("maps")`. See
    /// <see href="https://developers.google.com/maps/documentation/javascript/libraries." />
    /// </summary>
    abstract Polyline: PolylineStatic
    /// <summary>
    /// A rectangle overlay.
    ///
    /// Access by calling `const {Rectangle} = await
    /// google.maps.importLibrary("maps")`. See
    /// <see href="https://developers.google.com/maps/documentation/javascript/libraries." />
    /// </summary>
    abstract Rectangle: RectangleStatic
    /// <summary>
    /// Available only in the v=beta channel: <see href="https://goo.gle/3oAthT3." />
    ///
    /// Settings which control the behavior of the Maps JavaScript API as a whole.
    ///
    /// Access by calling `const {Settings} = await
    /// google.maps.importLibrary("core")`. See
    /// <see href="https://developers.google.com/maps/documentation/javascript/libraries." />
    /// </summary>
    abstract Settings: SettingsStatic
    /// <summary>
    /// Access by calling <c>const {Size} = await google.maps.importLibrary("core")</c>.
    /// See <see href="https://developers.google.com/maps/documentation/javascript/libraries." />
    /// </summary>
    abstract Size: SizeStatic
    /// <summary>
    /// A layer that illustrates the locations where Street View is available.
    ///
    /// Access by calling `const {StreetViewCoverageLayer} = await
    /// google.maps.importLibrary("streetView")`. See
    /// <see href="https://developers.google.com/maps/documentation/javascript/libraries." />
    /// </summary>
    abstract StreetViewCoverageLayer: StreetViewCoverageLayerStatic
    /// <summary>
    /// Displays the panorama for a given &lt;code&gt;LatLng&lt;/code&gt; or panorama ID. A
    /// &lt;code&gt;StreetViewPanorama&lt;/code&gt; object provides a Street View
    /// &amp;quot;viewer&amp;quot; which can be stand-alone within a separate
    /// &lt;code&gt;&amp;lt;div&amp;gt;&lt;/code&gt; or bound to a &lt;code&gt;Map&lt;/code&gt;.
    ///
    /// Access by calling `const {StreetViewPanorama} = await
    /// google.maps.importLibrary("streetView")`. See
    /// <see href="https://developers.google.com/maps/documentation/javascript/libraries." />
    /// </summary>
    abstract StreetViewPanorama: StreetViewPanoramaStatic
    /// <summary>
    /// A &lt;code&gt;StreetViewService&lt;/code&gt; object performs searches for Street View
    /// data.
    ///
    /// Access by calling `const {StreetViewService} = await
    /// google.maps.importLibrary("streetView")`. See
    /// <see href="https://developers.google.com/maps/documentation/javascript/libraries." />
    /// </summary>
    abstract StreetViewService: StreetViewServiceStatic
    /// <summary>
    /// Creates a &lt;code&gt;MapType&lt;/code&gt; with a custom style.
    ///
    /// Access by calling `const {StyledMapType} = await
    /// google.maps.importLibrary("maps")`. See
    /// <see href="https://developers.google.com/maps/documentation/javascript/libraries." />
    /// </summary>
    abstract StyledMapType: StyledMapTypeStatic
    /// <summary>
    /// A traffic layer.
    ///
    /// Access by calling `const {TrafficLayer} = await
    /// google.maps.importLibrary("maps")`. See
    /// <see href="https://developers.google.com/maps/documentation/javascript/libraries." />
    /// </summary>
    abstract TrafficLayer: TrafficLayerStatic
    /// <summary>
    /// A transit layer.
    ///
    /// Access by calling `const {TransitLayer} = await
    /// google.maps.importLibrary("maps")`. See
    /// <see href="https://developers.google.com/maps/documentation/javascript/libraries." />
    /// </summary>
    abstract TransitLayer: TransitLayerStatic
    /// <summary>
    /// The WebGL Overlay View provides direct access to the same WebGL rendering
    /// context Google Maps Platform uses to render the vector basemap. This use of
    /// a shared rendering context provides benefits such as depth occlusion with
    /// 3D building geometry, and the ability to sync 2D/3D content with basemap
    /// rendering. &lt;br&gt;&lt;br&gt;With WebGL Overlay View you can add content to your maps
    /// using WebGL directly, or popular Graphics libraries like Three.js or
    /// deck.gl. To use the overlay, you can extend
    /// &lt;code&gt;google.maps.WebGLOverlayView&lt;/code&gt; and provide an implementation for
    /// each of the following lifecycle hooks: <see cref="*">google.maps.WebGLOverlayView.onAdd</see>, <see cref="*">google.maps.WebGLOverlayView.onContextRestored</see>, <see cref="*">google.maps.WebGLOverlayView.onDraw</see>, <see cref="*">google.maps.WebGLOverlayView.onContextLost</see> and <see cref="*">google.maps.WebGLOverlayView.onRemove</see>. &lt;br&gt;&lt;br&gt;You must call <see cref="*">google.maps.WebGLOverlayView.setMap</see> with a valid <see cref="google.maps.Map" />
    /// object to trigger the call to the &lt;code&gt;onAdd()&lt;/code&gt; method and
    /// &lt;code&gt;setMap(null)&lt;/code&gt; in order to trigger the &lt;code&gt;onRemove()&lt;/code&gt;
    /// method. The &lt;code&gt;setMap()&lt;/code&gt; method can be called at the time of
    /// construction or at any point afterward when the overlay should be re-shown
    /// after removing. The &lt;code&gt;onDraw()&lt;/code&gt; method will then be called
    /// whenever a map property changes that could change the position of the
    /// element, such as zoom, center, or map type. WebGLOverlayView may only be
    /// added to a vector map having a <see cref="google.maps.MapOptions.mapId" />.
    ///
    /// Access by calling `const {WebGLOverlayView} = await
    /// google.maps.importLibrary("maps")`. See
    /// <see href="https://developers.google.com/maps/documentation/javascript/libraries." />
    /// </summary>
    abstract WebGLOverlayView: WebGLOverlayViewStatic
    /// <summary>
    /// Available only in the v=beta channel: <see href="https://goo.gle/3oAthT3." />
    ///
    /// This event is created from monitoring zoom change.
    ///
    /// Access by calling `const {ZoomChangeEvent} = await
    /// google.maps.importLibrary("maps")`. See
    /// <see href="https://developers.google.com/maps/documentation/javascript/libraries." />
    /// </summary>
    abstract ZoomChangeEvent: ZoomChangeEventStatic
    /// <summary>
    /// Namespace for all public event functions
    ///
    /// Access by calling `const {event} = await
    /// google.maps.importLibrary("core")`. See
    /// <see href="https://developers.google.com/maps/documentation/javascript/libraries." />
    /// </summary>
    abstract ``event``: eventStatic
    /// <summary>
    /// Loads a &lt;a
    /// href="<see href="https://developers.google.com/maps/documentation/javascript/libraries"/>
    /// of the Maps JavaScript API, resolving with the direct members of that API
    /// (without namespacing). (When loaded, libraries also add themselves to the
    /// global &lt;code&gt;google.maps&lt;/code&gt; namespace, though using the global
    /// namespace is not generally recommended.)
    /// </summary>
    abstract importLibrary: libraryName: string -> Promise<obj>
    /// <summary>
    /// Google Maps JavaScript API version loaded by the browser. See &lt;a
    /// href="<see href="https://developers.google.com/maps/documentation/javascript/versions"/>
    /// </summary>
    abstract version: string with get, set

/// <summary>
/// Animations that can be played on a marker. Use the <see cref="*">google.maps.Marker.setAnimation</see> method on Marker or the <see cref="*">google.maps.MarkerOptions.animation</see> option to play an animation.
///
/// Access by calling `const {Animation} = await
/// google.maps.importLibrary("marker")`. See
/// <see href="https://developers.google.com/maps/documentation/javascript/libraries." />
/// </summary>
type [<RequireQualifiedAccess>] Animation =
    /// <summary>Marker bounces until animation is stopped by calling <see cref="*">google.maps.Marker.setAnimation</see> with &lt;code&gt;null&lt;/code&gt;.</summary>
    | BOUNCE = 0
    /// <summary>
    /// Marker drops from the top of the map to its final location. Animation
    /// will cease once the marker comes to rest and <see cref="*">google.maps.Marker.getAnimation</see> will return &lt;code&gt;null&lt;/code&gt;. This type
    /// of animation is usually specified during creation of the marker.
    /// </summary>
    | DROP = 1

/// <summary>
/// A layer showing bike lanes and paths.
///
/// Access by calling `const {BicyclingLayer} = await
/// google.maps.importLibrary("maps")`. See
/// <see href="https://developers.google.com/maps/documentation/javascript/libraries." />
/// </summary>
type [<AllowNullLiteral>] BicyclingLayer =
    inherit Google.Maps.MVCObject
    /// Returns the map on which this layer is displayed.
    abstract getMap: unit -> Google.Maps.Map option
    /// Renders the layer on the specified map. If map is set to
    /// &lt;code&gt;null&lt;/code&gt;, the layer will be removed.
    abstract setMap: map: Google.Maps.Map option -> unit

/// <summary>
/// A layer showing bike lanes and paths.
///
/// Access by calling `const {BicyclingLayer} = await
/// google.maps.importLibrary("maps")`. See
/// <see href="https://developers.google.com/maps/documentation/javascript/libraries." />
/// </summary>
type [<AllowNullLiteral>] BicyclingLayerStatic =
    [<EmitConstructor>] abstract Create: unit -> BicyclingLayer

/// <summary>
/// Available only in the v=beta channel: <see href="https://goo.gle/3oAthT3." />
///
/// Used for setting the map&amp;#39;s camera options.
/// </summary>
type [<AllowNullLiteral>] CameraOptions =
    abstract center: U2<Google.Maps.LatLngLiteral, Google.Maps.LatLng> option with get, set
    abstract heading: float option with get, set
    abstract tilt: float option with get, set
    abstract zoom: float option with get, set

/// <summary>
/// Used for retrieving camera parameters, such as that of the GL camera used
/// for the <see cref="google.maps.WebGLOverlayView" />.
/// </summary>
type [<AllowNullLiteral>] CameraParams =
    inherit Google.Maps.CameraOptions
    abstract center: Google.Maps.LatLng with get, set
    abstract heading: float with get, set
    abstract tilt: float with get, set
    abstract zoom: float with get, set

/// <summary>
/// A circle on the Earth&amp;#39;s surface; also known as a &amp;quot;spherical
/// cap&amp;quot;.
///
/// Access by calling `const {Circle} = await
/// google.maps.importLibrary("maps")`. See
/// <see href="https://developers.google.com/maps/documentation/javascript/libraries." />
/// </summary>
type [<AllowNullLiteral>] Circle =
    inherit Google.Maps.MVCObject
    /// Gets the &lt;code&gt;LatLngBounds&lt;/code&gt; of this Circle.
    abstract getBounds: unit -> Google.Maps.LatLngBounds option
    /// Returns the center of this circle.
    abstract getCenter: unit -> Google.Maps.LatLng option
    /// Returns whether this circle can be dragged by the user.
    abstract getDraggable: unit -> bool
    /// Returns whether this circle can be edited by the user.
    abstract getEditable: unit -> bool
    /// Returns the map on which this circle is displayed.
    abstract getMap: unit -> Google.Maps.Map option
    /// Returns the radius of this circle (in meters).
    abstract getRadius: unit -> float
    /// Returns whether this circle is visible on the map.
    abstract getVisible: unit -> bool
    /// Sets the center of this circle.
    abstract setCenter: center: U2<Google.Maps.LatLng, Google.Maps.LatLngLiteral> option -> unit
    /// If set to &lt;code&gt;true&lt;/code&gt;, the user can drag this circle over the map.
    abstract setDraggable: draggable: bool -> unit
    /// If set to &lt;code&gt;true&lt;/code&gt;, the user can edit this circle by dragging
    /// the control points shown at the center and around the circumference of
    /// the circle.
    abstract setEditable: editable: bool -> unit
    /// Renders the circle on the specified map. If map is set to
    /// &lt;code&gt;null&lt;/code&gt;, the circle will be removed.
    abstract setMap: map: Google.Maps.Map option -> unit
    abstract setOptions: options: Google.Maps.CircleOptions option -> unit
    /// Sets the radius of this circle (in meters).
    abstract setRadius: radius: float -> unit
    /// Hides this circle if set to &lt;code&gt;false&lt;/code&gt;.
    abstract setVisible: visible: bool -> unit

/// <summary>
/// A circle on the Earth&amp;#39;s surface; also known as a &amp;quot;spherical
/// cap&amp;quot;.
///
/// Access by calling `const {Circle} = await
/// google.maps.importLibrary("maps")`. See
/// <see href="https://developers.google.com/maps/documentation/javascript/libraries." />
/// </summary>
type [<AllowNullLiteral>] CircleStatic =
    /// <summary>
    /// A circle on the Earth&amp;#39;s surface; also known as a &amp;quot;spherical
    /// cap&amp;quot;.
    ///
    /// Access by calling `const {Circle} = await
    /// google.maps.importLibrary("maps")`. See
    /// <see href="https://developers.google.com/maps/documentation/javascript/libraries." />
    /// </summary>
    [<EmitConstructor>] abstract Create: ?circleOrCircleOptions: U3<Google.Maps.Circle, Google.Maps.CircleLiteral, Google.Maps.CircleOptions> -> Circle

/// Object literal which represents a circle.
type [<AllowNullLiteral>] CircleLiteral =
    inherit Google.Maps.CircleOptions
    /// The center of the Circle.
    abstract center: U2<Google.Maps.LatLng, Google.Maps.LatLngLiteral> with get, set
    /// The radius in meters on the Earth&#39;s surface.
    abstract radius: float with get, set

/// CircleOptions object used to define the properties that can be set on a
/// Circle.
type [<AllowNullLiteral>] CircleOptions =
    /// The center of the Circle.
    abstract center: U2<Google.Maps.LatLng, Google.Maps.LatLngLiteral> option with get, set
    /// <summary>Indicates whether this &lt;code&gt;Circle&lt;/code&gt; handles mouse events.</summary>
    /// <default>&lt;code&gt;true&lt;/code&gt;</default>
    abstract clickable: bool option with get, set
    /// <summary>If set to &lt;code&gt;true&lt;/code&gt;, the user can drag this circle over the map.</summary>
    /// <default>&lt;code&gt;false&lt;/code&gt;</default>
    abstract draggable: bool option with get, set
    /// <summary>
    /// If set to &lt;code&gt;true&lt;/code&gt;, the user can edit this circle by dragging
    /// the control points shown at the center and around the circumference of
    /// the circle.
    /// </summary>
    /// <default>&lt;code&gt;false&lt;/code&gt;</default>
    abstract editable: bool option with get, set
    /// The fill color. All CSS3 colors are supported except for extended named
    /// colors.
    abstract fillColor: string option with get, set
    /// The fill opacity between 0.0 and 1.0.
    abstract fillOpacity: float option with get, set
    /// Map on which to display the Circle.
    abstract map: Google.Maps.Map option with get, set
    /// The radius in meters on the Earth&#39;s surface.
    abstract radius: float option with get, set
    /// The stroke color. All CSS3 colors are supported except for extended named
    /// colors.
    abstract strokeColor: string option with get, set
    /// The stroke opacity between 0.0 and 1.0.
    abstract strokeOpacity: float option with get, set
    /// <summary>The stroke position.</summary>
    /// <default><see cref="google.maps.StrokePosition.CENTER" /></default>
    abstract strokePosition: Google.Maps.StrokePosition option with get, set
    /// The stroke width in pixels.
    abstract strokeWeight: float option with get, set
    /// <summary>Whether this circle is visible on the map.</summary>
    /// <default>&lt;code&gt;true&lt;/code&gt;</default>
    abstract visible: bool option with get, set
    /// The zIndex compared to other polys.
    abstract zIndex: float option with get, set

/// <summary>
/// Access by calling `const {CollisionBehavior} = await
/// google.maps.importLibrary("marker")`. See
/// <see href="https://developers.google.com/maps/documentation/javascript/libraries." />
/// </summary>
type [<StringEnum>] [<RequireQualifiedAccess>] CollisionBehavior =
    /// Display the marker only if it does not overlap with other markers. If two
    /// markers of this type would overlap, the one with the higher zIndex is
    /// shown. If they have the same zIndex, the one with the lower vertical
    /// screen position is shown.
    | [<CompiledName("OPTIONAL_AND_HIDES_LOWER_PRIORITY")>] OPTIONAL_AND_HIDES_LOWER_PRIORITY
    /// Always display the marker regardless of collision. This is the default
    /// behavior.
    | [<CompiledName("REQUIRED")>] REQUIRED
    /// Always display the marker regardless of collision, and hide any
    /// OPTIONAL_AND_HIDES_LOWER_PRIORITY markers or labels that would overlap
    /// with the marker.
    | [<CompiledName("REQUIRED_AND_HIDES_OPTIONAL")>] REQUIRED_AND_HIDES_OPTIONAL

/// <summary>
/// Identifiers used to specify the placement of controls on the map. Controls
/// are positioned relative to other controls in the same layout position.
/// Controls that are added first are positioned closer to the edge of the map.
/// Usage of &amp;quot;logical values&amp;quot; (see &lt;a
/// href="<see href="https://developer.mozilla.org/en-US/docs/Web/CSS/CSS_logical_properties_and_values"&gt;https://developer.mozilla.org/en-US/docs/Web/CSS/CSS_logical_properties_and_values&lt;/a&gt;)" />
/// is recommended in order to be able to automatically support both
/// left-to-right (LTR) and right-to-left (RTL) layout contexts.&lt;br&gt;
/// &lt;br&gt;Logical values in LTR: &lt;br&gt; &lt;pre&gt;+----------------+
/// &lt;br&gt;|&amp;nbsp;BSIS&amp;nbsp;BSIC&amp;nbsp;BSIE |
/// &lt;br&gt;|&amp;nbsp;ISBS&amp;nbsp;&amp;nbsp;&amp;nbsp;&amp;nbsp;&amp;nbsp;&amp;nbsp;IEBS |
/// &lt;br&gt;|&amp;nbsp;&amp;nbsp;&amp;nbsp;&amp;nbsp;&amp;nbsp;&amp;nbsp;&amp;nbsp;&amp;nbsp;&amp;nbsp;&amp;nbsp;&amp;nbsp;&amp;nbsp;&amp;nbsp;&amp;nbsp;&amp;nbsp;&amp;nbsp;|
/// &lt;br&gt;|&amp;nbsp;ISBC&amp;nbsp;&amp;nbsp;&amp;nbsp;&amp;nbsp;&amp;nbsp;&amp;nbsp;IEBC |
/// &lt;br&gt;|&amp;nbsp;&amp;nbsp;&amp;nbsp;&amp;nbsp;&amp;nbsp;&amp;nbsp;&amp;nbsp;&amp;nbsp;&amp;nbsp;&amp;nbsp;&amp;nbsp;&amp;nbsp;&amp;nbsp;&amp;nbsp;&amp;nbsp;&amp;nbsp;|
/// &lt;br&gt;|&amp;nbsp;ISBE&amp;nbsp;&amp;nbsp;&amp;nbsp;&amp;nbsp;&amp;nbsp;&amp;nbsp;IEBE |
/// &lt;br&gt;|&amp;nbsp;BEIS&amp;nbsp;BEIC&amp;nbsp;BEIE | &lt;br&gt;+----------------+&lt;/pre&gt;&lt;br&gt;
/// Logical values in RTL:&lt;br&gt; &lt;pre&gt;+----------------+
/// &lt;br&gt;|&amp;nbsp;BSIE&amp;nbsp;BSIC&amp;nbsp;BSIS |
/// &lt;br&gt;|&amp;nbsp;IEBS&amp;nbsp;&amp;nbsp;&amp;nbsp;&amp;nbsp;&amp;nbsp;&amp;nbsp;ISBS |
/// &lt;br&gt;|&amp;nbsp;&amp;nbsp;&amp;nbsp;&amp;nbsp;&amp;nbsp;&amp;nbsp;&amp;nbsp;&amp;nbsp;&amp;nbsp;&amp;nbsp;&amp;nbsp;&amp;nbsp;&amp;nbsp;&amp;nbsp;&amp;nbsp;&amp;nbsp;|
/// &lt;br&gt;|&amp;nbsp;IEBC&amp;nbsp;&amp;nbsp;&amp;nbsp;&amp;nbsp;&amp;nbsp;&amp;nbsp;ISBC |
/// &lt;br&gt;|&amp;nbsp;&amp;nbsp;&amp;nbsp;&amp;nbsp;&amp;nbsp;&amp;nbsp;&amp;nbsp;&amp;nbsp;&amp;nbsp;&amp;nbsp;&amp;nbsp;&amp;nbsp;&amp;nbsp;&amp;nbsp;&amp;nbsp;&amp;nbsp;|
/// &lt;br&gt;|&amp;nbsp;IEBE&amp;nbsp;&amp;nbsp;&amp;nbsp;&amp;nbsp;&amp;nbsp;&amp;nbsp;ISBE |
/// &lt;br&gt;|&amp;nbsp;BEIE&amp;nbsp;BEIC&amp;nbsp;BEIS | &lt;br&gt;+----------------+&lt;/pre&gt;&lt;br&gt;
/// Legacy values:&lt;br&gt; &lt;pre&gt;+----------------+
/// &lt;br&gt;|&amp;nbsp;TL&amp;nbsp;&amp;nbsp;&amp;nbsp;&amp;nbsp;TC&amp;nbsp;&amp;nbsp;&amp;nbsp;&amp;nbsp;TR |
/// &lt;br&gt;|&amp;nbsp;LT&amp;nbsp;&amp;nbsp;&amp;nbsp;&amp;nbsp;&amp;nbsp;&amp;nbsp;&amp;nbsp;&amp;nbsp;&amp;nbsp;&amp;nbsp;RT
/// |
/// &lt;br&gt;|&amp;nbsp;&amp;nbsp;&amp;nbsp;&amp;nbsp;&amp;nbsp;&amp;nbsp;&amp;nbsp;&amp;nbsp;&amp;nbsp;&amp;nbsp;&amp;nbsp;&amp;nbsp;&amp;nbsp;&amp;nbsp;&amp;nbsp;&amp;nbsp;|
/// &lt;br&gt;|&amp;nbsp;LC&amp;nbsp;&amp;nbsp;&amp;nbsp;&amp;nbsp;&amp;nbsp;&amp;nbsp;&amp;nbsp;&amp;nbsp;&amp;nbsp;&amp;nbsp;RC
/// |
/// &lt;br&gt;|&amp;nbsp;&amp;nbsp;&amp;nbsp;&amp;nbsp;&amp;nbsp;&amp;nbsp;&amp;nbsp;&amp;nbsp;&amp;nbsp;&amp;nbsp;&amp;nbsp;&amp;nbsp;&amp;nbsp;&amp;nbsp;&amp;nbsp;&amp;nbsp;|
/// &lt;br&gt;|&amp;nbsp;LB&amp;nbsp;&amp;nbsp;&amp;nbsp;&amp;nbsp;&amp;nbsp;&amp;nbsp;&amp;nbsp;&amp;nbsp;&amp;nbsp;&amp;nbsp;RB
/// | &lt;br&gt;|&amp;nbsp;BL&amp;nbsp;&amp;nbsp;&amp;nbsp;&amp;nbsp;BC&amp;nbsp;&amp;nbsp;&amp;nbsp;&amp;nbsp;BR |
/// &lt;br&gt;+----------------+&lt;/pre&gt;&lt;br&gt; Elements in the top or bottom row flow
/// towards the middle of the row. Elements in the left or right column flow
/// towards the middle of the column.
///
/// Access by calling `const {ControlPosition} = await
/// google.maps.importLibrary("core")`. See
/// <see href="https://developers.google.com/maps/documentation/javascript/libraries." />
/// </summary>
type [<RequireQualifiedAccess>] ControlPosition =
    /// Equivalent to BOTTOM_CENTER in both LTR and RTL.
    | BLOCK_END_INLINE_CENTER = 0
    /// Equivalent to BOTTOM_RIGHT in LTR, or BOTTOM_LEFT in RTL.
    | BLOCK_END_INLINE_END = 1
    /// Equivalent to BOTTOM_LEFT in LTR, or BOTTOM_RIGHT in RTL.
    | BLOCK_END_INLINE_START = 2
    /// Equivalent to TOP_CENTER in both LTR and RTL.
    | BLOCK_START_INLINE_CENTER = 3
    /// Equivalent to TOP_RIGHT in LTR, or TOP_LEFT in RTL.
    | BLOCK_START_INLINE_END = 4
    /// Equivalent to TOP_LEFT in LTR, or TOP_RIGHT in RTL.
    | BLOCK_START_INLINE_START = 5
    /// Elements are positioned in the center of the bottom row. Consider using
    /// BLOCK_END_INLINE_CENTER instead.
    | BOTTOM_CENTER = 6
    /// Elements are positioned in the bottom left and flow towards the middle.
    /// Elements are positioned to the right of the Google logo. Consider using
    /// BLOCK_END_INLINE_START instead.
    | BOTTOM_LEFT = 7
    /// Elements are positioned in the bottom right and flow towards the middle.
    /// Elements are positioned to the left of the copyrights. Consider using
    /// BLOCK_END_INLINE_END instead.
    | BOTTOM_RIGHT = 8
    /// Equivalent to RIGHT_CENTER in LTR, or LEFT_CENTER in RTL.
    | INLINE_END_BLOCK_CENTER = 9
    /// Equivalent to RIGHT_BOTTOM in LTR, or LEFT_BOTTOM in RTL.
    | INLINE_END_BLOCK_END = 10
    /// Equivalent to RIGHT_TOP in LTR, or LEFT_TOP in RTL.
    | INLINE_END_BLOCK_START = 11
    /// Equivalent to LEFT_CENTER in LTR, or RIGHT_CENTER in RTL.
    | INLINE_START_BLOCK_CENTER = 12
    /// Equivalent to LEFT_BOTTOM in LTR, or RIGHT_BOTTOM in RTL.
    | INLINE_START_BLOCK_END = 13
    /// Equivalent to LEFT_TOP in LTR, or RIGHT_TOP in RTL.
    | INLINE_START_BLOCK_START = 14
    /// Elements are positioned on the left, above bottom-left elements, and flow
    /// upwards. Consider using INLINE_START_BLOCK_END instead.
    | LEFT_BOTTOM = 15
    /// Elements are positioned in the center of the left side. Consider using
    /// INLINE_START_BLOCK_CENTER instead.
    | LEFT_CENTER = 16
    /// Elements are positioned on the left, below top-left elements, and flow
    /// downwards. Consider using INLINE_START_BLOCK_START instead.
    | LEFT_TOP = 17
    /// Elements are positioned on the right, above bottom-right elements, and
    /// flow upwards. Consider using INLINE_END_BLOCK_END instead.
    | RIGHT_BOTTOM = 18
    /// Elements are positioned in the center of the right side. Consider using
    /// INLINE_END_BLOCK_CENTER instead.
    | RIGHT_CENTER = 19
    /// Elements are positioned on the right, below top-right elements, and flow
    /// downwards. Consider using INLINE_END_BLOCK_START instead.
    | RIGHT_TOP = 20
    /// Elements are positioned in the center of the top row. Consider using
    /// BLOCK_START_INLINE_CENTER instead.
    | TOP_CENTER = 21
    /// Elements are positioned in the top left and flow towards the middle.
    /// Consider using BLOCK_START_INLINE_START instead.
    | TOP_LEFT = 22
    /// Elements are positioned in the top right and flow towards the middle.
    /// Consider using BLOCK_START_INLINE_END instead.
    | TOP_RIGHT = 23

/// <summary>
/// This interface provides convenience methods for generating matrices to use
/// for rendering WebGL scenes on top of the Google base map. &lt;br&gt;&lt;br&gt;Note: A
/// reference to this object should &lt;b&gt;not&lt;/b&gt; be held outside of the scope of
/// the encapsulating <see cref="google.maps.WebGLOverlayView.onDraw" /> call.
/// </summary>
type [<AllowNullLiteral>] CoordinateTransformer =
    /// <param name="latLngAltitude">Latitude, longitude, and altitude.</param>
    /// <param name="rotations">
    /// An array that contains an Euler rotation angle in
    /// degrees, in the XYZ convention.
    /// </param>
    /// <param name="scale">
    /// Array that contains an XYZ scalar array to apply to the
    /// cardinal axis.
    /// </param>
    abstract fromLatLngAltitude: latLngAltitude: U2<Google.Maps.LatLngAltitude, Google.Maps.LatLngAltitudeLiteral> * ?rotations: Float32Array * ?scale: Float32Array -> Float64Array
    abstract getCameraParams: unit -> Google.Maps.CameraParams

type [<AllowNullLiteral>] CoreLibrary =
    abstract ControlPosition: obj with get, set
    abstract ``event``: obj with get, set
    abstract LatLng: obj with get, set
    abstract LatLngAltitude: obj with get, set
    abstract LatLngBounds: obj with get, set
    abstract MapsNetworkError: obj with get, set
    abstract MapsNetworkErrorEndpoint: obj with get, set
    abstract MapsRequestError: obj with get, set
    abstract MapsServerError: obj with get, set
    abstract MVCArray: obj with get, set
    abstract MVCObject: obj with get, set
    abstract Point: obj with get, set
    abstract Settings: obj with get, set
    abstract Size: obj with get, set
    abstract SymbolPath: obj with get, set
    abstract UnitSystem: obj with get, set

/// <summary>
/// A layer for displaying geospatial data. Points, line-strings and polygons
/// can be displayed. &lt;p&gt; Every &lt;code&gt;Map&lt;/code&gt; has a &lt;code&gt;Data&lt;/code&gt; object
/// by default, so most of the time there is no need to construct one. For
/// example: &lt;pre&gt; var myMap = new google.maps.Map(...);&lt;br&gt;
/// myMap.data.addGeoJson(...);&lt;br&gt; myMap.data.setStyle(...); &lt;/pre&gt; The
/// &lt;code&gt;Data&lt;/code&gt; object is a collection of &lt;a
/// href="#Data.Feature"&gt;&lt;code&gt;Features&lt;/code&gt;&lt;/a&gt;.
///
/// Access by calling <c>const {Data} = await google.maps.importLibrary("maps")</c>.
/// See <see href="https://developers.google.com/maps/documentation/javascript/libraries." />
/// </summary>
type [<AllowNullLiteral>] Data =
    inherit Google.Maps.MVCObject
    /// Adds a feature to the collection, and returns the added feature. &lt;p&gt; If
    /// the feature has an ID, it will replace any existing feature in the
    /// collection with the same ID. If no feature is given, a new feature will
    /// be created with null geometry and no properties. If
    /// &lt;code&gt;FeatureOptions&lt;/code&gt; are given, a new feature will be created with
    /// the specified properties. &lt;p&gt; Note that the IDs &lt;code&gt;1234&lt;/code&gt; and
    /// &lt;code&gt;'1234'&lt;/code&gt; are equivalent. Adding a feature with ID
    /// &lt;code&gt;1234&lt;/code&gt; will replace a feature with ID &lt;code&gt;'1234'&lt;/code&gt;, and
    /// vice versa.
    abstract add: ?feature: U2<Google.Maps.Data.Feature, Google.Maps.Data.FeatureOptions> -> Google.Maps.Data.Feature
    /// Adds GeoJSON features to the collection. Give this method a parsed JSON.
    /// The imported features are returned. Throws an exception if the GeoJSON
    /// could not be imported.
    abstract addGeoJson: geoJson: obj * ?options: Google.Maps.Data.GeoJsonOptions -> ResizeArray<Google.Maps.Data.Feature>
    /// Checks whether the given feature is in the collection.
    abstract contains: feature: Google.Maps.Data.Feature -> bool
    /// Repeatedly invokes the given function, passing a feature in the
    /// collection to the function on each invocation. The order of iteration
    /// through the features is undefined.
    abstract forEach: callback: (Google.Maps.Data.Feature -> unit) -> unit
    /// Returns the position of the drawing controls on the map.
    abstract getControlPosition: unit -> Google.Maps.ControlPosition
    /// Returns which drawing modes are available for the user to select, in the
    /// order they are displayed. This does not include the &lt;code&gt;null&lt;/code&gt;
    /// drawing mode, which is added by default. Possible drawing modes are
    /// &lt;code&gt;"Point"&lt;/code&gt;, &lt;code&gt;"LineString"&lt;/code&gt; or
    /// &lt;code&gt;"Polygon"&lt;/code&gt;.
    abstract getControls: unit -> ResizeArray<string> option
    /// Returns the current drawing mode of the given Data layer. A drawing mode
    /// of &lt;code&gt;null&lt;/code&gt; means that the user can interact with the map as
    /// normal, and clicks do not draw anything. Possible drawing modes are
    /// &lt;code&gt;null&lt;/code&gt;, &lt;code&gt;"Point"&lt;/code&gt;, &lt;code&gt;"LineString"&lt;/code&gt; or
    /// &lt;code&gt;"Polygon"&lt;/code&gt;.
    abstract getDrawingMode: unit -> string option
    /// Returns the feature with the given ID, if it exists in the collection.
    /// Otherwise returns &lt;code&gt;undefined&lt;/code&gt;. &lt;p&gt; Note that the IDs
    /// &lt;code&gt;1234&lt;/code&gt; and &lt;code&gt;'1234'&lt;/code&gt; are equivalent. Either can be
    /// used to look up the same feature.
    abstract getFeatureById: id: U2<float, string> -> Google.Maps.Data.Feature option
    /// Returns the map on which the features are displayed.
    abstract getMap: unit -> Google.Maps.Map option
    /// Gets the style for all features in the collection.
    abstract getStyle: unit -> U2<Google.Maps.Data.StylingFunction, Google.Maps.Data.StyleOptions> option
    /// Loads GeoJSON from a URL, and adds the features to the collection. &lt;p&gt;
    /// NOTE: The GeoJSON is fetched using XHR, and may not work cross-domain. If
    /// you have issues, we recommend you fetch the GeoJSON using your choice of
    /// AJAX library, and then call &lt;code&gt;addGeoJson()&lt;/code&gt;.
    abstract loadGeoJson: url: string * ?options: Google.Maps.Data.GeoJsonOptions * ?callback: (ResizeArray<Google.Maps.Data.Feature> -> unit) -> unit
    /// Changes the style of a feature. These changes are applied on top of the
    /// style specified by &lt;code&gt;setStyle()&lt;/code&gt;. Style properties set to
    /// &lt;code&gt;null&lt;/code&gt; revert to the value specified via
    /// &lt;code&gt;setStyle()&lt;/code&gt;.
    abstract overrideStyle: feature: Google.Maps.Data.Feature * style: Google.Maps.Data.StyleOptions -> unit
    /// Removes a feature from the collection.
    abstract remove: feature: Google.Maps.Data.Feature -> unit
    /// Removes the effect of previous &lt;code&gt;overrideStyle()&lt;/code&gt; calls. The
    /// style of the given feature reverts to the style specified by
    /// &lt;code&gt;setStyle()&lt;/code&gt;. &lt;p&gt;If no feature is given, all features have
    /// their style reverted.&lt;/p&gt;
    abstract revertStyle: ?feature: Google.Maps.Data.Feature -> unit
    /// Sets the position of the drawing controls on the map.
    abstract setControlPosition: controlPosition: Google.Maps.ControlPosition -> unit
    /// Sets which drawing modes are available for the user to select, in the
    /// order they are displayed. This should not include the &lt;code&gt;null&lt;/code&gt;
    /// drawing mode, which is added by default. If &lt;code&gt;null&lt;/code&gt;, drawing
    /// controls are disabled and not displayed. Possible drawing modes are
    /// &lt;code&gt;"Point"&lt;/code&gt;, &lt;code&gt;"LineString"&lt;/code&gt; or
    /// &lt;code&gt;"Polygon"&lt;/code&gt;.
    abstract setControls: controls: ResizeArray<string> option -> unit
    /// Sets the current drawing mode of the given Data layer. A drawing mode of
    /// &lt;code&gt;null&lt;/code&gt; means that the user can interact with the map as
    /// normal, and clicks do not draw anything. Possible drawing modes are
    /// &lt;code&gt;null&lt;/code&gt;, &lt;code&gt;"Point"&lt;/code&gt;, &lt;code&gt;"LineString"&lt;/code&gt; or
    /// &lt;code&gt;"Polygon"&lt;/code&gt;.
    abstract setDrawingMode: drawingMode: string option -> unit
    /// Renders the features on the specified map. If map is set to
    /// &lt;code&gt;null&lt;/code&gt;, the features will be removed from the map.
    abstract setMap: map: Google.Maps.Map option -> unit
    /// Sets the style for all features in the collection. Styles specified on a
    /// per-feature basis via &lt;code&gt;overrideStyle()&lt;/code&gt; continue to apply.
    /// &lt;p&gt;Pass either an object with the desired style options, or a function
    /// that computes the style for each feature. The function will be called
    /// every time a feature&amp;#39;s properties are updated.
    abstract setStyle: style: U2<Google.Maps.Data.StylingFunction, Google.Maps.Data.StyleOptions> option -> unit
    /// Exports the features in the collection to a GeoJSON object.
    abstract toGeoJson: callback: (obj -> unit) -> unit

/// <summary>
/// A layer for displaying geospatial data. Points, line-strings and polygons
/// can be displayed. &lt;p&gt; Every &lt;code&gt;Map&lt;/code&gt; has a &lt;code&gt;Data&lt;/code&gt; object
/// by default, so most of the time there is no need to construct one. For
/// example: &lt;pre&gt; var myMap = new google.maps.Map(...);&lt;br&gt;
/// myMap.data.addGeoJson(...);&lt;br&gt; myMap.data.setStyle(...); &lt;/pre&gt; The
/// &lt;code&gt;Data&lt;/code&gt; object is a collection of &lt;a
/// href="#Data.Feature"&gt;&lt;code&gt;Features&lt;/code&gt;&lt;/a&gt;.
///
/// Access by calling <c>const {Data} = await google.maps.importLibrary("maps")</c>.
/// See <see href="https://developers.google.com/maps/documentation/javascript/libraries." />
/// </summary>
type [<AllowNullLiteral>] DataStatic =
    /// <summary>
    /// A layer for displaying geospatial data. Points, line-strings and polygons
    /// can be displayed. &lt;p&gt; Every &lt;code&gt;Map&lt;/code&gt; has a &lt;code&gt;Data&lt;/code&gt;
    /// object by default, so most of the time there is no need to construct one.
    /// For example: &lt;pre&gt; var myMap = new google.maps.Map(...);&lt;br&gt;
    /// myMap.data.addGeoJson(...);&lt;br&gt; myMap.data.setStyle(...); &lt;/pre&gt; The
    /// &lt;code&gt;Data&lt;/code&gt; object is a collection of &lt;a
    /// href="#Data.Feature"&gt;&lt;code&gt;Features&lt;/code&gt;&lt;/a&gt;.
    ///
    /// Access by calling `const {Data} = await
    /// google.maps.importLibrary("maps")`. See
    /// <see href="https://developers.google.com/maps/documentation/javascript/libraries." />
    /// </summary>
    [<EmitConstructor>] abstract Create: ?options: Google.Maps.Data.DataOptions -> Data

/// <summary>
/// Available only in the v=beta channel: <see href="https://goo.gle/3oAthT3." />
///
/// An interface representing a feature from a Dataset. The
/// &lt;code&gt;featureType&lt;/code&gt; of a &lt;code&gt;DatasetFeature&lt;/code&gt; will always be
/// &lt;code&gt;FeatureType.DATASET&lt;/code&gt;.
/// </summary>
type [<AllowNullLiteral>] DatasetFeature =
    inherit Google.Maps.Feature
    /// Key-value mapping of the feature&#39;s attributes.
    abstract datasetAttributes: DatasetFeatureDatasetAttributes with get, set
    /// Dataset id of the dataset that this feature belongs to.
    abstract datasetId: string with get, set

/// A single geocoded waypoint.
type [<AllowNullLiteral>] DirectionsGeocodedWaypoint =
    /// Whether the geocoder did not return an exact match for the original
    /// waypoint, though it was able to match part of the requested address.
    abstract partial_match: bool option with get, set
    /// <summary>
    /// The place ID associated with the waypoint. Place IDs uniquely identify a
    /// place in the Google Places database and on Google Maps. Learn more about
    /// &lt;a
    /// href="<see href="https://developers.google.com/maps/documentation/places/web-service/place-id"&gt;Place" />
    /// IDs&lt;/a&gt; in the Places API developer guide.
    /// </summary>
    abstract place_id: string option with get, set
    /// <summary>
    /// An array of strings denoting the type of the returned geocoded element.
    /// For a list of possible strings, refer to the &lt;a href=
    /// "<see href="https://developers.google.com/maps/documentation/javascript/geocoding#GeocodingAddressTypes"&gt;" />
    /// Address Component Types&lt;/a&gt; section of the Developer&amp;#39;s Guide.
    /// </summary>
    abstract types: ResizeArray<string> option with get, set

/// A single leg consisting of a set of steps in a &lt;code&gt;&lt;a
/// href="#DirectionsResult"&gt;DirectionsResult&lt;/a&gt;&lt;/code&gt;. Some fields in the
/// leg may not be returned for all requests. Note that though this result is
/// &amp;quot;JSON-like,&amp;quot; it is not strictly JSON, as it directly and
/// indirectly includes &lt;code&gt;LatLng&lt;/code&gt; objects.
type [<AllowNullLiteral>] DirectionsLeg =
    /// An estimated arrival time for this leg. Only applicable for TRANSIT
    /// requests.
    abstract arrival_time: Google.Maps.Time option with get, set
    /// An estimated departure time for this leg. Only applicable for TRANSIT
    /// requests.
    abstract departure_time: Google.Maps.Time option with get, set
    /// The total distance covered by this leg. This property may be undefined as
    /// the distance may be unknown.
    abstract distance: Google.Maps.Distance option with get, set
    /// The total duration of this leg. This property may be
    /// &lt;code&gt;undefined&lt;/code&gt; as the duration may be unknown.
    abstract duration: Google.Maps.Duration option with get, set
    /// The total duration of this leg, taking into account the traffic
    /// conditions indicated by the &lt;code&gt;trafficModel&lt;/code&gt; property. This
    /// property may be &lt;code&gt;undefined&lt;/code&gt; as the duration may be unknown.
    abstract duration_in_traffic: Google.Maps.Duration option with get, set
    /// The address of the destination of this leg. This content is meant to be
    /// read as-is. Do not programmatically parse the formatted address.
    abstract end_address: string with get, set
    /// The &lt;code&gt;DirectionsService&lt;/code&gt; calculates directions between
    /// locations by using the nearest transportation option (usually a road) at
    /// the start and end locations. &lt;code&gt;end_location&lt;/code&gt; indicates the
    /// actual geocoded destination, which may be different than the
    /// &lt;code&gt;end_location&lt;/code&gt; of the last step if, for example, the road is
    /// not near the destination of this leg.
    abstract end_location: Google.Maps.LatLng with get, set
    /// The address of the origin of this leg. This content is meant to be read
    /// as-is. Do not programmatically parse the formatted address.
    abstract start_address: string with get, set
    /// The &lt;code&gt;DirectionsService&lt;/code&gt; calculates directions between
    /// locations by using the nearest transportation option (usually a road) at
    /// the start and end locations. &lt;code&gt;start_location&lt;/code&gt; indicates the
    /// actual geocoded origin, which may be different than the
    /// &lt;code&gt;start_location&lt;/code&gt; of the first step if, for example, the road
    /// is not near the origin of this leg.
    abstract start_location: Google.Maps.LatLng with get, set
    /// An array of &lt;code&gt;DirectionsStep&lt;/code&gt;s, each of which contains
    /// information about the individual steps in this leg.
    abstract steps: ResizeArray<Google.Maps.DirectionsStep> with get, set
    /// Information about traffic speed along the leg.
    [<Obsolete("This array will always be empty.")>]
    abstract traffic_speed_entry: ResizeArray<obj option> with get, set
    /// An array of non-stopover waypoints along this leg, which were specified
    /// in the original request. &lt;p&gt; &lt;strong&gt;Deprecated in alternative
    /// routes&lt;/strong&gt;. Version 3.27 will be the last version of the API that
    /// adds extra &lt;code&gt;via_waypoints&lt;/code&gt; in alternative routes. &lt;p&gt; When
    /// using the Directions Service to implement draggable directions, it is
    /// recommended to disable dragging of alternative routes. Only the main
    /// route should be draggable. Users can drag the main route until it matches
    /// an alternative route.
    abstract via_waypoints: ResizeArray<Google.Maps.LatLng> with get, set

/// <summary>
/// An object containing a &lt;code&gt;points&lt;/code&gt; property to describe the
/// polyline of a <see cref="google.maps.DirectionsStep" />.
/// </summary>
type [<AllowNullLiteral>] DirectionsPolyline =
    /// <summary>
    /// An &lt;a
    /// href="<see href="https://developers.google.com/maps/documentation/utilities/polylinealgorithm"&gt;encoded" />
    /// polyline&lt;/a&gt;.
    /// </summary>
    abstract points: string with get, set

/// <summary>
/// Renders directions obtained from the &lt;code&gt;&lt;a
/// href="#DirectionsService"&gt;DirectionsService&lt;/a&gt;&lt;/code&gt;.
///
/// Access by calling `const {DirectionsRenderer} = await
/// google.maps.importLibrary("routes")`. See
/// <see href="https://developers.google.com/maps/documentation/javascript/libraries." />
/// </summary>
type [<AllowNullLiteral>] DirectionsRenderer =
    inherit Google.Maps.MVCObject
    /// Returns the renderer&#39;s current set of directions.
    abstract getDirections: unit -> Google.Maps.DirectionsResult option
    /// Returns the map on which the &lt;code&gt;DirectionsResult&lt;/code&gt; is rendered.
    abstract getMap: unit -> Google.Maps.Map option
    /// Returns the panel &lt;code&gt;&amp;lt;div&amp;gt;&lt;/code&gt; in which the
    /// &lt;code&gt;DirectionsResult&lt;/code&gt; is rendered.
    abstract getPanel: unit -> HTMLElement option
    /// Returns the current (zero-based) route index in use by this
    /// &lt;code&gt;DirectionsRenderer&lt;/code&gt; object.
    abstract getRouteIndex: unit -> float
    /// Set the renderer to use the result from the
    /// &lt;code&gt;DirectionsService&lt;/code&gt;. Setting a valid set of directions in this
    /// manner will display the directions on the renderer&amp;#39;s designated map
    /// and panel.
    abstract setDirections: directions: Google.Maps.DirectionsResult option -> unit
    /// This method specifies the map on which directions will be rendered. Pass
    /// &lt;code&gt;null&lt;/code&gt; to remove the directions from the map.
    abstract setMap: map: Google.Maps.Map option -> unit
    /// Change the options settings of this &lt;code&gt;DirectionsRenderer&lt;/code&gt; after
    /// initialization.
    abstract setOptions: options: Google.Maps.DirectionsRendererOptions option -> unit
    /// This method renders the directions in a &lt;code&gt;&amp;lt;div&amp;gt;&lt;/code&gt;. Pass
    /// &lt;code&gt;null&lt;/code&gt; to remove the content from the panel.
    abstract setPanel: panel: HTMLElement option -> unit
    /// Set the (zero-based) index of the route in the
    /// &lt;code&gt;DirectionsResult&lt;/code&gt; object to render. By default, the first
    /// route in the array will be rendered.
    abstract setRouteIndex: routeIndex: float -> unit

/// <summary>
/// Renders directions obtained from the &lt;code&gt;&lt;a
/// href="#DirectionsService"&gt;DirectionsService&lt;/a&gt;&lt;/code&gt;.
///
/// Access by calling `const {DirectionsRenderer} = await
/// google.maps.importLibrary("routes")`. See
/// <see href="https://developers.google.com/maps/documentation/javascript/libraries." />
/// </summary>
type [<AllowNullLiteral>] DirectionsRendererStatic =
    /// <summary>
    /// Renders directions obtained from the &lt;code&gt;&lt;a
    /// href="#DirectionsService"&gt;DirectionsService&lt;/a&gt;&lt;/code&gt;.
    ///
    /// Access by calling `const {DirectionsRenderer} = await
    /// google.maps.importLibrary("routes")`. See
    /// <see href="https://developers.google.com/maps/documentation/javascript/libraries." />
    /// </summary>
    [<EmitConstructor>] abstract Create: ?opts: Google.Maps.DirectionsRendererOptions -> DirectionsRenderer

/// This object defines the properties that can be set on a
/// &lt;code&gt;DirectionsRenderer&lt;/code&gt; object.
type [<AllowNullLiteral>] DirectionsRendererOptions =
    /// The directions to display on the map and/or in a &lt;code&gt;&amp;lt;div&amp;gt;&lt;/code&gt;
    /// panel, retrieved as a &lt;code&gt;DirectionsResult&lt;/code&gt; object from
    /// &lt;code&gt;DirectionsService&lt;/code&gt;.
    abstract directions: Google.Maps.DirectionsResult option with get, set
    /// If &lt;code&gt;true&lt;/code&gt;, allows the user to drag and modify the paths of
    /// routes rendered by this &lt;code&gt;DirectionsRenderer&lt;/code&gt;.
    abstract draggable: bool option with get, set
    /// <summary>
    /// This property indicates whether the renderer should provide a
    /// user-selectable list of routes shown in the directions panel.
    /// </summary>
    /// <default>&lt;code&gt;false&lt;/code&gt;</default>
    abstract hideRouteList: bool option with get, set
    /// The &lt;code&gt;InfoWindow&lt;/code&gt; in which to render text information when a
    /// marker is clicked. Existing info window content will be overwritten and
    /// its position moved. If no info window is specified, the
    /// &lt;code&gt;DirectionsRenderer&lt;/code&gt; will create and use its own info window.
    /// This property will be ignored if &lt;code&gt;suppressInfoWindows&lt;/code&gt; is set
    /// to &lt;code&gt;true&lt;/code&gt;.
    abstract infoWindow: Google.Maps.InfoWindow option with get, set
    /// Map on which to display the directions.
    abstract map: Google.Maps.Map option with get, set
    /// Options for the markers. All markers rendered by the
    /// &lt;code&gt;DirectionsRenderer&lt;/code&gt; will use these options.
    abstract markerOptions: Google.Maps.MarkerOptions option with get, set
    /// The &lt;code&gt;&amp;lt;div&amp;gt;&lt;/code&gt; in which to display the directions steps.
    abstract panel: HTMLElement option with get, set
    /// Options for the polylines. All polylines rendered by the
    /// &lt;code&gt;DirectionsRenderer&lt;/code&gt; will use these options.
    abstract polylineOptions: Google.Maps.PolylineOptions option with get, set
    /// <summary>
    /// If this option is set to &lt;code&gt;true&lt;/code&gt; or the map&amp;#39;s center and
    /// zoom were never set, the input map is centered and zoomed to the bounding
    /// box of this set of directions.
    /// </summary>
    /// <default>&lt;code&gt;false&lt;/code&gt;</default>
    abstract preserveViewport: bool option with get, set
    /// The index of the route within the &lt;code&gt;DirectionsResult&lt;/code&gt; object.
    /// The default value is 0.
    abstract routeIndex: float option with get, set
    /// Suppress the rendering of the &lt;code&gt;BicyclingLayer&lt;/code&gt; when bicycling
    /// directions are requested.
    abstract suppressBicyclingLayer: bool option with get, set
    /// Suppress the rendering of info windows.
    abstract suppressInfoWindows: bool option with get, set
    /// Suppress the rendering of markers.
    abstract suppressMarkers: bool option with get, set
    /// Suppress the rendering of polylines.
    abstract suppressPolylines: bool option with get, set

/// A directions query to be sent to the &lt;code&gt;&lt;a
/// href="#DirectionsService"&gt;DirectionsService&lt;/a&gt;&lt;/code&gt;.
type [<AllowNullLiteral>] DirectionsRequest =
    /// If &lt;code&gt;true&lt;/code&gt;, instructs the Directions service to avoid ferries
    /// where possible. Optional.
    abstract avoidFerries: bool option with get, set
    /// If &lt;code&gt;true&lt;/code&gt;, instructs the Directions service to avoid highways
    /// where possible. Optional.
    abstract avoidHighways: bool option with get, set
    /// If &lt;code&gt;true&lt;/code&gt;, instructs the Directions service to avoid toll
    /// roads where possible. Optional.
    abstract avoidTolls: bool option with get, set
    /// Location of destination. This can be specified as either a string to be
    /// geocoded, or a &lt;code&gt;LatLng&lt;/code&gt;, or a &lt;code&gt;Place&lt;/code&gt;. Required.
    abstract destination: U4<string, Google.Maps.LatLng, Google.Maps.Place, Google.Maps.LatLngLiteral> with get, set
    /// Settings that apply only to requests where &lt;code&gt;travelMode&lt;/code&gt; is
    /// &lt;code&gt;DRIVING&lt;/code&gt;. This object will have no effect for other travel
    /// modes.
    abstract drivingOptions: Google.Maps.DrivingOptions option with get, set
    /// <summary>
    /// A language identifier for the language in which results should be
    /// returned, when possible. See the &lt;a
    /// href="<see href="https://developers.google.com/maps/faq#languagesupport"&gt;list" /> of
    /// supported languages&lt;/a&gt;.
    /// </summary>
    abstract language: string option with get, set
    /// If set to &lt;code&gt;true&lt;/code&gt;, the &lt;code&gt;DirectionsService&lt;/code&gt; will
    /// attempt to re-order the supplied intermediate waypoints to minimize
    /// overall cost of the route. If waypoints are optimized, inspect
    /// &lt;code&gt;DirectionsRoute.waypoint_order&lt;/code&gt; in the response to determine
    /// the new ordering.
    abstract optimizeWaypoints: bool option with get, set
    /// Location of origin. This can be specified as either a string to be
    /// geocoded, or a &lt;code&gt;LatLng&lt;/code&gt;, or a &lt;code&gt;Place&lt;/code&gt;. Required.
    abstract origin: U4<string, Google.Maps.LatLng, Google.Maps.Place, Google.Maps.LatLngLiteral> with get, set
    /// Whether or not route alternatives should be provided. Optional.
    abstract provideRouteAlternatives: bool option with get, set
    /// <summary>
    /// Region code used as a bias for geocoding requests. The region code
    /// accepts a &lt;a
    /// href="<see href="https://en.wikipedia.org/wiki/List_of_Internet_top-level_domains#Country_code_top-level_domains"&gt;ccTLD" />
    /// (&amp;quot;top-level domain&amp;quot;)&lt;/a&gt; two-character value. Most ccTLD codes
    /// are identical to ISO 3166-1 codes, with some notable exceptions. For
    /// example, the United Kingdom&amp;#39;s ccTLD is &amp;quot;uk&amp;quot;
    /// (&lt;code&gt;.co.uk&lt;/code&gt;) while its ISO 3166-1 code is &amp;quot;gb&amp;quot;
    /// (technically for the entity of &amp;quot;The United Kingdom of Great Britain
    /// and Northern Ireland&amp;quot;).
    /// </summary>
    abstract region: string option with get, set
    /// Settings that apply only to requests where &lt;code&gt;travelMode&lt;/code&gt; is
    /// TRANSIT. This object will have no effect for other travel modes.
    abstract transitOptions: Google.Maps.TransitOptions option with get, set
    /// Type of routing requested. Required.
    abstract travelMode: Google.Maps.TravelMode with get, set
    /// <summary>Preferred unit system to use when displaying distance.</summary>
    /// <default>The unit system used in the country of origin.</default>
    abstract unitSystem: Google.Maps.UnitSystem option with get, set
    /// <summary>
    /// Array of intermediate waypoints. Directions are calculated from the
    /// origin to the destination by way of each waypoint in this array. See the
    /// &lt;a
    /// href="<see href="https://developers.google.com/maps/documentation/javascript/directions#UsageLimits"&gt;" />
    /// developer&amp;#39;s guide&lt;/a&gt; for the maximum number of waypoints allowed.
    /// Waypoints are not supported for transit directions. Optional.
    /// </summary>
    abstract waypoints: ResizeArray<Google.Maps.DirectionsWaypoint> option with get, set

/// <summary>
/// The directions response retrieved from the directions server. You can
/// render these using a <see cref="google.maps.DirectionsRenderer" /> or parse this
/// object and render it yourself. You must display the warnings and copyrights
/// as noted in the &lt;a
/// href="<see href="https://cloud.google.com/maps-platform/terms"&gt;Google" /> Maps Platform
/// Terms of Service&lt;/a&gt;. Note that though this result is
/// &amp;quot;JSON-like,&amp;quot; it is not strictly JSON, as it indirectly includes
/// &lt;code&gt;LatLng&lt;/code&gt; objects.
/// </summary>
type [<AllowNullLiteral>] DirectionsResult =
    /// Contains an array of available travel modes. This field is returned when
    /// a request specifies a travel mode and gets no results. The array contains
    /// the available travel modes in the countries of the given set of
    /// waypoints. This field is not returned if one or more of the waypoints are
    /// &#39;via waypoints&#39;.
    abstract available_travel_modes: ResizeArray<Google.Maps.TravelMode> option with get, set
    /// An array of &lt;code&gt;DirectionsGeocodedWaypoint&lt;/code&gt;s, each of which
    /// contains information about the geocoding of origin, destination and
    /// waypoints.
    abstract geocoded_waypoints: ResizeArray<Google.Maps.DirectionsGeocodedWaypoint> option with get, set
    /// The DirectionsRequest that yielded this result.
    abstract request: Google.Maps.DirectionsRequest with get, set
    /// An array of &lt;code&gt;DirectionsRoute&lt;/code&gt;s, each of which contains
    /// information about the legs and steps of which it is composed. There will
    /// only be one route unless the &lt;code&gt;DirectionsRequest&lt;/code&gt; was made with
    /// &lt;code&gt;provideRouteAlternatives&lt;/code&gt; set to &lt;code&gt;true&lt;/code&gt;.
    abstract routes: ResizeArray<Google.Maps.DirectionsRoute> with get, set

/// A single route containing a set of legs in a &lt;code&gt;&lt;a
/// href="#DirectionsResult"&gt;DirectionsResult&lt;/a&gt;&lt;/code&gt;. Note that though this
/// object is &amp;quot;JSON-like,&amp;quot; it is not strictly JSON, as it directly
/// and indirectly includes &lt;code&gt;LatLng&lt;/code&gt; objects.
type [<AllowNullLiteral>] DirectionsRoute =
    /// The bounds for this route.
    abstract bounds: Google.Maps.LatLngBounds with get, set
    /// Copyrights text to be displayed for this route.
    abstract copyrights: string with get, set
    /// The total fare for the whole transit trip. Only applicable to transit
    /// requests.
    abstract fare: Google.Maps.TransitFare option with get, set
    /// An array of &lt;code&gt;DirectionsLeg&lt;/code&gt;s, each of which contains
    /// information about the steps of which it is composed. There will be one
    /// leg for each stopover waypoint or destination specified. So a route with
    /// no stopover waypoints will contain one &lt;code&gt;DirectionsLeg&lt;/code&gt; and a
    /// route with one stopover waypoint will contain two.
    abstract legs: ResizeArray<Google.Maps.DirectionsLeg> with get, set
    /// An array of &lt;code&gt;LatLng&lt;/code&gt;s representing the entire course of this
    /// route. The path is simplified in order to make it suitable in contexts
    /// where a small number of vertices is required (such as Static Maps API
    /// URLs).
    abstract overview_path: ResizeArray<Google.Maps.LatLng> with get, set
    /// <summary>
    /// An &lt;a
    /// href="<see href="https://developers.google.com/maps/documentation/utilities/polylinealgorithm"&gt;encoded" />
    /// polyline representation&lt;/a&gt; of the route in overview_path. This polyline
    /// is an approximate (smoothed) path of the resulting directions.
    /// </summary>
    abstract overview_polyline: string with get, set
    /// Contains a short textual description for the route, suitable for naming
    /// and disambiguating the route from alternatives.
    abstract summary: string with get, set
    /// Warnings to be displayed when showing these directions.
    abstract warnings: ResizeArray<string> with get, set
    /// If &lt;code&gt;optimizeWaypoints&lt;/code&gt; was set to &lt;code&gt;true&lt;/code&gt;, this
    /// field will contain the re-ordered permutation of the input waypoints. For
    /// example, if the input was:&lt;br&gt; &amp;nbsp;&amp;nbsp;Origin: Los Angeles&lt;br&gt;
    /// &amp;nbsp;&amp;nbsp;Waypoints: Dallas, Bangor, Phoenix&lt;br&gt;
    /// &amp;nbsp;&amp;nbsp;Destination: New York&lt;br&gt; and the optimized output was
    /// ordered as follows:&lt;br&gt; &amp;nbsp;&amp;nbsp;Origin: Los Angeles&lt;br&gt;
    /// &amp;nbsp;&amp;nbsp;Waypoints: Phoenix, Dallas, Bangor&lt;br&gt;
    /// &amp;nbsp;&amp;nbsp;Destination: New York&lt;br&gt; then this field will be an
    /// &lt;code&gt;Array&lt;/code&gt; containing the values [2, 0, 1]. Note that the
    /// numbering of waypoints is zero-based.&lt;br&gt; If any of the input waypoints
    /// has &lt;code&gt;stopover&lt;/code&gt; set to &lt;code&gt;false&lt;/code&gt;, this field will be
    /// empty, since route optimization is not available for such queries.
    abstract waypoint_order: ResizeArray<float> with get, set

/// <summary>
/// A service for computing directions between two or more places.
///
/// Access by calling `const {DirectionsService} = await
/// google.maps.importLibrary("routes")`. See
/// <see href="https://developers.google.com/maps/documentation/javascript/libraries." />
/// </summary>
type [<AllowNullLiteral>] DirectionsService =
    /// Issue a directions search request.
    abstract route: request: Google.Maps.DirectionsRequest * ?callback: (Google.Maps.DirectionsResult option -> Google.Maps.DirectionsStatus -> unit) -> Promise<Google.Maps.DirectionsResult>

/// <summary>
/// A service for computing directions between two or more places.
///
/// Access by calling `const {DirectionsService} = await
/// google.maps.importLibrary("routes")`. See
/// <see href="https://developers.google.com/maps/documentation/javascript/libraries." />
/// </summary>
type [<AllowNullLiteral>] DirectionsServiceStatic =
    [<EmitConstructor>] abstract Create: unit -> DirectionsService

/// <summary>
/// The status returned by the &lt;code&gt;DirectionsService&lt;/code&gt; on the completion
/// of a call to &lt;code&gt;route()&lt;/code&gt;. Specify these by value, or by using the
/// constant&amp;#39;s name. For example, &lt;code&gt;'OK'&lt;/code&gt; or
/// &lt;code&gt;google.maps.DirectionsStatus.OK&lt;/code&gt;.
///
/// Access by calling `const {DirectionsStatus} = await
/// google.maps.importLibrary("routes")`. See
/// <see href="https://developers.google.com/maps/documentation/javascript/libraries." />
/// </summary>
type [<StringEnum>] [<RequireQualifiedAccess>] DirectionsStatus =
    /// The &lt;code&gt;DirectionsRequest&lt;/code&gt; provided was invalid.
    | [<CompiledName("INVALID_REQUEST")>] INVALID_REQUEST
    /// <summary>
    /// Too many &lt;code&gt;DirectionsWaypoint&lt;/code&gt;s were provided in the
    /// &lt;code&gt;DirectionsRequest&lt;/code&gt;. See the &lt;a
    /// href="<see href="https://developers.google.com/maps/documentation/javascript/directions#UsageLimits"&gt;" />
    /// developer&amp;#39;s guide&lt;/a&gt; for the maximum number of waypoints allowed.
    /// </summary>
    | [<CompiledName("MAX_WAYPOINTS_EXCEEDED")>] MAX_WAYPOINTS_EXCEEDED
    /// At least one of the origin, destination, or waypoints could not be
    /// geocoded.
    | [<CompiledName("NOT_FOUND")>] NOT_FOUND
    /// The response contains a valid &lt;code&gt;DirectionsResult&lt;/code&gt;.
    | [<CompiledName("OK")>] OK
    /// The webpage has gone over the requests limit in too short a period of
    /// time.
    | [<CompiledName("OVER_QUERY_LIMIT")>] OVER_QUERY_LIMIT
    /// The webpage is not allowed to use the directions service.
    | [<CompiledName("REQUEST_DENIED")>] REQUEST_DENIED
    /// A directions request could not be processed due to a server error. The
    /// request may succeed if you try again.
    | [<CompiledName("UNKNOWN_ERROR")>] UNKNOWN_ERROR
    /// No route could be found between the origin and destination.
    | [<CompiledName("ZERO_RESULTS")>] ZERO_RESULTS

/// A single &lt;code&gt;DirectionsStep&lt;/code&gt; in a &lt;code&gt;DirectionsResult&lt;/code&gt;.
/// Some fields may be &lt;code&gt;undefined&lt;/code&gt;. Note that though this object is
/// &amp;quot;JSON-like,&amp;quot; it is not strictly JSON, as it directly includes
/// &lt;code&gt;LatLng&lt;/code&gt; objects.
type [<AllowNullLiteral>] DirectionsStep =
    /// The distance covered by this step. This property may be
    /// &lt;code&gt;undefined&lt;/code&gt; as the distance may be unknown.
    abstract distance: Google.Maps.Distance option with get, set
    /// The typical time required to perform this step in seconds and in text
    /// form. This property may be &lt;code&gt;undefined&lt;/code&gt; as the duration may be
    /// unknown.
    abstract duration: Google.Maps.Duration option with get, set
    /// <summary>
    /// An &lt;a
    /// href="<see href="https://developers.google.com/maps/documentation/utilities/polylinealgorithm"&gt;encoded" />
    /// polyline representation&lt;/a&gt; of the step. This is an approximate
    /// (smoothed) path of the step.
    /// </summary>
    abstract encoded_lat_lngs: string with get, set
    /// The ending location of this step.
    abstract end_location: Google.Maps.LatLng with get, set
    /// The ending location of this step.
    [<Obsolete("Please use {@link google.maps.DirectionsStep.end_location }.")>]
    abstract end_point: Google.Maps.LatLng with get, set
    /// Instructions for this step.
    abstract instructions: string with get, set
    /// A sequence of &lt;code&gt;LatLng&lt;/code&gt;s describing the course of this step.
    /// This is an approximate (smoothed) path of the step.
    [<Obsolete("Please use {@link google.maps.DirectionsStep.path }.")>]
    abstract lat_lngs: ResizeArray<Google.Maps.LatLng> with get, set
    /// Contains the action to take for the current step (&lt;code&gt;turn-left&lt;/code&gt;,
    /// &lt;code&gt;merge&lt;/code&gt;, &lt;code&gt;straight&lt;/code&gt;, etc.). Values are subject to
    /// change, and new values may be introduced without prior notice.
    abstract maneuver: string with get, set
    /// A sequence of &lt;code&gt;LatLng&lt;/code&gt;s describing the course of this step.
    /// This is an approximate (smoothed) path of the step.
    abstract path: ResizeArray<Google.Maps.LatLng> with get, set
    /// <summary>
    /// Contains an object with a single property, &amp;#39;points&amp;#39;, that holds
    /// an &lt;a
    /// href="<see href="https://developers.google.com/maps/documentation/utilities/polylinealgorithm"&gt;encoded" />
    /// polyline&lt;/a&gt; representation of the step. This polyline is an approximate
    /// (smoothed) path of the step.
    /// </summary>
    [<Obsolete("Please use {@link  *     google.maps.DirectionsStep.encoded_lat_lngs}.")>]
    abstract polyline: Google.Maps.DirectionsPolyline option with get, set
    /// The starting location of this step.
    abstract start_location: Google.Maps.LatLng with get, set
    /// The starting location of this step.
    [<Obsolete("Please use {@link google.maps.DirectionsStep.start_location }.")>]
    abstract start_point: Google.Maps.LatLng with get, set
    /// Sub-steps of this step. Specified for non-transit sections of transit
    /// routes.
    abstract steps: ResizeArray<Google.Maps.DirectionsStep> option with get, set
    /// Transit-specific details about this step. This property will be undefined
    /// unless the travel mode of this step is &lt;code&gt;TRANSIT&lt;/code&gt;.
    abstract transit: Google.Maps.TransitDetails option with get, set
    /// Details pertaining to this step if the travel mode is
    /// &lt;code&gt;TRANSIT&lt;/code&gt;.
    abstract transit_details: Google.Maps.TransitDetails option with get, set
    /// The mode of travel used in this step.
    abstract travel_mode: Google.Maps.TravelMode with get, set

[<Obsolete("Deprecated as of 2011. Use {@link google.maps.TravelMode }
instead.")>]
type [<RequireQualifiedAccess>] DirectionsTravelMode = class end

[<Obsolete("Deprecated as of 2011. Use {@link google.maps.UnitSystem }
instead.")>]
type [<RequireQualifiedAccess>] DirectionsUnitSystem = class end

/// A &lt;code&gt;DirectionsWaypoint&lt;/code&gt; represents a location between origin and
/// destination through which the trip should be routed.
type [<AllowNullLiteral>] DirectionsWaypoint =
    /// Waypoint location. Can be an address string, a &lt;code&gt;LatLng&lt;/code&gt;, or a
    /// &lt;code&gt;Place&lt;/code&gt;. Optional.
    abstract location: U4<string, Google.Maps.LatLng, Google.Maps.LatLngLiteral, Google.Maps.Place> option with get, set
    /// <summary>
    /// If &lt;code&gt;true&lt;/code&gt;, indicates that this waypoint is a stop between the
    /// origin and destination. This has the effect of splitting the route into
    /// two legs. If &lt;code&gt;false&lt;/code&gt;, indicates that the route should be
    /// biased to go through this waypoint, but not split into two legs. This is
    /// useful if you want to create a route in response to the user dragging
    /// waypoints on a map.
    /// </summary>
    /// <default>&lt;code&gt;true&lt;/code&gt;</default>
    abstract stopover: bool option with get, set

/// A representation of distance as a numeric value and a display string.
type [<AllowNullLiteral>] Distance =
    /// A string representation of the distance value, using the
    /// &lt;code&gt;UnitSystem&lt;/code&gt; specified in the request.
    abstract text: string with get, set
    /// The distance in meters.
    abstract value: float with get, set

/// <summary>
/// The element-level status about a particular origin-destination pairing
/// returned by the &lt;code&gt;DistanceMatrixService&lt;/code&gt; upon completion of a
/// distance matrix request. These values are specified as strings, for
/// example, &lt;code&gt;'OK'&lt;/code&gt;.
///
/// Access by calling `const {DistanceMatrixElementStatus} = await
/// google.maps.importLibrary("routes")`. See
/// <see href="https://developers.google.com/maps/documentation/javascript/libraries." />
/// </summary>
type [<StringEnum>] [<RequireQualifiedAccess>] DistanceMatrixElementStatus =
    /// The origin and/or destination of this pairing could not be geocoded.
    | [<CompiledName("NOT_FOUND")>] NOT_FOUND
    /// The response contains a valid result.
    | [<CompiledName("OK")>] OK
    /// No route could be found between the origin and destination.
    | [<CompiledName("ZERO_RESULTS")>] ZERO_RESULTS

/// A distance matrix query sent by the &lt;code&gt;DistanceMatrixService&lt;/code&gt;
/// containing arrays of origin and destination locations, and various options
/// for computing metrics.
type [<AllowNullLiteral>] DistanceMatrixRequest =
    /// If &lt;code&gt;true&lt;/code&gt;, instructs the Distance Matrix service to avoid
    /// ferries where possible. Optional.
    abstract avoidFerries: bool option with get, set
    /// If &lt;code&gt;true&lt;/code&gt;, instructs the Distance Matrix service to avoid
    /// highways where possible. Optional.
    abstract avoidHighways: bool option with get, set
    /// If &lt;code&gt;true&lt;/code&gt;, instructs the Distance Matrix service to avoid toll
    /// roads where possible. Optional.
    abstract avoidTolls: bool option with get, set
    /// An array containing destination address strings, or &lt;code&gt;LatLng&lt;/code&gt;,
    /// or &lt;code&gt;Place&lt;/code&gt; objects, to which to calculate distance and time.
    /// Required.
    abstract destinations: Array<U4<string, Google.Maps.LatLng, Google.Maps.LatLngLiteral, Google.Maps.Place>> with get, set
    /// Settings that apply only to requests where &lt;code&gt;travelMode&lt;/code&gt; is
    /// &lt;code&gt;DRIVING&lt;/code&gt;. This object will have no effect for other travel
    /// modes.
    abstract drivingOptions: Google.Maps.DrivingOptions option with get, set
    /// <summary>
    /// A language identifier for the language in which results should be
    /// returned, when possible. See the &lt;a
    /// href="<see href="https://developers.google.com/maps/faq#languagesupport"&gt;list" /> of
    /// supported languages&lt;/a&gt;.
    /// </summary>
    abstract language: string option with get, set
    /// An array containing origin address strings, or &lt;code&gt;LatLng&lt;/code&gt;, or
    /// &lt;code&gt;Place&lt;/code&gt; objects, from which to calculate distance and time.
    /// Required.
    abstract origins: Array<U4<string, Google.Maps.LatLng, Google.Maps.LatLngLiteral, Google.Maps.Place>> with get, set
    /// <summary>
    /// Region code used as a bias for geocoding requests. The region code
    /// accepts a &lt;a
    /// href="<see href="https://en.wikipedia.org/wiki/List_of_Internet_top-level_domains#Country_code_top-level_domains"&gt;ccTLD" />
    /// (&amp;quot;top-level domain&amp;quot;)&lt;/a&gt; two-character value. Most ccTLD codes
    /// are identical to ISO 3166-1 codes, with some notable exceptions. For
    /// example, the United Kingdom&amp;#39;s ccTLD is &amp;quot;uk&amp;quot;
    /// (&lt;code&gt;.co.uk&lt;/code&gt;) while its ISO 3166-1 code is &amp;quot;gb&amp;quot;
    /// (technically for the entity of &amp;quot;The United Kingdom of Great Britain
    /// and Northern Ireland&amp;quot;).
    /// </summary>
    abstract region: string option with get, set
    /// Settings that apply only to requests where &lt;code&gt;travelMode&lt;/code&gt; is
    /// TRANSIT. This object will have no effect for other travel modes.
    abstract transitOptions: Google.Maps.TransitOptions option with get, set
    /// Type of routing requested. Required.
    abstract travelMode: Google.Maps.TravelMode with get, set
    /// Preferred unit system to use when displaying distance. Optional; defaults
    /// to metric.
    abstract unitSystem: Google.Maps.UnitSystem option with get, set

/// The response to a &lt;code&gt;DistanceMatrixService&lt;/code&gt; request, consisting of
/// the formatted origin and destination addresses, and a sequence of
/// &lt;code&gt;DistanceMatrixResponseRow&lt;/code&gt;s, one for each corresponding origin
/// address.
type [<AllowNullLiteral>] DistanceMatrixResponse =
    /// The formatted destination addresses.
    abstract destinationAddresses: ResizeArray<string> with get, set
    /// The formatted origin addresses.
    abstract originAddresses: ResizeArray<string> with get, set
    /// The rows of the matrix, corresponding to the origin addresses.
    abstract rows: ResizeArray<Google.Maps.DistanceMatrixResponseRow> with get, set

/// A single element of a response to a &lt;code&gt;DistanceMatrixService&lt;/code&gt;
/// request, which contains the duration and distance from one origin to one
/// destination.
type [<AllowNullLiteral>] DistanceMatrixResponseElement =
    /// The distance for this origin-destination pairing. This property may be
    /// undefined as the distance may be unknown.
    abstract distance: Google.Maps.Distance with get, set
    /// The duration for this origin-destination pairing. This property may be
    /// undefined as the duration may be unknown.
    abstract duration: Google.Maps.Duration with get, set
    /// The duration for this origin-destination pairing, taking into account the
    /// traffic conditions indicated by the &lt;code&gt;trafficModel&lt;/code&gt; property.
    /// This property may be &lt;code&gt;undefined&lt;/code&gt; as the duration may be
    /// unknown. Only available to Premium Plan customers when
    /// &lt;code&gt;drivingOptions&lt;/code&gt; is defined when making the request.
    abstract duration_in_traffic: Google.Maps.Duration with get, set
    /// The total fare for this origin-destination pairing. Only applicable to
    /// transit requests.
    abstract fare: Google.Maps.TransitFare with get, set
    /// The status of this particular origin-destination pairing.
    abstract status: Google.Maps.DistanceMatrixElementStatus with get, set

/// A row of the response to a &lt;code&gt;DistanceMatrixService&lt;/code&gt; request,
/// consisting of a sequence of &lt;code&gt;DistanceMatrixResponseElement&lt;/code&gt;s,
/// one for each corresponding destination address.
type [<AllowNullLiteral>] DistanceMatrixResponseRow =
    /// The row&#39;s elements, corresponding to the destination addresses.
    abstract elements: ResizeArray<Google.Maps.DistanceMatrixResponseElement> with get, set

/// <summary>
/// A service for computing distances between multiple origins and
/// destinations.
///
/// Access by calling `const {DistanceMatrixService} = await
/// google.maps.importLibrary("routes")`. See
/// <see href="https://developers.google.com/maps/documentation/javascript/libraries." />
/// </summary>
type [<AllowNullLiteral>] DistanceMatrixService =
    /// Issues a distance matrix request.
    abstract getDistanceMatrix: request: Google.Maps.DistanceMatrixRequest * ?callback: (Google.Maps.DistanceMatrixResponse option -> Google.Maps.DistanceMatrixStatus -> unit) -> Promise<Google.Maps.DistanceMatrixResponse>

/// <summary>
/// A service for computing distances between multiple origins and
/// destinations.
///
/// Access by calling `const {DistanceMatrixService} = await
/// google.maps.importLibrary("routes")`. See
/// <see href="https://developers.google.com/maps/documentation/javascript/libraries." />
/// </summary>
type [<AllowNullLiteral>] DistanceMatrixServiceStatic =
    [<EmitConstructor>] abstract Create: unit -> DistanceMatrixService

/// <summary>
/// The top-level status about the request in general returned by the
/// &lt;code&gt;DistanceMatrixService&lt;/code&gt; upon completion of a distance matrix
/// request. Specify these by value, or by using the constant&amp;#39;s name. For
/// example, &lt;code&gt;'OK'&lt;/code&gt; or
/// &lt;code&gt;google.maps.DistanceMatrixStatus.OK&lt;/code&gt;.
///
/// Access by calling `const {DistanceMatrixStatus} = await
/// google.maps.importLibrary("routes")`. See
/// <see href="https://developers.google.com/maps/documentation/javascript/libraries." />
/// </summary>
type [<StringEnum>] [<RequireQualifiedAccess>] DistanceMatrixStatus =
    /// The provided request was invalid.
    | [<CompiledName("INVALID_REQUEST")>] INVALID_REQUEST
    /// The request contains more than 25 origins, or more than 25 destinations.
    | [<CompiledName("MAX_DIMENSIONS_EXCEEDED")>] MAX_DIMENSIONS_EXCEEDED
    /// The product of origins and destinations exceeds the per-query limit.
    | [<CompiledName("MAX_ELEMENTS_EXCEEDED")>] MAX_ELEMENTS_EXCEEDED
    /// The response contains a valid result.
    | [<CompiledName("OK")>] OK
    /// Too many elements have been requested within the allowed time period. The
    /// request should succeed if you try again after some time.
    | [<CompiledName("OVER_QUERY_LIMIT")>] OVER_QUERY_LIMIT
    /// The service denied use of the Distance Matrix service by your web page.
    | [<CompiledName("REQUEST_DENIED")>] REQUEST_DENIED
    /// A Distance Matrix request could not be processed due to a server error.
    /// The request may succeed if you try again.
    | [<CompiledName("UNKNOWN_ERROR")>] UNKNOWN_ERROR

type [<AllowNullLiteral>] DrawingLibrary =
    abstract DrawingManager: obj with get, set
    abstract OverlayType: obj with get, set

/// Configures the &lt;code&gt;&lt;a
/// href="#DirectionsRequest"&gt;DirectionsRequest&lt;/a&gt;&lt;/code&gt; when the travel mode
/// is set to &lt;code&gt;DRIVING&lt;/code&gt;.
type [<AllowNullLiteral>] DrivingOptions =
    /// The desired departure time for the route, specified as a
    /// &lt;code&gt;Date&lt;/code&gt; object. The &lt;code&gt;Date&lt;/code&gt; object measures time in
    /// milliseconds since 1 January 1970. This must be specified for a
    /// &lt;code&gt;DrivingOptions&lt;/code&gt; to be valid. The departure time must be set
    /// to the current time or some time in the future. It cannot be in the past.
    abstract departureTime: DateTime with get, set
    /// The preferred assumption to use when predicting duration in traffic. The
    /// default is &lt;code&gt;BEST_GUESS&lt;/code&gt;.
    abstract trafficModel: Google.Maps.TrafficModel option with get, set

/// A representation of duration as a numeric value and a display string.
type [<AllowNullLiteral>] Duration =
    /// A string representation of the duration value.
    abstract text: string with get, set
    /// The duration in seconds.
    abstract value: float with get, set

type [<AllowNullLiteral>] ElevationLibrary =
    abstract ElevationService: obj with get, set
    abstract ElevationStatus: obj with get, set

/// The result of an &lt;code&gt;ElevationService&lt;/code&gt; request, consisting of the
/// set of elevation coordinates and their elevation values. Note that a single
/// request may produce multiple &lt;code&gt;ElevationResult&lt;/code&gt;s.
type [<AllowNullLiteral>] ElevationResult =
    /// The elevation of this point on Earth, in meters above sea level.
    abstract elevation: float with get, set
    /// The location of this elevation result.
    abstract location: Google.Maps.LatLng option with get, set
    /// The distance, in meters, between sample points from which the elevation
    /// was interpolated. This property will be missing if the resolution is not
    /// known. Note that elevation data becomes more coarse (larger
    /// &lt;code&gt;resolution&lt;/code&gt; values) when multiple points are passed. To
    /// obtain the most accurate elevation value for a point, it should be
    /// queried independently.
    abstract resolution: float with get, set

/// <summary>
/// Defines a service class that talks directly to Google servers for
/// requesting elevation data.
///
/// Access by calling `const {ElevationService} = await
/// google.maps.importLibrary("elevation")`. See
/// <see href="https://developers.google.com/maps/documentation/javascript/libraries." />
/// </summary>
type [<AllowNullLiteral>] ElevationService =
    /// Makes an elevation request along a path, where the elevation data are
    /// returned as distance-based samples along that path.
    abstract getElevationAlongPath: request: Google.Maps.PathElevationRequest * ?callback: (ResizeArray<Google.Maps.ElevationResult> option -> Google.Maps.ElevationStatus -> unit) -> Promise<Google.Maps.PathElevationResponse>
    /// Makes an elevation request for a list of discrete locations.
    abstract getElevationForLocations: request: Google.Maps.LocationElevationRequest * ?callback: (ResizeArray<Google.Maps.ElevationResult> option -> Google.Maps.ElevationStatus -> unit) -> Promise<Google.Maps.LocationElevationResponse>

/// <summary>
/// Defines a service class that talks directly to Google servers for
/// requesting elevation data.
///
/// Access by calling `const {ElevationService} = await
/// google.maps.importLibrary("elevation")`. See
/// <see href="https://developers.google.com/maps/documentation/javascript/libraries." />
/// </summary>
type [<AllowNullLiteral>] ElevationServiceStatic =
    [<EmitConstructor>] abstract Create: unit -> ElevationService

/// <summary>
/// The status returned by the &lt;code&gt;ElevationService&lt;/code&gt; upon completion of
/// an elevation request. Specify these by value, or by using the
/// constant&amp;#39;s name. For example, &lt;code&gt;'OK'&lt;/code&gt; or
/// &lt;code&gt;google.maps.ElevationStatus.OK&lt;/code&gt;.
///
/// Access by calling `const {ElevationStatus} = await
/// google.maps.importLibrary("elevation")`. See
/// <see href="https://developers.google.com/maps/documentation/javascript/libraries." />
/// </summary>
type [<StringEnum>] [<RequireQualifiedAccess>] ElevationStatus =
    /// The request was invalid.
    | [<CompiledName("INVALID_REQUEST")>] INVALID_REQUEST
    /// The request did not encounter any errors.
    | [<CompiledName("OK")>] OK
    /// The webpage has gone over the requests limit in too short a period of
    /// time.
    | [<CompiledName("OVER_QUERY_LIMIT")>] OVER_QUERY_LIMIT
    /// The webpage is not allowed to use the elevation service.
    | [<CompiledName("REQUEST_DENIED")>] REQUEST_DENIED
    /// The elevation request could not be successfully processed, yet the exact
    /// reason for the failure is not known.
    | [<CompiledName("UNKNOWN_ERROR")>] UNKNOWN_ERROR

/// An event with an associated Error.
type [<AllowNullLiteral>] ErrorEvent =
    /// The Error related to the event.
    abstract error: Error with get, set

/// An interface representing a vector map tile feature. These are inputs to
/// the &lt;code&gt;FeatureStyleFunction&lt;/code&gt;. Do not save a reference to a
/// particular &lt;code&gt;Feature&lt;/code&gt; object because the reference will not be
/// stable.
type [<AllowNullLiteral>] Feature =
    /// &lt;code&gt;FeatureType&lt;/code&gt; of this &lt;code&gt;Feature&lt;/code&gt;.
    abstract featureType: Google.Maps.FeatureType with get, set

/// <summary>
/// An interface representing a map layer containing features of a
/// specific <see cref="google.maps.FeatureType" /> whose style can be overridden
/// client-side, or have events attached.
/// </summary>
type [<AllowNullLiteral>] FeatureLayer =
    /// <summary>
    /// Adds the given listener function to the given event name. Returns an
    /// identifier for this listener that can be used with <see cref="*">google.maps.event.removeListener</see>.
    /// </summary>
    /// <param name="eventName">Observed event.</param>
    /// <param name="handler">Function to handle events.</param>
    abstract addListener: eventName: string * handler: Function -> Google.Maps.MapsEventListener
    /// <summary>
    /// Available only in the v=beta channel: <see href="https://goo.gle/3oAthT3." />
    /// The Dataset ID for this &lt;code&gt;FeatureLayer&lt;/code&gt;. Only present if the
    /// &lt;code&gt;featureType&lt;/code&gt; is &lt;code&gt;FeatureType.DATASET&lt;/code&gt;.
    /// </summary>
    abstract datasetId: string option with get, set
    /// The &lt;code&gt;FeatureType&lt;/code&gt; associated with this
    /// &lt;code&gt;FeatureLayer&lt;/code&gt;.
    abstract featureType: Google.Maps.FeatureType with get, set
    /// Whether this &lt;code&gt;FeatureLayer&lt;/code&gt; is available, meaning whether
    /// Data-driven styling is available for this map (there is a map ID using
    /// vector tiles with this &lt;code&gt;FeatureLayer&lt;/code&gt; enabled in the Google
    /// Cloud Console map style.) If this is false (or becomes false), styling on
    /// this &lt;code&gt;FeatureLayer&lt;/code&gt; returns to default and events are not
    /// triggered.
    abstract isAvailable: bool with get, set
    /// The style of &lt;code&gt;Feature&lt;/code&gt;s in the &lt;code&gt;FeatureLayer&lt;/code&gt;. The
    /// style is applied when style is set. If your style function updates, you
    /// must set the style property again. A &lt;code&gt;FeatureStyleFunction&lt;/code&gt;
    /// must return consistent results when it is applied over the map tiles, and
    /// should be optimized for performance. Asynchronous functions are not
    /// supported. If you use a &lt;code&gt;FeatureStyleOptions&lt;/code&gt;, all features of
    /// that layer will be styled with the same &lt;code&gt;FeatureStyleOptions&lt;/code&gt;.
    /// Set the style to &lt;code&gt;null&lt;/code&gt; to remove the previously set style. If
    /// this &lt;code&gt;FeatureLayer&lt;/code&gt; is not available, setting style does
    /// nothing and logs an error.
    abstract style: U2<Google.Maps.FeatureStyleOptions, Google.Maps.FeatureStyleFunction> option with get, set

/// This object is returned from a mouse event on a &lt;code&gt;FeatureLayer&lt;/code&gt;.
type [<AllowNullLiteral>] FeatureMouseEvent =
    inherit Google.Maps.MapMouseEvent
    /// The &lt;code&gt;Feature&lt;/code&gt;s at this mouse event.
    abstract features: ResizeArray<Google.Maps.Feature> with get, set

type [<AllowNullLiteral>] FeatureStyleFunction =
    [<Emit("$0($1...)")>] abstract Invoke: a: Google.Maps.FeatureStyleFunctionOptions -> Google.Maps.FeatureStyleOptions option

/// Options passed to a &lt;code&gt;FeatureStyleFunction&lt;/code&gt;.
type [<AllowNullLiteral>] FeatureStyleFunctionOptions =
    /// &lt;code&gt;Feature&lt;/code&gt; passed into the &lt;code&gt;FeatureStyleFunction&lt;/code&gt;
    /// for styling.
    abstract feature: Google.Maps.Feature with get, set

/// These options specify the way the style of a &lt;code&gt;Feature&lt;/code&gt; should be
/// modified on a map.
type [<AllowNullLiteral>] FeatureStyleOptions =
    /// Hex RGB string (like &quot;#00FF00&quot; for green). Only applies to
    /// polygon geometries.
    abstract fillColor: string option with get, set
    /// The fill opacity between 0.0 and 1.0. Only applies to polygon geometries.
    abstract fillOpacity: float option with get, set
    /// Hex RGB string (like &quot;#00FF00&quot; for green).
    abstract strokeColor: string option with get, set
    /// The stroke opacity between 0.0 and 1.0. Only applies to line and polygon
    /// geometries.
    abstract strokeOpacity: float option with get, set
    /// The stroke width in pixels. Only applies to line and polygon geometries.
    abstract strokeWeight: float option with get, set

/// <summary>
/// Identifiers for feature types.
///
/// Access by calling `const {FeatureType} = await
/// google.maps.importLibrary("maps")`. See
/// <see href="https://developers.google.com/maps/documentation/javascript/libraries." />
/// </summary>
type [<StringEnum>] [<RequireQualifiedAccess>] FeatureType =
    /// Indicates a first-order civil entity below the country level.
    | [<CompiledName("ADMINISTRATIVE_AREA_LEVEL_1")>] ADMINISTRATIVE_AREA_LEVEL_1
    /// Indicates a second-order civil entity below the country level.
    | [<CompiledName("ADMINISTRATIVE_AREA_LEVEL_2")>] ADMINISTRATIVE_AREA_LEVEL_2
    /// Indicates the national political entity.
    | [<CompiledName("COUNTRY")>] COUNTRY
    /// Indicates a third-party dataset.
    | [<CompiledName("DATASET")>] DATASET
    /// Indicates an incorporated city or town political entity.
    | [<CompiledName("LOCALITY")>] LOCALITY
    /// Indicates a postal code as used to address postal mail within the
    /// country.
    | [<CompiledName("POSTAL_CODE")>] POSTAL_CODE
    /// Indicates a school district.
    | [<CompiledName("SCHOOL_DISTRICT")>] SCHOOL_DISTRICT

/// Options for the rendering of the fullscreen control.
type [<AllowNullLiteral>] FullscreenControlOptions =
    /// <summary>Position id. Used to specify the position of the control on the map.</summary>
    /// <default><see cref="google.maps.ControlPosition.INLINE_END_BLOCK_START" /></default>
    abstract position: Google.Maps.ControlPosition option with get, set

/// <summary>
/// A service for converting between an address and a &lt;code&gt;LatLng&lt;/code&gt;.
///
/// Access by calling `const {Geocoder} = await
/// google.maps.importLibrary("geocoding")`. See
/// <see href="https://developers.google.com/maps/documentation/javascript/libraries." />
/// </summary>
type [<AllowNullLiteral>] Geocoder =
    /// Geocode a request.
    abstract geocode: request: Google.Maps.GeocoderRequest * ?callback: (ResizeArray<Google.Maps.GeocoderResult> option -> Google.Maps.GeocoderStatus -> unit) -> Promise<Google.Maps.GeocoderResponse>

/// <summary>
/// A service for converting between an address and a &lt;code&gt;LatLng&lt;/code&gt;.
///
/// Access by calling `const {Geocoder} = await
/// google.maps.importLibrary("geocoding")`. See
/// <see href="https://developers.google.com/maps/documentation/javascript/libraries." />
/// </summary>
type [<AllowNullLiteral>] GeocoderStatic =
    [<EmitConstructor>] abstract Create: unit -> Geocoder

/// A single address component within a &lt;code&gt;GeocoderResult&lt;/code&gt;. A full
/// address may consist of multiple address components.
type [<AllowNullLiteral>] GeocoderAddressComponent =
    /// The full text of the address component
    abstract long_name: string with get, set
    /// The abbreviated, short text of the given address component
    abstract short_name: string with get, set
    /// <summary>
    /// An array of strings denoting the type of this address component. A list
    /// of valid types can be found &lt;a
    /// href="<see href="https://developers.google.com/maps/documentation/javascript/geocoding#GeocodingAddressTypes"&gt;here&lt;/a&gt;" />
    /// </summary>
    abstract types: ResizeArray<string> with get, set

/// <summary>
/// &lt;code&gt;GeocoderComponentRestrictions&lt;/code&gt; represents a set of filters that
/// resolve to a specific area. For details on how this works, see &lt;a
/// href="<see href="https://developers.google.com/maps/documentation/javascript/geocoding#ComponentFiltering"&gt;" />
/// Geocoding Component Filtering&lt;/a&gt;.
/// </summary>
type [<AllowNullLiteral>] GeocoderComponentRestrictions =
    /// Matches all the &lt;code&gt;administrative_area levels&lt;/code&gt;. Optional.
    abstract administrativeArea: string option with get, set
    /// Matches a country name or a two letter ISO 3166-1 country code. Optional.
    abstract country: string option with get, set
    /// Matches against both &lt;code&gt;locality&lt;/code&gt; and &lt;code&gt;sublocality&lt;/code&gt;
    /// types. Optional.
    abstract locality: string option with get, set
    /// Matches &lt;code&gt;postal_code&lt;/code&gt; and &lt;code&gt;postal_code_prefix&lt;/code&gt;.
    /// Optional.
    abstract postalCode: string option with get, set
    /// Matches the long or short name of a &lt;code&gt;route&lt;/code&gt;. Optional.
    abstract route: string option with get, set

/// Geometry information about this &lt;code&gt;GeocoderResult&lt;/code&gt;
type [<AllowNullLiteral>] GeocoderGeometry =
    /// The precise bounds of this &lt;code&gt;GeocoderResult&lt;/code&gt;, if applicable
    abstract bounds: Google.Maps.LatLngBounds option with get, set
    /// The latitude/longitude coordinates of this result
    abstract location: Google.Maps.LatLng with get, set
    /// The type of location returned in &lt;code&gt;location&lt;/code&gt;
    abstract location_type: Google.Maps.GeocoderLocationType with get, set
    /// The bounds of the recommended viewport for displaying this
    /// &lt;code&gt;GeocoderResult&lt;/code&gt;
    abstract viewport: Google.Maps.LatLngBounds with get, set

/// <summary>
/// Describes the type of location returned from a geocode. Specify these by
/// value, or by using the constant&amp;#39;s name. For example,
/// &lt;code&gt;'ROOFTOP'&lt;/code&gt; or
/// &lt;code&gt;google.maps.GeocoderLocationType.ROOFTOP&lt;/code&gt;.
///
/// Access by calling `const {GeocoderLocationType} = await
/// google.maps.importLibrary("geocoding")`. See
/// <see href="https://developers.google.com/maps/documentation/javascript/libraries." />
/// </summary>
type [<StringEnum>] [<RequireQualifiedAccess>] GeocoderLocationType =
    /// The returned result is approximate.
    | [<CompiledName("APPROXIMATE")>] APPROXIMATE
    /// The returned result is the geometric center of a result such a line (e.g.
    /// street) or polygon (region).
    | [<CompiledName("GEOMETRIC_CENTER")>] GEOMETRIC_CENTER
    /// The returned result reflects an approximation (usually on a road)
    /// interpolated between two precise points (such as intersections).
    /// Interpolated results are generally returned when rooftop geocodes are
    /// unavailable for a street address.
    | [<CompiledName("RANGE_INTERPOLATED")>] RANGE_INTERPOLATED
    /// The returned result reflects a precise geocode.
    | [<CompiledName("ROOFTOP")>] ROOFTOP

/// The specification for a geocoding request to be sent to the
/// &lt;code&gt;Geocoder&lt;/code&gt;.
type [<AllowNullLiteral>] GeocoderRequest =
    /// Address to geocode. One, and only one, of &lt;code&gt;address&lt;/code&gt;,
    /// &lt;code&gt;location&lt;/code&gt; and &lt;code&gt;placeId&lt;/code&gt; must be supplied.
    abstract address: string option with get, set
    /// &lt;code&gt;LatLngBounds&lt;/code&gt; within which to search. Optional.
    abstract bounds: U2<Google.Maps.LatLngBounds, Google.Maps.LatLngBoundsLiteral> option with get, set
    /// Components are used to restrict results to a specific area. A filter
    /// consists of one or more of: &lt;code&gt;route&lt;/code&gt;, &lt;code&gt;locality&lt;/code&gt;,
    /// &lt;code&gt;administrativeArea&lt;/code&gt;, &lt;code&gt;postalCode&lt;/code&gt;,
    /// &lt;code&gt;country&lt;/code&gt;. Only the results that match all the filters will be
    /// returned. Filter values support the same methods of spelling correction
    /// and partial matching as other geocoding requests. Optional.
    abstract componentRestrictions: Google.Maps.GeocoderComponentRestrictions option with get, set
    /// <summary>
    /// A language identifier for the language in which results should be
    /// returned, when possible. See the &lt;a
    /// href="<see href="https://developers.google.com/maps/faq#languagesupport"&gt;list" /> of
    /// supported languages&lt;/a&gt;.
    /// </summary>
    abstract language: string option with get, set
    /// <summary>
    /// &lt;code&gt;LatLng&lt;/code&gt; (or &lt;code&gt;LatLngLiteral&lt;/code&gt;) for which to search.
    /// The geocoder performs a reverse geocode. See &lt;a
    /// href="<see href="https://developers.google.com/maps/documentation/javascript/geocoding#ReverseGeocoding"&gt;" />
    /// Reverse Geocoding&lt;/a&gt; for more information. One, and only one, of
    /// &lt;code&gt;address&lt;/code&gt;, &lt;code&gt;location&lt;/code&gt; and &lt;code&gt;placeId&lt;/code&gt; must
    /// be supplied.
    /// </summary>
    abstract location: U2<Google.Maps.LatLng, Google.Maps.LatLngLiteral> option with get, set
    /// <summary>
    /// The place ID associated with the location. Place IDs uniquely identify a
    /// place in the Google Places database and on Google Maps. Learn more about
    /// &lt;a
    /// href="<see href="https://developers.google.com/maps/documentation/places/web-service/place-id"&gt;place" />
    /// IDs&lt;/a&gt; in the Places API developer guide. The geocoder performs a
    /// reverse geocode. See &lt;a
    /// href="<see href="https://developers.google.com/maps/documentation/javascript/geocoding#ReverseGeocoding"&gt;Reverse" />
    /// Geocoding&lt;/a&gt; for more information. One, and only one, of
    /// &lt;code&gt;address&lt;/code&gt;, &lt;code&gt;location&lt;/code&gt; and &lt;code&gt;placeId&lt;/code&gt; must
    /// be supplied.
    /// </summary>
    abstract placeId: string option with get, set
    /// <summary>
    /// Country code used to bias the search, specified as a two-character
    /// (non-numeric) Unicode region subtag / CLDR identifier. Optional. See &lt;a
    /// href="<see href="http://developers.google.com/maps/coverage"&gt;Google" /> Maps Platform
    /// Coverage Details&lt;/a&gt; for supported regions.
    /// </summary>
    abstract region: string option with get, set

/// <summary>
/// A Geocoder response returned by the <see cref="google.maps.Geocoder" /> containing
/// the list of <see cref="google.maps.GeocoderResult" />s.
/// </summary>
type [<AllowNullLiteral>] GeocoderResponse =
    /// <summary>The list of <see cref="google.maps.GeocoderResult" />s.</summary>
    abstract results: ResizeArray<Google.Maps.GeocoderResult> with get, set

/// A single geocoder result retrieved from the geocode server. A geocode
/// request may return multiple result objects. Note that though this result is
/// &amp;quot;JSON-like,&amp;quot; it is not strictly JSON, as it indirectly includes a
/// &lt;code&gt;LatLng&lt;/code&gt; object.
type [<AllowNullLiteral>] GeocoderResult =
    /// An array of &lt;code&gt;GeocoderAddressComponent&lt;/code&gt;s
    abstract address_components: ResizeArray<Google.Maps.GeocoderAddressComponent> with get, set
    /// A string containing the human-readable address of this location.
    abstract formatted_address: string with get, set
    /// A &lt;code&gt;GeocoderGeometry&lt;/code&gt; object
    abstract geometry: Google.Maps.GeocoderGeometry with get, set
    /// Whether the geocoder did not return an exact match for the original
    /// request, though it was able to match part of the requested address. If an
    /// exact match, the value will be &lt;code&gt;undefined&lt;/code&gt;.
    abstract partial_match: bool option with get, set
    /// <summary>
    /// The place ID associated with the location. Place IDs uniquely identify a
    /// place in the Google Places database and on Google Maps. Learn more about
    /// &lt;a
    /// href="<see href="https://developers.google.com/maps/documentation/places/web-service/place-id"&gt;Place" />
    /// IDs&lt;/a&gt; in the Places API developer guide.
    /// </summary>
    abstract place_id: string with get, set
    /// The plus code associated with the location.
    abstract plus_code: Google.Maps.Places.PlacePlusCode option with get, set
    /// An array of strings denoting all the localities contained in a postal
    /// code. This is only present when the result is a postal code that contains
    /// multiple localities.
    abstract postcode_localities: ResizeArray<string> option with get, set
    /// <summary>
    /// An array of strings denoting the type of the returned geocoded element.
    /// For a list of possible strings, refer to the &lt;a href=
    /// "<see href="https://developers.google.com/maps/documentation/javascript/geocoding#GeocodingAddressTypes"&gt;" />
    /// Address Component Types&lt;/a&gt; section of the Developer&amp;#39;s Guide.
    /// </summary>
    abstract types: ResizeArray<string> with get, set

/// <summary>
/// The status returned by the &lt;code&gt;Geocoder&lt;/code&gt; on the completion of a
/// call to &lt;code&gt;geocode()&lt;/code&gt;. Specify these by value, or by using the
/// constant&amp;#39;s name. For example, &lt;code&gt;'OK'&lt;/code&gt; or
/// &lt;code&gt;google.maps.GeocoderStatus.OK&lt;/code&gt;.
///
/// Access by calling `const {GeocoderStatus} = await
/// google.maps.importLibrary("geocoding")`. See
/// <see href="https://developers.google.com/maps/documentation/javascript/libraries." />
/// </summary>
type [<StringEnum>] [<RequireQualifiedAccess>] GeocoderStatus =
    /// There was a problem contacting the Google servers.
    | [<CompiledName("ERROR")>] ERROR
    /// This &lt;code&gt;GeocoderRequest&lt;/code&gt; was invalid.
    | [<CompiledName("INVALID_REQUEST")>] INVALID_REQUEST
    /// The response contains a valid &lt;code&gt;GeocoderResponse&lt;/code&gt;.
    | [<CompiledName("OK")>] OK
    /// The webpage has gone over the requests limit in too short a period of
    /// time.
    | [<CompiledName("OVER_QUERY_LIMIT")>] OVER_QUERY_LIMIT
    /// The webpage is not allowed to use the geocoder.
    | [<CompiledName("REQUEST_DENIED")>] REQUEST_DENIED
    /// A geocoding request could not be processed due to a server error. The
    /// request may succeed if you try again.
    | [<CompiledName("UNKNOWN_ERROR")>] UNKNOWN_ERROR
    /// No result was found for this &lt;code&gt;GeocoderRequest&lt;/code&gt;.
    | [<CompiledName("ZERO_RESULTS")>] ZERO_RESULTS

type [<AllowNullLiteral>] GeocodingLibrary =
    abstract Geocoder: obj with get, set
    abstract GeocoderLocationType: obj with get, set
    abstract GeocoderStatus: obj with get, set

type [<AllowNullLiteral>] GeometryLibrary =
    abstract encoding: obj with get, set
    abstract poly: obj with get, set
    abstract spherical: obj with get, set

/// <summary>
/// A rectangular image overlay on the map.
///
/// Access by calling `const {GroundOverlay} = await
/// google.maps.importLibrary("maps")`. See
/// <see href="https://developers.google.com/maps/documentation/javascript/libraries." />
/// </summary>
type [<AllowNullLiteral>] GroundOverlay =
    inherit Google.Maps.MVCObject
    /// Gets the &lt;code&gt;LatLngBounds&lt;/code&gt; of this overlay.
    abstract getBounds: unit -> Google.Maps.LatLngBounds option
    /// Returns the map on which this ground overlay is displayed.
    abstract getMap: unit -> Google.Maps.Map option
    /// Returns the opacity of this ground overlay.
    abstract getOpacity: unit -> float
    /// Gets the url of the projected image.
    abstract getUrl: unit -> string
    /// Renders the ground overlay on the specified map. If map is set to
    /// &lt;code&gt;null&lt;/code&gt;, the overlay is removed.
    abstract setMap: map: Google.Maps.Map option -> unit
    /// Sets the opacity of this ground overlay.
    abstract setOpacity: opacity: float -> unit

/// <summary>
/// A rectangular image overlay on the map.
///
/// Access by calling `const {GroundOverlay} = await
/// google.maps.importLibrary("maps")`. See
/// <see href="https://developers.google.com/maps/documentation/javascript/libraries." />
/// </summary>
type [<AllowNullLiteral>] GroundOverlayStatic =
    /// <summary>
    /// A rectangular image overlay on the map.
    ///
    /// Access by calling `const {GroundOverlay} = await
    /// google.maps.importLibrary("maps")`. See
    /// <see href="https://developers.google.com/maps/documentation/javascript/libraries." />
    /// </summary>
    [<EmitConstructor>] abstract Create: url: string * bounds: U2<Google.Maps.LatLngBounds, Google.Maps.LatLngBoundsLiteral> option * ?opts: Google.Maps.GroundOverlayOptions -> GroundOverlay

/// This object defines the properties that can be set on a
/// &lt;code&gt;GroundOverlay&lt;/code&gt; object.
type [<AllowNullLiteral>] GroundOverlayOptions =
    /// If &lt;code&gt;true&lt;/code&gt;, the ground overlay can receive mouse events.
    abstract clickable: bool option with get, set
    /// The map on which to display the overlay.
    abstract map: Google.Maps.Map option with get, set
    /// <summary>
    /// The opacity of the overlay, expressed as a number between 0 and 1.
    /// Optional.
    /// </summary>
    /// <default>&lt;code&gt;1.0&lt;/code&gt;</default>
    abstract opacity: float option with get, set

/// A structure representing a Marker icon image.
type [<AllowNullLiteral>] Icon =
    /// The position at which to anchor an image in correspondence to the
    /// location of the marker on the map. By default, the anchor is located
    /// along the center point of the bottom of the image.
    abstract anchor: Google.Maps.Point option with get, set
    /// The origin of the label relative to the top-left corner of the icon
    /// image, if a label is supplied by the marker. By default, the origin is
    /// located in the center point of the image.
    abstract labelOrigin: Google.Maps.Point option with get, set
    /// The position of the image within a sprite, if any. By default, the origin
    /// is located at the top left corner of the image &lt;code&gt;(0, 0)&lt;/code&gt;.
    abstract origin: Google.Maps.Point option with get, set
    /// The size of the entire image after scaling, if any. Use this property to
    /// stretch/shrink an image or a sprite.
    abstract scaledSize: Google.Maps.Size option with get, set
    /// The display size of the sprite or image. When using sprites, you must
    /// specify the sprite size. If the size is not provided, it will be set when
    /// the image loads.
    abstract size: Google.Maps.Size option with get, set
    /// The URL of the image or sprite sheet.
    abstract url: string with get, set

/// <summary>
/// This object is sent in an event when a user clicks on an icon on the map.
/// The place ID of this place is stored in the placeId member. To prevent the
/// default info window from showing up, call the stop() method on this event
/// to prevent it being propagated. Learn more about &lt;a
/// href="<see href="https://developers.google.com/maps/documentation/places/web-service/place-id"&gt;place" />
/// IDs&lt;/a&gt; in the Places API developer guide.
/// </summary>
type [<AllowNullLiteral>] IconMouseEvent =
    inherit Google.Maps.MapMouseEvent
    /// <summary>
    /// The place ID of the place that was clicked. This place ID can be used to
    /// query more information about the feature that was clicked. &lt;p&gt; Learn more
    /// about &lt;a
    /// href="<see href="https://developers.google.com/maps/documentation/places/web-service/place-id"&gt;place" />
    /// IDs&lt;/a&gt; in the Places API developer guide.
    /// </summary>
    abstract placeId: string option with get, set

/// Describes how icons are to be rendered on a line. <br><br> If your polyline
/// is geodesic, then the distances specified for both offset and repeat are
/// calculated in meters by default. Setting either offset or repeat to a pixel
/// value will cause the distances to be calculated in pixels on the screen.
type [<AllowNullLiteral>] IconSequence =
    /// <summary>
    /// If &lt;code&gt;true&lt;/code&gt;, each icon in the sequence has the same fixed
    /// rotation regardless of the angle of the edge on which it lies. If
    /// &lt;code&gt;false&lt;/code&gt;, case each icon in the sequence is rotated to align
    /// with its edge.
    /// </summary>
    /// <default>&lt;code&gt;false&lt;/code&gt;</default>
    abstract fixedRotation: bool option with get, set
    /// The icon to render on the line.
    abstract icon: Google.Maps.Symbol option with get, set
    /// <summary>
    /// The distance from the start of the line at which an icon is to be
    /// rendered. This distance may be expressed as a percentage of line&amp;#39;s
    /// length (e.g.
    /// &amp;#39;50%&amp;#39;) or in pixels (e.g. &amp;#39;50px&amp;#39;).
    /// </summary>
    /// <default>&lt;code&gt;&amp;#39;100%&amp;#39;&lt;/code&gt;</default>
    abstract offset: string option with get, set
    /// <summary>
    /// The distance between consecutive icons on the line. This distance may be
    /// expressed as a percentage of the line&amp;#39;s length (e.g. &amp;#39;50%&amp;#39;)
    /// or in pixels (e.g. &amp;#39;50px&amp;#39;). To disable repeating of the icon,
    /// specify
    /// &amp;#39;0&amp;#39;.
    /// </summary>
    /// <default>&lt;code&gt;0&lt;/code&gt;</default>
    abstract repeat: string option with get, set

/// <summary>
/// This class implements the MapType interface and is provided for rendering
/// image tiles.
///
/// Access by calling `const {ImageMapType} = await
/// google.maps.importLibrary("maps")`. See
/// <see href="https://developers.google.com/maps/documentation/javascript/libraries." />
/// </summary>
type [<AllowNullLiteral>] ImageMapType =
    inherit Google.Maps.MVCObject
    inherit Google.Maps.MapType
    /// Alt text to display when this MapType&#39;s button is hovered over in the
    /// MapTypeControl. Optional.
    abstract alt: string option with get, set
    /// Returns the opacity level (&lt;code&gt;0&lt;/code&gt; (transparent) to
    /// &lt;code&gt;1.0&lt;/code&gt;) of the &lt;code&gt;ImageMapType&lt;/code&gt; tiles.
    abstract getOpacity: unit -> float
    /// <summary>
    /// Returns a tile for the given tile coordinate (x, y) and zoom level. This
    /// tile will be appended to the given ownerDocument. Not available for base
    /// map types.
    /// </summary>
    /// <param name="tileCoord">Tile coordinates.</param>
    /// <param name="zoom">Tile zoom.</param>
    /// <param name="ownerDocument">The document which owns this tile.</param>
    abstract getTile: tileCoord: Google.Maps.Point option * zoom: float * ownerDocument: Document option -> Element option
    /// The maximum zoom level for the map when displaying this MapType. Required
    /// for base MapTypes, ignored for overlay MapTypes.
    abstract maxZoom: float with get, set
    /// The minimum zoom level for the map when displaying this MapType.
    /// Optional; defaults to 0.
    abstract minZoom: float with get, set
    /// Name to display in the MapTypeControl. Optional.
    abstract name: string option with get, set
    /// The Projection used to render this MapType. Optional; defaults to
    /// Mercator.
    abstract projection: Google.Maps.Projection option with get, set
    /// Radius of the planet for the map, in meters. Optional; defaults to
    /// Earth&#39;s equatorial radius of 6378137 meters.
    abstract radius: float with get, set
    /// <summary>
    /// Releases the given tile, performing any necessary cleanup. The provided
    /// tile will have already been removed from the document. Optional.
    /// </summary>
    /// <param name="tileDiv">Tile to release.</param>
    abstract releaseTile: tileDiv: Element option -> unit
    /// <summary>
    /// Sets the opacity level (&lt;code&gt;0&lt;/code&gt; (transparent) to &lt;code&gt;1.0&lt;/code&gt;)
    /// of the &lt;code&gt;ImageMapType&lt;/code&gt; tiles.
    /// </summary>
    /// <param name="opacity">The new opacity.</param>
    abstract setOpacity: opacity: float -> unit
    /// The dimensions of each tile. Required.
    abstract tileSize: Google.Maps.Size option with get, set

/// <summary>
/// This class implements the MapType interface and is provided for rendering
/// image tiles.
///
/// Access by calling `const {ImageMapType} = await
/// google.maps.importLibrary("maps")`. See
/// <see href="https://developers.google.com/maps/documentation/javascript/libraries." />
/// </summary>
type [<AllowNullLiteral>] ImageMapTypeStatic =
    /// <summary>
    /// This class implements the MapType interface and is provided for rendering
    /// image tiles.
    ///
    /// Access by calling `const {ImageMapType} = await
    /// google.maps.importLibrary("maps")`. See
    /// <see href="https://developers.google.com/maps/documentation/javascript/libraries." />
    /// </summary>
    [<EmitConstructor>] abstract Create: opts: Google.Maps.ImageMapTypeOptions option -> ImageMapType

/// This class is used to create a MapType that renders image tiles.
type [<AllowNullLiteral>] ImageMapTypeOptions =
    /// Alt text to display when this MapType&#39;s button is hovered over in the
    /// MapTypeControl.
    abstract alt: string option with get, set
    /// Returns a string (URL) for given tile coordinate (x, y) and zoom level.
    abstract getTileUrl: (Google.Maps.Point -> float -> string option) option with get, set
    /// The maximum zoom level for the map when displaying this MapType.
    abstract maxZoom: float option with get, set
    /// The minimum zoom level for the map when displaying this MapType.
    /// Optional.
    abstract minZoom: float option with get, set
    /// Name to display in the MapTypeControl.
    abstract name: string option with get, set
    /// The opacity to apply to the tiles. The opacity should be specified as a
    /// float value between 0 and 1.0, where 0 is fully transparent and 1 is
    /// fully opaque.
    abstract opacity: float option with get, set
    /// The tile size.
    abstract tileSize: Google.Maps.Size option with get, set

/// <summary>
/// An overlay that looks like a bubble and is often connected to a marker.
///
/// Access by calling `const {InfoWindow} = await
/// google.maps.importLibrary("maps")<c> or </c>const {InfoWindow} = await
/// google.maps.importLibrary("streetView")`. See
/// <see href="https://developers.google.com/maps/documentation/javascript/libraries." />
/// </summary>
type [<AllowNullLiteral>] InfoWindow =
    inherit Google.Maps.MVCObject
    /// Closes this InfoWindow by removing it from the DOM structure.
    abstract close: unit -> unit
    /// Sets focus on this &lt;code&gt;InfoWindow&lt;/code&gt;. You may wish to consider
    /// using this method along with a &lt;code&gt;visible&lt;/code&gt; event to make sure
    /// that &lt;code&gt;InfoWindow&lt;/code&gt; is visible before setting focus on it. An
    /// &lt;code&gt;InfoWindow&lt;/code&gt; that is not visible cannot be focused.
    abstract focus: unit -> unit
    abstract getContent: unit -> U3<string, Element, Text> option
    abstract getPosition: unit -> Google.Maps.LatLng option
    abstract getZIndex: unit -> float
    /// <summary>
    /// Opens this InfoWindow on the given map. Optionally, an InfoWindow can be
    /// associated with an anchor. In the core API, the only anchor is the Marker
    /// class. However, an anchor can be any MVCObject that exposes a LatLng
    /// &lt;code&gt;position&lt;/code&gt; property and optionally a Point
    /// &lt;code&gt;anchorPoint&lt;/code&gt; property for calculating the
    /// &lt;code&gt;pixelOffset&lt;/code&gt; (see InfoWindowOptions). The
    /// &lt;code&gt;anchorPoint&lt;/code&gt; is the offset from the anchor&amp;#39;s position to
    /// the tip of the InfoWindow. It is recommended to use the <see cref="*">google.maps.InfoWindowOpenOptions</see> interface as the single argument for
    /// this method. To prevent changing browser focus on open, set <see cref="*">google.maps.InfoWindowOpenOptions.shouldFocus</see> to &lt;code&gt;false&lt;/code&gt;.
    /// </summary>
    /// <param name="options">
    /// Either an InfoWindowOpenOptions object (recommended) or
    /// the map|panorama on which to render this InfoWindow.
    /// </param>
    /// <param name="anchor">
    /// The anchor to which this InfoWindow will be positioned. If
    /// the anchor is non-null, the InfoWindow will be positioned at the
    /// top-center of the anchor. The InfoWindow will be rendered on the same
    /// map or panorama as the anchor &lt;strong&gt;(when available)&lt;/strong&gt;.
    /// </param>
    abstract ``open``: ?options: U3<Google.Maps.InfoWindowOpenOptions, Google.Maps.Map, Google.Maps.StreetViewPanorama> * ?anchor: U2<Google.Maps.MVCObject, Google.Maps.Marker.AdvancedMarkerElement> -> unit
    /// <param name="content">The content to be displayed by this InfoWindow.</param>
    abstract setContent: ?content: U3<string, Element, Text> -> unit
    abstract setOptions: ?options: Google.Maps.InfoWindowOptions -> unit
    /// <param name="position">The LatLng position at which to display this InfoWindow.</param>
    abstract setPosition: ?position: U2<Google.Maps.LatLng, Google.Maps.LatLngLiteral> -> unit
    /// <param name="zIndex">
    /// The z-index for this InfoWindow. An InfoWindow with a
    /// greater z-index will be displayed in front of all other InfoWindows
    /// with a lower z-index.
    /// </param>
    abstract setZIndex: zIndex: float -> unit

/// <summary>
/// An overlay that looks like a bubble and is often connected to a marker.
///
/// Access by calling `const {InfoWindow} = await
/// google.maps.importLibrary("maps")<c> or </c>const {InfoWindow} = await
/// google.maps.importLibrary("streetView")`. See
/// <see href="https://developers.google.com/maps/documentation/javascript/libraries." />
/// </summary>
type [<AllowNullLiteral>] InfoWindowStatic =
    /// <summary>
    /// An overlay that looks like a bubble and is often connected to a marker.
    ///
    /// Access by calling `const {InfoWindow} = await
    /// google.maps.importLibrary("maps")<c> or </c>const {InfoWindow} = await
    /// google.maps.importLibrary("streetView")`. See
    /// <see href="https://developers.google.com/maps/documentation/javascript/libraries." />
    /// </summary>
    [<EmitConstructor>] abstract Create: ?opts: Google.Maps.InfoWindowOptions -> InfoWindow

/// Options for opening an InfoWindow
type [<AllowNullLiteral>] InfoWindowOpenOptions =
    /// The anchor to which this InfoWindow will be positioned. If the anchor is
    /// non-null, the InfoWindow will be positioned at the top-center of the
    /// anchor. The InfoWindow will be rendered on the same map or panorama as
    /// the anchor <strong>(when available)</strong>.
    abstract anchor: U2<Google.Maps.MVCObject, Google.Maps.Marker.AdvancedMarkerElement> option with get, set
    /// The map or panorama on which to render this InfoWindow.
    abstract map: U2<Google.Maps.Map, Google.Maps.StreetViewPanorama> option with get, set
    /// Whether or not focus should be moved inside the InfoWindow when it is
    /// opened. When this property is unset or when it is set to
    /// &lt;code&gt;null&lt;/code&gt; or &lt;code&gt;undefined&lt;/code&gt;, a heuristic is used to
    /// decide whether or not focus should be moved. It is recommended to
    /// explicitly set this property to fit your needs as the heuristic is
    /// subject to change and may not work well for all use cases.
    abstract shouldFocus: bool option with get, set

/// InfoWindowOptions object used to define the properties that can be set on a
/// InfoWindow.
type [<AllowNullLiteral>] InfoWindowOptions =
    /// AriaLabel to assign to the InfoWindow.
    abstract ariaLabel: string option with get, set
    /// Content to display in the InfoWindow. This can be an HTML element, a
    /// plain-text string, or a string containing HTML. The InfoWindow will be
    /// sized according to the content. To set an explicit size for the content,
    /// set content to be a HTML element with that size.
    abstract content: U3<string, Element, Text> option with get, set
    /// <summary>
    /// Disable panning the map to make the InfoWindow fully visible when it
    /// opens.
    /// </summary>
    /// <default>&lt;code&gt;false&lt;/code&gt;</default>
    abstract disableAutoPan: bool option with get, set
    /// Maximum width of the InfoWindow, regardless of content&amp;#39;s width. This
    /// value is only considered if it is set before a call to
    /// &lt;code&gt;open()&lt;/code&gt;. To change the maximum width when changing content,
    /// call &lt;code&gt;close()&lt;/code&gt;, &lt;code&gt;setOptions()&lt;/code&gt;, and then
    /// &lt;code&gt;open()&lt;/code&gt;.
    abstract maxWidth: float option with get, set
    /// Minimum width of the InfoWindow, regardless of the content&amp;#39;s width.
    /// When using this property, it is strongly recommended to set the
    /// &lt;code&gt;minWidth&lt;/code&gt; to a value less than the width of the map (in
    /// pixels). This value is only considered if it is set before a call to
    /// &lt;code&gt;open()&lt;/code&gt;. To change the minimum width when changing content,
    /// call &lt;code&gt;close()&lt;/code&gt;, &lt;code&gt;setOptions()&lt;/code&gt;, and then
    /// &lt;code&gt;open()&lt;/code&gt;.
    abstract minWidth: float option with get, set
    /// The offset, in pixels, of the tip of the info window from the point on
    /// the map at whose geographical coordinates the info window is anchored. If
    /// an InfoWindow is opened with an anchor, the &lt;code&gt;pixelOffset&lt;/code&gt; will
    /// be calculated from the anchor&amp;#39;s &lt;code&gt;anchorPoint&lt;/code&gt; property.
    abstract pixelOffset: Google.Maps.Size option with get, set
    /// The LatLng at which to display this InfoWindow. If the InfoWindow is
    /// opened with an anchor, the anchor&#39;s position will be used instead.
    abstract position: U2<Google.Maps.LatLng, Google.Maps.LatLngLiteral> option with get, set
    /// All InfoWindows are displayed on the map in order of their zIndex, with
    /// higher values displaying in front of InfoWindows with lower values. By
    /// default, InfoWindows are displayed according to their latitude, with
    /// InfoWindows of lower latitudes appearing in front of InfoWindows at
    /// higher latitudes. InfoWindows are always displayed in front of markers.
    abstract zIndex: float option with get, set

type [<AllowNullLiteral>] JourneySharingLibrary =
    abstract AutomaticViewportMode: obj with get, set
    abstract DeliveryVehicleStopState: obj with get, set
    abstract FleetEngineFleetLocationProvider: obj with get, set
    abstract FleetEngineServiceType: obj with get, set
    abstract FleetEngineShipmentLocationProvider: obj with get, set
    abstract FleetEngineTripLocationProvider: obj with get, set
    abstract FleetEngineVehicleLocationProvider: obj with get, set
    abstract JourneySharingMapView: obj with get, set
    abstract TripType: obj with get, set
    abstract VehicleNavigationStatus: obj with get, set
    abstract VehicleState: obj with get, set
    abstract VehicleType: obj with get, set
    abstract WaypointType: obj with get, set

/// Contains details of the author of a KML document or feature.
type [<AllowNullLiteral>] KmlAuthor =
    /// The author&#39;s e-mail address, or an empty string if not specified.
    abstract email: string with get, set
    /// The author&#39;s name, or an empty string if not specified.
    abstract name: string with get, set
    /// The author&#39;s home page, or an empty string if not specified.
    abstract uri: string with get, set

/// Data for a single KML feature in JSON format, returned when a KML feature
/// is clicked. The data contained in this object mirrors that associated with
/// the feature in the KML or GeoRSS markup in which it is declared.
type [<AllowNullLiteral>] KmlFeatureData =
    /// The feature&amp;#39;s &lt;code&gt;&amp;lt;atom:author&amp;gt;&lt;/code&gt;, extracted from the
    /// layer markup (if specified).
    abstract author: Google.Maps.KmlAuthor option with get, set
    /// The feature&amp;#39;s &lt;code&gt;&amp;lt;description&amp;gt;&lt;/code&gt;, extracted from the
    /// layer markup.
    abstract description: string with get, set
    /// The feature&amp;#39;s &lt;code&gt;&amp;lt;id&amp;gt;&lt;/code&gt;, extracted from the layer
    /// markup. If no &lt;code&gt;&amp;lt;id&amp;gt;&lt;/code&gt; has been specified, a unique ID
    /// will be generated for this feature.
    abstract id: string with get, set
    /// The feature&#39;s balloon styled text, if set.
    abstract infoWindowHtml: string with get, set
    /// The feature&amp;#39;s &lt;code&gt;&amp;lt;name&amp;gt;&lt;/code&gt;, extracted from the layer
    /// markup.
    abstract name: string with get, set
    /// The feature&amp;#39;s &lt;code&gt;&amp;lt;Snippet&amp;gt;&lt;/code&gt;, extracted from the layer
    /// markup.
    abstract snippet: string with get, set

/// <summary>
/// A &lt;code&gt;KmlLayer&lt;/code&gt; adds geographic markup to the map from a KML, KMZ
/// or GeoRSS file that is hosted on a publicly accessible web server. A
/// &lt;code&gt;KmlFeatureData&lt;/code&gt; object is provided for each feature when
/// clicked.
///
/// Access by calling `const {KmlLayer} = await
/// google.maps.importLibrary("maps")`. See
/// <see href="https://developers.google.com/maps/documentation/javascript/libraries." />
/// </summary>
type [<AllowNullLiteral>] KmlLayer =
    inherit Google.Maps.MVCObject
    /// Get the default viewport for the layer being displayed.
    abstract getDefaultViewport: unit -> Google.Maps.LatLngBounds option
    /// Get the map on which the KML Layer is being rendered.
    abstract getMap: unit -> Google.Maps.Map option
    /// Get the metadata associated with this layer, as specified in the layer
    /// markup.
    abstract getMetadata: unit -> Google.Maps.KmlLayerMetadata option
    /// Get the status of the layer, set once the requested document has loaded.
    abstract getStatus: unit -> Google.Maps.KmlLayerStatus
    /// Gets the URL of the KML file being displayed.
    abstract getUrl: unit -> string
    /// Gets the z-index of the KML Layer.
    abstract getZIndex: unit -> float
    /// Renders the KML Layer on the specified map. If map is set to
    /// &lt;code&gt;null&lt;/code&gt;, the layer is removed.
    abstract setMap: map: Google.Maps.Map option -> unit
    abstract setOptions: options: Google.Maps.KmlLayerOptions option -> unit
    /// Sets the URL of the KML file to display.
    abstract setUrl: url: string -> unit
    /// <summary>Sets the z-index of the KML Layer.</summary>
    /// <param name="zIndex">The z-index to set.</param>
    abstract setZIndex: zIndex: float -> unit

/// <summary>
/// A &lt;code&gt;KmlLayer&lt;/code&gt; adds geographic markup to the map from a KML, KMZ
/// or GeoRSS file that is hosted on a publicly accessible web server. A
/// &lt;code&gt;KmlFeatureData&lt;/code&gt; object is provided for each feature when
/// clicked.
///
/// Access by calling `const {KmlLayer} = await
/// google.maps.importLibrary("maps")`. See
/// <see href="https://developers.google.com/maps/documentation/javascript/libraries." />
/// </summary>
type [<AllowNullLiteral>] KmlLayerStatic =
    /// <summary>
    /// A &lt;code&gt;KmlLayer&lt;/code&gt; adds geographic markup to the map from a KML, KMZ
    /// or GeoRSS file that is hosted on a publicly accessible web server. A
    /// &lt;code&gt;KmlFeatureData&lt;/code&gt; object is provided for each feature when
    /// clicked.
    ///
    /// Access by calling `const {KmlLayer} = await
    /// google.maps.importLibrary("maps")`. See
    /// <see href="https://developers.google.com/maps/documentation/javascript/libraries." />
    /// </summary>
    /// <param name="opts">Options for this layer.</param>
    [<EmitConstructor>] abstract Create: ?opts: Google.Maps.KmlLayerOptions -> KmlLayer

/// Metadata for a single KML layer, in JSON format.
type [<AllowNullLiteral>] KmlLayerMetadata =
    /// The layer&amp;#39;s &lt;code&gt;&amp;lt;atom:author&amp;gt;&lt;/code&gt;, extracted from the
    /// layer markup.
    abstract author: Google.Maps.KmlAuthor option with get, set
    /// The layer&amp;#39;s &lt;code&gt;&amp;lt;description&amp;gt;&lt;/code&gt;, extracted from the
    /// layer markup.
    abstract description: string with get, set
    /// Whether the layer has any screen overlays.
    abstract hasScreenOverlays: bool with get, set
    /// The layer&amp;#39;s &lt;code&gt;&amp;lt;name&amp;gt;&lt;/code&gt;, extracted from the layer
    /// markup.
    abstract name: string with get, set
    /// The layer&amp;#39;s &lt;code&gt;&amp;lt;Snippet&amp;gt;&lt;/code&gt;, extracted from the layer
    /// markup
    abstract snippet: string with get, set

/// This object defines the properties that can be set on a
/// &lt;code&gt;KmlLayer&lt;/code&gt; object.
type [<AllowNullLiteral>] KmlLayerOptions =
    /// <summary>If &lt;code&gt;true&lt;/code&gt;, the layer receives mouse events.</summary>
    /// <default>&lt;code&gt;true&lt;/code&gt;</default>
    abstract clickable: bool option with get, set
    /// The map on which to display the layer.
    abstract map: Google.Maps.Map option with get, set
    /// <summary>
    /// If this option is set to &lt;code&gt;true&lt;/code&gt; or if the map&amp;#39;s center and
    /// zoom were never set, the input map is centered and zoomed to the bounding
    /// box of the contents of the layer.
    /// </summary>
    /// <default>&lt;code&gt;false&lt;/code&gt;</default>
    abstract preserveViewport: bool option with get, set
    /// <summary>Whether to render the screen overlays.</summary>
    /// <default>&lt;code&gt;true&lt;/code&gt;</default>
    abstract screenOverlays: bool option with get, set
    /// Suppress the rendering of info windows when layer features are clicked.
    abstract suppressInfoWindows: bool option with get, set
    /// The URL of the KML document to display.
    abstract url: string option with get, set
    /// The z-index of the layer.
    abstract zIndex: float option with get, set

/// <summary>
/// The status returned by &lt;code&gt;KmlLayer&lt;/code&gt; on the completion of loading a
/// document. Specify these by value, or by using the constant&amp;#39;s name. For
/// example, &lt;code&gt;'OK'&lt;/code&gt; or &lt;code&gt;google.maps.KmlLayerStatus.OK&lt;/code&gt;.
///
/// Access by calling `const {KmlLayerStatus} = await
/// google.maps.importLibrary("maps")`. See
/// <see href="https://developers.google.com/maps/documentation/javascript/libraries." />
/// </summary>
type [<StringEnum>] [<RequireQualifiedAccess>] KmlLayerStatus =
    /// The document could not be found. Most likely it is an invalid URL, or the
    /// document is not publicly available.
    | [<CompiledName("DOCUMENT_NOT_FOUND")>] DOCUMENT_NOT_FOUND
    /// The document exceeds the file size limits of KmlLayer.
    | [<CompiledName("DOCUMENT_TOO_LARGE")>] DOCUMENT_TOO_LARGE
    /// The document could not be fetched.
    | [<CompiledName("FETCH_ERROR")>] FETCH_ERROR
    /// The document is not a valid KML, KMZ or GeoRSS document.
    | [<CompiledName("INVALID_DOCUMENT")>] INVALID_DOCUMENT
    /// The &lt;code&gt;KmlLayer&lt;/code&gt; is invalid.
    | [<CompiledName("INVALID_REQUEST")>] INVALID_REQUEST
    /// The document exceeds the feature limits of KmlLayer.
    | [<CompiledName("LIMITS_EXCEEDED")>] LIMITS_EXCEEDED
    /// The layer loaded successfully.
    | [<CompiledName("OK")>] OK
    /// The document could not be loaded within a reasonable amount of time.
    | [<CompiledName("TIMED_OUT")>] TIMED_OUT
    /// The document failed to load for an unknown reason.
    | [<CompiledName("UNKNOWN")>] UNKNOWN

/// The properties of a click event on a KML/KMZ or GeoRSS document.
type [<AllowNullLiteral>] KmlMouseEvent =
    /// A &lt;code&gt;KmlFeatureData&lt;/code&gt; object, containing information about the
    /// clicked feature.
    abstract featureData: Google.Maps.KmlFeatureData option with get, set
    /// The position at which to anchor an infowindow on the clicked feature.
    abstract latLng: Google.Maps.LatLng option with get, set
    /// The offset to apply to an infowindow anchored on the clicked feature.
    abstract pixelOffset: Google.Maps.Size option with get, set

/// <summary>
/// A &lt;code&gt;LatLng&lt;/code&gt; is a point in geographical coordinates: latitude and
/// longitude.&lt;br&gt; &lt;ul&gt; &lt;li&gt;Latitude ranges between -90 and 90 degrees,
/// inclusive. Values above or below this range will be clamped to the range
/// [-90, 90]. This means that if the value specified is less than -90, it will
/// be set to -90. And if the value is greater than 90, it will be set
/// to 90.&lt;/li&gt; &lt;li&gt;Longitude ranges between -180 and 180 degrees, inclusive.
/// Values above or below this range will be wrapped so that they fall within
/// the range. For example, a value of -190 will be converted to 170. A value
/// of 190 will be converted to -170. This reflects the fact that longitudes
/// wrap around the globe.&lt;/li&gt; &lt;/ul&gt; Although the default map projection
/// associates longitude with the x-coordinate of the map, and latitude with
/// the y-coordinate, the latitude coordinate is always written &lt;em&gt;first&lt;/em&gt;,
/// followed by the longitude.&lt;br&gt; Notice that you cannot modify the
/// coordinates of a &lt;code&gt;LatLng&lt;/code&gt;. If you want to compute another point,
/// you have to create a new one.&lt;br&gt; &lt;p&gt; Most methods that accept
/// &lt;code&gt;LatLng&lt;/code&gt; objects also accept a <see cref="google.maps.LatLngLiteral" />
/// object, so that the following are equivalent: &lt;pre&gt; map.setCenter(new
/// google.maps.LatLng(-34, 151));&lt;br&gt; map.setCenter({lat: -34, lng: 151});
/// &lt;/pre&gt; &lt;p&gt; The constructor also accepts <see cref="google.maps.LatLngLiteral" />
/// and &lt;code&gt;LatLng&lt;/code&gt; objects. If a &lt;code&gt;LatLng&lt;/code&gt; instance is
/// passed to the constructor, a copy is created. &lt;p&gt; The possible calls to the
/// constructor are below: &lt;pre&gt; new google.maps.LatLng(-34, 151);&lt;br&gt; new
/// google.maps.LatLng(-34, 151, true);&lt;br&gt; new google.maps.LatLng({lat: -34,
/// lng: 151});&lt;br&gt; new google.maps.LatLng({lat: -34, lng: 151}, true);&lt;br&gt; new
/// google.maps.LatLng(new google.maps.LatLng(-34, 151));&lt;br&gt; new
/// google.maps.LatLng(new google.maps.LatLng(-34, 151), true);&lt;br&gt; &lt;/pre&gt;
///
/// Access by calling `const {LatLng} = await
/// google.maps.importLibrary("core")`. See
/// <see href="https://developers.google.com/maps/documentation/javascript/libraries." />
/// </summary>
type [<AllowNullLiteral>] LatLng =
    /// Comparison function.
    abstract equals: other: Google.Maps.LatLng option -> bool
    /// Returns the latitude in degrees.
    abstract lat: unit -> float
    /// Returns the longitude in degrees.
    abstract lng: unit -> float
    /// Converts to JSON representation. This function is intended to be used via
    /// &lt;code&gt;JSON.stringify&lt;/code&gt;.
    abstract toJSON: unit -> Google.Maps.LatLngLiteral
    /// Converts to string representation.
    abstract toString: unit -> string
    /// Returns a string of the form &quot;lat,lng&quot; for this LatLng. We
    /// round the lat/lng values to 6 decimal places by default.
    abstract toUrlValue: ?precision: float -> string

/// <summary>
/// A &lt;code&gt;LatLng&lt;/code&gt; is a point in geographical coordinates: latitude and
/// longitude.&lt;br&gt; &lt;ul&gt; &lt;li&gt;Latitude ranges between -90 and 90 degrees,
/// inclusive. Values above or below this range will be clamped to the range
/// [-90, 90]. This means that if the value specified is less than -90, it will
/// be set to -90. And if the value is greater than 90, it will be set
/// to 90.&lt;/li&gt; &lt;li&gt;Longitude ranges between -180 and 180 degrees, inclusive.
/// Values above or below this range will be wrapped so that they fall within
/// the range. For example, a value of -190 will be converted to 170. A value
/// of 190 will be converted to -170. This reflects the fact that longitudes
/// wrap around the globe.&lt;/li&gt; &lt;/ul&gt; Although the default map projection
/// associates longitude with the x-coordinate of the map, and latitude with
/// the y-coordinate, the latitude coordinate is always written &lt;em&gt;first&lt;/em&gt;,
/// followed by the longitude.&lt;br&gt; Notice that you cannot modify the
/// coordinates of a &lt;code&gt;LatLng&lt;/code&gt;. If you want to compute another point,
/// you have to create a new one.&lt;br&gt; &lt;p&gt; Most methods that accept
/// &lt;code&gt;LatLng&lt;/code&gt; objects also accept a <see cref="google.maps.LatLngLiteral" />
/// object, so that the following are equivalent: &lt;pre&gt; map.setCenter(new
/// google.maps.LatLng(-34, 151));&lt;br&gt; map.setCenter({lat: -34, lng: 151});
/// &lt;/pre&gt; &lt;p&gt; The constructor also accepts <see cref="google.maps.LatLngLiteral" />
/// and &lt;code&gt;LatLng&lt;/code&gt; objects. If a &lt;code&gt;LatLng&lt;/code&gt; instance is
/// passed to the constructor, a copy is created. &lt;p&gt; The possible calls to the
/// constructor are below: &lt;pre&gt; new google.maps.LatLng(-34, 151);&lt;br&gt; new
/// google.maps.LatLng(-34, 151, true);&lt;br&gt; new google.maps.LatLng({lat: -34,
/// lng: 151});&lt;br&gt; new google.maps.LatLng({lat: -34, lng: 151}, true);&lt;br&gt; new
/// google.maps.LatLng(new google.maps.LatLng(-34, 151));&lt;br&gt; new
/// google.maps.LatLng(new google.maps.LatLng(-34, 151), true);&lt;br&gt; &lt;/pre&gt;
///
/// Access by calling `const {LatLng} = await
/// google.maps.importLibrary("core")`. See
/// <see href="https://developers.google.com/maps/documentation/javascript/libraries." />
/// </summary>
type [<AllowNullLiteral>] LatLngStatic =
    /// <summary>
    /// A &lt;code&gt;LatLng&lt;/code&gt; is a point in geographical coordinates: latitude
    /// and longitude.&lt;br&gt; &lt;ul&gt; &lt;li&gt;Latitude ranges between -90 and 90 degrees,
    /// inclusive. Values above or below this range will be clamped to the range
    /// [-90, 90]. This means that if the value specified is less than -90, it
    /// will be set to -90. And if the value is greater than 90, it will be set
    /// to 90.&lt;/li&gt; &lt;li&gt;Longitude ranges between -180 and 180 degrees, inclusive.
    /// Values above or below this range will be wrapped so that they fall within
    /// the range. For example, a value of -190 will be converted to 170. A value
    /// of 190 will be converted to -170. This reflects the fact that longitudes
    /// wrap around the globe.&lt;/li&gt; &lt;/ul&gt; Although the default map projection
    /// associates longitude with the x-coordinate of the map, and latitude with
    /// the y-coordinate, the latitude coordinate is always written
    /// &lt;em&gt;first&lt;/em&gt;, followed by the longitude.&lt;br&gt; Notice that you cannot
    /// modify the coordinates of a &lt;code&gt;LatLng&lt;/code&gt;. If you want to compute
    /// another point, you have to create a new one.&lt;br&gt; &lt;p&gt; Most methods that
    /// accept &lt;code&gt;LatLng&lt;/code&gt; objects also accept a <see cref="*">google.maps.LatLngLiteral</see> object, so that the following are equivalent:
    /// &lt;pre&gt; map.setCenter(new google.maps.LatLng(-34, 151));&lt;br&gt;
    /// map.setCenter({lat: -34, lng: 151}); &lt;/pre&gt; &lt;p&gt; The constructor also
    /// accepts <see cref="google.maps.LatLngLiteral" /> and &lt;code&gt;LatLng&lt;/code&gt;
    /// objects. If a &lt;code&gt;LatLng&lt;/code&gt; instance is passed to the constructor,
    /// a copy is created. &lt;p&gt; The possible calls to the constructor are below:
    /// &lt;pre&gt; new google.maps.LatLng(-34, 151);&lt;br&gt; new google.maps.LatLng(-34,
    /// 151, true);&lt;br&gt; new google.maps.LatLng({lat: -34, lng: 151});&lt;br&gt; new
    /// google.maps.LatLng({lat: -34, lng: 151}, true);&lt;br&gt; new
    /// google.maps.LatLng(new google.maps.LatLng(-34, 151));&lt;br&gt; new
    /// google.maps.LatLng(new google.maps.LatLng(-34, 151), true);&lt;br&gt; &lt;/pre&gt;
    ///
    /// Access by calling `const {LatLng} = await
    /// google.maps.importLibrary("core")`. See
    /// <see href="https://developers.google.com/maps/documentation/javascript/libraries." />
    /// </summary>
    [<EmitConstructor>] abstract Create: latOrLatLngOrLatLngLiteral: U3<float, Google.Maps.LatLngLiteral, Google.Maps.LatLng> * ?lngOrNoClampNoWrap: U2<float, bool> * ?noClampNoWrap: bool -> LatLng

/// <summary>
/// A &lt;code&gt;LatLngAltitude&lt;/code&gt; is a 3D point in geographical coordinates:
/// latitude, longitude, and altitude.&lt;br&gt; &lt;ul&gt; &lt;li&gt;Latitude ranges between -90
/// and 90 degrees, inclusive. Values above or below this range will be clamped
/// to the range [-90, 90]. This means that if the value specified is less than
/// -90, it will be set to -90. And if the value is greater than 90, it will be
/// set to 90.&lt;/li&gt; &lt;li&gt;Longitude ranges between -180 and 180 degrees,
/// inclusive. Values above or below this range will be wrapped so that they
/// fall within the range. For example, a value of -190 will be converted to
/// 170. A value of 190 will be converted to -170. This reflects the fact that
/// longitudes wrap around the globe.&lt;/li&gt; &lt;li&gt;Altitude is measured in meters.
/// Positive values denote heights above ground level, and negative values
/// denote heights underneath the ground surface.&lt;/li&gt; &lt;/ul&gt;
///
/// Access by calling `const {LatLngAltitude} = await
/// google.maps.importLibrary("core")`. See
/// <see href="https://developers.google.com/maps/documentation/javascript/libraries." />
/// </summary>
type [<AllowNullLiteral>] LatLngAltitude =
    inherit Google.Maps.LatLngAltitudeLiteral
    inherit Google.Maps.LatLngLiteral
    /// Returns the altitude.
    abstract altitude: float with get, set
    /// <summary>Comparison function.</summary>
    /// <param name="other">Another LatLngAltitude object.</param>
    abstract equals: other: Google.Maps.LatLngAltitude option -> bool
    /// Returns the latitude.
    abstract lat: float with get, set
    /// Returns the longitude.
    abstract lng: float with get, set
    abstract toJSON: unit -> Google.Maps.LatLngAltitudeLiteral

/// <summary>
/// A &lt;code&gt;LatLngAltitude&lt;/code&gt; is a 3D point in geographical coordinates:
/// latitude, longitude, and altitude.&lt;br&gt; &lt;ul&gt; &lt;li&gt;Latitude ranges between -90
/// and 90 degrees, inclusive. Values above or below this range will be clamped
/// to the range [-90, 90]. This means that if the value specified is less than
/// -90, it will be set to -90. And if the value is greater than 90, it will be
/// set to 90.&lt;/li&gt; &lt;li&gt;Longitude ranges between -180 and 180 degrees,
/// inclusive. Values above or below this range will be wrapped so that they
/// fall within the range. For example, a value of -190 will be converted to
/// 170. A value of 190 will be converted to -170. This reflects the fact that
/// longitudes wrap around the globe.&lt;/li&gt; &lt;li&gt;Altitude is measured in meters.
/// Positive values denote heights above ground level, and negative values
/// denote heights underneath the ground surface.&lt;/li&gt; &lt;/ul&gt;
///
/// Access by calling `const {LatLngAltitude} = await
/// google.maps.importLibrary("core")`. See
/// <see href="https://developers.google.com/maps/documentation/javascript/libraries." />
/// </summary>
type [<AllowNullLiteral>] LatLngAltitudeStatic =
    /// <summary>
    /// A &lt;code&gt;LatLngAltitude&lt;/code&gt; is a 3D point in geographical coordinates:
    /// latitude, longitude, and altitude.&lt;br&gt; &lt;ul&gt; &lt;li&gt;Latitude ranges between
    /// -90 and 90 degrees, inclusive. Values above or below this range will be
    /// clamped to the range [-90, 90]. This means that if the value specified is
    /// less than -90, it will be set to -90. And if the value is greater than
    /// 90, it will be set to 90.&lt;/li&gt; &lt;li&gt;Longitude ranges between -180 and 180
    /// degrees, inclusive. Values above or below this range will be wrapped so
    /// that they fall within the range. For example, a value of -190 will be
    /// converted to 170. A value of 190 will be converted to -170. This reflects
    /// the fact that longitudes wrap around the globe.&lt;/li&gt; &lt;li&gt;Altitude is
    /// measured in meters. Positive values denote heights above ground level,
    /// and negative values denote heights underneath the ground surface.&lt;/li&gt;
    /// &lt;/ul&gt;
    ///
    /// Access by calling `const {LatLngAltitude} = await
    /// google.maps.importLibrary("core")`. See
    /// <see href="https://developers.google.com/maps/documentation/javascript/libraries." />
    /// </summary>
    /// <param name="value">The initializing value.</param>
    /// <param name="noClampNoWrap">
    /// Whether to preserve the initialization values, even
    /// if they may not necessarily be valid latitude values in the range of
    /// [-90, 90] or valid longitude values in the range of [-180, 180]. The
    /// default is &lt;code&gt;false&lt;/code&gt; which enables latitude clamping and
    /// longitude wrapping.
    /// </param>
    [<EmitConstructor>] abstract Create: value: U3<Google.Maps.LatLngAltitudeLiteral, Google.Maps.LatLng, Google.Maps.LatLngLiteral> * ?noClampNoWrap: bool -> LatLngAltitude

/// Object literals are accepted in place of &lt;code&gt;LatLngAltitude&lt;/code&gt;
/// objects, as a convenience, in many places. These are converted to
/// &lt;code&gt;LatLngAltitude&lt;/code&gt; objects when the Maps API encounters them.
type [<AllowNullLiteral>] LatLngAltitudeLiteral =
    inherit Google.Maps.LatLngLiteral
    /// <summary>
    /// Distance (in meters) above the ground surface. Negative value means
    /// underneath the ground surface.
    /// </summary>
    /// <default>&lt;code&gt;0&lt;/code&gt;</default>
    abstract altitude: float with get, set
    /// Latitude in degrees. Values will be clamped to the range [-90, 90]. This
    /// means that if the value specified is less than -90, it will be set to
    /// -90. And if the value is greater than 90, it will be set to 90.
    abstract lat: float with get, set
    /// Longitude in degrees. Values outside the range [-180, 180] will be
    /// wrapped so that they fall within the range. For example, a value of -190
    /// will be converted to 170. A value of 190 will be converted to -170. This
    /// reflects the fact that longitudes wrap around the globe.
    abstract lng: float with get, set

/// <summary>
/// A &lt;code&gt;&lt;a href="#LatLngBounds"&gt;LatLngBounds&lt;/a&gt;&lt;/code&gt; instance represents
/// a rectangle in geographical coordinates, including one that crosses the 180
/// degrees longitudinal meridian.
///
/// Access by calling `const {LatLngBounds} = await
/// google.maps.importLibrary("core")`. See
/// <see href="https://developers.google.com/maps/documentation/javascript/libraries." />
/// </summary>
type [<AllowNullLiteral>] LatLngBounds =
    /// Returns &lt;code&gt;true&lt;/code&gt; if the given lat/lng is in this bounds.
    abstract contains: latLng: U2<Google.Maps.LatLng, Google.Maps.LatLngLiteral> -> bool
    /// Returns &lt;code&gt;true&lt;/code&gt; if this bounds approximately equals the given
    /// bounds.
    abstract equals: other: U2<Google.Maps.LatLngBounds, Google.Maps.LatLngBoundsLiteral> option -> bool
    /// Extends this bounds to contain the given point.
    abstract extend: point: U2<Google.Maps.LatLng, Google.Maps.LatLngLiteral> -> Google.Maps.LatLngBounds
    /// Computes the center of this LatLngBounds
    abstract getCenter: unit -> Google.Maps.LatLng
    /// Returns the north-east corner of this bounds.
    abstract getNorthEast: unit -> Google.Maps.LatLng
    /// Returns the south-west corner of this bounds.
    abstract getSouthWest: unit -> Google.Maps.LatLng
    /// Returns &lt;code&gt;true&lt;/code&gt; if this bounds shares any points with the other
    /// bounds.
    abstract intersects: other: U2<Google.Maps.LatLngBounds, Google.Maps.LatLngBoundsLiteral> -> bool
    /// Returns if the bounds are empty.
    abstract isEmpty: unit -> bool
    /// Converts to JSON representation. This function is intended to be used via
    /// &lt;code&gt;JSON.stringify&lt;/code&gt;.
    abstract toJSON: unit -> Google.Maps.LatLngBoundsLiteral
    /// Converts the given map bounds to a lat/lng span.
    abstract toSpan: unit -> Google.Maps.LatLng
    /// Converts to string.
    abstract toString: unit -> string
    /// Returns a string of the form &quot;lat_lo,lng_lo,lat_hi,lng_hi&quot; for
    /// this bounds, where &quot;lo&quot; corresponds to the southwest corner of
    /// the bounding box, while &quot;hi&quot; corresponds to the northeast
    /// corner of that box.
    abstract toUrlValue: ?precision: float -> string
    /// Extends this bounds to contain the union of this and the given bounds.
    abstract union: other: U2<Google.Maps.LatLngBounds, Google.Maps.LatLngBoundsLiteral> -> Google.Maps.LatLngBounds

/// <summary>
/// A &lt;code&gt;&lt;a href="#LatLngBounds"&gt;LatLngBounds&lt;/a&gt;&lt;/code&gt; instance represents
/// a rectangle in geographical coordinates, including one that crosses the 180
/// degrees longitudinal meridian.
///
/// Access by calling `const {LatLngBounds} = await
/// google.maps.importLibrary("core")`. See
/// <see href="https://developers.google.com/maps/documentation/javascript/libraries." />
/// </summary>
type [<AllowNullLiteral>] LatLngBoundsStatic =
    /// <summary>
    /// A &lt;code&gt;&lt;a href="#LatLngBounds"&gt;LatLngBounds&lt;/a&gt;&lt;/code&gt; instance
    /// represents a rectangle in geographical coordinates, including one that
    /// crosses the 180 degrees longitudinal meridian.
    ///
    /// Access by calling `const {LatLngBounds} = await
    /// google.maps.importLibrary("core")`. See
    /// <see href="https://developers.google.com/maps/documentation/javascript/libraries." />
    /// </summary>
    [<EmitConstructor>] abstract Create: ?swOrLatLngBounds: U4<Google.Maps.LatLng, Google.Maps.LatLngLiteral, Google.Maps.LatLngBounds, Google.Maps.LatLngBoundsLiteral> * ?ne: U2<Google.Maps.LatLng, Google.Maps.LatLngLiteral> -> LatLngBounds
    /// LatLngBounds for the max bounds of the Earth. These bounds will encompass
    /// the entire globe.
    abstract MAX_BOUNDS: Google.Maps.LatLngBounds

/// Object literals are accepted in place of &lt;code&gt;LatLngBounds&lt;/code&gt; objects
/// throughout the API. These are automatically converted to
/// &lt;code&gt;LatLngBounds&lt;/code&gt; objects. All &lt;code&gt;south&lt;/code&gt;,
/// &lt;code&gt;west&lt;/code&gt;, &lt;code&gt;north&lt;/code&gt; and &lt;code&gt;east&lt;/code&gt; must be set,
/// otherwise an exception is thrown.
type [<AllowNullLiteral>] LatLngBoundsLiteral =
    /// East longitude in degrees. Values outside the range [-180, 180] will be
    /// wrapped to the range [-180, 180). For example, a value of -190 will be
    /// converted to 170. A value of 190 will be converted to -170. This reflects
    /// the fact that longitudes wrap around the globe.
    abstract east: float with get, set
    /// North latitude in degrees. Values will be clamped to the range [-90, 90].
    /// This means that if the value specified is less than -90, it will be set
    /// to -90. And if the value is greater than 90, it will be set to 90.
    abstract north: float with get, set
    /// South latitude in degrees. Values will be clamped to the range [-90, 90].
    /// This means that if the value specified is less than -90, it will be set
    /// to -90. And if the value is greater than 90, it will be set to 90.
    abstract south: float with get, set
    /// West longitude in degrees. Values outside the range [-180, 180] will be
    /// wrapped to the range [-180, 180). For example, a value of -190 will be
    /// converted to 170. A value of 190 will be converted to -170. This reflects
    /// the fact that longitudes wrap around the globe.
    abstract west: float with get, set

/// Object literals are accepted in place of &lt;code&gt;LatLng&lt;/code&gt; objects, as a
/// convenience, in many places. These are converted to &lt;code&gt;LatLng&lt;/code&gt;
/// objects when the Maps API encounters them. &lt;p&gt; Examples: &lt;pre&gt;
/// map.setCenter({lat: -34, lng: 151});&lt;br&gt; new
/// google.maps.Marker({position: {lat: -34, lng: 151}, map: map}); &lt;/pre&gt; &lt;p
/// class="note"&gt;LatLng object literals are not supported in the Geometry
/// library.&lt;/p&gt;
type [<AllowNullLiteral>] LatLngLiteral =
    /// Latitude in degrees. Values will be clamped to the range [-90, 90]. This
    /// means that if the value specified is less than -90, it will be set to
    /// -90. And if the value is greater than 90, it will be set to 90.
    abstract lat: float with get, set
    /// Longitude in degrees. Values outside the range [-180, 180] will be
    /// wrapped so that they fall within the range. For example, a value of -190
    /// will be converted to 170. A value of 190 will be converted to -170. This
    /// reflects the fact that longitudes wrap around the globe.
    abstract lng: float with get, set

/// An elevation request sent by the &lt;code&gt;ElevationService&lt;/code&gt; containing
/// the list of discrete coordinates (&lt;code&gt;LatLng&lt;/code&gt;s) for which to return
/// elevation data.
type [<AllowNullLiteral>] LocationElevationRequest =
    /// The discrete locations for which to retrieve elevations.
    abstract locations: Array<U2<Google.Maps.LatLng, Google.Maps.LatLngLiteral>> option with get, set

/// <summary>
/// An elevation response returned by the <see cref="google.maps.ElevationService" />
/// containing the list of <see cref="google.maps.ElevationResult" />s matching the
/// locations of the <see cref="google.maps.LocationElevationRequest" />.
/// </summary>
type [<AllowNullLiteral>] LocationElevationResponse =
    /// <summary>
    /// The list of <see cref="google.maps.ElevationResult" />s matching the locations
    /// of the <see cref="google.maps.LocationElevationRequest" />.
    /// </summary>
    abstract results: ResizeArray<Google.Maps.ElevationResult> with get, set

/// <summary>
/// Access by calling `const {MVCArray} = await
/// google.maps.importLibrary("core")`. See
/// <see href="https://developers.google.com/maps/documentation/javascript/libraries." />
/// </summary>
type MVCArray =
    MVCArray<obj option>

/// <summary>
/// Access by calling `const {MVCArray} = await
/// google.maps.importLibrary("core")`. See
/// <see href="https://developers.google.com/maps/documentation/javascript/libraries." />
/// </summary>
type [<AllowNullLiteral>] MVCArray<'T> =
    inherit Google.Maps.MVCObject
    /// Removes all elements from the array.
    abstract clear: unit -> unit
    /// Iterate over each element, calling the provided callback. The callback is
    /// called for each element like: callback(element, index).
    abstract forEach: callback: ('T -> float -> unit) -> unit
    /// Returns a reference to the underlying Array. Warning: if the Array is
    /// mutated, no events will be fired by this object.
    abstract getArray: unit -> ResizeArray<'T>
    /// Returns the element at the specified index.
    abstract getAt: i: float -> 'T
    /// Returns the number of elements in this array.
    abstract getLength: unit -> float
    /// Inserts an element at the specified index.
    abstract insertAt: i: float * elem: 'T -> unit
    /// Removes the last element of the array and returns that element.
    abstract pop: unit -> 'T
    /// Adds one element to the end of the array and returns the new length of
    /// the array.
    abstract push: elem: 'T -> float
    /// Removes an element from the specified index.
    abstract removeAt: i: float -> 'T
    /// Sets an element at the specified index.
    abstract setAt: i: float * elem: 'T -> unit

/// <summary>
/// Access by calling `const {MVCArray} = await
/// google.maps.importLibrary("core")`. See
/// <see href="https://developers.google.com/maps/documentation/javascript/libraries." />
/// </summary>
type [<AllowNullLiteral>] MVCArrayStatic =
    /// <summary>
    /// Access by calling `const {MVCArray} = await
    /// google.maps.importLibrary("core")`. See
    /// <see href="https://developers.google.com/maps/documentation/javascript/libraries." />
    /// </summary>
    [<EmitConstructor>] abstract Create: ?array: ResizeArray<'T> -> MVCArray<'T>

/// <summary>
/// Base class implementing KVO. &lt;br&gt;&lt;br&gt;The &lt;code&gt;MVCObject&lt;/code&gt; constructor
/// is guaranteed to be an empty function, and so you may inherit from
/// &lt;code&gt;MVCObject&lt;/code&gt; by writing &lt;code&gt;MySubclass.prototype = new
/// google.maps.MVCObject();&lt;/code&gt;. Unless otherwise noted, this is not true
/// of other classes in the API, and inheriting from other classes in the API
/// is not supported.
///
/// Access by calling `const {MVCObject} = await
/// google.maps.importLibrary("core")`. See
/// <see href="https://developers.google.com/maps/documentation/javascript/libraries." />
/// </summary>
type [<AllowNullLiteral>] MVCObject =
    /// Adds the given listener function to the given event name. Returns an
    /// identifier for this listener that can be used with
    /// &lt;code&gt;google.maps.event.removeListener&lt;/code&gt;.
    abstract addListener: eventName: string * handler: Function -> Google.Maps.MapsEventListener
    /// Binds a View to a Model.
    abstract bindTo: key: string * target: Google.Maps.MVCObject * ?targetKey: string * ?noNotify: bool -> unit
    /// Gets a value.
    abstract get: key: string -> obj option
    /// Notify all observers of a change on this property. This notifies both
    /// objects that are bound to the object&#39;s property as well as the object
    /// that it is bound to.
    abstract notify: key: string -> unit
    /// Sets a value.
    abstract set: key: string * value: obj -> unit
    /// Sets a collection of key-value pairs.
    abstract setValues: ?values: obj -> unit
    /// Removes a binding. Unbinding will set the unbound property to the current
    /// value. The object will not be notified, as the value has not changed.
    abstract unbind: key: string -> unit
    /// Removes all bindings.
    abstract unbindAll: unit -> unit

/// <summary>
/// Base class implementing KVO. &lt;br&gt;&lt;br&gt;The &lt;code&gt;MVCObject&lt;/code&gt; constructor
/// is guaranteed to be an empty function, and so you may inherit from
/// &lt;code&gt;MVCObject&lt;/code&gt; by writing &lt;code&gt;MySubclass.prototype = new
/// google.maps.MVCObject();&lt;/code&gt;. Unless otherwise noted, this is not true
/// of other classes in the API, and inheriting from other classes in the API
/// is not supported.
///
/// Access by calling `const {MVCObject} = await
/// google.maps.importLibrary("core")`. See
/// <see href="https://developers.google.com/maps/documentation/javascript/libraries." />
/// </summary>
type [<AllowNullLiteral>] MVCObjectStatic =
    [<EmitConstructor>] abstract Create: unit -> MVCObject

/// <summary>
/// Access by calling <c>const {Map} = await google.maps.importLibrary("maps")</c>.
/// See <see href="https://developers.google.com/maps/documentation/javascript/libraries." />
/// </summary>
type [<AllowNullLiteral>] Map =
    inherit Google.Maps.MVCObject
    /// Additional controls to attach to the map. To add a control to the map,
    /// add the control&amp;#39;s &lt;code&gt;&amp;lt;div&amp;gt;&lt;/code&gt; to the
    /// &lt;code&gt;MVCArray&lt;/code&gt; corresponding to the &lt;code&gt;ControlPosition&lt;/code&gt;
    /// where it should be rendered.
    abstract controls: Array<Google.Maps.MVCArray<HTMLElement>> with get, set
    /// An instance of &lt;code&gt;Data&lt;/code&gt;, bound to the map. Add features to this
    /// &lt;code&gt;Data&lt;/code&gt; object to conveniently display them on this map.
    abstract data: Google.Maps.Data with get, set
    /// <summary>
    /// Sets the viewport to contain the given bounds.&lt;/br&gt;
    /// &lt;strong&gt;Note:&lt;/strong&gt; When the map is set to &lt;code&gt;display: none&lt;/code&gt;,
    /// the &lt;code&gt;fitBounds&lt;/code&gt; function reads the map&amp;#39;s size as 0x0, and
    /// therefore does not do anything. To change the viewport while the map is
    /// hidden, set the map to &lt;code&gt;visibility: hidden&lt;/code&gt;, thereby ensuring
    /// the map div has an actual size. For vector maps, this method sets the
    /// map&amp;#39;s tilt and heading to their default zero values. Calling this
    /// method may cause a smooth animation as the map pans and zooms to fit the
    /// bounds. Whether or not this method animates depends on an internal
    /// heuristic.
    /// </summary>
    /// <param name="bounds">Bounds to show.</param>
    /// <param name="padding">
    /// Padding in pixels. The bounds will be fit in the part of
    /// the map that remains after padding is removed. A number value will
    /// yield the same padding on all 4 sides. Supply 0 here to make a
    /// fitBounds idempotent on the result of getBounds.
    /// </param>
    abstract fitBounds: bounds: U2<Google.Maps.LatLngBounds, Google.Maps.LatLngBoundsLiteral> * ?padding: U2<float, Google.Maps.Padding> -> unit
    /// <summary>
    /// Returns the lat/lng bounds of the current viewport. If more than one copy
    /// of the world is visible, the bounds range in longitude from -180 to 180
    /// degrees inclusive. If the map is not yet initialized or center and zoom
    /// have not been set then the result is &lt;code&gt;undefined&lt;/code&gt;. For vector
    /// maps with non-zero tilt or heading, the returned lat/lng bounds
    /// represents the smallest bounding box that includes the visible region of
    /// the map&amp;#39;s viewport. See <see cref="*">google.maps.MapCanvasProjection.getVisibleRegion</see> for getting the exact
    /// visible region of the map&amp;#39;s viewport.
    /// </summary>
    abstract getBounds: unit -> Google.Maps.LatLngBounds option
    /// <summary>
    /// Returns the position displayed at the center of the map. Note that
    /// this <see cref="google.maps.LatLng" /> object is &lt;em&gt;not&lt;/em&gt; wrapped. See
    /// &lt;code&gt;&lt;a href="#LatLng"&gt;LatLng&lt;/a&gt;&lt;/code&gt; for more information. If the
    /// center or bounds have not been set then the result is
    /// &lt;code&gt;undefined&lt;/code&gt;.
    /// </summary>
    abstract getCenter: unit -> Google.Maps.LatLng option
    /// Returns the clickability of the map icons. A map icon represents a point
    /// of interest, also known as a POI. If the returned value is
    /// &lt;code&gt;true&lt;/code&gt;, then the icons are clickable on the map.
    abstract getClickableIcons: unit -> bool option
    /// <summary>
    /// Available only in the v=beta channel: <see href="https://goo.gle/3oAthT3." />
    /// Returns the &lt;code&gt;FeatureLayer&lt;/code&gt; for the specified
    /// &lt;code&gt;datasetId&lt;/code&gt;. Dataset IDs must be configured in the Google
    /// Cloud Console. If the dataset ID is not associated with the map&amp;#39;s map
    /// style, or if Data-driven styling is not available (no map ID, no vector
    /// tiles, no Data-Driven Styling feature layers or Datasets configured in
    /// the Map Style), this logs an error, and the resulting
    /// &lt;code&gt;FeatureLayer.isAvailable&lt;/code&gt; will be false.
    /// </summary>
    abstract getDatasetFeatureLayer: datasetId: string -> Google.Maps.FeatureLayer
    abstract getDiv: unit -> HTMLElement
    /// Returns the &lt;code&gt;FeatureLayer&lt;/code&gt; of the specific
    /// &lt;code&gt;FeatureType&lt;/code&gt;. A &lt;code&gt;FeatureLayer&lt;/code&gt; must be enabled in
    /// the Google Cloud Console. If a &lt;code&gt;FeatureLayer&lt;/code&gt; of the specified
    /// &lt;code&gt;FeatureType&lt;/code&gt; does not exist on this map, or if Data-driven
    /// styling is not available (no map ID, no vector tiles, and no
    /// &lt;code&gt;FeatureLayer&lt;/code&gt; enabled in the map style), this logs an error,
    /// and the resulting &lt;code&gt;FeatureLayer.isAvailable&lt;/code&gt; will be false.
    abstract getFeatureLayer: featureType: Google.Maps.FeatureType -> Google.Maps.FeatureLayer
    /// Returns the compass heading of the map. The heading value is measured in
    /// degrees (clockwise) from cardinal direction North. If the map is not yet
    /// initialized then the result is &lt;code&gt;undefined&lt;/code&gt;.
    abstract getHeading: unit -> float option
    /// Informs the caller of the current capabilities available to the map based
    /// on the Map ID that was provided.
    abstract getMapCapabilities: unit -> Google.Maps.MapCapabilities
    abstract getMapTypeId: unit -> string option
    /// Returns the current &lt;code&gt;Projection&lt;/code&gt;. If the map is not yet
    /// initialized then the result is &lt;code&gt;undefined&lt;/code&gt;. Listen to the
    /// &lt;code&gt;projection_changed&lt;/code&gt; event and check its value to ensure it is
    /// not &lt;code&gt;undefined&lt;/code&gt;.
    abstract getProjection: unit -> Google.Maps.Projection option
    /// Returns the current RenderingType of the map.
    abstract getRenderingType: unit -> Google.Maps.RenderingType
    /// Returns the default &lt;code&gt;StreetViewPanorama&lt;/code&gt; bound to the map,
    /// which may be a default panorama embedded within the map, or the panorama
    /// set using &lt;code&gt;setStreetView()&lt;/code&gt;. Changes to the map&amp;#39;s
    /// &lt;code&gt;streetViewControl&lt;/code&gt; will be reflected in the display of such a
    /// bound panorama.
    abstract getStreetView: unit -> Google.Maps.StreetViewPanorama
    /// Returns the current angle of incidence of the map, in degrees from the
    /// viewport plane to the map plane. For raster maps, the result will be
    /// &lt;code&gt;0&lt;/code&gt; for imagery taken directly overhead or &lt;code&gt;45&lt;/code&gt; for
    /// 45&amp;deg; imagery. This method does not return the value set by
    /// &lt;code&gt;setTilt&lt;/code&gt;. See &lt;code&gt;setTilt&lt;/code&gt; for details.
    abstract getTilt: unit -> float option
    /// Returns the zoom of the map. If the zoom has not been set then the result
    /// is &lt;code&gt;undefined&lt;/code&gt;.
    abstract getZoom: unit -> float option
    /// A registry of &lt;code&gt;MapType&lt;/code&gt; instances by string ID.
    abstract mapTypes: Google.Maps.MapTypeRegistry with get, set
    /// Immediately sets the map&#39;s camera to the target camera options,
    /// without animation.
    abstract moveCamera: cameraOptions: Google.Maps.CameraOptions -> unit
    /// Additional map types to overlay. Overlay map types will display on top of
    /// the base map they are attached to, in the order in which they appear in
    /// the &lt;code&gt;overlayMapTypes&lt;/code&gt; array (overlays with higher index values
    /// are displayed in front of overlays with lower index values).
    abstract overlayMapTypes: Google.Maps.MVCArray<Google.Maps.MapType option> with get, set
    /// <summary>
    /// Changes the center of the map by the given distance in pixels. If the
    /// distance is less than both the width and height of the map, the
    /// transition will be smoothly animated. Note that the map coordinate system
    /// increases from west to east (for x values) and north to south (for y
    /// values).
    /// </summary>
    /// <param name="x">Number of pixels to move the map in the x direction.</param>
    /// <param name="y">Number of pixels to move the map in the y direction.</param>
    abstract panBy: x: float * y: float -> unit
    /// <summary>
    /// Changes the center of the map to the given &lt;code&gt;LatLng&lt;/code&gt;. If the
    /// change is less than both the width and height of the map, the transition
    /// will be smoothly animated.
    /// </summary>
    /// <param name="latLng">The new center latitude/longitude of the map.</param>
    abstract panTo: latLng: U2<Google.Maps.LatLng, Google.Maps.LatLngLiteral> -> unit
    /// <summary>
    /// Pans the map by the minimum amount necessary to contain the given
    /// &lt;code&gt;LatLngBounds&lt;/code&gt;. It makes no guarantee where on the map the
    /// bounds will be, except that the map will be panned to show as much of the
    /// bounds as possible inside &lt;code&gt;{currentMapSizeInPx} - {padding}&lt;/code&gt;.
    /// For both raster and vector maps, the map&amp;#39;s zoom, tilt, and heading
    /// will not be changed.
    /// </summary>
    /// <param name="latLngBounds">The bounds to pan the map to.</param>
    /// <param name="padding">
    /// Padding in pixels. A number value will yield the same
    /// padding on all 4 sides. The default value is 0.
    /// </param>
    abstract panToBounds: latLngBounds: U2<Google.Maps.LatLngBounds, Google.Maps.LatLngBoundsLiteral> * ?padding: U2<float, Google.Maps.Padding> -> unit
    abstract setCenter: latlng: U2<Google.Maps.LatLng, Google.Maps.LatLngLiteral> -> unit
    /// Controls whether the map icons are clickable or not. A map icon
    /// represents a point of interest, also known as a POI. To disable the
    /// clickability of map icons, pass a value of &lt;code&gt;false&lt;/code&gt; to this
    /// method.
    abstract setClickableIcons: value: bool -> unit
    /// Sets the compass heading for map measured in degrees from cardinal
    /// direction North. For raster maps, this method only applies to aerial
    /// imagery.
    abstract setHeading: heading: float -> unit
    abstract setMapTypeId: mapTypeId: string -> unit
    abstract setOptions: options: Google.Maps.MapOptions option -> unit
    /// <summary>
    /// Binds a &lt;code&gt;StreetViewPanorama&lt;/code&gt; to the map. This panorama
    /// overrides the default &lt;code&gt;StreetViewPanorama&lt;/code&gt;, allowing the map
    /// to bind to an external panorama outside of the map. Setting the panorama
    /// to &lt;code&gt;null&lt;/code&gt; binds the default embedded panorama back to the map.
    /// </summary>
    /// <param name="panorama">The panorama to bind to the map.</param>
    abstract setStreetView: panorama: Google.Maps.StreetViewPanorama option -> unit
    /// For vector maps, sets the angle of incidence of the map. The allowed
    /// values are restricted depending on the zoom level of the map. For raster
    /// maps, controls the automatic switching behavior for the angle of
    /// incidence of the map. The only allowed values are &lt;code&gt;0&lt;/code&gt; and
    /// &lt;code&gt;45&lt;/code&gt;. &lt;code&gt;setTilt(0)&lt;/code&gt; causes the map to always use a
    /// 0&amp;deg; overhead view regardless of the zoom level and viewport.
    /// &lt;code&gt;setTilt(45)&lt;/code&gt; causes the tilt angle to automatically switch to
    /// 45 whenever 45&amp;deg; imagery is available for the current zoom level and
    /// viewport, and switch back to 0 whenever 45&amp;deg; imagery is not available
    /// (this is the default behavior). 45&amp;deg; imagery is only available for
    /// &lt;code&gt;satellite&lt;/code&gt; and &lt;code&gt;hybrid&lt;/code&gt; map types, within some
    /// locations, and at some zoom levels. &lt;b&gt;Note:&lt;/b&gt; &lt;code&gt;getTilt&lt;/code&gt;
    /// returns the current tilt angle, not the value set by
    /// &lt;code&gt;setTilt&lt;/code&gt;. Because &lt;code&gt;getTilt&lt;/code&gt; and
    /// &lt;code&gt;setTilt&lt;/code&gt; refer to different things, do not
    /// &lt;code&gt;bind()&lt;/code&gt; the &lt;code&gt;tilt&lt;/code&gt; property; doing so may yield
    /// unpredictable effects.
    abstract setTilt: tilt: float -> unit
    /// <summary>Sets the zoom of the map.</summary>
    /// <param name="zoom">Larger zoom values correspond to a higher resolution.</param>
    abstract setZoom: zoom: float -> unit

/// <summary>
/// Access by calling <c>const {Map} = await google.maps.importLibrary("maps")</c>.
/// See <see href="https://developers.google.com/maps/documentation/javascript/libraries." />
/// </summary>
type [<AllowNullLiteral>] MapStatic =
    /// <summary>
    /// Access by calling `const {Map} = await
    /// google.maps.importLibrary("maps")`. See
    /// <see href="https://developers.google.com/maps/documentation/javascript/libraries." />
    /// </summary>
    /// <param name="mapDiv">The map will render to fill this element.</param>
    /// <param name="opts">Options</param>
    [<EmitConstructor>] abstract Create: mapDiv: HTMLElement * ?opts: Google.Maps.MapOptions -> Map
    /// Map ID which can be used for code samples which require a Map ID. This
    /// Map ID is not intended for use in production applications and cannot be
    /// used for features which require cloud configuration (such as Cloud
    /// Styling).
    abstract DEMO_MAP_ID: string

/// This object is made available to the &lt;code&gt;OverlayView&lt;/code&gt; from within
/// the draw method. It is not guaranteed to be initialized until draw is
/// called.
type [<AllowNullLiteral>] MapCanvasProjection =
    /// Computes the geographical coordinates from pixel coordinates in the
    /// map&#39;s container.
    abstract fromContainerPixelToLatLng: pixel: Google.Maps.Point option * ?noClampNoWrap: bool -> Google.Maps.LatLng option
    /// Computes the geographical coordinates from pixel coordinates in the div
    /// that holds the draggable map.
    abstract fromDivPixelToLatLng: pixel: Google.Maps.Point option * ?noClampNoWrap: bool -> Google.Maps.LatLng option
    /// Computes the pixel coordinates of the given geographical location in the
    /// map&#39;s container element.
    abstract fromLatLngToContainerPixel: latLng: U2<Google.Maps.LatLng, Google.Maps.LatLngLiteral> -> Google.Maps.Point option
    /// Computes the pixel coordinates of the given geographical location in the
    /// DOM element that holds the draggable map.
    abstract fromLatLngToDivPixel: latLng: U2<Google.Maps.LatLng, Google.Maps.LatLngLiteral> option -> Google.Maps.Point option
    /// The visible region of the map. Returns &lt;code&gt;null&lt;/code&gt; if the map has
    /// no size. Returns &lt;code&gt;null&lt;/code&gt; if the OverlayView is on a
    /// StreetViewPanorama.
    abstract getVisibleRegion: unit -> Google.Maps.VisibleRegion option
    /// The width of the world in pixels in the current zoom level. For
    /// projections with a heading angle of either 90 or 270 degrees, this
    /// corresponds to the pixel span in the Y-axis.
    abstract getWorldWidth: unit -> float

/// Object containing a snapshot of what capabilities are currently available
/// for the Map. Note that this does not necessarily mean that relevant modules
/// are loaded or initialized, but rather that the current map has permission
/// to use these APIs. See the properties for a list of possible capabilities.
type [<AllowNullLiteral>] MapCapabilities =
    /// <summary>
    /// If true, this map is configured properly to allow for the use of advanced
    /// markers. Note that you must still import the &lt;code&gt;marker&lt;/code&gt; library
    /// in order to use advanced markers. See &lt;a
    /// href="<see href="https://goo.gle/gmp-isAdvancedMarkersAvailable"&gt;https://goo.gle/gmp-isAdvancedMarkersAvailable&lt;/a&gt;" />
    /// for more information.
    /// </summary>
    abstract isAdvancedMarkersAvailable: bool option with get, set
    /// <summary>
    /// If true, this map is configured properly to allow for the use of
    /// data-driven styling for at least one FeatureLayer. See &lt;a
    /// href="<see href="https://goo.gle/gmp-data-driven-styling"&gt;https://goo.gle/gmp-data-driven-styling&lt;/a&gt;" />
    /// and &lt;a
    /// href="<see href="https://goo.gle/gmp-FeatureLayerIsAvailable"&gt;https://goo.gle/gmp-FeatureLayerIsAvailable&lt;/a&gt;" />
    /// for more information.
    /// </summary>
    abstract isDataDrivenStylingAvailable: bool option with get, set

/// <summary>
/// Available only in the v=beta channel: <see href="https://goo.gle/3oAthT3." />
///
/// MapElement is an &lt;code&gt;HTMLElement&lt;/code&gt; subclass for rendering maps.
/// After loading the &lt;code&gt;maps&lt;/code&gt; library, a map can be created in HTML.
/// For example: &lt;pre&gt;&lt;code&gt;&amp;lt;gmp-map
/// center=&amp;quot;37.4220656,-122.0840897&amp;quot; zoom=&amp;quot;10&amp;quot;
/// map-id=&amp;quot;DEMO_MAP_ID&amp;quot;&amp;gt;&lt;br&gt;&amp;nbsp;&amp;nbsp;&amp;lt;button
/// slot=&amp;quot;control-block-start-inline-end&amp;quot;&amp;gt;Custom
/// Control&amp;lt;/button&amp;gt;&lt;br&gt;&amp;lt;/gmp-map&amp;gt;&lt;/code&gt;&lt;/pre&gt; &lt;br&gt; Internally, it
/// uses <see cref="google.maps.Map" />, which can be accessed with the
/// &lt;code&gt;innerMap&lt;/code&gt; property.
///
/// Access by calling `const {MapElement} = await
/// google.maps.importLibrary("maps")`. See
/// <see href="https://developers.google.com/maps/documentation/javascript/libraries." />
/// </summary>
type [<AllowNullLiteral>] MapElement =
    inherit HTMLElement
    inherit Google.Maps.MapElementOptions
    /// The center latitude/longitude of the map.
    abstract center: U2<Google.Maps.LatLng, Google.Maps.LatLngLiteral> option with get, set
    /// <summary>
    /// A reference to the <see cref="google.maps.Map" /> that the MapElement uses
    /// internally.
    /// </summary>
    abstract innerMap: Google.Maps.Map with get, set
    /// <summary>
    /// The Map ID of the map. See the &lt;a
    /// href="<see href="https://developers.google.com/maps/documentation/get-map-id"&gt;Map" /> ID
    /// documentation&lt;/a&gt; for more information.
    /// </summary>
    abstract mapId: string option with get, set
    /// The zoom level of the map.
    abstract zoom: float option with get, set

/// <summary>
/// Available only in the v=beta channel: <see href="https://goo.gle/3oAthT3." />
///
/// MapElement is an &lt;code&gt;HTMLElement&lt;/code&gt; subclass for rendering maps.
/// After loading the &lt;code&gt;maps&lt;/code&gt; library, a map can be created in HTML.
/// For example: &lt;pre&gt;&lt;code&gt;&amp;lt;gmp-map
/// center=&amp;quot;37.4220656,-122.0840897&amp;quot; zoom=&amp;quot;10&amp;quot;
/// map-id=&amp;quot;DEMO_MAP_ID&amp;quot;&amp;gt;&lt;br&gt;&amp;nbsp;&amp;nbsp;&amp;lt;button
/// slot=&amp;quot;control-block-start-inline-end&amp;quot;&amp;gt;Custom
/// Control&amp;lt;/button&amp;gt;&lt;br&gt;&amp;lt;/gmp-map&amp;gt;&lt;/code&gt;&lt;/pre&gt; &lt;br&gt; Internally, it
/// uses <see cref="google.maps.Map" />, which can be accessed with the
/// &lt;code&gt;innerMap&lt;/code&gt; property.
///
/// Access by calling `const {MapElement} = await
/// google.maps.importLibrary("maps")`. See
/// <see href="https://developers.google.com/maps/documentation/javascript/libraries." />
/// </summary>
type [<AllowNullLiteral>] MapElementStatic =
    /// <summary>
    /// Available only in the v=beta channel: <see href="https://goo.gle/3oAthT3." />
    ///
    /// MapElement is an &lt;code&gt;HTMLElement&lt;/code&gt; subclass for rendering maps.
    /// After loading the &lt;code&gt;maps&lt;/code&gt; library, a map can be created in
    /// HTML. For example: &lt;pre&gt;&lt;code&gt;&amp;lt;gmp-map
    /// center=&amp;quot;37.4220656,-122.0840897&amp;quot; zoom=&amp;quot;10&amp;quot;
    /// map-id=&amp;quot;DEMO_MAP_ID&amp;quot;&amp;gt;&lt;br&gt;&amp;nbsp;&amp;nbsp;&amp;lt;button
    /// slot=&amp;quot;control-block-start-inline-end&amp;quot;&amp;gt;Custom
    /// Control&amp;lt;/button&amp;gt;&lt;br&gt;&amp;lt;/gmp-map&amp;gt;&lt;/code&gt;&lt;/pre&gt; &lt;br&gt; Internally,
    /// it uses <see cref="google.maps.Map" />, which can be accessed with the
    /// &lt;code&gt;innerMap&lt;/code&gt; property.
    ///
    /// Access by calling `const {MapElement} = await
    /// google.maps.importLibrary("maps")`. See
    /// <see href="https://developers.google.com/maps/documentation/javascript/libraries." />
    /// </summary>
    [<EmitConstructor>] abstract Create: unit -> MapElement

/// <summary>
/// Available only in the v=beta channel: <see href="https://goo.gle/3oAthT3." />
///
/// MapElementOptions object used to define the properties that can be set on a
/// MapElement.
/// </summary>
type [<AllowNullLiteral>] MapElementOptions =
    /// The initial Map center.
    abstract center: U2<Google.Maps.LatLng, Google.Maps.LatLngLiteral> option with get, set
    /// <summary>
    /// The &lt;a
    /// href="<see href="https://developers.google.com/maps/documentation/get-map-id"&gt;Map" />
    /// ID&lt;/a&gt; of the map. This parameter cannot be set or changed after a map is
    /// instantiated.
    /// </summary>
    abstract mapId: string option with get, set
    /// <summary>
    /// The initial Map zoom level. Valid zoom values are numbers from zero up to
    /// the supported &lt;a
    /// href="<see href="https://developers.google.com/maps/documentation/javascript/maxzoom"&gt;maximum" />
    /// zoom level&lt;/a&gt;. Larger zoom values correspond to a higher resolution.
    /// </summary>
    abstract zoom: float option with get, set

/// This object is returned from various mouse events on the map and overlays,
/// and contains all the fields shown below.
type [<AllowNullLiteral>] MapMouseEvent =
    /// <summary>
    /// The corresponding native DOM event. Developers should not rely on
    /// &lt;code&gt;target&lt;/code&gt;, &lt;code&gt;currentTarget&lt;/code&gt;,
    /// &lt;code&gt;relatedTarget&lt;/code&gt; and &lt;code&gt;path&lt;/code&gt; properties being defined
    /// and consistent. Developers should not also rely on the DOM structure of
    /// the internal implementation of the Maps API. Due to internal event
    /// mapping, the &lt;code&gt;domEvent&lt;/code&gt; may have different semantics from
    /// the <see cref="google.maps.MapMouseEvent" /> (e.g. a <see cref="*">google.maps.MapMouseEvent</see> &amp;quot;click&amp;quot; may have a
    /// &lt;code&gt;domEvent&lt;/code&gt; of type &lt;code&gt;KeyboardEvent&lt;/code&gt;).
    /// </summary>
    abstract domEvent: U5<MouseEvent, TouchEvent, PointerEvent, KeyboardEvent, Event> with get, set
    /// The latitude/longitude that was below the cursor when the event occurred.
    abstract latLng: Google.Maps.LatLng option with get, set
    /// Prevents this event from propagating further.
    abstract stop: unit -> unit

/// MapOptions object used to define the properties that can be set on a Map.
type [<AllowNullLiteral>] MapOptions =
    /// Color used for the background of the Map div. This color will be visible
    /// when tiles have not yet loaded as the user pans. This option can only be
    /// set when the map is initialized.
    abstract backgroundColor: string option with get, set
    /// The initial Map center.
    abstract center: U2<Google.Maps.LatLng, Google.Maps.LatLngLiteral> option with get, set
    /// <summary>
    /// When &lt;code&gt;false&lt;/code&gt;, map icons are not clickable. A map icon
    /// represents a point of interest, also known as a POI.
    /// </summary>
    /// <default>&lt;code&gt;true&lt;/code&gt;</default>
    abstract clickableIcons: bool option with get, set
    /// Size in pixels of the controls appearing on the map. This value must be
    /// supplied directly when creating the Map, updating this value later may
    /// bring the controls into an &lt;code&gt;undefined&lt;/code&gt; state. Only governs the
    /// controls made by the Maps API itself. Does not scale developer created
    /// custom controls.
    abstract controlSize: float option with get, set
    /// <summary>
    /// Enables/disables all default UI buttons. May be overridden individually.
    /// Does not disable the keyboard controls, which are separately controlled
    /// by the <see cref="google.maps.MapOptions.keyboardShortcuts" /> option. Does not
    /// disable gesture controls, which are separately controlled by the <see cref="*">google.maps.MapOptions.gestureHandling</see> option.
    /// </summary>
    abstract disableDefaultUI: bool option with get, set
    /// Enables/disables zoom and center on double click. Enabled by default.
    /// &lt;p&gt;&lt;strong&gt;Note&lt;/strong&gt;: This property is &lt;strong&gt;not
    /// recommended&lt;/strong&gt;. To disable zooming on double click, you can use the
    /// &lt;code&gt;gestureHandling&lt;/code&gt; property, and set it to &lt;code&gt;"none"&lt;/code&gt;.
    abstract disableDoubleClickZoom: bool option with get, set
    /// If &lt;code&gt;false&lt;/code&gt;, prevents the map from being dragged. Dragging is
    /// enabled by default.
    [<Obsolete("Deprecated in 2017. To disable dragging on the map, you can
use the <code>gestureHandling</code> property, and set it to
<code>\"none\"</code>.")>]
    abstract draggable: bool option with get, set
    /// <summary>
    /// The name or url of the cursor to display when mousing over a draggable
    /// map. This property uses the css &lt;code&gt;cursor&lt;/code&gt; attribute to change
    /// the icon. As with the css property, you must specify at least one
    /// fallback cursor that is not a URL. For example: &lt;code&gt;draggableCursor:
    /// 'url(&lt;a
    /// href="<see href="http://www.example.com/icon.png"&gt;http://www.example.com/icon.png&lt;/a&gt;)," />
    /// auto;'&lt;/code&gt;.
    /// </summary>
    abstract draggableCursor: string option with get, set
    /// <summary>
    /// The name or url of the cursor to display when the map is being dragged.
    /// This property uses the css &lt;code&gt;cursor&lt;/code&gt; attribute to change the
    /// icon. As with the css property, you must specify at least one fallback
    /// cursor that is not a URL. For example: &lt;code&gt;draggingCursor: 'url(&lt;a
    /// href="<see href="http://www.example.com/icon.png"&gt;http://www.example.com/icon.png&lt;/a&gt;)," />
    /// auto;'&lt;/code&gt;.
    /// </summary>
    abstract draggingCursor: string option with get, set
    /// The enabled/disabled state of the Fullscreen control.
    abstract fullscreenControl: bool option with get, set
    /// The display options for the Fullscreen control.
    abstract fullscreenControlOptions: Google.Maps.FullscreenControlOptions option with get, set
    /// This setting controls how the API handles gestures on the map. Allowed
    /// values: &lt;ul&gt; &lt;li&gt; &lt;code&gt;"cooperative"&lt;/code&gt;: Scroll events and
    /// one-finger touch gestures scroll the page, and do not zoom or pan the
    /// map. Two-finger touch gestures pan and zoom the map. Scroll events with a
    /// ctrl key or ⌘ key pressed zoom the map.&lt;br&gt; In this mode the map
    /// &lt;em&gt;cooperates&lt;/em&gt; with the page. &lt;li&gt; &lt;code&gt;"greedy"&lt;/code&gt;: All touch
    /// gestures and scroll events pan or zoom the map. &lt;li&gt; &lt;code&gt;"none"&lt;/code&gt;:
    /// The map cannot be panned or zoomed by user gestures. &lt;li&gt;
    /// &lt;code&gt;"auto"&lt;/code&gt;: (default) Gesture handling is either cooperative or
    /// greedy, depending on whether the page is scrollable or in an iframe.
    /// &lt;/ul&gt;
    abstract gestureHandling: string option with get, set
    /// The heading for aerial imagery in degrees measured clockwise from
    /// cardinal direction North. Headings are snapped to the nearest available
    /// angle for which imagery is available.
    abstract heading: float option with get, set
    /// <summary>
    /// Whether the map should allow fractional zoom levels. Listen to
    /// &lt;code&gt;isfractionalzoomenabled_changed&lt;/code&gt; to know when the default has
    /// been set.
    /// </summary>
    /// <default>
    /// &lt;code&gt;true&lt;/code&gt; for vector maps and &lt;code&gt;false&lt;/code&gt;
    /// for raster maps
    /// </default>
    abstract isFractionalZoomEnabled: bool option with get, set
    /// If &lt;code&gt;false&lt;/code&gt;, prevents the map from being controlled by the
    /// keyboard. Keyboard shortcuts are enabled by default.
    abstract keyboardShortcuts: bool option with get, set
    /// <summary>
    /// The &lt;a
    /// href="<see href="https://developers.google.com/maps/documentation/get-map-id"&gt;Map" />
    /// ID&lt;/a&gt; of the map. This parameter cannot be set or changed after a map is
    /// instantiated.
    /// </summary>
    abstract mapId: string option with get, set
    /// The initial enabled/disabled state of the Map type control.
    abstract mapTypeControl: bool option with get, set
    /// The initial display options for the Map type control.
    abstract mapTypeControlOptions: Google.Maps.MapTypeControlOptions option with get, set
    /// The initial Map mapTypeId. Defaults to &lt;code&gt;ROADMAP&lt;/code&gt;.
    abstract mapTypeId: string option with get, set
    /// <summary>
    /// The maximum zoom level which will be displayed on the map. If omitted, or
    /// set to &lt;code&gt;null&lt;/code&gt;, the maximum zoom from the current map type is
    /// used instead. Valid zoom values are numbers from zero up to the supported
    /// &lt;a
    /// href="<see href="https://developers.google.com/maps/documentation/javascript/maxzoom"&gt;maximum" />
    /// zoom level&lt;/a&gt;.
    /// </summary>
    abstract maxZoom: float option with get, set
    /// <summary>
    /// The minimum zoom level which will be displayed on the map. If omitted, or
    /// set to &lt;code&gt;null&lt;/code&gt;, the minimum zoom from the current map type is
    /// used instead. Valid zoom values are numbers from zero up to the supported
    /// &lt;a
    /// href="<see href="https://developers.google.com/maps/documentation/javascript/maxzoom"&gt;maximum" />
    /// zoom level&lt;/a&gt;.
    /// </summary>
    abstract minZoom: float option with get, set
    /// If &lt;code&gt;true&lt;/code&gt;, do not clear the contents of the Map div.
    abstract noClear: bool option with get, set
    /// The enabled/disabled state of the Pan control. <p>
    [<Obsolete("The Pan control is deprecated as of September 2015.")>]
    abstract panControl: bool option with get, set
    /// The display options for the Pan control. <p>
    [<Obsolete("The Pan control is deprecated as of September 2015.")>]
    abstract panControlOptions: Google.Maps.PanControlOptions option with get, set
    /// Defines a boundary that restricts the area of the map accessible to
    /// users. When set, a user can only pan and zoom while the camera view stays
    /// inside the limits of the boundary.
    abstract restriction: Google.Maps.MapRestriction option with get, set
    /// The enabled/disabled state of the Rotate control.
    abstract rotateControl: bool option with get, set
    /// The display options for the Rotate control.
    abstract rotateControlOptions: Google.Maps.RotateControlOptions option with get, set
    /// The initial enabled/disabled state of the Scale control.
    abstract scaleControl: bool option with get, set
    /// The initial display options for the Scale control.
    abstract scaleControlOptions: Google.Maps.ScaleControlOptions option with get, set
    /// If &lt;code&gt;false&lt;/code&gt;, disables zooming on the map using a mouse scroll
    /// wheel. The scrollwheel is enabled by default. &lt;p&gt;&lt;strong&gt;Note&lt;/strong&gt;:
    /// This property is &lt;strong&gt;not recommended&lt;/strong&gt;. To disable zooming
    /// using scrollwheel, you can use the &lt;code&gt;gestureHandling&lt;/code&gt; property,
    /// and set it to either &lt;code&gt;"cooperative"&lt;/code&gt; or &lt;code&gt;"none"&lt;/code&gt;.
    abstract scrollwheel: bool option with get, set
    /// A &lt;code&gt;StreetViewPanorama&lt;/code&gt; to display when the Street View pegman
    /// is dropped on the map. If no panorama is specified, a default
    /// &lt;code&gt;StreetViewPanorama&lt;/code&gt; will be displayed in the map&amp;#39;s
    /// &lt;code&gt;div&lt;/code&gt; when the pegman is dropped.
    abstract streetView: Google.Maps.StreetViewPanorama option with get, set
    /// The initial enabled/disabled state of the Street View Pegman control.
    /// This control is part of the default UI, and should be set to
    /// &lt;code&gt;false&lt;/code&gt; when displaying a map type on which the Street View
    /// road overlay should not appear (e.g. a non-Earth map type).
    abstract streetViewControl: bool option with get, set
    /// The initial display options for the Street View Pegman control.
    abstract streetViewControlOptions: Google.Maps.StreetViewControlOptions option with get, set
    /// Styles to apply to each of the default map types. Note that for
    /// &lt;code&gt;satellite&lt;/code&gt;/&lt;code&gt;hybrid&lt;/code&gt; and &lt;code&gt;terrain&lt;/code&gt;
    /// modes, these styles will only apply to labels and geometry.
    abstract styles: ResizeArray<Google.Maps.MapTypeStyle> option with get, set
    /// For vector maps, sets the angle of incidence of the map. The allowed
    /// values are restricted depending on the zoom level of the map. For raster
    /// maps, controls the automatic switching behavior for the angle of
    /// incidence of the map. The only allowed values are &lt;code&gt;0&lt;/code&gt; and
    /// &lt;code&gt;45&lt;/code&gt;. The value &lt;code&gt;0&lt;/code&gt; causes the map to always use a
    /// 0&amp;deg; overhead view regardless of the zoom level and viewport. The value
    /// &lt;code&gt;45&lt;/code&gt; causes the tilt angle to automatically switch to 45
    /// whenever 45&amp;deg; imagery is available for the current zoom level and
    /// viewport, and switch back to 0 whenever 45&amp;deg; imagery is not available
    /// (this is the default behavior). 45&amp;deg; imagery is only available for
    /// &lt;code&gt;satellite&lt;/code&gt; and &lt;code&gt;hybrid&lt;/code&gt; map types, within some
    /// locations, and at some zoom levels. &lt;b&gt;Note:&lt;/b&gt; &lt;code&gt;getTilt&lt;/code&gt;
    /// returns the current tilt angle, not the value specified by this option.
    /// Because &lt;code&gt;getTilt&lt;/code&gt; and this option refer to different things,
    /// do not &lt;code&gt;bind()&lt;/code&gt; the &lt;code&gt;tilt&lt;/code&gt; property; doing so may
    /// yield unpredictable effects.
    abstract tilt: float option with get, set
    /// <summary>
    /// The initial Map zoom level. Valid zoom values are numbers from zero up to
    /// the supported &lt;a
    /// href="<see href="https://developers.google.com/maps/documentation/javascript/maxzoom"&gt;maximum" />
    /// zoom level&lt;/a&gt;. Larger zoom values correspond to a higher resolution.
    /// </summary>
    abstract zoom: float option with get, set
    /// The enabled/disabled state of the Zoom control.
    abstract zoomControl: bool option with get, set
    /// The display options for the Zoom control.
    abstract zoomControlOptions: Google.Maps.ZoomControlOptions option with get, set

type [<AllowNullLiteral>] MapPanes =
    /// This pane contains the info window. It is above all map overlays. (Pane
    /// 4).
    abstract floatPane: Element with get, set
    /// This pane is the lowest pane and is above the tiles. It does not receive
    /// DOM events. (Pane 0).
    abstract mapPane: Element with get, set
    /// This pane contains markers. It does not receive DOM events. (Pane 2).
    abstract markerLayer: Element with get, set
    /// This pane contains polylines, polygons, ground overlays and tile layer
    /// overlays. It does not receive DOM events. (Pane 1).
    abstract overlayLayer: Element with get, set
    /// This pane contains elements that receive DOM events. (Pane 3).
    abstract overlayMouseTarget: Element with get, set

/// A restriction that can be applied to the Map. The map&#39;s viewport will
/// not exceed these restrictions.
type [<AllowNullLiteral>] MapRestriction =
    /// When set, a user can only pan and zoom inside the given bounds. Bounds
    /// can restrict both longitude and latitude, or can restrict latitude only.
    /// For latitude-only bounds use west and east longitudes of -180 and 180,
    /// respectively, for example, &lt;code&gt;latLngBounds: {north: northLat, south:
    /// southLat, west: -180, east: 180}&lt;/code&gt;.
    abstract latLngBounds: U2<Google.Maps.LatLngBounds, Google.Maps.LatLngBoundsLiteral> with get, set
    /// Bounds can be made more restrictive by setting the
    /// &lt;code&gt;strictBounds&lt;/code&gt; flag to &lt;code&gt;true&lt;/code&gt;. This reduces how far
    /// a user can zoom out, ensuring that everything outside of the restricted
    /// bounds stays hidden. The default is &lt;code&gt;false&lt;/code&gt;, meaning that a
    /// user can zoom out until the entire bounded area is in view, possibly
    /// including areas outside the bounded area.
    abstract strictBounds: bool option with get, set

/// This interface defines the map type, and is typically used for custom map
/// types. Immutable.
type [<AllowNullLiteral>] MapType =
    /// Alt text to display when this MapType&#39;s button is hovered over in the
    /// MapTypeControl. Optional.
    abstract alt: string option with get, set
    /// <summary>
    /// Returns a tile for the given tile coordinate (x, y) and zoom level. This
    /// tile will be appended to the given ownerDocument. Not available for base
    /// map types.
    /// </summary>
    /// <param name="tileCoord">Tile coordinates.</param>
    /// <param name="zoom">Tile zoom.</param>
    /// <param name="ownerDocument">The document which owns this tile.</param>
    abstract getTile: tileCoord: Google.Maps.Point option * zoom: float * ownerDocument: Document option -> Element option
    /// The maximum zoom level for the map when displaying this MapType. Required
    /// for base MapTypes, ignored for overlay MapTypes.
    abstract maxZoom: float with get, set
    /// The minimum zoom level for the map when displaying this MapType.
    /// Optional; defaults to 0.
    abstract minZoom: float with get, set
    /// Name to display in the MapTypeControl. Optional.
    abstract name: string option with get, set
    /// The Projection used to render this MapType. Optional; defaults to
    /// Mercator.
    abstract projection: Google.Maps.Projection option with get, set
    /// Radius of the planet for the map, in meters. Optional; defaults to
    /// Earth&#39;s equatorial radius of 6378137 meters.
    abstract radius: float with get, set
    /// <summary>
    /// Releases the given tile, performing any necessary cleanup. The provided
    /// tile will have already been removed from the document. Optional.
    /// </summary>
    /// <param name="tile">Tile to release.</param>
    abstract releaseTile: tile: Element option -> unit
    /// The dimensions of each tile. Required.
    abstract tileSize: Google.Maps.Size option with get, set

/// Options for the rendering of the map type control.
type [<AllowNullLiteral>] MapTypeControlOptions =
    /// IDs of map types to show in the control.
    abstract mapTypeIds: ResizeArray<string> option with get, set
    /// <summary>Position id. Used to specify the position of the control on the map.</summary>
    /// <default>{@link  * google.maps.ControlPosition.BLOCK_START_INLINE_START}</default>
    abstract position: Google.Maps.ControlPosition option with get, set
    /// Style id. Used to select what style of map type control to display.
    abstract style: Google.Maps.MapTypeControlStyle option with get, set

/// <summary>
/// Identifiers for common MapTypesControls.
///
/// Access by calling `const {MapTypeControlStyle} = await
/// google.maps.importLibrary("maps")`. See
/// <see href="https://developers.google.com/maps/documentation/javascript/libraries." />
/// </summary>
type [<RequireQualifiedAccess>] MapTypeControlStyle =
    /// Uses the default map type control. When the &lt;code&gt;DEFAULT&lt;/code&gt; control
    /// is shown, it will vary according to window size and other factors. The
    /// &lt;code&gt;DEFAULT&lt;/code&gt; control may change in future versions of the API.
    | DEFAULT = 0
    /// A dropdown menu for the screen realestate conscious.
    | DROPDOWN_MENU = 1
    /// The standard horizontal radio buttons bar.
    | HORIZONTAL_BAR = 2

/// <summary>
/// Identifiers for common MapTypes. Specify these by value, or by using the
/// constant&amp;#39;s name. For example, &lt;code&gt;'satellite'&lt;/code&gt; or
/// &lt;code&gt;google.maps.MapTypeId.SATELLITE&lt;/code&gt;.
///
/// Access by calling `const {MapTypeId} = await
/// google.maps.importLibrary("maps")`. See
/// <see href="https://developers.google.com/maps/documentation/javascript/libraries." />
/// </summary>
type [<StringEnum>] [<RequireQualifiedAccess>] MapTypeId =
    /// This map type displays a transparent layer of major streets on satellite
    /// images.
    | [<CompiledName("hybrid")>] HYBRID
    /// This map type displays a normal street map.
    | [<CompiledName("roadmap")>] ROADMAP
    /// This map type displays satellite images.
    | [<CompiledName("satellite")>] SATELLITE
    /// This map type displays maps with physical features such as terrain and
    /// vegetation.
    | [<CompiledName("terrain")>] TERRAIN

/// <summary>
/// A registry for MapType instances, keyed by MapType id.
///
/// Access by calling `const {MapTypeRegistry} = await
/// google.maps.importLibrary("maps")`. See
/// <see href="https://developers.google.com/maps/documentation/javascript/libraries." />
/// </summary>
type [<AllowNullLiteral>] MapTypeRegistry =
    inherit Google.Maps.MVCObject
    /// <summary>
    /// Sets the registry to associate the passed string identifier with the
    /// passed MapType.
    /// </summary>
    /// <param name="id">Identifier of the MapType to add to the registry.</param>
    /// <param name="mapType">MapType object to add to the registry.</param>
    abstract set: id: string * mapType: obj -> unit

/// <summary>
/// A registry for MapType instances, keyed by MapType id.
///
/// Access by calling `const {MapTypeRegistry} = await
/// google.maps.importLibrary("maps")`. See
/// <see href="https://developers.google.com/maps/documentation/javascript/libraries." />
/// </summary>
type [<AllowNullLiteral>] MapTypeRegistryStatic =
    [<EmitConstructor>] abstract Create: unit -> MapTypeRegistry

/// <summary>
/// The &lt;code&gt;MapTypeStyle&lt;/code&gt; is a collection of selectors and stylers that
/// define how the map should be styled. Selectors specify the map features
/// and/or elements that should be affected, and stylers specify how those
/// features and elements should be modified. For details, see the &lt;a
/// href="<see href="https://developers.google.com/maps/documentation/javascript/style-reference"&gt;style" />
/// reference&lt;/a&gt;.
/// </summary>
type [<AllowNullLiteral>] MapTypeStyle =
    /// <summary>
    /// The element to which a styler should be applied. An element is a visual
    /// aspect of a feature on the map. Example: a label, an icon, the stroke or
    /// fill applied to the geometry, and more. Optional. If
    /// &lt;code&gt;elementType&lt;/code&gt; is not specified, the value is assumed to be
    /// &lt;code&gt;'all'&lt;/code&gt;. For details of usage and allowed values, see the &lt;a
    /// href="<see href="https://developers.google.com/maps/documentation/javascript/style-reference#style-elements"&gt;style" />
    /// reference&lt;/a&gt;.
    /// </summary>
    abstract elementType: string option with get, set
    /// <summary>
    /// The feature, or group of features, to which a styler should be applied.
    /// Optional. If &lt;code&gt;featureType&lt;/code&gt; is not specified, the value is
    /// assumed to be &lt;code&gt;'all'&lt;/code&gt;. For details of usage and allowed
    /// values, see the &lt;a
    /// href="<see href="https://developers.google.com/maps/documentation/javascript/style-reference#style-features"&gt;style" />
    /// reference&lt;/a&gt;.
    /// </summary>
    abstract featureType: string option with get, set
    /// <summary>
    /// The style rules to apply to the selected map features and elements. The
    /// rules are applied in the order that you specify in this array. For
    /// guidelines on usage and allowed values, see the &lt;a
    /// href="<see href="https://developers.google.com/maps/documentation/javascript/style-reference#stylers"&gt;style" />
    /// reference&lt;/a&gt;.
    /// </summary>
    abstract stylers: ResizeArray<obj> with get, set

/// An event listener, created by &lt;code&gt;&lt;a
/// href="#event"&gt;google.maps.event.addListener&lt;/a&gt;()&lt;/code&gt; and friends.
type [<AllowNullLiteral>] MapsEventListener =
    /// Removes the listener. &lt;p&gt;Calling &lt;code&gt;listener.remove()&lt;/code&gt; is
    /// equivalent to &lt;code&gt;google.maps.event.removeListener(listener)&lt;/code&gt;.
    abstract remove: unit -> unit

type [<AllowNullLiteral>] MapsLibrary =
    abstract BicyclingLayer: obj with get, set
    abstract Circle: obj with get, set
    abstract Data: obj with get, set
    abstract FeatureType: obj with get, set
    abstract GroundOverlay: obj with get, set
    abstract ImageMapType: obj with get, set
    abstract InfoWindow: obj with get, set
    abstract KmlLayer: obj with get, set
    abstract KmlLayerStatus: obj with get, set
    abstract Map: obj with get, set
    abstract MapTypeControlStyle: obj with get, set
    abstract MapTypeId: obj with get, set
    abstract MapTypeRegistry: obj with get, set
    abstract MaxZoomService: obj with get, set
    abstract MaxZoomStatus: obj with get, set
    abstract OverlayView: obj with get, set
    abstract Polygon: obj with get, set
    abstract Polyline: obj with get, set
    abstract Rectangle: obj with get, set
    abstract RenderingType: obj with get, set
    abstract StrokePosition: obj with get, set
    abstract StyledMapType: obj with get, set
    abstract TrafficLayer: obj with get, set
    abstract TransitLayer: obj with get, set
    abstract WebGLOverlayView: obj with get, set
    abstract ZoomChangeEvent: obj with get, set

/// <summary>
/// Base class for managing network errors in Maps.
///
/// Access by calling `const {MapsNetworkError} = await
/// google.maps.importLibrary("core")`. See
/// <see href="https://developers.google.com/maps/documentation/javascript/libraries." />
/// </summary>
type [<AllowNullLiteral; AbstractClass>] MapsNetworkError =
    inherit Error
    /// Identifies the type of error produced by the API.
    abstract code: U7<Google.Maps.DirectionsStatus, Google.Maps.DistanceMatrixStatus, Google.Maps.ElevationStatus, Google.Maps.GeocoderStatus, Google.Maps.MaxZoomStatus, Google.Maps.Places.PlacesServiceStatus, Google.Maps.StreetViewStatus> with get, set
    /// Represents the network service that responded with the error.
    abstract endpoint: Google.Maps.MapsNetworkErrorEndpoint with get, set

/// <summary>
/// Base class for managing network errors in Maps.
///
/// Access by calling `const {MapsNetworkError} = await
/// google.maps.importLibrary("core")`. See
/// <see href="https://developers.google.com/maps/documentation/javascript/libraries." />
/// </summary>
type [<AllowNullLiteral>] MapsNetworkErrorStatic =
    /// <summary>
    /// Base class for managing network errors in Maps.
    ///
    /// Access by calling `const {MapsNetworkError} = await
    /// google.maps.importLibrary("core")`. See
    /// <see href="https://developers.google.com/maps/documentation/javascript/libraries." />
    /// </summary>
    [<EmitConstructor>] abstract Create: unit -> MapsNetworkError

/// <summary>
/// Identifiers for API endpoints used by <see cref="google.maps.MapsNetworkError" />
/// instances.
///
/// Access by calling `const {MapsNetworkErrorEndpoint} = await
/// google.maps.importLibrary("core")`. See
/// <see href="https://developers.google.com/maps/documentation/javascript/libraries." />
/// </summary>
type [<StringEnum>] [<RequireQualifiedAccess>] MapsNetworkErrorEndpoint =
    /// Identifies the Routes API within the Directions API.
    | [<CompiledName("DIRECTIONS_ROUTE")>] DIRECTIONS_ROUTE
    /// Identifies the DistanceMatrix API.
    | [<CompiledName("DISTANCE_MATRIX")>] DISTANCE_MATRIX
    /// Identifies the getElevationsAlongPath API within the Elevation API.
    | [<CompiledName("ELEVATION_ALONG_PATH")>] ELEVATION_ALONG_PATH
    /// Identifies the getElevationForLocations API within the Elevation API.
    | [<CompiledName("ELEVATION_LOCATIONS")>] ELEVATION_LOCATIONS
    /// Identifies the Get DeliveryVehicle API within Fleet Engine.
    | [<CompiledName("FLEET_ENGINE_GET_DELIVERY_VEHICLE")>] FLEET_ENGINE_GET_DELIVERY_VEHICLE
    /// Identifies the Get Trip API within Fleet Engine.
    | [<CompiledName("FLEET_ENGINE_GET_TRIP")>] FLEET_ENGINE_GET_TRIP
    /// Identifies the Get Vehicle API within Fleet Engine.
    | [<CompiledName("FLEET_ENGINE_GET_VEHICLE")>] FLEET_ENGINE_GET_VEHICLE
    /// Identifies the List DeliveryVehicles API within Fleet Engine.
    | [<CompiledName("FLEET_ENGINE_LIST_DELIVERY_VEHICLES")>] FLEET_ENGINE_LIST_DELIVERY_VEHICLES
    /// Identifies the List Tasks API within Fleet Engine.
    | [<CompiledName("FLEET_ENGINE_LIST_TASKS")>] FLEET_ENGINE_LIST_TASKS
    /// Identifies the List Vehicles API within Fleet Engine.
    | [<CompiledName("FLEET_ENGINE_LIST_VEHICLES")>] FLEET_ENGINE_LIST_VEHICLES
    /// Identifies the Search Tasks API within Fleet Engine.
    | [<CompiledName("FLEET_ENGINE_SEARCH_TASKS")>] FLEET_ENGINE_SEARCH_TASKS
    /// Identifies the geocode API within the Geocoder.
    | [<CompiledName("GEOCODER_GEOCODE")>] GEOCODER_GEOCODE
    /// Identifies the MaximumZoomImageryService API within the Maps API.
    | [<CompiledName("MAPS_MAX_ZOOM")>] MAPS_MAX_ZOOM
    /// Identifies the Autocomplete API within the Places API.
    | [<CompiledName("PLACES_AUTOCOMPLETE")>] PLACES_AUTOCOMPLETE
    /// Identifies the Details API within the Places API.
    | [<CompiledName("PLACES_DETAILS")>] PLACES_DETAILS
    /// Identifies the findPlaceFromPhoneNumber API within the Places API.
    | [<CompiledName("PLACES_FIND_PLACE_FROM_PHONE_NUMBER")>] PLACES_FIND_PLACE_FROM_PHONE_NUMBER
    /// Identifies the findPlaceFromQuery API within the Places API.
    | [<CompiledName("PLACES_FIND_PLACE_FROM_QUERY")>] PLACES_FIND_PLACE_FROM_QUERY
    /// Identifies the Gateway API within the Places API.
    | [<CompiledName("PLACES_GATEWAY")>] PLACES_GATEWAY
    /// Identifies the LocalContextSearch API within the Places API.
    | [<CompiledName("PLACES_LOCAL_CONTEXT_SEARCH")>] PLACES_LOCAL_CONTEXT_SEARCH
    /// Identifies the NearbySearch API within the Places API.
    | [<CompiledName("PLACES_NEARBY_SEARCH")>] PLACES_NEARBY_SEARCH
    /// Identifies the getPanorama method within the Streetview service.
    | [<CompiledName("STREETVIEW_GET_PANORAMA")>] STREETVIEW_GET_PANORAMA

/// <summary>
/// Represents a request error from a web service (i.e. the equivalent of a 4xx
/// code in HTTP).
///
/// Access by calling `const {MapsRequestError} = await
/// google.maps.importLibrary("core")`. See
/// <see href="https://developers.google.com/maps/documentation/javascript/libraries." />
/// </summary>
type [<AllowNullLiteral; AbstractClass>] MapsRequestError =
    inherit Google.Maps.MapsNetworkError

/// <summary>
/// Represents a request error from a web service (i.e. the equivalent of a 4xx
/// code in HTTP).
///
/// Access by calling `const {MapsRequestError} = await
/// google.maps.importLibrary("core")`. See
/// <see href="https://developers.google.com/maps/documentation/javascript/libraries." />
/// </summary>
type [<AllowNullLiteral>] MapsRequestErrorStatic =
    /// <summary>
    /// Represents a request error from a web service (i.e. the equivalent of a
    /// 4xx code in HTTP).
    ///
    /// Access by calling `const {MapsRequestError} = await
    /// google.maps.importLibrary("core")`. See
    /// <see href="https://developers.google.com/maps/documentation/javascript/libraries." />
    /// </summary>
    [<EmitConstructor>] abstract Create: unit -> MapsRequestError

/// <summary>
/// Represents a server-side error from a web service (i.e. the equivalent of a
/// 5xx code in HTTP).
///
/// Access by calling `const {MapsServerError} = await
/// google.maps.importLibrary("core")`. See
/// <see href="https://developers.google.com/maps/documentation/javascript/libraries." />
/// </summary>
type [<AllowNullLiteral; AbstractClass>] MapsServerError =
    inherit Google.Maps.MapsNetworkError

/// <summary>
/// Represents a server-side error from a web service (i.e. the equivalent of a
/// 5xx code in HTTP).
///
/// Access by calling `const {MapsServerError} = await
/// google.maps.importLibrary("core")`. See
/// <see href="https://developers.google.com/maps/documentation/javascript/libraries." />
/// </summary>
type [<AllowNullLiteral>] MapsServerErrorStatic =
    /// <summary>
    /// Represents a server-side error from a web service (i.e. the equivalent of
    /// a 5xx code in HTTP).
    ///
    /// Access by calling `const {MapsServerError} = await
    /// google.maps.importLibrary("core")`. See
    /// <see href="https://developers.google.com/maps/documentation/javascript/libraries." />
    /// </summary>
    [<EmitConstructor>] abstract Create: unit -> MapsServerError

/// <summary>
/// Access by calling `const {Marker} = await
/// google.maps.importLibrary("marker")`. See
/// <see href="https://developers.google.com/maps/documentation/javascript/libraries." />
/// </summary>
type [<AllowNullLiteral>] Marker =
    inherit Google.Maps.MVCObject
    /// Get the currently running animation.
    abstract getAnimation: unit -> Google.Maps.Animation option
    /// <summary>Get the clickable status of the <see cref="google.maps.Marker" />.</summary>
    abstract getClickable: unit -> bool
    /// Get the mouse cursor type shown on hover.
    abstract getCursor: unit -> string option
    /// <summary>Get the draggable status of the <see cref="google.maps.Marker" />.</summary>
    abstract getDraggable: unit -> bool
    /// <summary>Get the icon of the <see cref="google.maps.Marker" />. See <see cref="*">google.maps.MarkerOptions.icon</see>.</summary>
    abstract getIcon: unit -> U3<string, Google.Maps.Icon, Google.Maps.Symbol> option
    /// <summary>Get the label of the <see cref="google.maps.Marker" />. See <see cref="*">google.maps.MarkerOptions.label</see>.</summary>
    abstract getLabel: unit -> U2<Google.Maps.MarkerLabel, string> option
    /// <summary>Get the map or panaroama the <see cref="google.maps.Marker" /> is rendered on.</summary>
    abstract getMap: unit -> U2<Google.Maps.Map, Google.Maps.StreetViewPanorama> option
    /// <summary>Get the opacity of the <see cref="google.maps.Marker" />.</summary>
    abstract getOpacity: unit -> float option
    /// <summary>Get the position of the <see cref="google.maps.Marker" />.</summary>
    abstract getPosition: unit -> Google.Maps.LatLng option
    /// <summary>
    /// Get the shape of the <see cref="google.maps.Marker" /> used for interaction.
    /// See <see cref="google.maps.MarkerOptions.shape" /> and <see cref="*">google.maps.MarkerShape</see>.
    /// </summary>
    abstract getShape: unit -> Google.Maps.MarkerShape option
    /// <summary>Get the title of the <see cref="google.maps.Marker" /> tooltip. See <see cref="*">google.maps.MarkerOptions.title</see>.</summary>
    abstract getTitle: unit -> string option
    /// <summary>Get the visibility of the <see cref="google.maps.Marker" />.</summary>
    abstract getVisible: unit -> bool
    /// <summary>Get the zIndex of the <see cref="google.maps.Marker" />. See <see cref="*">google.maps.MarkerOptions.zIndex</see>.</summary>
    abstract getZIndex: unit -> float option
    /// <summary>
    /// Start an animation. Any ongoing animation will be cancelled. Currently
    /// supported animations are: <see cref="google.maps.Animation.BOUNCE" />, <see cref="*">google.maps.Animation.DROP</see>. Passing in &lt;code&gt;null&lt;/code&gt; will cause any
    /// animation to stop.
    /// </summary>
    /// <param name="animation">The animation to play.</param>
    abstract setAnimation: ?animation: Google.Maps.Animation -> unit
    /// <summary>Set if the <see cref="google.maps.Marker" /> is clickable.</summary>
    /// <param name="flag">If &lt;code&gt;true&lt;/code&gt;, the Marker can be clicked.</param>
    abstract setClickable: flag: bool -> unit
    /// <summary>Set the mouse cursor type shown on hover.</summary>
    /// <param name="cursor">Mouse cursor type.</param>
    abstract setCursor: ?cursor: string -> unit
    /// <summary>Set if the <see cref="google.maps.Marker" /> is draggable.</summary>
    /// <param name="flag">If &lt;code&gt;true&lt;/code&gt;, the Marker can be dragged.</param>
    abstract setDraggable: flag: bool option -> unit
    /// <summary>Set the icon for the <see cref="google.maps.Marker" />. See <see cref="*">google.maps.MarkerOptions.icon</see>.</summary>
    abstract setIcon: ?icon: U3<string, Google.Maps.Icon, Google.Maps.Symbol> -> unit
    /// <summary>Set the label for the <see cref="google.maps.Marker" />. See <see cref="*">google.maps.MarkerOptions.label</see>.</summary>
    /// <param name="label">The label can either be a character string or a {@link  *     google.maps.MarkerLabel} object.</param>
    abstract setLabel: ?label: U2<string, Google.Maps.MarkerLabel> -> unit
    /// <summary>
    /// Renders the <see cref="google.maps.Marker" /> on the specified map or panorama.
    /// If map is set to &lt;code&gt;null&lt;/code&gt;, the marker will be removed.
    /// </summary>
    abstract setMap: map: U2<Google.Maps.Map, Google.Maps.StreetViewPanorama> option -> unit
    /// <summary>Set the opacity of the <see cref="google.maps.Marker" />.</summary>
    /// <param name="opacity">A number between 0.0, transparent, and 1.0, opaque.</param>
    abstract setOpacity: ?opacity: float -> unit
    /// <summary>Set the options for the <see cref="google.maps.Marker" />.</summary>
    abstract setOptions: options: Google.Maps.MarkerOptions option -> unit
    /// <summary>Set the postition for the <see cref="google.maps.Marker" />.</summary>
    /// <param name="latlng">The new position.</param>
    abstract setPosition: ?latlng: U2<Google.Maps.LatLng, Google.Maps.LatLngLiteral> -> unit
    /// <summary>
    /// Set the shape of the <see cref="google.maps.Marker" /> used for interaction.
    /// See <see cref="google.maps.MarkerOptions.shape" /> and <see cref="*">google.maps.MarkerShape</see>.
    /// </summary>
    abstract setShape: ?shape: Google.Maps.MarkerShape -> unit
    /// <summary>Set the title of the <see cref="google.maps.Marker" /> tooltip. See <see cref="*">google.maps.MarkerOptions.title</see>.</summary>
    abstract setTitle: ?title: string -> unit
    /// <summary>Set if the <see cref="google.maps.Marker" /> is visible.</summary>
    /// <param name="visible">If &lt;code&gt;true&lt;/code&gt;, the Marker is visible</param>
    abstract setVisible: visible: bool -> unit
    /// <summary>Set the zIndex of the <see cref="google.maps.Marker" />. See <see cref="*">google.maps.MarkerOptions.zIndex</see>.</summary>
    abstract setZIndex: ?zIndex: float -> unit

/// <summary>
/// Access by calling `const {Marker} = await
/// google.maps.importLibrary("marker")`. See
/// <see href="https://developers.google.com/maps/documentation/javascript/libraries." />
/// </summary>
type [<AllowNullLiteral>] MarkerStatic =
    /// <summary>
    /// Access by calling `const {Marker} = await
    /// google.maps.importLibrary("marker")`. See
    /// <see href="https://developers.google.com/maps/documentation/javascript/libraries." />
    /// </summary>
    /// <param name="opts">Named optional arguments</param>
    [<EmitConstructor>] abstract Create: ?opts: Google.Maps.MarkerOptions -> Marker
    /// The maximum default z-index that the API will assign to a marker. You may
    /// set a higher z-index to bring a marker to the front.
    abstract MAX_ZINDEX: float

/// These options specify the appearance of a marker label. A marker label is a
/// string (often a single character) which will appear inside the marker. If
/// you are using it with a custom marker, you can reposition it with the
/// &lt;code&gt;labelOrigin&lt;/code&gt; property in the &lt;code&gt;Icon&lt;/code&gt; class.
type [<AllowNullLiteral>] MarkerLabel =
    /// <summary>
    /// The className property of the label&amp;#39;s element (equivalent to the
    /// element&amp;#39;s class attribute). Multiple space-separated CSS classes can
    /// be added. The font color, size, weight, and family can only be set via
    /// the other properties of &lt;code&gt;MarkerLabel&lt;/code&gt;. CSS classes should not
    /// be used to change the position nor orientation of the label (e.g. using
    /// translations and rotations) if also using &lt;a
    /// href="<see href="https://developers.google.com/maps/documentation/javascript/examples/marker-collision-management"&gt;marker" />
    /// collision management&lt;/a&gt;.
    /// </summary>
    /// <default>&lt;code&gt;&amp;#39;&amp;#39;&lt;/code&gt; (empty string)</default>
    abstract className: string option with get, set
    /// <summary>The color of the label text.</summary>
    /// <default>&lt;code&gt;&amp;#39;black&amp;#39;&lt;/code&gt;</default>
    abstract color: string option with get, set
    /// The font family of the label text (equivalent to the CSS font-family
    /// property).
    abstract fontFamily: string option with get, set
    /// <summary>
    /// The font size of the label text (equivalent to the CSS font-size
    /// property).
    /// </summary>
    /// <default>&lt;code&gt;&amp;#39;14px&amp;#39;&lt;/code&gt;</default>
    abstract fontSize: string option with get, set
    /// The font weight of the label text (equivalent to the CSS font-weight
    /// property).
    abstract fontWeight: string option with get, set
    /// The text to be displayed in the label.
    abstract text: string with get, set

type [<AllowNullLiteral>] MarkerLibrary =
    abstract AdvancedMarkerClickEvent: obj with get, set
    abstract AdvancedMarkerElement: obj with get, set
    abstract Animation: obj with get, set
    abstract CollisionBehavior: obj with get, set
    abstract Marker: obj with get, set
    abstract PinElement: obj with get, set

/// MarkerOptions object used to define the properties that can be set on a
/// Marker.
type [<AllowNullLiteral>] MarkerOptions =
    /// The offset from the marker&#39;s position to the tip of an InfoWindow
    /// that has been opened with the marker as anchor.
    abstract anchorPoint: Google.Maps.Point option with get, set
    /// <summary>Which animation to play when marker is added to a map.</summary>
    /// <default>&lt;code&gt;null&lt;/code&gt;</default>
    abstract animation: Google.Maps.Animation option with get, set
    /// <summary>If &lt;code&gt;true&lt;/code&gt;, the marker receives mouse and touch events.</summary>
    /// <default>&lt;code&gt;true&lt;/code&gt;</default>
    abstract clickable: bool option with get, set
    /// <summary>
    /// Available only in the v=beta channel: <see href="https://goo.gle/3oAthT3." />
    /// Set a collision behavior for markers on vector maps.
    /// </summary>
    /// <default>&lt;code&gt;null&lt;/code&gt;</default>
    [<Obsolete("<code>collisionBehavior</code> is deprecated as of July 2023.
Use {@link  *     google.maps.marker.AdvancedMarkerElement.collisionBehavior} instead.")>]
    abstract collisionBehavior: string option with get, set
    /// <summary>
    /// If &lt;code&gt;false&lt;/code&gt;, disables cross that appears beneath the marker
    /// when dragging.
    /// </summary>
    /// <default>&lt;code&gt;true&lt;/code&gt;</default>
    abstract crossOnDrag: bool option with get, set
    /// <summary>Mouse cursor type to show on hover.</summary>
    /// <default>&lt;code&gt;pointer&lt;/code&gt;</default>
    abstract cursor: string option with get, set
    /// <summary>If &lt;code&gt;true&lt;/code&gt;, the marker can be dragged.</summary>
    /// <default>&lt;code&gt;false&lt;/code&gt;</default>
    abstract draggable: bool option with get, set
    /// Icon for the foreground. If a string is provided, it is treated as though
    /// it were an &lt;code&gt;Icon&lt;/code&gt; with the string as &lt;code&gt;url&lt;/code&gt;.
    abstract icon: U3<string, Google.Maps.Icon, Google.Maps.Symbol> option with get, set
    /// <summary>
    /// Adds a label to the marker. A marker label is a letter or number that
    /// appears inside a marker. The label can either be a string, or a
    /// &lt;code&gt;MarkerLabel&lt;/code&gt; object. If provided and <see cref="*">google.maps.MarkerOptions.title</see> is not provided, an accessibility text
    /// (e.g. for use with screen readers) will be added to the marker with the
    /// provided label&amp;#39;s text. Please note that the &lt;code&gt;label&lt;/code&gt; is
    /// currently only used for accessibility text for non-optimized markers.
    /// </summary>
    /// <default>&lt;code&gt;null&lt;/code&gt;</default>
    abstract label: U2<string, Google.Maps.MarkerLabel> option with get, set
    /// <summary>
    /// Map on which to display Marker. The map is required to display the marker
    /// and can be provided with <see cref="google.maps.Marker.setMap" /> if not
    /// provided at marker construction.
    /// </summary>
    abstract map: U2<Google.Maps.Map, Google.Maps.StreetViewPanorama> option with get, set
    /// <summary>A number between 0.0, transparent, and 1.0, opaque.</summary>
    /// <default>1.0</default>
    abstract opacity: float option with get, set
    /// <summary>
    /// Optimization enhances performance by rendering many markers as a single
    /// static element. This is useful in cases where a large number of markers
    /// is required. Read more about &lt;a
    /// href="<see href="https://developers.google.com/maps/documentation/javascript/markers#optimize"&gt;marker" />
    /// optimization&lt;/a&gt;.
    /// </summary>
    abstract optimized: bool option with get, set
    /// <summary>
    /// Sets the marker position. A marker may be constructed but not displayed
    /// until its position is provided - for example, by a user&amp;#39;s actions or
    /// choices. A marker position can be provided with <see cref="*">google.maps.Marker.setPosition</see> if not provided at marker construction.
    /// </summary>
    abstract position: U2<Google.Maps.LatLng, Google.Maps.LatLngLiteral> option with get, set
    /// Image map region definition used for drag/click.
    abstract shape: Google.Maps.MarkerShape option with get, set
    /// <summary>
    /// Rollover text. If provided, an accessibility text (e.g. for use with
    /// screen readers) will be added to the marker with the provided value.
    /// Please note that the &lt;code&gt;title&lt;/code&gt; is currently only used for
    /// accessibility text for non-optimized markers.
    /// </summary>
    /// <default>&lt;code&gt;undefined&lt;/code&gt;</default>
    abstract title: string option with get, set
    /// <summary>If &lt;code&gt;true&lt;/code&gt;, the marker is visible.</summary>
    /// <default>&lt;code&gt;true&lt;/code&gt;</default>
    abstract visible: bool option with get, set
    /// All markers are displayed on the map in order of their zIndex, with
    /// higher values displaying in front of markers with lower values. By
    /// default, markers are displayed according to their vertical position on
    /// screen, with lower markers appearing in front of markers further up the
    /// screen.
    abstract zIndex: float option with get, set

/// This object defines the clickable region of a marker image. The shape
/// consists of two properties &amp;mdash; &lt;code&gt;type&lt;/code&gt; and &lt;code&gt;coord&lt;/code&gt;
/// &amp;mdash; which define the non-transparent region of an image.
type [<AllowNullLiteral>] MarkerShape =
    /// <summary>
    /// The format of this attribute depends on the value of the
    /// &lt;code&gt;type&lt;/code&gt; and follows the w3 AREA &lt;code&gt;coords&lt;/code&gt;
    /// specification found at &lt;a
    /// href="<see href="http://www.w3.org/TR/REC-html40/struct/objects.html#adef-coords"&gt;" />
    /// <see href="http://www.w3.org/TR/REC-html40/struct/objects.html#adef-coords&lt;/a&gt;." />
    /// &lt;br&gt;The &lt;code&gt;coords&lt;/code&gt; attribute is an array of integers that
    /// specify the pixel position of the shape relative to the top-left corner
    /// of the target image. The coordinates depend on the value of
    /// &lt;code&gt;type&lt;/code&gt; as follows: &lt;br&gt;&amp;nbsp;&amp;nbsp;- &lt;code&gt;circle&lt;/code&gt;:
    /// coords is &lt;code&gt;[x1,y1,r]&lt;/code&gt; where x1,y2 are the coordinates of the
    /// center of the circle, and r is the radius of the circle.
    /// &lt;br&gt;&amp;nbsp;&amp;nbsp;- &lt;code&gt;poly&lt;/code&gt;: coords is
    /// &lt;code&gt;[x1,y1,x2,y2...xn,yn]&lt;/code&gt; where each x,y pair contains the
    /// coordinates of one vertex of the polygon. &lt;br&gt;&amp;nbsp;&amp;nbsp;-
    /// &lt;code&gt;rect&lt;/code&gt;: coords is &lt;code&gt;[x1,y1,x2,y2]&lt;/code&gt; where x1,y1 are
    /// the coordinates of the upper-left corner of the rectangle and x2,y2 are
    /// the coordinates of the lower-right coordinates of the rectangle.
    /// </summary>
    abstract coords: ResizeArray<float> option with get, set
    /// Describes the shape&amp;#39;s type and can be &lt;code&gt;circle&lt;/code&gt;,
    /// &lt;code&gt;poly&lt;/code&gt; or &lt;code&gt;rect&lt;/code&gt;.
    abstract ``type``: string with get, set

/// A MaxZoom result in JSON format retrieved from the MaxZoomService.
type [<AllowNullLiteral>] MaxZoomResult =
    /// <summary>
    /// Status of the request. This property is only defined when using callbacks
    /// with <see cref="google.maps.MaxZoomService.getMaxZoomAtLatLng" /> (it is not
    /// defined when using Promises).
    /// </summary>
    abstract status: Google.Maps.MaxZoomStatus option with get, set
    /// The maximum zoom level found at the given &lt;code&gt;LatLng&lt;/code&gt;.
    abstract zoom: float with get, set

/// <summary>
/// A service for obtaining the highest zoom level at which satellite imagery
/// is available for a given location.
///
/// Access by calling `const {MaxZoomService} = await
/// google.maps.importLibrary("maps")`. See
/// <see href="https://developers.google.com/maps/documentation/javascript/libraries." />
/// </summary>
type [<AllowNullLiteral>] MaxZoomService =
    /// Returns the maximum zoom level for which detailed imagery is available at
    /// a particular &lt;code&gt;LatLng&lt;/code&gt; for the &lt;code&gt;satellite&lt;/code&gt; map type.
    /// As this request is asynchronous, you must pass a &lt;code&gt;callback&lt;/code&gt;
    /// function which will be executed upon completion of the request, being
    /// passed a &lt;code&gt;MaxZoomResult&lt;/code&gt;.
    abstract getMaxZoomAtLatLng: latlng: U2<Google.Maps.LatLng, Google.Maps.LatLngLiteral> * ?callback: (Google.Maps.MaxZoomResult -> unit) -> Promise<Google.Maps.MaxZoomResult>

/// <summary>
/// A service for obtaining the highest zoom level at which satellite imagery
/// is available for a given location.
///
/// Access by calling `const {MaxZoomService} = await
/// google.maps.importLibrary("maps")`. See
/// <see href="https://developers.google.com/maps/documentation/javascript/libraries." />
/// </summary>
type [<AllowNullLiteral>] MaxZoomServiceStatic =
    [<EmitConstructor>] abstract Create: unit -> MaxZoomService

/// <summary>
/// The status returned by the &lt;code&gt;MaxZoomService&lt;/code&gt; on the completion of
/// a call to &lt;code&gt;getMaxZoomAtLatLng()&lt;/code&gt;. Specify these by value, or by
/// using the constant&amp;#39;s name. For example, &lt;code&gt;'OK'&lt;/code&gt; or
/// &lt;code&gt;google.maps.MaxZoomStatus.OK&lt;/code&gt;.
///
/// Access by calling `const {MaxZoomStatus} = await
/// google.maps.importLibrary("maps")`. See
/// <see href="https://developers.google.com/maps/documentation/javascript/libraries." />
/// </summary>
type [<StringEnum>] [<RequireQualifiedAccess>] MaxZoomStatus =
    /// An unknown error occurred.
    | [<CompiledName("ERROR")>] ERROR
    /// The response contains a valid &lt;code&gt;MaxZoomResult&lt;/code&gt;.
    | [<CompiledName("OK")>] OK

/// Options for the rendering of the motion tracking control.
type [<AllowNullLiteral>] MotionTrackingControlOptions =
    /// <summary>
    /// Position id. This is used to specify the position of this control on the
    /// panorama.
    /// </summary>
    /// <default><see cref="google.maps.ControlPosition.INLINE_END_BLOCK_END" /></default>
    abstract position: Google.Maps.ControlPosition option with get, set

/// <summary>
/// You can implement this class if you want to display custom types of overlay
/// objects on the map. &lt;br&gt;&lt;br&gt;Inherit from this class by setting your
/// overlay&amp;#39;s prototype: &lt;code&gt;MyOverlay.prototype = new
/// google.maps.OverlayView();&lt;/code&gt;. The &lt;code&gt;OverlayView&lt;/code&gt; constructor
/// is guaranteed to be an empty function. &lt;br&gt;&lt;br&gt;You must implement three
/// methods: &lt;code&gt;onAdd()&lt;/code&gt;, &lt;code&gt;draw()&lt;/code&gt;, and
/// &lt;code&gt;onRemove()&lt;/code&gt;. &lt;ul&gt; &lt;li&gt;In the &lt;code&gt;onAdd()&lt;/code&gt; method, you
/// should create DOM objects and append them as children of the panes.&lt;/li&gt;
/// &lt;li&gt;In the &lt;code&gt;draw()&lt;/code&gt; method, you should position these
/// elements.&lt;/li&gt; &lt;li&gt;In the &lt;code&gt;onRemove()&lt;/code&gt; method, you should remove
/// the objects from the DOM.&lt;/li&gt; &lt;/ul&gt; You must call &lt;code&gt;setMap()&lt;/code&gt;
/// with a valid &lt;code&gt;Map&lt;/code&gt; object to trigger the call to the
/// &lt;code&gt;onAdd()&lt;/code&gt; method and &lt;code&gt;setMap(null)&lt;/code&gt; in order to
/// trigger the &lt;code&gt;onRemove()&lt;/code&gt; method. The &lt;code&gt;setMap()&lt;/code&gt;
/// method can be called at the time of construction or at any point afterward
/// when the overlay should be re-shown after removing. The &lt;code&gt;draw()&lt;/code&gt;
/// method will then be called whenever a map property changes that could
/// change the position of the element, such as zoom, center, or map type.
///
/// Access by calling `const {OverlayView} = await
/// google.maps.importLibrary("maps")<c> or </c>const {OverlayView} = await
/// google.maps.importLibrary("streetView")`. See
/// <see href="https://developers.google.com/maps/documentation/javascript/libraries." />
/// </summary>
type [<AllowNullLiteral>] OverlayView =
    inherit Google.Maps.MVCObject
    /// Implement this method to draw or update the overlay. Use the position
    /// from projection.fromLatLngToDivPixel() to correctly position the overlay
    /// relative to the MapPanes. This method is called after onAdd(), and is
    /// called on change of zoom or center. It is not recommended to do
    /// computationally expensive work in this method.
    abstract draw: unit -> unit
    abstract getMap: unit -> U2<Google.Maps.Map, Google.Maps.StreetViewPanorama> option
    /// Returns the panes in which this OverlayView can be rendered. The panes
    /// are not initialized until &lt;code&gt;onAdd&lt;/code&gt; is called by the API.
    abstract getPanes: unit -> Google.Maps.MapPanes option
    /// Returns the &lt;code&gt;MapCanvasProjection&lt;/code&gt; object associated with this
    /// &lt;code&gt;OverlayView&lt;/code&gt;. The projection is not initialized until
    /// &lt;code&gt;onAdd&lt;/code&gt; is called by the API.
    abstract getProjection: unit -> Google.Maps.MapCanvasProjection
    /// Implement this method to initialize the overlay DOM elements. This method
    /// is called once after setMap() is called with a valid map. At this point,
    /// panes and projection will have been initialized.
    abstract onAdd: unit -> unit
    /// Implement this method to remove your elements from the DOM. This method
    /// is called once following a call to setMap(null).
    abstract onRemove: unit -> unit
    /// <summary>Adds the overlay to the map or panorama.</summary>
    /// <param name="map">
    /// The map or panorama. If &lt;code&gt;null&lt;/code&gt;, the layer will be
    /// removed.
    /// </param>
    abstract setMap: map: U2<Google.Maps.Map, Google.Maps.StreetViewPanorama> option -> unit

/// <summary>
/// You can implement this class if you want to display custom types of overlay
/// objects on the map. &lt;br&gt;&lt;br&gt;Inherit from this class by setting your
/// overlay&amp;#39;s prototype: &lt;code&gt;MyOverlay.prototype = new
/// google.maps.OverlayView();&lt;/code&gt;. The &lt;code&gt;OverlayView&lt;/code&gt; constructor
/// is guaranteed to be an empty function. &lt;br&gt;&lt;br&gt;You must implement three
/// methods: &lt;code&gt;onAdd()&lt;/code&gt;, &lt;code&gt;draw()&lt;/code&gt;, and
/// &lt;code&gt;onRemove()&lt;/code&gt;. &lt;ul&gt; &lt;li&gt;In the &lt;code&gt;onAdd()&lt;/code&gt; method, you
/// should create DOM objects and append them as children of the panes.&lt;/li&gt;
/// &lt;li&gt;In the &lt;code&gt;draw()&lt;/code&gt; method, you should position these
/// elements.&lt;/li&gt; &lt;li&gt;In the &lt;code&gt;onRemove()&lt;/code&gt; method, you should remove
/// the objects from the DOM.&lt;/li&gt; &lt;/ul&gt; You must call &lt;code&gt;setMap()&lt;/code&gt;
/// with a valid &lt;code&gt;Map&lt;/code&gt; object to trigger the call to the
/// &lt;code&gt;onAdd()&lt;/code&gt; method and &lt;code&gt;setMap(null)&lt;/code&gt; in order to
/// trigger the &lt;code&gt;onRemove()&lt;/code&gt; method. The &lt;code&gt;setMap()&lt;/code&gt;
/// method can be called at the time of construction or at any point afterward
/// when the overlay should be re-shown after removing. The &lt;code&gt;draw()&lt;/code&gt;
/// method will then be called whenever a map property changes that could
/// change the position of the element, such as zoom, center, or map type.
///
/// Access by calling `const {OverlayView} = await
/// google.maps.importLibrary("maps")<c> or </c>const {OverlayView} = await
/// google.maps.importLibrary("streetView")`. See
/// <see href="https://developers.google.com/maps/documentation/javascript/libraries." />
/// </summary>
type [<AllowNullLiteral>] OverlayViewStatic =
    [<EmitConstructor>] abstract Create: unit -> OverlayView
    /// Stops click, tap, drag, and wheel events on the element from bubbling up
    /// to the map. Use this to prevent map dragging and zooming, as well as map
    /// &quot;click&quot; events.
    abstract preventMapHitsAndGesturesFrom: this: obj option * element: Element -> unit
    /// Stops click or tap on the element from bubbling up to the map. Use this
    /// to prevent the map from triggering &quot;click&quot; events.
    abstract preventMapHitsFrom: this: obj option * element: Element -> unit

type [<AllowNullLiteral>] Padding =
    /// Padding for the bottom, in pixels.
    abstract bottom: float option with get, set
    /// Padding for the left, in pixels.
    abstract left: float option with get, set
    /// Padding for the right, in pixels.
    abstract right: float option with get, set
    /// Padding for the top, in pixels.
    abstract top: float option with get, set

/// Options for the rendering of the pan control.
type [<AllowNullLiteral>] PanControlOptions =
    /// <summary>Position id. Used to specify the position of the control on the map.</summary>
    /// <default><see cref="google.maps.ControlPosition.INLINE_END_BLOCK_END" /></default>
    abstract position: Google.Maps.ControlPosition option with get, set

/// Options for the Custom Pano Provider.
type [<AllowNullLiteral>] PanoProviderOptions =
    /// If set, the renderer will use technologies (like webgl) that only work
    /// when cors headers are appropriately set on the provided images. It is the
    /// developer&#39;s task to serve the images correctly in combination with
    /// this flag, which might otherwise lead to SecurityErrors.
    abstract cors: bool option with get, set

/// An elevation query sent by the &lt;code&gt;ElevationService&lt;/code&gt; containing the
/// path along which to return sampled data. This request defines a continuous
/// path along the earth along which elevation samples should be taken at
/// evenly-spaced distances. All paths from vertex to vertex use segments of
/// the great circle between those two points.
type [<AllowNullLiteral>] PathElevationRequest =
    /// The path along which to collect elevation values.
    abstract path: Array<U2<Google.Maps.LatLng, Google.Maps.LatLngLiteral>> option with get, set
    /// Required. The number of equidistant points along the given path for which
    /// to retrieve elevation data, including the endpoints. The number of
    /// samples must be a value between 2 and 512 inclusive.
    abstract samples: float with get, set

/// <summary>
/// An elevation response returned by the <see cref="google.maps.ElevationService" />
/// containing the list of <see cref="google.maps.ElevationResult" />s evenly-spaced
/// along the path of the <see cref="google.maps.PathElevationRequest" />.
/// </summary>
type [<AllowNullLiteral>] PathElevationResponse =
    /// <summary>
    /// The list of <see cref="google.maps.ElevationResult" />s matching the samples of
    /// the <see cref="google.maps.PathElevationRequest" />.
    /// </summary>
    abstract results: ResizeArray<Google.Maps.ElevationResult> with get, set

/// <summary>
/// Contains information needed to locate, identify, or describe a place for
/// a <see cref="google.maps.DirectionsRequest" /> or <see cref="*">google.maps.DistanceMatrixRequest</see>. In this context, &amp;quot;place&amp;quot;
/// means a business, point of interest, or geographic location. For fetching
/// information about a place, see <see cref="google.maps.places.PlacesService" />.
/// </summary>
type [<AllowNullLiteral>] Place =
    /// The &lt;code&gt;LatLng&lt;/code&gt; of the entity described by this place.
    abstract location: U2<Google.Maps.LatLng, Google.Maps.LatLngLiteral> option with get, set
    /// <summary>
    /// The place ID of the place (such as a business or point of interest). The
    /// place ID is a unique identifier of a place in the Google Maps database.
    /// Note that the &lt;code&gt;placeId&lt;/code&gt; is the most accurate way of
    /// identifying a place. If possible, you should specify the
    /// &lt;code&gt;placeId&lt;/code&gt; rather than a &lt;code&gt;query&lt;/code&gt;. A place ID can be
    /// retrieved from any request to the Places API, such as a &lt;a
    /// href="<see href="https://developers.google.com/maps/documentation/places/web-service/search"&gt;TextSearch&lt;/a&gt;." />
    /// Place IDs can also be retrieved from requests to the Geocoding API. For
    /// more information, see the &lt;a
    /// href="<see href="https://developers.google.com/maps/documentation/places/web-service/place-id"&gt;overview" />
    /// of place IDs&lt;/a&gt;.
    /// </summary>
    abstract placeId: string option with get, set
    /// A search query describing the place (such as a business or point of
    /// interest). An example query is &amp;quot;Quay, Upper Level, Overseas
    /// Passenger Terminal 5 Hickson Road, The Rocks NSW&amp;quot;. If possible, you
    /// should specify the &lt;code&gt;placeId&lt;/code&gt; rather than a &lt;code&gt;query&lt;/code&gt;.
    /// The API does not guarantee the accuracy of resolving the query string to
    /// a place. If both the &lt;code&gt;placeId&lt;/code&gt; and &lt;code&gt;query&lt;/code&gt; are
    /// provided, an error occurs.
    abstract query: string option with get, set

/// <summary>
/// An interface representing a feature with a place ID which includes features
/// of type <see cref="google.maps.FeatureType.ADMINISTRATIVE_AREA_LEVEL_1" />, <see cref="*">google.maps.FeatureType.ADMINISTRATIVE_AREA_LEVEL_2</see>, <see cref="*">google.maps.FeatureType.COUNTRY</see>, <see cref="*">google.maps.FeatureType.LOCALITY</see>, <see cref="*">google.maps.FeatureType.POSTAL_CODE</see>, and <see cref="*">google.maps.FeatureType.SCHOOL_DISTRICT</see>.
/// </summary>
type [<AllowNullLiteral>] PlaceFeature =
    inherit Google.Maps.Feature
    /// Fetches a &lt;code&gt;Place&lt;/code&gt; for this &lt;code&gt;PlaceFeature&lt;/code&gt;. In the
    /// resulting &lt;code&gt;Place&lt;/code&gt; object, the &lt;code&gt;id&lt;/code&gt; and the
    /// &lt;code&gt;displayName&lt;/code&gt; properties will be populated. The display name
    /// will be in the language the end user sees on the map. (Additional fields
    /// can be subsequently requested via &lt;code&gt;Place.fetchFields()&lt;/code&gt;
    /// subject to normal Places API enablement and billing.) Do not call this
    /// from a &lt;code&gt;FeatureStyleFunction&lt;/code&gt; since only synchronous
    /// FeatureStyleFunctions are supported. The promise is rejected if there was
    /// an error fetching the &lt;code&gt;Place&lt;/code&gt;.
    abstract fetchPlace: unit -> Promise<Google.Maps.Places.Place>
    /// <summary>The <see cref="google.maps.places.PlaceResult.place_id" />.</summary>
    abstract placeId: string with get, set

type [<AllowNullLiteral>] PlacesLibrary =
    abstract AddressComponent: obj with get, set
    abstract Attribution: obj with get, set
    abstract AuthorAttribution: obj with get, set
    abstract Autocomplete: obj with get, set
    abstract AutocompleteService: obj with get, set
    abstract AutocompleteSessionToken: obj with get, set
    abstract BusinessStatus: obj with get, set
    abstract OpeningHours: obj with get, set
    abstract OpeningHoursPeriod: obj with get, set
    abstract OpeningHoursPoint: obj with get, set
    abstract Photo: obj with get, set
    abstract Place: obj with get, set
    abstract PlacesService: obj with get, set
    abstract PlacesServiceStatus: obj with get, set
    abstract PlusCode: obj with get, set
    abstract PriceLevel: obj with get, set
    abstract RankBy: obj with get, set
    abstract Review: obj with get, set
    abstract SearchBox: obj with get, set

/// <summary>
/// Access by calling `const {Point} = await
/// google.maps.importLibrary("core")`. See
/// <see href="https://developers.google.com/maps/documentation/javascript/libraries." />
/// </summary>
type [<AllowNullLiteral>] Point =
    /// Compares two Points
    abstract equals: other: Google.Maps.Point option -> bool
    /// Returns a string representation of this Point.
    abstract toString: unit -> string
    /// The X coordinate
    abstract x: float with get, set
    /// The Y coordinate
    abstract y: float with get, set

/// <summary>
/// Access by calling `const {Point} = await
/// google.maps.importLibrary("core")`. See
/// <see href="https://developers.google.com/maps/documentation/javascript/libraries." />
/// </summary>
type [<AllowNullLiteral>] PointStatic =
    /// <summary>
    /// Access by calling `const {Point} = await
    /// google.maps.importLibrary("core")`. See
    /// <see href="https://developers.google.com/maps/documentation/javascript/libraries." />
    /// </summary>
    [<EmitConstructor>] abstract Create: x: float * y: float -> Point

/// This object is returned from mouse events on polylines and polygons.
type [<AllowNullLiteral>] PolyMouseEvent =
    inherit Google.Maps.MapMouseEvent
    /// The index of the edge within the path beneath the cursor when the event
    /// occurred, if the event occurred on a mid-point on an editable polygon.
    abstract edge: float option with get, set
    /// The index of the path beneath the cursor when the event occurred, if the
    /// event occurred on a vertex and the polygon is editable. Otherwise
    /// &lt;code&gt;undefined&lt;/code&gt;.
    abstract path: float option with get, set
    /// The index of the vertex beneath the cursor when the event occurred, if
    /// the event occurred on a vertex and the polyline or polygon is editable.
    /// If the event does not occur on a vertex, the value is
    /// &lt;code&gt;undefined&lt;/code&gt;.
    abstract vertex: float option with get, set

/// <summary>
/// A polygon (like a polyline) defines a series of connected coordinates in an
/// ordered sequence. Additionally, polygons form a closed loop and define a
/// filled region. See the samples in the developer&amp;#39;s guide, starting with
/// a &lt;a
/// href="<see href="https://developers.google.com/maps/documentation/javascript/examples/polygon-simple"&gt;simple" />
/// polygon&lt;/a&gt;, a &lt;a
/// href="<see href="https://developers.google.com/maps/documentation/javascript/examples/polygon-hole"&gt;polygon" />
/// with a hole&lt;/a&gt;, and more. Note that you can also use the &lt;a
/// href="#Data.Polygon"&gt;Data layer&lt;/a&gt; to create a polygon. The Data layer
/// offers a simpler way of creating holes because it handles the order of the
/// inner and outer paths for you.
///
/// Access by calling `const {Polygon} = await
/// google.maps.importLibrary("maps")`. See
/// <see href="https://developers.google.com/maps/documentation/javascript/libraries." />
/// </summary>
type [<AllowNullLiteral>] Polygon =
    inherit Google.Maps.MVCObject
    /// Returns whether this shape can be dragged by the user.
    abstract getDraggable: unit -> bool
    /// Returns whether this shape can be edited by the user.
    abstract getEditable: unit -> bool
    /// Returns the map on which this shape is attached.
    abstract getMap: unit -> Google.Maps.Map option
    /// Retrieves the first path.
    abstract getPath: unit -> Google.Maps.MVCArray<Google.Maps.LatLng>
    /// Retrieves the paths for this polygon.
    abstract getPaths: unit -> Google.Maps.MVCArray<Google.Maps.MVCArray<Google.Maps.LatLng>>
    /// Returns whether this poly is visible on the map.
    abstract getVisible: unit -> bool
    /// If set to &lt;code&gt;true&lt;/code&gt;, the user can drag this shape over the map.
    /// The &lt;code&gt;geodesic&lt;/code&gt; property defines the mode of dragging.
    abstract setDraggable: draggable: bool -> unit
    /// If set to &lt;code&gt;true&lt;/code&gt;, the user can edit this shape by dragging the
    /// control points shown at the vertices and on each segment.
    abstract setEditable: editable: bool -> unit
    /// Renders this shape on the specified map. If map is set to
    /// &lt;code&gt;null&lt;/code&gt;, the shape will be removed.
    abstract setMap: map: Google.Maps.Map option -> unit
    abstract setOptions: options: Google.Maps.PolygonOptions option -> unit
    /// Sets the first path. See &lt;em&gt;&lt;code&gt;&lt;a
    /// href="#PolygonOptions"&gt;PolygonOptions&lt;/a&gt;&lt;/code&gt;&lt;/em&gt; for more details.
    abstract setPath: path: U2<Google.Maps.MVCArray<Google.Maps.LatLng>, Array<U2<Google.Maps.LatLng, Google.Maps.LatLngLiteral>>> -> unit
    /// Sets the path for this polygon.
    abstract setPaths: paths: U2<Google.Maps.MVCArray<obj option>, ResizeArray<obj option>> -> unit
    /// Hides this poly if set to &lt;code&gt;false&lt;/code&gt;.
    abstract setVisible: visible: bool -> unit

/// <summary>
/// A polygon (like a polyline) defines a series of connected coordinates in an
/// ordered sequence. Additionally, polygons form a closed loop and define a
/// filled region. See the samples in the developer&amp;#39;s guide, starting with
/// a &lt;a
/// href="<see href="https://developers.google.com/maps/documentation/javascript/examples/polygon-simple"&gt;simple" />
/// polygon&lt;/a&gt;, a &lt;a
/// href="<see href="https://developers.google.com/maps/documentation/javascript/examples/polygon-hole"&gt;polygon" />
/// with a hole&lt;/a&gt;, and more. Note that you can also use the &lt;a
/// href="#Data.Polygon"&gt;Data layer&lt;/a&gt; to create a polygon. The Data layer
/// offers a simpler way of creating holes because it handles the order of the
/// inner and outer paths for you.
///
/// Access by calling `const {Polygon} = await
/// google.maps.importLibrary("maps")`. See
/// <see href="https://developers.google.com/maps/documentation/javascript/libraries." />
/// </summary>
type [<AllowNullLiteral>] PolygonStatic =
    /// <summary>
    /// A polygon (like a polyline) defines a series of connected coordinates in
    /// an ordered sequence. Additionally, polygons form a closed loop and define
    /// a filled region. See the samples in the developer&amp;#39;s guide, starting
    /// with a &lt;a
    /// href="<see href="https://developers.google.com/maps/documentation/javascript/examples/polygon-simple"&gt;simple" />
    /// polygon&lt;/a&gt;, a &lt;a
    /// href="<see href="https://developers.google.com/maps/documentation/javascript/examples/polygon-hole"&gt;polygon" />
    /// with a hole&lt;/a&gt;, and more. Note that you can also use the &lt;a
    /// href="#Data.Polygon"&gt;Data layer&lt;/a&gt; to create a polygon. The Data layer
    /// offers a simpler way of creating holes because it handles the order of
    /// the inner and outer paths for you.
    ///
    /// Access by calling `const {Polygon} = await
    /// google.maps.importLibrary("maps")`. See
    /// <see href="https://developers.google.com/maps/documentation/javascript/libraries." />
    /// </summary>
    [<EmitConstructor>] abstract Create: ?opts: Google.Maps.PolygonOptions -> Polygon

/// PolygonOptions object used to define the properties that can be set on a
/// Polygon.
type [<AllowNullLiteral>] PolygonOptions =
    /// <summary>Indicates whether this &lt;code&gt;Polygon&lt;/code&gt; handles mouse events.</summary>
    /// <default>&lt;code&gt;true&lt;/code&gt;</default>
    abstract clickable: bool option with get, set
    /// <summary>
    /// If set to &lt;code&gt;true&lt;/code&gt;, the user can drag this shape over the map.
    /// The &lt;code&gt;geodesic&lt;/code&gt; property defines the mode of dragging.
    /// </summary>
    /// <default>&lt;code&gt;false&lt;/code&gt;</default>
    abstract draggable: bool option with get, set
    /// <summary>
    /// If set to &lt;code&gt;true&lt;/code&gt;, the user can edit this shape by dragging the
    /// control points shown at the vertices and on each segment.
    /// </summary>
    /// <default>&lt;code&gt;false&lt;/code&gt;</default>
    abstract editable: bool option with get, set
    /// The fill color. All CSS3 colors are supported except for extended named
    /// colors.
    abstract fillColor: string option with get, set
    /// The fill opacity between 0.0 and 1.0
    abstract fillOpacity: float option with get, set
    /// <summary>
    /// When &lt;code&gt;true&lt;/code&gt;, edges of the polygon are interpreted as geodesic
    /// and will follow the curvature of the Earth. When &lt;code&gt;false&lt;/code&gt;,
    /// edges of the polygon are rendered as straight lines in screen space. Note
    /// that the shape of a geodesic polygon may appear to change when dragged,
    /// as the dimensions are maintained relative to the surface of the earth.
    /// </summary>
    /// <default>&lt;code&gt;false&lt;/code&gt;</default>
    abstract geodesic: bool option with get, set
    /// Map on which to display Polygon.
    abstract map: Google.Maps.Map option with get, set
    /// The ordered sequence of coordinates that designates a closed loop. Unlike
    /// polylines, a polygon may consist of one or more paths. As a result, the
    /// paths property may specify one or more arrays of &lt;code&gt;LatLng&lt;/code&gt;
    /// coordinates. Paths are closed automatically; do not repeat the first
    /// vertex of the path as the last vertex. Simple polygons may be defined
    /// using a single array of &lt;code&gt;LatLng&lt;/code&gt;s. More complex polygons may
    /// specify an array of arrays. Any simple arrays are converted into &lt;code&gt;&lt;a
    /// href="#MVCArray"&gt;MVCArray&lt;/a&gt;&lt;/code&gt;s. Inserting or removing
    /// &lt;code&gt;LatLng&lt;/code&gt;s from the &lt;code&gt;MVCArray&lt;/code&gt; will automatically
    /// update the polygon on the map.
    abstract paths: U2<Google.Maps.MVCArray<obj option>, ResizeArray<obj option>> option with get, set
    /// The stroke color. All CSS3 colors are supported except for extended named
    /// colors.
    abstract strokeColor: string option with get, set
    /// The stroke opacity between 0.0 and 1.0
    abstract strokeOpacity: float option with get, set
    /// <summary>The stroke position.</summary>
    /// <default><see cref="google.maps.StrokePosition.CENTER" /></default>
    abstract strokePosition: Google.Maps.StrokePosition option with get, set
    /// The stroke width in pixels.
    abstract strokeWeight: float option with get, set
    /// <summary>Whether this polygon is visible on the map.</summary>
    /// <default>&lt;code&gt;true&lt;/code&gt;</default>
    abstract visible: bool option with get, set
    /// The zIndex compared to other polys.
    abstract zIndex: float option with get, set

/// <summary>
/// A polyline is a linear overlay of connected line segments on the map.
///
/// Access by calling `const {Polyline} = await
/// google.maps.importLibrary("maps")`. See
/// <see href="https://developers.google.com/maps/documentation/javascript/libraries." />
/// </summary>
type [<AllowNullLiteral>] Polyline =
    inherit Google.Maps.MVCObject
    /// Returns whether this shape can be dragged by the user.
    abstract getDraggable: unit -> bool
    /// Returns whether this shape can be edited by the user.
    abstract getEditable: unit -> bool
    /// Returns the map on which this shape is attached.
    abstract getMap: unit -> Google.Maps.Map option
    /// Retrieves the path.
    abstract getPath: unit -> Google.Maps.MVCArray<Google.Maps.LatLng>
    /// Returns whether this poly is visible on the map.
    abstract getVisible: unit -> bool
    /// If set to &lt;code&gt;true&lt;/code&gt;, the user can drag this shape over the map.
    /// The &lt;code&gt;geodesic&lt;/code&gt; property defines the mode of dragging.
    abstract setDraggable: draggable: bool -> unit
    /// If set to &lt;code&gt;true&lt;/code&gt;, the user can edit this shape by dragging the
    /// control points shown at the vertices and on each segment.
    abstract setEditable: editable: bool -> unit
    /// Renders this shape on the specified map. If map is set to
    /// &lt;code&gt;null&lt;/code&gt;, the shape will be removed.
    abstract setMap: map: Google.Maps.Map option -> unit
    abstract setOptions: options: Google.Maps.PolylineOptions option -> unit
    /// Sets the path. See &lt;em&gt;&lt;code&gt;&lt;a
    /// href="#PolylineOptions"&gt;PolylineOptions&lt;/a&gt;&lt;/code&gt;&lt;/em&gt; for more details.
    abstract setPath: path: U2<Google.Maps.MVCArray<Google.Maps.LatLng>, Array<U2<Google.Maps.LatLng, Google.Maps.LatLngLiteral>>> -> unit
    /// Hides this poly if set to &lt;code&gt;false&lt;/code&gt;.
    abstract setVisible: visible: bool -> unit

/// <summary>
/// A polyline is a linear overlay of connected line segments on the map.
///
/// Access by calling `const {Polyline} = await
/// google.maps.importLibrary("maps")`. See
/// <see href="https://developers.google.com/maps/documentation/javascript/libraries." />
/// </summary>
type [<AllowNullLiteral>] PolylineStatic =
    /// <summary>
    /// A polyline is a linear overlay of connected line segments on the map.
    ///
    /// Access by calling `const {Polyline} = await
    /// google.maps.importLibrary("maps")`. See
    /// <see href="https://developers.google.com/maps/documentation/javascript/libraries." />
    /// </summary>
    [<EmitConstructor>] abstract Create: ?opts: Google.Maps.PolylineOptions -> Polyline

/// PolylineOptions object used to define the properties that can be set on a
/// Polyline.
type [<AllowNullLiteral>] PolylineOptions =
    /// <summary>Indicates whether this &lt;code&gt;Polyline&lt;/code&gt; handles mouse events.</summary>
    /// <default>&lt;code&gt;true&lt;/code&gt;</default>
    abstract clickable: bool option with get, set
    /// <summary>
    /// If set to &lt;code&gt;true&lt;/code&gt;, the user can drag this shape over the map.
    /// The &lt;code&gt;geodesic&lt;/code&gt; property defines the mode of dragging.
    /// </summary>
    /// <default>&lt;code&gt;false&lt;/code&gt;</default>
    abstract draggable: bool option with get, set
    /// <summary>
    /// If set to &lt;code&gt;true&lt;/code&gt;, the user can edit this shape by dragging the
    /// control points shown at the vertices and on each segment.
    /// </summary>
    /// <default>&lt;code&gt;false&lt;/code&gt;</default>
    abstract editable: bool option with get, set
    /// <summary>
    /// When &lt;code&gt;true&lt;/code&gt;, edges of the polygon are interpreted as geodesic
    /// and will follow the curvature of the Earth. When &lt;code&gt;false&lt;/code&gt;,
    /// edges of the polygon are rendered as straight lines in screen space. Note
    /// that the shape of a geodesic polygon may appear to change when dragged,
    /// as the dimensions are maintained relative to the surface of the earth.
    /// </summary>
    /// <default>&lt;code&gt;false&lt;/code&gt;</default>
    abstract geodesic: bool option with get, set
    /// The icons to be rendered along the polyline.
    abstract icons: ResizeArray<Google.Maps.IconSequence> option with get, set
    /// Map on which to display Polyline.
    abstract map: Google.Maps.Map option with get, set
    /// The ordered sequence of coordinates of the Polyline. This path may be
    /// specified using either a simple array of &lt;code&gt;LatLng&lt;/code&gt;s, or an
    /// &lt;code&gt;MVCArray&lt;/code&gt; of &lt;code&gt;LatLng&lt;/code&gt;s. Note that if you pass a
    /// simple array, it will be converted to an &lt;code&gt;MVCArray&lt;/code&gt; Inserting
    /// or removing LatLngs in the &lt;code&gt;MVCArray&lt;/code&gt; will automatically
    /// update the polyline on the map.
    abstract path: U2<Google.Maps.MVCArray<Google.Maps.LatLng>, Array<U2<Google.Maps.LatLng, Google.Maps.LatLngLiteral>>> option with get, set
    /// The stroke color. All CSS3 colors are supported except for extended named
    /// colors.
    abstract strokeColor: string option with get, set
    /// The stroke opacity between 0.0 and 1.0.
    abstract strokeOpacity: float option with get, set
    /// The stroke width in pixels.
    abstract strokeWeight: float option with get, set
    /// <summary>Whether this polyline is visible on the map.</summary>
    /// <default>&lt;code&gt;true&lt;/code&gt;</default>
    abstract visible: bool option with get, set
    /// The zIndex compared to other polys.
    abstract zIndex: float option with get, set

type [<AllowNullLiteral>] Projection =
    /// Translates from the LatLng cylinder to the Point plane. This interface
    /// specifies a function which implements translation from given
    /// &lt;code&gt;LatLng&lt;/code&gt; values to world coordinates on the map projection.
    /// The Maps API calls this method when it needs to plot locations on screen.
    /// &lt;code&gt;Projection&lt;/code&gt; objects must implement this method, but may
    /// return &lt;code&gt;null&lt;/code&gt; if the projection cannot calculate the
    /// &lt;code&gt;Point&lt;/code&gt;.
    abstract fromLatLngToPoint: latLng: U2<Google.Maps.LatLng, Google.Maps.LatLngLiteral> * ?point: Google.Maps.Point -> Google.Maps.Point option
    /// This interface specifies a function which implements translation from
    /// world coordinates on a map projection to &lt;code&gt;LatLng&lt;/code&gt; values. The
    /// Maps API calls this method when it needs to translate actions on screen
    /// to positions on the map. &lt;code&gt;Projection&lt;/code&gt; objects must implement
    /// this method, but may return &lt;code&gt;null&lt;/code&gt; if the projection cannot
    /// calculate the &lt;code&gt;LatLng&lt;/code&gt;.
    abstract fromPointToLatLng: pixel: Google.Maps.Point * ?noClampNoWrap: bool -> Google.Maps.LatLng option

/// <summary>
/// A rectangle overlay.
///
/// Access by calling `const {Rectangle} = await
/// google.maps.importLibrary("maps")`. See
/// <see href="https://developers.google.com/maps/documentation/javascript/libraries." />
/// </summary>
type [<AllowNullLiteral>] Rectangle =
    inherit Google.Maps.MVCObject
    /// Returns the bounds of this rectangle.
    abstract getBounds: unit -> Google.Maps.LatLngBounds option
    /// Returns whether this rectangle can be dragged by the user.
    abstract getDraggable: unit -> bool
    /// Returns whether this rectangle can be edited by the user.
    abstract getEditable: unit -> bool
    /// Returns the map on which this rectangle is displayed.
    abstract getMap: unit -> Google.Maps.Map option
    /// Returns whether this rectangle is visible on the map.
    abstract getVisible: unit -> bool
    /// Sets the bounds of this rectangle.
    abstract setBounds: bounds: U2<Google.Maps.LatLngBounds, Google.Maps.LatLngBoundsLiteral> option -> unit
    /// If set to &lt;code&gt;true&lt;/code&gt;, the user can drag this rectangle over the
    /// map.
    abstract setDraggable: draggable: bool -> unit
    /// If set to &lt;code&gt;true&lt;/code&gt;, the user can edit this rectangle by dragging
    /// the control points shown at the corners and on each edge.
    abstract setEditable: editable: bool -> unit
    /// Renders the rectangle on the specified map. If map is set to
    /// &lt;code&gt;null&lt;/code&gt;, the rectangle will be removed.
    abstract setMap: map: Google.Maps.Map option -> unit
    abstract setOptions: options: Google.Maps.RectangleOptions option -> unit
    /// Hides this rectangle if set to &lt;code&gt;false&lt;/code&gt;.
    abstract setVisible: visible: bool -> unit

/// <summary>
/// A rectangle overlay.
///
/// Access by calling `const {Rectangle} = await
/// google.maps.importLibrary("maps")`. See
/// <see href="https://developers.google.com/maps/documentation/javascript/libraries." />
/// </summary>
type [<AllowNullLiteral>] RectangleStatic =
    /// <summary>
    /// A rectangle overlay.
    ///
    /// Access by calling `const {Rectangle} = await
    /// google.maps.importLibrary("maps")`. See
    /// <see href="https://developers.google.com/maps/documentation/javascript/libraries." />
    /// </summary>
    [<EmitConstructor>] abstract Create: ?opts: Google.Maps.RectangleOptions -> Rectangle

/// RectangleOptions object used to define the properties that can be set on a
/// Rectangle.
type [<AllowNullLiteral>] RectangleOptions =
    /// The bounds.
    abstract bounds: U2<Google.Maps.LatLngBounds, Google.Maps.LatLngBoundsLiteral> option with get, set
    /// <summary>Indicates whether this &lt;code&gt;Rectangle&lt;/code&gt; handles mouse events.</summary>
    /// <default>&lt;code&gt;true&lt;/code&gt;</default>
    abstract clickable: bool option with get, set
    /// <summary>
    /// If set to &lt;code&gt;true&lt;/code&gt;, the user can drag this rectangle over the
    /// map.
    /// </summary>
    /// <default>&lt;code&gt;false&lt;/code&gt;</default>
    abstract draggable: bool option with get, set
    /// <summary>
    /// If set to &lt;code&gt;true&lt;/code&gt;, the user can edit this rectangle by dragging
    /// the control points shown at the corners and on each edge.
    /// </summary>
    /// <default>&lt;code&gt;false&lt;/code&gt;</default>
    abstract editable: bool option with get, set
    /// The fill color. All CSS3 colors are supported except for extended named
    /// colors.
    abstract fillColor: string option with get, set
    /// The fill opacity between 0.0 and 1.0
    abstract fillOpacity: float option with get, set
    /// Map on which to display Rectangle.
    abstract map: Google.Maps.Map option with get, set
    /// The stroke color. All CSS3 colors are supported except for extended named
    /// colors.
    abstract strokeColor: string option with get, set
    /// The stroke opacity between 0.0 and 1.0
    abstract strokeOpacity: float option with get, set
    /// <summary>The stroke position.</summary>
    /// <default><see cref="google.maps.StrokePosition.CENTER" /></default>
    abstract strokePosition: Google.Maps.StrokePosition option with get, set
    /// The stroke width in pixels.
    abstract strokeWeight: float option with get, set
    /// <summary>Whether this rectangle is visible on the map.</summary>
    /// <default>&lt;code&gt;true&lt;/code&gt;</default>
    abstract visible: bool option with get, set
    /// The zIndex compared to other polys.
    abstract zIndex: float option with get, set

/// <summary>
/// Access by calling `const {RenderingType} = await
/// google.maps.importLibrary("maps")`. See
/// <see href="https://developers.google.com/maps/documentation/javascript/libraries." />
/// </summary>
type [<StringEnum>] [<RequireQualifiedAccess>] RenderingType =
    /// Indicates that the map is a raster map.
    | [<CompiledName("RASTER")>] RASTER
    /// Indicates that it is unknown yet whether the map is vector or raster,
    /// because the map has not finished initializing yet.
    | [<CompiledName("UNINITIALIZED")>] UNINITIALIZED
    /// Indicates that the map is a vector map.
    | [<CompiledName("VECTOR")>] VECTOR

/// Options for the rendering of the rotate control.
type [<AllowNullLiteral>] RotateControlOptions =
    /// <summary>Position id. Used to specify the position of the control on the map.</summary>
    /// <default><see cref="google.maps.ControlPosition.INLINE_START_BLOCK_END" /></default>
    abstract position: Google.Maps.ControlPosition option with get, set

type [<AllowNullLiteral>] RoutesLibrary =
    abstract DirectionsRenderer: obj with get, set
    abstract DirectionsService: obj with get, set
    abstract DirectionsStatus: obj with get, set
    abstract DistanceMatrixElementStatus: obj with get, set
    abstract DistanceMatrixService: obj with get, set
    abstract DistanceMatrixStatus: obj with get, set
    abstract TrafficModel: obj with get, set
    abstract TransitMode: obj with get, set
    abstract TransitRoutePreference: obj with get, set
    abstract TravelMode: obj with get, set
    abstract VehicleType: obj with get, set

/// Options for the rendering of the scale control.
type [<AllowNullLiteral>] ScaleControlOptions =
    /// Style id. Used to select what style of scale control to display.
    abstract style: Google.Maps.ScaleControlStyle option with get, set

/// Identifiers for scale control ids.
type [<RequireQualifiedAccess>] ScaleControlStyle =
    /// The standard scale control.
    | DEFAULT = 0

/// <summary>
/// Available only in the v=beta channel: <see href="https://goo.gle/3oAthT3." />
///
/// Settings which control the behavior of the Maps JavaScript API as a whole.
///
/// Access by calling `const {Settings} = await
/// google.maps.importLibrary("core")`. See
/// <see href="https://developers.google.com/maps/documentation/javascript/libraries." />
/// </summary>
type [<AllowNullLiteral>] Settings =
    /// <summary>
    /// Available only in the v=beta channel: <see href="https://goo.gle/3oAthT3." />
    /// A collection of unique experience IDs to which to attribute Maps JS API
    /// calls. The returned value is a copy of the internal value that is stored
    /// in the &lt;code&gt;Settings&lt;/code&gt; class singleton instance. Operations on
    /// &lt;code&gt;google.maps.Settings.getInstance().experienceIds&lt;/code&gt; will
    /// therefore only modify the copy and not the internal value.&lt;br/&gt;&lt;br/&gt;To
    /// update the internal value, set the property equal to the new value on the
    /// singleton instance (ex:
    /// &lt;code&gt;google.maps.Settings.getInstance().experienceIds =
    /// [experienceId];&lt;/code&gt;).
    /// </summary>
    abstract experienceIds: ResizeArray<string> with get, set

/// <summary>
/// Available only in the v=beta channel: <see href="https://goo.gle/3oAthT3." />
///
/// Settings which control the behavior of the Maps JavaScript API as a whole.
///
/// Access by calling `const {Settings} = await
/// google.maps.importLibrary("core")`. See
/// <see href="https://developers.google.com/maps/documentation/javascript/libraries." />
/// </summary>
type [<AllowNullLiteral>] SettingsStatic =
    [<EmitConstructor>] abstract Create: unit -> Settings
    /// <summary>
    /// Available only in the v=beta channel: <see href="https://goo.gle/3oAthT3." />
    /// Returns the singleton instance of &lt;code&gt;google.maps.Settings&lt;/code&gt;.
    /// </summary>
    abstract getInstance: this: obj option -> Google.Maps.Settings

/// <summary>
/// Access by calling <c>const {Size} = await google.maps.importLibrary("core")</c>.
/// See <see href="https://developers.google.com/maps/documentation/javascript/libraries." />
/// </summary>
type [<AllowNullLiteral>] Size =
    /// Compares two Sizes.
    abstract equals: other: Google.Maps.Size option -> bool
    /// The height along the y-axis, in pixels.
    abstract height: float with get, set
    /// Returns a string representation of this Size.
    abstract toString: unit -> string
    /// The width along the x-axis, in pixels.
    abstract width: float with get, set

/// <summary>
/// Access by calling <c>const {Size} = await google.maps.importLibrary("core")</c>.
/// See <see href="https://developers.google.com/maps/documentation/javascript/libraries." />
/// </summary>
type [<AllowNullLiteral>] SizeStatic =
    /// <summary>
    /// Access by calling `const {Size} = await
    /// google.maps.importLibrary("core")`. See
    /// <see href="https://developers.google.com/maps/documentation/javascript/libraries." />
    /// </summary>
    [<EmitConstructor>] abstract Create: width: float * height: float * ?widthUnit: string * ?heightUnit: string -> Size

/// Options for the rendering of the Street View address control.
type [<AllowNullLiteral>] StreetViewAddressControlOptions =
    /// Position id. This id is used to specify the position of the control on
    /// the map. The default position is &lt;code&gt;TOP_LEFT&lt;/code&gt;.
    abstract position: Google.Maps.ControlPosition option with get, set

/// Options for the rendering of the Street View pegman control on the map.
type [<AllowNullLiteral>] StreetViewControlOptions =
    /// Position id. Used to specify the position of the control on the map. The
    /// default position is embedded within the navigation (zoom and pan)
    /// controls. If this position is empty or the same as that specified in the
    /// &lt;code&gt;zoomControlOptions&lt;/code&gt; or &lt;code&gt;panControlOptions&lt;/code&gt;, the
    /// Street View control will be displayed as part of the navigation controls.
    /// Otherwise, it will be displayed separately.
    abstract position: Google.Maps.ControlPosition option with get, set
    /// <summary>
    /// Specifies the sources of panoramas to search. This allows a restriction
    /// to search for just official Google panoramas for example. Setting
    /// multiple sources will be evaluated as the intersection of those sources.
    /// Note: the <see cref="google.maps.StreetViewSource.OUTDOOR" /> source is not
    /// supported at this time.
    /// </summary>
    /// <default>[<see cref="google.maps.StreetViewSource.DEFAULT" />]</default>
    abstract sources: ResizeArray<Google.Maps.StreetViewSource> option with get, set

/// <summary>
/// A layer that illustrates the locations where Street View is available.
///
/// Access by calling `const {StreetViewCoverageLayer} = await
/// google.maps.importLibrary("streetView")`. See
/// <see href="https://developers.google.com/maps/documentation/javascript/libraries." />
/// </summary>
type [<AllowNullLiteral>] StreetViewCoverageLayer =
    inherit Google.Maps.MVCObject
    /// Returns the map on which this layer is displayed.
    abstract getMap: unit -> Google.Maps.Map option
    /// Renders the layer on the specified map. If the map is set to null, the
    /// layer will be removed.
    abstract setMap: map: Google.Maps.Map option -> unit

/// <summary>
/// A layer that illustrates the locations where Street View is available.
///
/// Access by calling `const {StreetViewCoverageLayer} = await
/// google.maps.importLibrary("streetView")`. See
/// <see href="https://developers.google.com/maps/documentation/javascript/libraries." />
/// </summary>
type [<AllowNullLiteral>] StreetViewCoverageLayerStatic =
    [<EmitConstructor>] abstract Create: unit -> StreetViewCoverageLayer

type [<AllowNullLiteral>] StreetViewLibrary =
    abstract InfoWindow: obj with get, set
    abstract OverlayView: obj with get, set
    abstract StreetViewCoverageLayer: obj with get, set
    abstract StreetViewPanorama: obj with get, set
    abstract StreetViewPreference: obj with get, set
    abstract StreetViewService: obj with get, set
    abstract StreetViewSource: obj with get, set
    abstract StreetViewStatus: obj with get, set

/// A collection of references to adjacent Street View panos.
type [<AllowNullLiteral>] StreetViewLink =
    /// A localized string describing the link.
    abstract description: string option with get, set
    /// The heading of the link.
    abstract heading: float option with get, set
    /// A unique identifier for the panorama. This id is stable within a session
    /// but unstable across sessions.
    abstract pano: string option with get, set

/// A representation of a location in the Street View panorama.
type [<AllowNullLiteral>] StreetViewLocation =
    /// A localized string describing the location.
    abstract description: string option with get, set
    /// The latlng of the panorama.
    abstract latLng: Google.Maps.LatLng option with get, set
    /// A unique identifier for the panorama. This is stable within a session but
    /// unstable across sessions.
    abstract pano: string with get, set
    /// Short description of the location.
    abstract shortDescription: string option with get, set

/// A Street View request to be sent with &lt;code&gt;getPanorama&lt;/code&gt;.
/// &lt;code&gt;StreetViewLocationRequest&lt;/code&gt; lets you search for a Street View
/// panoroma at a specified location.
type [<AllowNullLiteral>] StreetViewLocationRequest =
    /// Specifies the location where to search for a Street View panorama.
    abstract location: U2<Google.Maps.LatLng, Google.Maps.LatLngLiteral> option with get, set
    /// Sets a preference for which panorama should be found within the radius:
    /// the one nearest to the provided location, or the best one within the
    /// radius.
    abstract preference: Google.Maps.StreetViewPreference option with get, set
    /// <summary>Sets a radius in meters in which to search for a panorama.</summary>
    /// <default>&lt;code&gt;50&lt;/code&gt;</default>
    abstract radius: float option with get, set
    /// <summary>
    /// Specifies the source of panoramas to search. This allows a restriction to
    /// search for just outdoor panoramas for example.
    /// </summary>
    /// <default><see cref="google.maps.StreetViewSource.DEFAULT" /></default>
    [<Obsolete("Use <code>sources</code> instead.")>]
    abstract source: Google.Maps.StreetViewSource option with get, set
    /// <summary>
    /// Specifies the sources of panoramas to search. This allows a restriction
    /// to search for just outdoor panoramas for example. Setting multiple
    /// sources will be evaluated as the intersection of those sources.
    /// </summary>
    /// <default>[<see cref="google.maps.StreetViewSource.DEFAULT" />]</default>
    abstract sources: ResizeArray<Google.Maps.StreetViewSource> option with get, set

/// A &lt;code&gt;StreetViewPanoRequest&lt;/code&gt; is used with the
/// &lt;code&gt;getPanorama&lt;/code&gt; to find a panorama with a specified ID.
type [<AllowNullLiteral>] StreetViewPanoRequest =
    /// Specifies the pano ID to search for.
    abstract pano: string option with get, set

/// <summary>
/// Displays the panorama for a given &lt;code&gt;LatLng&lt;/code&gt; or panorama ID. A
/// &lt;code&gt;StreetViewPanorama&lt;/code&gt; object provides a Street View
/// &amp;quot;viewer&amp;quot; which can be stand-alone within a separate
/// &lt;code&gt;&amp;lt;div&amp;gt;&lt;/code&gt; or bound to a &lt;code&gt;Map&lt;/code&gt;.
///
/// Access by calling `const {StreetViewPanorama} = await
/// google.maps.importLibrary("streetView")`. See
/// <see href="https://developers.google.com/maps/documentation/javascript/libraries." />
/// </summary>
type [<AllowNullLiteral>] StreetViewPanorama =
    inherit Google.Maps.MVCObject
    /// <summary>
    /// Additional controls to attach to the panorama. To add a control to the
    /// panorama, add the control&amp;#39;s &lt;code&gt;&amp;lt;div&amp;gt;&lt;/code&gt; to the
    /// &lt;code&gt;MVCArray&lt;/code&gt; corresponding to the <see cref="*">google.maps.ControlPosition</see> where it should be rendered.
    /// </summary>
    abstract controls: Array<Google.Maps.MVCArray<HTMLElement>> with get, set
    /// Sets focus on this &lt;code&gt;StreetViewPanorama&lt;/code&gt;. You may wish to
    /// consider using this method along with a &lt;code&gt;visible_changed&lt;/code&gt;
    /// event to make sure that &lt;code&gt;StreetViewPanorama&lt;/code&gt; is visible before
    /// setting focus on it. A &lt;code&gt;StreetViewPanorama&lt;/code&gt; that is not
    /// visible cannot be focused.
    abstract focus: unit -> unit
    /// Returns the set of navigation links for the Street View panorama.
    abstract getLinks: unit -> Array<Google.Maps.StreetViewLink option> option
    /// Returns the StreetViewLocation of the current panorama.
    abstract getLocation: unit -> Google.Maps.StreetViewLocation
    /// Returns the state of motion tracker. If &lt;code&gt;true&lt;/code&gt; when the user
    /// physically moves the device and the browser supports it, the Street View
    /// Panorama tracks the physical movements.
    abstract getMotionTracking: unit -> bool
    /// Returns the current panorama ID for the Street View panorama. This id is
    /// stable within the browser&#39;s current session only.
    abstract getPano: unit -> string
    /// Returns the heading and pitch of the photographer when this panorama was
    /// taken. For Street View panoramas on the road, this also reveals in which
    /// direction the car was travelling. This data is available after the
    /// &lt;code&gt;pano_changed&lt;/code&gt; event.
    abstract getPhotographerPov: unit -> Google.Maps.StreetViewPov
    /// Returns the current &lt;code&gt;LatLng&lt;/code&gt; position for the Street View
    /// panorama.
    abstract getPosition: unit -> Google.Maps.LatLng option
    /// Returns the current point of view for the Street View panorama.
    abstract getPov: unit -> Google.Maps.StreetViewPov
    /// Returns the status of the panorama on completion of the
    /// &lt;code&gt;setPosition()&lt;/code&gt; or &lt;code&gt;setPano()&lt;/code&gt; request.
    abstract getStatus: unit -> Google.Maps.StreetViewStatus
    /// Returns &lt;code&gt;true&lt;/code&gt; if the panorama is visible. It does not specify
    /// whether Street View imagery is available at the specified position.
    abstract getVisible: unit -> bool
    /// Returns the zoom level of the panorama. Fully zoomed-out is level 0,
    /// where the field of view is 180 degrees. Zooming in increases the zoom
    /// level.
    abstract getZoom: unit -> float
    /// Set the custom panorama provider called on pano change to load custom
    /// panoramas.
    abstract registerPanoProvider: provider: (string -> Google.Maps.StreetViewPanoramaData option) * ?opt_options: Google.Maps.PanoProviderOptions -> unit
    /// Sets the set of navigation links for the Street View panorama.
    abstract setLinks: links: Array<Google.Maps.StreetViewLink option> option -> unit
    /// Sets the state of motion tracker. If &lt;code&gt;true&lt;/code&gt; when the user
    /// physically moves the device and the browser supports it, the Street View
    /// Panorama tracks the physical movements.
    abstract setMotionTracking: motionTracking: bool -> unit
    /// Sets a collection of key-value pairs.
    abstract setOptions: options: Google.Maps.StreetViewPanoramaOptions option -> unit
    /// Sets the current panorama ID for the Street View panorama.
    abstract setPano: pano: string -> unit
    /// Sets the current &lt;code&gt;LatLng&lt;/code&gt; position for the Street View
    /// panorama.
    abstract setPosition: latLng: U2<Google.Maps.LatLng, Google.Maps.LatLngLiteral> option -> unit
    /// Sets the point of view for the Street View panorama.
    abstract setPov: pov: Google.Maps.StreetViewPov -> unit
    /// Sets to &lt;code&gt;true&lt;/code&gt; to make the panorama visible. If set to
    /// &lt;code&gt;false&lt;/code&gt;, the panorama will be hidden whether it is embedded in
    /// the map or in its own &lt;code&gt;&amp;lt;div&amp;gt;&lt;/code&gt;.
    abstract setVisible: flag: bool -> unit
    /// Sets the zoom level of the panorama. Fully zoomed-out is level 0, where
    /// the field of view is 180 degrees. Zooming in increases the zoom level.
    abstract setZoom: zoom: float -> unit

/// <summary>
/// Displays the panorama for a given &lt;code&gt;LatLng&lt;/code&gt; or panorama ID. A
/// &lt;code&gt;StreetViewPanorama&lt;/code&gt; object provides a Street View
/// &amp;quot;viewer&amp;quot; which can be stand-alone within a separate
/// &lt;code&gt;&amp;lt;div&amp;gt;&lt;/code&gt; or bound to a &lt;code&gt;Map&lt;/code&gt;.
///
/// Access by calling `const {StreetViewPanorama} = await
/// google.maps.importLibrary("streetView")`. See
/// <see href="https://developers.google.com/maps/documentation/javascript/libraries." />
/// </summary>
type [<AllowNullLiteral>] StreetViewPanoramaStatic =
    /// <summary>
    /// Displays the panorama for a given &lt;code&gt;LatLng&lt;/code&gt; or panorama ID. A
    /// &lt;code&gt;StreetViewPanorama&lt;/code&gt; object provides a Street View
    /// &amp;quot;viewer&amp;quot; which can be stand-alone within a separate
    /// &lt;code&gt;&amp;lt;div&amp;gt;&lt;/code&gt; or bound to a &lt;code&gt;Map&lt;/code&gt;.
    ///
    /// Access by calling `const {StreetViewPanorama} = await
    /// google.maps.importLibrary("streetView")`. See
    /// <see href="https://developers.google.com/maps/documentation/javascript/libraries." />
    /// </summary>
    [<EmitConstructor>] abstract Create: container: HTMLElement * ?opts: Google.Maps.StreetViewPanoramaOptions -> StreetViewPanorama

/// The representation of a panorama returned from the provider defined using
/// &lt;code&gt;registerPanoProvider&lt;/code&gt;.
type [<AllowNullLiteral>] StreetViewPanoramaData =
    /// Specifies the copyright text for this panorama.
    abstract copyright: string option with get, set
    /// Specifies the year and month in which the imagery in this panorama was
    /// acquired. The date string is in the form YYYY-MM.
    abstract imageDate: string option with get, set
    /// Specifies the navigational links to adjacent panoramas.
    abstract links: ResizeArray<Google.Maps.StreetViewLink> option with get, set
    /// Specifies the location meta-data for this panorama.
    abstract location: Google.Maps.StreetViewLocation option with get, set
    /// Specifies the custom tiles for this panorama.
    abstract tiles: Google.Maps.StreetViewTileData with get, set

/// Options defining the properties of a &lt;code&gt;StreetViewPanorama&lt;/code&gt;
/// object.
type [<AllowNullLiteral>] StreetViewPanoramaOptions =
    /// The enabled/disabled state of the address control.
    abstract addressControl: bool option with get, set
    /// The display options for the address control.
    abstract addressControlOptions: Google.Maps.StreetViewAddressControlOptions option with get, set
    /// <summary>
    /// The enabled/disabled state of click-to-go. Not applicable to custom
    /// panoramas.
    /// </summary>
    /// <default>&lt;code&gt;true&lt;/code&gt;</default>
    abstract clickToGo: bool option with get, set
    /// Size in pixels of the controls appearing on the panorama. This value must
    /// be supplied directly when creating the Panorama, updating this value
    /// later may bring the controls into an undefined state. Only governs the
    /// controls made by the Maps API itself. Does not scale developer created
    /// custom controls.
    abstract controlSize: float option with get, set
    /// Enables/disables all default UI. May be overridden individually.
    abstract disableDefaultUI: bool option with get, set
    /// <summary>Enables/disables zoom on double click.</summary>
    /// <default>&lt;code&gt;true&lt;/code&gt;</default>
    abstract disableDoubleClickZoom: bool option with get, set
    /// <summary>If &lt;code&gt;true&lt;/code&gt;, the close button is displayed.</summary>
    /// <default>&lt;code&gt;false&lt;/code&gt;</default>
    abstract enableCloseButton: bool option with get, set
    /// The enabled/disabled state of the fullscreen control.
    abstract fullscreenControl: bool option with get, set
    /// The display options for the fullscreen control.
    abstract fullscreenControlOptions: Google.Maps.FullscreenControlOptions option with get, set
    /// The enabled/disabled state of the imagery acquisition date control.
    /// Disabled by default.
    abstract imageDateControl: bool option with get, set
    /// The enabled/disabled state of the links control.
    abstract linksControl: bool option with get, set
    /// Whether motion tracking is on or off. Enabled by default when the motion
    /// tracking control is present and permission is granted by a user or not
    /// required, so that the POV (point of view) follows the orientation of the
    /// device. This is primarily applicable to mobile devices. If
    /// &lt;code&gt;motionTracking&lt;/code&gt; is set to &lt;code&gt;false&lt;/code&gt; while
    /// &lt;code&gt;motionTrackingControl&lt;/code&gt; is enabled, the motion tracking
    /// control appears but tracking is off. The user can tap the motion tracking
    /// control to toggle this option. If &lt;code&gt;motionTracking&lt;/code&gt; is set to
    /// &lt;code&gt;true&lt;/code&gt; while permission is required but not yet requested, the
    /// motion tracking control appears but tracking is off. The user can tap the
    /// motion tracking control to request permission. If
    /// &lt;code&gt;motionTracking&lt;/code&gt; is set to &lt;code&gt;true&lt;/code&gt; while permission
    /// is denied by a user, the motion tracking control appears disabled with
    /// tracking turned off.
    abstract motionTracking: bool option with get, set
    /// The enabled/disabled state of the motion tracking control. Enabled by
    /// default when the device has motion data, so that the control appears on
    /// the map. This is primarily applicable to mobile devices.
    abstract motionTrackingControl: bool option with get, set
    /// The display options for the motion tracking control.
    abstract motionTrackingControlOptions: Google.Maps.MotionTrackingControlOptions option with get, set
    /// The enabled/disabled state of the pan control.
    abstract panControl: bool option with get, set
    /// The display options for the pan control.
    abstract panControlOptions: Google.Maps.PanControlOptions option with get, set
    /// The panorama ID, which should be set when specifying a custom panorama.
    abstract pano: string option with get, set
    /// The &lt;code&gt;LatLng&lt;/code&gt; position of the Street View panorama.
    abstract position: U2<Google.Maps.LatLng, Google.Maps.LatLngLiteral> option with get, set
    /// The camera orientation, specified as heading and pitch, for the panorama.
    abstract pov: Google.Maps.StreetViewPov option with get, set
    /// <summary>If &lt;code&gt;false&lt;/code&gt;, disables scrollwheel zooming in Street View.</summary>
    /// <default>&lt;code&gt;true&lt;/code&gt;</default>
    abstract scrollwheel: bool option with get, set
    /// <summary>
    /// The display of street names on the panorama. If this value is not
    /// specified, or is set to &lt;code&gt;true&lt;/code&gt;, street names are displayed on
    /// the panorama. If set to &lt;code&gt;false&lt;/code&gt;, street names are not
    /// displayed.
    /// </summary>
    /// <default>&lt;code&gt;true&lt;/code&gt;</default>
    abstract showRoadLabels: bool option with get, set
    /// If &lt;code&gt;true&lt;/code&gt;, the Street View panorama is visible on load.
    abstract visible: bool option with get, set
    /// The zoom of the panorama, specified as a number. A zoom of 0 gives a 180
    /// degrees Field of View.
    abstract zoom: float option with get, set
    /// The enabled/disabled state of the zoom control.
    abstract zoomControl: bool option with get, set
    /// The display options for the zoom control.
    abstract zoomControlOptions: Google.Maps.ZoomControlOptions option with get, set

/// A point of view object which specifies the camera&#39;s orientation at the
/// Street View panorama&#39;s position. The point of view is defined as
/// heading and pitch.
type [<AllowNullLiteral>] StreetViewPov =
    /// The camera heading in degrees relative to &lt;code&gt;true&lt;/code&gt; north. True
    /// north is 0&amp;deg;, east is 90&amp;deg;, south is 180&amp;deg;, west is 270&amp;deg;.
    abstract heading: float with get, set
    /// The camera pitch in degrees, relative to the street view vehicle. Ranges
    /// from 90&deg; (directly upwards) to -90&deg; (directly downwards).
    abstract pitch: float with get, set

/// <summary>
/// Options that bias a search result towards returning a Street View panorama
/// that is nearest to the request location, or a panorama that is considered
/// most likely to be what the user wants to see. Specify these by value, or by
/// using the constant&amp;#39;s name. For example, &lt;code&gt;'best'&lt;/code&gt; or
/// &lt;code&gt;google.maps.StreetViewPreference.BEST&lt;/code&gt;.
///
/// Access by calling `const {StreetViewPreference} = await
/// google.maps.importLibrary("streetView")`. See
/// <see href="https://developers.google.com/maps/documentation/javascript/libraries." />
/// </summary>
type [<StringEnum>] [<RequireQualifiedAccess>] StreetViewPreference =
    /// Return the Street View panorama that is considered most likely to be what
    /// the user wants to see. The best result is determined by algorithms based
    /// on user research and parameters such as recognised points of interest,
    /// image quality, and distance from the given location.
    | [<CompiledName("best")>] BEST
    /// Return the Street View panorama that is the shortest distance from the
    /// provided location. This works well only within a limited radius. The
    /// recommended radius is 1km or less.
    | [<CompiledName("nearest")>] NEAREST

/// <summary>The response resolved for a Promise from <see cref="*">google.maps.StreetViewService.getPanorama</see>.</summary>
type [<AllowNullLiteral>] StreetViewResponse =
    /// The representation of a panorama.
    abstract data: Google.Maps.StreetViewPanoramaData with get, set

/// <summary>
/// A &lt;code&gt;StreetViewService&lt;/code&gt; object performs searches for Street View
/// data.
///
/// Access by calling `const {StreetViewService} = await
/// google.maps.importLibrary("streetView")`. See
/// <see href="https://developers.google.com/maps/documentation/javascript/libraries." />
/// </summary>
type [<AllowNullLiteral>] StreetViewService =
    /// Retrieves the &lt;code&gt;StreetViewPanoramaData&lt;/code&gt; for a panorama that
    /// matches the supplied Street View query request. The
    /// &lt;code&gt;StreetViewPanoramaData&lt;/code&gt; is passed to the provided callback.
    abstract getPanorama: request: U2<Google.Maps.StreetViewLocationRequest, Google.Maps.StreetViewPanoRequest> * ?callback: (Google.Maps.StreetViewPanoramaData option -> Google.Maps.StreetViewStatus -> unit) -> Promise<Google.Maps.StreetViewResponse>

/// <summary>
/// A &lt;code&gt;StreetViewService&lt;/code&gt; object performs searches for Street View
/// data.
///
/// Access by calling `const {StreetViewService} = await
/// google.maps.importLibrary("streetView")`. See
/// <see href="https://developers.google.com/maps/documentation/javascript/libraries." />
/// </summary>
type [<AllowNullLiteral>] StreetViewServiceStatic =
    [<EmitConstructor>] abstract Create: unit -> StreetViewService

/// <summary>
/// Identifiers to limit Street View searches to selected sources. These values
/// are specified as strings. For example, &lt;code&gt;'outdoor'&lt;/code&gt;.
///
/// Access by calling `const {StreetViewSource} = await
/// google.maps.importLibrary("streetView")`. See
/// <see href="https://developers.google.com/maps/documentation/javascript/libraries." />
/// </summary>
type [<StringEnum>] [<RequireQualifiedAccess>] StreetViewSource =
    /// Uses the default sources of Street View, searches will not be limited to
    /// specific sources.
    | [<CompiledName("default")>] DEFAULT
    /// Limits Street View searches to official Google collections.
    | [<CompiledName("google")>] GOOGLE
    /// Limits Street View searches to outdoor collections. Indoor collections
    /// are not included in search results. Note also that the search only
    /// returns panoramas where it&#39;s possible to determine whether
    /// they&#39;re indoors or outdoors. For example, PhotoSpheres are not
    /// returned because it&#39;s unknown whether they are indoors or outdoors.
    | [<CompiledName("outdoor")>] OUTDOOR

/// <summary>
/// The status returned by the &lt;code&gt;StreetViewService&lt;/code&gt; on completion of
/// a Street View request. These can be specified by value, or by using the
/// constant&amp;#39;s name. For example, &lt;code&gt;'OK'&lt;/code&gt; or
/// &lt;code&gt;google.maps.StreetViewStatus.OK&lt;/code&gt;.
///
/// Access by calling `const {StreetViewStatus} = await
/// google.maps.importLibrary("streetView")`. See
/// <see href="https://developers.google.com/maps/documentation/javascript/libraries." />
/// </summary>
type [<StringEnum>] [<RequireQualifiedAccess>] StreetViewStatus =
    /// The request was successful.
    | [<CompiledName("OK")>] OK
    /// The request could not be successfully processed, yet the exact reason for
    /// failure is unknown.
    | [<CompiledName("UNKNOWN_ERROR")>] UNKNOWN_ERROR
    /// There are no panoramas found that match the search criteria.
    | [<CompiledName("ZERO_RESULTS")>] ZERO_RESULTS

/// The properties of the tile set used in a Street View panorama.
type [<AllowNullLiteral>] StreetViewTileData =
    /// The heading (in degrees) at the center of the panoramic tiles.
    abstract centerHeading: float with get, set
    /// Gets the tile image URL for the specified tile.&lt;br/&gt; This is a custom
    /// method which you must implement, to supply your custom tiles. The API
    /// calls this method, supplying the following parameters:&lt;/br&gt;
    /// &lt;code&gt;pano&lt;/code&gt; is the panorama ID of the Street View tile.&lt;br/&gt;
    /// &lt;code&gt;tileZoom&lt;/code&gt; is the zoom level of the tile.&lt;br/&gt;
    /// &lt;code&gt;tileX&lt;/code&gt; is the x-coordinate of the tile.&lt;br/&gt;
    /// &lt;code&gt;tileY&lt;/code&gt; is the y-coordinate of the tile.&lt;br/&gt; Your custom
    /// method must return the URL for the tile image.&lt;br/&gt;
    abstract getTileUrl: pano: string * tileZoom: float * tileX: float * tileY: float -> string
    /// The size (in pixels) at which tiles will be rendered.
    abstract tileSize: Google.Maps.Size with get, set
    /// The size (in pixels) of the whole panorama&#39;s &quot;world&quot;.
    abstract worldSize: Google.Maps.Size with get, set

/// <summary>
/// The possible positions of the stroke on a polygon.
///
/// Access by calling `const {StrokePosition} = await
/// google.maps.importLibrary("maps")`. See
/// <see href="https://developers.google.com/maps/documentation/javascript/libraries." />
/// </summary>
type [<RequireQualifiedAccess>] StrokePosition =
    /// The stroke is centered on the polygon&#39;s path, with half the stroke
    /// inside the polygon and half the stroke outside the polygon.
    | CENTER = 0
    /// The stroke lies inside the polygon.
    | INSIDE = 1
    /// The stroke lies outside the polygon.
    | OUTSIDE = 2

/// <summary>
/// Creates a &lt;code&gt;MapType&lt;/code&gt; with a custom style.
///
/// Access by calling `const {StyledMapType} = await
/// google.maps.importLibrary("maps")`. See
/// <see href="https://developers.google.com/maps/documentation/javascript/libraries." />
/// </summary>
type [<AllowNullLiteral>] StyledMapType =
    inherit Google.Maps.MVCObject
    inherit Google.Maps.MapType
    /// Alt text to display when this MapType&#39;s button is hovered over in the
    /// MapTypeControl. Optional.
    abstract alt: string with get, set
    /// <summary>
    /// Returns a tile for the given tile coordinate (x, y) and zoom level. This
    /// tile will be appended to the given ownerDocument. Not available for base
    /// map types.
    /// </summary>
    /// <param name="tileCoord">Tile coordinates.</param>
    /// <param name="zoom">Tile zoom.</param>
    /// <param name="ownerDocument">The document which owns this tile.</param>
    abstract getTile: tileCoord: Google.Maps.Point option * zoom: float * ownerDocument: Document option -> Element option
    /// The maximum zoom level for the map when displaying this MapType. Required
    /// for base MapTypes, ignored for overlay MapTypes.
    abstract maxZoom: float with get, set
    /// The minimum zoom level for the map when displaying this MapType.
    /// Optional; defaults to 0.
    abstract minZoom: float with get, set
    /// Name to display in the MapTypeControl. Optional.
    abstract name: string with get, set
    /// The Projection used to render this MapType. Optional; defaults to
    /// Mercator.
    abstract projection: Google.Maps.Projection option with get, set
    /// Radius of the planet for the map, in meters. Optional; defaults to
    /// Earth&#39;s equatorial radius of 6378137 meters.
    abstract radius: float with get, set
    /// <summary>
    /// Releases the given tile, performing any necessary cleanup. The provided
    /// tile will have already been removed from the document. Optional.
    /// </summary>
    /// <param name="tile">Tile to release.</param>
    abstract releaseTile: tile: Element option -> unit
    /// The dimensions of each tile. Required.
    abstract tileSize: Google.Maps.Size option with get, set

/// <summary>
/// Creates a &lt;code&gt;MapType&lt;/code&gt; with a custom style.
///
/// Access by calling `const {StyledMapType} = await
/// google.maps.importLibrary("maps")`. See
/// <see href="https://developers.google.com/maps/documentation/javascript/libraries." />
/// </summary>
type [<AllowNullLiteral>] StyledMapTypeStatic =
    /// <summary>
    /// Creates a &lt;code&gt;MapType&lt;/code&gt; with a custom style.
    ///
    /// Access by calling `const {StyledMapType} = await
    /// google.maps.importLibrary("maps")`. See
    /// <see href="https://developers.google.com/maps/documentation/javascript/libraries." />
    /// </summary>
    [<EmitConstructor>] abstract Create: styles: Array<Google.Maps.MapTypeStyle option> option * ?options: Google.Maps.StyledMapTypeOptions -> StyledMapType

/// This class is used to specify options when creating a
/// &lt;code&gt;StyledMapType&lt;/code&gt;. These options cannot be changed after the
/// &lt;code&gt;StyledMapType&lt;/code&gt; is instantiated.
type [<AllowNullLiteral>] StyledMapTypeOptions =
    /// Text to display when this &lt;code&gt;MapType&lt;/code&gt;&amp;#39;s button is hovered
    /// over in the map type control.
    abstract alt: string option with get, set
    /// The maximum zoom level for the map when displaying this
    /// &lt;code&gt;MapType&lt;/code&gt;. Optional.
    abstract maxZoom: float option with get, set
    /// The minimum zoom level for the map when displaying this
    /// &lt;code&gt;MapType&lt;/code&gt;. Optional.
    abstract minZoom: float option with get, set
    /// The name to display in the map type control.
    abstract name: string option with get, set

/// Describes a symbol, which consists of a vector path with styling. A symbol
/// can be used as the icon of a marker, or placed on a polyline.
type [<AllowNullLiteral>] Symbol =
    /// <summary>
    /// The position of the symbol relative to the marker or polyline. The
    /// coordinates of the symbol&amp;#39;s path are translated left and up by the
    /// anchor&amp;#39;s x and y coordinates respectively. The position is expressed
    /// in the same coordinate system as the symbol&amp;#39;s path.
    /// </summary>
    /// <default>&lt;code&gt;google.maps.Point(0,0)&lt;/code&gt;</default>
    abstract anchor: Google.Maps.Point option with get, set
    /// The symbol&#39;s fill color. All CSS3 colors are supported except for
    /// extended named colors. For symbol markers, this defaults to
    /// &#39;black&#39;. For symbols on polylines, this defaults to the stroke
    /// color of the corresponding polyline.
    abstract fillColor: string option with get, set
    /// <summary>The symbol&amp;#39;s fill opacity.</summary>
    /// <default>&lt;code&gt;0&lt;/code&gt;</default>
    abstract fillOpacity: float option with get, set
    /// <summary>
    /// The origin of the label relative to the origin of the path, if label is
    /// supplied by the marker. The origin is expressed in the same coordinate
    /// system as the symbol&amp;#39;s path. This property is unused for symbols on
    /// polylines.
    /// </summary>
    /// <default>&lt;code&gt;google.maps.Point(0,0)&lt;/code&gt;</default>
    abstract labelOrigin: Google.Maps.Point option with get, set
    /// <summary>
    /// The symbol&amp;#39;s path, which is a built-in symbol path, or a custom path
    /// expressed using &lt;a
    /// href="<see href="http://www.w3.org/TR/SVG/paths.html#PathData"&gt;SVG" /> path
    /// notation&lt;/a&gt;. Required.
    /// </summary>
    abstract path: U2<Google.Maps.SymbolPath, string> with get, set
    /// <summary>
    /// The angle by which to rotate the symbol, expressed clockwise in degrees.
    /// A symbol in an &lt;code&gt;IconSequence&lt;/code&gt; where &lt;code&gt;fixedRotation&lt;/code&gt;
    /// is &lt;code&gt;false&lt;/code&gt; is rotated relative to the angle of the edge on
    /// which it lies.
    /// </summary>
    /// <default>&lt;code&gt;0&lt;/code&gt;</default>
    abstract rotation: float option with get, set
    /// The amount by which the symbol is scaled in size. For symbol markers,
    /// this defaults to 1; after scaling, the symbol may be of any size. For
    /// symbols on a polyline, this defaults to the stroke weight of the
    /// polyline; after scaling, the symbol must lie inside a square 22 pixels in
    /// size centered at the symbol&#39;s anchor.
    abstract scale: float option with get, set
    /// The symbol&#39;s stroke color. All CSS3 colors are supported except for
    /// extended named colors. For symbol markers, this defaults to
    /// &#39;black&#39;. For symbols on a polyline, this defaults to the stroke
    /// color of the polyline.
    abstract strokeColor: string option with get, set
    /// The symbol&#39;s stroke opacity. For symbol markers, this defaults to 1.
    /// For symbols on a polyline, this defaults to the stroke opacity of the
    /// polyline.
    abstract strokeOpacity: float option with get, set
    /// <summary>The symbol&amp;#39;s stroke weight.</summary>
    /// <default>The <see cref="google.maps.Symbol.scale" /> of the symbol.</default>
    abstract strokeWeight: float option with get, set

/// <summary>
/// Built-in symbol paths.
///
/// Access by calling `const {SymbolPath} = await
/// google.maps.importLibrary("core")`. See
/// <see href="https://developers.google.com/maps/documentation/javascript/libraries." />
/// </summary>
type [<RequireQualifiedAccess>] SymbolPath =
    /// A backward-pointing closed arrow.
    | BACKWARD_CLOSED_ARROW = 0
    /// A backward-pointing open arrow.
    | BACKWARD_OPEN_ARROW = 1
    /// A circle.
    | CIRCLE = 2
    /// A forward-pointing closed arrow.
    | FORWARD_CLOSED_ARROW = 3
    /// A forward-pointing open arrow.
    | FORWARD_OPEN_ARROW = 4

/// A representation of time as a Date object, a localized string, and a time
/// zone.
type [<AllowNullLiteral>] Time =
    /// A string representing the time&#39;s value. The time is displayed in the
    /// time zone of the transit stop.
    abstract text: string with get, set
    /// The time zone in which this stop lies. The value is the name of the time
    /// zone as defined in the IANA Time Zone Database, e.g.
    /// &quot;America/New_York&quot;.
    abstract time_zone: string with get, set
    /// The time of this departure or arrival, specified as a JavaScript Date
    /// object.
    abstract value: DateTime with get, set

/// <summary>
/// A traffic layer.
///
/// Access by calling `const {TrafficLayer} = await
/// google.maps.importLibrary("maps")`. See
/// <see href="https://developers.google.com/maps/documentation/javascript/libraries." />
/// </summary>
type [<AllowNullLiteral>] TrafficLayer =
    inherit Google.Maps.MVCObject
    /// Returns the map on which this layer is displayed.
    abstract getMap: unit -> Google.Maps.Map option
    /// Renders the layer on the specified map. If map is set to
    /// &lt;code&gt;null&lt;/code&gt;, the layer will be removed.
    abstract setMap: map: Google.Maps.Map option -> unit
    abstract setOptions: options: Google.Maps.TrafficLayerOptions option -> unit

/// <summary>
/// A traffic layer.
///
/// Access by calling `const {TrafficLayer} = await
/// google.maps.importLibrary("maps")`. See
/// <see href="https://developers.google.com/maps/documentation/javascript/libraries." />
/// </summary>
type [<AllowNullLiteral>] TrafficLayerStatic =
    /// <summary>
    /// A traffic layer.
    ///
    /// Access by calling `const {TrafficLayer} = await
    /// google.maps.importLibrary("maps")`. See
    /// <see href="https://developers.google.com/maps/documentation/javascript/libraries." />
    /// </summary>
    [<EmitConstructor>] abstract Create: ?opts: Google.Maps.TrafficLayerOptions -> TrafficLayer

/// TrafficLayerOptions object used to define the properties that can be set on
/// a TrafficLayer.
type [<AllowNullLiteral>] TrafficLayerOptions =
    /// <summary>
    /// Whether the traffic layer refreshes with updated information
    /// automatically.
    /// </summary>
    /// <default>&lt;code&gt;true&lt;/code&gt;</default>
    abstract autoRefresh: bool option with get, set
    /// Map on which to display the traffic layer.
    abstract map: Google.Maps.Map option with get, set

/// <summary>
/// The assumptions to use when predicting duration in traffic. Specified as
/// part of a &lt;code&gt;&lt;a href="#DirectionsRequest"&gt;DirectionsRequest&lt;/a&gt;&lt;/code&gt;
/// or &lt;code&gt;&lt;a href="#DistanceMatrixRequest"&gt;DistanceMatrixRequest&lt;/a&gt;&lt;/code&gt;.
/// Specify these by value, or by using the constant&amp;#39;s name. For example,
/// &lt;code&gt;'bestguess'&lt;/code&gt; or
/// &lt;code&gt;google.maps.TrafficModel.BEST_GUESS&lt;/code&gt;.
///
/// Access by calling `const {TrafficModel} = await
/// google.maps.importLibrary("routes")`. See
/// <see href="https://developers.google.com/maps/documentation/javascript/libraries." />
/// </summary>
type [<StringEnum>] [<RequireQualifiedAccess>] TrafficModel =
    /// Use historical traffic data to best estimate the time spent in traffic.
    | [<CompiledName("bestguess")>] BEST_GUESS
    /// Use historical traffic data to make an optimistic estimate of what the
    /// duration in traffic will be.
    | [<CompiledName("optimistic")>] OPTIMISTIC
    /// Use historical traffic data to make a pessimistic estimate of what the
    /// duration in traffic will be.
    | [<CompiledName("pessimistic")>] PESSIMISTIC

/// Information about an agency that operates a transit line.
type [<AllowNullLiteral>] TransitAgency =
    /// The name of this transit agency.
    abstract name: string with get, set
    /// The transit agency&#39;s phone number.
    abstract phone: string with get, set
    /// The transit agency&#39;s URL.
    abstract url: string with get, set

/// Details about the departure, arrival, and mode of transit used in this
/// step.
type [<AllowNullLiteral>] TransitDetails =
    /// The arrival stop of this transit step.
    abstract arrival_stop: Google.Maps.TransitStop with get, set
    /// The arrival time of this step, specified as a Time object.
    abstract arrival_time: Google.Maps.Time with get, set
    /// The departure stop of this transit step.
    abstract departure_stop: Google.Maps.TransitStop with get, set
    /// The departure time of this step, specified as a Time object.
    abstract departure_time: Google.Maps.Time with get, set
    /// The direction in which to travel on this line, as it is marked on the
    /// vehicle or at the departure stop.
    abstract headsign: string with get, set
    /// The expected number of seconds between equivalent vehicles at this stop.
    abstract headway: float with get, set
    /// Details about the transit line used in this step.
    abstract line: Google.Maps.TransitLine with get, set
    /// The number of stops on this step. Includes the arrival stop, but not the
    /// departure stop.
    abstract num_stops: float with get, set
    /// The text that appears in schedules and sign boards to identify a transit
    /// trip to passengers, for example, to identify train numbers for commuter
    /// rail trips. The text uniquely identifies a trip within a service day.
    abstract trip_short_name: string with get, set

/// A fare of a &lt;code&gt;&lt;a href="#DirectionsResult"&gt;DirectionsRoute&lt;/a&gt; &lt;/code&gt;
/// consisting of value and currency.
type [<AllowNullLiteral>] TransitFare =
    /// <summary>
    /// An &lt;a href="<see href="http://en.wikipedia.org/wiki/ISO_4217"&gt;ISO" /> 4217 currency
    /// code&lt;/a&gt; indicating the currency in which the fare is expressed.
    /// </summary>
    abstract currency: string with get, set
    /// The numerical value of the fare, expressed in the given
    /// &lt;code&gt;currency&lt;/code&gt;.
    abstract value: float with get, set

/// <summary>
/// A transit layer.
///
/// Access by calling `const {TransitLayer} = await
/// google.maps.importLibrary("maps")`. See
/// <see href="https://developers.google.com/maps/documentation/javascript/libraries." />
/// </summary>
type [<AllowNullLiteral>] TransitLayer =
    inherit Google.Maps.MVCObject
    /// Returns the map on which this layer is displayed.
    abstract getMap: unit -> Google.Maps.Map option
    /// Renders the layer on the specified map. If map is set to
    /// &lt;code&gt;null&lt;/code&gt;, the layer will be removed.
    abstract setMap: map: Google.Maps.Map option -> unit

/// <summary>
/// A transit layer.
///
/// Access by calling `const {TransitLayer} = await
/// google.maps.importLibrary("maps")`. See
/// <see href="https://developers.google.com/maps/documentation/javascript/libraries." />
/// </summary>
type [<AllowNullLiteral>] TransitLayerStatic =
    [<EmitConstructor>] abstract Create: unit -> TransitLayer

/// Information about the transit line that operates this transit step.
type [<AllowNullLiteral>] TransitLine =
    /// The transit agency that operates this transit line.
    abstract agencies: Array<Google.Maps.TransitAgency option> option with get, set
    /// The color commonly used in signage for this transit line, represented as
    /// a hex string.
    abstract color: string with get, set
    /// The URL for an icon associated with this line.
    abstract icon: string with get, set
    /// The full name of this transit line, e.g. &quot;8 Avenue Local&quot;.
    abstract name: string with get, set
    /// The short name of this transit line, e.g. &quot;E&quot;.
    abstract short_name: string with get, set
    /// The text color commonly used in signage for this transit line,
    /// represented as a hex string.
    abstract text_color: string with get, set
    /// The agency&#39;s URL which is specific to this transit line.
    abstract url: string with get, set
    /// The type of vehicle used, e.g. train or bus.
    abstract vehicle: Google.Maps.TransitVehicle with get, set

/// <summary>
/// The valid transit mode e.g. bus that can be specified in a &lt;i&gt;&lt;code&gt;&lt;a
/// href="#TransitOptions"&gt;TransitOptions&lt;/a&gt;&lt;/code&gt;&lt;/i&gt;. Specify these by
/// value, or by using the constant&amp;#39;s name. For example, &lt;code&gt;'BUS'&lt;/code&gt;
/// or &lt;code&gt;google.maps.TransitMode.BUS&lt;/code&gt;.
///
/// Access by calling `const {TransitMode} = await
/// google.maps.importLibrary("routes")`. See
/// <see href="https://developers.google.com/maps/documentation/javascript/libraries." />
/// </summary>
type [<StringEnum>] [<RequireQualifiedAccess>] TransitMode =
    /// Specifies bus as a preferred mode of transit.
    | [<CompiledName("BUS")>] BUS
    /// Specifies rail as a preferred mode of transit.
    | [<CompiledName("RAIL")>] RAIL
    /// Specifies subway as a preferred mode of transit.
    | [<CompiledName("SUBWAY")>] SUBWAY
    /// Specifies train as a preferred mode of transit.
    | [<CompiledName("TRAIN")>] TRAIN
    /// Specifies tram as a preferred mode of transit.
    | [<CompiledName("TRAM")>] TRAM

/// The TransitOptions object to be included in a &lt;code&gt;&lt;a
/// href="#DirectionsRequest"&gt;DirectionsRequest&lt;/a&gt;&lt;/code&gt; when the travel mode
/// is set to TRANSIT.
type [<AllowNullLiteral>] TransitOptions =
    /// The desired arrival time for the route, specified as a Date object. The
    /// Date object measures time in milliseconds since 1 January 1970. If
    /// arrival time is specified, departure time is ignored.
    abstract arrivalTime: DateTime option with get, set
    /// The desired departure time for the route, specified as a Date object. The
    /// Date object measures time in milliseconds since 1 January 1970. If
    /// neither departure time nor arrival time is specified, the time is assumed
    /// to be &quot;now&quot;.
    abstract departureTime: DateTime option with get, set
    /// One or more preferred modes of transit, such as bus or train. If no
    /// preference is given, the API returns the default best route.
    abstract modes: ResizeArray<Google.Maps.TransitMode> option with get, set
    /// A preference that can bias the choice of transit route, such as less
    /// walking. If no preference is given, the API returns the default best
    /// route.
    abstract routingPreference: Google.Maps.TransitRoutePreference option with get, set

/// <summary>
/// The valid transit route type that can be specified in a &lt;i&gt;&lt;code&gt;&lt;a
/// href="#TransitOptions"&gt;TransitOptions&lt;/a&gt;&lt;/code&gt;&lt;/i&gt;. Specify these by
/// value, or by using the constant&amp;#39;s name. For example,
/// &lt;code&gt;'LESS_WALKING'&lt;/code&gt; or
/// &lt;code&gt;google.maps.TransitRoutePreference.LESS_WALKING&lt;/code&gt;.
///
/// Access by calling `const {TransitRoutePreference} = await
/// google.maps.importLibrary("routes")`. See
/// <see href="https://developers.google.com/maps/documentation/javascript/libraries." />
/// </summary>
type [<StringEnum>] [<RequireQualifiedAccess>] TransitRoutePreference =
    /// Specifies that the calculated route should prefer a limited number of
    /// transfers.
    | [<CompiledName("FEWER_TRANSFERS")>] FEWER_TRANSFERS
    /// Specifies that the calculated route should prefer limited amounts of
    /// walking.
    | [<CompiledName("LESS_WALKING")>] LESS_WALKING

/// Details about a transit stop or station.
type [<AllowNullLiteral>] TransitStop =
    /// The location of this stop.
    abstract location: Google.Maps.LatLng with get, set
    /// The name of this transit stop.
    abstract name: string with get, set

/// Information about the vehicle that operates on a transit line.
type [<AllowNullLiteral>] TransitVehicle =
    /// A URL for an icon that corresponds to the type of vehicle used on this
    /// line.
    abstract icon: string with get, set
    /// A URL for an icon that corresponds to the type of vehicle used in this
    /// region instead of the more general icon.
    abstract local_icon: string with get, set
    /// A name for this type of TransitVehicle, e.g. &quot;Train&quot; or
    /// &quot;Bus&quot;.
    abstract name: string with get, set
    /// The type of vehicle used, e.g. train, bus, or ferry.
    abstract ``type``: Google.Maps.VehicleType with get, set

/// <summary>
/// The valid travel modes that can be specified in a
/// &lt;code&gt;DirectionsRequest&lt;/code&gt; as well as the travel modes returned in a
/// &lt;code&gt;DirectionsStep&lt;/code&gt;. Specify these by value, or by using the
/// constant&amp;#39;s name. For example, &lt;code&gt;'BICYCLING'&lt;/code&gt; or
/// &lt;code&gt;google.maps.TravelMode.BICYCLING&lt;/code&gt;.
///
/// Access by calling `const {TravelMode} = await
/// google.maps.importLibrary("routes")`. See
/// <see href="https://developers.google.com/maps/documentation/javascript/libraries." />
/// </summary>
type [<StringEnum>] [<RequireQualifiedAccess>] TravelMode =
    /// Specifies a bicycling directions request.
    | [<CompiledName("BICYCLING")>] BICYCLING
    /// Specifies a driving directions request.
    | [<CompiledName("DRIVING")>] DRIVING
    /// Specifies a transit directions request.
    | [<CompiledName("TRANSIT")>] TRANSIT
    /// Specifies a walking directions request.
    | [<CompiledName("WALKING")>] WALKING

/// <summary>
/// The valid unit systems that can be specified in a &lt;i&gt;&lt;code&gt;&lt;a
/// href="#DirectionsRequest"&gt;DirectionsRequest&lt;/a&gt;&lt;/code&gt;&lt;/i&gt;.
///
/// Access by calling `const {UnitSystem} = await
/// google.maps.importLibrary("core")`. See
/// <see href="https://developers.google.com/maps/documentation/javascript/libraries." />
/// </summary>
type [<RequireQualifiedAccess>] UnitSystem =
    /// Specifies that distances in the &lt;code&gt;DirectionsResult&lt;/code&gt; should be
    /// expressed in imperial units.
    | IMPERIAL = 0
    /// Specifies that distances in the &lt;code&gt;DirectionsResult&lt;/code&gt; should be
    /// expressed in metric units.
    | METRIC = 1

/// <summary>
/// Possible values for vehicle types.
///
/// Access by calling `const {VehicleType} = await
/// google.maps.importLibrary("routes")`. See
/// <see href="https://developers.google.com/maps/documentation/javascript/libraries." />
/// </summary>
type [<StringEnum>] [<RequireQualifiedAccess>] VehicleType =
    /// Bus.
    | [<CompiledName("BUS")>] BUS
    /// A vehicle that operates on a cable, usually on the ground. Aerial cable
    /// cars may be of the type &lt;code&gt;GONDOLA_LIFT&lt;/code&gt;.
    | [<CompiledName("CABLE_CAR")>] CABLE_CAR
    /// Commuter rail.
    | [<CompiledName("COMMUTER_TRAIN")>] COMMUTER_TRAIN
    /// Ferry.
    | [<CompiledName("FERRY")>] FERRY
    /// A vehicle that is pulled up a steep incline by a cable.
    | [<CompiledName("FUNICULAR")>] FUNICULAR
    /// An aerial cable car.
    | [<CompiledName("GONDOLA_LIFT")>] GONDOLA_LIFT
    /// Heavy rail.
    | [<CompiledName("HEAVY_RAIL")>] HEAVY_RAIL
    /// High speed train.
    | [<CompiledName("HIGH_SPEED_TRAIN")>] HIGH_SPEED_TRAIN
    /// Intercity bus.
    | [<CompiledName("INTERCITY_BUS")>] INTERCITY_BUS
    /// Light rail.
    | [<CompiledName("METRO_RAIL")>] METRO_RAIL
    /// Monorail.
    | [<CompiledName("MONORAIL")>] MONORAIL
    /// Other vehicles.
    | [<CompiledName("OTHER")>] OTHER
    /// Rail.
    | [<CompiledName("RAIL")>] RAIL
    /// Share taxi is a sort of bus transport with ability to drop off and pick
    /// up passengers anywhere on its route. Generally share taxi uses minibus
    /// vehicles.
    | [<CompiledName("SHARE_TAXI")>] SHARE_TAXI
    /// Underground light rail.
    | [<CompiledName("SUBWAY")>] SUBWAY
    /// Above ground light rail.
    | [<CompiledName("TRAM")>] TRAM
    /// Trolleybus.
    | [<CompiledName("TROLLEYBUS")>] TROLLEYBUS

/// Contains the four points defining the four-sided polygon that is the
/// visible region of the map. On a vector map this polygon can be a trapezoid
/// instead of a rectangle, when a vector map has tilt.
type [<AllowNullLiteral>] VisibleRegion =
    abstract farLeft: Google.Maps.LatLng with get, set
    abstract farRight: Google.Maps.LatLng with get, set
    /// The smallest bounding box that includes the visible region.
    abstract latLngBounds: Google.Maps.LatLngBounds with get, set
    abstract nearLeft: Google.Maps.LatLng with get, set
    abstract nearRight: Google.Maps.LatLng with get, set

type [<AllowNullLiteral>] VisualizationLibrary =
    abstract HeatmapLayer: obj with get, set

/// Drawing options.
type [<AllowNullLiteral>] WebGLDrawOptions =
    /// The WebGLRenderingContext on which to render this WebGLOverlayView.
    abstract gl: WebGLRenderingContext with get, set
    /// The matrix transformation from camera space to latitude/longitude
    /// coordinates.
    abstract transformer: Google.Maps.CoordinateTransformer with get, set

/// <summary>
/// The WebGL Overlay View provides direct access to the same WebGL rendering
/// context Google Maps Platform uses to render the vector basemap. This use of
/// a shared rendering context provides benefits such as depth occlusion with
/// 3D building geometry, and the ability to sync 2D/3D content with basemap
/// rendering. &lt;br&gt;&lt;br&gt;With WebGL Overlay View you can add content to your maps
/// using WebGL directly, or popular Graphics libraries like Three.js or
/// deck.gl. To use the overlay, you can extend
/// &lt;code&gt;google.maps.WebGLOverlayView&lt;/code&gt; and provide an implementation for
/// each of the following lifecycle hooks: <see cref="*">google.maps.WebGLOverlayView.onAdd</see>, <see cref="*">google.maps.WebGLOverlayView.onContextRestored</see>, <see cref="*">google.maps.WebGLOverlayView.onDraw</see>, <see cref="*">google.maps.WebGLOverlayView.onContextLost</see> and <see cref="*">google.maps.WebGLOverlayView.onRemove</see>. &lt;br&gt;&lt;br&gt;You must call <see cref="*">google.maps.WebGLOverlayView.setMap</see> with a valid <see cref="google.maps.Map" />
/// object to trigger the call to the &lt;code&gt;onAdd()&lt;/code&gt; method and
/// &lt;code&gt;setMap(null)&lt;/code&gt; in order to trigger the &lt;code&gt;onRemove()&lt;/code&gt;
/// method. The &lt;code&gt;setMap()&lt;/code&gt; method can be called at the time of
/// construction or at any point afterward when the overlay should be re-shown
/// after removing. The &lt;code&gt;onDraw()&lt;/code&gt; method will then be called
/// whenever a map property changes that could change the position of the
/// element, such as zoom, center, or map type. WebGLOverlayView may only be
/// added to a vector map having a <see cref="google.maps.MapOptions.mapId" />.
///
/// Access by calling `const {WebGLOverlayView} = await
/// google.maps.importLibrary("maps")`. See
/// <see href="https://developers.google.com/maps/documentation/javascript/libraries." />
/// </summary>
type [<AllowNullLiteral>] WebGLOverlayView =
    inherit Google.Maps.MVCObject
    abstract getMap: unit -> Google.Maps.Map option
    /// Implement this method to fetch or create intermediate data structures
    /// before the overlay is drawn that don’t require immediate access to the
    /// WebGL rendering context. This method must be implemented to render.
    abstract onAdd: unit -> unit
    /// This method is called when the rendering context is lost for any reason,
    /// and is where you should clean up any pre-existing GL state, since it is
    /// no longer needed.
    abstract onContextLost: unit -> unit
    /// <summary>
    /// This method is called once the rendering context is available. Use it to
    /// initialize or bind any WebGL state such as shaders or buffer objects.
    /// </summary>
    /// <param name="options">that allow developers to restore the GL context.</param>
    abstract onContextRestored: options: Google.Maps.WebGLStateOptions -> unit
    /// <summary>
    /// Implement this method to draw WebGL content directly on the map. Note
    /// that if the overlay needs a new frame drawn then call <see cref="*">google.maps.WebGLOverlayView.requestRedraw</see>.
    /// </summary>
    /// <param name="options">
    /// that allow developers to render content to an associated
    /// Google basemap.
    /// </param>
    abstract onDraw: options: Google.Maps.WebGLDrawOptions -> unit
    /// This method is called when the overlay is removed from the map with
    /// &lt;code&gt;WebGLOverlayView.setMap(null)&lt;/code&gt;, and is where you should
    /// remove all intermediate objects. This method must be implemented to
    /// render.
    abstract onRemove: unit -> unit
    /// <summary>
    /// Implement this method to handle any GL state updates outside of the
    /// render animation frame.
    /// </summary>
    /// <param name="options">that allow developerse to restore the GL context.</param>
    abstract onStateUpdate: options: Google.Maps.WebGLStateOptions -> unit
    /// Triggers the map to redraw a frame.
    abstract requestRedraw: unit -> unit
    /// Triggers the map to update GL state.
    abstract requestStateUpdate: unit -> unit
    /// <summary>Adds the overlay to the map.</summary>
    /// <param name="map">The map to access the div, model and view state.</param>
    abstract setMap: ?map: Google.Maps.Map -> unit

/// <summary>
/// The WebGL Overlay View provides direct access to the same WebGL rendering
/// context Google Maps Platform uses to render the vector basemap. This use of
/// a shared rendering context provides benefits such as depth occlusion with
/// 3D building geometry, and the ability to sync 2D/3D content with basemap
/// rendering. &lt;br&gt;&lt;br&gt;With WebGL Overlay View you can add content to your maps
/// using WebGL directly, or popular Graphics libraries like Three.js or
/// deck.gl. To use the overlay, you can extend
/// &lt;code&gt;google.maps.WebGLOverlayView&lt;/code&gt; and provide an implementation for
/// each of the following lifecycle hooks: <see cref="*">google.maps.WebGLOverlayView.onAdd</see>, <see cref="*">google.maps.WebGLOverlayView.onContextRestored</see>, <see cref="*">google.maps.WebGLOverlayView.onDraw</see>, <see cref="*">google.maps.WebGLOverlayView.onContextLost</see> and <see cref="*">google.maps.WebGLOverlayView.onRemove</see>. &lt;br&gt;&lt;br&gt;You must call <see cref="*">google.maps.WebGLOverlayView.setMap</see> with a valid <see cref="google.maps.Map" />
/// object to trigger the call to the &lt;code&gt;onAdd()&lt;/code&gt; method and
/// &lt;code&gt;setMap(null)&lt;/code&gt; in order to trigger the &lt;code&gt;onRemove()&lt;/code&gt;
/// method. The &lt;code&gt;setMap()&lt;/code&gt; method can be called at the time of
/// construction or at any point afterward when the overlay should be re-shown
/// after removing. The &lt;code&gt;onDraw()&lt;/code&gt; method will then be called
/// whenever a map property changes that could change the position of the
/// element, such as zoom, center, or map type. WebGLOverlayView may only be
/// added to a vector map having a <see cref="google.maps.MapOptions.mapId" />.
///
/// Access by calling `const {WebGLOverlayView} = await
/// google.maps.importLibrary("maps")`. See
/// <see href="https://developers.google.com/maps/documentation/javascript/libraries." />
/// </summary>
type [<AllowNullLiteral>] WebGLOverlayViewStatic =
    [<EmitConstructor>] abstract Create: unit -> WebGLOverlayView

/// GL state options.
type [<AllowNullLiteral>] WebGLStateOptions =
    /// The WebGLRenderingContext on which to render this WebGLOverlayView.
    abstract gl: WebGLRenderingContext with get, set

/// <summary>
/// Available only in the v=beta channel: <see href="https://goo.gle/3oAthT3." />
///
/// This event is created from monitoring zoom change.
///
/// Access by calling `const {ZoomChangeEvent} = await
/// google.maps.importLibrary("maps")`. See
/// <see href="https://developers.google.com/maps/documentation/javascript/libraries." />
/// </summary>
type [<AllowNullLiteral>] ZoomChangeEvent =
    inherit Event

/// <summary>
/// Available only in the v=beta channel: <see href="https://goo.gle/3oAthT3." />
///
/// This event is created from monitoring zoom change.
///
/// Access by calling `const {ZoomChangeEvent} = await
/// google.maps.importLibrary("maps")`. See
/// <see href="https://developers.google.com/maps/documentation/javascript/libraries." />
/// </summary>
type [<AllowNullLiteral>] ZoomChangeEventStatic =
    /// <summary>
    /// Available only in the v=beta channel: <see href="https://goo.gle/3oAthT3." />
    ///
    /// This event is created from monitoring zoom change.
    ///
    /// Access by calling `const {ZoomChangeEvent} = await
    /// google.maps.importLibrary("maps")`. See
    /// <see href="https://developers.google.com/maps/documentation/javascript/libraries." />
    /// </summary>
    [<EmitConstructor>] abstract Create: unit -> ZoomChangeEvent

/// Options for the rendering of the zoom control.
type [<AllowNullLiteral>] ZoomControlOptions =
    /// <summary>Position id. Used to specify the position of the control on the map.</summary>
    /// <default><see cref="google.maps.ControlPosition.INLINE_START_BLOCK_END" /></default>
    abstract position: Google.Maps.ControlPosition option with get, set

/// <summary>
/// Namespace for all public event functions
///
/// Access by calling `const {event} = await
/// google.maps.importLibrary("core")`. See
/// <see href="https://developers.google.com/maps/documentation/javascript/libraries." />
/// </summary>
type [<AllowNullLiteral>] ``event`` =
    interface end

/// <summary>
/// Namespace for all public event functions
///
/// Access by calling `const {event} = await
/// google.maps.importLibrary("core")`. See
/// <see href="https://developers.google.com/maps/documentation/javascript/libraries." />
/// </summary>
type [<AllowNullLiteral>] eventStatic =
    [<EmitConstructor>] abstract Create: unit -> ``event``
    /// Cross browser event handler registration. This listener is removed by
    /// calling removeListener(handle) for the handle that is returned by this
    /// function.
    [<Obsolete("<code>google.maps.event.addDomListener()</code> is
deprecated, use the standard <a
href=\"https://developer.mozilla.org/docs/Web/API/EventTarget/addEventListener\">addEventListener()</a>
method instead. The feature will continue to work and there is no
plan to decommission it.")>]
    abstract addDomListener: this: obj option * instance: obj * eventName: string * handler: Function * ?capture: bool -> Google.Maps.MapsEventListener
    /// Wrapper around addDomListener that removes the listener after the first
    /// event.
    [<Obsolete("<code>google.maps.event.addDomListenerOnce()</code> is
deprecated, use the standard <a
href=\"https://developer.mozilla.org/docs/Web/API/EventTarget/addEventListener\">addEventListener()</a>
method instead. The feature will continue to work and there is no
plan to decommission it.")>]
    abstract addDomListenerOnce: this: obj option * instance: obj * eventName: string * handler: Function * ?capture: bool -> Google.Maps.MapsEventListener
    /// Adds the given listener function to the given event name for the given
    /// object instance. Returns an identifier for this listener that can be used
    /// with removeListener().
    abstract addListener: this: obj option * instance: obj * eventName: string * handler: Function -> Google.Maps.MapsEventListener
    /// Like addListener, but the handler removes itself after handling the first
    /// event.
    abstract addListenerOnce: this: obj option * instance: obj * eventName: string * handler: Function -> Google.Maps.MapsEventListener
    /// Removes all listeners for all events for the given instance.
    abstract clearInstanceListeners: this: obj option * instance: obj -> unit
    /// Removes all listeners for the given event for the given instance.
    abstract clearListeners: this: obj option * instance: obj * eventName: string -> unit
    /// Returns if there are listeners for the given event on the given instance.
    /// Can be used to to save the computation of expensive event details.
    abstract hasListeners: this: obj option * instance: obj * eventName: string -> bool
    /// Removes the given listener, which should have been returned by
    /// addListener above. Equivalent to calling &lt;code&gt;listener.remove()&lt;/code&gt;.
    abstract removeListener: this: obj option * listener: Google.Maps.MapsEventListener -> unit
    /// Triggers the given event. All arguments after eventName are passed as
    /// arguments to the listeners.
    abstract trigger: this: obj option * instance: obj * eventName: string * [<ParamArray>] eventArgs: obj option[] -> unit

/// <summary>
/// A layer for displaying geospatial data. Points, line-strings and polygons
/// can be displayed. &lt;p&gt; Every &lt;code&gt;Map&lt;/code&gt; has a &lt;code&gt;Data&lt;/code&gt; object
/// by default, so most of the time there is no need to construct one. For
/// example: &lt;pre&gt; var myMap = new google.maps.Map(...);&lt;br&gt;
/// myMap.data.addGeoJson(...);&lt;br&gt; myMap.data.setStyle(...); &lt;/pre&gt; The
/// &lt;code&gt;Data&lt;/code&gt; object is a collection of &lt;a
/// href="#Data.Feature"&gt;&lt;code&gt;Features&lt;/code&gt;&lt;/a&gt;.
///
/// Access by calling <c>const {Data} = await google.maps.importLibrary("maps")</c>.
/// See <see href="https://developers.google.com/maps/documentation/javascript/libraries." />
/// </summary>
module Data =

    type [<AllowNullLiteral>] IExports =
        /// <summary>
        /// A feature has a geometry, an id, and a set of properties.
        ///
        /// Access by calling <c>const {Data} = await google.maps.importLibrary("maps")</c>.
        /// See <see href="https://developers.google.com/maps/documentation/javascript/libraries." />
        /// </summary>
        abstract Feature: FeatureStatic
        /// <summary>
        /// A GeometryCollection contains a number of geometry objects. Any
        /// &lt;code&gt;LatLng&lt;/code&gt; or &lt;code&gt;LatLngLiteral&lt;/code&gt; objects are automatically
        /// converted to &lt;code&gt;Data.Point&lt;/code&gt; geometry objects.
        ///
        /// Access by calling <c>const {Data} = await google.maps.importLibrary("maps")</c>.
        /// See <see href="https://developers.google.com/maps/documentation/javascript/libraries." />
        /// </summary>
        abstract GeometryCollection: GeometryCollectionStatic
        /// <summary>
        /// A LineString geometry contains a number of &lt;code&gt;LatLng&lt;/code&gt;s.
        ///
        /// Access by calling <c>const {Data} = await google.maps.importLibrary("maps")</c>.
        /// See <see href="https://developers.google.com/maps/documentation/javascript/libraries." />
        /// </summary>
        abstract LineString: LineStringStatic
        /// <summary>
        /// A LinearRing geometry contains a number of &lt;code&gt;LatLng&lt;/code&gt;s,
        /// representing a closed LineString. There is no need to make the first
        /// &lt;code&gt;LatLng&lt;/code&gt; equal to the last &lt;code&gt;LatLng&lt;/code&gt;. The LinearRing
        /// is closed implicitly.
        ///
        /// Access by calling <c>const {Data} = await google.maps.importLibrary("maps")</c>.
        /// See <see href="https://developers.google.com/maps/documentation/javascript/libraries." />
        /// </summary>
        abstract LinearRing: LinearRingStatic
        /// <summary>
        /// A MultiLineString geometry contains a number of &lt;code&gt;LineString&lt;/code&gt;s.
        ///
        /// Access by calling <c>const {Data} = await google.maps.importLibrary("maps")</c>.
        /// See <see href="https://developers.google.com/maps/documentation/javascript/libraries." />
        /// </summary>
        abstract MultiLineString: MultiLineStringStatic
        /// <summary>
        /// A MultiPoint geometry contains a number of &lt;code&gt;LatLng&lt;/code&gt;s.
        ///
        /// Access by calling <c>const {Data} = await google.maps.importLibrary("maps")</c>.
        /// See <see href="https://developers.google.com/maps/documentation/javascript/libraries." />
        /// </summary>
        abstract MultiPoint: MultiPointStatic
        /// <summary>
        /// A MultiPolygon geometry contains a number of &lt;code&gt;Data.Polygon&lt;/code&gt;s.
        ///
        /// Access by calling <c>const {Data} = await google.maps.importLibrary("maps")</c>.
        /// See <see href="https://developers.google.com/maps/documentation/javascript/libraries." />
        /// </summary>
        abstract MultiPolygon: MultiPolygonStatic
        /// <summary>
        /// A Point geometry contains a single &lt;code&gt;LatLng&lt;/code&gt;.
        ///
        /// Access by calling <c>const {Data} = await google.maps.importLibrary("maps")</c>.
        /// See <see href="https://developers.google.com/maps/documentation/javascript/libraries." />
        /// </summary>
        abstract Point: PointStatic
        /// <summary>
        /// A Polygon geometry contains a number of &lt;code&gt;Data.LinearRing&lt;/code&gt;s. The
        /// first linear-ring must be the polygon exterior boundary and subsequent
        /// linear-rings must be interior boundaries, also known as holes. See the &lt;a
        /// href="<see href="https://developers.google.com/maps/documentation/javascript/examples/layer-data-polygon"&gt;sample" />
        /// polygon with a hole&lt;/a&gt;.
        ///
        /// Access by calling <c>const {Data} = await google.maps.importLibrary("maps")</c>.
        /// See <see href="https://developers.google.com/maps/documentation/javascript/libraries." />
        /// </summary>
        abstract Polygon: PolygonStatic

    /// The properties of a &lt;code&gt;addfeature&lt;/code&gt; event.
    type [<AllowNullLiteral>] AddFeatureEvent =
        /// The feature that was added to the &lt;code&gt;FeatureCollection&lt;/code&gt;.
        abstract feature: Google.Maps.Data.Feature with get, set

    /// DataOptions object used to define the properties that a developer can set
    /// on a &lt;code&gt;Data&lt;/code&gt; object.
    type [<AllowNullLiteral>] DataOptions =
        /// <summary>The position of the drawing controls on the map.</summary>
        /// <default><see cref="google.maps.ControlPosition.TOP_LEFT" /></default>
        abstract controlPosition: Google.Maps.ControlPosition option with get, set
        /// <summary>
        /// Describes which drawing modes are available for the user to select, in
        /// the order they are displayed. This should not include the
        /// &lt;code&gt;null&lt;/code&gt; drawing mode, which is added by default. If
        /// &lt;code&gt;null&lt;/code&gt;, drawing controls are disabled and not displayed.
        /// Possible drawing modes are &lt;code&gt;"Point"&lt;/code&gt;,
        /// &lt;code&gt;"LineString"&lt;/code&gt; or &lt;code&gt;"Polygon"&lt;/code&gt;.
        /// </summary>
        /// <default>&lt;code&gt;null&lt;/code&gt;</default>
        abstract controls: ResizeArray<string> option with get, set
        /// <summary>
        /// The current drawing mode of the given Data layer. A drawing mode of
        /// &lt;code&gt;null&lt;/code&gt; means that the user can interact with the map as
        /// normal, and clicks do not draw anything. Possible drawing modes are
        /// &lt;code&gt;null&lt;/code&gt;, &lt;code&gt;"Point"&lt;/code&gt;, &lt;code&gt;"LineString"&lt;/code&gt; or
        /// &lt;code&gt;"Polygon"&lt;/code&gt;.
        /// </summary>
        /// <default>&lt;code&gt;null&lt;/code&gt;</default>
        abstract drawingMode: string option with get, set
        /// When drawing is enabled and a user draws a Geometry (a Point, Line String
        /// or Polygon), this function is called with that Geometry and should return
        /// a Feature that is to be added to the Data layer. If a featureFactory is
        /// not supplied, a Feature with no id and no properties will be created from
        /// that Geometry instead. Defaults to &lt;code&gt;null&lt;/code&gt;.
        abstract featureFactory: (Google.Maps.Data.Geometry -> Google.Maps.Data.Feature) option with get, set
        /// Map on which to display the features in the collection.
        abstract map: Google.Maps.Map with get, set
        /// Style for all features in the collection. For more details, see the
        /// &lt;code&gt;&lt;a href='#Data'&gt;setStyle()&lt;/a&gt;&lt;/code&gt; method above.
        abstract style: U2<Google.Maps.Data.StylingFunction, Google.Maps.Data.StyleOptions> option with get, set

    /// <summary>
    /// A feature has a geometry, an id, and a set of properties.
    ///
    /// Access by calling <c>const {Data} = await google.maps.importLibrary("maps")</c>.
    /// See <see href="https://developers.google.com/maps/documentation/javascript/libraries." />
    /// </summary>
    type [<AllowNullLiteral>] Feature =
        /// Repeatedly invokes the given function, passing a property value and name
        /// on each invocation. The order of iteration through the properties is
        /// undefined.
        abstract forEachProperty: callback: (obj -> string -> unit) -> unit
        /// Returns the feature&#39;s geometry.
        abstract getGeometry: unit -> Google.Maps.Data.Geometry option
        /// Returns the feature ID.
        abstract getId: unit -> U2<float, string> option
        /// Returns the value of the requested property, or &lt;code&gt;undefined&lt;/code&gt; if
        /// the property does not exist.
        abstract getProperty: name: string -> obj
        /// Removes the property with the given name.
        abstract removeProperty: name: string -> unit
        /// Sets the feature&#39;s geometry.
        abstract setGeometry: newGeometry: U3<Google.Maps.Data.Geometry, Google.Maps.LatLng, Google.Maps.LatLngLiteral> option -> unit
        /// Sets the value of the specified property. If &lt;code&gt;newValue&lt;/code&gt; is
        /// &lt;code&gt;undefined&lt;/code&gt; this is equivalent to calling
        /// &lt;code&gt;removeProperty&lt;/code&gt;.
        abstract setProperty: name: string * newValue: obj -> unit
        /// Exports the feature to a GeoJSON object.
        abstract toGeoJson: callback: (obj -> unit) -> unit

    /// <summary>
    /// A feature has a geometry, an id, and a set of properties.
    ///
    /// Access by calling <c>const {Data} = await google.maps.importLibrary("maps")</c>.
    /// See <see href="https://developers.google.com/maps/documentation/javascript/libraries." />
    /// </summary>
    type [<AllowNullLiteral>] FeatureStatic =
        /// <summary>
        /// A feature has a geometry, an id, and a set of properties.
        ///
        /// Access by calling `const {Data} = await
        /// google.maps.importLibrary("maps")`. See
        /// <see href="https://developers.google.com/maps/documentation/javascript/libraries." />
        /// </summary>
        [<EmitConstructor>] abstract Create: ?options: Google.Maps.Data.FeatureOptions -> Feature

    /// Optional parameters for creating &lt;code&gt;Data.Feature&lt;/code&gt; objects.
    type [<AllowNullLiteral>] FeatureOptions =
        /// The feature geometry. If none is specified when a feature is constructed,
        /// the feature&amp;#39;s geometry will be &lt;code&gt;null&lt;/code&gt;. If a
        /// &lt;code&gt;LatLng&lt;/code&gt; object or &lt;code&gt;LatLngLiteral&lt;/code&gt; is given, this
        /// will be converted to a &lt;code&gt;Data.Point&lt;/code&gt; geometry.
        abstract geometry: U3<Google.Maps.Data.Geometry, Google.Maps.LatLng, Google.Maps.LatLngLiteral> option with get, set
        /// Feature ID is optional. If provided, it can be used to look up the
        /// feature in a &lt;code&gt;Data&lt;/code&gt; object using the
        /// &lt;code&gt;getFeatureById()&lt;/code&gt; method. Note that a feature&amp;#39;s ID cannot
        /// be subsequently changed.
        abstract id: U2<float, string> option with get, set
        /// The feature properties. This is an arbitrary mapping of property names to
        /// values.
        abstract properties: obj option with get, set

    /// Optional parameters for importing GeoJSON.
    type [<AllowNullLiteral>] GeoJsonOptions =
        /// The name of the Feature property to use as the feature ID. If not
        /// specified, the GeoJSON Feature id will be used.
        abstract idPropertyName: string option with get, set

    /// A superclass for the various geometry objects.
    type [<AllowNullLiteral>] Geometry =
        /// Repeatedly invokes the given function, passing a point from the geometry
        /// to the function on each invocation.
        abstract forEachLatLng: callback: (Google.Maps.LatLng -> unit) -> unit
        /// Returns the type of the geometry object. Possibilities are
        /// &lt;code&gt;"Point"&lt;/code&gt;, &lt;code&gt;"MultiPoint"&lt;/code&gt;,
        /// &lt;code&gt;"LineString"&lt;/code&gt;, &lt;code&gt;"MultiLineString"&lt;/code&gt;,
        /// &lt;code&gt;"LinearRing"&lt;/code&gt;, &lt;code&gt;"Polygon"&lt;/code&gt;,
        /// &lt;code&gt;"MultiPolygon"&lt;/code&gt;, or &lt;code&gt;"GeometryCollection"&lt;/code&gt;.
        abstract getType: unit -> string

    /// <summary>
    /// A GeometryCollection contains a number of geometry objects. Any
    /// &lt;code&gt;LatLng&lt;/code&gt; or &lt;code&gt;LatLngLiteral&lt;/code&gt; objects are automatically
    /// converted to &lt;code&gt;Data.Point&lt;/code&gt; geometry objects.
    ///
    /// Access by calling <c>const {Data} = await google.maps.importLibrary("maps")</c>.
    /// See <see href="https://developers.google.com/maps/documentation/javascript/libraries." />
    /// </summary>
    type [<AllowNullLiteral>] GeometryCollection =
        inherit Google.Maps.Data.Geometry
        /// Repeatedly invokes the given function, passing a point from the geometry
        /// to the function on each invocation.
        abstract forEachLatLng: callback: (Google.Maps.LatLng -> unit) -> unit
        /// Returns an array of the contained geometry objects. A new array is
        /// returned each time &lt;code&gt;getArray()&lt;/code&gt; is called.
        abstract getArray: unit -> ResizeArray<Google.Maps.Data.Geometry>
        /// Returns the &lt;code&gt;n&lt;/code&gt;-th contained geometry object.
        abstract getAt: n: float -> Google.Maps.Data.Geometry
        /// Returns the number of contained geometry objects.
        abstract getLength: unit -> float
        /// Returns the string &lt;code&gt;"GeometryCollection"&lt;/code&gt;.
        abstract getType: unit -> string

    /// <summary>
    /// A GeometryCollection contains a number of geometry objects. Any
    /// &lt;code&gt;LatLng&lt;/code&gt; or &lt;code&gt;LatLngLiteral&lt;/code&gt; objects are automatically
    /// converted to &lt;code&gt;Data.Point&lt;/code&gt; geometry objects.
    ///
    /// Access by calling <c>const {Data} = await google.maps.importLibrary("maps")</c>.
    /// See <see href="https://developers.google.com/maps/documentation/javascript/libraries." />
    /// </summary>
    type [<AllowNullLiteral>] GeometryCollectionStatic =
        /// <summary>
        /// A GeometryCollection contains a number of geometry objects. Any
        /// &lt;code&gt;LatLng&lt;/code&gt; or &lt;code&gt;LatLngLiteral&lt;/code&gt; objects are
        /// automatically converted to &lt;code&gt;Data.Point&lt;/code&gt; geometry objects.
        ///
        /// Access by calling `const {Data} = await
        /// google.maps.importLibrary("maps")`. See
        /// <see href="https://developers.google.com/maps/documentation/javascript/libraries." />
        /// </summary>
        [<EmitConstructor>] abstract Create: elements: Array<U3<Google.Maps.Data.Geometry, Google.Maps.LatLng, Google.Maps.LatLngLiteral>> -> GeometryCollection

    /// <summary>
    /// A LineString geometry contains a number of &lt;code&gt;LatLng&lt;/code&gt;s.
    ///
    /// Access by calling <c>const {Data} = await google.maps.importLibrary("maps")</c>.
    /// See <see href="https://developers.google.com/maps/documentation/javascript/libraries." />
    /// </summary>
    type [<AllowNullLiteral>] LineString =
        inherit Google.Maps.Data.Geometry
        /// Repeatedly invokes the given function, passing a point from the geometry
        /// to the function on each invocation.
        abstract forEachLatLng: callback: (Google.Maps.LatLng -> unit) -> unit
        /// Returns an array of the contained &lt;code&gt;LatLngs&lt;/code&gt;. A new array is
        /// returned each time &lt;code&gt;getArray()&lt;/code&gt; is called.
        abstract getArray: unit -> ResizeArray<Google.Maps.LatLng>
        /// Returns the &lt;code&gt;n&lt;/code&gt;-th contained &lt;code&gt;LatLng&lt;/code&gt;.
        abstract getAt: n: float -> Google.Maps.LatLng
        /// Returns the number of contained &lt;code&gt;LatLng&lt;/code&gt;s.
        abstract getLength: unit -> float
        /// Returns the string &lt;code&gt;"LineString"&lt;/code&gt;.
        abstract getType: unit -> string

    /// <summary>
    /// A LineString geometry contains a number of &lt;code&gt;LatLng&lt;/code&gt;s.
    ///
    /// Access by calling <c>const {Data} = await google.maps.importLibrary("maps")</c>.
    /// See <see href="https://developers.google.com/maps/documentation/javascript/libraries." />
    /// </summary>
    type [<AllowNullLiteral>] LineStringStatic =
        /// <summary>
        /// A LineString geometry contains a number of &lt;code&gt;LatLng&lt;/code&gt;s.
        ///
        /// Access by calling `const {Data} = await
        /// google.maps.importLibrary("maps")`. See
        /// <see href="https://developers.google.com/maps/documentation/javascript/libraries." />
        /// </summary>
        [<EmitConstructor>] abstract Create: elements: Array<U2<Google.Maps.LatLng, Google.Maps.LatLngLiteral>> -> LineString

    /// <summary>
    /// A LinearRing geometry contains a number of &lt;code&gt;LatLng&lt;/code&gt;s,
    /// representing a closed LineString. There is no need to make the first
    /// &lt;code&gt;LatLng&lt;/code&gt; equal to the last &lt;code&gt;LatLng&lt;/code&gt;. The LinearRing
    /// is closed implicitly.
    ///
    /// Access by calling <c>const {Data} = await google.maps.importLibrary("maps")</c>.
    /// See <see href="https://developers.google.com/maps/documentation/javascript/libraries." />
    /// </summary>
    type [<AllowNullLiteral>] LinearRing =
        inherit Google.Maps.Data.Geometry
        /// Repeatedly invokes the given function, passing a point from the geometry
        /// to the function on each invocation.
        abstract forEachLatLng: callback: (Google.Maps.LatLng -> unit) -> unit
        /// Returns an array of the contained &lt;code&gt;LatLng&lt;/code&gt;s. A new array is
        /// returned each time &lt;code&gt;getArray()&lt;/code&gt; is called.
        abstract getArray: unit -> ResizeArray<Google.Maps.LatLng>
        /// Returns the &lt;code&gt;n&lt;/code&gt;-th contained &lt;code&gt;LatLng&lt;/code&gt;.
        abstract getAt: n: float -> Google.Maps.LatLng
        /// Returns the number of contained &lt;code&gt;LatLng&lt;/code&gt;s.
        abstract getLength: unit -> float
        /// Returns the string &lt;code&gt;"LinearRing"&lt;/code&gt;.
        abstract getType: unit -> string

    /// <summary>
    /// A LinearRing geometry contains a number of &lt;code&gt;LatLng&lt;/code&gt;s,
    /// representing a closed LineString. There is no need to make the first
    /// &lt;code&gt;LatLng&lt;/code&gt; equal to the last &lt;code&gt;LatLng&lt;/code&gt;. The LinearRing
    /// is closed implicitly.
    ///
    /// Access by calling <c>const {Data} = await google.maps.importLibrary("maps")</c>.
    /// See <see href="https://developers.google.com/maps/documentation/javascript/libraries." />
    /// </summary>
    type [<AllowNullLiteral>] LinearRingStatic =
        /// <summary>
        /// A LinearRing geometry contains a number of &lt;code&gt;LatLng&lt;/code&gt;s,
        /// representing a closed LineString. There is no need to make the first
        /// &lt;code&gt;LatLng&lt;/code&gt; equal to the last &lt;code&gt;LatLng&lt;/code&gt;. The LinearRing
        /// is closed implicitly.
        ///
        /// Access by calling `const {Data} = await
        /// google.maps.importLibrary("maps")`. See
        /// <see href="https://developers.google.com/maps/documentation/javascript/libraries." />
        /// </summary>
        [<EmitConstructor>] abstract Create: elements: Array<U2<Google.Maps.LatLng, Google.Maps.LatLngLiteral>> -> LinearRing

    /// This object is passed to mouse event handlers on a &lt;code&gt;Data&lt;/code&gt;
    /// object.
    type [<AllowNullLiteral>] MouseEvent =
        inherit Google.Maps.MapMouseEvent
        /// The feature which generated the mouse event.
        abstract feature: Google.Maps.Data.Feature with get, set

    /// <summary>
    /// A MultiLineString geometry contains a number of &lt;code&gt;LineString&lt;/code&gt;s.
    ///
    /// Access by calling <c>const {Data} = await google.maps.importLibrary("maps")</c>.
    /// See <see href="https://developers.google.com/maps/documentation/javascript/libraries." />
    /// </summary>
    type [<AllowNullLiteral>] MultiLineString =
        inherit Google.Maps.Data.Geometry
        /// Repeatedly invokes the given function, passing a point from the geometry
        /// to the function on each invocation.
        abstract forEachLatLng: callback: (Google.Maps.LatLng -> unit) -> unit
        /// Returns an array of the contained &lt;code&gt;Data.LineString&lt;/code&gt;s. A new
        /// array is returned each time &lt;code&gt;getArray()&lt;/code&gt; is called.
        abstract getArray: unit -> ResizeArray<Google.Maps.Data.LineString>
        /// Returns the &lt;code&gt;n&lt;/code&gt;-th contained &lt;code&gt;Data.LineString&lt;/code&gt;.
        abstract getAt: n: float -> Google.Maps.Data.LineString
        /// Returns the number of contained &lt;code&gt;Data.LineString&lt;/code&gt;s.
        abstract getLength: unit -> float
        /// Returns the string &lt;code&gt;"MultiLineString"&lt;/code&gt;.
        abstract getType: unit -> string

    /// <summary>
    /// A MultiLineString geometry contains a number of &lt;code&gt;LineString&lt;/code&gt;s.
    ///
    /// Access by calling <c>const {Data} = await google.maps.importLibrary("maps")</c>.
    /// See <see href="https://developers.google.com/maps/documentation/javascript/libraries." />
    /// </summary>
    type [<AllowNullLiteral>] MultiLineStringStatic =
        /// <summary>
        /// A MultiLineString geometry contains a number of &lt;code&gt;LineString&lt;/code&gt;s.
        ///
        /// Access by calling `const {Data} = await
        /// google.maps.importLibrary("maps")`. See
        /// <see href="https://developers.google.com/maps/documentation/javascript/libraries." />
        /// </summary>
        [<EmitConstructor>] abstract Create: elements: Array<U2<Google.Maps.Data.LineString, Array<U2<Google.Maps.LatLng, Google.Maps.LatLngLiteral>>>> -> MultiLineString

    /// <summary>
    /// A MultiPoint geometry contains a number of &lt;code&gt;LatLng&lt;/code&gt;s.
    ///
    /// Access by calling <c>const {Data} = await google.maps.importLibrary("maps")</c>.
    /// See <see href="https://developers.google.com/maps/documentation/javascript/libraries." />
    /// </summary>
    type [<AllowNullLiteral>] MultiPoint =
        inherit Google.Maps.Data.Geometry
        /// Repeatedly invokes the given function, passing a point from the geometry
        /// to the function on each invocation.
        abstract forEachLatLng: callback: (Google.Maps.LatLng -> unit) -> unit
        /// Returns an array of the contained &lt;code&gt;LatLng&lt;/code&gt;s. A new array is
        /// returned each time &lt;code&gt;getArray()&lt;/code&gt; is called.
        abstract getArray: unit -> ResizeArray<Google.Maps.LatLng>
        /// Returns the &lt;code&gt;n&lt;/code&gt;-th contained &lt;code&gt;LatLng&lt;/code&gt;.
        abstract getAt: n: float -> Google.Maps.LatLng
        /// Returns the number of contained &lt;code&gt;LatLng&lt;/code&gt;s.
        abstract getLength: unit -> float
        /// Returns the string &lt;code&gt;"MultiPoint"&lt;/code&gt;.
        abstract getType: unit -> string

    /// <summary>
    /// A MultiPoint geometry contains a number of &lt;code&gt;LatLng&lt;/code&gt;s.
    ///
    /// Access by calling <c>const {Data} = await google.maps.importLibrary("maps")</c>.
    /// See <see href="https://developers.google.com/maps/documentation/javascript/libraries." />
    /// </summary>
    type [<AllowNullLiteral>] MultiPointStatic =
        /// <summary>
        /// A MultiPoint geometry contains a number of &lt;code&gt;LatLng&lt;/code&gt;s.
        ///
        /// Access by calling `const {Data} = await
        /// google.maps.importLibrary("maps")`. See
        /// <see href="https://developers.google.com/maps/documentation/javascript/libraries." />
        /// </summary>
        [<EmitConstructor>] abstract Create: elements: Array<U2<Google.Maps.LatLng, Google.Maps.LatLngLiteral>> -> MultiPoint

    /// <summary>
    /// A MultiPolygon geometry contains a number of &lt;code&gt;Data.Polygon&lt;/code&gt;s.
    ///
    /// Access by calling <c>const {Data} = await google.maps.importLibrary("maps")</c>.
    /// See <see href="https://developers.google.com/maps/documentation/javascript/libraries." />
    /// </summary>
    type [<AllowNullLiteral>] MultiPolygon =
        inherit Google.Maps.Data.Geometry
        /// Repeatedly invokes the given function, passing a point from the geometry
        /// to the function on each invocation.
        abstract forEachLatLng: callback: (Google.Maps.LatLng -> unit) -> unit
        /// Returns an array of the contained &lt;code&gt;Data.Polygon&lt;/code&gt;s. A new array
        /// is returned each time &lt;code&gt;getArray()&lt;/code&gt; is called.
        abstract getArray: unit -> ResizeArray<Google.Maps.Data.Polygon>
        /// Returns the &lt;code&gt;n&lt;/code&gt;-th contained &lt;code&gt;Data.Polygon&lt;/code&gt;.
        abstract getAt: n: float -> Google.Maps.Data.Polygon
        /// Returns the number of contained &lt;code&gt;Data.Polygon&lt;/code&gt;s.
        abstract getLength: unit -> float
        /// Returns the string &lt;code&gt;"MultiPolygon"&lt;/code&gt;.
        abstract getType: unit -> string

    /// <summary>
    /// A MultiPolygon geometry contains a number of &lt;code&gt;Data.Polygon&lt;/code&gt;s.
    ///
    /// Access by calling <c>const {Data} = await google.maps.importLibrary("maps")</c>.
    /// See <see href="https://developers.google.com/maps/documentation/javascript/libraries." />
    /// </summary>
    type [<AllowNullLiteral>] MultiPolygonStatic =
        /// <summary>
        /// A MultiPolygon geometry contains a number of &lt;code&gt;Data.Polygon&lt;/code&gt;s.
        ///
        /// Access by calling `const {Data} = await
        /// google.maps.importLibrary("maps")`. See
        /// <see href="https://developers.google.com/maps/documentation/javascript/libraries." />
        /// </summary>
        [<EmitConstructor>] abstract Create: elements: Array<U2<Google.Maps.Data.Polygon, Array<U2<Google.Maps.Data.LinearRing, Array<U2<Google.Maps.LatLng, Google.Maps.LatLngLiteral>>>>>> -> MultiPolygon

    /// <summary>
    /// A Point geometry contains a single &lt;code&gt;LatLng&lt;/code&gt;.
    ///
    /// Access by calling <c>const {Data} = await google.maps.importLibrary("maps")</c>.
    /// See <see href="https://developers.google.com/maps/documentation/javascript/libraries." />
    /// </summary>
    type [<AllowNullLiteral>] Point =
        inherit Google.Maps.Data.Geometry
        /// Repeatedly invokes the given function, passing a point from the geometry
        /// to the function on each invocation.
        abstract forEachLatLng: callback: (Google.Maps.LatLng -> unit) -> unit
        /// Returns the contained &lt;code&gt;LatLng&lt;/code&gt;.
        abstract get: unit -> Google.Maps.LatLng
        /// Returns the string &lt;code&gt;"Point"&lt;/code&gt;.
        abstract getType: unit -> string

    /// <summary>
    /// A Point geometry contains a single &lt;code&gt;LatLng&lt;/code&gt;.
    ///
    /// Access by calling <c>const {Data} = await google.maps.importLibrary("maps")</c>.
    /// See <see href="https://developers.google.com/maps/documentation/javascript/libraries." />
    /// </summary>
    type [<AllowNullLiteral>] PointStatic =
        /// <summary>
        /// A Point geometry contains a single &lt;code&gt;LatLng&lt;/code&gt;.
        ///
        /// Access by calling `const {Data} = await
        /// google.maps.importLibrary("maps")`. See
        /// <see href="https://developers.google.com/maps/documentation/javascript/libraries." />
        /// </summary>
        [<EmitConstructor>] abstract Create: latLng: U2<Google.Maps.LatLng, Google.Maps.LatLngLiteral> -> Point

    /// <summary>
    /// A Polygon geometry contains a number of &lt;code&gt;Data.LinearRing&lt;/code&gt;s. The
    /// first linear-ring must be the polygon exterior boundary and subsequent
    /// linear-rings must be interior boundaries, also known as holes. See the &lt;a
    /// href="<see href="https://developers.google.com/maps/documentation/javascript/examples/layer-data-polygon"&gt;sample" />
    /// polygon with a hole&lt;/a&gt;.
    ///
    /// Access by calling <c>const {Data} = await google.maps.importLibrary("maps")</c>.
    /// See <see href="https://developers.google.com/maps/documentation/javascript/libraries." />
    /// </summary>
    type [<AllowNullLiteral>] Polygon =
        inherit Google.Maps.Data.Geometry
        /// Repeatedly invokes the given function, passing a point from the geometry
        /// to the function on each invocation.
        abstract forEachLatLng: callback: (Google.Maps.LatLng -> unit) -> unit
        /// Returns an array of the contained &lt;code&gt;Data.LinearRing&lt;/code&gt;s. A new
        /// array is returned each time &lt;code&gt;getArray()&lt;/code&gt; is called.
        abstract getArray: unit -> ResizeArray<Google.Maps.Data.LinearRing>
        /// Returns the &lt;code&gt;n&lt;/code&gt;-th contained &lt;code&gt;Data.LinearRing&lt;/code&gt;.
        abstract getAt: n: float -> Google.Maps.Data.LinearRing
        /// Returns the number of contained &lt;code&gt;Data.LinearRing&lt;/code&gt;s.
        abstract getLength: unit -> float
        /// Returns the string &lt;code&gt;"Polygon"&lt;/code&gt;.
        abstract getType: unit -> string

    /// <summary>
    /// A Polygon geometry contains a number of &lt;code&gt;Data.LinearRing&lt;/code&gt;s. The
    /// first linear-ring must be the polygon exterior boundary and subsequent
    /// linear-rings must be interior boundaries, also known as holes. See the &lt;a
    /// href="<see href="https://developers.google.com/maps/documentation/javascript/examples/layer-data-polygon"&gt;sample" />
    /// polygon with a hole&lt;/a&gt;.
    ///
    /// Access by calling <c>const {Data} = await google.maps.importLibrary("maps")</c>.
    /// See <see href="https://developers.google.com/maps/documentation/javascript/libraries." />
    /// </summary>
    type [<AllowNullLiteral>] PolygonStatic =
        /// <summary>
        /// A Polygon geometry contains a number of &lt;code&gt;Data.LinearRing&lt;/code&gt;s.
        /// The first linear-ring must be the polygon exterior boundary and
        /// subsequent linear-rings must be interior boundaries, also known as holes.
        /// See the &lt;a
        /// href="<see href="https://developers.google.com/maps/documentation/javascript/examples/layer-data-polygon"&gt;sample" />
        /// polygon with a hole&lt;/a&gt;.
        ///
        /// Access by calling `const {Data} = await
        /// google.maps.importLibrary("maps")`. See
        /// <see href="https://developers.google.com/maps/documentation/javascript/libraries." />
        /// </summary>
        [<EmitConstructor>] abstract Create: elements: Array<U2<Google.Maps.Data.LinearRing, Array<U2<Google.Maps.LatLng, Google.Maps.LatLngLiteral>>>> -> Polygon

    /// The properties of a &lt;code&gt;removefeature&lt;/code&gt; event.
    type [<AllowNullLiteral>] RemoveFeatureEvent =
        /// The feature that was removed from the &lt;code&gt;FeatureCollection&lt;/code&gt;.
        abstract feature: Google.Maps.Data.Feature with get, set

    /// The properties of a &lt;code&gt;removeproperty&lt;/code&gt; event.
    type [<AllowNullLiteral>] RemovePropertyEvent =
        /// The feature whose property was removed.
        abstract feature: Google.Maps.Data.Feature with get, set
        /// The property name.
        abstract name: string with get, set
        /// The previous value.
        abstract oldValue: obj with get, set

    /// The properties of a &lt;code&gt;setgeometry&lt;/code&gt; event.
    type [<AllowNullLiteral>] SetGeometryEvent =
        /// The feature whose geometry was set.
        abstract feature: Google.Maps.Data.Feature with get, set
        /// The new feature geometry.
        abstract newGeometry: Google.Maps.Data.Geometry option with get, set
        /// The previous feature geometry.
        abstract oldGeometry: Google.Maps.Data.Geometry option with get, set

    /// The properties of a &lt;code&gt;setproperty&lt;/code&gt; event.
    type [<AllowNullLiteral>] SetPropertyEvent =
        /// The feature whose property was set.
        abstract feature: Google.Maps.Data.Feature with get, set
        /// The property name.
        abstract name: string with get, set
        /// The new value.
        abstract newValue: obj with get, set
        /// The previous value. Will be &lt;code&gt;undefined&lt;/code&gt; if the property was
        /// added.
        abstract oldValue: obj with get, set

    /// These options specify the way a Feature should appear when displayed on a
    /// map.
    type [<AllowNullLiteral>] StyleOptions =
        /// The animation to play when marker is added to a map. Only applies to
        /// point geometries.
        abstract animation: Google.Maps.Animation option with get, set
        /// <summary>If &lt;code&gt;true&lt;/code&gt;, the marker receives mouse and touch events.</summary>
        /// <default>&lt;code&gt;true&lt;/code&gt;</default>
        abstract clickable: bool option with get, set
        /// Mouse cursor to show on hover. Only applies to point geometries.
        abstract cursor: string option with get, set
        /// <summary>
        /// If &lt;code&gt;true&lt;/code&gt;, the object can be dragged across the map and the
        /// underlying feature will have its geometry updated.
        /// </summary>
        /// <default>&lt;code&gt;false&lt;/code&gt;</default>
        abstract draggable: bool option with get, set
        /// <summary>
        /// If &lt;code&gt;true&lt;/code&gt;, the object can be edited by dragging control points
        /// and the underlying feature will have its geometry updated. Only applies
        /// to LineString and Polygon geometries.
        /// </summary>
        /// <default>&lt;code&gt;false&lt;/code&gt;</default>
        abstract editable: bool option with get, set
        /// The fill color. All CSS3 colors are supported except for extended named
        /// colors. Only applies to polygon geometries.
        abstract fillColor: string option with get, set
        /// The fill opacity between 0.0 and 1.0. Only applies to polygon geometries.
        abstract fillOpacity: float option with get, set
        /// Icon for the foreground. If a string is provided, it is treated as though
        /// it were an &lt;code&gt;Icon&lt;/code&gt; with the string as &lt;code&gt;url&lt;/code&gt;. Only
        /// applies to point geometries.
        abstract icon: U3<string, Google.Maps.Icon, Google.Maps.Symbol> option with get, set
        /// The icons to be rendered along a polyline. Only applies to line
        /// geometries.
        abstract icons: ResizeArray<Google.Maps.IconSequence> option with get, set
        /// Adds a label to the marker. The label can either be a string, or a
        /// &lt;code&gt;MarkerLabel&lt;/code&gt; object. Only applies to point geometries.
        abstract label: U2<string, Google.Maps.MarkerLabel> option with get, set
        /// The marker&#39;s opacity between 0.0 and 1.0. Only applies to point
        /// geometries.
        abstract opacity: float option with get, set
        /// Defines the image map used for hit detection. Only applies to point
        /// geometries.
        abstract shape: Google.Maps.MarkerShape option with get, set
        /// The stroke color. All CSS3 colors are supported except for extended named
        /// colors. Only applies to line and polygon geometries.
        abstract strokeColor: string option with get, set
        /// The stroke opacity between 0.0 and 1.0. Only applies to line and polygon
        /// geometries.
        abstract strokeOpacity: float option with get, set
        /// The stroke width in pixels. Only applies to line and polygon geometries.
        abstract strokeWeight: float option with get, set
        /// Rollover text. Only applies to point geometries.
        abstract title: string option with get, set
        /// <summary>Whether the feature is visible.</summary>
        /// <default>&lt;code&gt;true&lt;/code&gt;</default>
        abstract visible: bool option with get, set
        /// All features are displayed on the map in order of their zIndex, with
        /// higher values displaying in front of features with lower values. Markers
        /// are always displayed in front of line-strings and polygons.
        abstract zIndex: float option with get, set

    type [<AllowNullLiteral>] StylingFunction =
        [<Emit("$0($1...)")>] abstract Invoke: a: Google.Maps.Data.Feature -> Google.Maps.Data.StyleOptions

module Drawing =

    type [<AllowNullLiteral>] IExports =
        /// <summary>
        /// Allows users to draw markers, polygons, polylines, rectangles, and circles
        /// on the map. The &lt;code&gt;DrawingManager&lt;/code&gt;&amp;#39;s drawing mode defines the
        /// type of overlay that will be created by the user. Adds a control to the
        /// map, allowing the user to switch drawing mode.
        ///
        /// Access by calling `const {DrawingManager} = await
        /// google.maps.importLibrary("drawing")`. See
        /// <see href="https://developers.google.com/maps/documentation/javascript/libraries." />
        /// </summary>
        abstract DrawingManager: DrawingManagerStatic

    /// Options for the rendering of the drawing control.
    type [<AllowNullLiteral>] DrawingControlOptions =
        /// <summary>
        /// The drawing modes to display in the drawing control, in the order in
        /// which they are to be displayed. The hand icon (which corresponds to the
        /// &lt;code&gt;null&lt;/code&gt; drawing mode) is always available and is not to be
        /// specified in this array.
        /// </summary>
        /// <default>&lt;code&gt;[{@link  * google.maps.drawing.OverlayType.MARKER}, {@link  * google.maps.drawing.OverlayType.POLYLINE}, {@link  * google.maps.drawing.OverlayType.RECTANGLE}, {@link  * google.maps.drawing.OverlayType.CIRCLE}, {@link  * google.maps.drawing.OverlayType.POLYGON}]&lt;/code&gt;</default>
        abstract drawingModes: ResizeArray<Google.Maps.Drawing.OverlayType> option with get, set
        /// <summary>Position id. Used to specify the position of the control on the map.</summary>
        /// <default><see cref="google.maps.ControlPosition.TOP_LEFT" /></default>
        abstract position: Google.Maps.ControlPosition option with get, set

    /// <summary>
    /// Allows users to draw markers, polygons, polylines, rectangles, and circles
    /// on the map. The &lt;code&gt;DrawingManager&lt;/code&gt;&amp;#39;s drawing mode defines the
    /// type of overlay that will be created by the user. Adds a control to the
    /// map, allowing the user to switch drawing mode.
    ///
    /// Access by calling `const {DrawingManager} = await
    /// google.maps.importLibrary("drawing")`. See
    /// <see href="https://developers.google.com/maps/documentation/javascript/libraries." />
    /// </summary>
    type [<AllowNullLiteral>] DrawingManager =
        inherit Google.Maps.MVCObject
        /// Returns the &lt;code&gt;DrawingManager&lt;/code&gt;&amp;#39;s drawing mode.
        abstract getDrawingMode: unit -> Google.Maps.Drawing.OverlayType option
        /// Returns the &lt;code&gt;Map&lt;/code&gt; to which the &lt;code&gt;DrawingManager&lt;/code&gt; is
        /// attached, which is the &lt;code&gt;Map&lt;/code&gt; on which the overlays created
        /// will be placed.
        abstract getMap: unit -> Google.Maps.Map option
        /// Changes the &lt;code&gt;DrawingManager&lt;/code&gt;&amp;#39;s drawing mode, which defines
        /// the type of overlay to be added on the map. Accepted values are
        /// &lt;code&gt;'marker'&lt;/code&gt;, &lt;code&gt;'polygon'&lt;/code&gt;, &lt;code&gt;'polyline'&lt;/code&gt;,
        /// &lt;code&gt;'rectangle'&lt;/code&gt;, &lt;code&gt;'circle'&lt;/code&gt;, or &lt;code&gt;null&lt;/code&gt;. A
        /// drawing mode of &lt;code&gt;null&lt;/code&gt; means that the user can interact with
        /// the map as normal, and clicks do not draw anything.
        abstract setDrawingMode: drawingMode: Google.Maps.Drawing.OverlayType option -> unit
        /// Attaches the &lt;code&gt;DrawingManager&lt;/code&gt; object to the specified
        /// &lt;code&gt;Map&lt;/code&gt;.
        abstract setMap: map: Google.Maps.Map option -> unit
        /// Sets the &lt;code&gt;DrawingManager&lt;/code&gt;&amp;#39;s options.
        abstract setOptions: options: Google.Maps.Drawing.DrawingManagerOptions option -> unit

    /// <summary>
    /// Allows users to draw markers, polygons, polylines, rectangles, and circles
    /// on the map. The &lt;code&gt;DrawingManager&lt;/code&gt;&amp;#39;s drawing mode defines the
    /// type of overlay that will be created by the user. Adds a control to the
    /// map, allowing the user to switch drawing mode.
    ///
    /// Access by calling `const {DrawingManager} = await
    /// google.maps.importLibrary("drawing")`. See
    /// <see href="https://developers.google.com/maps/documentation/javascript/libraries." />
    /// </summary>
    type [<AllowNullLiteral>] DrawingManagerStatic =
        /// <summary>
        /// Allows users to draw markers, polygons, polylines, rectangles, and
        /// circles on the map. The &lt;code&gt;DrawingManager&lt;/code&gt;&amp;#39;s drawing mode
        /// defines the type of overlay that will be created by the user. Adds a
        /// control to the map, allowing the user to switch drawing mode.
        ///
        /// Access by calling `const {DrawingManager} = await
        /// google.maps.importLibrary("drawing")`. See
        /// <see href="https://developers.google.com/maps/documentation/javascript/libraries." />
        /// </summary>
        [<EmitConstructor>] abstract Create: ?options: Google.Maps.Drawing.DrawingManagerOptions -> DrawingManager

    /// Options for the drawing manager.
    type [<AllowNullLiteral>] DrawingManagerOptions =
        /// Options to apply to any new circles created with this
        /// &lt;code&gt;DrawingManager&lt;/code&gt;. The &lt;code&gt;center&lt;/code&gt; and
        /// &lt;code&gt;radius&lt;/code&gt; properties are ignored, and the &lt;code&gt;map&lt;/code&gt;
        /// property of a new circle is always set to the
        /// &lt;code&gt;DrawingManager&lt;/code&gt;&amp;#39;s map.
        abstract circleOptions: Google.Maps.CircleOptions option with get, set
        /// <summary>The enabled/disabled state of the drawing control.</summary>
        /// <default>&lt;code&gt;true&lt;/code&gt;</default>
        abstract drawingControl: bool option with get, set
        /// The display options for the drawing control.
        abstract drawingControlOptions: Google.Maps.Drawing.DrawingControlOptions option with get, set
        /// The &lt;code&gt;DrawingManager&lt;/code&gt;&amp;#39;s drawing mode, which defines the
        /// type of overlay to be added on the map. Accepted values are
        /// &lt;code&gt;'marker'&lt;/code&gt;, &lt;code&gt;'polygon'&lt;/code&gt;, &lt;code&gt;'polyline'&lt;/code&gt;,
        /// &lt;code&gt;'rectangle'&lt;/code&gt;, &lt;code&gt;'circle'&lt;/code&gt;, or &lt;code&gt;null&lt;/code&gt;. A
        /// drawing mode of &lt;code&gt;null&lt;/code&gt; means that the user can interact with
        /// the map as normal, and clicks do not draw anything.
        abstract drawingMode: Google.Maps.Drawing.OverlayType option with get, set
        /// The &lt;code&gt;Map&lt;/code&gt; to which the &lt;code&gt;DrawingManager&lt;/code&gt; is
        /// attached, which is the &lt;code&gt;Map&lt;/code&gt; on which the overlays created
        /// will be placed.
        abstract map: Google.Maps.Map option with get, set
        /// Options to apply to any new markers created with this
        /// &lt;code&gt;DrawingManager&lt;/code&gt;. The &lt;code&gt;position&lt;/code&gt; property is
        /// ignored, and the &lt;code&gt;map&lt;/code&gt; property of a new marker is always set
        /// to the &lt;code&gt;DrawingManager&lt;/code&gt;&amp;#39;s map.
        abstract markerOptions: Google.Maps.MarkerOptions option with get, set
        /// Options to apply to any new polygons created with this
        /// &lt;code&gt;DrawingManager&lt;/code&gt;. The &lt;code&gt;paths&lt;/code&gt; property is ignored,
        /// and the &lt;code&gt;map&lt;/code&gt; property of a new polygon is always set to the
        /// &lt;code&gt;DrawingManager&lt;/code&gt;&amp;#39;s map.
        abstract polygonOptions: Google.Maps.PolygonOptions option with get, set
        /// Options to apply to any new polylines created with this
        /// &lt;code&gt;DrawingManager&lt;/code&gt;. The &lt;code&gt;path&lt;/code&gt; property is ignored,
        /// and the &lt;code&gt;map&lt;/code&gt; property of a new polyline is always set to the
        /// &lt;code&gt;DrawingManager&lt;/code&gt;&amp;#39;s map.
        abstract polylineOptions: Google.Maps.PolylineOptions option with get, set
        /// Options to apply to any new rectangles created with this
        /// &lt;code&gt;DrawingManager&lt;/code&gt;. The &lt;code&gt;bounds&lt;/code&gt; property is ignored,
        /// and the &lt;code&gt;map&lt;/code&gt; property of a new rectangle is always set to the
        /// &lt;code&gt;DrawingManager&lt;/code&gt;&amp;#39;s map.
        abstract rectangleOptions: Google.Maps.RectangleOptions option with get, set

    /// The properties of an overlaycomplete event on a
    /// &lt;code&gt;DrawingManager&lt;/code&gt;.
    type [<AllowNullLiteral>] OverlayCompleteEvent =
        /// The completed overlay.
        abstract overlay: U5<Google.Maps.Marker, Google.Maps.Polygon, Google.Maps.Polyline, Google.Maps.Rectangle, Google.Maps.Circle> option with get, set
        /// The completed overlay&#39;s type.
        abstract ``type``: Google.Maps.Drawing.OverlayType with get, set

    /// <summary>
    /// The types of overlay that may be created by the
    /// &lt;code&gt;DrawingManager&lt;/code&gt;. Specify these by value, or by using the
    /// constant&amp;#39;s name. For example, &lt;code&gt;'polygon'&lt;/code&gt; or
    /// &lt;code&gt;google.maps.drawing.OverlayType.POLYGON&lt;/code&gt;.
    ///
    /// Access by calling `const {OverlayType} = await
    /// google.maps.importLibrary("drawing")`. See
    /// <see href="https://developers.google.com/maps/documentation/javascript/libraries." />
    /// </summary>
    type [<StringEnum>] [<RequireQualifiedAccess>] OverlayType =
        /// Specifies that the &lt;code&gt;DrawingManager&lt;/code&gt; creates circles, and that
        /// the overlay given in the &lt;code&gt;overlaycomplete&lt;/code&gt; event is a circle.
        | [<CompiledName("circle")>] CIRCLE
        /// Specifies that the &lt;code&gt;DrawingManager&lt;/code&gt; creates markers, and that
        /// the overlay given in the &lt;code&gt;overlaycomplete&lt;/code&gt; event is a marker.
        | [<CompiledName("marker")>] MARKER
        /// Specifies that the &lt;code&gt;DrawingManager&lt;/code&gt; creates polygons, and that
        /// the overlay given in the &lt;code&gt;overlaycomplete&lt;/code&gt; event is a polygon.
        | [<CompiledName("polygon")>] POLYGON
        /// Specifies that the &lt;code&gt;DrawingManager&lt;/code&gt; creates polylines, and
        /// that the overlay given in the &lt;code&gt;overlaycomplete&lt;/code&gt; event is a
        /// polyline.
        | [<CompiledName("polyline")>] POLYLINE
        /// Specifies that the &lt;code&gt;DrawingManager&lt;/code&gt; creates rectangles, and
        /// that the overlay given in the &lt;code&gt;overlaycomplete&lt;/code&gt; event is a
        /// rectangle.
        | [<CompiledName("rectangle")>] RECTANGLE

module Geometry =
    let [<Import("encoding","module/google/maps/geometry")>] encoding: Encoding.IExports = jsNative
    let [<Import("poly","module/google/maps/geometry")>] poly: Poly.IExports = jsNative
    let [<Import("spherical","module/google/maps/geometry")>] spherical: Spherical.IExports = jsNative

    module Encoding =

        type [<AllowNullLiteral>] IExports =
            /// Decodes an encoded path string into a sequence of LatLngs.
            abstract decodePath: encodedPath: string -> ResizeArray<Google.Maps.LatLng>
            /// Encodes a sequence of LatLngs into an encoded path string.
            abstract encodePath: path: U2<Array<U2<Google.Maps.LatLng, Google.Maps.LatLngLiteral>>, Google.Maps.MVCArray<U2<Google.Maps.LatLng, Google.Maps.LatLngLiteral>>> -> string

    module Poly =

        type [<AllowNullLiteral>] IExports =
            /// Computes whether the given point lies inside the specified polygon.
            abstract containsLocation: point: U2<Google.Maps.LatLng, Google.Maps.LatLngLiteral> * polygon: Google.Maps.Polygon -> bool
            /// Computes whether the given point lies on or near to a polyline, or the edge
            /// of a polygon, within a specified tolerance. Returns &lt;code&gt;true&lt;/code&gt; when
            /// the difference between the latitude and longitude of the supplied point,
            /// and the closest point on the edge, is less than the tolerance. The
            /// tolerance defaults to 10&lt;sup&gt;-9&lt;/sup&gt; degrees.
            abstract isLocationOnEdge: point: U2<Google.Maps.LatLng, Google.Maps.LatLngLiteral> * poly: U2<Google.Maps.Polygon, Google.Maps.Polyline> * ?tolerance: float -> bool

    module Spherical =

        type [<AllowNullLiteral>] IExports =
            /// Returns the unsigned area of a closed path, in the range [0, 2×pi×radius²].
            /// The computed area uses the same units as the radius. The
            /// &lt;code&gt;radiusOfSphere&lt;/code&gt; defaults to the Earth&amp;#39;s radius in meters,
            /// in which case the area is in square meters. Passing a &lt;code&gt;Circle&lt;/code&gt;
            /// requires the &lt;code&gt;radius&lt;/code&gt; to be set to a non-negative value.
            /// Additionally, the Circle must not cover more than 100% of the sphere. And
            /// when passing a &lt;code&gt;LatLngBounds&lt;/code&gt;, the southern LatLng cannot be
            /// more north than the northern LatLng.
            abstract computeArea: path: U6<Array<U2<Google.Maps.LatLng, Google.Maps.LatLngLiteral>>, Google.Maps.MVCArray<U2<Google.Maps.LatLng, Google.Maps.LatLngLiteral>>, Google.Maps.Circle, Google.Maps.CircleLiteral, Google.Maps.LatLngBounds, Google.Maps.LatLngBoundsLiteral> * ?radiusOfSphere: float -> float
            /// Returns the distance, in meters, between two LatLngs. You can optionally
            /// specify a custom radius. The radius defaults to the radius of the Earth.
            abstract computeDistanceBetween: from: U2<Google.Maps.LatLng, Google.Maps.LatLngLiteral> * ``to``: U2<Google.Maps.LatLng, Google.Maps.LatLngLiteral> * ?radius: float -> float
            /// Returns the heading from one LatLng to another LatLng. Headings are
            /// expressed in degrees clockwise from North within the range [-180,180).
            abstract computeHeading: from: U2<Google.Maps.LatLng, Google.Maps.LatLngLiteral> * ``to``: U2<Google.Maps.LatLng, Google.Maps.LatLngLiteral> -> float
            /// Returns the length of the given path.
            abstract computeLength: path: U2<Array<U2<Google.Maps.LatLng, Google.Maps.LatLngLiteral>>, Google.Maps.MVCArray<U2<Google.Maps.LatLng, Google.Maps.LatLngLiteral>>> * ?radius: float -> float
            /// Returns the LatLng resulting from moving a distance from an origin in the
            /// specified heading (expressed in degrees clockwise from north).
            abstract computeOffset: from: U2<Google.Maps.LatLng, Google.Maps.LatLngLiteral> * distance: float * heading: float * ?radius: float -> Google.Maps.LatLng
            /// Returns the location of origin when provided with a LatLng destination,
            /// meters travelled and original heading. Headings are expressed in degrees
            /// clockwise from North. This function returns &lt;code&gt;null&lt;/code&gt; when no
            /// solution is available.
            abstract computeOffsetOrigin: ``to``: U2<Google.Maps.LatLng, Google.Maps.LatLngLiteral> * distance: float * heading: float * ?radius: float -> Google.Maps.LatLng option
            /// <summary>
            /// Returns the signed area of a closed path, where counterclockwise is
            /// positive, in the range [-2×pi×radius², 2×pi×radius²]. The computed area
            /// uses the same units as the radius. The radius defaults to the Earth&amp;#39;s
            /// radius in meters, in which case the area is in square meters. &lt;br&gt;&lt;br&gt; The
            /// area is computed using the &lt;a
            /// href="<see href="https://wikipedia.org/wiki/Parallel_transport"&gt;parallel" /> transport&lt;/a&gt;
            /// method; the parallel transport around a closed path on the unit sphere
            /// twists by an angle that is equal to the area enclosed by the path. This is
            /// simpler and more accurate and robust than triangulation using Girard,
            /// l&amp;#39;Huilier, or Eriksson on each triangle. In particular, since it
            /// doesn&amp;#39;t triangulate, it suffers no instability except in the
            /// unavoidable case when an &lt;em&gt;edge&lt;/em&gt; (not a diagonal) of the polygon
            /// spans 180 degrees.
            /// </summary>
            abstract computeSignedArea: loop: U2<Array<U2<Google.Maps.LatLng, Google.Maps.LatLngLiteral>>, Google.Maps.MVCArray<U2<Google.Maps.LatLng, Google.Maps.LatLngLiteral>>> * ?radius: float -> float
            /// Returns the LatLng which lies the given fraction of the way between the
            /// origin LatLng and the destination LatLng.
            abstract interpolate: from: U2<Google.Maps.LatLng, Google.Maps.LatLngLiteral> * ``to``: U2<Google.Maps.LatLng, Google.Maps.LatLngLiteral> * fraction: float -> Google.Maps.LatLng

module JourneySharing =

    type [<AllowNullLiteral>] IExports =
        /// <summary>
        /// Delivery Fleet Location Provider.
        ///
        /// Access by calling `const {FleetEngineDeliveryFleetLocationProvider} = await
        /// google.maps.importLibrary("journeySharing")`. See
        /// <see href="https://developers.google.com/maps/documentation/javascript/libraries." />
        /// </summary>
        abstract FleetEngineDeliveryFleetLocationProvider: FleetEngineDeliveryFleetLocationProviderStatic
        /// <summary>
        /// Delivery Vehicle Location Provider.
        ///
        /// Access by calling `const {FleetEngineDeliveryVehicleLocationProvider} =
        /// await google.maps.importLibrary("journeySharing")`. See
        /// <see href="https://developers.google.com/maps/documentation/javascript/libraries." />
        /// </summary>
        abstract FleetEngineDeliveryVehicleLocationProvider: FleetEngineDeliveryVehicleLocationProviderStatic
        /// <summary>
        /// Available only in the v=beta channel: <see href="https://goo.gle/3oAthT3." />
        ///
        /// Fleet Location Provider.
        ///
        /// Access by calling `const {FleetEngineFleetLocationProvider} = await
        /// google.maps.importLibrary("journeySharing")`. See
        /// <see href="https://developers.google.com/maps/documentation/javascript/libraries." />
        /// </summary>
        abstract FleetEngineFleetLocationProvider: FleetEngineFleetLocationProviderStatic
        /// <summary>
        /// Shipment location provider.
        ///
        /// Access by calling `const {FleetEngineShipmentLocationProvider} = await
        /// google.maps.importLibrary("journeySharing")`. See
        /// <see href="https://developers.google.com/maps/documentation/javascript/libraries." />
        /// </summary>
        abstract FleetEngineShipmentLocationProvider: FleetEngineShipmentLocationProviderStatic
        /// <summary>
        /// Trip location provider.
        ///
        /// Access by calling `const {FleetEngineTripLocationProvider} = await
        /// google.maps.importLibrary("journeySharing")`. See
        /// <see href="https://developers.google.com/maps/documentation/javascript/libraries." />
        /// </summary>
        abstract FleetEngineTripLocationProvider: FleetEngineTripLocationProviderStatic
        /// <summary>
        /// Available only in the v=beta channel: <see href="https://goo.gle/3oAthT3." />
        ///
        /// Vehicle Location Provider.
        ///
        /// Access by calling `const {FleetEngineVehicleLocationProvider} = await
        /// google.maps.importLibrary("journeySharing")`. See
        /// <see href="https://developers.google.com/maps/documentation/javascript/libraries." />
        /// </summary>
        abstract FleetEngineVehicleLocationProvider: FleetEngineVehicleLocationProviderStatic
        /// <summary>
        /// The map view.
        ///
        /// Access by calling `const {JourneySharingMapView} = await
        /// google.maps.importLibrary("journeySharing")`. See
        /// <see href="https://developers.google.com/maps/documentation/javascript/libraries." />
        /// </summary>
        abstract JourneySharingMapView: JourneySharingMapViewStatic
        /// Parent class of all location providers.
        abstract LocationProvider: LocationProviderStatic
        /// Parent class of polling location providers.
        abstract PollingLocationProvider: PollingLocationProviderStatic

    /// The auth token returned by the token fetcher.
    type [<AllowNullLiteral>] AuthToken =
        /// The expiration time in seconds. A token expires in this amount of time
        /// after fetching.
        abstract expiresInSeconds: float with get, set
        /// The token.
        abstract token: string with get, set

    /// Contains additional information needed to mint JSON Web Tokens.
    type [<AllowNullLiteral>] AuthTokenContext =
        /// When provided, the minted token should have a private
        /// &lt;code&gt;DeliveryVehicleId&lt;/code&gt; claim for the provided deliveryVehicleId.
        abstract deliveryVehicleId: string option with get, set
        /// When provided, the minted token should have a private &lt;code&gt;TaskId&lt;/code&gt;
        /// claim for the provided taskId.
        abstract taskId: string option with get, set
        /// When provided, the minted token should have a private
        /// &lt;code&gt;TrackingId&lt;/code&gt; claim for the provided trackingId.
        abstract trackingId: string option with get, set
        /// When provided, the minted token should have a private &lt;code&gt;TripId&lt;/code&gt;
        /// claim for the provided tripId.
        abstract tripId: string option with get, set
        /// When provided, the minted token should have a private
        /// &lt;code&gt;VehicleId&lt;/code&gt; claim for the provided vehicleId.
        abstract vehicleId: string option with get, set

    type [<AllowNullLiteral>] AuthTokenFetcher =
        [<Emit("$0($1...)")>] abstract Invoke: a: Google.Maps.JourneySharing.AuthTokenFetcherOptions -> Promise<Google.Maps.JourneySharing.AuthToken>

    /// Options for the auth token fetcher.
    type [<AllowNullLiteral>] AuthTokenFetcherOptions =
        /// The auth token context. IDs specified in the context should be added to
        /// the request sent to the JSON Web Token minting endpoint.
        abstract context: Google.Maps.JourneySharing.AuthTokenContext with get, set
        /// The Fleet Engine service type.
        abstract serviceType: Google.Maps.JourneySharing.FleetEngineServiceType with get, set

    /// <summary>
    /// Automatic viewport mode.
    ///
    /// Access by calling `const {AutomaticViewportMode} = await
    /// google.maps.importLibrary("journeySharing")`. See
    /// <see href="https://developers.google.com/maps/documentation/javascript/libraries." />
    /// </summary>
    type [<StringEnum>] [<RequireQualifiedAccess>] AutomaticViewportMode =
        /// Automatically adjust the viewport to fit markers and any visible
        /// anticipated route polylines. This is the default.
        | [<CompiledName("FIT_ANTICIPATED_ROUTE")>] FIT_ANTICIPATED_ROUTE
        /// Do not automatically adjust the viewport.
        | [<CompiledName("NONE")>] NONE

    /// MarkerSetup default options.
    [<Obsolete("Marker setup is deprecated. Use the
<code>MarkerCustomizationFunction</code> methods for your location
provider instead.")>]
    type [<AllowNullLiteral>] DefaultMarkerSetupOptions =
        /// Default marker options.
        abstract defaultMarkerOptions: Google.Maps.MarkerOptions with get, set

    /// PolylineSetup default options.
    type [<AllowNullLiteral>] DefaultPolylineSetupOptions =
        /// Default polyline options.
        abstract defaultPolylineOptions: Google.Maps.PolylineOptions with get, set
        /// Default polyline visibility.
        abstract defaultVisible: bool with get, set

    /// The details for a delivery vehicle returned by Fleet Engine.
    type [<AllowNullLiteral>] DeliveryVehicle =
        /// Custom delivery vehicle attributes.
        abstract attributes: DeliveryVehicleAttributes with get, set
        /// The location where the current route segment ends.
        abstract currentRouteSegmentEndPoint: Google.Maps.LatLngLiteral option with get, set
        /// The last reported location of the delivery vehicle.
        abstract latestVehicleLocationUpdate: Google.Maps.JourneySharing.VehicleLocationUpdate option with get, set
        /// In the format
        /// &quot;providers/{provider_id}/deliveryVehicles/{delivery_vehicle_id}&quot;.
        /// The delivery_vehicle_id must be a unique identifier.
        abstract name: string with get, set
        /// The current navigation status of the vehicle.
        abstract navigationStatus: string with get, set
        /// The remaining driving distance in the current route segment, in meters.
        abstract remainingDistanceMeters: float with get, set
        /// The remaining driving duration in the current route segment, in
        /// milliseconds.
        abstract remainingDurationMillis: float option with get, set
        /// <summary>
        /// The journey segments assigned to this delivery vehicle, starting from the
        /// vehicle&amp;#39;s most recently reported location. This is only populated
        /// when the <see cref="google.maps.journeySharing.DeliveryVehicle" /> data object
        /// is provided through <see cref="*">google.maps.journeySharing.FleetEngineDeliveryVehicleLocationProvider</see>.
        /// </summary>
        abstract remainingVehicleJourneySegments: ResizeArray<Google.Maps.JourneySharing.VehicleJourneySegment> with get, set

    /// <summary>
    /// Parameters specific to marker customization functions that apply options to
    /// delivery vehicle markers. Used by <see cref="*">google.maps.journeySharing.FleetEngineDeliveryVehicleLocationProviderOptions.deliveryVehicleMarkerCustomization</see>
    /// and <see cref="*">google.maps.journeySharing.FleetEngineDeliveryFleetLocationProviderOptions.deliveryVehicleMarkerCustomization</see>.
    /// </summary>
    type [<AllowNullLiteral>] DeliveryVehicleMarkerCustomizationFunctionParams =
        inherit Google.Maps.JourneySharing.MarkerCustomizationFunctionParams
        /// The delivery vehicle represented by this marker.
        abstract vehicle: Google.Maps.JourneySharing.DeliveryVehicle with get, set

    /// DeliveryVehicleStop type
    type [<AllowNullLiteral>] DeliveryVehicleStop =
        /// The location of the stop.
        abstract plannedLocation: Google.Maps.LatLngLiteral option with get, set
        /// The state of the stop.
        abstract state: Google.Maps.JourneySharing.DeliveryVehicleStopState option with get, set
        /// The list of Tasks to be performed at this stop. &lt;ul&gt; &lt;li&gt;&lt;code&gt;id&lt;/code&gt;:
        /// the ID of the task. &lt;li&gt;&lt;code&gt;extraDurationMillis&lt;/code&gt;: the extra time
        /// it takes to perform the task, in milliseconds. &lt;/ul&gt;
        abstract tasks: ResizeArray<Google.Maps.JourneySharing.TaskInfo> with get, set

    /// <summary>
    /// The current state of a <see cref="*">google.maps.journeySharing.DeliveryVehicleStop</see>.
    ///
    /// Access by calling `const {DeliveryVehicleStopState} = await
    /// google.maps.importLibrary("journeySharing")`. See
    /// <see href="https://developers.google.com/maps/documentation/javascript/libraries." />
    /// </summary>
    type [<StringEnum>] [<RequireQualifiedAccess>] DeliveryVehicleStopState =
        /// Arrived at stop. Assumes that when the vehicle is routing to the next
        /// stop, that all previous stops have been completed.
        | [<CompiledName("ARRIVED")>] ARRIVED
        /// Assigned and actively routing.
        | [<CompiledName("ENROUTE")>] ENROUTE
        /// Created, but not actively routing.
        | [<CompiledName("NEW")>] NEW
        /// Unknown.
        | [<CompiledName("UNSPECIFIED")>] UNSPECIFIED

    /// <summary>
    /// Delivery Fleet Location Provider.
    ///
    /// Access by calling `const {FleetEngineDeliveryFleetLocationProvider} = await
    /// google.maps.importLibrary("journeySharing")`. See
    /// <see href="https://developers.google.com/maps/documentation/javascript/libraries." />
    /// </summary>
    type [<AllowNullLiteral>] FleetEngineDeliveryFleetLocationProvider =
        inherit Google.Maps.JourneySharing.PollingLocationProvider
        /// The filter applied when fetching the delivery vehicles.
        abstract deliveryVehicleFilter: string option with get, set
        /// The bounds within which to track delivery vehicles. If no bounds are set,
        /// no delivery vehicles will be tracked. To track all delivery vehicles
        /// regardless of location, set bounds equivalent to the entire earth.
        abstract locationRestriction: U2<Google.Maps.LatLngBounds, Google.Maps.LatLngBoundsLiteral> option with get, set
        /// This Field is read-only. Threshold for stale vehicle location. If the
        /// last updated location for the vehicle is older than this threshold, the
        /// vehicle will not be displayed.
        abstract staleLocationThresholdMillis: float with get, set

    /// <summary>
    /// Delivery Fleet Location Provider.
    ///
    /// Access by calling `const {FleetEngineDeliveryFleetLocationProvider} = await
    /// google.maps.importLibrary("journeySharing")`. See
    /// <see href="https://developers.google.com/maps/documentation/javascript/libraries." />
    /// </summary>
    type [<AllowNullLiteral>] FleetEngineDeliveryFleetLocationProviderStatic =
        /// <summary>
        /// Delivery Fleet Location Provider.
        ///
        /// Access by calling `const {FleetEngineDeliveryFleetLocationProvider} =
        /// await google.maps.importLibrary("journeySharing")`. See
        /// <see href="https://developers.google.com/maps/documentation/javascript/libraries." />
        /// </summary>
        /// <param name="options">Options to pass to the location provider.</param>
        [<EmitConstructor>] abstract Create: options: Google.Maps.JourneySharing
            .FleetEngineDeliveryFleetLocationProviderOptions -> FleetEngineDeliveryFleetLocationProvider

    /// Options for delivery fleet location provider.
    type [<AllowNullLiteral>] FleetEngineDeliveryFleetLocationProviderOptions =
        /// Provides JSON Web Tokens for authenticating the client to Fleet Engine.
        abstract authTokenFetcher: this: obj option * a: Google.Maps.JourneySharing.AuthTokenFetcherOptions -> Promise<Google.Maps.JourneySharing.AuthToken>
        /// <summary>
        /// A filter query to apply when fetching delivery vehicles. This filter is
        /// passed directly to Fleet Engine. &lt;br&gt;&lt;br&gt;See &lt;a
        /// href="<see href="https://goo.gle/3wT0Dlt"&gt;ListDeliveryVehiclesRequest.filter&lt;/a&gt;" /> for
        /// supported formats.&lt;br&gt;&lt;br&gt;Note that valid filters for attributes must
        /// have the &amp;quot;attributes&amp;quot; prefix. For example, &lt;code&gt;attributes.x =
        /// &amp;quot;y&amp;quot;&lt;/code&gt; or &lt;code&gt;attributes.&amp;quot;x y&amp;quot; =
        /// &amp;quot;z&amp;quot;&lt;/code&gt;.
        /// </summary>
        abstract deliveryVehicleFilter: string option with get, set
        /// <summary>
        /// Customization applied to a delivery vehicle marker. &lt;br&gt;&lt;br&gt;Use this
        /// field to specify custom styling (such as marker icon) and interactivity
        /// (such as click handling).&lt;ul&gt;&lt;li&gt;If a <see cref="google.maps.MarkerOptions" />
        /// object is specified, the changes specified in it are applied to the
        /// marker after the marker has been created, overwriting its default options
        /// if they exist.&lt;/li&gt;&lt;li&gt; If a function is specified, it is invoked once
        /// when the marker is created, before it is added to the map view. (On this
        /// invocation, the &lt;code&gt;isNew&lt;/code&gt; parameter in the function parameters
        /// object is set to &lt;code&gt;true&lt;/code&gt;.) Additionally, this function is
        /// invoked when the location provider receives data from Fleet Engine,
        /// regardless of whether the data corresponding to this marker have
        /// changed.&lt;br&gt;&lt;br&gt;See <see cref="*">google.maps.journeySharing.DeliveryVehicleMarkerCustomizationFunctionParams</see>
        /// for a list of supplied parameters and their uses.&lt;/li&gt;&lt;/ul&gt;
        /// </summary>
        abstract deliveryVehicleMarkerCustomization: (Google.Maps.JourneySharing
        .DeliveryVehicleMarkerCustomizationFunctionParams -> unit) option with get, set
        /// <summary>
        /// The latitude/longitude bounds within which to track vehicles immediately
        /// after the location provider is instantiated. If not set, the location
        /// provider does not start tracking any vehicles; use <see cref="*">google.maps.journeySharing.FleetEngineDeliveryFleetLocationProvider.locationRestriction</see>
        /// to set the bounds and begin tracking. To track all delivery vehicles
        /// regardless of location, set bounds equivalent to the entire earth.
        /// </summary>
        abstract locationRestriction: U2<Google.Maps.LatLngBounds, Google.Maps.LatLngBoundsLiteral> option with get, set
        /// The consumer&#39;s project ID from Google Cloud Console.
        abstract projectId: string with get, set
        /// Threshold for stale vehicle location. If the last updated location for
        /// the vehicle is older this threshold, the vehicle will not be displayed.
        /// Defaults to 24 hours in milliseconds. If the threshold is less than zero,
        /// or <i>Infinity</i>, the threshold will be ignored and the vehicle
        /// location will not be considered stale.
        abstract staleLocationThresholdMillis: float option with get, set

    /// <summary>
    /// The event object passed to the event handler when the <see cref="*">google.maps.journeySharing.FleetEngineDeliveryFleetLocationProvider.update</see>
    /// event is triggered.
    /// </summary>
    type [<AllowNullLiteral>] FleetEngineDeliveryFleetLocationProviderUpdateEvent =
        /// The list of delivery vehicles returned by the query. Unmodifiable.
        abstract deliveryVehicles: ResizeArray<Google.Maps.JourneySharing.DeliveryVehicle> option with get, set

    /// <summary>
    /// Delivery Vehicle Location Provider.
    ///
    /// Access by calling `const {FleetEngineDeliveryVehicleLocationProvider} =
    /// await google.maps.importLibrary("journeySharing")`. See
    /// <see href="https://developers.google.com/maps/documentation/javascript/libraries." />
    /// </summary>
    type [<AllowNullLiteral>] FleetEngineDeliveryVehicleLocationProvider =
        inherit Google.Maps.JourneySharing.PollingLocationProvider
        /// ID for the vehicle that this location provider observes. Set this field
        /// to track a vehicle.
        abstract deliveryVehicleId: string with get, set
        /// Optionally allow users to display the task&#39;s outcome location.
        abstract shouldShowOutcomeLocations: bool option with get, set
        /// Optionally allow users to display fetched tasks.
        abstract shouldShowTasks: bool option with get, set
        /// This Field is read-only. Threshold for stale vehicle location. If the
        /// last updated location for the vehicle is older than this threshold, the
        /// vehicle will not be displayed.
        abstract staleLocationThresholdMillis: float with get, set
        /// Returns the filter options to apply when fetching tasks.
        abstract taskFilterOptions: Google.Maps.JourneySharing.FleetEngineTaskFilterOptions with get, set

    /// <summary>
    /// Delivery Vehicle Location Provider.
    ///
    /// Access by calling `const {FleetEngineDeliveryVehicleLocationProvider} =
    /// await google.maps.importLibrary("journeySharing")`. See
    /// <see href="https://developers.google.com/maps/documentation/javascript/libraries." />
    /// </summary>
    type [<AllowNullLiteral>] FleetEngineDeliveryVehicleLocationProviderStatic =
        /// <summary>
        /// Delivery Vehicle Location Provider.
        ///
        /// Access by calling `const {FleetEngineDeliveryVehicleLocationProvider} =
        /// await google.maps.importLibrary("journeySharing")`. See
        /// <see href="https://developers.google.com/maps/documentation/javascript/libraries." />
        /// </summary>
        /// <param name="options">Options to pass to the location provider.</param>
        [<EmitConstructor>] abstract Create: options: Google.Maps.JourneySharing
            .FleetEngineDeliveryVehicleLocationProviderOptions -> FleetEngineDeliveryVehicleLocationProvider

    /// Options for delivery vehicle location provider.
    type [<AllowNullLiteral>] FleetEngineDeliveryVehicleLocationProviderOptions =
        /// Provides JSON Web Tokens for authenticating the client to Fleet Engine.
        abstract authTokenFetcher: this: obj option * a: Google.Maps.JourneySharing.AuthTokenFetcherOptions -> Promise<Google.Maps.JourneySharing.AuthToken>
        /// <summary>
        /// The delivery vehicle ID to track immediately after the location provider
        /// is instantiated. If not specified, the location provider does not start
        /// tracking any vehicle; use <see cref="*">google.maps.journeySharing.FleetEngineDeliveryVehicleLocationProvider.deliveryVehicleId</see>
        /// to set the ID and begin tracking.
        /// </summary>
        abstract deliveryVehicleId: string option with get, set
        /// <summary>
        /// Customization applied to the delivery vehicle marker. &lt;br&gt;&lt;br&gt;Use this
        /// field to specify custom styling (such as marker icon) and interactivity
        /// (such as click handling).&lt;ul&gt;&lt;li&gt;If a <see cref="google.maps.MarkerOptions" />
        /// object is specified, the changes specified in it are applied to the
        /// marker after the marker has been created, overwriting its default options
        /// if they exist.&lt;/li&gt;&lt;li&gt;If a function is specified, it is invoked once
        /// when the marker is created, before it is added to the map view. (On this
        /// invocation, the &lt;code&gt;isNew&lt;/code&gt; parameter in the function parameters
        /// object is set to &lt;code&gt;true&lt;/code&gt;.) Additionally, this function is
        /// invoked when the location provider receives data from Fleet Engine,
        /// regardless of whether the data corresponding to this marker have
        /// changed.&lt;br&gt;&lt;br&gt;See <see cref="*">google.maps.journeySharing.DeliveryVehicleMarkerCustomizationFunctionParams</see>
        /// for a list of supplied parameters and their uses.&lt;/li&gt;&lt;/ul&gt;
        /// </summary>
        abstract deliveryVehicleMarkerCustomization: U2<(Google.Maps.JourneySharing
        .DeliveryVehicleMarkerCustomizationFunctionParams -> unit), Google.Maps.MarkerOptions> option with get, set
        /// <summary>
        /// Customization applied to a planned stop marker. &lt;br&gt;&lt;br&gt;Use this field to
        /// specify custom styling (such as marker icon) and interactivity (such as
        /// click handling).&lt;ul&gt;&lt;li&gt;If a <see cref="google.maps.MarkerOptions" /> object is
        /// specified, the changes specified in it are applied to the marker after
        /// the marker has been created, overwriting its default options if they
        /// exist.&lt;/li&gt;&lt;li&gt;If a function is specified, it is invoked once when the
        /// marker is created, before it is added to the map view. (On this
        /// invocation, the &lt;code&gt;isNew&lt;/code&gt; parameter in the function parameters
        /// object is set to &lt;code&gt;true&lt;/code&gt;.) Additionally, this function is
        /// invoked when the location provider receives data from Fleet Engine,
        /// regardless of whether the data corresponding to this marker have
        /// changed.&lt;br&gt;&lt;br&gt;See <see cref="*">google.maps.journeySharing.PlannedStopMarkerCustomizationFunctionParams</see>
        /// for a list of supplied parameters and their uses.&lt;/li&gt;&lt;/ul&gt;
        /// </summary>
        abstract plannedStopMarkerCustomization: U2<(Google.Maps.JourneySharing
        .PlannedStopMarkerCustomizationFunctionParams -> unit), Google.Maps.MarkerOptions> option with get, set
        /// Minimum time between fetching location updates in milliseconds. If it
        /// takes longer than &lt;code&gt;pollingIntervalMillis&lt;/code&gt; to fetch a location
        /// update, the next location update is not started until the current one
        /// finishes. &lt;br&gt;&lt;br&gt;Setting this value to 0 disables recurring location
        /// updates. A new location update is fetched if any of the parameters
        /// observed by the location provider changes. &lt;br&gt;&lt;br&gt;The default polling
        /// interval is 5000 milliseconds, the minimum interval. If you set the
        /// polling interval to a lower non-zero value, 5000 is used.
        abstract pollingIntervalMillis: float option with get, set
        /// The consumer&#39;s project ID from Google Cloud Console.
        abstract projectId: string with get, set
        /// Boolean to show or hide outcome locations for the fetched tasks.
        abstract shouldShowOutcomeLocations: bool option with get, set
        /// Boolean to show or hide tasks. Setting this to false will prevent the
        /// ListTasks endpoint from being called to fetch the tasks. Only the
        /// upcoming vehicle stops will be displayed.
        abstract shouldShowTasks: bool option with get, set
        /// Threshold for stale vehicle location. If the last updated location for
        /// the vehicle is older this threshold, the vehicle will not be displayed.
        /// Defaults to 24 hours in milliseconds. If the threshold is less than 0, or
        /// <i>Infinity</i>, the threshold will be ignored and the vehicle location
        /// will not be considered stale.
        abstract staleLocationThresholdMillis: float option with get, set
        /// Filter options to apply when fetching tasks. The options can include
        /// specific vehicle, time, and task status.
        abstract taskFilterOptions: Google.Maps.JourneySharing.FleetEngineTaskFilterOptions option with get, set
        /// <summary>
        /// Customization applied to a task marker. A task marker is rendered at the
        /// planned location of each task assigned to the delivery vehicle.
        /// &lt;br&gt;&lt;br&gt;Use this field to specify custom styling (such as marker icon)
        /// and interactivity (such as click handling).&lt;ul&gt;&lt;li&gt;If a <see cref="*">google.maps.MarkerOptions</see> object is specified, the changes specified in
        /// it are applied to the marker after the marker has been created,
        /// overwriting its default options if they exist.&lt;/li&gt;&lt;li&gt;If a function is
        /// specified, it is invoked once when the marker is created, before it is
        /// added to the map view. (On this invocation, the &lt;code&gt;isNew&lt;/code&gt;
        /// parameter in the function parameters object is set to &lt;code&gt;true&lt;/code&gt;.)
        /// Additionally, this function is invoked when the location provider
        /// receives data from Fleet Engine, regardless of whether the data
        /// corresponding to this marker have changed.&lt;br&gt;&lt;br&gt;See <see cref="*">google.maps.journeySharing.TaskMarkerCustomizationFunctionParams</see> for a
        /// list of supplied parameters and their uses.&lt;/li&gt;&lt;/ul&gt;
        /// </summary>
        abstract taskMarkerCustomization: U2<(Google.Maps.JourneySharing.TaskMarkerCustomizationFunctionParams -> unit), Google.Maps.MarkerOptions> option with get, set
        /// <summary>
        /// Customization applied to a task outcome marker. A task outcome marker is
        /// rendered at the actual outcome location of each task assigned to the
        /// delivery vehicle. &lt;br&gt;&lt;br&gt;Use this field to specify custom styling (such
        /// as marker icon) and interactivity (such as click handling).&lt;ul&gt;&lt;li&gt;If
        /// a <see cref="google.maps.MarkerOptions" /> object is specified, the changes
        /// specified in it are applied to the marker after the marker has been
        /// created, overwriting its default options if they exist.&lt;/li&gt;&lt;li&gt;If a
        /// function is specified, it is invoked once when the marker is created,
        /// before it is added to the map view. (On this invocation, the
        /// &lt;code&gt;isNew&lt;/code&gt; parameter in the function parameters object is set to
        /// &lt;code&gt;true&lt;/code&gt;.) Additionally, this function is invoked when the
        /// location provider receives data from Fleet Engine, regardless of whether
        /// the data corresponding to this marker have changed.&lt;br&gt;&lt;br&gt;See <see cref="*">google.maps.journeySharing.TaskMarkerCustomizationFunctionParams</see> for a
        /// list of supplied parameters and their uses.&lt;/li&gt;&lt;/ul&gt;
        /// </summary>
        abstract taskOutcomeMarkerCustomization: (Google.Maps.JourneySharing
        .TaskMarkerCustomizationFunctionParams -> unit) option with get, set

    /// <summary>
    /// The event object passed to the event handler when the <see cref="*">google.maps.journeySharing.FleetEngineDeliveryVehicleLocationProvider.update</see>
    /// event is triggered.
    /// </summary>
    type [<AllowNullLiteral>] FleetEngineDeliveryVehicleLocationProviderUpdateEvent =
        /// The journey segments that have been completed by this vehicle.
        /// Unmodifiable.
        abstract completedVehicleJourneySegments: ResizeArray<Google.Maps.JourneySharing.VehicleJourneySegment> option with get, set
        /// The delivery vehicle data structure returned by the update. Unmodifiable.
        abstract deliveryVehicle: Google.Maps.JourneySharing.DeliveryVehicle option with get, set
        /// The list of tasks served by this delivery vehicle. Unmodifiable.
        abstract tasks: ResizeArray<Google.Maps.JourneySharing.Task> option with get, set

    /// <summary>
    /// Available only in the v=beta channel: <see href="https://goo.gle/3oAthT3." />
    ///
    /// Fleet Location Provider.
    ///
    /// Access by calling `const {FleetEngineFleetLocationProvider} = await
    /// google.maps.importLibrary("journeySharing")`. See
    /// <see href="https://developers.google.com/maps/documentation/javascript/libraries." />
    /// </summary>
    type [<AllowNullLiteral>] FleetEngineFleetLocationProvider =
        inherit Google.Maps.JourneySharing.PollingLocationProvider
        /// The bounds within which to track vehicles. If no bounds are set, no
        /// vehicles will be tracked. To track all vehicles regardless of location,
        /// set bounds equivalent to the entire earth.
        abstract locationRestriction: U2<Google.Maps.LatLngBounds, Google.Maps.LatLngBoundsLiteral> option with get, set
        /// This Field is read-only. Threshold for stale vehicle location. If the
        /// last updated location for the vehicle is older than this threshold, the
        /// vehicle will not be displayed.
        abstract staleLocationThresholdMillis: float with get, set
        /// The filter applied when fetching the vehicles.
        abstract vehicleFilter: string option with get, set

    /// <summary>
    /// Available only in the v=beta channel: <see href="https://goo.gle/3oAthT3." />
    ///
    /// Fleet Location Provider.
    ///
    /// Access by calling `const {FleetEngineFleetLocationProvider} = await
    /// google.maps.importLibrary("journeySharing")`. See
    /// <see href="https://developers.google.com/maps/documentation/javascript/libraries." />
    /// </summary>
    type [<AllowNullLiteral>] FleetEngineFleetLocationProviderStatic =
        /// <summary>
        /// Available only in the v=beta channel: <see href="https://goo.gle/3oAthT3." />
        ///
        /// Fleet Location Provider.
        ///
        /// Access by calling `const {FleetEngineFleetLocationProvider} = await
        /// google.maps.importLibrary("journeySharing")`. See
        /// <see href="https://developers.google.com/maps/documentation/javascript/libraries." />
        /// </summary>
        /// <param name="options">Options to pass to the location provider.</param>
        [<EmitConstructor>] abstract Create: options: Google.Maps.JourneySharing
            .FleetEngineFleetLocationProviderOptions -> FleetEngineFleetLocationProvider

    /// <summary>
    /// Available only in the v=beta channel: <see href="https://goo.gle/3oAthT3." />
    ///
    /// Options for fleet location provider.
    /// </summary>
    type [<AllowNullLiteral>] FleetEngineFleetLocationProviderOptions =
        /// Provides JSON Web Tokens for authenticating the client to Fleet Engine.
        abstract authTokenFetcher: this: obj option * a: Google.Maps.JourneySharing.AuthTokenFetcherOptions -> Promise<Google.Maps.JourneySharing.AuthToken>
        /// <summary>
        /// The latitude/longitude bounds within which to track vehicles immediately
        /// after the location provider is instantiated. If not set, the location
        /// provider does not start tracking any vehicles; use <see cref="*">google.maps.journeySharing.FleetEngineFleetLocationProvider.locationRestriction</see>
        /// to set the bounds and begin tracking. To track all vehicles regardless of
        /// location, set bounds equivalent to the entire earth.
        /// </summary>
        abstract locationRestriction: U2<Google.Maps.LatLngBounds, Google.Maps.LatLngBoundsLiteral> option with get, set
        /// The consumer&#39;s project ID from Google Cloud Console.
        abstract projectId: string with get, set
        /// Threshold for stale vehicle location. If the last updated location for
        /// the vehicle is older than this threshold, the vehicle will not be
        /// displayed. Defaults to 24 hours in milliseconds. If the threshold is less
        /// than zero, or <i>Infinity</i>, the threshold will be ignored and the
        /// vehicle location will not be considered stale.
        abstract staleLocationThresholdMillis: float option with get, set
        /// <summary>
        /// A filter query to apply when fetching vehicles. This filter is passed
        /// directly to Fleet Engine. &lt;br&gt;&lt;br&gt;See &lt;a
        /// href="<see href="https://goo.gle/ListVehiclesRequest-filter"&gt;ListVehiclesRequest.filter&lt;/a&gt;" />
        /// for supported formats.&lt;br&gt;&lt;br&gt;Note that valid filters for attributes must
        /// have the &amp;quot;attributes&amp;quot; prefix. For example, &lt;code&gt;attributes.x =
        /// &amp;quot;y&amp;quot;&lt;/code&gt; or &lt;code&gt;attributes.&amp;quot;x y&amp;quot; =
        /// &amp;quot;z&amp;quot;&lt;/code&gt;.
        /// </summary>
        abstract vehicleFilter: string option with get, set
        /// <summary>
        /// Customization applied to a vehicle marker. &lt;br&gt;&lt;br&gt;Use this field to
        /// specify custom styling (such as marker icon) and interactivity (such as
        /// click handling).&lt;ul&gt;&lt;li&gt;If a <see cref="google.maps.MarkerOptions" /> object is
        /// specified, the changes specified in it are applied to the marker after
        /// the marker has been created, overwriting its default options if they
        /// exist.&lt;/li&gt;&lt;li&gt; If a function is specified, it is invoked once when the
        /// marker is created, before it is added to the map view. (On this
        /// invocation, the &lt;code&gt;isNew&lt;/code&gt; parameter in the function parameters
        /// object is set to &lt;code&gt;true&lt;/code&gt;.) Additionally, this function is
        /// invoked when the location provider receives data from Fleet Engine,
        /// regardless of whether the data corresponding to this marker have
        /// changed.&lt;br&gt;&lt;br&gt;See <see cref="*">google.maps.journeySharing.VehicleMarkerCustomizationFunctionParams</see> for
        /// a list of supplied parameters and their uses.&lt;/li&gt;&lt;/ul&gt;
        /// </summary>
        abstract vehicleMarkerCustomization: (Google.Maps.JourneySharing
        .VehicleMarkerCustomizationFunctionParams -> unit) option with get, set

    /// <summary>
    /// Available only in the v=beta channel: <see href="https://goo.gle/3oAthT3." />
    ///
    /// The event object passed to the event handler when the <see cref="*">google.maps.journeySharing.FleetEngineFleetLocationProvider.update</see> event
    /// is triggered.
    /// </summary>
    type [<AllowNullLiteral>] FleetEngineFleetLocationProviderUpdateEvent =
        /// The list of vehicles returned by the query. Unmodifiable.
        abstract vehicles: ResizeArray<Google.Maps.JourneySharing.Vehicle> option with get, set

    /// <summary>
    /// Types of Fleet Engine services.
    ///
    /// Access by calling `const {FleetEngineServiceType} = await
    /// google.maps.importLibrary("journeySharing")`. See
    /// <see href="https://developers.google.com/maps/documentation/javascript/libraries." />
    /// </summary>
    type [<StringEnum>] [<RequireQualifiedAccess>] FleetEngineServiceType =
        /// Fleet Engine service used to access delivery vehicles.
        | [<CompiledName("DELIVERY_VEHICLE_SERVICE")>] DELIVERY_VEHICLE_SERVICE
        /// Fleet Engine service used to access task information.
        | [<CompiledName("TASK_SERVICE")>] TASK_SERVICE
        /// Fleet Engine service used to access trip information.
        | [<CompiledName("TRIP_SERVICE")>] TRIP_SERVICE
        /// Unknown Fleet Engine service.
        | [<CompiledName("UNKNOWN_SERVICE")>] UNKNOWN_SERVICE

    /// <summary>
    /// Shipment location provider.
    ///
    /// Access by calling `const {FleetEngineShipmentLocationProvider} = await
    /// google.maps.importLibrary("journeySharing")`. See
    /// <see href="https://developers.google.com/maps/documentation/javascript/libraries." />
    /// </summary>
    type [<AllowNullLiteral>] FleetEngineShipmentLocationProvider =
        inherit Google.Maps.JourneySharing.PollingLocationProvider
        /// Explicitly refreshes the tracked location.
        abstract refresh: unit -> unit
        /// The tracking ID for the task that this location provider observes. Set
        /// this field to begin tracking.
        abstract trackingId: string with get, set

    /// <summary>
    /// Shipment location provider.
    ///
    /// Access by calling `const {FleetEngineShipmentLocationProvider} = await
    /// google.maps.importLibrary("journeySharing")`. See
    /// <see href="https://developers.google.com/maps/documentation/javascript/libraries." />
    /// </summary>
    type [<AllowNullLiteral>] FleetEngineShipmentLocationProviderStatic =
        /// <summary>
        /// Shipment location provider.
        ///
        /// Access by calling `const {FleetEngineShipmentLocationProvider} = await
        /// google.maps.importLibrary("journeySharing")`. See
        /// <see href="https://developers.google.com/maps/documentation/javascript/libraries." />
        /// </summary>
        /// <param name="options">Options for the location provider.</param>
        [<EmitConstructor>] abstract Create: options: Google.Maps.JourneySharing
            .FleetEngineShipmentLocationProviderOptions -> FleetEngineShipmentLocationProvider

    /// Options for shipment location provider.
    type [<AllowNullLiteral>] FleetEngineShipmentLocationProviderOptions =
        /// Provides JSON Web Tokens for authenticating the client to Fleet Engine.
        abstract authTokenFetcher: this: obj option * a: Google.Maps.JourneySharing.AuthTokenFetcherOptions -> Promise<Google.Maps.JourneySharing.AuthToken>
        /// <summary>
        /// Customization applied to the delivery vehicle marker. &lt;br&gt;&lt;br&gt;Use this
        /// field to specify custom styling (such as marker icon) and interactivity
        /// (such as click handling).&lt;ul&gt;&lt;li&gt; If a <see cref="google.maps.MarkerOptions" />
        /// object is specified, the changes specified in it are applied to the
        /// marker after the marker has been created, overwriting its default options
        /// if they exist.&lt;/li&gt;&lt;li&gt;If a function is specified, it is invoked once
        /// when the marker is created, before it is added to the map view. (On this
        /// invocation, the &lt;code&gt;isNew&lt;/code&gt; parameter in the function parameters
        /// object is set to &lt;code&gt;true&lt;/code&gt;.) Additionally, this function is
        /// invoked when the location provider receives data from Fleet Engine,
        /// regardless of whether the data corresponding to this marker have
        /// changed.&lt;br&gt;&lt;br&gt;See <see cref="*">google.maps.journeySharing.ShipmentMarkerCustomizationFunctionParams</see> for
        /// a list of supplied parameters and their uses.&lt;/li&gt;&lt;/ul&gt;
        /// </summary>
        abstract deliveryVehicleMarkerCustomization: U2<(Google.Maps.JourneySharing
        .ShipmentMarkerCustomizationFunctionParams -> unit), Google.Maps.MarkerOptions> option with get, set
        /// <summary>
        /// Customization applied to the destination marker. &lt;br&gt;&lt;br&gt;Use this field
        /// to specify custom styling (such as marker icon) and interactivity (such
        /// as click handling).&lt;ul&gt;&lt;li&gt; If a <see cref="google.maps.MarkerOptions" /> object
        /// is specified, the changes specified in it are applied to the marker after
        /// the marker has been created, overwriting its default options if they
        /// exist.&lt;/li&gt;&lt;li&gt;If a function is specified, it is invoked once when the
        /// marker is created, before it is added to the map view. (On this
        /// invocation, the &lt;code&gt;isNew&lt;/code&gt; parameter in the function parameters
        /// object is set to &lt;code&gt;true&lt;/code&gt;.) Additionally, this function is
        /// invoked when the location provider receives data from Fleet Engine,
        /// regardless of whether the data corresponding to this marker have
        /// changed.&lt;br&gt;&lt;br&gt;See <see cref="*">google.maps.journeySharing.ShipmentMarkerCustomizationFunctionParams</see> for
        /// a list of supplied parameters and their uses.&lt;/li&gt;&lt;/ul&gt;
        /// </summary>
        abstract destinationMarkerCustomization: U2<(Google.Maps.JourneySharing
        .ShipmentMarkerCustomizationFunctionParams -> unit), Google.Maps.MarkerOptions> option with get, set
        /// Minimum time between fetching location updates in milliseconds. If it
        /// takes longer than &lt;code&gt;pollingIntervalMillis&lt;/code&gt; to fetch a location
        /// update, the next location update is not started until the current one
        /// finishes. &lt;br&gt;&lt;br&gt;Setting this value to 0, Infinity, or a negative value
        /// disables automatic location updates. A new location update is fetched
        /// once if the tracking ID parameter (for example, the shipment tracking ID
        /// of the shipment location provider), or a filtering option (for example,
        /// viewport bounds or attribute filters for fleet location providers)
        /// changes. &lt;br&gt;&lt;br&gt;The default, and minimum, polling interval is 5000
        /// milliseconds. If you set the polling interval to a lower positive value,
        /// 5000 is stored and used.
        abstract pollingIntervalMillis: float option with get, set
        /// The consumer&#39;s project ID from Google Cloud Console.
        abstract projectId: string with get, set
        /// <summary>
        /// The tracking ID of the task to track immediately after the location
        /// provider is instantiated. If not specified, the location provider does
        /// not start tracking any task; use <see cref="*">google.maps.journeySharing.FleetEngineShipmentLocationProvider.trackingId</see>
        /// to set the tracking ID and begin tracking.
        /// </summary>
        abstract trackingId: string option with get, set

    /// <summary>
    /// The event object passed to the event handler when the <see cref="*">google.maps.journeySharing.FleetEngineShipmentLocationProvider.update</see>
    /// event is triggered.
    /// </summary>
    type [<AllowNullLiteral>] FleetEngineShipmentLocationProviderUpdateEvent =
        /// The task tracking info structure returned by the update. Unmodifiable.
        abstract taskTrackingInfo: Google.Maps.JourneySharing.TaskTrackingInfo option with get, set

    /// Filtering options for tasks in the Delivery Vehicle Location Provider.
    type [<AllowNullLiteral>] FleetEngineTaskFilterOptions =
        /// Exclusive lower bound for the completion time of the task. Used to filter
        /// for tasks that were completed after the specified time.
        abstract completionTimeFrom: DateTime option with get, set
        /// Exclusive upper bound for the completion time of the task. Used to filter
        /// for tasks that were completed before the specified time.
        abstract completionTimeTo: DateTime option with get, set
        /// The state of the task. Valid values are OPEN or CLOSED.
        abstract state: string option with get, set

    /// <summary>
    /// Trip location provider.
    ///
    /// Access by calling `const {FleetEngineTripLocationProvider} = await
    /// google.maps.importLibrary("journeySharing")`. See
    /// <see href="https://developers.google.com/maps/documentation/javascript/libraries." />
    /// </summary>
    type [<AllowNullLiteral>] FleetEngineTripLocationProvider =
        inherit Google.Maps.JourneySharing.PollingLocationProvider
        /// Explicitly refreshes the tracked location.
        abstract refresh: unit -> unit
        /// The ID for the trip that this location provider observes. Set this field
        /// to begin tracking.
        abstract tripId: string with get, set

    /// <summary>
    /// Trip location provider.
    ///
    /// Access by calling `const {FleetEngineTripLocationProvider} = await
    /// google.maps.importLibrary("journeySharing")`. See
    /// <see href="https://developers.google.com/maps/documentation/javascript/libraries." />
    /// </summary>
    type [<AllowNullLiteral>] FleetEngineTripLocationProviderStatic =
        /// <summary>
        /// Trip location provider.
        ///
        /// Access by calling `const {FleetEngineTripLocationProvider} = await
        /// google.maps.importLibrary("journeySharing")`. See
        /// <see href="https://developers.google.com/maps/documentation/javascript/libraries." />
        /// </summary>
        /// <param name="options">Options for the location provider.</param>
        [<EmitConstructor>] abstract Create: options: Google.Maps.JourneySharing
            .FleetEngineTripLocationProviderOptions -> FleetEngineTripLocationProvider

    /// Options for trip location provider.
    type [<AllowNullLiteral>] FleetEngineTripLocationProviderOptions =
        /// Provides JSON Web Tokens for authenticating the client to Fleet Engine.
        abstract authTokenFetcher: this: obj option * a: Google.Maps.JourneySharing.AuthTokenFetcherOptions -> Promise<Google.Maps.JourneySharing.AuthToken>
        /// <summary>
        /// Customization applied to the destination marker. &lt;br&gt;&lt;br&gt;Use this field
        /// to specify custom styling (such as marker icon) and interactivity (such
        /// as click handling).&lt;ul&gt;&lt;li&gt;If a <see cref="google.maps.MarkerOptions" /> object
        /// is specified, the changes specified in it are applied to the marker after
        /// the marker has been created, overwriting its default options if they
        /// exist.&lt;/li&gt;&lt;li&gt;If a function is specified, it is invoked once when the
        /// marker is created, before it is added to the map view. (On this
        /// invocation, the &lt;code&gt;isNew&lt;/code&gt; parameter in the function parameters
        /// object is set to &lt;code&gt;true&lt;/code&gt;.) Additionally, this function is
        /// invoked when the location provider receives data from Fleet Engine,
        /// regardless of whether the data corresponding to this marker have
        /// changed.&lt;br&gt;&lt;br&gt;See <see cref="*">google.maps.journeySharing.TripMarkerCustomizationFunctionParams</see> for a
        /// list of supplied parameters and their uses.&lt;/li&gt;&lt;/ul&gt;
        /// </summary>
        abstract destinationMarkerCustomization: U2<(Google.Maps.JourneySharing.TripMarkerCustomizationFunctionParams -> unit), Google.Maps.MarkerOptions> option with get, set
        /// <summary>
        /// Customization applied to the origin marker. &lt;br&gt;&lt;br&gt;Use this field to
        /// specify custom styling (such as marker icon) and interactivity (such as
        /// click handling).&lt;ul&gt;&lt;li&gt;If a <see cref="google.maps.MarkerOptions" /> object is
        /// specified, the changes specified in it are applied to the marker after
        /// the marker has been created, overwriting its default options if they
        /// exist.&lt;/li&gt;&lt;li&gt;If a function is specified, it is invoked once when the
        /// marker is created, before it is added to the map view. (On this
        /// invocation, the &lt;code&gt;isNew&lt;/code&gt; parameter in the function parameters
        /// object is set to &lt;code&gt;true&lt;/code&gt;.) Additionally, this function is
        /// invoked when the location provider receives data from Fleet Engine,
        /// regardless of whether the data corresponding to this marker have
        /// changed.&lt;br&gt;&lt;br&gt;See <see cref="*">google.maps.journeySharing.TripMarkerCustomizationFunctionParams</see> for a
        /// list of supplied parameters and their uses.&lt;/li&gt;&lt;/ul&gt;
        /// </summary>
        abstract originMarkerCustomization: U2<(Google.Maps.JourneySharing.TripMarkerCustomizationFunctionParams -> unit), Google.Maps.MarkerOptions> option with get, set
        /// Minimum time between fetching location updates in milliseconds. If it
        /// takes longer than &lt;code&gt;pollingIntervalMillis&lt;/code&gt; to fetch a location
        /// update, the next location update is not started until the current one
        /// finishes. &lt;br&gt;&lt;br&gt;Setting this value to 0 disables recurring location
        /// updates. A new location update is fetched if any of the parameters
        /// observed by the location provider changes. &lt;br&gt;&lt;br&gt;The default polling
        /// interval is 5000 milliseconds, the minimum interval. If you set the
        /// polling interval to a lower non-zero value, 5000 is used.
        abstract pollingIntervalMillis: float option with get, set
        /// The consumer&#39;s project ID from Google Cloud Console.
        abstract projectId: string with get, set
        /// <summary>
        /// The trip ID to track immediately after the location provider is
        /// instantiated. If not specified, the location provider does not start
        /// tracking any trip; use <see cref="*">google.maps.journeySharing.FleetEngineTripLocationProvider.tripId</see> to set
        /// the ID and begin tracking.
        /// </summary>
        abstract tripId: string option with get, set
        /// <summary>
        /// Customization applied to the vehicle marker. &lt;br&gt;&lt;br&gt;Use this field to
        /// specify custom styling (such as marker icon) and interactivity (such as
        /// click handling).&lt;ul&gt;&lt;li&gt;If a <see cref="google.maps.MarkerOptions" /> object is
        /// specified, the changes specified in it are applied to the marker after
        /// the marker has been created, overwriting its default options if they
        /// exist.&lt;/li&gt;&lt;li&gt;If a function is specified, it is invoked once when the
        /// marker is created, before it is added to the map view. (On this
        /// invocation, the &lt;code&gt;isNew&lt;/code&gt; parameter in the function parameters
        /// object is set to &lt;code&gt;true&lt;/code&gt;.) Additionally, this function is
        /// invoked when the location provider receives data from Fleet Engine,
        /// regardless of whether the data corresponding to this marker have
        /// changed.&lt;br&gt;&lt;br&gt;See <see cref="*">google.maps.journeySharing.TripMarkerCustomizationFunctionParams</see> for a
        /// list of supplied parameters and their uses.&lt;/li&gt;&lt;/ul&gt;
        /// </summary>
        abstract vehicleMarkerCustomization: U2<(Google.Maps.JourneySharing.TripMarkerCustomizationFunctionParams -> unit), Google.Maps.MarkerOptions> option with get, set
        /// <summary>
        /// Customization applied to a waypoint marker. &lt;br&gt;&lt;br&gt;Use this field to
        /// specify custom styling (such as marker icon) and interactivity (such as
        /// click handling).&lt;ul&gt;&lt;li&gt;If a <see cref="google.maps.MarkerOptions" /> object is
        /// specified, the changes specified in it are applied to the marker after
        /// the marker has been created, overwriting its default options if they
        /// exist.&lt;/li&gt;&lt;li&gt;If a function is specified, it is invoked once when the
        /// marker is created, before it is added to the map view. (On this
        /// invocation, the &lt;code&gt;isNew&lt;/code&gt; parameter in the function parameters
        /// object is set to &lt;code&gt;true&lt;/code&gt;.) Additionally, this function is
        /// invoked when the location provider receives data from Fleet Engine,
        /// regardless of whether the data corresponding to this marker have
        /// changed.&lt;br&gt;&lt;br&gt;See <see cref="*">google.maps.journeySharing.TripWaypointMarkerCustomizationFunctionParams</see>
        /// for a list of supplied parameters and their uses.&lt;/li&gt;&lt;/ul&gt;
        /// </summary>
        abstract waypointMarkerCustomization: U2<(Google.Maps.JourneySharing
        .TripWaypointMarkerCustomizationFunctionParams -> unit), Google.Maps.MarkerOptions> option with get, set

    /// <summary>
    /// The event object passed to the event handler when the <see cref="*">google.maps.journeySharing.FleetEngineTripLocationProvider.update</see> event is
    /// triggered.
    /// </summary>
    type [<AllowNullLiteral>] FleetEngineTripLocationProviderUpdateEvent =
        /// The trip structure returned by the update. Unmodifiable.
        abstract trip: Google.Maps.JourneySharing.Trip option with get, set

    /// <summary>
    /// Available only in the v=beta channel: <see href="https://goo.gle/3oAthT3." />
    ///
    /// Vehicle Location Provider.
    ///
    /// Access by calling `const {FleetEngineVehicleLocationProvider} = await
    /// google.maps.importLibrary("journeySharing")`. See
    /// <see href="https://developers.google.com/maps/documentation/javascript/libraries." />
    /// </summary>
    type [<AllowNullLiteral>] FleetEngineVehicleLocationProvider =
        inherit Google.Maps.JourneySharing.PollingLocationProvider
        /// This Field is read-only. Threshold for stale vehicle location. If the
        /// last updated location for the vehicle is older than this threshold, the
        /// vehicle will not be displayed.
        abstract staleLocationThresholdMillis: float with get, set
        /// ID for the vehicle that this location provider observes. Set this field
        /// to track a vehicle.
        abstract vehicleId: string with get, set

    /// <summary>
    /// Available only in the v=beta channel: <see href="https://goo.gle/3oAthT3." />
    ///
    /// Vehicle Location Provider.
    ///
    /// Access by calling `const {FleetEngineVehicleLocationProvider} = await
    /// google.maps.importLibrary("journeySharing")`. See
    /// <see href="https://developers.google.com/maps/documentation/javascript/libraries." />
    /// </summary>
    type [<AllowNullLiteral>] FleetEngineVehicleLocationProviderStatic =
        /// <summary>
        /// Available only in the v=beta channel: <see href="https://goo.gle/3oAthT3." />
        ///
        /// Vehicle Location Provider.
        ///
        /// Access by calling `const {FleetEngineVehicleLocationProvider} = await
        /// google.maps.importLibrary("journeySharing")`. See
        /// <see href="https://developers.google.com/maps/documentation/javascript/libraries." />
        /// </summary>
        /// <param name="options">Options to pass to the location provider.</param>
        [<EmitConstructor>] abstract Create: options: Google.Maps.JourneySharing
            .FleetEngineVehicleLocationProviderOptions -> FleetEngineVehicleLocationProvider

    /// <summary>
    /// Available only in the v=beta channel: <see href="https://goo.gle/3oAthT3." />
    ///
    /// Options for vehicle location provider.
    /// </summary>
    type [<AllowNullLiteral>] FleetEngineVehicleLocationProviderOptions =
        /// Provides JSON Web Tokens for authenticating the client to Fleet Engine.
        abstract authTokenFetcher: this: obj option * a: Google.Maps.JourneySharing.AuthTokenFetcherOptions -> Promise<Google.Maps.JourneySharing.AuthToken>
        /// <summary>
        /// Customization applied to the vehicle trip destination marker. &lt;br&gt;&lt;br&gt;Use
        /// this field to specify custom styling (such as marker icon) and
        /// interactivity (such as click handling).&lt;ul&gt;&lt;li&gt;If a <see cref="*">google.maps.MarkerOptions</see> object is specified, the changes specified in
        /// it are applied to the marker after the marker has been created,
        /// overwriting its default options if they exist.&lt;/li&gt;&lt;li&gt;If a function is
        /// specified, it is invoked once when the marker is created, before it is
        /// added to the map view. (On this invocation, the &lt;code&gt;isNew&lt;/code&gt;
        /// parameter in the function parameters object is set to &lt;code&gt;true&lt;/code&gt;.)
        /// Additionally, this function is invoked when the location provider
        /// receives data from Fleet Engine, regardless of whether the data
        /// corresponding to this marker have changed.&lt;br&gt;&lt;br&gt;See <see cref="*">google.maps.journeySharing.VehicleWaypointMarkerCustomizationFunctionParams</see>
        /// for a list of supplied parameters and their uses.&lt;/li&gt;&lt;/ul&gt;
        /// </summary>
        abstract destinationMarkerCustomization: U2<(Google.Maps.JourneySharing
        .VehicleWaypointMarkerCustomizationFunctionParams -> unit), Google.Maps.MarkerOptions> option with get, set
        /// <summary>
        /// Customization applied to the vehicle trip intermediate destination
        /// markers. &lt;br&gt;&lt;br&gt;Use this field to specify custom styling (such as marker
        /// icon) and interactivity (such as click handling).&lt;ul&gt;&lt;li&gt;If a <see cref="*">google.maps.MarkerOptions</see> object is specified, the changes specified in
        /// it are applied to the marker after the marker has been created,
        /// overwriting its default options if they exist.&lt;/li&gt;&lt;li&gt;If a function is
        /// specified, it is invoked once when the marker is created, before it is
        /// added to the map view. (On this invocation, the &lt;code&gt;isNew&lt;/code&gt;
        /// parameter in the function parameters object is set to &lt;code&gt;true&lt;/code&gt;.)
        /// Additionally, this function is invoked when the location provider
        /// receives data from Fleet Engine, regardless of whether the data
        /// corresponding to this marker have changed.&lt;br&gt;&lt;br&gt;See <see cref="*">google.maps.journeySharing.VehicleWaypointMarkerCustomizationFunctionParams</see>
        /// for a list of supplied parameters and their uses.&lt;/li&gt;&lt;/ul&gt;
        /// </summary>
        abstract intermediateDestinationMarkerCustomization: U2<(Google.Maps.JourneySharing
        .VehicleWaypointMarkerCustomizationFunctionParams -> unit), Google.Maps.MarkerOptions> option with get, set
        /// <summary>
        /// Customization applied to the vehicle trip origin marker. &lt;br&gt;&lt;br&gt;Use this
        /// field to specify custom styling (such as marker icon) and interactivity
        /// (such as click handling).&lt;ul&gt;&lt;li&gt;If a <see cref="google.maps.MarkerOptions" />
        /// object is specified, the changes specified in it are applied to the
        /// marker after the marker has been created, overwriting its default options
        /// if they exist.&lt;/li&gt;&lt;li&gt;If a function is specified, it is invoked once
        /// when the marker is created, before it is added to the map view. (On this
        /// invocation, the &lt;code&gt;isNew&lt;/code&gt; parameter in the function parameters
        /// object is set to &lt;code&gt;true&lt;/code&gt;.) Additionally, this function is
        /// invoked when the location provider receives data from Fleet Engine,
        /// regardless of whether the data corresponding to this marker have
        /// changed.&lt;br&gt;&lt;br&gt;See <see cref="*">google.maps.journeySharing.VehicleWaypointMarkerCustomizationFunctionParams</see>
        /// for a list of supplied parameters and their uses.&lt;/li&gt;&lt;/ul&gt;
        /// </summary>
        abstract originMarkerCustomization: U2<(Google.Maps.JourneySharing
        .VehicleWaypointMarkerCustomizationFunctionParams -> unit), Google.Maps.MarkerOptions> option with get, set
        /// Minimum time between fetching location updates in milliseconds. If it
        /// takes longer than &lt;code&gt;pollingIntervalMillis&lt;/code&gt; to fetch a location
        /// update, the next location update is not started until the current one
        /// finishes. &lt;br&gt;&lt;br&gt;Setting this value to 0 disables recurring location
        /// updates. A new location update is fetched if any of the parameters
        /// observed by the location provider changes. &lt;br&gt;&lt;br&gt;The default polling
        /// interval is 5000 milliseconds, the minimum interval. If you set the
        /// polling interval to a lower non-zero value, 5000 is used.
        abstract pollingIntervalMillis: float option with get, set
        /// The consumer&#39;s project ID from Google Cloud Console.
        abstract projectId: string with get, set
        /// Threshold for stale vehicle location. If the last updated location for
        /// the vehicle is older this threshold, the vehicle will not be displayed.
        /// Defaults to 24 hours in milliseconds. If the threshold is less than 0, or
        /// <i>Infinity</i>, the threshold will be ignored and the vehicle location
        /// will not be considered stale.
        abstract staleLocationThresholdMillis: float option with get, set
        /// <summary>
        /// The vehicle ID to track immediately after the location provider is
        /// instantiated. If not specified, the location provider does not start
        /// tracking any vehicle; use <see cref="*">google.maps.journeySharing.FleetEngineVehicleLocationProvider.vehicleId</see>
        /// to set the ID and begin tracking.
        /// </summary>
        abstract vehicleId: string option with get, set
        /// <summary>
        /// Customization applied to the vehicle marker. &lt;br&gt;&lt;br&gt;Use this field to
        /// specify custom styling (such as marker icon) and interactivity (such as
        /// click handling).&lt;ul&gt;&lt;li&gt;If a <see cref="google.maps.MarkerOptions" /> object is
        /// specified, the changes specified in it are applied to the marker after
        /// the marker has been created, overwriting its default options if they
        /// exist.&lt;/li&gt;&lt;li&gt;If a function is specified, it is invoked once when the
        /// marker is created, before it is added to the map view. (On this
        /// invocation, the &lt;code&gt;isNew&lt;/code&gt; parameter in the function parameters
        /// object is set to &lt;code&gt;true&lt;/code&gt;.) Additionally, this function is
        /// invoked when the location provider receives data from Fleet Engine,
        /// regardless of whether the data corresponding to this marker have
        /// changed.&lt;br&gt;&lt;br&gt;See <see cref="*">google.maps.journeySharing.VehicleMarkerCustomizationFunctionParams</see> for
        /// a list of supplied parameters and their uses.&lt;/li&gt;&lt;/ul&gt;
        /// </summary>
        abstract vehicleMarkerCustomization: U2<(Google.Maps.JourneySharing
        .VehicleMarkerCustomizationFunctionParams -> unit), Google.Maps.MarkerOptions> option with get, set

    /// <summary>
    /// Available only in the v=beta channel: <see href="https://goo.gle/3oAthT3." />
    ///
    /// The event object passed to the event handler when the <see cref="*">google.maps.journeySharing.FleetEngineVehicleLocationProvider.update</see> event
    /// is triggered.
    /// </summary>
    type [<AllowNullLiteral>] FleetEngineVehicleLocationProviderUpdateEvent =
        /// The list of trips completed by this vehicle. Unmodifiable.
        abstract trips: ResizeArray<Google.Maps.JourneySharing.Trip> option with get, set
        /// The vehicle data structure returned by the update. Unmodifiable.
        abstract vehicle: Google.Maps.JourneySharing.Vehicle option with get, set

    /// <summary>
    /// The map view.
    ///
    /// Access by calling `const {JourneySharingMapView} = await
    /// google.maps.importLibrary("journeySharing")`. See
    /// <see href="https://developers.google.com/maps/documentation/javascript/libraries." />
    /// </summary>
    type [<AllowNullLiteral>] JourneySharingMapView =
        /// <summary>
        /// Adds a location provider to the map view. If the location provider is
        /// already added, no action is performed.
        /// </summary>
        /// <param name="locationProvider">the location provider to add.</param>
        abstract addLocationProvider: locationProvider: Google.Maps.JourneySharing.LocationProvider -> unit
        /// Configures options for an anticipated route polyline. Invoked whenever a
        /// new anticipated route polyline is rendered. <br><br>If specifying a
        /// function, the function can and should modify the input&#39;s
        /// defaultPolylineOptions field containing a google.maps.PolylineOptions
        /// object, and return it as polylineOptions in the output
        /// PolylineSetupOptions object. <br><br>Specifying a PolylineSetupOptions
        /// object has the same effect as specifying a function that returns that
        /// static object. <br><br>Do not reuse the same PolylineSetupOptions object
        /// in different PolylineSetup functions or static values, and do not reuse
        /// the same google.maps.PolylineOptions object for the polylineOptions key
        /// in different PolylineSetupOptions objects. If polylineOptions or visible
        /// is unset or null, it will be overwritten with the default. Any values set
        /// for polylineOptions.map or polylineOptions.path will be ignored.
        abstract anticipatedRoutePolylineSetup: U2<Google.Maps.JourneySharing.PolylineSetupOptions, (Google.Maps.JourneySharing.DefaultPolylineSetupOptions -> Google.Maps.JourneySharing.PolylineSetupOptions)> with get, set
        /// Returns the anticipated route polylines, if any.
        abstract anticipatedRoutePolylines: ResizeArray<Google.Maps.Polyline> with get, set
        /// This Field is read-only. Automatic viewport mode.
        abstract automaticViewportMode: Google.Maps.JourneySharing.AutomaticViewportMode with get, set
        /// Configures options for a destination location marker. Invoked whenever a
        /// new destination marker is rendered. <br><br>If specifying a function, the
        /// function can and should modify the input&#39;s defaultMarkerOptions field
        /// containing a google.maps.MarkerOptions object, and return it as
        /// markerOptions in the output MarkerSetupOptions object. <br><br>Specifying
        /// a MarkerSetupOptions object has the same effect as specifying a function
        /// that returns that static object. <br><br>Do not reuse the same
        /// MarkerSetupOptions object in different MarkerSetup functions or static
        /// values, and do not reuse the same google.maps.MarkerOptions object for
        /// the markerOptions key in different MarkerSetupOptions objects. If
        /// markerOptions is unset or null, it will be overwritten with the default.
        /// Any value set for markerOptions.map or markerOptions.position will be
        /// ignored.
        [<Obsolete("Marker setup is deprecated. Use the
<code>MarkerCustomizationFunction</code> methods for your location
provider instead. This field will be removed in the future.")>]
        abstract destinationMarkerSetup: U2<Google.Maps.JourneySharing.MarkerSetupOptions, (Google.Maps.JourneySharing.DefaultMarkerSetupOptions -> Google.Maps.JourneySharing.MarkerSetupOptions)> with get, set
        /// Returns the destination markers, if any.
        [<Obsolete("getting a list of markers via the <code>MapView</code> is
deprecated. Use the <code>MarkerCustomizationFunction</code>s for
your location provider to receive callbacks when a marker is added to
the map or updated.")>]
        abstract destinationMarkers: ResizeArray<Google.Maps.Marker> with get, set
        /// This Field is read-only. The DOM element backing the view.
        abstract element: Element with get, set
        /// Enables or disables the traffic layer.
        abstract enableTraffic: bool with get, set
        /// This Field is read-only. A source of tracked locations to be shown in the
        /// tracking map view.
        [<Obsolete("Use {@link  *     google.maps.journeySharing.JourneySharingMapView.locationProviders}
instead."       )>]
        abstract locationProvider: Google.Maps.JourneySharing.LocationProvider option with get, set
        /// <summary>
        /// This field is read-only. Sources of tracked locations to be shown in the
        /// tracking map view. To add or remove location providers, use the <see cref="*">google.maps.journeySharing.JourneySharingMapView.addLocationProvider</see>
        /// and <see cref="*">google.maps.journeySharing.JourneySharingMapView.removeLocationProvider</see>
        /// methods.
        /// </summary>
        abstract locationProviders: ResizeArray<Google.Maps.JourneySharing.LocationProvider> option with get, set
        /// This Field is read-only. The map object contained in the map view.
        abstract map: Google.Maps.Map with get, set
        /// This Field is read-only. The map options passed into the map via the map
        /// view.
        abstract mapOptions: Google.Maps.MapOptions with get, set
        /// Configures options for an origin location marker. Invoked whenever a new
        /// origin marker is rendered. <br><br>If specifying a function, the function
        /// can and should modify the input&#39;s defaultMarkerOptions field
        /// containing a google.maps.MarkerOptions object, and return it as
        /// markerOptions in the output MarkerSetupOptions object. <br><br>Specifying
        /// a MarkerSetupOptions object has the same effect as specifying a function
        /// that returns that static object. <br><br>Do not reuse the same
        /// MarkerSetupOptions object in different MarkerSetup functions or static
        /// values, and do not reuse the same google.maps.MarkerOptions object for
        /// the markerOptions key in different MarkerSetupOptions objects. If
        /// markerOptions is unset or null, it will be overwritten with the default.
        /// Any value set for markerOptions.map or markerOptions.position will be
        /// ignored.
        [<Obsolete("Marker setup is deprecated. Use the
<code>MarkerCustomizationFunction</code> methods for your location
provider instead. This field will be removed in the future.")>]
        abstract originMarkerSetup: U2<Google.Maps.JourneySharing.MarkerSetupOptions, (Google.Maps.JourneySharing.DefaultMarkerSetupOptions -> Google.Maps.JourneySharing.MarkerSetupOptions)> with get, set
        /// Returns the origin markers, if any.
        [<Obsolete("getting a list of markers via the <code>MapView</code> is
deprecated. Use the <code>MarkerCustomizationFunction</code>s for
your location provider to receive callbacks when a marker is added to
the map or updated.")>]
        abstract originMarkers: ResizeArray<Google.Maps.Marker> with get, set
        /// Configures options for a ping location marker. Invoked whenever a new
        /// ping marker is rendered. <br><br>If specifying a function, the function
        /// can and should modify the input&#39;s defaultMarkerOptions field
        /// containing a google.maps.MarkerOptions object, and return it as
        /// markerOptions in the output MarkerSetupOptions object. <br><br>Specifying
        /// a MarkerSetupOptions object has the same effect as specifying a function
        /// that returns that static object. <br><br>Do not reuse the same
        /// MarkerSetupOptions object in different MarkerSetup functions or static
        /// values, and do not reuse the same google.maps.MarkerOptions object for
        /// the markerOptions key in different MarkerSetupOptions objects. If
        /// markerOptions is unset or null, it will be overwritten with the default.
        /// Any value set for markerOptions.map or markerOptions.position will be
        /// ignored.
        [<Obsolete("Marker setup is deprecated. Use the
<code>MarkerCustomizationFunction</code> methods for your location
provider instead. This field will be removed in the future.")>]
        abstract pingMarkerSetup: U2<Google.Maps.JourneySharing.MarkerSetupOptions, (Google.Maps.JourneySharing.DefaultMarkerSetupOptions -> Google.Maps.JourneySharing.MarkerSetupOptions)> with get, set
        /// <summary>
        /// Removes a location provider from the map view. If the location provider
        /// is not already added to the map view, no action is performed.
        /// </summary>
        /// <param name="locationProvider">the location provider to remove.</param>
        abstract removeLocationProvider: locationProvider: Google.Maps.JourneySharing.LocationProvider -> unit
        /// Configures options for a successful task location marker. Invoked
        /// whenever a new successful task marker is rendered. <br><br>If specifying
        /// a function, the function can and should modify the input&#39;s
        /// defaultMarkerOptions field containing a google.maps.MarkerOptions object,
        /// and return it as markerOptions in the output MarkerSetupOptions object.
        /// <br><br>Specifying a MarkerSetupOptions object has the same effect as
        /// specifying a function that returns that static object. <br><br>Do not
        /// reuse the same MarkerSetupOptions object in different MarkerSetup
        /// functions or static values, and do not reuse the same
        /// google.maps.MarkerOptions object for the markerOptions key in different
        /// MarkerSetupOptions objects. If markerOptions is unset or null, it will be
        /// overwritten with the default. Any value set for markerOptions.map or
        /// markerOptions.position will be ignored.
        [<Obsolete("Marker setup is deprecated. Use the
<code>MarkerCustomizationFunction</code> methods for your location
provider instead. This field will be removed in the future.")>]
        abstract successfulTaskMarkerSetup: U2<Google.Maps.JourneySharing.MarkerSetupOptions, (Google.Maps.JourneySharing.DefaultMarkerSetupOptions -> Google.Maps.JourneySharing.MarkerSetupOptions)> with get, set
        /// Returns the successful task markers, if any.
        [<Obsolete("getting a list of markers via the <code>MapView</code> is
deprecated. Use the <code>MarkerCustomizationFunction</code>s for
your location provider to receive callbacks when a marker is added to
the map or updated.")>]
        abstract successfulTaskMarkers: ResizeArray<Google.Maps.Marker> with get, set
        /// Configures options for a taken route polyline. Invoked whenever a new
        /// taken route polyline is rendered. <br><br>If specifying a function, the
        /// function can and should modify the input&#39;s defaultPolylineOptions
        /// field containing a google.maps.PolylineOptions object, and return it as
        /// polylineOptions in the output PolylineSetupOptions object.
        /// <br><br>Specifying a PolylineSetupOptions object has the same effect as
        /// specifying a function that returns that static object. <br><br>Do not
        /// reuse the same PolylineSetupOptions object in different PolylineSetup
        /// functions or static values, and do not reuse the same
        /// google.maps.PolylineOptions object for the polylineOptions key in
        /// different PolylineSetupOptions objects. <br><br>Any values set for
        /// polylineOptions.map or polylineOptions.path will be ignored. Any unset or
        /// null value will be overwritten with the default.
        abstract takenRoutePolylineSetup: U2<Google.Maps.JourneySharing.PolylineSetupOptions, (Google.Maps.JourneySharing.DefaultPolylineSetupOptions -> Google.Maps.JourneySharing.PolylineSetupOptions)> with get, set
        /// Returns the taken route polylines, if any.
        abstract takenRoutePolylines: ResizeArray<Google.Maps.Polyline> with get, set
        /// Configures options for a task outcome location marker. Invoked whenever a
        /// new task outcome location marker is rendered. <br><br>If specifying a
        /// function, the function can and should modify the input&#39;s
        /// defaultMarkerOptions field containing a google.maps.MarkerOptions object,
        /// and return it as markerOptions in the output MarkerSetupOptions object.
        /// <br><br>Specifying a MarkerSetupOptions object has the same effect as
        /// specifying a function that returns that static object. <br><br>Do not
        /// reuse the same MarkerSetupOptions object in different MarkerSetup
        /// functions or static values, and do not reuse the same
        /// google.maps.MarkerOptions object for the markerOptions key in different
        /// MarkerSetupOptions objects. If markerOptions is unset or null, it will be
        /// overwritten with the default. Any value set for markerOptions.map or
        /// markerOptions.position will be ignored.
        [<Obsolete("Marker setup is deprecated. Use the
<code>MarkerCustomizationFunction</code> methods for your location
provider instead. This field will be removed in the future.")>]
        abstract taskOutcomeMarkerSetup: U2<Google.Maps.JourneySharing.MarkerSetupOptions, (Google.Maps.JourneySharing.DefaultMarkerSetupOptions -> Google.Maps.JourneySharing.MarkerSetupOptions)> with get, set
        /// Returns the task outcome markers, if any.
        [<Obsolete("getting a list of markers via the <code>MapView</code> is
deprecated. Use the <code>MarkerCustomizationFunction</code>s for
your location provider to receive callbacks when a marker is added to
the map or updated.")>]
        abstract taskOutcomeMarkers: ResizeArray<Google.Maps.Marker> with get, set
        /// Configures options for an unsuccessful task location marker. Invoked
        /// whenever a new unsuccessful task marker is rendered. <br><br>If
        /// specifying a function, the function can and should modify the input&#39;s
        /// defaultMarkerOptions field containing a google.maps.MarkerOptions object,
        /// and return it as markerOptions in the output MarkerSetupOptions object.
        /// <br><br>Specifying a MarkerSetupOptions object has the same effect as
        /// specifying a function that returns that static object. <br><br>Do not
        /// reuse the same MarkerSetupOptions object in different MarkerSetup
        /// functions or static values, and do not reuse the same
        /// google.maps.MarkerOptions object for the markerOptions key in different
        /// MarkerSetupOptions objects. If markerOptions is unset or null, it will be
        /// overwritten with the default. Any value set for markerOptions.map or
        /// markerOptions.position will be ignored.
        [<Obsolete("Marker setup is deprecated. Use the
<code>MarkerCustomizationFunction</code> methods for your location
provider instead. This field will be removed in the future.")>]
        abstract unsuccessfulTaskMarkerSetup: U2<Google.Maps.JourneySharing.MarkerSetupOptions, (Google.Maps.JourneySharing.DefaultMarkerSetupOptions -> Google.Maps.JourneySharing.MarkerSetupOptions)> with get, set
        /// Returns the unsuccessful task markers, if any.
        [<Obsolete("getting a list of markers via the <code>MapView</code> is
deprecated. Use the <code>MarkerCustomizationFunction</code>s for
your location provider to receive callbacks when a marker is added to
the map or updated.")>]
        abstract unsuccessfulTaskMarkers: ResizeArray<Google.Maps.Marker> with get, set
        /// Configures options for a vehicle location marker. Invoked whenever a new
        /// vehicle marker is rendered. <br><br>If specifying a function, the
        /// function can and should modify the input&#39;s defaultMarkerOptions field
        /// containing a google.maps.MarkerOptions object, and return it as
        /// markerOptions in the output MarkerSetupOptions object. <br><br>Specifying
        /// a MarkerSetupOptions object has the same effect as specifying a function
        /// that returns that static object. <br><br>Do not reuse the same
        /// MarkerSetupOptions object in different MarkerSetup functions or static
        /// values, and do not reuse the same google.maps.MarkerOptions object for
        /// the markerOptions key in different MarkerSetupOptions objects. If
        /// markerOptions is unset or null, it will be overwritten with the default.
        /// Any value set for markerOptions.map or markerOptions.position will be
        /// ignored.
        [<Obsolete("Marker setup is deprecated. Use the
<code>MarkerCustomizationFunction</code> methods for your location
provider instead. This field will be removed in the future.")>]
        abstract vehicleMarkerSetup: U2<Google.Maps.JourneySharing.MarkerSetupOptions, (Google.Maps.JourneySharing.DefaultMarkerSetupOptions -> Google.Maps.JourneySharing.MarkerSetupOptions)> with get, set
        /// Returns the vehicle markers, if any.
        [<Obsolete("getting a list of markers via the <code>MapView</code> is
deprecated. Use the <code>MarkerCustomizationFunction</code>s for
your location provider to receive callbacks when a marker is added to
the map or updated.")>]
        abstract vehicleMarkers: ResizeArray<Google.Maps.Marker> with get, set
        /// Configures options for a waypoint location marker. Invoked whenever a new
        /// waypoint marker is rendered. <br><br>If specifying a function, the
        /// function can and should modify the input&#39;s defaultMarkerOptions field
        /// containing a google.maps.MarkerOptions object, and return it as
        /// markerOptions in the output MarkerSetupOptions object. <br><br>Specifying
        /// a MarkerSetupOptions object has the same effect as specifying a function
        /// that returns that static object. <br><br>Do not reuse the same
        /// MarkerSetupOptions object in different MarkerSetup functions or static
        /// values, and do not reuse the same google.maps.MarkerOptions object for
        /// the markerOptions key in different MarkerSetupOptions objects. If
        /// markerOptions is unset or null, it will be overwritten with the default.
        /// Any value set for markerOptions.map or markerOptions.position will be
        /// ignored.
        [<Obsolete("Marker setup is deprecated. Use the
<code>MarkerCustomizationFunction</code> methods for your location
provider instead. This field will be removed in the future.")>]
        abstract waypointMarkerSetup: U2<Google.Maps.JourneySharing.MarkerSetupOptions, (Google.Maps.JourneySharing.DefaultMarkerSetupOptions -> Google.Maps.JourneySharing.MarkerSetupOptions)> with get, set
        /// Returns the waypoint markers, if any.
        [<Obsolete("getting a list of markers via the <code>MapView</code> is
deprecated. Use the <code>MarkerCustomizationFunction</code>s for
your location provider to receive callbacks when a marker is added to
the map or updated.")>]
        abstract waypointMarkers: ResizeArray<Google.Maps.Marker> with get, set

    /// <summary>
    /// The map view.
    ///
    /// Access by calling `const {JourneySharingMapView} = await
    /// google.maps.importLibrary("journeySharing")`. See
    /// <see href="https://developers.google.com/maps/documentation/javascript/libraries." />
    /// </summary>
    type [<AllowNullLiteral>] JourneySharingMapViewStatic =
        /// <summary>
        /// The map view.
        ///
        /// Access by calling `const {JourneySharingMapView} = await
        /// google.maps.importLibrary("journeySharing")`. See
        /// <see href="https://developers.google.com/maps/documentation/javascript/libraries." />
        /// </summary>
        /// <param name="options">Options for the map view.</param>
        [<EmitConstructor>] abstract Create: options: Google.Maps.JourneySharing.JourneySharingMapViewOptions -> JourneySharingMapView

    /// Options for the map view.
    type [<AllowNullLiteral>] JourneySharingMapViewOptions =
        /// Configures options for an anticipated route polyline. Invoked whenever a
        /// new anticipated route polyline is rendered. <br><br>If specifying a
        /// function, the function can and should modify the input&#39;s
        /// defaultPolylineOptions field containing a google.maps.PolylineOptions
        /// object, and return it as polylineOptions in the output
        /// PolylineSetupOptions object. <br><br>Specifying a PolylineSetupOptions
        /// object has the same effect as specifying a function that returns that
        /// static object. <br><br>Do not reuse the same PolylineSetupOptions object
        /// in different PolylineSetup functions or static values, and do not reuse
        /// the same google.maps.PolylineOptions object for the polylineOptions key
        /// in different PolylineSetupOptions objects. If polylineOptions or visible
        /// is unset or null, it will be overwritten with the default. Any values set
        /// for polylineOptions.map or polylineOptions.path will be ignored.
        abstract anticipatedRoutePolylineSetup: U2<Google.Maps.JourneySharing.PolylineSetupOptions, (Google.Maps.JourneySharing.DefaultPolylineSetupOptions -> Google.Maps.JourneySharing.PolylineSetupOptions)> option with get, set
        /// Automatic viewport mode. Default value is FIT_ANTICIPATED_ROUTE, which
        /// enables the map view to automatically adjust the viewport to fit vehicle
        /// markers, location markers, and any visible anticipated route polylines.
        /// Set this to NONE to turn off automatic fitting.
        abstract automaticViewportMode: Google.Maps.JourneySharing.AutomaticViewportMode option with get, set
        /// Configures options for a destination location marker. Invoked whenever a
        /// new destination marker is rendered. <br><br>If specifying a function, the
        /// function can and should modify the input&#39;s defaultMarkerOptions field
        /// containing a google.maps.MarkerOptions object, and return it as
        /// markerOptions in the output MarkerSetupOptions object. <br><br>Specifying
        /// a MarkerSetupOptions object has the same effect as specifying a function
        /// that returns that static object. <br><br>Do not reuse the same
        /// MarkerSetupOptions object in different MarkerSetup functions or static
        /// values, and do not reuse the same google.maps.MarkerOptions object for
        /// the markerOptions key in different MarkerSetupOptions objects. If
        /// markerOptions is unset or null, it will be overwritten with the default.
        /// Any value set for markerOptions.map or markerOptions.position will be
        /// ignored.
        [<Obsolete("Marker setup is deprecated. Use the
<code>MarkerCustomizationFunction</code> methods for your location
provider instead. This field will be removed in the future.")>]
        abstract destinationMarkerSetup: U2<Google.Maps.JourneySharing.MarkerSetupOptions, (Google.Maps.JourneySharing.DefaultMarkerSetupOptions -> Google.Maps.JourneySharing.MarkerSetupOptions)> option with get, set
        /// The DOM element backing the view. Required.
        abstract element: Element with get, set
        /// A source of tracked locations to be shown in the tracking map view.
        /// Optional.
        [<Obsolete("Use {@link  *     google.maps.journeySharing.JourneySharingMapViewOptions.locationProviders}
instead."       )>]
        abstract locationProvider: Google.Maps.JourneySharing.LocationProvider option with get, set
        /// Sources of tracked locations to be shown in the tracking map view.
        /// Optional.
        abstract locationProviders: ResizeArray<Google.Maps.JourneySharing.LocationProvider> option with get, set
        /// Map options passed into the google.maps.Map constructor.
        abstract mapOptions: Google.Maps.MapOptions option with get, set
        /// Configures options for an origin location marker. Invoked whenever a new
        /// origin marker is rendered. <br><br>If specifying a function, the function
        /// can and should modify the input&#39;s defaultMarkerOptions field
        /// containing a google.maps.MarkerOptions object, and return it as
        /// markerOptions in the output MarkerSetupOptions object. <br><br>Specifying
        /// a MarkerSetupOptions object has the same effect as specifying a function
        /// that returns that static object. <br><br>Do not reuse the same
        /// MarkerSetupOptions object in different MarkerSetup functions or static
        /// values, and do not reuse the same google.maps.MarkerOptions object for
        /// the markerOptions key in different MarkerSetupOptions objects. If
        /// markerOptions is unset or null, it will be overwritten with the default.
        /// Any value set for markerOptions.map or markerOptions.position will be
        /// ignored.
        [<Obsolete("Marker setup is deprecated. Use the
<code>MarkerCustomizationFunction</code> methods for your location
provider instead. This field will be removed in the future.")>]
        abstract originMarkerSetup: U2<Google.Maps.JourneySharing.MarkerSetupOptions, (Google.Maps.JourneySharing.DefaultMarkerSetupOptions -> Google.Maps.JourneySharing.MarkerSetupOptions)> option with get, set
        /// Configures options for a ping location marker. Invoked whenever a new
        /// ping marker is rendered. <br><br>If specifying a function, the function
        /// can and should modify the input&#39;s defaultMarkerOptions field
        /// containing a google.maps.MarkerOptions object, and return it as
        /// markerOptions in the output MarkerSetupOptions object. <br><br>Specifying
        /// a MarkerSetupOptions object has the same effect as specifying a function
        /// that returns that static object. <br><br>Do not reuse the same
        /// MarkerSetupOptions object in different MarkerSetup functions or static
        /// values, and do not reuse the same google.maps.MarkerOptions object for
        /// the markerOptions key in different MarkerSetupOptions objects. If
        /// markerOptions is unset or null, it will be overwritten with the default.
        /// Any value set for markerOptions.map or markerOptions.position will be
        /// ignored.
        [<Obsolete("Marker setup is deprecated. Use the
<code>MarkerCustomizationFunction</code> methods for your location
provider instead. This field will be removed in the future.")>]
        abstract pingMarkerSetup: U2<Google.Maps.JourneySharing.MarkerSetupOptions, (Google.Maps.JourneySharing.DefaultMarkerSetupOptions -> Google.Maps.JourneySharing.MarkerSetupOptions)> option with get, set
        /// Configures options for a successful task location marker. Invoked
        /// whenever a new successful task marker is rendered. <br><br>If specifying
        /// a function, the function can and should modify the input&#39;s
        /// defaultMarkerOptions field containing a google.maps.MarkerOptions object,
        /// and return it as markerOptions in the output MarkerSetupOptions object.
        /// <br><br>Specifying a MarkerSetupOptions object has the same effect as
        /// specifying a function that returns that static object. <br><br>Do not
        /// reuse the same MarkerSetupOptions object in different MarkerSetup
        /// functions or static values, and do not reuse the same
        /// google.maps.MarkerOptions object for the markerOptions key in different
        /// MarkerSetupOptions objects. If markerOptions is unset or null, it will be
        /// overwritten with the default. Any value set for markerOptions.map or
        /// markerOptions.position will be ignored.
        [<Obsolete("Marker setup is deprecated. Use the
<code>MarkerCustomizationFunction</code> methods for your location
provider instead. This field will be removed in the future.")>]
        abstract successfulTaskMarkerSetup: U2<Google.Maps.JourneySharing.MarkerSetupOptions, (Google.Maps.JourneySharing.DefaultMarkerSetupOptions -> Google.Maps.JourneySharing.MarkerSetupOptions)> option with get, set
        /// Configures options for a taken route polyline. Invoked whenever a new
        /// taken route polyline is rendered. <br><br>If specifying a function, the
        /// function can and should modify the input&#39;s defaultPolylineOptions
        /// field containing a google.maps.PolylineOptions object, and return it as
        /// polylineOptions in the output PolylineSetupOptions object.
        /// <br><br>Specifying a PolylineSetupOptions object has the same effect as
        /// specifying a function that returns that static object. <br><br>Do not
        /// reuse the same PolylineSetupOptions object in different PolylineSetup
        /// functions or static values, and do not reuse the same
        /// google.maps.PolylineOptions object for the polylineOptions key in
        /// different PolylineSetupOptions objects. <br><br>Any values set for
        /// polylineOptions.map or polylineOptions.path will be ignored. Any unset or
        /// null value will be overwritten with the default.
        abstract takenRoutePolylineSetup: U2<Google.Maps.JourneySharing.PolylineSetupOptions, (Google.Maps.JourneySharing.DefaultPolylineSetupOptions -> Google.Maps.JourneySharing.PolylineSetupOptions)> option with get, set
        /// Configures options for a task outcome location marker. Invoked whenever a
        /// new task outcome location marker is rendered. <br><br>If specifying a
        /// function, the function can and should modify the input&#39;s
        /// defaultMarkerOptions field containing a google.maps.MarkerOptions object,
        /// and return it as markerOptions in the output MarkerSetupOptions object.
        /// <br><br>Specifying a MarkerSetupOptions object has the same effect as
        /// specifying a function that returns that static object. <br><br>Do not
        /// reuse the same MarkerSetupOptions object in different MarkerSetup
        /// functions or static values, and do not reuse the same
        /// google.maps.MarkerOptions object for the markerOptions key in different
        /// MarkerSetupOptions objects. If markerOptions is unset or null, it will be
        /// overwritten with the default. Any value set for markerOptions.map or
        /// markerOptions.position will be ignored.
        [<Obsolete("Marker setup is deprecated. Use the
<code>MarkerCustomizationFunction</code> methods for your location
provider instead. This field will be removed in the future.")>]
        abstract taskOutcomeMarkerSetup: U2<Google.Maps.JourneySharing.MarkerSetupOptions, (Google.Maps.JourneySharing.DefaultMarkerSetupOptions -> Google.Maps.JourneySharing.MarkerSetupOptions)> option with get, set
        /// Configures options for an unsuccessful task location marker. Invoked
        /// whenever a new unsuccessful task marker is rendered. <br><br>If
        /// specifying a function, the function can and should modify the input&#39;s
        /// defaultMarkerOptions field containing a google.maps.MarkerOptions object,
        /// and return it as markerOptions in the output MarkerSetupOptions object.
        /// <br><br>Specifying a MarkerSetupOptions object has the same effect as
        /// specifying a function that returns that static object. <br><br>Do not
        /// reuse the same MarkerSetupOptions object in different MarkerSetup
        /// functions or static values, and do not reuse the same
        /// google.maps.MarkerOptions object for the markerOptions key in different
        /// MarkerSetupOptions objects. If markerOptions is unset or null, it will be
        /// overwritten with the default. Any value set for markerOptions.map or
        /// markerOptions.position will be ignored.
        [<Obsolete("Marker setup is deprecated. Use the
<code>MarkerCustomizationFunction</code> methods for your location
provider instead. This field will be removed in the future.")>]
        abstract unsuccessfulTaskMarkerSetup: U2<Google.Maps.JourneySharing.MarkerSetupOptions, (Google.Maps.JourneySharing.DefaultMarkerSetupOptions -> Google.Maps.JourneySharing.MarkerSetupOptions)> option with get, set
        /// Configures options for a vehicle location marker. Invoked whenever a new
        /// vehicle marker is rendered. <br><br>If specifying a function, the
        /// function can and should modify the input&#39;s defaultMarkerOptions field
        /// containing a google.maps.MarkerOptions object, and return it as
        /// markerOptions in the output MarkerSetupOptions object. <br><br>Specifying
        /// a MarkerSetupOptions object has the same effect as specifying a function
        /// that returns that static object. <br><br>Do not reuse the same
        /// MarkerSetupOptions object in different MarkerSetup functions or static
        /// values, and do not reuse the same google.maps.MarkerOptions object for
        /// the markerOptions key in different MarkerSetupOptions objects. If
        /// markerOptions is unset or null, it will be overwritten with the default.
        /// Any value set for markerOptions.map or markerOptions.position will be
        /// ignored.
        [<Obsolete("Marker setup is deprecated. Use the
<code>MarkerCustomizationFunction</code> methods for your location
provider instead. This field will be removed in the future.")>]
        abstract vehicleMarkerSetup: U2<Google.Maps.JourneySharing.MarkerSetupOptions, (Google.Maps.JourneySharing.DefaultMarkerSetupOptions -> Google.Maps.JourneySharing.MarkerSetupOptions)> option with get, set
        /// Configures options for a waypoint location marker. Invoked whenever a new
        /// waypoint marker is rendered. <br><br>If specifying a function, the
        /// function can and should modify the input&#39;s defaultMarkerOptions field
        /// containing a google.maps.MarkerOptions object, and return it as
        /// markerOptions in the output MarkerSetupOptions object. <br><br>Specifying
        /// a MarkerSetupOptions object has the same effect as specifying a function
        /// that returns that static object. <br><br>Do not reuse the same
        /// MarkerSetupOptions object in different MarkerSetup functions or static
        /// values, and do not reuse the same google.maps.MarkerOptions object for
        /// the markerOptions key in different MarkerSetupOptions objects. If
        /// markerOptions is unset or null, it will be overwritten with the default.
        /// Any value set for markerOptions.map or markerOptions.position will be
        /// ignored.
        [<Obsolete("Marker setup is deprecated. Use the
<code>MarkerCustomizationFunction</code> methods for your location
provider instead. This field will be removed in the future.")>]
        abstract waypointMarkerSetup: U2<Google.Maps.JourneySharing.MarkerSetupOptions, (Google.Maps.JourneySharing.DefaultMarkerSetupOptions -> Google.Maps.JourneySharing.MarkerSetupOptions)> option with get, set

    /// Parent class of all location providers.
    type [<AllowNullLiteral>] LocationProvider =
        /// <summary>
        /// Adds a <see cref="google.maps.MapsEventListener" /> for an event fired by this
        /// location provider. Returns an identifier for this listener that can be
        /// used with <see cref="google.maps.event.removeListener" />.
        /// </summary>
        /// <param name="eventName">The name of the event to listen for.</param>
        /// <param name="handler">The event handler.</param>
        abstract addListener: eventName: string * handler: Function -> Google.Maps.MapsEventListener

    /// Parent class of all location providers.
    type [<AllowNullLiteral>] LocationProviderStatic =
        [<EmitConstructor>] abstract Create: unit -> LocationProvider

    /// Parameters that are common to all marker customization functions. No object
    /// of this class is provided directly to any marker customization function; an
    /// object of one of its descendent classes is provided instead.
    type [<AllowNullLiteral>] MarkerCustomizationFunctionParams =
        /// The default options used to create this marker.
        abstract defaultOptions: Google.Maps.MarkerOptions with get, set
        /// If true, the marker was newly created, and the marker customization
        /// function is being called for the first time, before the marker has been
        /// added to the map view. False otherwise.
        abstract isNew: bool with get, set
        /// The marker. Any customizations should be made to this object directly.
        abstract marker: Google.Maps.Marker with get, set

    [<Obsolete("Marker setup is deprecated. Use the
<code>MarkerCustomizationFunction</code> methods for your location
provider instead.")>]
    type MarkerSetup =
        U2<Google.Maps.JourneySharing.MarkerSetupOptions, (Google.Maps.JourneySharing.DefaultMarkerSetupOptions -> Google.Maps.JourneySharing.MarkerSetupOptions)>

    /// MarkerSetup options.
    [<Obsolete("Marker setup is deprecated. Use the
<code>MarkerCustomizationFunction</code> methods for your location
provider instead.")>]
    type [<AllowNullLiteral>] MarkerSetupOptions =
        /// Marker options.
        abstract markerOptions: Google.Maps.MarkerOptions option with get, set

    /// <summary>
    /// Parameters specific to marker customization functions that apply options to
    /// markers representing planned stops. Used by <see cref="*">google.maps.journeySharing.FleetEngineDeliveryVehicleLocationProviderOptions.plannedStopMarkerCustomization</see>.
    /// </summary>
    type [<AllowNullLiteral>] PlannedStopMarkerCustomizationFunctionParams =
        inherit Google.Maps.JourneySharing.DeliveryVehicleMarkerCustomizationFunctionParams
        /// The 0-based index of this stop in the list of remaining stops.
        abstract stopIndex: float with get, set

    /// Parent class of polling location providers.
    type [<AllowNullLiteral>] PollingLocationProvider =
        inherit Google.Maps.JourneySharing.LocationProvider
        /// True if this location provider is polling. Read only.
        abstract isPolling: bool with get, set
        /// Minimum time between fetching location updates in milliseconds. If it
        /// takes longer than &lt;code&gt;pollingIntervalMillis&lt;/code&gt; to fetch a location
        /// update, the next location update is not started until the current one
        /// finishes. &lt;br&gt;&lt;br&gt;Setting this value to 0, Infinity, or a negative value
        /// disables automatic location updates. A new location update is fetched
        /// once if the tracking ID parameter (for example, the shipment tracking ID
        /// of the shipment location provider), or a filtering option (for example,
        /// viewport bounds or attribute filters for fleet location providers)
        /// changes. &lt;br&gt;&lt;br&gt;The default, and minimum, polling interval is 5000
        /// milliseconds. If you set the polling interval to a lower positive value,
        /// 5000 is stored and used.
        abstract pollingIntervalMillis: float with get, set

    /// Parent class of polling location providers.
    type [<AllowNullLiteral>] PollingLocationProviderStatic =
        [<EmitConstructor>] abstract Create: unit -> PollingLocationProvider

    /// <summary>
    /// The event object passed to the event handler when the <see cref="*">google.maps.journeySharing.PollingLocationProvider.ispollingchange</see> event
    /// is triggered.
    /// </summary>
    type [<AllowNullLiteral>] PollingLocationProviderIsPollingChangeEvent =
        /// The error that caused the polling state to change, if the state change
        /// was caused by an error. Undefined if the state change was due to normal
        /// operations.
        abstract error: Error option with get, set

    type PolylineSetup =
        U2<Google.Maps.JourneySharing.PolylineSetupOptions, (Google.Maps.JourneySharing.DefaultPolylineSetupOptions -> Google.Maps.JourneySharing.PolylineSetupOptions)>

    /// PolylineSetup options.
    type [<AllowNullLiteral>] PolylineSetupOptions =
        /// Polyline options.
        abstract polylineOptions: Google.Maps.PolylineOptions option with get, set
        /// Polyline visibility.
        abstract visible: bool option with get, set

    /// <summary>
    /// Parameters specific to marker customization functions that apply options to
    /// markers representing shipment delivery vehicle and destination locations.
    /// Used by <see cref="*">google.maps.journeySharing.FleetEngineShipmentLocationProviderOptions.deliveryVehicleMarkerCustomization</see>
    /// and <see cref="*">google.maps.journeySharing.FleetEngineShipmentLocationProviderOptions.destinationMarkerCustomization</see>.
    /// </summary>
    type [<AllowNullLiteral>] ShipmentMarkerCustomizationFunctionParams =
        inherit Google.Maps.JourneySharing.MarkerCustomizationFunctionParams
        /// Information for the task associated with this marker.
        abstract taskTrackingInfo: Google.Maps.JourneySharing.TaskTrackingInfo with get, set

    /// The details for a task returned by Fleet Engine.
    type [<AllowNullLiteral>] Task =
        /// Attributes assigned to the task.
        abstract attributes: TaskAttributes with get, set
        /// The timestamp of the estimated completion time of the task.
        abstract estimatedCompletionTime: DateTime option with get, set
        /// Information specific to the last location update.
        abstract latestVehicleLocationUpdate: Google.Maps.JourneySharing.VehicleLocationUpdate option with get, set
        /// The task name in the format
        /// &quot;providers/{provider_id}/tasks/{task_id}&quot;. The task_id must be
        /// a unique identifier and not a tracking ID. To store a tracking ID of a
        /// shipment, use the tracking_id field. Multiple tasks can have the same
        /// tracking_id.
        abstract name: string with get, set
        /// The outcome of the task.
        abstract outcome: string option with get, set
        /// The location where the task was completed (from provider).
        abstract outcomeLocation: Google.Maps.LatLngLiteral option with get, set
        /// The setter of the task outcome location (&#39;PROVIDER&#39; or
        /// &#39;LAST_VEHICLE_LOCATION&#39;).
        abstract outcomeLocationSource: string option with get, set
        /// The timestamp of when the task&#39;s outcome was set (from provider).
        abstract outcomeTime: DateTime option with get, set
        /// The location where the task is to be completed.
        abstract plannedLocation: Google.Maps.LatLngLiteral option with get, set
        /// Information about the segments left to be completed for this task.
        abstract remainingVehicleJourneySegments: ResizeArray<Google.Maps.JourneySharing.VehicleJourneySegment> with get, set
        /// The current execution state of the task.
        abstract status: string with get, set
        /// The time window during which the task should be completed.
        abstract targetTimeWindow: Google.Maps.JourneySharing.TimeWindow option with get, set
        /// The tracking ID of the shipment.
        abstract trackingId: string option with get, set
        /// The task type; for example, a break or shipment.
        abstract ``type``: string with get, set
        /// The ID of the vehicle performing this task.
        abstract vehicleId: string option with get, set

    /// <summary>TaskInfo type, used by <see cref="*">google.maps.journeySharing.DeliveryVehicleStop</see>.</summary>
    type [<AllowNullLiteral>] TaskInfo =
        /// The extra time it takes to perform the task, in milliseconds.
        abstract extraDurationMillis: float option with get, set
        /// The ID of the task.
        abstract id: string option with get, set
        /// The time window during which the task should be completed.
        abstract targetTimeWindow: Google.Maps.JourneySharing.TimeWindow option with get, set

    /// <summary>
    /// Parameters specific to marker customization functions that apply options to
    /// markers representing planned or actual task locations. Used by <see cref="*">google.maps.journeySharing.FleetEngineDeliveryVehicleLocationProviderOptions.taskMarkerCustomization</see>
    /// and <see cref="*">google.maps.journeySharing.FleetEngineDeliveryVehicleLocationProviderOptions.taskOutcomeMarkerCustomization</see>.
    /// </summary>
    type [<AllowNullLiteral>] TaskMarkerCustomizationFunctionParams =
        inherit Google.Maps.JourneySharing.DeliveryVehicleMarkerCustomizationFunctionParams
        /// The task location represented by this marker.
        abstract task: Google.Maps.JourneySharing.Task with get, set

    /// The details for a task tracking info object returned by Fleet Engine.
    type [<AllowNullLiteral>] TaskTrackingInfo =
        /// Attributes assigned to the task.
        abstract attributes: TaskAttributes with get, set
        /// The estimated arrival time to the stop location.
        abstract estimatedArrivalTime: DateTime option with get, set
        /// The estimated completion time of a Task.
        abstract estimatedTaskCompletionTime: DateTime option with get, set
        /// Information specific to the last location update.
        abstract latestVehicleLocationUpdate: Google.Maps.JourneySharing.VehicleLocationUpdate option with get, set
        /// The name in the format
        /// &amp;quot;providers/{provider_id}/taskTrackingInfo/{tracking_id}&amp;quot;, where
        /// &lt;code&gt;tracking_id&lt;/code&gt; represents the tracking ID.
        abstract name: string with get, set
        /// The location where the Task will be completed.
        abstract plannedLocation: Google.Maps.LatLng option with get, set
        /// The total remaining distance in meters to the &lt;code&gt;VehicleStop&lt;/code&gt; of
        /// interest.
        abstract remainingDrivingDistanceMeters: float option with get, set
        /// Indicates the number of stops the vehicle remaining until the task stop
        /// is reached, including the task stop. For example, if the vehicle&#39;s
        /// next stop is the task stop, the value will be 1.
        abstract remainingStopCount: float option with get, set
        /// A list of points which when connected forms a polyline of the
        /// vehicle&#39;s expected route to the location of this task.
        abstract routePolylinePoints: ResizeArray<Google.Maps.LatLng> option with get, set
        /// The current execution state of the Task.
        abstract state: string option with get, set
        /// The time window during which the task should be completed.
        abstract targetTimeWindow: Google.Maps.JourneySharing.TimeWindow option with get, set
        /// The outcome of attempting to execute a Task.
        abstract taskOutcome: string option with get, set
        /// The time when the Task&#39;s outcome was set by the provider.
        abstract taskOutcomeTime: DateTime option with get, set
        /// <summary>
        /// The tracking ID of a Task.&lt;br&gt; &lt;ul&gt; &lt;li&gt;Must be a valid Unicode
        /// string.&lt;/li&gt; &lt;li&gt;Limited to a maximum length of 64 characters.&lt;/li&gt;
        /// &lt;li&gt;Normalized according to &lt;a
        /// href="<see href="http://www.unicode.org/reports/tr15/"&gt;Unicode" /> Normalization Form
        /// C&lt;/a&gt;.&lt;/li&gt; &lt;li&gt;May not contain any of the following ASCII characters:
        /// &amp;#39;/&amp;#39;, &amp;#39;:&amp;#39;, &amp;#39;?&amp;#39;, &amp;#39;,&amp;#39;, or
        /// &amp;#39;#&amp;#39;.&lt;/li&gt; &lt;/ul&gt;
        /// </summary>
        abstract trackingId: string with get, set

    /// A time range.
    type [<AllowNullLiteral>] TimeWindow =
        /// The end time of the time window (inclusive).
        abstract endTime: DateTime with get, set
        /// The start time of the time window (inclusive).
        abstract startTime: DateTime with get, set

    /// The details for a trip returned by Fleet Engine.
    type [<AllowNullLiteral>] Trip =
        /// Location where the customer was dropped off.
        abstract actualDropOffLocation: Google.Maps.LatLngLiteral option with get, set
        /// Location where the customer was picked up.
        abstract actualPickupLocation: Google.Maps.LatLngLiteral option with get, set
        /// The estimated future time when the passengers will be dropped off, or the
        /// actual time when they were dropped off.
        abstract dropOffTime: DateTime option with get, set
        /// Information specific to the last location update.
        abstract latestVehicleLocationUpdate: Google.Maps.JourneySharing.VehicleLocationUpdate option with get, set
        /// In the format &quot;providers/{provider_id}/trips/{trip_id}&quot;. The
        /// trip_id must be a unique identifier.
        abstract name: string with get, set
        /// Number of passengers on this trip; does not include the driver.
        abstract passengerCount: float with get, set
        /// The estimated future time when the passengers will be picked up, or the
        /// actual time when they were picked up.
        abstract pickupTime: DateTime option with get, set
        /// Location where the customer indicates they will be dropped off.
        abstract plannedDropOffLocation: Google.Maps.LatLngLiteral option with get, set
        /// Location where customer indicates they will be picked up.
        abstract plannedPickupLocation: Google.Maps.LatLngLiteral option with get, set
        /// An array of waypoints indicating the path from the current location to
        /// the drop-off point.
        abstract remainingWaypoints: ResizeArray<Google.Maps.JourneySharing.VehicleWaypoint> with get, set
        /// Current status of the trip. Possible values are UNKNOWN_TRIP_STATUS, NEW,
        /// ENROUTE_TO_PICKUP, ARRIVED_AT_PICKUP,
        /// ARRIVED_AT_INTERMEDIATE_DESTINATION, ENROUTE_TO_INTERMEDIATE_DESTINATION,
        /// ENROUTE_TO_DROPOFF, COMPLETE, or CANCELED.
        abstract status: string with get, set
        /// The type of the trip. Possible values are UNKNOWN_TRIP_TYPE, SHARED or
        /// EXCLUSIVE.
        abstract ``type``: string with get, set
        /// ID of the vehicle making this trip.
        abstract vehicleId: string with get, set

    /// <summary>
    /// Parameters specific to marker customization functions that apply options to
    /// markers representing trip vehicle, origin and destination locations. Used
    /// by <see cref="*">google.maps.journeySharing.FleetEngineTripLocationProviderOptions.vehicleMarkerCustomization</see>, <see cref="*">google.maps.journeySharing.FleetEngineTripLocationProviderOptions.originMarkerCustomization</see>,
    /// and <see cref="*">google.maps.journeySharing.FleetEngineTripLocationProviderOptions.destinationMarkerCustomization</see>.
    /// </summary>
    type [<AllowNullLiteral>] TripMarkerCustomizationFunctionParams =
        inherit Google.Maps.JourneySharing.MarkerCustomizationFunctionParams
        /// <summary>
        /// The trip associated with this marker. &lt;br&gt;&lt;br&gt;For information about the
        /// vehicle servicing this trip, use <see cref="*">google.maps.journeySharing.Trip.latestVehicleLocationUpdate</see> and <see cref="*">google.maps.journeySharing.Trip.remainingWaypoints</see>.
        /// </summary>
        abstract trip: Google.Maps.JourneySharing.Trip with get, set

    /// <summary>
    /// Available only in the v=beta channel: <see href="https://goo.gle/3oAthT3." />
    ///
    /// Trip types supported by a <see cref="google.maps.journeySharing.Vehicle" />.
    ///
    /// Access by calling `const {TripType} = await
    /// google.maps.importLibrary("journeySharing")`. See
    /// <see href="https://developers.google.com/maps/documentation/javascript/libraries." />
    /// </summary>
    type [<StringEnum>] [<RequireQualifiedAccess>] TripType =
        /// The trip is exclusive to a vehicle.
        | [<CompiledName("EXCLUSIVE")>] EXCLUSIVE
        /// The trip may share a vehicle with other trips.
        | [<CompiledName("SHARED")>] SHARED
        /// Unknown trip type.
        | [<CompiledName("UNKNOWN_TRIP_TYPE")>] UNKNOWN_TRIP_TYPE

    /// <summary>
    /// Available only in the v=beta channel: <see href="https://goo.gle/3oAthT3." />
    ///
    /// TripWaypoint type.
    /// </summary>
    type [<AllowNullLiteral>] TripWaypoint =
        /// The path distance between the previous waypoint (or the vehicle&#39;s
        /// current location, if this waypoint is the first in the list of waypoints)
        /// to this waypoint in meters.
        abstract distanceMeters: float option with get, set
        /// Travel time between the previous waypoint (or the vehicle&#39;s current
        /// location, if this waypoint is the first in the list of waypoints) to this
        /// waypoint in milliseconds.
        abstract durationMillis: float option with get, set
        /// The location of the waypoint.
        abstract location: Google.Maps.LatLngLiteral option with get, set
        /// The trip associated with this waypoint.
        abstract tripId: string option with get, set
        /// The role this waypoint plays in this trip, such as pickup or dropoff.
        abstract waypointType: Google.Maps.JourneySharing.WaypointType option with get, set

    /// <summary>
    /// Parameters specific to marker customization functions that apply options to
    /// markers representing trip waypoint locations. Used by <see cref="*">google.maps.journeySharing.FleetEngineTripLocationProviderOptions.waypointMarkerCustomization</see>.
    /// </summary>
    type [<AllowNullLiteral>] TripWaypointMarkerCustomizationFunctionParams =
        inherit Google.Maps.JourneySharing.TripMarkerCustomizationFunctionParams
        /// <summary>
        /// The 0-based waypoint index associated with this marker. Use this index
        /// on <see cref="google.maps.journeySharing.Trip.remainingWaypoints" /> to retrieve
        /// information about the waypoint.
        /// </summary>
        abstract waypointIndex: float with get, set

    /// <summary>
    /// Available only in the v=beta channel: <see href="https://goo.gle/3oAthT3." />
    ///
    /// The details for a vehicle returned by Fleet Engine.
    /// </summary>
    type [<AllowNullLiteral>] Vehicle =
        /// Custom vehicle attributes.
        abstract attributes: TaskAttributes with get, set
        /// The waypoint where current route segment ends.
        abstract currentRouteSegmentEndPoint: Google.Maps.JourneySharing.TripWaypoint option with get, set
        /// Time when the current route segment was set.
        abstract currentRouteSegmentVersion: DateTime option with get, set
        /// List of trip IDs for trips currently assigned to this vehicle.
        abstract currentTrips: ResizeArray<string> option with get, set
        /// The ETA to the first entry in the waypoints field.
        abstract etaToFirstWaypoint: DateTime option with get, set
        /// The last reported location of the vehicle.
        abstract latestLocation: Google.Maps.JourneySharing.VehicleLocationUpdate option with get, set
        /// The total numbers of riders this vehicle can carry. The driver is not
        /// considered in this value.
        abstract maximumCapacity: float option with get, set
        /// In the format &quot;providers/{provider_id}/vehicles/{vehicle_id}&quot;.
        /// The vehicle_id must be a unique identifier.
        abstract name: string with get, set
        /// The current navigation status of the vehicle.
        abstract navigationStatus: Google.Maps.JourneySharing.VehicleNavigationStatus with get, set
        /// The remaining driving distance in the current route segment, in meters.
        abstract remainingDistanceMeters: float with get, set
        /// Trip types supported by this vehicle.
        abstract supportedTripTypes: ResizeArray<Google.Maps.JourneySharing.TripType> option with get, set
        /// The vehicle state.
        abstract vehicleState: Google.Maps.JourneySharing.VehicleState with get, set
        /// The type of this vehicle.
        abstract vehicleType: Google.Maps.JourneySharing.VehicleType with get, set
        /// The remaining waypoints assigned to this Vehicle.
        abstract waypoints: ResizeArray<Google.Maps.JourneySharing.TripWaypoint> option with get, set
        /// Last time the waypoints field was updated.
        abstract waypointsVersion: DateTime option with get, set

    /// VehicleJourneySegment type
    type [<AllowNullLiteral>] VehicleJourneySegment =
        /// The travel distance from the previous stop to this stop, in meters.
        abstract drivingDistanceMeters: float option with get, set
        /// The travel time from the previous stop this stop, in milliseconds.
        abstract drivingDurationMillis: float option with get, set
        /// The path from the previous stop (or the vehicle&#39;s current location,
        /// if this stop is the first in the list of stops) to this stop.
        abstract path: ResizeArray<Google.Maps.LatLngLiteral> option with get, set
        /// Information about the stop.
        abstract stop: Google.Maps.JourneySharing.DeliveryVehicleStop option with get, set

    /// VehicleLocationUpdate type
    type [<AllowNullLiteral>] VehicleLocationUpdate =
        /// The heading of the update. 0 corresponds to north, 180 to south.
        abstract heading: float option with get, set
        /// The location of the update.
        abstract location: U2<Google.Maps.LatLngLiteral, Google.Maps.LatLng> option with get, set
        /// The speed in kilometers per hour.
        abstract speedKilometersPerHour: float option with get, set
        /// The time this update was received from the vehicle.
        abstract time: DateTime option with get, set

    /// <summary>
    /// Available only in the v=beta channel: <see href="https://goo.gle/3oAthT3." />
    ///
    /// Parameters specific to marker customization functions that apply options to
    /// vehicle markers. Used by <see cref="*">google.maps.journeySharing.FleetEngineVehicleLocationProviderOptions.vehicleMarkerCustomization</see>
    /// and <see cref="*">google.maps.journeySharing.FleetEngineFleetLocationProviderOptions.vehicleMarkerCustomization</see>.
    /// </summary>
    type [<AllowNullLiteral>] VehicleMarkerCustomizationFunctionParams =
        inherit Google.Maps.JourneySharing.MarkerCustomizationFunctionParams
        /// The vehicle represented by this marker.
        abstract vehicle: Google.Maps.JourneySharing.Vehicle with get, set

    /// <summary>
    /// Available only in the v=beta channel: <see href="https://goo.gle/3oAthT3." />
    ///
    /// The current navigation status of a <see cref="*">google.maps.journeySharing.Vehicle</see>.
    ///
    /// Access by calling `const {VehicleNavigationStatus} = await
    /// google.maps.importLibrary("journeySharing")`. See
    /// <see href="https://developers.google.com/maps/documentation/javascript/libraries." />
    /// </summary>
    type [<StringEnum>] [<RequireQualifiedAccess>] VehicleNavigationStatus =
        /// The vehicle is within approximately 50m of the destination.
        | [<CompiledName("ARRIVED_AT_DESTINATION")>] ARRIVED_AT_DESTINATION
        /// Turn-by-turn navigation is available and the Driver app navigation has
        /// entered GUIDED_NAV mode.
        | [<CompiledName("ENROUTE_TO_DESTINATION")>] ENROUTE_TO_DESTINATION
        /// The Driver app&#39;s navigation is in FREE_NAV mode.
        | [<CompiledName("NO_GUIDANCE")>] NO_GUIDANCE
        /// The vehicle has gone off the suggested route.
        | [<CompiledName("OFF_ROUTE")>] OFF_ROUTE
        /// Unspecified navigation status.
        | [<CompiledName("UNKNOWN_NAVIGATION_STATUS")>] UNKNOWN_NAVIGATION_STATUS

    /// <summary>
    /// Available only in the v=beta channel: <see href="https://goo.gle/3oAthT3." />
    ///
    /// The current state of a <see cref="google.maps.journeySharing.Vehicle" />.
    ///
    /// Access by calling `const {VehicleState} = await
    /// google.maps.importLibrary("journeySharing")`. See
    /// <see href="https://developers.google.com/maps/documentation/javascript/libraries." />
    /// </summary>
    type [<StringEnum>] [<RequireQualifiedAccess>] VehicleState =
        /// The vehicle is not accepting new trips.
        | [<CompiledName("OFFLINE")>] OFFLINE
        /// The vehicle is accepting new trips.
        | [<CompiledName("ONLINE")>] ONLINE
        /// Unknown vehicle state.
        | [<CompiledName("UNKNOWN_VEHICLE_STATE")>] UNKNOWN_VEHICLE_STATE

    /// <summary>
    /// Available only in the v=beta channel: <see href="https://goo.gle/3oAthT3." />
    ///
    /// The type of <see cref="google.maps.journeySharing.Vehicle" />.
    ///
    /// Access by calling `const {VehicleType} = await
    /// google.maps.importLibrary("journeySharing")`. See
    /// <see href="https://developers.google.com/maps/documentation/javascript/libraries." />
    /// </summary>
    type [<StringEnum>] [<RequireQualifiedAccess>] VehicleType =
        /// An automobile.
        | [<CompiledName("AUTO")>] AUTO
        /// Any vehicle that acts as a taxi (typically licensed or regulated).
        | [<CompiledName("TAXI")>] TAXI
        /// A vehicle with a large storage capacity.
        | [<CompiledName("TRUCK")>] TRUCK
        /// A motorcycle, moped, or other two-wheeled vehicle.
        | [<CompiledName("TWO_WHEELER")>] TWO_WHEELER
        /// Unknown vehicle type.
        | [<CompiledName("UNKNOWN")>] UNKNOWN

    /// VehicleWaypoint type.
    type [<AllowNullLiteral>] VehicleWaypoint =
        /// The path distance between the previous waypoint (or the vehicle&#39;s
        /// current location, if this waypoint is the first in the list of waypoints)
        /// to this waypoint in meters.
        abstract distanceMeters: float option with get, set
        /// Travel time between the previous waypoint (or the vehicle&#39;s current
        /// location, if this waypoint is the first in the list of waypoints) to this
        /// waypoint in milliseconds.
        abstract durationMillis: float option with get, set
        /// The location of the waypoint.
        abstract location: Google.Maps.LatLngLiteral option with get, set
        /// The path from the previous waypoint (or the vehicle&#39;s current
        /// location, if this waypoint is the first in the list of waypoints) to this
        /// waypoint.
        abstract path: ResizeArray<Google.Maps.LatLngLiteral> option with get, set

    /// <summary>
    /// Available only in the v=beta channel: <see href="https://goo.gle/3oAthT3." />
    ///
    /// Parameters specific to marker customization functions that apply options to
    /// vehicle waypoint markers. Used by <see cref="*">google.maps.journeySharing.FleetEngineVehicleLocationProviderOptions.originMarkerCustomization</see>, <see cref="*">google.maps.journeySharing.FleetEngineVehicleLocationProviderOptions.destinationMarkerCustomization</see>
    /// and <see cref="*">google.maps.journeySharing.FleetEngineVehicleLocationProviderOptions.intermediateDestinationMarkerCustomization</see>
    /// </summary>
    type [<AllowNullLiteral>] VehicleWaypointMarkerCustomizationFunctionParams =
        inherit Google.Maps.JourneySharing.VehicleMarkerCustomizationFunctionParams
        /// <summary>
        /// The 0-based waypoint index associated with this marker. Use this index
        /// on <see cref="google.maps.journeySharing.Vehicle.waypoints" /> to retrieve
        /// information about the waypoint.
        /// </summary>
        abstract waypointIndex: float with get, set

    /// <summary>
    /// Available only in the v=beta channel: <see href="https://goo.gle/3oAthT3." />
    ///
    /// Waypoint types supported by <see cref="google.maps.journeySharing.Vehicle" />.
    ///
    /// Access by calling `const {WaypointType} = await
    /// google.maps.importLibrary("journeySharing")`. See
    /// <see href="https://developers.google.com/maps/documentation/javascript/libraries." />
    /// </summary>
    type [<StringEnum>] [<RequireQualifiedAccess>] WaypointType =
        /// Waypoints for dropping off riders.
        | [<CompiledName("DROP_OFF_WAYPOINT_TYPE")>] DROP_OFF_WAYPOINT_TYPE
        /// Waypoints for intermediate destinations in a multi-destination trip.
        | [<CompiledName("INTERMEDIATE_DESTINATION_WAYPOINT_TYPE")>] INTERMEDIATE_DESTINATION_WAYPOINT_TYPE
        /// Waypoints for picking up riders.
        | [<CompiledName("PICKUP_WAYPOINT_TYPE")>] PICKUP_WAYPOINT_TYPE
        /// Unknown waypoint type.
        | [<CompiledName("UNKNOWN_WAYPOINT_TYPE")>] UNKNOWN_WAYPOINT_TYPE

    type [<AllowNullLiteral>] DeliveryVehicleAttributes =
        [<EmitIndexer>] abstract Item: key: string -> string option with get, set

    type [<AllowNullLiteral>] TaskAttributes =
        [<EmitIndexer>] abstract Item: key: string -> obj with get, set

module LocalContext =

    type [<AllowNullLiteral>] IExports =
        /// <summary>
        /// Available only in the v=beta channel: <see href="https://goo.gle/3oAthT3." />
        ///
        /// Shows a Local Context experience with a <see cref="google.maps.Map" />.
        ///
        /// Access by calling `const {LocalContextMapView} = await
        /// google.maps.importLibrary("localContext")`. See
        /// <see href="https://developers.google.com/maps/documentation/javascript/libraries." />
        /// </summary>
        [<Obsolete("Local Context is deprecated, and no longer recommended for new
websites. The feature will continue to work, and 12 months notice will
be given before support is discontinued. If you are interested in
building a Local Context-like experience yourself, we suggest that you
check out the &quot;Neighborhood Discovery&quot; solution in <a
href=\"https://mapsplatform.google.com/resources/quick-builder/\">Quick
Builder</a> or use the <a
href=\"https://developers.google.com/maps/documentation/javascript/places\">Places
Library</a>, Maps JavaScript API. <a
href=\"https://developers.google.com/maps/documentation/javascript/examples#places\">Code
samples</a> and <a
href=\"https://codelabs.developers.google.com/?product=googlemapsplatform&text=places\">codelabs</a>
for the Places Library can help you.")>]
        abstract LocalContextMapView: LocalContextMapViewStatic
        /// <summary>
        /// Available only in the v=beta channel: <see href="https://goo.gle/3oAthT3." />
        ///
        /// Provides settings for directions with a <see cref="*">google.maps.localContext.LocalContextMapView</see>.
        ///
        /// Access by calling `const {MapDirectionsOptions} = await
        /// google.maps.importLibrary("localContext")`. See
        /// <see href="https://developers.google.com/maps/documentation/javascript/libraries." />
        /// </summary>
        abstract MapDirectionsOptions: MapDirectionsOptionsStatic

    /// <summary>
    /// Available only in the v=beta channel: <see href="https://goo.gle/3oAthT3." />
    ///
    /// Shows a Local Context experience with a <see cref="google.maps.Map" />.
    ///
    /// Access by calling `const {LocalContextMapView} = await
    /// google.maps.importLibrary("localContext")`. See
    /// <see href="https://developers.google.com/maps/documentation/javascript/libraries." />
    /// </summary>
    [<Obsolete("Local Context is deprecated, and no longer recommended for new
websites. The feature will continue to work, and 12 months notice will
be given before support is discontinued. If you are interested in
building a Local Context-like experience yourself, we suggest that you
check out the &quot;Neighborhood Discovery&quot; solution in <a
href=\"https://mapsplatform.google.com/resources/quick-builder/\">Quick
Builder</a> or use the <a
href=\"https://developers.google.com/maps/documentation/javascript/places\">Places
Library</a>, Maps JavaScript API. <a
href=\"https://developers.google.com/maps/documentation/javascript/examples#places\">Code
samples</a> and <a
href=\"https://codelabs.developers.google.com/?product=googlemapsplatform&text=places\">codelabs</a>
for the Places Library can help you.")>]
    type [<AllowNullLiteral>] LocalContextMapView =
        inherit Google.Maps.LocalContext.LocalContextMapViewOptions
        /// Adds the given listener function to the given event name.
        abstract addListener: eventName: string * handler: Function -> Google.Maps.MapsEventListener
        /// <summary>See <see cref="*">google.maps.localContext.LocalContextMapViewOptions.directionsOptions</see>.</summary>
        abstract directionsOptions: Google.Maps.LocalContext.MapDirectionsOptionsLiteral option with get, set
        /// This Field is read-only. The DOM Element backing the view.
        abstract element: U2<HTMLElement, SVGSVGElement> option with get, set
        /// Hides the place details.
        abstract hidePlaceDetailsView: unit -> unit
        /// <summary>
        /// Is set to &lt;code&gt;true&lt;/code&gt; before <see cref="*">google.maps.localContext.LocalContextMapView</see> begins changing the bounds
        /// of the inner <see cref="google.maps.Map" />, and set to &lt;code&gt;false&lt;/code&gt;
        /// after <see cref="google.maps.localContext.LocalContextMapView" /> finishes
        /// changing the bounds of the inner <see cref="google.maps.Map" />. (Not set when
        /// layout mode changes happen due to responsive resizing.)
        /// </summary>
        abstract isTransitioningMapBounds: bool with get, set
        /// <summary>
        /// See <see cref="*">google.maps.localContext.LocalContextMapViewOptions.locationBias</see>.
        /// Changing this property on the &lt;code&gt;LocalContextMapView&lt;/code&gt; may
        /// trigger a new search.
        /// </summary>
        abstract locationBias: U7<Google.Maps.LatLng, Google.Maps.LatLngLiteral, Google.Maps.LatLngBounds, Google.Maps.LatLngBoundsLiteral, Google.Maps.Circle, Google.Maps.CircleLiteral, string> option with get, set
        /// <summary>
        /// See <see cref="*">google.maps.localContext.LocalContextMapViewOptions.locationRestriction</see>.
        /// Changing this property on the &lt;code&gt;LocalContextMapView&lt;/code&gt; may
        /// trigger a new search.
        /// </summary>
        abstract locationRestriction: U2<Google.Maps.LatLngBounds, Google.Maps.LatLngBoundsLiteral> option with get, set
        /// <summary>
        /// An already instantiated <see cref="google.maps.Map" /> instance. If passed in,
        /// the map will be moved into the LocalContextMapView&amp;#39;s DOM, and will
        /// &lt;strong&gt;not&lt;/strong&gt; be re-styled. The element associated with the Map
        /// may also have styles and classes applied to it by the
        /// &lt;code&gt;LocalContextMapView&lt;/code&gt;.
        /// </summary>
        abstract map: Google.Maps.Map option with get, set
        /// <summary>
        /// See <see cref="*">google.maps.localContext.LocalContextMapViewOptions.maxPlaceCount</see>.
        /// Changing this property on the &lt;code&gt;LocalContextMapView&lt;/code&gt; may
        /// trigger a new search.
        /// </summary>
        abstract maxPlaceCount: float with get, set
        /// Configure the place marker icon based on the icon state. Invoked whenever
        /// the input to the callback changes. Pass a function to dynamically
        /// override the default setup when the LocalContextMapView draws the place
        /// marker. Errors and invalid configurations may be determined
        /// asynchronously, and will be ignored (defaults will be used, and errors
        /// will be logged to the console).
        abstract pinOptionsSetup: U2<({| isHighlighted: bool; isSelected: bool |} -> Google.Maps.LocalContext.PinOptions option), Google.Maps.LocalContext.PinOptions> option with get, set
        /// Overrides the setup of the place chooser view. Pass a function to
        /// dynamically override the default setup when the LocalContextMapView might
        /// change its layout due to resizing. Errors and invalid configurations may
        /// be determined asynchronously, and will be ignored (defaults will be used
        /// instead, and errors will be logged to the console). Errors detected at
        /// construction will cause errors to be thrown synchronously.
        abstract placeChooserViewSetup: U2<({| defaultLayoutMode: Google.Maps.LocalContext.PlaceChooserLayoutMode; defaultPosition: Google.Maps.LocalContext.PlaceChooserPosition option |} -> Google.Maps.LocalContext.PlaceChooserViewSetupOptions option), Google.Maps.LocalContext.PlaceChooserViewSetupOptions> option with get, set
        /// Overrides the setup of the place details view. Pass a function to
        /// dynamically override the default setup when the LocalContextMapView might
        /// change its layout due to resizing. Errors and invalid configurations may
        /// be determined asynchronously, and will be ignored (defaults will be used,
        /// and errors will be logged to the console). Errors detected at
        /// construction will cause errors to be thrown synchronously.
        abstract placeDetailsViewSetup: U2<({| defaultLayoutMode: Google.Maps.LocalContext.PlaceDetailsLayoutMode; defaultPosition: Google.Maps.LocalContext.PlaceDetailsPosition option |} -> Google.Maps.LocalContext.PlaceDetailsViewSetupOptions option), Google.Maps.LocalContext.PlaceDetailsViewSetupOptions> option with get, set
        /// <summary>
        /// See <see cref="*">google.maps.localContext.LocalContextMapViewOptions.placeTypePreferences</see>.
        /// Changing this property on the &lt;code&gt;LocalContextMapView&lt;/code&gt; may
        /// trigger a new search.
        /// &lt;code&gt;Iterable&amp;lt;string|PlaceTypePreference&amp;gt;&lt;/code&gt; is also accepted.
        /// </summary>
        abstract placeTypePreferences: ResizeArray<Google.Maps.LocalContext.PlaceTypePreference> with get, set
        /// Searches for places to show the user based on the current
        /// &lt;code&gt;maxPlaceCount&lt;/code&gt;, &lt;code&gt;placeTypePreferences&lt;/code&gt;,
        /// &lt;code&gt;locationRestriction&lt;/code&gt;, and &lt;code&gt;locationBias&lt;/code&gt;.
        abstract search: unit -> unit

    /// <summary>
    /// Available only in the v=beta channel: <see href="https://goo.gle/3oAthT3." />
    ///
    /// Shows a Local Context experience with a <see cref="google.maps.Map" />.
    ///
    /// Access by calling `const {LocalContextMapView} = await
    /// google.maps.importLibrary("localContext")`. See
    /// <see href="https://developers.google.com/maps/documentation/javascript/libraries." />
    /// </summary>
    [<Obsolete("Local Context is deprecated, and no longer recommended for new
websites. The feature will continue to work, and 12 months notice will
be given before support is discontinued. If you are interested in
building a Local Context-like experience yourself, we suggest that you
check out the &quot;Neighborhood Discovery&quot; solution in <a
href=\"https://mapsplatform.google.com/resources/quick-builder/\">Quick
Builder</a> or use the <a
href=\"https://developers.google.com/maps/documentation/javascript/places\">Places
Library</a>, Maps JavaScript API. <a
href=\"https://developers.google.com/maps/documentation/javascript/examples#places\">Code
samples</a> and <a
href=\"https://codelabs.developers.google.com/?product=googlemapsplatform&text=places\">codelabs</a>
for the Places Library can help you.")>]
    type [<AllowNullLiteral>] LocalContextMapViewStatic =
        /// <summary>
        /// Available only in the v=beta channel: <see href="https://goo.gle/3oAthT3." />
        ///
        /// Shows a Local Context experience with a <see cref="google.maps.Map" />.
        ///
        /// Access by calling `const {LocalContextMapView} = await
        /// google.maps.importLibrary("localContext")`. See
        /// <see href="https://developers.google.com/maps/documentation/javascript/libraries." />
        /// </summary>
        [<Obsolete("Local Context is deprecated, and no longer recommended for
new websites. The feature will continue to work, and 12 months notice
will be given before support is discontinued. If you are interested
in building a Local Context-like experience yourself, we suggest that
you check out the &quot;Neighborhood Discovery&quot; solution in <a
href=\"https://mapsplatform.google.com/resources/quick-builder/\">Quick
Builder</a> or use the <a
href=\"https://developers.google.com/maps/documentation/javascript/places\">Places
Library</a>, Maps JavaScript API. <a
href=\"https://developers.google.com/maps/documentation/javascript/examples#places\">Code
samples</a> and <a
href=\"https://codelabs.developers.google.com/?product=googlemapsplatform&text=places\">codelabs</a>
for the Places Library can help you.")>]
        [<EmitConstructor>] abstract Create: options: Google.Maps.LocalContext.LocalContextMapViewOptions -> LocalContextMapView

    /// <summary>
    /// Available only in the v=beta channel: <see href="https://goo.gle/3oAthT3." />
    ///
    /// Options for constructing a <see cref="*">google.maps.localContext.LocalContextMapView</see>, or accessing an
    /// existing <see cref="google.maps.localContext.LocalContextMapView" />.
    /// </summary>
    type [<AllowNullLiteral>] LocalContextMapViewOptions =
        /// Options for customizing directions. If not set, directions and distance
        /// will be disabled.
        abstract directionsOptions: Google.Maps.LocalContext.MapDirectionsOptionsLiteral option with get, set
        /// This Field is read-only. The DOM Element backing the view.
        abstract element: U2<HTMLElement, SVGElement> option with get, set
        /// <summary>A soft boundary or hint to use when searching for places.</summary>
        /// <default>&lt;code&gt;null&lt;/code&gt;</default>
        abstract locationBias: U7<Google.Maps.LatLng, Google.Maps.LatLngLiteral, Google.Maps.LatLngBounds, Google.Maps.LatLngBoundsLiteral, Google.Maps.Circle, Google.Maps.CircleLiteral, string> option with get, set
        /// Bounds to constrain search results. If not specified, results will be
        /// constrained to the map viewport.
        abstract locationRestriction: U2<Google.Maps.LatLngBounds, Google.Maps.LatLngBoundsLiteral> option with get, set
        /// <summary>
        /// An already instantiated <see cref="google.maps.Map" /> instance. If passed in,
        /// the map will be moved into the LocalContextMapView&amp;#39;s DOM, and will
        /// &lt;strong&gt;not&lt;/strong&gt; be re-styled. The element associated with the Map
        /// may also have styles and classes applied to it by the
        /// &lt;code&gt;LocalContextMapView&lt;/code&gt;.
        /// </summary>
        abstract map: Google.Maps.Map option with get, set
        /// The maximum number of places to show. When this parameter is 0, the Local
        /// Context Library does not load places. [0,24]
        abstract maxPlaceCount: float with get, set
        /// Configure the place marker icon based on the icon state. Invoked whenever
        /// the input to the callback changes. Pass a function to dynamically
        /// override the default setup when the LocalContextMapView draws the place
        /// marker. Errors and invalid configurations may be determined
        /// asynchronously, and will be ignored (defaults will be used, and errors
        /// will be logged to the console).
        abstract pinOptionsSetup: U2<({| isHighlighted: bool; isSelected: bool |} -> Google.Maps.LocalContext.PinOptions option), Google.Maps.LocalContext.PinOptions> option with get, set
        /// Overrides the setup of the place chooser view. Pass a function to
        /// dynamically override the default setup when the LocalContextMapView might
        /// change its layout due to resizing. Errors and invalid configurations may
        /// be determined asynchronously, and will be ignored (defaults will be used
        /// instead, and errors will be logged to the console). Errors detected at
        /// construction will cause errors to be thrown synchronously.
        abstract placeChooserViewSetup: U2<({| defaultLayoutMode: Google.Maps.LocalContext.PlaceChooserLayoutMode; defaultPosition: Google.Maps.LocalContext.PlaceChooserPosition option |} -> Google.Maps.LocalContext.PlaceChooserViewSetupOptions option), Google.Maps.LocalContext.PlaceChooserViewSetupOptions> option with get, set
        /// Overrides the setup of the place details view. Pass a function to
        /// dynamically override the default setup when the LocalContextMapView might
        /// change its layout due to resizing. Errors and invalid configurations may
        /// be determined asynchronously, and will be ignored (defaults will be used,
        /// and errors will be logged to the console). Errors detected at
        /// construction will cause errors to be thrown synchronously.
        abstract placeDetailsViewSetup: U2<({| defaultLayoutMode: Google.Maps.LocalContext.PlaceDetailsLayoutMode; defaultPosition: Google.Maps.LocalContext.PlaceDetailsPosition option |} -> Google.Maps.LocalContext.PlaceDetailsViewSetupOptions option), Google.Maps.LocalContext.PlaceDetailsViewSetupOptions> option with get, set
        /// The types of places to search for (up to 10). The type
        /// &lt;code&gt;Iterable&amp;lt;string|PlaceTypePreference&amp;gt;&lt;/code&gt; is also accepted,
        /// but is only supported in browsers which natively support JavaScript
        /// Symbols.
        abstract placeTypePreferences: ResizeArray<Google.Maps.LocalContext.PlaceTypePreference> with get, set

    /// <summary>
    /// Available only in the v=beta channel: <see href="https://goo.gle/3oAthT3." />
    ///
    /// Provides settings for directions with a <see cref="*">google.maps.localContext.LocalContextMapView</see>.
    ///
    /// Access by calling `const {MapDirectionsOptions} = await
    /// google.maps.importLibrary("localContext")`. See
    /// <see href="https://developers.google.com/maps/documentation/javascript/libraries." />
    /// </summary>
    type [<AllowNullLiteral>] MapDirectionsOptions =
        inherit Google.Maps.LocalContext.MapDirectionsOptionsLiteral
        /// Adds the given listener function to the given event name.
        abstract addListener: eventName: string * handler: Function -> Google.Maps.MapsEventListener
        /// Origin for directions and distance.
        abstract origin: U2<Google.Maps.LatLng, Google.Maps.LatLngLiteral> with get, set

    /// <summary>
    /// Available only in the v=beta channel: <see href="https://goo.gle/3oAthT3." />
    ///
    /// Provides settings for directions with a <see cref="*">google.maps.localContext.LocalContextMapView</see>.
    ///
    /// Access by calling `const {MapDirectionsOptions} = await
    /// google.maps.importLibrary("localContext")`. See
    /// <see href="https://developers.google.com/maps/documentation/javascript/libraries." />
    /// </summary>
    type [<AllowNullLiteral>] MapDirectionsOptionsStatic =
        [<EmitConstructor>] abstract Create: unit -> MapDirectionsOptions

    /// <summary>
    /// Available only in the v=beta channel: <see href="https://goo.gle/3oAthT3." />
    ///
    /// Object literals are accepted in place of <see cref="*">google.maps.localContext.MapDirectionsOptions</see> objects, as a convenience,
    /// in many places. These are converted to <see cref="*">google.maps.localContext.MapDirectionsOptions</see> objects when the Maps API
    /// encounters them.
    /// </summary>
    type [<AllowNullLiteral>] MapDirectionsOptionsLiteral =
        /// Origin for directions and distance.
        abstract origin: U2<Google.Maps.LatLng, Google.Maps.LatLngLiteral> with get, set

    /// <summary>
    /// Available only in the v=beta channel: <see href="https://goo.gle/3oAthT3." />
    ///
    /// Options for customizing a pin marker.
    /// </summary>
    type [<AllowNullLiteral>] PinOptions =
        /// The color of the icon&#39;s shape, can be any valid CSS color.
        abstract background: string option with get, set
        /// The color of the icon&#39;s glyph, can be any valid CSS color.
        abstract glyphColor: string option with get, set
        /// The scale of the icon. The value is absolute, not relative to the default
        /// sizes in each state.
        abstract scale: float option with get, set

    /// <summary>
    /// Available only in the v=beta channel: <see href="https://goo.gle/3oAthT3." />
    ///
    /// Layout modes for the place chooser.
    ///
    /// Access by calling `const {PlaceChooserLayoutMode} = await
    /// google.maps.importLibrary("localContext")`. See
    /// <see href="https://developers.google.com/maps/documentation/javascript/libraries." />
    /// </summary>
    type [<StringEnum>] [<RequireQualifiedAccess>] PlaceChooserLayoutMode =
        /// Place chooser is hidden.
        | [<CompiledName("HIDDEN")>] HIDDEN
        /// Place chooser is shown as a sheet.
        | [<CompiledName("SHEET")>] SHEET

    /// <summary>
    /// Available only in the v=beta channel: <see href="https://goo.gle/3oAthT3." />
    ///
    /// Display positions for the place chooser.
    ///
    /// Access by calling `const {PlaceChooserPosition} = await
    /// google.maps.importLibrary("localContext")`. See
    /// <see href="https://developers.google.com/maps/documentation/javascript/libraries." />
    /// </summary>
    type [<StringEnum>] [<RequireQualifiedAccess>] PlaceChooserPosition =
        /// Place chooser is displayed on a line below the map extending to the end
        /// of the container.
        | [<CompiledName("BLOCK_END")>] BLOCK_END
        /// Place chooser is displayed inline with the map at the end of the line.
        /// (In a left-to-right language this means that the place chooser is to the
        /// right of the map.)
        | [<CompiledName("INLINE_END")>] INLINE_END
        /// Place chooser is displayed inline with the map at the start of the line.
        /// (In a left-to-right language this means that the place chooser is to the
        /// left of the map.)
        | [<CompiledName("INLINE_START")>] INLINE_START

    /// <summary>
    /// Setup options for the place chooser. Read more about &lt;a
    /// href="<see href="https://developers.google.com/maps/documentation/javascript/local-context/set-options#setting_layout_and_visibility"&gt;setting" />
    /// layout and visibility&lt;/a&gt;.
    /// </summary>
    type [<AllowNullLiteral>] PlaceChooserViewSetupOptions =
        abstract layoutMode: Google.Maps.LocalContext.PlaceChooserLayoutMode option with get, set
        /// Ignored when &lt;code&gt;layoutMode:HIDDEN&lt;/code&gt;. If not passed, a position
        /// will be determined automatically based on the &lt;code&gt;layoutMode&lt;/code&gt;.
        abstract position: Google.Maps.LocalContext.PlaceChooserPosition option with get, set

    /// <summary>
    /// Available only in the v=beta channel: <see href="https://goo.gle/3oAthT3." />
    ///
    /// Layout modes for the place details.
    ///
    /// Access by calling `const {PlaceDetailsLayoutMode} = await
    /// google.maps.importLibrary("localContext")`. See
    /// <see href="https://developers.google.com/maps/documentation/javascript/libraries." />
    /// </summary>
    type [<StringEnum>] [<RequireQualifiedAccess>] PlaceDetailsLayoutMode =
        /// <summary>Place details is displayed in an <see cref="google.maps.InfoWindow" />.</summary>
        | [<CompiledName("INFO_WINDOW")>] INFO_WINDOW
        /// Place details is displayed in a sheet.
        | [<CompiledName("SHEET")>] SHEET

    /// <summary>
    /// Available only in the v=beta channel: <see href="https://goo.gle/3oAthT3." />
    ///
    /// Display positions for the place details.
    ///
    /// Access by calling `const {PlaceDetailsPosition} = await
    /// google.maps.importLibrary("localContext")`. See
    /// <see href="https://developers.google.com/maps/documentation/javascript/libraries." />
    /// </summary>
    type [<StringEnum>] [<RequireQualifiedAccess>] PlaceDetailsPosition =
        /// Place details is displayed inline with the map at the end of the line.
        /// (In a left-to-right language this means that the place details is to the
        /// right of the map.)
        | [<CompiledName("INLINE_END")>] INLINE_END
        /// Place details is displayed inline with the map at the start of the line.
        /// (In a left-to-right language this means that the place details is to the
        /// left of the map.)
        | [<CompiledName("INLINE_START")>] INLINE_START

    /// <summary>
    /// Setup options for the place details. Read more about &lt;a
    /// href="<see href="https://developers.google.com/maps/documentation/javascript/local-context/set-options#setting_layout_and_visibility"&gt;setting" />
    /// layout and visibility&lt;/a&gt;.
    /// </summary>
    type [<AllowNullLiteral>] PlaceDetailsViewSetupOptions =
        abstract hidesOnMapClick: bool option with get, set
        abstract layoutMode: Google.Maps.LocalContext.PlaceDetailsLayoutMode option with get, set
        /// Ignored when &lt;code&gt;layoutMode:INFO_WINDOW&lt;/code&gt;. If not passed, a
        /// position will be determined automatically based on the
        /// &lt;code&gt;layoutMode&lt;/code&gt;.
        abstract position: Google.Maps.LocalContext.PlaceDetailsPosition option with get, set

    /// <summary>Available only in the v=beta channel: <see href="https://goo.gle/3oAthT3." /></summary>
    type [<AllowNullLiteral>] PlaceTypePreference =
        abstract ``type``: string with get, set
        abstract weight: float option with get, set

module Marker =

    type [<AllowNullLiteral>] IExports =
        /// <summary>
        /// Available only in the v=beta channel: <see href="https://goo.gle/3oAthT3." />
        ///
        /// This event is created from clicking an Advanced Marker. Access the
        /// marker&amp;#39;s position with &lt;code&gt;event.target.position&lt;/code&gt;.
        ///
        /// Access by calling `const {AdvancedMarkerClickEvent} = await
        /// google.maps.importLibrary("marker")`. See
        /// <see href="https://developers.google.com/maps/documentation/javascript/libraries." />
        /// </summary>
        abstract AdvancedMarkerClickEvent: AdvancedMarkerClickEventStatic
        /// <summary>
        /// Shows a position on a map. Note that the &lt;code&gt;position&lt;/code&gt; must be set
        /// for the &lt;code&gt;AdvancedMarkerElement&lt;/code&gt; to display.&lt;br&gt; &lt;br&gt;
        /// &lt;strong&gt;Note:&lt;/strong&gt; Usage as a Web Component (e.g. using the custom
        /// &lt;code&gt;&amp;lt;gmp-advanced-marker&amp;gt;&lt;/code&gt; HTML element, is only available in
        /// the &lt;code&gt;v=beta&lt;/code&gt; channel).
        ///
        /// Access by calling `const {AdvancedMarkerElement} = await
        /// google.maps.importLibrary("marker")`. See
        /// <see href="https://developers.google.com/maps/documentation/javascript/libraries." />
        /// </summary>
        abstract AdvancedMarkerElement: AdvancedMarkerElementStatic
        /// <summary>
        /// A &lt;code&gt;PinElement&lt;/code&gt; represents a DOM element that consists of a shape
        /// and a glyph. The shape has the same balloon style as seen in the
        /// default <see cref="google.maps.marker.AdvancedMarkerElement" />. The glyph is an
        /// optional DOM element displayed in the balloon shape. A
        /// &lt;code&gt;PinElement&lt;/code&gt; may have a different aspect ratio depending on
        /// its <see cref="google.maps.marker.PinElement.scale" />.&lt;br&gt; &lt;br&gt;
        /// &lt;strong&gt;Note:&lt;/strong&gt; Usage as a Web Component (e.g. usage as an
        /// HTMLElement subclass, or via HTML) is not yet supported.
        ///
        /// Access by calling `const {PinElement} = await
        /// google.maps.importLibrary("marker")`. See
        /// <see href="https://developers.google.com/maps/documentation/javascript/libraries." />
        /// </summary>
        abstract PinElement: PinElementStatic

    /// <summary>
    /// Available only in the v=beta channel: <see href="https://goo.gle/3oAthT3." />
    ///
    /// This event is created from clicking an Advanced Marker. Access the
    /// marker&amp;#39;s position with &lt;code&gt;event.target.position&lt;/code&gt;.
    ///
    /// Access by calling `const {AdvancedMarkerClickEvent} = await
    /// google.maps.importLibrary("marker")`. See
    /// <see href="https://developers.google.com/maps/documentation/javascript/libraries." />
    /// </summary>
    type [<AllowNullLiteral>] AdvancedMarkerClickEvent =
        inherit Event

    /// <summary>
    /// Available only in the v=beta channel: <see href="https://goo.gle/3oAthT3." />
    ///
    /// This event is created from clicking an Advanced Marker. Access the
    /// marker&amp;#39;s position with &lt;code&gt;event.target.position&lt;/code&gt;.
    ///
    /// Access by calling `const {AdvancedMarkerClickEvent} = await
    /// google.maps.importLibrary("marker")`. See
    /// <see href="https://developers.google.com/maps/documentation/javascript/libraries." />
    /// </summary>
    type [<AllowNullLiteral>] AdvancedMarkerClickEventStatic =
        /// <summary>
        /// Available only in the v=beta channel: <see href="https://goo.gle/3oAthT3." />
        ///
        /// This event is created from clicking an Advanced Marker. Access the
        /// marker&amp;#39;s position with &lt;code&gt;event.target.position&lt;/code&gt;.
        ///
        /// Access by calling `const {AdvancedMarkerClickEvent} = await
        /// google.maps.importLibrary("marker")`. See
        /// <see href="https://developers.google.com/maps/documentation/javascript/libraries." />
        /// </summary>
        [<EmitConstructor>] abstract Create: unit -> AdvancedMarkerClickEvent

    /// <summary>
    /// Shows a position on a map. Note that the &lt;code&gt;position&lt;/code&gt; must be set
    /// for the &lt;code&gt;AdvancedMarkerElement&lt;/code&gt; to display.&lt;br&gt; &lt;br&gt;
    /// &lt;strong&gt;Note:&lt;/strong&gt; Usage as a Web Component (e.g. using the custom
    /// &lt;code&gt;&amp;lt;gmp-advanced-marker&amp;gt;&lt;/code&gt; HTML element, is only available in
    /// the &lt;code&gt;v=beta&lt;/code&gt; channel).
    ///
    /// Access by calling `const {AdvancedMarkerElement} = await
    /// google.maps.importLibrary("marker")`. See
    /// <see href="https://developers.google.com/maps/documentation/javascript/libraries." />
    /// </summary>
    type [<AllowNullLiteral>] AdvancedMarkerElement =
        inherit HTMLElement
        inherit Google.Maps.Marker.AdvancedMarkerElementOptions
        /// <summary>
        /// Adds the given listener function to the given event name in the Maps
        /// Eventing system.
        /// </summary>
        /// <param name="eventName">Observed event.</param>
        /// <param name="handler">Function to handle events.</param>
        abstract addListener: eventName: string * handler: Function -> Google.Maps.MapsEventListener
        /// <summary>See <see cref="*">google.maps.marker.AdvancedMarkerElementOptions.collisionBehavior</see>.</summary>
        abstract collisionBehavior: Google.Maps.CollisionBehavior option with get, set
        /// <summary>See <see cref="google.maps.marker.AdvancedMarkerElementOptions.content" />.</summary>
        abstract content: Node option with get, set
        /// This field is read-only. The DOM Element backing the view.
        abstract element: HTMLElement with get, set
        /// <summary>See <see cref="google.maps.marker.AdvancedMarkerElementOptions.gmpDraggable" />.</summary>
        abstract gmpDraggable: bool option with get, set
        /// <summary>See <see cref="google.maps.marker.AdvancedMarkerElementOptions.map" />.</summary>
        abstract map: Google.Maps.Map option with get, set
        /// <summary>See <see cref="google.maps.marker.AdvancedMarkerElementOptions.position" />.</summary>
        abstract position: U3<Google.Maps.LatLng, Google.Maps.LatLngLiteral, Google.Maps.LatLngAltitudeLiteral> option with get, set
        /// <summary>See <see cref="google.maps.marker.AdvancedMarkerElementOptions.title" />.</summary>
        abstract title: string with get, set
        /// <summary>See <see cref="google.maps.marker.AdvancedMarkerElementOptions.zIndex" />.</summary>
        abstract zIndex: float option with get, set

    /// <summary>
    /// Shows a position on a map. Note that the &lt;code&gt;position&lt;/code&gt; must be set
    /// for the &lt;code&gt;AdvancedMarkerElement&lt;/code&gt; to display.&lt;br&gt; &lt;br&gt;
    /// &lt;strong&gt;Note:&lt;/strong&gt; Usage as a Web Component (e.g. using the custom
    /// &lt;code&gt;&amp;lt;gmp-advanced-marker&amp;gt;&lt;/code&gt; HTML element, is only available in
    /// the &lt;code&gt;v=beta&lt;/code&gt; channel).
    ///
    /// Access by calling `const {AdvancedMarkerElement} = await
    /// google.maps.importLibrary("marker")`. See
    /// <see href="https://developers.google.com/maps/documentation/javascript/libraries." />
    /// </summary>
    type [<AllowNullLiteral>] AdvancedMarkerElementStatic =
        /// <summary>
        /// Shows a position on a map. Note that the &lt;code&gt;position&lt;/code&gt; must be
        /// set for the &lt;code&gt;AdvancedMarkerElement&lt;/code&gt; to display.&lt;br&gt; &lt;br&gt;
        /// &lt;strong&gt;Note:&lt;/strong&gt; Usage as a Web Component (e.g. using the custom
        /// &lt;code&gt;&amp;lt;gmp-advanced-marker&amp;gt;&lt;/code&gt; HTML element, is only available
        /// in the &lt;code&gt;v=beta&lt;/code&gt; channel).
        ///
        /// Access by calling `const {AdvancedMarkerElement} = await
        /// google.maps.importLibrary("marker")`. See
        /// <see href="https://developers.google.com/maps/documentation/javascript/libraries." />
        /// </summary>
        [<EmitConstructor>] abstract Create: ?options: Google.Maps.Marker.AdvancedMarkerElementOptions -> AdvancedMarkerElement

    /// <summary>Options for constructing an <see cref="*">google.maps.marker.AdvancedMarkerElement</see>.</summary>
    type [<AllowNullLiteral>] AdvancedMarkerElementOptions =
        /// An enumeration specifying how an &lt;code&gt;AdvancedMarkerElement&lt;/code&gt;
        /// should behave when it collides with another
        /// &lt;code&gt;AdvancedMarkerElement&lt;/code&gt; or with the basemap labels on a vector
        /// map. &lt;p&gt;&lt;strong&gt;Note&lt;/strong&gt;: &lt;code&gt;AdvancedMarkerElement&lt;/code&gt; to
        /// &lt;code&gt;AdvancedMarkerElement&lt;/code&gt; collision works on both raster and
        /// vector maps, however, &lt;code&gt;AdvancedMarkerElement&lt;/code&gt; to base
        /// map&amp;#39;s label collision only works on vector maps.
        abstract collisionBehavior: Google.Maps.CollisionBehavior option with get, set
        /// <summary>
        /// The DOM Element backing the visual of an
        /// &lt;code&gt;AdvancedMarkerElement&lt;/code&gt;. &lt;p&gt;&lt;strong&gt;Note&lt;/strong&gt;:
        /// &lt;code&gt;AdvancedMarkerElement&lt;/code&gt; does not clone the passed-in DOM
        /// element. Once the DOM element is passed to an
        /// &lt;code&gt;AdvancedMarkerElement&lt;/code&gt;, passing the same DOM element to
        /// another &lt;code&gt;AdvancedMarkerElement&lt;/code&gt; will move the DOM element and
        /// cause the previous &lt;code&gt;AdvancedMarkerElement&lt;/code&gt; to look empty.
        /// </summary>
        /// <default><see cref="google.maps.marker.PinElement.element" /></default>
        abstract content: Node option with get, set
        /// <summary>
        /// If &lt;code&gt;true&lt;/code&gt;, the &lt;code&gt;AdvancedMarkerElement&lt;/code&gt; can be
        /// dragged. &lt;p&gt;&lt;strong&gt;Note&lt;/strong&gt;: &lt;code&gt;AdvancedMarkerElement&lt;/code&gt;
        /// with altitude is not draggable.
        /// </summary>
        /// <default>&lt;code&gt;false&lt;/code&gt;</default>
        abstract gmpDraggable: bool option with get, set
        /// <summary>
        /// Map on which to display the &lt;code&gt;AdvancedMarkerElement&lt;/code&gt;. The map
        /// is required to display the &lt;code&gt;AdvancedMarkerElement&lt;/code&gt; and can be
        /// provided by setting <see cref="google.maps.marker.AdvancedMarkerElement.map" />
        /// if not provided at the construction.
        /// </summary>
        abstract map: Google.Maps.Map option with get, set
        /// <summary>
        /// Sets the &lt;code&gt;AdvancedMarkerElement&lt;/code&gt;&amp;#39;s position. An
        /// &lt;code&gt;AdvancedMarkerElement&lt;/code&gt; may be constructed without a position,
        /// but will not be displayed until its position is provided - for example,
        /// by a user&amp;#39;s actions or choices. An
        /// &lt;code&gt;AdvancedMarkerElement&lt;/code&gt;&amp;#39;s position can be provided by
        /// setting <see cref="google.maps.marker.AdvancedMarkerElement.position" /> if not
        /// provided at the construction. &lt;p&gt;&lt;strong&gt;Note&lt;/strong&gt;:
        /// &lt;code&gt;AdvancedMarkerElement&lt;/code&gt; with altitude is only supported on
        /// vector maps.
        /// </summary>
        abstract position: U2<Google.Maps.LatLng, Google.Maps.LatLngLiteral> option with get, set
        /// Rollover text. If provided, an accessibility text (e.g. for use with
        /// screen readers) will be added to the &lt;code&gt;AdvancedMarkerElement&lt;/code&gt;
        /// with the provided value.
        abstract title: string option with get, set
        /// <summary>
        /// All &lt;code&gt;AdvancedMarkerElement&lt;/code&gt;s are displayed on the map in order
        /// of their zIndex, with higher values displaying in front of
        /// &lt;code&gt;AdvancedMarkerElement&lt;/code&gt;s with lower values. By default,
        /// &lt;code&gt;AdvancedMarkerElement&lt;/code&gt;s are displayed according to their
        /// vertical position on screen, with lower
        /// &lt;code&gt;AdvancedMarkerElement&lt;/code&gt;s appearing in front of
        /// &lt;code&gt;AdvancedMarkerElement&lt;/code&gt;s farther up the screen. Note that
        /// &lt;code&gt;zIndex&lt;/code&gt; is also used to help determine relative priority
        /// between <see cref="*">google.maps.CollisionBehavior.OPTIONAL_AND_HIDES_LOWER_PRIORITY</see> Advanced
        /// Markers. A higher &lt;code&gt;zIndex&lt;/code&gt; value indicates higher priority.
        /// </summary>
        abstract zIndex: float option with get, set

    /// <summary>
    /// A &lt;code&gt;PinElement&lt;/code&gt; represents a DOM element that consists of a shape
    /// and a glyph. The shape has the same balloon style as seen in the
    /// default <see cref="google.maps.marker.AdvancedMarkerElement" />. The glyph is an
    /// optional DOM element displayed in the balloon shape. A
    /// &lt;code&gt;PinElement&lt;/code&gt; may have a different aspect ratio depending on
    /// its <see cref="google.maps.marker.PinElement.scale" />.&lt;br&gt; &lt;br&gt;
    /// &lt;strong&gt;Note:&lt;/strong&gt; Usage as a Web Component (e.g. usage as an
    /// HTMLElement subclass, or via HTML) is not yet supported.
    ///
    /// Access by calling `const {PinElement} = await
    /// google.maps.importLibrary("marker")`. See
    /// <see href="https://developers.google.com/maps/documentation/javascript/libraries." />
    /// </summary>
    type [<AllowNullLiteral>] PinElement =
        inherit HTMLElement
        inherit Google.Maps.Marker.PinElementOptions
        /// <summary>See <see cref="google.maps.marker.PinElementOptions.background" />.</summary>
        abstract background: string option with get, set
        /// <summary>See <see cref="google.maps.marker.PinElementOptions.borderColor" />.</summary>
        abstract borderColor: string option with get, set
        /// This field is read-only. The DOM Element backing the view.
        abstract element: HTMLElement with get, set
        /// <summary>See <see cref="google.maps.marker.PinElementOptions.glyph" />.</summary>
        abstract glyph: U3<string, Element, URL> option with get, set
        /// <summary>See <see cref="google.maps.marker.PinElementOptions.glyphColor" />.</summary>
        abstract glyphColor: string option with get, set
        /// <summary>See <see cref="google.maps.marker.PinElementOptions.scale" />.</summary>
        abstract scale: float option with get, set

    /// <summary>
    /// A &lt;code&gt;PinElement&lt;/code&gt; represents a DOM element that consists of a shape
    /// and a glyph. The shape has the same balloon style as seen in the
    /// default <see cref="google.maps.marker.AdvancedMarkerElement" />. The glyph is an
    /// optional DOM element displayed in the balloon shape. A
    /// &lt;code&gt;PinElement&lt;/code&gt; may have a different aspect ratio depending on
    /// its <see cref="google.maps.marker.PinElement.scale" />.&lt;br&gt; &lt;br&gt;
    /// &lt;strong&gt;Note:&lt;/strong&gt; Usage as a Web Component (e.g. usage as an
    /// HTMLElement subclass, or via HTML) is not yet supported.
    ///
    /// Access by calling `const {PinElement} = await
    /// google.maps.importLibrary("marker")`. See
    /// <see href="https://developers.google.com/maps/documentation/javascript/libraries." />
    /// </summary>
    type [<AllowNullLiteral>] PinElementStatic =
        /// <summary>
        /// A &lt;code&gt;PinElement&lt;/code&gt; represents a DOM element that consists of a
        /// shape and a glyph. The shape has the same balloon style as seen in the
        /// default <see cref="google.maps.marker.AdvancedMarkerElement" />. The glyph is an
        /// optional DOM element displayed in the balloon shape. A
        /// &lt;code&gt;PinElement&lt;/code&gt; may have a different aspect ratio depending on
        /// its <see cref="google.maps.marker.PinElement.scale" />.&lt;br&gt; &lt;br&gt;
        /// &lt;strong&gt;Note:&lt;/strong&gt; Usage as a Web Component (e.g. usage as an
        /// HTMLElement subclass, or via HTML) is not yet supported.
        ///
        /// Access by calling `const {PinElement} = await
        /// google.maps.importLibrary("marker")`. See
        /// <see href="https://developers.google.com/maps/documentation/javascript/libraries." />
        /// </summary>
        [<EmitConstructor>] abstract Create: ?options: Google.Maps.Marker.PinElementOptions -> PinElement

    /// <summary>Options for creating a <see cref="google.maps.marker.PinElement" />.</summary>
    type [<AllowNullLiteral>] PinElementOptions =
        /// <summary>
        /// The background color of the pin shape. Supports any CSS &lt;a
        /// href="<see href="https://developer.mozilla.org/en-US/docs/Web/CSS/color_value"&gt;color" />
        /// value&lt;/a&gt;.
        /// </summary>
        abstract background: string option with get, set
        /// <summary>
        /// The border color of the pin shape. Supports any CSS &lt;a
        /// href="<see href="https://developer.mozilla.org/en-US/docs/Web/CSS/color_value"&gt;color" />
        /// value&lt;/a&gt;.
        /// </summary>
        abstract borderColor: string option with get, set
        /// The DOM element displayed in the pin.
        abstract glyph: U3<string, Element, URL> option with get, set
        /// <summary>
        /// The color of the glyph. Supports any CSS &lt;a
        /// href="<see href="https://developer.mozilla.org/en-US/docs/Web/CSS/color_value"&gt;color" />
        /// value&lt;/a&gt;.
        /// </summary>
        abstract glyphColor: string option with get, set
        /// <summary>The scale of the pin.</summary>
        /// <default>&lt;code&gt;1&lt;/code&gt;</default>
        abstract scale: float option with get, set

module Places =

    type [<AllowNullLiteral>] IExports =
        /// <summary>
        /// Available only in the v=beta channel: <see href="https://goo.gle/3oAthT3." />
        ///
        ///
        /// Access by calling `const {AddressComponent} = await
        /// google.maps.importLibrary("places")`. See
        /// <see href="https://developers.google.com/maps/documentation/javascript/libraries." />
        /// </summary>
        abstract AddressComponent: AddressComponentStatic
        /// <summary>
        /// Available only in the v=beta channel: <see href="https://goo.gle/3oAthT3." />
        ///
        ///
        /// Access by calling `const {Attribution} = await
        /// google.maps.importLibrary("places")`. See
        /// <see href="https://developers.google.com/maps/documentation/javascript/libraries." />
        /// </summary>
        abstract Attribution: AttributionStatic
        /// <summary>
        /// Available only in the v=beta channel: <see href="https://goo.gle/3oAthT3." />
        ///
        ///
        /// Access by calling `const {AuthorAttribution} = await
        /// google.maps.importLibrary("places")`. See
        /// <see href="https://developers.google.com/maps/documentation/javascript/libraries." />
        /// </summary>
        abstract AuthorAttribution: AuthorAttributionStatic
        /// <summary>
        /// A widget that provides Place predictions based on a user&amp;#39;s text input.
        /// It attaches to an input element of type &lt;code&gt;text&lt;/code&gt;, and listens for
        /// text entry in that field. The list of predictions is presented as a
        /// drop-down list, and is updated as text is entered.
        ///
        /// Access by calling `const {Autocomplete} = await
        /// google.maps.importLibrary("places")`. See
        /// <see href="https://developers.google.com/maps/documentation/javascript/libraries." />
        /// </summary>
        abstract Autocomplete: AutocompleteStatic
        /// <summary>
        /// Contains methods related to retrieving Autocomplete predictions.
        ///
        /// Access by calling `const {AutocompleteService} = await
        /// google.maps.importLibrary("places")`. See
        /// <see href="https://developers.google.com/maps/documentation/javascript/libraries." />
        /// </summary>
        abstract AutocompleteService: AutocompleteServiceStatic
        /// <summary>
        /// Represents a session token used for tracking an autocomplete session, which
        /// can be a series of <see cref="*">google.maps.places.AutocompleteService.getPlacePredictions</see> calls followed
        /// by a single <see cref="google.maps.places.PlacesService.getDetails" /> call.
        ///
        /// Access by calling `const {AutocompleteSessionToken} = await
        /// google.maps.importLibrary("places")`. See
        /// <see href="https://developers.google.com/maps/documentation/javascript/libraries." />
        /// </summary>
        abstract AutocompleteSessionToken: AutocompleteSessionTokenStatic
        /// <summary>
        /// Available only in the v=beta channel: <see href="https://goo.gle/3oAthT3." />
        ///
        ///
        /// Access by calling `const {OpeningHours} = await
        /// google.maps.importLibrary("places")`. See
        /// <see href="https://developers.google.com/maps/documentation/javascript/libraries." />
        /// </summary>
        abstract OpeningHours: OpeningHoursStatic
        /// <summary>
        /// Available only in the v=beta channel: <see href="https://goo.gle/3oAthT3." />
        ///
        ///
        /// Access by calling `const {OpeningHoursPeriod} = await
        /// google.maps.importLibrary("places")`. See
        /// <see href="https://developers.google.com/maps/documentation/javascript/libraries." />
        /// </summary>
        abstract OpeningHoursPeriod: OpeningHoursPeriodStatic
        /// <summary>
        /// Available only in the v=beta channel: <see href="https://goo.gle/3oAthT3." />
        ///
        ///
        /// Access by calling `const {OpeningHoursPoint} = await
        /// google.maps.importLibrary("places")`. See
        /// <see href="https://developers.google.com/maps/documentation/javascript/libraries." />
        /// </summary>
        abstract OpeningHoursPoint: OpeningHoursPointStatic
        /// <summary>
        /// Available only in the v=beta channel: <see href="https://goo.gle/3oAthT3." />
        ///
        ///
        /// Access by calling `const {Photo} = await
        /// google.maps.importLibrary("places")`. See
        /// <see href="https://developers.google.com/maps/documentation/javascript/libraries." />
        /// </summary>
        abstract Photo: PhotoStatic
        /// <summary>
        /// Available only in the v=beta channel: <see href="https://goo.gle/3oAthT3." />
        ///
        ///
        /// Access by calling `const {Place} = await
        /// google.maps.importLibrary("places")`. See
        /// <see href="https://developers.google.com/maps/documentation/javascript/libraries." />
        /// </summary>
        abstract Place: PlaceStatic
        /// <summary>
        /// Available only in the v=alpha channel: <see href="https://goo.gle/js-alpha-channel." />
        ///
        /// &lt;ul&gt;
        /// &lt;li&gt;PlaceAutocompleteElement is an &lt;code&gt;HTMLElement&lt;/code&gt; subclass which
        /// provides a UI component for the Places Autocomplete API. After loading the
        /// &lt;code&gt;places&lt;/code&gt; library, an input with autocomplete functionality can
        /// be created in HTML. For example: &lt;pre&gt;&lt;code&gt;&amp;lt;gmp-placeautocomplete
        /// &amp;gt;&amp;lt;/gmp-placeautocomplete&amp;gt;&lt;/code&gt;&lt;/pre&gt;&lt;/li&gt;
        /// &lt;/ul&gt;
        ///
        /// Access by calling `const {PlaceAutocompleteElement} = await
        /// google.maps.importLibrary("places")`. See
        /// <see href="https://developers.google.com/maps/documentation/javascript/libraries." />
        /// </summary>
        abstract PlaceAutocompleteElement: PlaceAutocompleteElementStatic
        /// <summary>
        /// Available only in the v=alpha channel: <see href="https://goo.gle/js-alpha-channel." />
        ///
        /// This event is created after the user selects a place with the Place
        /// Autocomplete Element. Access the selection with &lt;code&gt;event.place&lt;/code&gt;.
        ///
        /// Access by calling `const {PlaceAutocompletePlaceSelectEvent} = await
        /// google.maps.importLibrary("places")`. See
        /// <see href="https://developers.google.com/maps/documentation/javascript/libraries." />
        /// </summary>
        abstract PlaceAutocompletePlaceSelectEvent: PlaceAutocompletePlaceSelectEventStatic
        /// <summary>
        /// Available only in the v=alpha channel: <see href="https://goo.gle/js-alpha-channel." />
        ///
        /// This event is emitted by the PlaceAutocompleteElement when there is an
        /// issue with the network request.
        ///
        /// Access by calling `const {PlaceAutocompleteRequestErrorEvent} = await
        /// google.maps.importLibrary("places")`. See
        /// <see href="https://developers.google.com/maps/documentation/javascript/libraries." />
        /// </summary>
        abstract PlaceAutocompleteRequestErrorEvent: PlaceAutocompleteRequestErrorEventStatic
        /// <summary>
        /// Contains methods related to searching for places and retrieving details
        /// about a place.
        ///
        /// Access by calling `const {PlacesService} = await
        /// google.maps.importLibrary("places")`. See
        /// <see href="https://developers.google.com/maps/documentation/javascript/libraries." />
        /// </summary>
        abstract PlacesService: PlacesServiceStatic
        /// <summary>
        /// Available only in the v=beta channel: <see href="https://goo.gle/3oAthT3." />
        ///
        ///
        /// Access by calling `const {PlusCode} = await
        /// google.maps.importLibrary("places")`. See
        /// <see href="https://developers.google.com/maps/documentation/javascript/libraries." />
        /// </summary>
        abstract PlusCode: PlusCodeStatic
        /// <summary>
        /// Available only in the v=beta channel: <see href="https://goo.gle/3oAthT3." />
        ///
        ///
        /// Access by calling `const {Review} = await
        /// google.maps.importLibrary("places")`. See
        /// <see href="https://developers.google.com/maps/documentation/javascript/libraries." />
        /// </summary>
        abstract Review: ReviewStatic
        /// <summary>
        /// A widget that provides query predictions based on a user&amp;#39;s text input.
        /// It attaches to an input element of type &lt;code&gt;text&lt;/code&gt;, and listens for
        /// text entry in that field. The list of predictions is presented as a
        /// drop-down list, and is updated as text is entered.
        ///
        /// Access by calling `const {SearchBox} = await
        /// google.maps.importLibrary("places")`. See
        /// <see href="https://developers.google.com/maps/documentation/javascript/libraries." />
        /// </summary>
        abstract SearchBox: SearchBoxStatic

    /// <summary>
    /// Available only in the v=beta channel: <see href="https://goo.gle/3oAthT3." />
    ///
    ///
    /// Access by calling `const {AddressComponent} = await
    /// google.maps.importLibrary("places")`. See
    /// <see href="https://developers.google.com/maps/documentation/javascript/libraries." />
    /// </summary>
    type [<AllowNullLiteral>] AddressComponent =
        /// The full text of the address component.
        abstract longText: string option with get, set
        /// The abbreviated, short text of the given address component.
        abstract shortText: string option with get, set
        /// <summary>
        /// An array of strings denoting the type of this address component. A list
        /// of valid types can be found &lt;a
        /// href="<see href="https://developers.google.com/maps/documentation/javascript/geocoding#GeocodingAddressTypes"&gt;here&lt;/a&gt;." />
        /// </summary>
        abstract types: ResizeArray<string> with get, set

    /// <summary>
    /// Available only in the v=beta channel: <see href="https://goo.gle/3oAthT3." />
    ///
    ///
    /// Access by calling `const {AddressComponent} = await
    /// google.maps.importLibrary("places")`. See
    /// <see href="https://developers.google.com/maps/documentation/javascript/libraries." />
    /// </summary>
    type [<AllowNullLiteral>] AddressComponentStatic =
        [<EmitConstructor>] abstract Create: unit -> AddressComponent

    /// <summary>
    /// Available only in the v=beta channel: <see href="https://goo.gle/3oAthT3." />
    ///
    ///
    /// Access by calling `const {Attribution} = await
    /// google.maps.importLibrary("places")`. See
    /// <see href="https://developers.google.com/maps/documentation/javascript/libraries." />
    /// </summary>
    type [<AllowNullLiteral>] Attribution =
        /// Attribution text to be displayed for this Place result.
        abstract provider: string option with get, set
        abstract providerURI: string option with get, set

    /// <summary>
    /// Available only in the v=beta channel: <see href="https://goo.gle/3oAthT3." />
    ///
    ///
    /// Access by calling `const {Attribution} = await
    /// google.maps.importLibrary("places")`. See
    /// <see href="https://developers.google.com/maps/documentation/javascript/libraries." />
    /// </summary>
    type [<AllowNullLiteral>] AttributionStatic =
        [<EmitConstructor>] abstract Create: unit -> Attribution

    /// <summary>
    /// Available only in the v=beta channel: <see href="https://goo.gle/3oAthT3." />
    ///
    ///
    /// Access by calling `const {AuthorAttribution} = await
    /// google.maps.importLibrary("places")`. See
    /// <see href="https://developers.google.com/maps/documentation/javascript/libraries." />
    /// </summary>
    type [<AllowNullLiteral>] AuthorAttribution =
        /// Author&#39;s name for this result.
        abstract displayName: string with get, set
        /// Author&#39;s photo URI for this result. This may not always be available.
        abstract photoURI: string option with get, set
        /// Author&#39;s profile URI for this result.
        abstract uri: string option with get, set

    /// <summary>
    /// Available only in the v=beta channel: <see href="https://goo.gle/3oAthT3." />
    ///
    ///
    /// Access by calling `const {AuthorAttribution} = await
    /// google.maps.importLibrary("places")`. See
    /// <see href="https://developers.google.com/maps/documentation/javascript/libraries." />
    /// </summary>
    type [<AllowNullLiteral>] AuthorAttributionStatic =
        [<EmitConstructor>] abstract Create: unit -> AuthorAttribution

    /// <summary>
    /// A widget that provides Place predictions based on a user&amp;#39;s text input.
    /// It attaches to an input element of type &lt;code&gt;text&lt;/code&gt;, and listens for
    /// text entry in that field. The list of predictions is presented as a
    /// drop-down list, and is updated as text is entered.
    ///
    /// Access by calling `const {Autocomplete} = await
    /// google.maps.importLibrary("places")`. See
    /// <see href="https://developers.google.com/maps/documentation/javascript/libraries." />
    /// </summary>
    type [<AllowNullLiteral>] Autocomplete =
        inherit Google.Maps.MVCObject
        /// Returns the bounds to which predictions are biased.
        abstract getBounds: unit -> Google.Maps.LatLngBounds option
        /// <summary>
        /// Returns the fields to be included for the Place in the details response
        /// when the details are successfully retrieved. For a list of fields
        /// see <see cref="google.maps.places.PlaceResult" />.
        /// </summary>
        abstract getFields: unit -> ResizeArray<string> option
        /// Returns the details of the Place selected by user if the details were
        /// successfully retrieved. Otherwise returns a stub Place object, with the
        /// &lt;code&gt;name&lt;/code&gt; property set to the current value of the input field.
        abstract getPlace: unit -> Google.Maps.Places.PlaceResult
        /// <summary>
        /// Sets the preferred area within which to return Place results. Results are
        /// biased towards, but not restricted to, this area.
        /// </summary>
        /// <param name="bounds">The biasing bounds.</param>
        abstract setBounds: bounds: U2<Google.Maps.LatLngBounds, Google.Maps.LatLngBoundsLiteral> option -> unit
        /// <summary>
        /// Sets the component restrictions. Component restrictions are used to
        /// restrict predictions to only those within the parent component. For
        /// example, the country.
        /// </summary>
        /// <param name="restrictions">The restrictions to use.</param>
        abstract setComponentRestrictions: restrictions: Google.Maps.Places.ComponentRestrictions option -> unit
        /// <summary>
        /// Sets the fields to be included for the Place in the details response when
        /// the details are successfully retrieved. For a list of fields see <see cref="*">google.maps.places.PlaceResult</see>.
        /// </summary>
        abstract setFields: fields: ResizeArray<string> option -> unit
        abstract setOptions: options: Google.Maps.Places.AutocompleteOptions option -> unit
        /// <summary>
        /// Sets the types of predictions to be returned. For supported types, see
        /// the &lt;a
        /// href="<see href="https://developers.google.com/maps/documentation/javascript/places-autocomplete#constrain-place-types"&gt;" />
        /// developer&amp;#39;s guide&lt;/a&gt;. If no types are specified, all types will be
        /// returned.
        /// </summary>
        /// <param name="types">The types of predictions to be included.</param>
        abstract setTypes: types: ResizeArray<string> option -> unit

    /// <summary>
    /// A widget that provides Place predictions based on a user&amp;#39;s text input.
    /// It attaches to an input element of type &lt;code&gt;text&lt;/code&gt;, and listens for
    /// text entry in that field. The list of predictions is presented as a
    /// drop-down list, and is updated as text is entered.
    ///
    /// Access by calling `const {Autocomplete} = await
    /// google.maps.importLibrary("places")`. See
    /// <see href="https://developers.google.com/maps/documentation/javascript/libraries." />
    /// </summary>
    type [<AllowNullLiteral>] AutocompleteStatic =
        /// <summary>
        /// A widget that provides Place predictions based on a user&amp;#39;s text
        /// input. It attaches to an input element of type &lt;code&gt;text&lt;/code&gt;, and
        /// listens for text entry in that field. The list of predictions is
        /// presented as a drop-down list, and is updated as text is entered.
        ///
        /// Access by calling `const {Autocomplete} = await
        /// google.maps.importLibrary("places")`. See
        /// <see href="https://developers.google.com/maps/documentation/javascript/libraries." />
        /// </summary>
        /// <param name="inputField">
        /// The &lt;code&gt;&amp;lt;input&amp;gt;&lt;/code&gt; text field to which the
        /// &lt;code&gt;Autocomplete&lt;/code&gt; should be attached.
        /// </param>
        /// <param name="opts">Options.</param>
        [<EmitConstructor>] abstract Create: inputField: HTMLInputElement * ?opts: Google.Maps.Places.AutocompleteOptions -> Autocomplete

    /// The options that can be set on an &lt;code&gt;Autocomplete&lt;/code&gt; object.
    type [<AllowNullLiteral>] AutocompleteOptions =
        /// The area in which to search for places.
        abstract bounds: U2<Google.Maps.LatLngBounds, Google.Maps.LatLngBoundsLiteral> option with get, set
        /// The component restrictions. Component restrictions are used to restrict
        /// predictions to only those within the parent component. For example, the
        /// country.
        abstract componentRestrictions: Google.Maps.Places.ComponentRestrictions option with get, set
        /// <summary>
        /// Fields to be included for the Place in the details response when the
        /// details are successfully retrieved, &lt;a
        /// href="<see href="https://developers.google.com/maps/billing/understanding-cost-of-use#places-product"&gt;which" />
        /// will be billed for&lt;/a&gt;. If &lt;code&gt;[&amp;#39;ALL&amp;#39;]&lt;/code&gt; is passed in, all
        /// available fields will be returned and billed for (this is not recommended
        /// for production deployments). For a list of fields see <see cref="*">google.maps.places.PlaceResult</see>. Nested fields can be specified with
        /// dot-paths (for example, &lt;code&gt;"geometry.location"&lt;/code&gt;). The default is
        /// &lt;code&gt;[&amp;#39;ALL&amp;#39;]&lt;/code&gt;.
        /// </summary>
        abstract fields: ResizeArray<string> option with get, set
        /// Whether to retrieve only Place IDs. The PlaceResult made available when
        /// the place_changed event is fired will only have the place_id, types and
        /// name fields, with the place_id, types and description returned by the
        /// Autocomplete service. Disabled by default.
        [<Obsolete("<code>placeIdOnly</code> is deprecated as of January 15,
2019, and will be turned off on January 15, 2020. Use {@link  *     google.maps.places.AutocompleteOptions.fields} instead: <code>fields:
[&#39;place_id&#39;, &#39;name&#39;, &#39;types&#39;]</code>.")>]
        abstract placeIdOnly: bool option with get, set
        /// A boolean value, indicating that the Autocomplete widget should only
        /// return those places that are inside the bounds of the Autocomplete widget
        /// at the time the query is sent. Setting strictBounds to &lt;code&gt;false&lt;/code&gt;
        /// (which is the default) will make the results biased towards, but not
        /// restricted to, places contained within the bounds.
        abstract strictBounds: bool option with get, set
        /// <summary>
        /// The types of predictions to be returned. For supported types, see the &lt;a
        /// href="<see href="https://developers.google.com/maps/documentation/javascript/places-autocomplete#constrain-place-types"&gt;" />
        /// developer&amp;#39;s guide&lt;/a&gt;. If no types are specified, all types will be
        /// returned.
        /// </summary>
        abstract types: ResizeArray<string> option with get, set

    /// Represents a single autocomplete prediction.
    type [<AllowNullLiteral>] AutocompletePrediction =
        /// This is the unformatted version of the query suggested by the Places
        /// service.
        abstract description: string with get, set
        /// <summary>The distance in meters of the place from the <see cref="*">google.maps.places.AutocompletionRequest.origin</see>.</summary>
        abstract distance_meters: float option with get, set
        /// A set of substrings in the place&#39;s description that match elements in
        /// the user&#39;s input, suitable for use in highlighting those substrings.
        /// Each substring is identified by an offset and a length, expressed in
        /// unicode characters.
        abstract matched_substrings: ResizeArray<Google.Maps.Places.PredictionSubstring> with get, set
        /// <summary>
        /// A place ID that can be used to retrieve details about this place using
        /// the place details service (see <see cref="*">google.maps.places.PlacesService.getDetails</see>).
        /// </summary>
        abstract place_id: string with get, set
        /// Structured information about the place&#39;s description, divided into a
        /// main text and a secondary text, including an array of matched substrings
        /// from the autocomplete input, identified by an offset and a length,
        /// expressed in unicode characters.
        abstract structured_formatting: Google.Maps.Places.StructuredFormatting with get, set
        /// Information about individual terms in the above description, from most to
        /// least specific. For example, &quot;Taco Bell&quot;, &quot;Willitis&quot;,
        /// and &quot;CA&quot;.
        abstract terms: ResizeArray<Google.Maps.Places.PredictionTerm> with get, set
        /// An array of types that the prediction belongs to, for example
        /// &lt;code&gt;'establishment'&lt;/code&gt; or &lt;code&gt;'geocode'&lt;/code&gt;.
        abstract types: ResizeArray<string> with get, set

    /// <summary>
    /// An Autocomplete response returned by the call to <see cref="*">google.maps.places.AutocompleteService.getPlacePredictions</see> containing a
    /// list of <see cref="google.maps.places.AutocompletePrediction" />s.
    /// </summary>
    type [<AllowNullLiteral>] AutocompleteResponse =
        /// <summary>The list of <see cref="google.maps.places.AutocompletePrediction" />s.</summary>
        abstract predictions: ResizeArray<Google.Maps.Places.AutocompletePrediction> with get, set

    /// <summary>
    /// Contains methods related to retrieving Autocomplete predictions.
    ///
    /// Access by calling `const {AutocompleteService} = await
    /// google.maps.importLibrary("places")`. See
    /// <see href="https://developers.google.com/maps/documentation/javascript/libraries." />
    /// </summary>
    type [<AllowNullLiteral>] AutocompleteService =
        /// <summary>
        /// Retrieves place autocomplete predictions based on the supplied
        /// autocomplete request.
        /// </summary>
        /// <param name="request">The autocompletion request.</param>
        /// <param name="callback">
        /// A callback accepting an array of AutocompletePrediction
        /// objects and a PlacesServiceStatus value as argument.
        /// </param>
        abstract getPlacePredictions: request: Google.Maps.Places.AutocompletionRequest * ?callback: (ResizeArray<Google.Maps.Places.AutocompletePrediction> option -> Google.Maps.Places.PlacesServiceStatus -> unit) -> Promise<Google.Maps.Places.AutocompleteResponse>
        /// <summary>
        /// Retrieves query autocomplete predictions based on the supplied query
        /// autocomplete request.
        /// </summary>
        /// <param name="request">The query autocompletion request.</param>
        /// <param name="callback">
        /// A callback accepting an array of
        /// QueryAutocompletePrediction objects and a PlacesServiceStatus value
        /// as argument.
        /// </param>
        abstract getQueryPredictions: request: Google.Maps.Places.QueryAutocompletionRequest * callback: (ResizeArray<Google.Maps.Places.QueryAutocompletePrediction> option -> Google.Maps.Places.PlacesServiceStatus -> unit) -> unit

    /// <summary>
    /// Contains methods related to retrieving Autocomplete predictions.
    ///
    /// Access by calling `const {AutocompleteService} = await
    /// google.maps.importLibrary("places")`. See
    /// <see href="https://developers.google.com/maps/documentation/javascript/libraries." />
    /// </summary>
    type [<AllowNullLiteral>] AutocompleteServiceStatic =
        [<EmitConstructor>] abstract Create: unit -> AutocompleteService

    /// <summary>
    /// Represents a session token used for tracking an autocomplete session, which
    /// can be a series of <see cref="*">google.maps.places.AutocompleteService.getPlacePredictions</see> calls followed
    /// by a single <see cref="google.maps.places.PlacesService.getDetails" /> call.
    ///
    /// Access by calling `const {AutocompleteSessionToken} = await
    /// google.maps.importLibrary("places")`. See
    /// <see href="https://developers.google.com/maps/documentation/javascript/libraries." />
    /// </summary>
    type [<AllowNullLiteral>] AutocompleteSessionToken =
        interface end

    /// <summary>
    /// Represents a session token used for tracking an autocomplete session, which
    /// can be a series of <see cref="*">google.maps.places.AutocompleteService.getPlacePredictions</see> calls followed
    /// by a single <see cref="google.maps.places.PlacesService.getDetails" /> call.
    ///
    /// Access by calling `const {AutocompleteSessionToken} = await
    /// google.maps.importLibrary("places")`. See
    /// <see href="https://developers.google.com/maps/documentation/javascript/libraries." />
    /// </summary>
    type [<AllowNullLiteral>] AutocompleteSessionTokenStatic =
        [<EmitConstructor>] abstract Create: unit -> AutocompleteSessionToken

    /// <summary>An Autocompletion request to be sent to <see cref="*">google.maps.places.AutocompleteService.getPlacePredictions</see>.</summary>
    type [<AllowNullLiteral; Global>] AutocompletionRequest private () =

        [<ParamObject; Emit("$0")>]
        new (
            input: string,
            ?bounds: Google.Maps.LatLngBounds,
            ?componentRestrictions: Google.Maps.Places.ComponentRestrictions,
            ?language: string,
            ?location: Google.Maps.LatLng,
            ?locationBias: Google.Maps.LatLngBounds,
            ?locationRestriction: Google.Maps.LatLngBounds,
            ?offset: float,
            ?origin: Google.Maps.LatLng,
            ?radius: float,
            ?region: string,
            ?sessionToken: Google.Maps.Places.AutocompleteSessionToken,
            ?types: ResizeArray<string>
        ) = AutocompletionRequest()

        /// Bounds for prediction biasing. Predictions will be biased towards, but
        /// not restricted to, the given &lt;code&gt;bounds&lt;/code&gt;. Both
        /// &lt;code&gt;location&lt;/code&gt; and &lt;code&gt;radius&lt;/code&gt; will be ignored if
        /// &lt;code&gt;bounds&lt;/code&gt; is set.
        [<Obsolete("<code>bounds</code> is deprecated as of May 2023. Use {@link  *     google.maps.places.AutocompletionRequest.locationBias} and {@link  *     google.maps.places.AutocompletionRequest.locationRestriction}
instead."       )>]
        member val bounds: U2<Google.Maps.LatLngBounds, Google.Maps.LatLngBoundsLiteral> option = nativeOnly with get, set
        /// The component restrictions. Component restrictions are used to restrict
        /// predictions to only those within the parent component. For example, the
        /// country.
        member val componentRestrictions: Google.Maps.Places.ComponentRestrictions option = nativeOnly with get, set
        /// The user entered input string.
        member val input: string = nativeOnly with get, set
        /// <summary>
        /// A language identifier for the language in which the results should be
        /// returned, if possible. Results in the selected language may be given a
        /// higher ranking, but suggestions are not restricted to this language. See
        /// the &lt;a href="<see href="https://developers.google.com/maps/faq#languagesupport"&gt;list" />
        /// of supported languages&lt;/a&gt;.
        /// </summary>
        member val language: string option = nativeOnly with get, set
        /// Location for prediction biasing. Predictions will be biased towards the
        /// given &lt;code&gt;location&lt;/code&gt; and &lt;code&gt;radius&lt;/code&gt;. Alternatively,
        /// &lt;code&gt;bounds&lt;/code&gt; can be used.
        [<Obsolete("<code>location</code> is deprecated as of May 2023.
Use {@link google.maps.places.AutocompletionRequest.locationBias }
and {@link  *     google.maps.places.AutocompletionRequest.locationRestriction}
instead."       )>]
        member val location: Google.Maps.LatLng option = nativeOnly with get, set
        /// A soft boundary or hint to use when searching for places.
        member val locationBias: U7<Google.Maps.LatLng, Google.Maps.LatLngLiteral, Google.Maps.LatLngBounds, Google.Maps.LatLngBoundsLiteral, Google.Maps.Circle, Google.Maps.CircleLiteral, string> option = nativeOnly with get, set
        /// Bounds to constrain search results.
        member val locationRestriction: U2<Google.Maps.LatLngBounds, Google.Maps.LatLngBoundsLiteral> option = nativeOnly with get, set
        /// The character position in the input term at which the service uses text
        /// for predictions (the position of the cursor in the input field).
        member val offset: float option = nativeOnly with get, set
        /// <summary>
        /// The location where <see cref="*">google.maps.places.AutocompletePrediction.distance_meters</see> is calculated
        /// from.
        /// </summary>
        member val origin: U2<Google.Maps.LatLng, Google.Maps.LatLngLiteral> option = nativeOnly with get, set
        /// The radius of the area used for prediction biasing. The
        /// &lt;code&gt;radius&lt;/code&gt; is specified in meters, and must always be
        /// accompanied by a &lt;code&gt;location&lt;/code&gt; property. Alternatively,
        /// &lt;code&gt;bounds&lt;/code&gt; can be used.
        [<Obsolete("<code>radius</code> is deprecated as of May 2023. Use {@link  *     google.maps.places.AutocompletionRequest.locationBias} and {@link  *     google.maps.places.AutocompletionRequest.locationRestriction}
instead."       )>]
        member val radius: float option = nativeOnly with get, set
        /// <summary>
        /// A region code which is used for result formatting and for result
        /// filtering. It does not restrict the suggestions to this country. The
        /// region code accepts a &lt;a
        /// href="<see href="https://en.wikipedia.org/wiki/List_of_Internet_top-level_domains#Country_code_top-level_domains"&gt;ccTLD" />
        /// (&amp;quot;top-level domain&amp;quot;)&lt;/a&gt; two-character value. Most ccTLD codes
        /// are identical to ISO 3166-1 codes, with some notable exceptions. For
        /// example, the United Kingdom&amp;#39;s ccTLD is &amp;quot;uk&amp;quot;
        /// (&lt;code&gt;.co.uk&lt;/code&gt;) while its ISO 3166-1 code is &amp;quot;gb&amp;quot;
        /// (technically for the entity of &amp;quot;The United Kingdom of Great Britain
        /// and Northern Ireland&amp;quot;).
        /// </summary>
        member val region: string option = nativeOnly with get, set
        /// Unique reference used to bundle individual requests into sessions.
        member val sessionToken: Google.Maps.Places.AutocompleteSessionToken option = nativeOnly with get, set
        /// <summary>
        /// The types of predictions to be returned. For supported types, see the &lt;a
        /// href="<see href="https://developers.google.com/maps/documentation/javascript/places-autocomplete#constrain-place-types"&gt;" />
        /// developer&amp;#39;s guide&lt;/a&gt;. If no types are specified, all types will be
        /// returned.
        /// </summary>
        member val types: ResizeArray<string> option = nativeOnly with get, set

    /// <summary>
    /// The operational status of the Place, if it is a business, returned in a
    /// PlaceResult (indicates whether the place is operational, or closed either
    /// temporarily or permanently). Specify these by value, or the constant&amp;#39;s
    /// name (example: &lt;code&gt;&amp;#39;OPERATIONAL&amp;#39;&lt;/code&gt; or
    /// &lt;code&gt;google.maps.places.BusinessStatus.OPERATIONAL&lt;/code&gt;).
    ///
    /// Access by calling `const {BusinessStatus} = await
    /// google.maps.importLibrary("places")`. See
    /// <see href="https://developers.google.com/maps/documentation/javascript/libraries." />
    /// </summary>
    type [<StringEnum>] [<RequireQualifiedAccess>] BusinessStatus =
        /// The business is closed permanently.
        | [<CompiledName("CLOSED_PERMANENTLY")>] CLOSED_PERMANENTLY
        /// The business is closed temporarily.
        | [<CompiledName("CLOSED_TEMPORARILY")>] CLOSED_TEMPORARILY
        /// The business is operating normally.
        | [<CompiledName("OPERATIONAL")>] OPERATIONAL

    /// Defines the component restrictions that can be used with the autocomplete
    /// service.
    /// [<AllowNullLiteral>]
    [<Global>]
    [<AllowNullLiteral>]
    type ComponentRestrictions
        [<ParamObject; Emit("$0")>]
        () =

        [<ParamObject; Emit("$0")>]
        new (?country: string) =
            ComponentRestrictions()

        [<ParamObject; Emit("$0")>]
        new (?country: ResizeArray<string>) =
            ComponentRestrictions()

        /// Restricts predictions to the specified country (ISO 3166-1 Alpha-2
        /// country code, case insensitive). For example, &lt;code&gt;'us'&lt;/code&gt;,
        /// &lt;code&gt;'br'&lt;/code&gt;, or &lt;code&gt;'au'&lt;/code&gt;. You can provide a single one, or
        /// an array of up to five country code strings.
        member val country: U2<string, ResizeArray<string>> option = jsNative with get, set

    /// <summary>
    /// Available only in the v=beta channel: <see href="https://goo.gle/3oAthT3." />
    ///
    /// Options for fetching Place fields.
    /// </summary>
    type [<AllowNullLiteral>] FetchFieldsRequest =
        /// List of fields to be fetched.
        abstract fields: ResizeArray<string> with get, set
        /// Unique reference used to bundle the details request with an autocomplete
        /// session.
        abstract sessionToken: Google.Maps.Places.AutocompleteSessionToken option with get, set

    /// <summary>A find place from text search request to be sent to <see cref="*">google.maps.places.PlacesService.findPlaceFromPhoneNumber</see>.</summary>
    type [<AllowNullLiteral>] FindPlaceFromPhoneNumberRequest =
        /// <summary>
        /// Fields to be included in the response, &lt;a
        /// href="<see href="https://developers.google.com/maps/billing/understanding-cost-of-use#places-product"&gt;which" />
        /// will be billed for&lt;/a&gt;. If &lt;code&gt;[&amp;#39;ALL&amp;#39;]&lt;/code&gt; is passed in, all
        /// available fields will be returned and billed for (this is not recommended
        /// for production deployments). For a list of fields see <see cref="*">google.maps.places.PlaceResult</see>. Nested fields can be specified with
        /// dot-paths (for example, &lt;code&gt;"geometry.location"&lt;/code&gt;).
        /// </summary>
        abstract fields: ResizeArray<string> with get, set
        /// <summary>
        /// A language identifier for the language in which names and addresses
        /// should be returned, when possible. See the &lt;a
        /// href="<see href="https://developers.google.com/maps/faq#languagesupport"&gt;list" /> of
        /// supported languages&lt;/a&gt;.
        /// </summary>
        abstract language: string option with get, set
        /// <summary>
        /// The bias used when searching for Place. The result will be biased
        /// towards, but not restricted to, the given <see cref="*">google.maps.places.LocationBias</see>.
        /// </summary>
        abstract locationBias: U7<Google.Maps.LatLng, Google.Maps.LatLngLiteral, Google.Maps.LatLngBounds, Google.Maps.LatLngBoundsLiteral, Google.Maps.Circle, Google.Maps.CircleLiteral, string> option with get, set
        /// <summary>
        /// The phone number of the place to look up. Format must be &lt;a
        /// href="<see href="https://en.wikipedia.org/wiki/E.164"&gt;E.164&lt;/a&gt;." />
        /// </summary>
        abstract phoneNumber: string with get, set

    /// <summary>A find place from text search request to be sent to <see cref="*">google.maps.places.PlacesService.findPlaceFromQuery</see>.</summary>
    type [<AllowNullLiteral>] FindPlaceFromQueryRequest =
        /// <summary>
        /// Fields to be included in the response, &lt;a
        /// href="<see href="https://developers.google.com/maps/billing/understanding-cost-of-use#places-product"&gt;which" />
        /// will be billed for&lt;/a&gt;. If &lt;code&gt;[&amp;#39;ALL&amp;#39;]&lt;/code&gt; is passed in, all
        /// available fields will be returned and billed for (this is not recommended
        /// for production deployments). For a list of fields see <see cref="*">google.maps.places.PlaceResult</see>. Nested fields can be specified with
        /// dot-paths (for example, &lt;code&gt;"geometry.location"&lt;/code&gt;).
        /// </summary>
        abstract fields: ResizeArray<string> with get, set
        /// <summary>
        /// A language identifier for the language in which names and addresses
        /// should be returned, when possible. See the &lt;a
        /// href="<see href="https://developers.google.com/maps/faq#languagesupport"&gt;list" /> of
        /// supported languages&lt;/a&gt;.
        /// </summary>
        abstract language: string option with get, set
        /// <summary>
        /// The bias used when searching for Place. The result will be biased
        /// towards, but not restricted to, the given <see cref="*">google.maps.places.LocationBias</see>.
        /// </summary>
        abstract locationBias: U7<Google.Maps.LatLng, Google.Maps.LatLngLiteral, Google.Maps.LatLngBounds, Google.Maps.LatLngBoundsLiteral, Google.Maps.Circle, Google.Maps.CircleLiteral, string> option with get, set
        /// The request&#39;s query. For example, the name or address of a place.
        abstract query: string with get, set

    type LocationBias =
        U7<Google.Maps.LatLng, Google.Maps.LatLngLiteral, Google.Maps.LatLngBounds, Google.Maps.LatLngBoundsLiteral, Google.Maps.Circle, Google.Maps.CircleLiteral, string>

    type LocationRestriction =
        U2<Google.Maps.LatLngBounds, Google.Maps.LatLngBoundsLiteral>

    /// <summary>
    /// Available only in the v=beta channel: <see href="https://goo.gle/3oAthT3." />
    ///
    ///
    /// Access by calling `const {OpeningHours} = await
    /// google.maps.importLibrary("places")`. See
    /// <see href="https://developers.google.com/maps/documentation/javascript/libraries." />
    /// </summary>
    type [<AllowNullLiteral>] OpeningHours =
        /// Opening periods covering each day of the week, starting from Sunday, in
        /// chronological order. Does not include days where the Place is not open.
        abstract periods: ResizeArray<Google.Maps.Places.OpeningHoursPeriod> with get, set
        /// An array of seven strings representing the formatted opening hours for
        /// each day of the week. The Places Service will format and localize the
        /// opening hours appropriately for the current language. The ordering of the
        /// elements in this array depends on the language. Some languages start the
        /// week on Monday, while others start on Sunday.
        abstract weekdayDescriptions: ResizeArray<string> with get, set

    /// <summary>
    /// Available only in the v=beta channel: <see href="https://goo.gle/3oAthT3." />
    ///
    ///
    /// Access by calling `const {OpeningHours} = await
    /// google.maps.importLibrary("places")`. See
    /// <see href="https://developers.google.com/maps/documentation/javascript/libraries." />
    /// </summary>
    type [<AllowNullLiteral>] OpeningHoursStatic =
        [<EmitConstructor>] abstract Create: unit -> OpeningHours

    /// <summary>
    /// Available only in the v=beta channel: <see href="https://goo.gle/3oAthT3." />
    ///
    ///
    /// Access by calling `const {OpeningHoursPeriod} = await
    /// google.maps.importLibrary("places")`. See
    /// <see href="https://developers.google.com/maps/documentation/javascript/libraries." />
    /// </summary>
    type [<AllowNullLiteral>] OpeningHoursPeriod =
        /// The closing time for the Place.
        abstract close: Google.Maps.Places.OpeningHoursPoint option with get, set
        /// The opening time for the Place.
        abstract ``open``: Google.Maps.Places.OpeningHoursPoint with get, set

    /// <summary>
    /// Available only in the v=beta channel: <see href="https://goo.gle/3oAthT3." />
    ///
    ///
    /// Access by calling `const {OpeningHoursPeriod} = await
    /// google.maps.importLibrary("places")`. See
    /// <see href="https://developers.google.com/maps/documentation/javascript/libraries." />
    /// </summary>
    type [<AllowNullLiteral>] OpeningHoursPeriodStatic =
        [<EmitConstructor>] abstract Create: unit -> OpeningHoursPeriod

    /// <summary>
    /// Available only in the v=beta channel: <see href="https://goo.gle/3oAthT3." />
    ///
    ///
    /// Access by calling `const {OpeningHoursPoint} = await
    /// google.maps.importLibrary("places")`. See
    /// <see href="https://developers.google.com/maps/documentation/javascript/libraries." />
    /// </summary>
    type [<AllowNullLiteral>] OpeningHoursPoint =
        /// The day of the week, as a number in the range [0, 6], starting on Sunday.
        /// For example, 2 means Tuesday.
        abstract day: float with get, set
        /// The hour of the OpeningHoursPoint.time as a number, in the range [0, 23].
        /// This will be reported in the Place’s time zone.
        abstract hour: float with get, set
        /// The minute of the OpeningHoursPoint.time as a number, in the range [0,
        /// 59]. This will be reported in the Place’s time zone.
        abstract minute: float with get, set

    /// <summary>
    /// Available only in the v=beta channel: <see href="https://goo.gle/3oAthT3." />
    ///
    ///
    /// Access by calling `const {OpeningHoursPoint} = await
    /// google.maps.importLibrary("places")`. See
    /// <see href="https://developers.google.com/maps/documentation/javascript/libraries." />
    /// </summary>
    type [<AllowNullLiteral>] OpeningHoursPointStatic =
        [<EmitConstructor>] abstract Create: unit -> OpeningHoursPoint

    /// <summary>
    /// Available only in the v=beta channel: <see href="https://goo.gle/3oAthT3." />
    ///
    ///
    /// Access by calling `const {Photo} = await
    /// google.maps.importLibrary("places")`. See
    /// <see href="https://developers.google.com/maps/documentation/javascript/libraries." />
    /// </summary>
    type [<AllowNullLiteral>] Photo =
        /// Attribution text to be displayed for this photo.
        abstract authorAttributions: ResizeArray<Google.Maps.Places.AuthorAttribution> with get, set
        /// Returns the image URL corresponding to the specified options.
        abstract getURI: ?options: Google.Maps.Places.PhotoOptions -> string
        /// The height of the photo in pixels.
        abstract heightPx: float with get, set
        /// The width of the photo in pixels.
        abstract widthPx: float with get, set

    /// <summary>
    /// Available only in the v=beta channel: <see href="https://goo.gle/3oAthT3." />
    ///
    ///
    /// Access by calling `const {Photo} = await
    /// google.maps.importLibrary("places")`. See
    /// <see href="https://developers.google.com/maps/documentation/javascript/libraries." />
    /// </summary>
    type [<AllowNullLiteral>] PhotoStatic =
        [<EmitConstructor>] abstract Create: unit -> Photo

    /// Defines photo-requesting options.
    type [<AllowNullLiteral>] PhotoOptions =
        /// The maximum height in pixels of the returned image.
        abstract maxHeight: float option with get, set
        /// The maximum width in pixels of the returned image.
        abstract maxWidth: float option with get, set

    /// <summary>
    /// Available only in the v=beta channel: <see href="https://goo.gle/3oAthT3." />
    ///
    ///
    /// Access by calling `const {Place} = await
    /// google.maps.importLibrary("places")`. See
    /// <see href="https://developers.google.com/maps/documentation/javascript/libraries." />
    /// </summary>
    type [<AllowNullLiteral>] Place =
        /// The collection of address components for this Place’s location. Empty
        /// object if there is no known address data. &lt;code&gt;undefined&lt;/code&gt; if the
        /// address data has not been called for from the server.
        abstract addressComponents: ResizeArray<Google.Maps.Places.AddressComponent> option with get, set
        /// <summary>
        /// The representation of the Place’s address in the &lt;a
        /// href="<see href="http://microformats.org/wiki/adr"&gt;adr" /> microformat&lt;/a&gt;.
        /// </summary>
        abstract adrFormatAddress: string option with get, set
        /// Attribution text to be displayed for this Place result.
        abstract attributions: ResizeArray<Google.Maps.Places.Attribution> option with get, set
        /// The location&amp;#39;s operational status. &lt;code&gt;null&lt;/code&gt; if there is no
        /// known status. &lt;code&gt;undefined&lt;/code&gt; if the status data has not been
        /// loaded from the server.
        abstract businessStatus: Google.Maps.Places.BusinessStatus option with get, set
        /// The location&amp;#39;s display name. &lt;code&gt;null&lt;/code&gt; if there is no name.
        /// &lt;code&gt;undefined&lt;/code&gt; if the name data has not been loaded from the
        /// server.
        abstract displayName: string option with get, set
        /// <summary>Available only in the v=beta channel: <see href="https://goo.gle/3oAthT3." /></summary>
        abstract fetchFields: options: Google.Maps.Places.FetchFieldsRequest -> Promise<{| place: Google.Maps.Places.Place |}>
        /// The locations’s full address.
        abstract formattedAddress: string option with get, set
        /// <summary>
        /// Available only in the v=beta channel: <see href="https://goo.gle/3oAthT3." />
        /// Calculates the Date representing the next OpeningHoursTime. Returns
        /// undefined if the data is insufficient to calculate the result, or this
        /// place is not operational.
        /// </summary>
        abstract getNextOpeningTime: ?date: DateTime -> Promise<DateTime option>
        /// URL of the official Google page for this place. This is the Google-owned
        /// page that contains the best available information about the Place.
        abstract googleMapsURI: string option with get, set
        /// Whether a place has curbside pickup. Returns &#39;true&#39; or
        /// &#39;false&#39; if the value is known. Returns &#39;null&#39; if the
        /// value is unknown. Returns &#39;undefined&#39; if this field has not yet
        /// been requested.
        abstract hasCurbsidePickup: bool option with get, set
        /// Whether a place has delivery. Returns &#39;true&#39; or &#39;false&#39;
        /// if the value is known. Returns &#39;null&#39; if the value is unknown.
        /// Returns
        /// &#39;undefined&#39; if this field has not yet been requested.
        abstract hasDelivery: bool option with get, set
        /// Whether a place has dine in. Returns &#39;true&#39; or &#39;false&#39; if
        /// the value is known. Returns &#39;null&#39; if the value is unknown.
        /// Returns
        /// &#39;undefined&#39; if this field has not yet been requested.
        abstract hasDineIn: bool option with get, set
        /// Whether a place has takeout. Returns &#39;true&#39; or &#39;false&#39; if
        /// the value is known. Returns &#39;null&#39; if the value is unknown.
        /// Returns
        /// &#39;undefined&#39; if this field has not yet been requested.
        abstract hasTakeout: bool option with get, set
        /// Whether a place has a wheelchair accessible entrance. Returns
        /// &#39;true&#39; or &#39;false&#39; if the value is known. Returns
        /// &#39;null&#39; if the value is unknown. Returns &#39;undefined&#39; if
        /// this field has not yet been requested.
        abstract hasWheelchairAccessibleEntrance: bool option with get, set
        /// The default HEX color code for the place&#39;s category.
        abstract iconBackgroundColor: string option with get, set
        /// The unique place id.
        abstract id: string with get, set
        /// The Place’s phone number in international format. International format
        /// includes the country code, and is prefixed with the plus (+) sign.
        abstract internationalPhoneNumber: string option with get, set
        /// <summary>
        /// Available only in the v=beta channel: <see href="https://goo.gle/3oAthT3." />
        /// Check if the place is open at the given datetime. Resolves with
        /// &lt;code&gt;undefined&lt;/code&gt; if the known data for the location is insufficient
        /// to calculate this, e.g. if the opening hours are unregistered.
        /// </summary>
        /// <param name="date">Defaults to now.</param>
        abstract isOpen: ?date: DateTime -> Promise<bool option>
        /// Whether a place is reservable. Returns &#39;true&#39; or &#39;false&#39;
        /// if the value is known. Returns &#39;null&#39; if the value is unknown.
        /// Returns
        /// &#39;undefined&#39; if this field has not yet been requested.
        abstract isReservable: bool option with get, set
        /// The Place’s position.
        abstract location: Google.Maps.LatLng option with get, set
        /// <summary>
        /// The Place’s phone number, formatted according to the &lt;a
        /// href="<see href="http://en.wikipedia.org/wiki/Local_conventions_for_writing_telephone_numbers"&gt;number&amp;#39;s" />
        /// regional convention&lt;/a&gt;.
        /// </summary>
        abstract nationalPhoneNumber: string option with get, set
        abstract openingHours: Google.Maps.Places.OpeningHours option with get, set
        /// <summary>Photos of this Place. The collection will contain up to ten <see cref="*">google.maps.places.Photo</see> objects.</summary>
        abstract photos: ResizeArray<Google.Maps.Places.Photo> option with get, set
        abstract plusCode: Google.Maps.Places.PlusCode option with get, set
        /// The price level of the Place. This property can return any of the
        /// following values &lt;ul style="list-style-type: none;"&gt;
        /// &lt;li&gt;&lt;code&gt;Free&lt;/code&gt;&lt;/li&gt; &lt;li&gt;&lt;code&gt;Inexpensive&lt;/code&gt;&lt;/li&gt;
        /// &lt;li&gt;&lt;code&gt;Moderate&lt;/code&gt;&lt;/li&gt; &lt;li&gt;&lt;code&gt;Expensive&lt;/code&gt;&lt;/li&gt;
        /// &lt;li&gt;&lt;code&gt;Very Expensive&lt;/code&gt;&lt;/li&gt; &lt;/ul&gt;
        abstract priceLevel: Google.Maps.Places.PriceLevel option with get, set
        /// A rating, between 1.0 to 5.0, based on user reviews of this Place.
        abstract rating: float option with get, set
        /// The requested language for this place.
        abstract requestedLanguage: string option with get, set
        /// The requested region for this place.
        abstract requestedRegion: string option with get, set
        /// A list of reviews for this Place.
        abstract reviews: ResizeArray<Google.Maps.Places.Review> option with get, set
        /// Whether a place serves beer. Returns &#39;true&#39; or &#39;false&#39; if
        /// the value is known. Returns &#39;null&#39; if the value is unknown.
        /// Returns
        /// &#39;undefined&#39; if this field has not yet been requested.
        abstract servesBeer: bool option with get, set
        /// Whether a place serves breakfast. Returns &#39;true&#39; or
        /// &#39;false&#39; if the value is known. Returns &#39;null&#39; if the
        /// value is unknown. Returns &#39;undefined&#39; if this field has not yet
        /// been requested.
        abstract servesBreakfast: bool option with get, set
        /// Whether a place serves brunch. Returns &#39;true&#39; or &#39;false&#39;
        /// if the value is known. Returns &#39;null&#39; if the value is unknown.
        /// Returns
        /// &#39;undefined&#39; if this field has not yet been requested.
        abstract servesBrunch: bool option with get, set
        /// Whether a place serves dinner. Returns &#39;true&#39; or &#39;false&#39;
        /// if the value is known. Returns &#39;null&#39; if the value is unknown.
        /// Returns
        /// &#39;undefined&#39; if this field has not yet been requested.
        abstract servesDinner: bool option with get, set
        /// Whether a place serves lunch. Returns &#39;true&#39; or &#39;false&#39;
        /// if the value is known. Returns &#39;null&#39; if the value is unknown.
        /// Returns
        /// &#39;undefined&#39; if this field has not yet been requested.
        abstract servesLunch: bool option with get, set
        /// Whether a place serves vegetarian food. Returns &#39;true&#39; or
        /// &#39;false&#39; if the value is known. Returns &#39;null&#39; if the
        /// value is unknown. Returns &#39;undefined&#39; if this field has not yet
        /// been requested.
        abstract servesVegetarianFood: bool option with get, set
        /// Whether a place serves wine. Returns &#39;true&#39; or &#39;false&#39; if
        /// the value is known. Returns &#39;null&#39; if the value is unknown.
        /// Returns
        /// &#39;undefined&#39; if this field has not yet been requested.
        abstract servesWine: bool option with get, set
        /// URI to the svg image mask resource that can be used to represent a
        /// place’s category.
        abstract svgIconMaskURI: string option with get, set
        abstract toJSON: unit -> obj
        /// <summary>
        /// An array of &lt;a
        /// href="<see href="https://developers.google.com/maps/documentation/places/web-service/supported_types"&gt;types" />
        /// for this Place&lt;/a&gt; (for example, &lt;code&gt;[&amp;quot;political&amp;quot;,
        /// &amp;quot;locality&amp;quot;]&lt;/code&gt; or &lt;code&gt;[&amp;quot;restaurant&amp;quot;,
        /// &amp;quot;establishment&amp;quot;]&lt;/code&gt;).
        /// </summary>
        abstract types: ResizeArray<string> option with get, set
        /// <summary>The number of user ratings which contributed to this Place’s <see cref="*">google.maps.places.Place.rating</see>.</summary>
        abstract userRatingCount: float option with get, set
        /// The offset from UTC of the Place’s current timezone, in minutes. For
        /// example, Austrialian Eastern Standard Time (GMT+10) in daylight savings
        /// is 11 hours ahead of UTC, so the &lt;code&gt;utc_offset_minutes&lt;/code&gt; will be
        /// &lt;code&gt;660&lt;/code&gt;. For timezones behind UTC, the offset is negative. For
        /// example, the &lt;code&gt;utc_offset_minutes&lt;/code&gt; is &lt;code&gt;-60&lt;/code&gt; for Cape
        /// Verde.
        abstract utcOffsetMinutes: float option with get, set
        /// The preferred viewport when displaying this Place on a map.
        abstract viewport: Google.Maps.LatLngBounds option with get, set
        /// The authoritative website for this Place, such as a business&#39;
        /// homepage.
        abstract websiteURI: string option with get, set

    /// <summary>
    /// Available only in the v=beta channel: <see href="https://goo.gle/3oAthT3." />
    ///
    ///
    /// Access by calling `const {Place} = await
    /// google.maps.importLibrary("places")`. See
    /// <see href="https://developers.google.com/maps/documentation/javascript/libraries." />
    /// </summary>
    type [<AllowNullLiteral>] PlaceStatic =
        /// <summary>
        /// Available only in the v=beta channel: <see href="https://goo.gle/3oAthT3." />
        ///
        ///
        /// Access by calling `const {Place} = await
        /// google.maps.importLibrary("places")`. See
        /// <see href="https://developers.google.com/maps/documentation/javascript/libraries." />
        /// </summary>
        [<EmitConstructor>] abstract Create: options: Google.Maps.Places.PlaceOptions -> Place
        /// <summary>
        /// Available only in the v=beta channel: <see href="https://goo.gle/3oAthT3." />
        /// Searches for a place based on the given phone number. Returns an array
        /// due to rare cases where multiple places may share a phone number.
        /// </summary>
        /// <param name="request">
        /// The request containing the phone number and requested
        /// fields.
        /// </param>
        abstract findPlaceFromPhoneNumber: this: obj option * request: Google.Maps.Places.FindPlaceFromPhoneNumberRequest -> Promise<{| places: ResizeArray<Google.Maps.Places.Place> |}>
        /// <summary>
        /// Available only in the v=beta channel: <see href="https://goo.gle/3oAthT3." />
        /// Searches for a place based on the given text query. Returns an array due
        /// to cases where the query is mildly ambiguous, and more than one place
        /// gets returned. This method is &lt;em&gt;not&lt;/em&gt; intended for searches where
        /// multiple results are expected.
        /// </summary>
        /// <param name="request">
        /// The request containing the text query and requested
        /// fields.
        /// </param>
        abstract findPlaceFromQuery: this: obj option * request: Google.Maps.Places.FindPlaceFromQueryRequest -> Promise<{| places: ResizeArray<Google.Maps.Places.Place> |}>
        /// <summary>
        /// Available only in the v=beta channel: <see href="https://goo.gle/3oAthT3." />
        /// Text query based place search.
        /// </summary>
        abstract searchByText: this: obj option * request: Google.Maps.Places.SearchByTextRequest -> Promise<{| places: ResizeArray<Google.Maps.Places.Place> |}>

    /// Defines information about an aspect of the place that users have reviewed.
    [<Obsolete("This interface is no longer used.")>]
    type [<AllowNullLiteral>] PlaceAspectRating =
        /// The rating of this aspect. For individual reviews this is an integer from
        /// 0 to 3. For aggregated ratings of a place this is an integer from 0
        /// to 30.
        abstract rating: float with get, set
        /// The aspect type. For example, &lt;code&gt;"food"&lt;/code&gt;, &lt;code&gt;"decor"&lt;/code&gt;,
        /// &lt;code&gt;"service"&lt;/code&gt;, or &lt;code&gt;"overall"&lt;/code&gt;.
        abstract ``type``: string with get, set

    /// <summary>
    /// Available only in the v=alpha channel: <see href="https://goo.gle/js-alpha-channel." />
    ///
    /// &lt;ul&gt;
    /// &lt;li&gt;PlaceAutocompleteElement is an &lt;code&gt;HTMLElement&lt;/code&gt; subclass which
    /// provides a UI component for the Places Autocomplete API. After loading the
    /// &lt;code&gt;places&lt;/code&gt; library, an input with autocomplete functionality can
    /// be created in HTML. For example: &lt;pre&gt;&lt;code&gt;&amp;lt;gmp-placeautocomplete
    /// &amp;gt;&amp;lt;/gmp-placeautocomplete&amp;gt;&lt;/code&gt;&lt;/pre&gt;&lt;/li&gt;
    /// &lt;/ul&gt;
    ///
    /// Access by calling `const {PlaceAutocompleteElement} = await
    /// google.maps.importLibrary("places")`. See
    /// <see href="https://developers.google.com/maps/documentation/javascript/libraries." />
    /// </summary>
    type [<AllowNullLiteral>] PlaceAutocompleteElement =
        inherit HTMLElement
        inherit Google.Maps.Places.PlaceAutocompleteElementOptions
        /// The component restrictions. Component restrictions are used to restrict
        /// predictions to only those within the parent component. For example, the
        /// country.
        abstract componentRestrictions: Google.Maps.Places.ComponentRestrictions option with get, set
        /// The input element to show autocompletions for.
        abstract inputElement: HTMLInputElement with get, set
        /// A soft boundary or hint to use when searching for places.
        abstract locationBias: U7<Google.Maps.LatLng, Google.Maps.LatLngLiteral, Google.Maps.LatLngBounds, Google.Maps.LatLngBoundsLiteral, Google.Maps.Circle, Google.Maps.CircleLiteral, string> option with get, set
        /// Bounds to constrain search results.
        abstract locationRestriction: U2<Google.Maps.LatLngBounds, Google.Maps.LatLngBoundsLiteral> option with get, set
        /// <summary>
        /// A language identifier for the language in which the results should be
        /// returned, if possible. Results in the selected language may be given a
        /// higher ranking, but suggestions are not restricted to this language. See
        /// the &lt;a href="<see href="https://developers.google.com/maps/faq#languagesupport"&gt;list" />
        /// of supported languages&lt;/a&gt;.
        /// </summary>
        abstract requestedLanguage: string option with get, set
        /// <summary>
        /// A region code which is used for result formatting and for result
        /// filtering. It does not restrict the suggestions to this country. The
        /// region code accepts a &lt;a
        /// href="<see href="https://en.wikipedia.org/wiki/List_of_Internet_top-level_domains#Country_code_top-level_domains"&gt;ccTLD" />
        /// (&amp;quot;top-level domain&amp;quot;)&lt;/a&gt; two-character value. Most ccTLD codes
        /// are identical to ISO 3166-1 codes, with some notable exceptions. For
        /// example, the United Kingdom&amp;#39;s ccTLD is &amp;quot;uk&amp;quot;
        /// (&lt;code&gt;.co.uk&lt;/code&gt;) while its ISO 3166-1 code is &amp;quot;gb&amp;quot;
        /// (technically for the entity of &amp;quot;The United Kingdom of Great Britain
        /// and Northern Ireland&amp;quot;).
        /// </summary>
        abstract requestedRegion: string option with get, set
        /// <summary>
        /// The types of predictions to be returned. For supported types, see the &lt;a
        /// href="<see href="https://developers.google.com/maps/documentation/javascript/places-autocomplete#constrain-place-types"&gt;" />
        /// developer&amp;#39;s guide&lt;/a&gt;. If no types are specified, all types will be
        /// returned.
        /// </summary>
        abstract types: ResizeArray<string> option with get, set

    /// <summary>
    /// Available only in the v=alpha channel: <see href="https://goo.gle/js-alpha-channel." />
    ///
    /// &lt;ul&gt;
    /// &lt;li&gt;PlaceAutocompleteElement is an &lt;code&gt;HTMLElement&lt;/code&gt; subclass which
    /// provides a UI component for the Places Autocomplete API. After loading the
    /// &lt;code&gt;places&lt;/code&gt; library, an input with autocomplete functionality can
    /// be created in HTML. For example: &lt;pre&gt;&lt;code&gt;&amp;lt;gmp-placeautocomplete
    /// &amp;gt;&amp;lt;/gmp-placeautocomplete&amp;gt;&lt;/code&gt;&lt;/pre&gt;&lt;/li&gt;
    /// &lt;/ul&gt;
    ///
    /// Access by calling `const {PlaceAutocompleteElement} = await
    /// google.maps.importLibrary("places")`. See
    /// <see href="https://developers.google.com/maps/documentation/javascript/libraries." />
    /// </summary>
    type [<AllowNullLiteral>] PlaceAutocompleteElementStatic =
        /// <summary>
        /// Available only in the v=alpha channel: <see href="https://goo.gle/js-alpha-channel." />
        ///
        /// &lt;ul&gt;
        /// &lt;li&gt;PlaceAutocompleteElement is an &lt;code&gt;HTMLElement&lt;/code&gt; subclass
        /// which provides a UI component for the Places Autocomplete API. After
        /// loading the &lt;code&gt;places&lt;/code&gt; library, an input with autocomplete
        /// functionality can be created in HTML. For example:
        /// &lt;pre&gt;&lt;code&gt;&amp;lt;gmp-placeautocomplete
        /// &amp;gt;&amp;lt;/gmp-placeautocomplete&amp;gt;&lt;/code&gt;&lt;/pre&gt;&lt;/li&gt;
        /// &lt;/ul&gt;
        ///
        /// Access by calling `const {PlaceAutocompleteElement} = await
        /// google.maps.importLibrary("places")`. See
        /// <see href="https://developers.google.com/maps/documentation/javascript/libraries." />
        /// </summary>
        [<EmitConstructor>] abstract Create: options: Google.Maps.Places.PlaceAutocompleteElementOptions -> PlaceAutocompleteElement

    /// <summary>
    /// Available only in the v=alpha channel: <see href="https://goo.gle/js-alpha-channel." />
    ///
    /// Options for constructing a PlaceAutocompleteElement.
    /// </summary>
    type [<AllowNullLiteral>] PlaceAutocompleteElementOptions =
        /// The component restrictions. Component restrictions are used to restrict
        /// predictions to only those within the parent component. For example, the
        /// country.
        abstract componentRestrictions: Google.Maps.Places.ComponentRestrictions option with get, set
        /// The input element to show autocompletions for.
        abstract inputElement: HTMLInputElement with get, set
        /// A soft boundary or hint to use when searching for places.
        abstract locationBias: U7<Google.Maps.LatLng, Google.Maps.LatLngLiteral, Google.Maps.LatLngBounds, Google.Maps.LatLngBoundsLiteral, Google.Maps.Circle, Google.Maps.CircleLiteral, string> option with get, set
        /// Bounds to constrain search results.
        abstract locationRestriction: U2<Google.Maps.LatLngBounds, Google.Maps.LatLngBoundsLiteral> option with get, set
        /// <summary>
        /// A language identifier for the language in which the results should be
        /// returned, if possible. Results in the selected language may be given a
        /// higher ranking, but suggestions are not restricted to this language. See
        /// the &lt;a href="<see href="https://developers.google.com/maps/faq#languagesupport"&gt;list" />
        /// of supported languages&lt;/a&gt;.
        /// </summary>
        abstract requestedLanguage: string option with get, set
        /// <summary>
        /// A region code which is used for result formatting and for result
        /// filtering. It does not restrict the suggestions to this country. The
        /// region code accepts a &lt;a
        /// href="<see href="https://en.wikipedia.org/wiki/List_of_Internet_top-level_domains#Country_code_top-level_domains"&gt;ccTLD" />
        /// (&amp;quot;top-level domain&amp;quot;)&lt;/a&gt; two-character value. Most ccTLD codes
        /// are identical to ISO 3166-1 codes, with some notable exceptions. For
        /// example, the United Kingdom&amp;#39;s ccTLD is &amp;quot;uk&amp;quot;
        /// (&lt;code&gt;.co.uk&lt;/code&gt;) while its ISO 3166-1 code is &amp;quot;gb&amp;quot;
        /// (technically for the entity of &amp;quot;The United Kingdom of Great Britain
        /// and Northern Ireland&amp;quot;).
        /// </summary>
        abstract requestedRegion: string option with get, set
        /// <summary>
        /// The types of predictions to be returned. For supported types, see the &lt;a
        /// href="<see href="https://developers.google.com/maps/documentation/javascript/places-autocomplete#constrain-place-types"&gt;" />
        /// developer&amp;#39;s guide&lt;/a&gt;. If no types are specified, all types will be
        /// returned.
        /// </summary>
        abstract types: ResizeArray<string> option with get, set

    /// <summary>
    /// Available only in the v=alpha channel: <see href="https://goo.gle/js-alpha-channel." />
    ///
    /// This event is created after the user selects a place with the Place
    /// Autocomplete Element. Access the selection with &lt;code&gt;event.place&lt;/code&gt;.
    ///
    /// Access by calling `const {PlaceAutocompletePlaceSelectEvent} = await
    /// google.maps.importLibrary("places")`. See
    /// <see href="https://developers.google.com/maps/documentation/javascript/libraries." />
    /// </summary>
    type [<AllowNullLiteral>] PlaceAutocompletePlaceSelectEvent =
        inherit Event

    /// <summary>
    /// Available only in the v=alpha channel: <see href="https://goo.gle/js-alpha-channel." />
    ///
    /// This event is created after the user selects a place with the Place
    /// Autocomplete Element. Access the selection with &lt;code&gt;event.place&lt;/code&gt;.
    ///
    /// Access by calling `const {PlaceAutocompletePlaceSelectEvent} = await
    /// google.maps.importLibrary("places")`. See
    /// <see href="https://developers.google.com/maps/documentation/javascript/libraries." />
    /// </summary>
    type [<AllowNullLiteral>] PlaceAutocompletePlaceSelectEventStatic =
        /// <summary>
        /// Available only in the v=alpha channel: <see href="https://goo.gle/js-alpha-channel." />
        ///
        /// This event is created after the user selects a place with the Place
        /// Autocomplete Element. Access the selection with &lt;code&gt;event.place&lt;/code&gt;.
        ///
        /// Access by calling `const {PlaceAutocompletePlaceSelectEvent} = await
        /// google.maps.importLibrary("places")`. See
        /// <see href="https://developers.google.com/maps/documentation/javascript/libraries." />
        /// </summary>
        [<EmitConstructor>] abstract Create: unit -> PlaceAutocompletePlaceSelectEvent

    /// <summary>
    /// Available only in the v=alpha channel: <see href="https://goo.gle/js-alpha-channel." />
    ///
    /// This event is emitted by the PlaceAutocompleteElement when there is an
    /// issue with the network request.
    ///
    /// Access by calling `const {PlaceAutocompleteRequestErrorEvent} = await
    /// google.maps.importLibrary("places")`. See
    /// <see href="https://developers.google.com/maps/documentation/javascript/libraries." />
    /// </summary>
    type [<AllowNullLiteral>] PlaceAutocompleteRequestErrorEvent =
        inherit Event

    /// <summary>
    /// Available only in the v=alpha channel: <see href="https://goo.gle/js-alpha-channel." />
    ///
    /// This event is emitted by the PlaceAutocompleteElement when there is an
    /// issue with the network request.
    ///
    /// Access by calling `const {PlaceAutocompleteRequestErrorEvent} = await
    /// google.maps.importLibrary("places")`. See
    /// <see href="https://developers.google.com/maps/documentation/javascript/libraries." />
    /// </summary>
    type [<AllowNullLiteral>] PlaceAutocompleteRequestErrorEventStatic =
        /// <summary>
        /// Available only in the v=alpha channel: <see href="https://goo.gle/js-alpha-channel." />
        ///
        /// This event is emitted by the PlaceAutocompleteElement when there is an
        /// issue with the network request.
        ///
        /// Access by calling `const {PlaceAutocompleteRequestErrorEvent} = await
        /// google.maps.importLibrary("places")`. See
        /// <see href="https://developers.google.com/maps/documentation/javascript/libraries." />
        /// </summary>
        [<EmitConstructor>] abstract Create: unit -> PlaceAutocompleteRequestErrorEvent

    /// A Place details query to be sent to the &lt;code&gt;PlacesService&lt;/code&gt;.
    type [<AllowNullLiteral; Global>] PlaceDetailsRequest

        [<ParamObject; Emit("$0")>]
        (
            placeId: string,
            ?fields: ResizeArray<string>,
            ?language: string,
            ?region: string,
            ?sessionToken: Google.Maps.Places.AutocompleteSessionToken
        ) =

        /// <summary>
        /// Fields to be included in the details response, &lt;a
        /// href="<see href="https://developers.google.com/maps/billing/understanding-cost-of-use#places-product"&gt;which" />
        /// will be billed for&lt;/a&gt;. If no fields are specified or
        /// &lt;code&gt;[&amp;#39;ALL&amp;#39;]&lt;/code&gt; is passed in, all available fields will be
        /// returned and billed for (this is not recommended for production
        /// deployments). For a list of fields see <see cref="*">google.maps.places.PlaceResult</see>. Nested fields can be specified with
        /// dot-paths (for example, &lt;code&gt;"geometry.location"&lt;/code&gt;).
        /// </summary>
        member val fields: ResizeArray<string> option = nativeOnly with get, set
        /// <summary>
        /// A language identifier for the language in which details should be
        /// returned. See the &lt;a
        /// href="<see href="https://developers.google.com/maps/faq#languagesupport"&gt;list" /> of
        /// supported languages&lt;/a&gt;.
        /// </summary>
        member val language: string option = nativeOnly with get, set
        /// The Place ID of the Place for which details are being requested.
        member val placeId: string = nativeOnly with get, set
        /// <summary>
        /// A region code of the user&amp;#39;s region. This can affect which photos may
        /// be returned, and possibly other things. The region code accepts a &lt;a
        /// href="<see href="https://en.wikipedia.org/wiki/List_of_Internet_top-level_domains#Country_code_top-level_domains"&gt;ccTLD" />
        /// (&amp;quot;top-level domain&amp;quot;)&lt;/a&gt; two-character value. Most ccTLD codes
        /// are identical to ISO 3166-1 codes, with some notable exceptions. For
        /// example, the United Kingdom&amp;#39;s ccTLD is &amp;quot;uk&amp;quot;
        /// (&lt;code&gt;.co.uk&lt;/code&gt;) while its ISO 3166-1 code is &amp;quot;gb&amp;quot;
        /// (technically for the entity of &amp;quot;The United Kingdom of Great Britain
        /// and Northern Ireland&amp;quot;).
        /// </summary>
        member val region: string option = nativeOnly with get, set
        /// Unique reference used to bundle the details request with an autocomplete
        /// session.
        member val sessionToken: Google.Maps.Places.AutocompleteSessionToken option = nativeOnly with get, set

    /// Defines information about the geometry of a Place.
    type [<AllowNullLiteral>] PlaceGeometry =
        /// The Place’s position.
        abstract location: Google.Maps.LatLng option with get, set
        /// <summary>
        /// The preferred viewport when displaying this Place on a map. This property
        /// will be &lt;code&gt;null&lt;/code&gt; if the preferred viewport for the Place is not
        /// known. Only available with <see cref="*">google.maps.places.PlacesService.getDetails</see>.
        /// </summary>
        abstract viewport: Google.Maps.LatLngBounds option with get, set

    /// Defines information about the opening hours of a Place.
    type [<AllowNullLiteral>] PlaceOpeningHours =
        /// <summary>
        /// Check whether the place is open now (when no date is passed), or at the
        /// given date. If this place does not have <see cref="*">google.maps.places.PlaceResult.utc_offset_minutes</see> or <see cref="*">google.maps.places.PlaceOpeningHours.periods</see> then &lt;code&gt;undefined&lt;/code&gt;
        /// is returned (<see cref="google.maps.places.PlaceOpeningHours.periods" /> is only
        /// available via <see cref="google.maps.places.PlacesService.getDetails" />). This
        /// method does not take exceptional hours, such as holiday hours, into
        /// consideration.
        /// </summary>
        abstract isOpen: ?date: DateTime -> bool option
        /// Whether the Place is open at the current time.
        [<Obsolete("<code>open_now</code> is deprecated as of November 2019. Use
the {@link google.maps.places.PlaceOpeningHours.isOpen } method from
a {@link google.maps.places.PlacesService.getDetails } result instead.
See <a
href=\"https://goo.gle/js-open-now\">https://goo.gle/js-open-now</a>")>]
        abstract open_now: bool option with get, set
        /// <summary>
        /// Opening periods covering for each day of the week, starting from Sunday,
        /// in chronological order. Days in which the Place is not open are not
        /// included. Only available with <see cref="*">google.maps.places.PlacesService.getDetails</see>.
        /// </summary>
        abstract periods: ResizeArray<Google.Maps.Places.PlaceOpeningHoursPeriod> option with get, set
        /// <summary>
        /// An array of seven strings representing the formatted opening hours for
        /// each day of the week. The Places Service will format and localize the
        /// opening hours appropriately for the current language. The ordering of the
        /// elements in this array depends on the language. Some languages start the
        /// week on Monday while others start on Sunday. Only available with <see cref="*">google.maps.places.PlacesService.getDetails</see>. Other calls may return an
        /// empty array.
        /// </summary>
        abstract weekday_text: ResizeArray<string> option with get, set

    /// Defines structured information about the opening hours of a Place.
    /// &lt;strong&gt;Note:&lt;/strong&gt; If a Place is &lt;strong&gt;always open&lt;/strong&gt;, the
    /// &lt;code&gt;close&lt;/code&gt; section will be missing from the response. Clients can
    /// rely on always-open being represented as an &lt;code&gt;open&lt;/code&gt; period
    /// containing &lt;code&gt;day&lt;/code&gt; with value &lt;code&gt;0&lt;/code&gt; and &lt;code&gt;time&lt;/code&gt;
    /// with value &lt;code&gt;"0000"&lt;/code&gt;, and no &lt;code&gt;close&lt;/code&gt;.&lt;/li&gt;
    type [<AllowNullLiteral>] PlaceOpeningHoursPeriod =
        /// The closing time for the Place.
        abstract close: Google.Maps.Places.PlaceOpeningHoursTime option with get, set
        /// The opening time for the Place.
        abstract ``open``: Google.Maps.Places.PlaceOpeningHoursTime with get, set

    /// Defines when a Place opens or closes.
    type [<AllowNullLiteral>] PlaceOpeningHoursTime =
        /// The days of the week, as a number in the range [&lt;code&gt;0&lt;/code&gt;,
        /// &lt;code&gt;6&lt;/code&gt;], starting on Sunday. For example, &lt;code&gt;2&lt;/code&gt; means
        /// Tuesday.
        abstract day: float with get, set
        /// <summary>
        /// The hours of the <see cref="google.maps.places.PlaceOpeningHoursTime.time" /> as
        /// a number, in the range [&lt;code&gt;0&lt;/code&gt;, &lt;code&gt;23&lt;/code&gt;]. This will be
        /// reported in the Place’s time zone.
        /// </summary>
        abstract hours: float with get, set
        /// <summary>
        /// The minutes of the <see cref="google.maps.places.PlaceOpeningHoursTime.time" />
        /// as a number, in the range [&lt;code&gt;0&lt;/code&gt;, &lt;code&gt;59&lt;/code&gt;]. This will be
        /// reported in the Place’s time zone.
        /// </summary>
        abstract minutes: float with get, set
        /// <summary>
        /// The timestamp (as milliseconds since the epoch, suitable for use with
        /// &lt;code&gt;new Date()&lt;/code&gt;) representing the next occurrence of this
        /// PlaceOpeningHoursTime. It is calculated from the <see cref="*">google.maps.places.PlaceOpeningHoursTime.day</see> of week, the <see cref="*">google.maps.places.PlaceOpeningHoursTime.time</see>, and the <see cref="*">google.maps.places.PlaceResult.utc_offset_minutes</see>. If the <see cref="*">google.maps.places.PlaceResult.utc_offset_minutes</see> is
        /// &lt;code&gt;undefined&lt;/code&gt;, then &lt;code&gt;nextDate&lt;/code&gt; will be
        /// &lt;code&gt;undefined&lt;/code&gt;.
        /// </summary>
        abstract nextDate: float option with get, set
        /// The time of day in 24-hour &amp;quot;hhmm&amp;quot; format. Values are in the
        /// range
        /// [&lt;code&gt;"0000"&lt;/code&gt;, &lt;code&gt;"2359"&lt;/code&gt;]. The time will be reported in
        /// the Place’s time zone.
        abstract time: string with get, set

    /// <summary>
    /// Available only in the v=beta channel: <see href="https://goo.gle/3oAthT3." />
    ///
    /// Options for constructing a Place.
    /// </summary>
    type [<AllowNullLiteral>] PlaceOptions =
        /// The unique place id.
        abstract id: string with get, set
        /// <summary>
        /// A language identifier for the language in which details should be
        /// returned. See the &lt;a
        /// href="<see href="https://developers.google.com/maps/faq#languagesupport"&gt;list" /> of
        /// supported languages&lt;/a&gt;.
        /// </summary>
        abstract requestedLanguage: string option with get, set
        /// <summary>
        /// A region code of the user&amp;#39;s region. This can affect which photos may
        /// be returned, and possibly other things. The region code accepts a &lt;a
        /// href="<see href="https://en.wikipedia.org/wiki/List_of_Internet_top-level_domains#Country_code_top-level_domains"&gt;ccTLD" />
        /// (&amp;quot;top-level domain&amp;quot;)&lt;/a&gt; two-character value. Most ccTLD codes
        /// are identical to ISO 3166-1 codes, with some notable exceptions. For
        /// example, the United Kingdom&amp;#39;s ccTLD is &amp;quot;uk&amp;quot;
        /// (&lt;code&gt;.co.uk&lt;/code&gt;) while its ISO 3166-1 code is &amp;quot;gb&amp;quot;
        /// (technically for the entity of &amp;quot;The United Kingdom of Great Britain
        /// and Northern Ireland&amp;quot;).
        /// </summary>
        abstract requestedRegion: string option with get, set

    /// Represents a photo element of a Place.
    type [<AllowNullLiteral>] PlacePhoto =
        /// Returns the image URL corresponding to the specified options.
        abstract getUrl: ?opts: Google.Maps.Places.PhotoOptions -> string
        /// The height of the photo in pixels.
        abstract height: float with get, set
        /// Attribution text to be displayed for this photo.
        abstract html_attributions: ResizeArray<string> with get, set
        /// The width of the photo in pixels.
        abstract width: float with get, set

    /// <summary>
    /// Defines Open Location Codes or &amp;quot;&lt;a href="<see href="https://plus.codes/"&gt;plus" />
    /// codes&lt;/a&gt;&amp;quot; for a Place. Plus codes can be used as a replacement for
    /// street addresses in places where they do not exist (where buildings are not
    /// numbered or streets are not named).
    /// </summary>
    type [<AllowNullLiteral>] PlacePlusCode =
        /// <summary>
        /// A &lt;a href="<see href="https://plus.codes/"&gt;plus" /> code&lt;/a&gt; with a 1/8000th of a degree
        /// by 1/8000th of a degree area where the first four characters (the area
        /// code) are dropped and replaced with a locality description. For example,
        /// &lt;code&gt;"9G8F+5W Zurich, Switzerland"&lt;/code&gt;. If no suitable locality that
        /// can be found to shorten the code then this field is omitted.
        /// </summary>
        abstract compound_code: string option with get, set
        /// <summary>
        /// A &lt;a href="<see href="https://plus.codes/"&gt;plus" /> code&lt;/a&gt; with a 1/8000th of a degree
        /// by 1/8000th of a degree area. For example, &lt;code&gt;"8FVC9G8F+5W"&lt;/code&gt;.
        /// </summary>
        abstract global_code: string with get, set

    /// Defines information about a Place.
    type [<AllowNullLiteral>] PlaceResult =
        /// <summary>
        /// The collection of address components for this Place’s location. Only
        /// available with <see cref="google.maps.places.PlacesService.getDetails" />.
        /// </summary>
        abstract address_components: ResizeArray<Google.Maps.GeocoderAddressComponent> option with get, set
        /// <summary>
        /// The representation of the Place’s address in the &lt;a
        /// href="<see href="http://microformats.org/wiki/adr"&gt;adr" /> microformat&lt;/a&gt;. Only
        /// available with <see cref="google.maps.places.PlacesService.getDetails" />.
        /// </summary>
        abstract adr_address: string option with get, set
        /// The rated aspects of this Place, based on Google and Zagat user reviews.
        /// The ratings are on a scale of 0 to 30.
        abstract aspects: ResizeArray<Google.Maps.Places.PlaceAspectRating> option with get, set
        /// A flag indicating the operational status of the Place, if it is a
        /// business (indicates whether the place is operational, or closed either
        /// temporarily or permanently). If no data is available, the flag is not
        /// present in search or details responses.
        abstract business_status: Google.Maps.Places.BusinessStatus option with get, set
        /// The Place’s full address.
        abstract formatted_address: string option with get, set
        /// <summary>
        /// The Place’s phone number, formatted according to the &lt;a
        /// href="<see href="http://en.wikipedia.org/wiki/Local_conventions_for_writing_telephone_numbers"&gt;" />
        /// number&amp;#39;s regional convention&lt;/a&gt;. Only available with <see cref="*">google.maps.places.PlacesService.getDetails</see>.
        /// </summary>
        abstract formatted_phone_number: string option with get, set
        /// The Place’s geometry-related information.
        abstract geometry: Google.Maps.Places.PlaceGeometry option with get, set
        /// Attribution text to be displayed for this Place result. Available
        /// &lt;code&gt;html_attributions&lt;/code&gt; are always returned regardless of what
        /// &lt;code&gt;fields&lt;/code&gt; have been requested, and must be displayed.
        abstract html_attributions: ResizeArray<string> option with get, set
        /// URL to an image resource that can be used to represent this Place’s
        /// category.
        abstract icon: string option with get, set
        /// <summary>Background color for use with a Place&amp;#39;s icon. See also <see cref="*">google.maps.places.PlaceResult.icon_mask_base_uri</see>.</summary>
        abstract icon_background_color: string option with get, set
        /// A truncated URL to an icon mask. Access different icon types by appending
        /// a file extension to the end (i.e. &lt;code&gt;.svg&lt;/code&gt; or
        /// &lt;code&gt;.png&lt;/code&gt;).
        abstract icon_mask_base_uri: string option with get, set
        /// <summary>
        /// The Place’s phone number in international format. International format
        /// includes the country code, and is prefixed with the plus (+) sign. Only
        /// available with <see cref="google.maps.places.PlacesService.getDetails" />.
        /// </summary>
        abstract international_phone_number: string option with get, set
        /// <summary>
        /// The Place’s name. Note: In the case of user entered Places, this is the
        /// raw text, as typed by the user. Please exercise caution when using this
        /// data, as malicious users may try to use it as a vector for code injection
        /// attacks (See &lt;a href="<see href="http://en.wikipedia.org/wiki/Code_injection"&gt;" />
        /// <see href="http://en.wikipedia.org/wiki/Code_injection&lt;/a&gt;)." />
        /// </summary>
        abstract name: string option with get, set
        /// Defines when the Place opens or closes.
        abstract opening_hours: Google.Maps.Places.PlaceOpeningHours option with get, set
        /// A flag indicating whether the Place is closed, either permanently or
        /// temporarily. If the place is operational, or if no data is available, the
        /// flag is absent from the response.
        [<Obsolete("<code>permanently_closed</code> is deprecated as of May 2020
and will be turned off in May 2021. Use {@link  *     google.maps.places.PlaceResult.business_status} instead as
<code>permanently_closed</code> does not distinguish between
temporary and permanent closures.")>]
        abstract permanently_closed: bool option with get, set
        /// <summary>Photos of this Place. The collection will contain up to ten <see cref="*">google.maps.places.PlacePhoto</see> objects.</summary>
        abstract photos: ResizeArray<Google.Maps.Places.PlacePhoto> option with get, set
        /// A unique identifier for the Place.
        abstract place_id: string option with get, set
        /// <summary>
        /// Defines Open Location Codes or &amp;quot;&lt;a href="<see href="https://plus.codes/"&gt;plus" />
        /// codes&lt;/a&gt;&amp;quot; for the Place.
        /// </summary>
        abstract plus_code: Google.Maps.Places.PlacePlusCode option with get, set
        /// The price level of the Place, on a scale of 0 to 4. Price levels are
        /// interpreted as follows: &lt;ul style="list-style-type: none;"&gt;
        /// &lt;li&gt;&lt;code&gt;0&lt;/code&gt;: Free &lt;li&gt;&lt;code&gt;1&lt;/code&gt;: Inexpensive
        /// &lt;li&gt;&lt;code&gt;2&lt;/code&gt;: Moderate &lt;li&gt;&lt;code&gt;3&lt;/code&gt;: Expensive
        /// &lt;li&gt;&lt;code&gt;4&lt;/code&gt;: Very Expensive
        /// &lt;/ul&gt;
        abstract price_level: float option with get, set
        /// A rating, between 1.0 to 5.0, based on user reviews of this Place.
        abstract rating: float option with get, set
        /// <summary>A list of reviews of this Place. Only available with <see cref="*">google.maps.places.PlacesService.getDetails</see>.</summary>
        abstract reviews: ResizeArray<Google.Maps.Places.PlaceReview> option with get, set
        /// <summary>
        /// An array of &lt;a
        /// href="<see href="https://developers.google.com/maps/documentation/places/web-service/supported_types"&gt;" />
        /// types for this Place&lt;/a&gt; (for example, &lt;code&gt;["political",
        /// "locality"]&lt;/code&gt; or &lt;code&gt;["restaurant", "establishment"]&lt;/code&gt;).
        /// </summary>
        abstract types: ResizeArray<string> option with get, set
        /// <summary>
        /// URL of the official Google page for this place. This is the Google-owned
        /// page that contains the best available information about the Place. Only
        /// available with <see cref="google.maps.places.PlacesService.getDetails" />.
        /// </summary>
        abstract url: string option with get, set
        /// <summary>The number of user ratings which contributed to this Place’s <see cref="*">google.maps.places.PlaceResult.rating</see>.</summary>
        abstract user_ratings_total: float option with get, set
        /// <summary>
        /// The offset from UTC of the Place’s current timezone, in minutes. For
        /// example, Sydney, Australia in daylight savings is 11 hours ahead of UTC,
        /// so the &lt;code&gt;utc_offset&lt;/code&gt; will be &lt;code&gt;660&lt;/code&gt;. For timezones
        /// behind UTC, the offset is negative. For example, the
        /// &lt;code&gt;utc_offset&lt;/code&gt; is &lt;code&gt;-60&lt;/code&gt; for Cape Verde. Only
        /// available with <see cref="google.maps.places.PlacesService.getDetails" />.
        /// </summary>
        [<Obsolete("<code>utc_offset</code> is deprecated as of November 2019.
Use {@link google.maps.places.PlaceResult.utc_offset_minutes }
instead. See <a
href=\"https://goo.gle/js-open-now\">https://goo.gle/js-open-now</a>")>]
        abstract utc_offset: float option with get, set
        /// <summary>
        /// The offset from UTC of the Place’s current timezone, in minutes. For
        /// example, Sydney, Australia in daylight savings is 11 hours ahead of UTC,
        /// so the &lt;code&gt;utc_offset_minutes&lt;/code&gt; will be &lt;code&gt;660&lt;/code&gt;. For
        /// timezones behind UTC, the offset is negative. For example, the
        /// &lt;code&gt;utc_offset_minutes&lt;/code&gt; is &lt;code&gt;-60&lt;/code&gt; for Cape Verde. Only
        /// available with <see cref="google.maps.places.PlacesService.getDetails" />.
        /// </summary>
        abstract utc_offset_minutes: float option with get, set
        /// <summary>
        /// The simplified address for the Place, including the street name, street
        /// number, and locality, but not the province/state, postal code, or
        /// country. For example, Google&amp;#39;s Sydney, Australia office has a
        /// vicinity value of &lt;code&gt;"48 Pirrama Road, Pyrmont"&lt;/code&gt;. Only available
        /// with <see cref="google.maps.places.PlacesService.getDetails" />.
        /// </summary>
        abstract vicinity: string option with get, set
        /// <summary>
        /// The authoritative website for this Place, such as a business&amp;#39;
        /// homepage. Only available with <see cref="*">google.maps.places.PlacesService.getDetails</see>.
        /// </summary>
        abstract website: string option with get, set

    /// Represents a single review of a place.
    type [<AllowNullLiteral>] PlaceReview =
        /// The aspects rated by the review. The ratings on a scale of 0 to 3.
        [<Obsolete("This field is no longer available.")>]
        abstract aspects: ResizeArray<Google.Maps.Places.PlaceAspectRating> option with get, set
        /// The name of the reviewer.
        abstract author_name: string with get, set
        /// A URL to the reviewer&amp;#39;s profile. This will be &lt;code&gt;undefined&lt;/code&gt;
        /// when the reviewer&amp;#39;s profile is unavailable.
        abstract author_url: string option with get, set
        /// An IETF language code indicating the language in which this review is
        /// written. Note that this code includes only the main language tag without
        /// any secondary tag indicating country or region. For example, all the
        /// English reviews are tagged as &lt;code&gt;'en'&lt;/code&gt; rather than
        /// &amp;#39;en-AU&amp;#39; or
        /// &amp;#39;en-UK&amp;#39;.
        abstract language: string with get, set
        /// A URL to the reviwer&#39;s profile image.
        abstract profile_photo_url: string with get, set
        /// The rating of this review, a number between 1.0 and 5.0 (inclusive).
        abstract rating: float option with get, set
        /// A string of formatted recent time, expressing the review time relative to
        /// the current time in a form appropriate for the language and country. For
        /// example &lt;code&gt;&amp;quot;a month ago&amp;quot;&lt;/code&gt;.
        abstract relative_time_description: string with get, set
        /// The text of a review.
        abstract text: string with get, set
        /// Timestamp for the review, expressed in seconds since epoch.
        abstract time: float with get, set

    /// An object used to fetch additional pages of Places results.
    type [<AllowNullLiteral>] PlaceSearchPagination =
        /// Indicates if further results are available. &lt;code&gt;true&lt;/code&gt; when there
        /// is an additional results page.
        abstract hasNextPage: bool with get, set
        /// Fetches the next page of results. Uses the same callback function that
        /// was provided to the first search request.
        abstract nextPage: unit -> unit

    /// A Place search query to be sent to the &lt;code&gt;PlacesService&lt;/code&gt;.
    type [<AllowNullLiteral>] PlaceSearchRequest =
        /// The bounds within which to search for Places. Both &lt;code&gt;location&lt;/code&gt;
        /// and &lt;code&gt;radius&lt;/code&gt; will be ignored if &lt;code&gt;bounds&lt;/code&gt; is set.
        abstract bounds: U2<Google.Maps.LatLngBounds, Google.Maps.LatLngBoundsLiteral> option with get, set
        /// A term to be matched against all available fields, including but not
        /// limited to name, type, and address, as well as customer reviews and other
        /// third-party content.
        abstract keyword: string option with get, set
        /// <summary>
        /// A language identifier for the language in which names and addresses
        /// should be returned, when possible. See the &lt;a
        /// href="<see href="https://developers.google.com/maps/faq#languagesupport"&gt;list" /> of
        /// supported languages&lt;/a&gt;.
        /// </summary>
        abstract language: string option with get, set
        /// The location around which to search for Places.
        abstract location: U2<Google.Maps.LatLng, Google.Maps.LatLngLiteral> option with get, set
        /// Restricts results to only those places at the specified price level or
        /// lower. Valid values are in the range from 0 (most affordable) to 4 (most
        /// expensive), inclusive. Must be greater than or equal to &lt;code&gt;minPrice
        /// &lt;/code&gt;, if specified.
        abstract maxPriceLevel: float option with get, set
        /// Restricts results to only those places at the specified price level or
        /// higher. Valid values are in the range from 0 (most affordable) to 4 (most
        /// expensive), inclusive. Must be less than or equal to
        /// &lt;code&gt;maxPrice&lt;/code&gt;, if specified.
        abstract minPriceLevel: float option with get, set
        /// Equivalent to &lt;code&gt;keyword&lt;/code&gt;. Values in this field are combined
        /// with values in the &lt;code&gt;keyword&lt;/code&gt; field and passed as part of the
        /// same search string.
        [<Obsolete("Use <code>keyword</code> instead.")>]
        abstract name: string option with get, set
        /// Restricts results to only those places that are open right now.
        abstract openNow: bool option with get, set
        /// The distance from the given location within which to search for Places,
        /// in meters. The maximum allowed value is 50&thinsp;000.
        abstract radius: float option with get, set
        /// <summary>
        /// Specifies the ranking method to use when returning results. Note that
        /// when &lt;code&gt;rankBy&lt;/code&gt; is set to &lt;code&gt;DISTANCE&lt;/code&gt;, you must
        /// specify a &lt;code&gt;location&lt;/code&gt; but you cannot specify a
        /// &lt;code&gt;radius&lt;/code&gt; or &lt;code&gt;bounds&lt;/code&gt;.
        /// </summary>
        /// <default><see cref="google.maps.places.RankBy.PROMINENCE" /></default>
        abstract rankBy: Google.Maps.Places.RankBy option with get, set
        /// <summary>
        /// Searches for places of the given type. The type is translated to the
        /// local language of the request&amp;#39;s target location and used as a query
        /// string. If a query is also provided, it is concatenated to the localized
        /// type string. Results of a different type are dropped from the response.
        /// Use this field to perform language and region independent categorical
        /// searches. Valid types are given &lt;a
        /// href="<see href="https://developers.google.com/maps/documentation/places/web-service/supported_types"&gt;here&lt;/a&gt;." />
        /// </summary>
        abstract ``type``: string option with get, set

    /// <summary>
    /// Contains methods related to searching for places and retrieving details
    /// about a place.
    ///
    /// Access by calling `const {PlacesService} = await
    /// google.maps.importLibrary("places")`. See
    /// <see href="https://developers.google.com/maps/documentation/javascript/libraries." />
    /// </summary>
    type [<AllowNullLiteral>] PlacesService =
        /// <summary>
        /// Retrieves a list of places based on a phone number. In most cases there
        /// should be just one item in the result list, however if the request is
        /// ambiguous more than one result may be returned. The <see cref="*">google.maps.places.PlaceResult</see>s passed to the callback are subsets of a
        /// full <see cref="google.maps.places.PlaceResult" />. Your app can get a more
        /// detailed <see cref="google.maps.places.PlaceResult" /> for each place by
        /// calling <see cref="google.maps.places.PlacesService.getDetails" /> and passing
        /// the <see cref="google.maps.places.PlaceResult.place_id" /> for the desired
        /// place.
        /// </summary>
        abstract findPlaceFromPhoneNumber: request: Google.Maps.Places.FindPlaceFromPhoneNumberRequest * callback: (ResizeArray<Google.Maps.Places.PlaceResult> option -> Google.Maps.Places.PlacesServiceStatus -> unit) -> unit
        /// <summary>
        /// Retrieves a list of places based on a query string. In most cases there
        /// should be just one item in the result list, however if the request is
        /// ambiguous more than one result may be returned. The <see cref="*">google.maps.places.PlaceResult</see>s passed to the callback are subsets of a
        /// full <see cref="google.maps.places.PlaceResult" />. Your app can get a more
        /// detailed <see cref="google.maps.places.PlaceResult" /> for each place by
        /// calling <see cref="google.maps.places.PlacesService.getDetails" /> and passing
        /// the <see cref="google.maps.places.PlaceResult.place_id" /> for the desired
        /// place.
        /// </summary>
        abstract findPlaceFromQuery: request: Google.Maps.Places.FindPlaceFromQueryRequest * callback: (ResizeArray<Google.Maps.Places.PlaceResult> option -> Google.Maps.Places.PlacesServiceStatus -> unit) -> unit
        /// Retrieves details about the place identified by the given
        /// &lt;code&gt;placeId&lt;/code&gt;.
        abstract getDetails: request: Google.Maps.Places.PlaceDetailsRequest * callback: (Google.Maps.Places.PlaceResult option -> Google.Maps.Places.PlacesServiceStatus -> unit) -> unit
        /// <summary>
        /// Retrieves a list of places near a particular location, based on keyword
        /// or type. Location must always be specified, either by passing a
        /// &lt;code&gt;LatLngBounds&lt;/code&gt;, or &lt;code&gt;location&lt;/code&gt; and
        /// &lt;code&gt;radius&lt;/code&gt; parameters. The <see cref="*">google.maps.places.PlaceResult</see>s passed to the callback are subsets of
        /// the full <see cref="google.maps.places.PlaceResult" />. Your app can get a more
        /// detailed <see cref="google.maps.places.PlaceResult" /> for each place by sending
        /// a &lt;a
        /// href="<see href="https://developers.google.com/maps/documentation/javascript/places#place_details_requests"&gt;Place" />
        /// Details request&lt;/a&gt; passing the <see cref="*">google.maps.places.PlaceResult.place_id</see> for the desired place.
        /// The <see cref="google.maps.places.PlaceSearchPagination" /> object can be used
        /// to fetch additional pages of results (null if this is the last page of
        /// results or if there is only one page of results).
        /// </summary>
        abstract nearbySearch: request: Google.Maps.Places.PlaceSearchRequest * callback: (ResizeArray<Google.Maps.Places.PlaceResult> option -> Google.Maps.Places.PlacesServiceStatus -> Google.Maps.Places.PlaceSearchPagination option -> unit) -> unit
        /// Retrieves a list of places based on a query string (for example,
        /// &amp;quot;pizza in New York&amp;quot;, or &amp;quot;shoe stores near Ottawa&amp;quot;).
        /// Location parameters are optional; when the location is specified, results
        /// are only biased toward nearby results rather than restricted to places
        /// inside the area. Use &lt;code&gt;textSearch&lt;/code&gt; when you want to search for
        /// places using an arbitrary string, and in cases where you may not want to
        /// restrict search results to a particular location. The
        /// &lt;code&gt;PlaceSearchPagination&lt;/code&gt; object can be used to fetch additional
        /// pages of results (null if this is the last page of results or if there is
        /// only one page of results).
        abstract textSearch: request: Google.Maps.Places.TextSearchRequest * callback: (ResizeArray<Google.Maps.Places.PlaceResult> option -> Google.Maps.Places.PlacesServiceStatus -> Google.Maps.Places.PlaceSearchPagination option -> unit) -> unit

    /// <summary>
    /// Contains methods related to searching for places and retrieving details
    /// about a place.
    ///
    /// Access by calling `const {PlacesService} = await
    /// google.maps.importLibrary("places")`. See
    /// <see href="https://developers.google.com/maps/documentation/javascript/libraries." />
    /// </summary>
    type [<AllowNullLiteral>] PlacesServiceStatic =
        /// <summary>
        /// Contains methods related to searching for places and retrieving details
        /// about a place.
        ///
        /// Access by calling `const {PlacesService} = await
        /// google.maps.importLibrary("places")`. See
        /// <see href="https://developers.google.com/maps/documentation/javascript/libraries." />
        /// </summary>
        [<EmitConstructor>] abstract Create: attrContainer: U2<HTMLDivElement, Google.Maps.Map> -> PlacesService

    /// <summary>
    /// The status returned by the &lt;code&gt;PlacesService&lt;/code&gt; on the completion of
    /// its searches. Specify these by value, or by using the constant&amp;#39;s name.
    /// For example, &lt;code&gt;'OK'&lt;/code&gt; or
    /// &lt;code&gt;google.maps.places.PlacesServiceStatus.OK&lt;/code&gt;.
    ///
    /// Access by calling `const {PlacesServiceStatus} = await
    /// google.maps.importLibrary("places")`. See
    /// <see href="https://developers.google.com/maps/documentation/javascript/libraries." />
    /// </summary>
    type [<StringEnum>] [<RequireQualifiedAccess>] PlacesServiceStatus =
        /// This request was invalid.
        | [<CompiledName("INVALID_REQUEST")>] INVALID_REQUEST
        /// The place referenced was not found.
        | [<CompiledName("NOT_FOUND")>] NOT_FOUND
        /// The response contains a valid result.
        | [<CompiledName("OK")>] OK
        /// The application has gone over its request quota.
        | [<CompiledName("OVER_QUERY_LIMIT")>] OVER_QUERY_LIMIT
        /// The application is not allowed to use the &lt;code&gt;PlacesService&lt;/code&gt;.
        | [<CompiledName("REQUEST_DENIED")>] REQUEST_DENIED
        /// The &lt;code&gt;PlacesService&lt;/code&gt; request could not be processed due to a
        /// server error. The request may succeed if you try again.
        | [<CompiledName("UNKNOWN_ERROR")>] UNKNOWN_ERROR
        /// No result was found for this request.
        | [<CompiledName("ZERO_RESULTS")>] ZERO_RESULTS

    /// <summary>
    /// Available only in the v=beta channel: <see href="https://goo.gle/3oAthT3." />
    ///
    ///
    /// Access by calling `const {PlusCode} = await
    /// google.maps.importLibrary("places")`. See
    /// <see href="https://developers.google.com/maps/documentation/javascript/libraries." />
    /// </summary>
    type [<AllowNullLiteral>] PlusCode =
        /// A plus code with a 1/8000th of a degree by 1/8000th of a degree area
        /// where the first four characters (the area code) are dropped and replaced
        /// with a locality description. For example, &quot;9G8F+5W Zurich,
        /// Switzerland&quot;.
        abstract compoundCode: string option with get, set
        /// A plus code with a 1/8000th of a degree by 1/8000th of a degree area. For
        /// example, &quot;8FVC9G8F+5W&quot;.
        abstract globalCode: string option with get, set

    /// <summary>
    /// Available only in the v=beta channel: <see href="https://goo.gle/3oAthT3." />
    ///
    ///
    /// Access by calling `const {PlusCode} = await
    /// google.maps.importLibrary("places")`. See
    /// <see href="https://developers.google.com/maps/documentation/javascript/libraries." />
    /// </summary>
    type [<AllowNullLiteral>] PlusCodeStatic =
        [<EmitConstructor>] abstract Create: unit -> PlusCode

    /// Represents a prediction substring.
    type [<AllowNullLiteral>] PredictionSubstring =
        /// The length of the substring.
        abstract length: float with get, set
        /// The offset to the substring&#39;s start within the description string.
        abstract offset: float with get, set

    /// Represents a prediction term.
    type [<AllowNullLiteral>] PredictionTerm =
        /// The offset, in unicode characters, of the start of this term in the
        /// description of the place.
        abstract offset: float with get, set
        /// The value of this term, for example, &quot;Taco Bell&quot;.
        abstract value: string with get, set

    /// <summary>
    /// Available only in the v=beta channel: <see href="https://goo.gle/3oAthT3." />
    ///
    /// Price level enum for Place objects.
    ///
    /// Access by calling `const {PriceLevel} = await
    /// google.maps.importLibrary("places")`. See
    /// <see href="https://developers.google.com/maps/documentation/javascript/libraries." />
    /// </summary>
    type [<StringEnum>] [<RequireQualifiedAccess>] PriceLevel =
        | [<CompiledName("EXPENSIVE")>] EXPENSIVE
        | [<CompiledName("FREE")>] FREE
        | [<CompiledName("INEXPENSIVE")>] INEXPENSIVE
        | [<CompiledName("MODERATE")>] MODERATE
        | [<CompiledName("VERY_EXPENSIVE")>] VERY_EXPENSIVE

    /// Represents a single Query Autocomplete prediction.
    type [<AllowNullLiteral>] QueryAutocompletePrediction =
        /// This is the unformatted version of the query suggested by the Places
        /// service.
        abstract description: string with get, set
        /// A set of substrings in the place&#39;s description that match elements in
        /// the user&#39;s input, suitable for use in highlighting those substrings.
        /// Each substring is identified by an offset and a length, expressed in
        /// unicode characters.
        abstract matched_substrings: ResizeArray<Google.Maps.Places.PredictionSubstring> with get, set
        /// <summary>
        /// Only available if prediction is a place. A place ID that can be used to
        /// retrieve details about this place using the place details service
        /// (see <see cref="google.maps.places.PlacesService.getDetails" />).
        /// </summary>
        abstract place_id: string option with get, set
        /// Information about individual terms in the above description. Categorical
        /// terms come first (for example, &quot;restaurant&quot;). Address terms
        /// appear from most to least specific. For example, &quot;San
        /// Francisco&quot;, and &quot;CA&quot;.
        abstract terms: ResizeArray<Google.Maps.Places.PredictionTerm> with get, set

    /// A QueryAutocompletion request to be sent to the
    /// &lt;code&gt;QueryAutocompleteService&lt;/code&gt;.
    type [<AllowNullLiteral; Global>] QueryAutocompletionRequest private() =

        [<ParamObject; Emit("$0")>]
        new (
            input: string,
            ?bounds: Google.Maps.LatLngBounds,
            ?location: Google.Maps.LatLng,
            ?offset: float,
            ?radius: float
        ) = QueryAutocompletionRequest()

        /// Bounds for prediction biasing. Predictions will be biased towards, but
        /// not restricted to, the given &lt;code&gt;bounds&lt;/code&gt;. Both
        /// &lt;code&gt;location&lt;/code&gt; and &lt;code&gt;radius&lt;/code&gt; will be ignored if
        /// &lt;code&gt;bounds&lt;/code&gt; is set.
        member val bounds: U2<Google.Maps.LatLngBounds, Google.Maps.LatLngBoundsLiteral> option = nativeOnly with get, set
        /// The user entered input string.
        member val input: string = nativeOnly with get, set
        /// Location for prediction biasing. Predictions will be biased towards the
        /// given &lt;code&gt;location&lt;/code&gt; and &lt;code&gt;radius&lt;/code&gt;. Alternatively,
        /// &lt;code&gt;bounds&lt;/code&gt; can be used.
        member val location: Google.Maps.LatLng option = nativeOnly with get, set
        /// The character position in the input term at which the service uses text
        /// for predictions (the position of the cursor in the input field).
        member val offset: float option = nativeOnly with get, set
        /// The radius of the area used for prediction biasing. The
        /// &lt;code&gt;radius&lt;/code&gt; is specified in meters, and must always be
        /// accompanied by a &lt;code&gt;location&lt;/code&gt; property. Alternatively,
        /// &lt;code&gt;bounds&lt;/code&gt; can be used.
        member val radius: float option = nativeOnly with get, set

    /// <summary>
    /// Ranking options for a PlaceSearchRequest.
    ///
    /// Access by calling `const {RankBy} = await
    /// google.maps.importLibrary("places")`. See
    /// <see href="https://developers.google.com/maps/documentation/javascript/libraries." />
    /// </summary>
    type [<RequireQualifiedAccess>] RankBy =
        /// Ranks place results by distance from the location.
        | DISTANCE = 0
        /// Ranks place results by their prominence.
        | PROMINENCE = 1

    /// <summary>
    /// Available only in the v=beta channel: <see href="https://goo.gle/3oAthT3." />
    ///
    ///
    /// Access by calling `const {Review} = await
    /// google.maps.importLibrary("places")`. See
    /// <see href="https://developers.google.com/maps/documentation/javascript/libraries." />
    /// </summary>
    type [<AllowNullLiteral>] Review =
        /// The reviewer.
        abstract authorAttribution: Google.Maps.Places.AuthorAttribution option with get, set
        abstract publishTime: DateTime option with get, set
        /// The rating of this review, a number between 1.0 and 5.0 (inclusive).
        abstract rating: float option with get, set
        /// A string of formatted recent time, expressing the review time relative to
        /// the current time in a form appropriate for the language and country. For
        /// example
        /// `&quot;a month ago&quot;&#39;.
        abstract relativePublishTimeDescription: string option with get, set
        /// The text of a review.
        abstract text: string option with get, set
        /// An IETF language code indicating the language in which this review is
        /// written. Note that this code includes only the main language tag without
        /// any secondary tag indicating country or region. For example, all the
        /// English reviews are tagged as &lt;code&gt;'en'&lt;/code&gt; rather than
        /// &amp;#39;en-AU&amp;#39; or
        /// &amp;#39;en-UK&amp;#39;.
        abstract textLanguageCode: string option with get, set

    /// <summary>
    /// Available only in the v=beta channel: <see href="https://goo.gle/3oAthT3." />
    ///
    ///
    /// Access by calling `const {Review} = await
    /// google.maps.importLibrary("places")`. See
    /// <see href="https://developers.google.com/maps/documentation/javascript/libraries." />
    /// </summary>
    type [<AllowNullLiteral>] ReviewStatic =
        [<EmitConstructor>] abstract Create: unit -> Review

    /// <summary>
    /// A widget that provides query predictions based on a user&amp;#39;s text input.
    /// It attaches to an input element of type &lt;code&gt;text&lt;/code&gt;, and listens for
    /// text entry in that field. The list of predictions is presented as a
    /// drop-down list, and is updated as text is entered.
    ///
    /// Access by calling `const {SearchBox} = await
    /// google.maps.importLibrary("places")`. See
    /// <see href="https://developers.google.com/maps/documentation/javascript/libraries." />
    /// </summary>
    type [<AllowNullLiteral>] SearchBox =
        inherit Google.Maps.MVCObject
        /// Returns the bounds to which query predictions are biased.
        abstract getBounds: unit -> Google.Maps.LatLngBounds option
        /// Returns the query selected by the user to be used with
        /// &lt;code&gt;places_changed&lt;/code&gt; event.
        abstract getPlaces: unit -> ResizeArray<Google.Maps.Places.PlaceResult> option
        /// Sets the region to use for biasing query predictions. Results will only
        /// be biased towards this area and not be completely restricted to it.
        abstract setBounds: bounds: U2<Google.Maps.LatLngBounds, Google.Maps.LatLngBoundsLiteral> option -> unit

    /// <summary>
    /// A widget that provides query predictions based on a user&amp;#39;s text input.
    /// It attaches to an input element of type &lt;code&gt;text&lt;/code&gt;, and listens for
    /// text entry in that field. The list of predictions is presented as a
    /// drop-down list, and is updated as text is entered.
    ///
    /// Access by calling `const {SearchBox} = await
    /// google.maps.importLibrary("places")`. See
    /// <see href="https://developers.google.com/maps/documentation/javascript/libraries." />
    /// </summary>
    type [<AllowNullLiteral>] SearchBoxStatic =
        /// <summary>
        /// A widget that provides query predictions based on a user&amp;#39;s text
        /// input. It attaches to an input element of type &lt;code&gt;text&lt;/code&gt;, and
        /// listens for text entry in that field. The list of predictions is
        /// presented as a drop-down list, and is updated as text is entered.
        ///
        /// Access by calling `const {SearchBox} = await
        /// google.maps.importLibrary("places")`. See
        /// <see href="https://developers.google.com/maps/documentation/javascript/libraries." />
        /// </summary>
        [<EmitConstructor>] abstract Create: inputField: HTMLInputElement * ?opts: Google.Maps.Places.SearchBoxOptions -> SearchBox

    /// The options that can be set on a &lt;code&gt;SearchBox&lt;/code&gt; object.
    type [<AllowNullLiteral>] SearchBoxOptions =
        /// The area towards which to bias query predictions. Predictions are biased
        /// towards, but not restricted to, queries targeting these bounds.
        abstract bounds: U2<Google.Maps.LatLngBounds, Google.Maps.LatLngBoundsLiteral> option with get, set

    /// <summary>
    /// Available only in the v=beta channel: <see href="https://goo.gle/3oAthT3." />
    ///
    /// RankBy enum for SearchByTextRequest.
    ///
    /// Access by calling `const {SearchByTextRankBy} = await
    /// google.maps.importLibrary("places")`. See
    /// <see href="https://developers.google.com/maps/documentation/javascript/libraries." />
    /// </summary>
    type [<StringEnum>] [<RequireQualifiedAccess>] SearchByTextRankBy =
        /// Ranks results by distance.
        | [<CompiledName("DISTANCE")>] DISTANCE
        /// Ranks results by relevance.
        | [<CompiledName("RELEVANCE")>] RELEVANCE

    /// <summary>
    /// Available only in the v=beta channel: <see href="https://goo.gle/3oAthT3." />
    ///
    /// Request interface for <see cref="google.maps.places.Place.searchByText" />.
    /// </summary>
    type [<AllowNullLiteral>] SearchByTextRequest =
        /// <summary>
        /// Fields to be included in the response, &lt;a
        /// href="<see href="https://developers.google.com/maps/billing/understanding-cost-of-use#places-product"&gt;which" />
        /// will be billed for&lt;/a&gt;. If &lt;code&gt;[&amp;#39;ALL&amp;#39;]&lt;/code&gt; is passed in, all
        /// available fields will be returned and billed for (this is not recommended
        /// for production deployments). For a list of fields see <see cref="*">google.maps.places.PlaceResult</see>. Nested fields can be specified with
        /// dot-paths (for example, &lt;code&gt;"geometry.location"&lt;/code&gt;).
        /// </summary>
        abstract fields: ResizeArray<string> with get, set
        /// <summary>
        /// The requested place type. Full list of types supported: &lt;a
        /// href="<see href="https://developers.google.com/maps/documentation/places/web-service/place-types"&gt;https://developers.google.com/maps/documentation/places/web-service/place-types&lt;/a&gt;." />
        /// Only one included type is supported. See <see cref="*">google.maps.places.SearchByTextRequest.useStrictTypeFiltering</see>
        /// </summary>
        abstract includedType: string option with get, set
        /// <summary>Used to restrict the search to places that are currently open.</summary>
        /// <default>&lt;code&gt;false&lt;/code&gt;</default>
        abstract isOpenNow: bool option with get, set
        /// <summary>
        /// Place details will be displayed with the preferred language if available.
        /// Will default to the browser&amp;#39;s language preference. Current list of
        /// supported languages: &lt;a
        /// href="<see href="https://developers.google.com/maps/faq#languagesupport"&gt;https://developers.google.com/maps/faq#languagesupport&lt;/a&gt;." />
        /// </summary>
        abstract language: string option with get, set
        /// The region to search. This location serves as a bias which means results
        /// around given location might be returned. Cannot be set along with
        /// locationRestriction.
        abstract locationBias: U6<Google.Maps.LatLng, Google.Maps.LatLngLiteral, Google.Maps.LatLngBounds, Google.Maps.LatLngBoundsLiteral, Google.Maps.CircleLiteral, Google.Maps.Circle> option with get, set
        /// The region to search. This location serves as a restriction which means
        /// results outside given location will not be returned. Cannot be set along
        /// with locationBias.
        abstract locationRestriction: U2<Google.Maps.LatLngBounds, Google.Maps.LatLngBoundsLiteral> option with get, set
        /// Maximum number of results to return. It must be between 1 and 20,
        /// inclusively.
        abstract maxResultCount: float option with get, set
        /// Filter out results whose average user rating is strictly less than this
        /// limit. A valid value must be an float between 0 and 5 (inclusively) at a
        /// 0.5 cadence i.e. [0, 0.5, 1.0, ... , 5.0] inclusively. The input rating
        /// will be rounded up to the nearest 0.5(ceiling). For instance, a rating of
        /// 0.6 will eliminate all results with a less than 1.0 rating.
        abstract minRating: float option with get, set
        /// Used to restrict the search to places that are marked as certain price
        /// levels. Any combinations of price levels can be chosen. Defaults to all
        /// price levels.
        abstract priceLevels: ResizeArray<Google.Maps.Places.PriceLevel> option with get, set
        [<Obsolete("Please use textQuery instead")>]
        abstract query: string option with get, set
        /// <summary>How results will be ranked in the response.</summary>
        /// <default>&lt;code&gt;SearchByTextRankBy.DISTANCE&lt;/code&gt;</default>
        abstract rankBy: Google.Maps.Places.SearchByTextRankBy option with get, set
        /// <summary>
        /// The Unicode country/region code (CLDR) of the location where the request
        /// is coming from. This parameter is used to display the place details, like
        /// region-specific place name, if available. The parameter can affect
        /// results based on applicable law. For more information, see &lt;a
        /// href="<see href="https://www.unicode.org/cldr/charts/latest/supplemental/territory_language_information.html"&gt;https://www.unicode.org/cldr/charts/latest/supplemental/territory_language_information.html&lt;/a&gt;." />
        /// Note that 3-digit region codes are not currently supported.
        /// </summary>
        abstract region: string option with get, set
        /// Required. The text query for textual search.
        abstract textQuery: string option with get, set
        /// <summary>
        /// Used to set strict type filtering for <see cref="*">google.maps.places.SearchByTextRequest.includedType</see>. If set to true,
        /// only results of the same type will be returned.
        /// </summary>
        /// <default>&lt;code&gt;false&lt;/code&gt;</default>
        abstract useStrictTypeFiltering: bool option with get, set

    /// Contains structured information about the place&#39;s description, divided
    /// into a main text and a secondary text, including an array of matched
    /// substrings from the autocomplete input, identified by an offset and a
    /// length, expressed in unicode characters.
    type [<AllowNullLiteral>] StructuredFormatting =
        /// This is the main text part of the unformatted description of the place
        /// suggested by the Places service. Usually the name of the place.
        abstract main_text: string with get, set
        /// A set of substrings in the main text that match elements in the
        /// user&#39;s input, suitable for use in highlighting those substrings. Each
        /// substring is identified by an offset and a length, expressed in unicode
        /// characters.
        abstract main_text_matched_substrings: ResizeArray<Google.Maps.Places.PredictionSubstring> with get, set
        /// This is the secondary text part of the unformatted description of the
        /// place suggested by the Places service. Usually the location of the place.
        abstract secondary_text: string with get, set

    /// A text search request to be sent to the &lt;code&gt;PlacesService&lt;/code&gt;.
    type [<AllowNullLiteral>] TextSearchRequest =
        /// Bounds used to bias results when searching for Places (optional). Both
        /// &lt;code&gt;location&lt;/code&gt; and &lt;code&gt;radius&lt;/code&gt; will be ignored if
        /// &lt;code&gt;bounds&lt;/code&gt; is set. Results will not be restricted to those
        /// inside these bounds; but, results inside it will rank higher.
        abstract bounds: U2<Google.Maps.LatLngBounds, Google.Maps.LatLngBoundsLiteral> option with get, set
        /// <summary>
        /// A language identifier for the language in which names and addresses
        /// should be returned, when possible. See the &lt;a
        /// href="<see href="https://developers.google.com/maps/faq#languagesupport"&gt;list" /> of
        /// supported languages&lt;/a&gt;.
        /// </summary>
        abstract language: string option with get, set
        /// The center of the area used to bias results when searching for Places.
        abstract location: U2<Google.Maps.LatLng, Google.Maps.LatLngLiteral> option with get, set
        /// The request&#39;s query term. For example, the name of a place
        /// (&#39;Eiffel Tower&#39;), a category followed by the name of a location
        /// (&#39;pizza in New York&#39;), or the name of a place followed by a
        /// location disambiguator
        /// (&#39;Starbucks in Sydney&#39;).
        abstract query: string option with get, set
        /// The radius of the area used to bias results when searching for Places, in
        /// meters.
        abstract radius: float option with get, set
        /// <summary>
        /// A region code to bias results towards. The region code accepts a &lt;a
        /// href="<see href="https://en.wikipedia.org/wiki/List_of_Internet_top-level_domains#Country_code_top-level_domains"&gt;ccTLD" />
        /// (&amp;quot;top-level domain&amp;quot;)&lt;/a&gt; two-character value. Most ccTLD codes
        /// are identical to ISO 3166-1 codes, with some notable exceptions. For
        /// example, the United Kingdom&amp;#39;s ccTLD is &amp;quot;uk&amp;quot;
        /// (&lt;code&gt;.co.uk&lt;/code&gt;) while its ISO 3166-1 code is &amp;quot;gb&amp;quot;
        /// (technically for the entity of &amp;quot;The United Kingdom of Great Britain
        /// and Northern Ireland&amp;quot;).
        /// </summary>
        abstract region: string option with get, set
        /// <summary>
        /// Searches for places of the given type. The type is translated to the
        /// local language of the request&amp;#39;s target location and used as a query
        /// string. If a query is also provided, it is concatenated to the localized
        /// type string. Results of a different type are dropped from the response.
        /// Use this field to perform language and region independent categorical
        /// searches. Valid types are given &lt;a
        /// href="<see href="https://developers.google.com/maps/documentation/places/web-service/supported_types"&gt;here&lt;/a&gt;." />
        /// </summary>
        abstract ``type``: string option with get, set

module Visualization =

    type [<AllowNullLiteral>] IExports =
        /// <summary>
        /// A layer that provides a client-side rendered heatmap, depicting the
        /// intensity of data at geographical points.
        ///
        /// Access by calling `const {HeatmapLayer} = await
        /// google.maps.importLibrary("visualization")`. See
        /// <see href="https://developers.google.com/maps/documentation/javascript/libraries." />
        /// </summary>
        abstract HeatmapLayer: HeatmapLayerStatic

    /// <summary>
    /// A layer that provides a client-side rendered heatmap, depicting the
    /// intensity of data at geographical points.
    ///
    /// Access by calling `const {HeatmapLayer} = await
    /// google.maps.importLibrary("visualization")`. See
    /// <see href="https://developers.google.com/maps/documentation/javascript/libraries." />
    /// </summary>
    type [<AllowNullLiteral>] HeatmapLayer =
        inherit Google.Maps.MVCObject
        /// Returns the data points currently displayed by this heatmap.
        abstract getData: unit -> Google.Maps.MVCArray<U2<Google.Maps.LatLng, Google.Maps.Visualization.WeightedLocation>>
        abstract getMap: unit -> Google.Maps.Map option
        /// Sets the data points to be displayed by this heatmap.
        abstract setData: data: U2<Google.Maps.MVCArray<U2<Google.Maps.LatLng, Google.Maps.Visualization.WeightedLocation>>, Array<U2<Google.Maps.LatLng, Google.Maps.Visualization.WeightedLocation>>> -> unit
        /// Renders the heatmap on the specified map. If map is set to
        /// &lt;code&gt;null&lt;/code&gt;, the heatmap will be removed.
        abstract setMap: map: Google.Maps.Map option -> unit
        abstract setOptions: options: Google.Maps.Visualization.HeatmapLayerOptions option -> unit

    /// <summary>
    /// A layer that provides a client-side rendered heatmap, depicting the
    /// intensity of data at geographical points.
    ///
    /// Access by calling `const {HeatmapLayer} = await
    /// google.maps.importLibrary("visualization")`. See
    /// <see href="https://developers.google.com/maps/documentation/javascript/libraries." />
    /// </summary>
    type [<AllowNullLiteral>] HeatmapLayerStatic =
        /// <summary>
        /// A layer that provides a client-side rendered heatmap, depicting the
        /// intensity of data at geographical points.
        ///
        /// Access by calling `const {HeatmapLayer} = await
        /// google.maps.importLibrary("visualization")`. See
        /// <see href="https://developers.google.com/maps/documentation/javascript/libraries." />
        /// </summary>
        [<EmitConstructor>] abstract Create: ?opts: Google.Maps.Visualization.HeatmapLayerOptions -> HeatmapLayer

    /// This object defines the properties that can be set on a
    /// &lt;code&gt;HeatmapLayer&lt;/code&gt; object.
    type [<AllowNullLiteral>] HeatmapLayerOptions =
        /// The data points to display. Required.
        abstract data: U2<Google.Maps.MVCArray<U2<Google.Maps.LatLng, Google.Maps.Visualization.WeightedLocation>>, Array<U2<Google.Maps.LatLng, Google.Maps.Visualization.WeightedLocation>>> option with get, set
        /// Specifies whether heatmaps dissipate on zoom. By default, the radius of
        /// influence of a data point is specified by the radius option only. When
        /// dissipating is disabled, the radius option is interpreted as a radius at
        /// zoom level 0.
        abstract dissipating: bool option with get, set
        /// The color gradient of the heatmap, specified as an array of CSS color
        /// strings. All CSS3 colors are supported except for extended named colors.
        abstract gradient: ResizeArray<string> option with get, set
        /// The map on which to display the layer.
        abstract map: Google.Maps.Map option with get, set
        /// The maximum intensity of the heatmap. By default, heatmap colors are
        /// dynamically scaled according to the greatest concentration of points at
        /// any particular pixel on the map. This property allows you to specify a
        /// fixed maximum.
        abstract maxIntensity: float option with get, set
        /// <summary>The opacity of the heatmap, expressed as a number between 0 and 1.</summary>
        /// <default>&lt;code&gt;0.6&lt;/code&gt;</default>
        abstract opacity: float option with get, set
        /// The radius of influence for each data point, in pixels.
        abstract radius: float option with get, set

    /// A data point entry for a heatmap. This is a geographical data point with a
    /// weight attribute.
    type [<AllowNullLiteral>] WeightedLocation =
        /// The location of the data point.
        abstract location: Google.Maps.LatLng option with get, set
        /// The weighting value of the data point.
        abstract weight: float with get, set

type [<AllowNullLiteral>] DatasetFeatureDatasetAttributes =
    [<EmitIndexer>] abstract Item: key: string -> string with get, set
