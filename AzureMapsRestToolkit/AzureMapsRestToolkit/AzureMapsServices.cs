using AzureMapsToolkit.Render;
using AzureMapsToolkit.Common;
using System;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.Linq;
using AzureMapsToolkit.GeoJson;
using AzureMapsToolkit.Search;
using AzureMapsToolkit.Timezone;
using AzureMapsToolkit.Traffic;
using AzureMapsToolkit.Geolocation;
using AzureMapsRestToolkit.Common;

namespace AzureMapsToolkit
{
    public class AzureMapsServices : BaseServices
    {
        

        string Format { get { return "json"; } }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="key"></param>
        public AzureMapsServices(string key) : base(key)
        {
            if (string.IsNullOrEmpty(key))
            {
                throw new ArgumentException("Missing azure maps key");
            }
        }


        #region Geolocation

        /// <summary>
        /// This service will return the ISO country code for the provided IP address. Developers can use this information to block or alter certain content based on geographical locations where the application is being viewed from.
        /// </summary>
        /// <param name="ip">The IP address. Both IPv4 and IPv6 are allowed.</param>
        /// <param name="apiVersion">Version number of Azure Maps API. Current version is 1.0</param>
        /// <returns></returns>
        public async Task<Response<Geolocation.IpAddressToLocationResult>> GetIPToLocation(string ip, string apiVersion = "1.0")
        {
            var req = new IpAddressToLocationRequest { Ip = ip };
            var res = await ExecuteRequest<IpAddressToLocationResult, IpAddressToLocationRequest>
              ("https://atlas.microsoft.com/geolocation/ip/json", req);
            return res;
        }

        #endregion

        #region Render
        /// <summary>
        /// Copyrights API is designed to serve copyright information for Render Tile service. In addition to basic copyright for the whole map, API is serving specific groups of copyrights for some countries.
        /// As an alternative to copyrights for map request, one can receive captions for displaying the map provider information on the map.
        /// </summary>
        /// <param name="apiVersion">Version number of Azure Maps API. Current version is 1.0</param>
        /// <returns></returns>
        public async Task<Response<Render.CopyrightCaptionResult>> GetCopyrightCaption(string apiVersion = "1.0")
        {
            var res = await ExecuteRequest<CopyrightCaptionResult, RequestBase>
               ("https://atlas.microsoft.com/map/copyright/caption/json", new RequestBase());
            return res;

        }

        /// <summary>
        /// Copyrights API is designed to serve copyright information for Render Tile service. In addition to basic copyright for the whole map, API is serving specific groups of copyrights for some countries.
        /// Returns the copyright information for a given tile.To obtain the copyright information for a particular tile, the request should specify the tile's zoom level and x and y coordinates (see: Zoom Levels and Tile Grid).
        /// </summary>
        /// <returns></returns>
        public async Task<Response<Render.CopyrightResult>> GetCopyrightForTile(CopyrightForTileRequest req)
        {
            var res = await ExecuteRequest<CopyrightResult, CopyrightForTileRequest>
                ("https://atlas.microsoft.com/map/copyright/tile/json", req);
            return res;
        }


        /// <summary>
        /// Copyrights API is designed to serve copyright information for Render Tile service. In addition to basic copyright for the whole map, API is serving specific groups of copyrights for some countries.
        /// Returns the copyright information for the world.To obtain the default copyright information for the whole world, do not specify a tile or bounding box.
        /// </summary>
        /// <param name="apiVersion"></param>
        /// <returns></returns>
        public async Task<Response<Render.CopyrightResult>> GetCopyrightForWorld(string apiVersion = "1.0")
        {
            var res = await ExecuteRequest<CopyrightResult, RequestBase>
               ("https://atlas.microsoft.com/map/copyright/world/json", new RequestBase());
            return res;
        }

        /// <summary>
        /// Returns copyright information for a given bounding box. Bounding-box requests should specify the minimum and maximum longitude and latitude (EPSG-3857) coordinates
        /// </summary>
        /// <returns></returns>
        public async Task<Response<Render.CopyrightResult>> GetCopyrightFromBoundingBox(
            CopyrightFromBoundingBoxRequest req)
        {
            var res = await ExecuteRequest<CopyrightResult, CopyrightFromBoundingBoxRequest>
               ("https://atlas.microsoft.com/map/copyright/bounding/json", req);
            return res;

        }



        /// <summary>
        /// The static image service renders a user-defined, rectangular image containing a map section using a zoom level from 0 to 20.
        /// The supported resolution range for the map image is from 1x1 to 8192x8192.
        /// If you are deciding when to use the static image service over the map tile service, you may want to consider how you would like to interact with the rendered map.If the map contents will be relatively unchanging, a static map is a good choice.If you want to support a lot of zooming, panning and changing of the map content, the map tile service would be a better choice.
        /// Note : Either center or bbox parameter must be supplied to the API.
        /// </summary>
        /// <returns></returns>
        public async Task<Response<byte[]>> GetMapImage(MapImageRequest req)
        {
            // TODO, check that the image is correct
            try
            {
                var baseAddress = "https://atlas.microsoft.com/map/static/png";
                string url = $"?subscription-key={Key}&api-version={req.ApiVersion}&layer={req.Layer}&style={req.Style}";
                if (!string.IsNullOrEmpty(req.Bbox))
                {
                    url += $"&bbox={req.Bbox}&height={req.Height}&width={req.Width}&language={req.Language}";
                }
                else if (!string.IsNullOrEmpty(req.Center))
                {
                    url += $"&zoom={req.Zoom}&center={req.Center}&height={req.Height}&width={req.Width}&language={req.Language}";
                }
                var content = await GetByteArray(baseAddress, url);

                var response = Response<byte[]>.CreateResponse(content);

                return response;
            }
            catch (Exception ex)
            {
                return Response<byte[]>.CreateErrorResponse(ex);
            }
        }

        /// <summary>
        /// This service returns a map image tile with size 256x256, given the x and y coordinates and zoom level. Zoom level ranges from 0 to 18. The current available style value is 'satellite' which provides satellite imagery alone.
        /// </summary>
        /// <returns></returns>
        public async Task<Response<byte[]>> GetMapImageryTile(MapImageryTileRequest req) 
        {
            try
            {
                var baseAddress = "https://atlas.microsoft.com/map/imagery/png";
                var url = $"?subscription-key={Key}&api-version=1.0&style=satellite&zoom={req.Zoom}&x={req.X}&y={req.Y}";
                var content = await GetByteArray(baseAddress, url);
                var response = Response<byte[]>.CreateResponse(content);
                return response;
            }
            catch (Exception ex)
            {
                return Response<byte[]>.CreateErrorResponse(ex);
            }
        }

        /// <summary>
        /// Fetches map tiles in vector or raster format typically to be integrated into a new map control or SDK. By default, Azure uses vector map tiles for its web map control 
        /// </summary>
        /// <returns></returns>
        public async Task<Response<byte[]>> GetMapTile(MapTileRequest req)
        {
            try
            {
                string tileFormat = req.Format == TileFormat.pbf ? "pbf" : "png";
                var baseAddress = $"https://atlas.microsoft.com/map/tile/{tileFormat}";
                var mapLayer = req.Layer == StaticMapLayer.basic ? "basic" : req.Layer == StaticMapLayer.hybrid ? "hybrid" : "labels";
                var languagePart = req.Format == TileFormat.png ? "" : $"&language={req.Language}";
                var size = req.TileSize == MapTileSize._256 ? "256" : "512";
                var url = $"?subscription-key={Key}&api-version=1.0&layer={mapLayer}&style=main&zoom={req.Zoom}&x={req.X}&y={req.Y}&tileSize={size}" + languagePart;
                var content = await GetByteArray(baseAddress, url);
                var response = Response<byte[]>.CreateResponse(content);
                return response;
            }
            catch (Exception ex)
            {
                return Response<byte[]>.CreateErrorResponse(ex);
            }
        }

        #endregion

        #region Route
        /// <summary>
        /// eturns a route between an origin and a destination, passing through waypoints if they are specified. The route will take into account factors such as current traffic and the typical road speeds on the requested day of the week and time of day.
        /// Information returned includes the distance, estimated travel time, and a representation of the route geometry.Additional routing information such as optimized waypoint order or turn by turn instructions is also available, depending on the options selected.
        /// Routing service provides a set of parameters for a detailed description of vehicle-specific Consumption Model.Please check Consumption Model for detailed explanation of the concepts and parameters involved.
        /// </summary>
        /// <param name="from"></param>
        /// <param name="to"></param>
        /// <param name="wayPoints"></param>
        /// <returns></returns>
        public async Task<Response<RouteDirectionsResponse>> GetRouteDirections(RouteRequestDirections routeReq)
        {
            var res = await ExecuteRequest<RouteDirectionsResponse, RouteRequestDirections>
                ("https://atlas.microsoft.com/route/directions/json", routeReq);
            return res;

        }


        /// <summary>
        /// This service will calculate a set of locations that can be reached from the origin point based on fuel, energy, or time budget that is specified. A polygon boundary (or Isochrone) is returned in a counterclockwise orientation as well as the precise polygon center which was the result of the origin point.
        /// 
        /// The returned polygon can be used for further processing such as Search Inside Geometry to search for POIs within the provided Isochrone
        /// </summary>
        /// <param name="routeRequest"></param>
        /// <returns></returns>
        public async Task<Response<RouteRangeResponse>> GetRouteRange(RouteRangeRequest routeRequest)
        {
            var res = await ExecuteRequest<RouteRangeResponse, RouteRangeRequest>
                ("https://atlas.microsoft.com/route/range/json", routeRequest);
            return res;
        }

        /// <summary>
        /// The Route Directions Batch API allows the caller to batch up to 1,000 Route Directions API queries/requests using just a single API call.
        /// </summary>
        /// <param name="routeRequest"></param>
        /// <returns></returns>
        public async Task<(string ResultUrl, Exception ex)> GetRouteDirections(IEnumerable<RouteRequestDirections> routeRequestItems)
        {
            try
            {
                var url = $"https://atlas.microsoft.com/route/directions/batch/json?subscription-key={Key}&api-version=1.0";

                var queryCollection = GetSearchQuery<RouteRequestDirections>(routeRequestItems);
                var q = new { queries = queryCollection };
                var queryContent = Newtonsoft.Json.JsonConvert.SerializeObject(q);

                using (var responseMessage = await GetHttpResponseMessage(url, queryContent))
                {

                    var resultUrl = responseMessage.Headers.GetValues("Location").First();
                    return (resultUrl, null);
                }

            }
            catch (Exception ex)
            {
                return (string.Empty, ex);
            }
        }

        /// <summary>
        /// The Matrix Routing service allows calculation of a matrix of route summaries for a set of routes defined by origin and destination locations. For every given origin, this service calculates the cost of routing from that origin to every given destination. The set of origins and the set of destinations can be thought of as the column and row headers of a table and each cell in the table contains the costs of routing from the origin to the destination for that cell. For each route, the travel times and distances are calculated. You can use the computed costs to determine which routes to calculate using the Routing Directions API. If the computation takes longer than 20 seconds or forceAsyn parameter in the request is set to true, this API returns a 202 response code along a redirect URL in the Location field of the response header. This URL should be checked periodically until the response data or error information is available. 
        /// The asynchronous responses are stored for 14 days. The redirect URL returns a 400 response if used after the expiration period.
        /// </summary>
        /// <param name="routeMatrixRequest"></param>
        /// <param name="coordinatesOrigins"></param>
        /// <param name="coordinatesDestinations"></param>
        /// <returns></returns>
        public async Task<(RouteMatrixResponse matrix, Exception ex)> GetRouteMatrix(RouteMatrixRequest routeMatrixRequest, IEnumerable<Coordinate> coordinatesOrigins, IEnumerable<Coordinate> coordinatesDestinations)
        {
            try
            {
                var url = $"https://atlas.microsoft.com/route/matrix/json?subscription-key={Key}";
                url += GetQuery<RouteMatrixRequest>(routeMatrixRequest, true);

                var originPoints = GetMultipPoint(coordinatesOrigins);
                var destinationsPoint = GetMultipPoint(coordinatesDestinations);

                var body = new
                {
                    origins = originPoints,
                    destinations = destinationsPoint
                };

                string data = Newtonsoft.Json.JsonConvert.SerializeObject(body);

                using (var response = await GetHttpResponseMessage(url, data))
                {
                    using (var responseMessage = response.Content)
                    {
                        var responseData = await responseMessage.ReadAsStringAsync();
                        var matrix = Newtonsoft.Json.JsonConvert.DeserializeObject<RouteMatrixResponse>(responseData);
                        return (matrix, null);
                    }
                }
            }
            catch (Exception ex)
            {
                return (null, ex);
            }
        }

        #endregion

        #region Search

        /// <summary>
        /// In many cases, the complete search service might be too much, for instance if you are only interested in traditional geocoding. Search can also be accessed for address look up exclusively. The geocoding is performed by hitting the geocode endpoint with just the address or partial address in question. The geocoding search index will be queried for everything above the street level data. No POIs will be returned. Note that the geocoder is very tolerant of typos and incomplete addresses. It will also handle everything from exact street addresses or street or intersections as well as higher level geographies such as city centers, counties, states etc.
        /// </summary>
        /// <param name="searchAddressRequest"></param>
        /// <returns></returns>
        public async Task<Response<SearchAddressResponse>> GetSearchAddress(SearchAddressRequest searchAddressRequest)
        {

            var res = await ExecuteRequest<SearchAddressResponse, SearchAddressRequest>("https://atlas.microsoft.com/search/address/json", searchAddressRequest);
            return res;

        }

        /// <summary>
        /// There may be times when you need to translate a coordinate (example: 37.786505, -122.3862) into a human understandable street address. Most often this is needed in tracking applications where you receive a GPS feed from the device or asset and wish to know what address where the coordinate is located. This endpoint will return address information for a given coordinate
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        public async Task<Response<SearchAddressReverseResponse>> GetSearchAddressReverse(SearchAddressReverseRequest request)
        {

            var res = await ExecuteRequest<SearchAddressReverseResponse, SearchAddressReverseRequest>("https://atlas.microsoft.com/search/address/reverse/json", request);
            return res;

        }

        /// <summary>
        /// There may be times when you need to translate a coordinate (example: 37.786505, -122.3862) into a human understandable cross street. Most often this is needed in tracking applications where you receive a GPS feed from the device or asset and wish to know what address where the coordinate is located.
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        public async Task<Response<SearchAddressReverseCrossStreetResponse>> GetSearchAddressReverseCrossStreet(SearchAddressReverseCrossStreetRequest request)
        {

            var res = await ExecuteRequest<SearchAddressReverseCrossStreetResponse, SearchAddressReverseCrossStreetRequest>("https://atlas.microsoft.com/search/address/reverse/crossStreet/json", request);
            return res;

        }

        /// <summary>
        /// Azure Address Geocoding can also be accessed for structured address look up exclusively. The geocoding search index will be queried for everything above the street level data. No POIs will be returned. Note that the geocoder is very tolerant of typos and incomplete addresses. It will also handle everything from exact street addresses or street or intersections as well as higher level geographies such as city centers, counties, states etc.
        /// </summary>
        /// <param name="req"></param>
        /// <returns></returns>
        public async Task<Response<SearchAddressStructuredResponse>> GetSearchAddressStructured(SearchAddressStructuredRequest req)
        {

            var res = await ExecuteRequest<SearchAddressStructuredResponse, SearchAddressStructuredRequest>("https://atlas.microsoft.com/search/address/structured/json", req);
            return res;
        }
        /// <summary>
        /// The basic default API is Free Form Search which handles the most fuzzy of inputs handling any combination of address or POI tokens. This search API is the canonical 'single line search'. The Free Form Search API is a seamless combination of POI search and geocoding. The API can also be weighted with a contextual position (lat./lon. pair), or fully constrained by a coordinate and radius, or it can be executed more generally without any geo biasing anchor point.
        /// We strongly advise you to use the 'countrySet' parameter to specify only the countries for which your application needs coverage, as the default behavior will be to search the entire world, potentially returning unnecessary results.
        /// Most Search queries default to maxFuzzyLevel=2 to gain performance and also reduce unusual results. This new default can be overridden as needed per request by passing in the query param maxFuzzyLevel=3 or 4.
        /// </summary>
        /// <param name="req"></param>
        /// <returns></returns>
        public async Task<Response<SearchFuzzyResponse>> GetSearchFuzzy(SearchFuzzyRequest req)
        {
            var res = await ExecuteRequest<SearchFuzzyResponse, SearchFuzzyRequest>("https://atlas.microsoft.com/search/fuzzy/json", req);
            return res;

        }

        /// <summary>
        /// If you have a use case for only retrieving POI results around a specific location, the nearby search method may be the right choice. This endpoint will only return POI results, and does not take in a search query parameter.
        /// </summary>
        /// <param name="req"></param>
        /// <returns></returns>
        public async Task<Response<SearchNearbyResponse>> GetSearchNearby(SearchNearbyRequest req)
        {
            var res = await ExecuteRequest<SearchNearbyResponse, SearchNearbyRequest>("https://atlas.microsoft.com/search/nearby/json", req);
            return res;
        }

        /// <summary>
        /// If your search use case only requires POI results, you may use the POI endpoint for searching. This endpoint will only return POI results.
        /// </summary>
        /// <param name="req"></param>
        /// <returns></returns>
        public async Task<Response<SearchPoiResponse>> GetSearchPoi(SearchPoiRequest req)
        {
            var res = await ExecuteRequest<SearchPoiResponse, SearchPoiRequest>("https://atlas.microsoft.com/search/poi/json", req);
            return res;
        }

        /// <summary>
        /// If your search use case only requires POI results filtered by category, you may use the category endpoint. This endpoint will only return POI results which are categorized as specified.
        /// </summary>
        /// <param name="req"></param>
        /// <returns></returns>
        public async Task<Response<SearchPoiCategoryResponse>> GetSearchPOICategory(SearchPoiCategoryRequest req)
        {
            var res = await ExecuteRequest<SearchPoiCategoryResponse, SearchPoiCategoryRequest>("https://atlas.microsoft.com/search/poi/category/json", req);
            return res;
        }

        /// <summary>
        /// he Search Address Batch API allows the caller to batch up to 10,000 Search Address API queries/requests using just a single API call.
        /// </summary>
        /// <param name="req"></param>
        /// <returns></returns>
        public async Task<(string ResultUrl, Exception ex)> GetSearchAddress(IEnumerable<SearchAddressRequest> req)
        {
            try
            {
                var url = $"https://atlas.microsoft.com/search/address/batch/json?subscription-key={Key}&api-version=1.0";
                var queryCollection = GetSearchQuery<SearchAddressRequest>(req);

                var q = new { queries = queryCollection };

                var queryContent = Newtonsoft.Json.JsonConvert.SerializeObject(q);

                using (var responseMessage = await GetHttpResponseMessage(url, queryContent))
                {

                    var resultUrl = responseMessage.Headers.GetValues("Location").First();
                    return (resultUrl, null);
                }

            }
            catch (Exception ex)
            {
                return (string.Empty, ex);
            }
        }

        /// <summary>
        /// The Search Address Reverse Batch API allows the caller to batch up to 10,000 Search Address Reverse API queries/requests using just a single API call.
        /// </summary>
        /// <param name="req"></param>
        /// <returns></returns>
        public async Task<(string ResultUrl, Exception ex)> GetSearchAddressReverse(IEnumerable<SearchAddressReverseRequest> req)
        {
            try
            {
                var url = $"https://atlas.microsoft.com/search/address/reverse/batch/json?subscription-key={Key}&api-version=1.0";
                var queryCollection = GetSearchQuery<SearchAddressReverseRequest>(req);

                var q = new { queries = queryCollection };

                var queryContent = Newtonsoft.Json.JsonConvert.SerializeObject(q);

                using (var responseMessage = await GetHttpResponseMessage(url, queryContent))
                {
                    var resultUrl = responseMessage.Headers.GetValues("Location").First();
                    return (resultUrl, null);
                }

            }
            catch (Exception ex)
            {
                return (string.Empty, ex);
            }
        }

        /// <summary>
        /// The Search Along Route endpoint allows you to perform a fuzzy search for POIs along a specified route. This search is constrained by specifying the maxDetourTime limiting measure.
        /// To send the route-points you will use a POST request where the request body will contain the route object represented as a GeoJSON LineString type and the Content-Type header will be set to application/json. Each route-point in route is represented as a GeoJSON Position type i.e. an array where the longitude value is followed by the latitude value and the altitude value is ignored. The route should contain at least 2 route-points.
        /// It is possible that original route will be altered, some of it's points may be skipped. If the route that passes through the found point is faster than the original one, the detourTime value in the response is negative.
        /// </summary>
        /// <param name="req"></param>
        /// <param name="lineString"></param>
        /// <returns></returns>
        public async Task<Response<SearchAlongRouteResponse>> GetSearchAlongRoute(SearchAlongRouteRequest req, LineString lineString)
        {
            try
            {
                var bodyContent = new { route = lineString };

                var queryContent = Newtonsoft.Json.JsonConvert.SerializeObject(bodyContent);

                var args = GetQuery<SearchAlongRouteRequest>(req, true);

                var url = $"https://atlas.microsoft.com/search/alongRoute/json?subscription-key={Key}&api-version=1.0{args}";

                using (var responseMsg = await GetHttpResponseMessage(url, queryContent))
                {
                    using (var data = responseMsg.Content)
                    {
                        var content = await data.ReadAsStringAsync();
                        var response = Newtonsoft.Json.JsonConvert.DeserializeObject<SearchAlongRouteResponse>(content);
                        return Response<SearchAlongRouteResponse>.CreateResponse(response);
                    }
                }
            }
            catch (Exception ex)
            {
                return Response<SearchAlongRouteResponse>.CreateErrorResponse(ex);
            }
        }


        /// <summary>
        /// The Search Fuzzy Batch API allows the caller to batch up to 10,000 Search Fuzzy API queries/requests using just a single API call.
        /// </summary>
        /// <param name="req"></param>
        /// <returns></returns>
        public async Task<(string ResultUrl, Exception ex)> GetSearchFuzzy(IEnumerable<SearchFuzzyRequest> req)
        {
            try
            {
                var url = $"https://atlas.microsoft.com/search/fuzzy/batch/json?subscription-key={Key}&api-version=1.0";

                var queryCollection = GetSearchQuery<SearchFuzzyRequest>(req);

                var q = new { queries = queryCollection };

                var queryContent = Newtonsoft.Json.JsonConvert.SerializeObject(q);

                using (var responseMessage = await GetHttpResponseMessage(url, queryContent))
                {
                    var resultUrl = responseMessage.Headers.GetValues("Location").First();
                    return (resultUrl, null);
                }
            }
            catch (Exception ex)
            {
                return (null, ex);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="request"></param>
        /// <param name="geoJson"></param>
        /// <returns></returns>
        public async Task<Response<SearchGeometryResponse>> GetSearchInsidePolygon(SearchInsidePolygonRequest request, Object geoJson)
        {
            try
            {
                var g = new { geometry = geoJson };

                var json = Newtonsoft.Json.JsonConvert.SerializeObject(g);

                var args = GetQuery<SearchInsidePolygonRequest>(request, false);

                var url = $"https://atlas.microsoft.com/search/geometry/json?subscription-key={Key}&api-version=1.0{args}";

                using (var responseMsg = await GetHttpResponseMessage(url, json))
                {
                    using (var data = responseMsg.Content)
                    {
                        var content = await data.ReadAsStringAsync();
                        var response = Newtonsoft.Json.JsonConvert.DeserializeObject<SearchGeometryResponse>(content);
                        return Response<SearchGeometryResponse>.CreateResponse(response);
                    }
                }
            }
            catch (Exception ex)
            {

                return Response<SearchGeometryResponse>.CreateErrorResponse(ex);
            }
        }


        #endregion

        #region TimeZone

        /// <summary>
        /// This API returns current, historical, and future time zone information for a specified latitude-longitude pair.
        /// </summary>
        /// <param name="req"></param>
        /// <returns></returns>
        public async Task<Response<TimezoneResult>> GetTimezoneByCoordinates(TimeZoneRequest req)
        {
            var res = await ExecuteRequest<TimezoneResult, TimeZoneRequest>
                ("https://atlas.microsoft.com/timezone/byCoordinates/json", req);
            return res;
        }

        /// <summary>
        /// This API returns current, historical, and future time zone information for the specified IANA time zone ID.
        /// </summary>
        /// <param name="req"></param>
        /// <returns></returns>
        public async Task<Response<TimezoneResult>> GetTimezoneById(TimeZoneRequest req)
        {
            var res = await ExecuteRequest<TimezoneResult, TimeZoneRequest>
                ("https://atlas.microsoft.com/timezone/byId/json", req);
            return res;
        }

        public async Task<Response<IEnumerable<IanaId>>> GetTimezoneEnumIANA()
        {
            var req = new RequestBase();
            var res = await ExecuteRequest<IEnumerable<IanaId>, RequestBase>
                ("https://atlas.microsoft.com/timezone/enumIana/json", req);
            return res;
        }

        /// <summary>
        /// This API returns a full list of Windows Time Zone IDs.
        /// </summary>
        /// <returns></returns>
        public async Task<Response<IEnumerable<TimezoneEnumWindow>>> GetTimezoneEnumWindows()
        {
            var req = new RequestBase();
            var res = await ExecuteRequest<IEnumerable<TimezoneEnumWindow>, RequestBase>
                ("https://atlas.microsoft.com/timezone/enumWindows/json", req);
            return res;
        }


        /// <summary>
        /// This API returns the current IANA version number.
        /// </summary>
        /// <returns></returns>
        public async Task<Response<TimezoneIanaVersionResult>> GetTimezoneIANAVersion()
        {
            var req = new RequestBase();
            var res = await ExecuteRequest<TimezoneIanaVersionResult, RequestBase>
                ("https://atlas.microsoft.com/timezone/ianaVersion/json", req);

            return res;

        }

        /// <summary>
        /// This API returns a corresponding IANA ID, given a valid Windows Time Zone ID. Multiple IANA IDs may be returned for a single Windows ID. It is possible to narrow these results by adding an optional territory parameter.
        /// </summary>
        /// <param name="req"></param>
        /// <returns></returns>
        public async Task<Response<IEnumerable<IanaId>>> GetTimezoneWindowsToIANA(TimezoneWindowsToIANARequest req)
        {
            var res = await ExecuteRequest<IEnumerable<IanaId>, TimezoneWindowsToIANARequest>
                ("https://atlas.microsoft.com/timezone/windowsToIana/json", req);
            return res;
        }


        #endregion

        #region Traffic

        /// <summary>
        /// This service provides information about the speeds and travel times of the road fragment closest to the given coordinates. It is designed to work alongside the Flow layer of the Render Service to support clickable flow data visualizations. With this API, the client side can connect any place in the map with flow data on the closest road and present it to the user.
        /// </summary>
        /// <param name="req"></param>
        /// <returns></returns>
        public async Task<Response<TrafficFlowSegmentResult>> GetTrafficFlowSegment(TrafficFlowSegmentRequest req)
        {
            var res = await ExecuteRequest<TrafficFlowSegmentResult, TrafficFlowSegmentRequest>
                ("https://atlas.microsoft.com/traffic/flow/segment/json", req);
            return res;
        }


        /// <summary>
        /// The Azure Flow Tile API serves 256 x 256 pixel tiles showing traffic flow. All tiles use the same grid system. Because the traffic tiles use transparent images, they can be layered on top of map tiles to create a compound display. The Flow tiles use colors to indicate either the speed of traffic on different road segments, or the difference between that speed and the free-flow speed on the road segment in question.
        /// </summary>
        /// <param name="req"></param>
        /// <returns></returns>

        public async Task<Response<byte[]>> GetTrafficFlowTile(TrafficFlowTileRequest req)
        {
            try
            {
                var baseAddress = "https://atlas.microsoft.com/traffic/flow/tile/png";
                Url += GetQuery<TrafficFlowTileRequest>(req, true);

                var content = await GetByteArray(baseAddress, Url);

                var response = Response<byte[]>.CreateResponse(content);

                return response;
            }
            catch (Exception ex)
            {
                return Response<byte[]>.CreateErrorResponse(ex);
            }
        }

        /// <summary>
        /// Traffic Incident Detail This API provides information on traffic incidents inside a given bounding box, based on the current Traffic Model ID. The Traffic Model ID is available to grant synchronization of data between calls and API's. The Traffic Model ID is a key value for determining the currency of traffic incidents. It is updated every minute, and is valid for two minutes before it times out. It is used in rendering incident tiles. It can be obtained from the Viewport API.
        /// </summary>
        /// <returns></returns>
        public async Task<Response<TrafficIncidentDetailResult>> GetTrafficIncidentDetail(TrafficIncidentDetailRequest req)
        {
           
                var res = await ExecuteRequest<TrafficIncidentDetailResult, TrafficIncidentDetailRequest>
                    ("https://atlas.microsoft.com/traffic/incident/detail/json", req);
                return res;
        }


        /// <summary>
        /// This API provides information on traffic incidents inside a given bounding box, based on the current Traffic Model ID. The Traffic Model ID is available to grant synchronization of data between calls and API's. The Traffic Model ID is a key value for determining the currency of traffic incidents. It is updated every minute, and is valid for two minutes before it times out. It is used in rendering traffic tiles. It can be obtained from the Viewport API.
        /// </summary>
        /// <param name="req"></param>
        /// <returns></returns>
        public async Task<Response<byte[]>> GetTrafficIncidentTile(TrafficIncidentTileRequest req)
        {
            try
            {
                var baseAddress = "https://atlas.microsoft.com/traffic/incident/tile/png";
                Url += GetQuery<TrafficIncidentTileRequest>(req, true);

                var content = await GetByteArray(baseAddress, Url);

                var response = Response<byte[]>.CreateResponse(content);

                return response;
            }
            catch (Exception ex)
            {

                return Response<byte[]>.CreateErrorResponse(ex);
            }
        }

        /// <summary>
        /// This API returns legal and technical information for the viewport described in the request. It should be called by client applications whenever the viewport changes (for instance, through zooming, panning, going to a location, or displaying a route). The request should contain the bounding box and zoom level of the viewport whose information is needed. The return will contain map version information, as well as the current Traffic Model ID and copyright IDs. The Traffic Model ID returned by the Viewport Description is used by other APIs to retrieve last traffic information for further processing.
        /// </summary>
        /// <returns></returns>
        public async Task<Response<TrafficIncidentViewportResult>> GetTrafficIncidentViewport(TrafficIncidentViewportRequest req)
        {
            var res = await ExecuteRequest<TrafficIncidentViewportResult, TrafficIncidentViewportRequest>
                    ("https://atlas.microsoft.com/traffic/incident/viewport/json", req);
            return res;
        }

        #endregion

    }
}
