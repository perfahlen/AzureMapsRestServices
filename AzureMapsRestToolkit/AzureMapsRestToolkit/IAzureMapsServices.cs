using AzureMapsToolkit.Common;
using AzureMapsToolkit.Data;
using AzureMapsToolkit.GeoJson;
using AzureMapsToolkit.Render;
using AzureMapsToolkit.Search;
using AzureMapsToolkit.Spatial;
using AzureMapsToolkit.Timezone;
using AzureMapsToolkit.Traffic;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace AzureMapsToolkit
{
    public interface IAzureMapsServices
    {
        Task<Response<PostPointInPolygonResponse>> PostPointInPolygon(PostPointInPolygonRequest req, string geoJson);

        Task<Response<GeofenceResponse>> PostGeofence(PostGeofenceRequest req, string geoJson);

        Task<Response<ClosestPointResponse>> PostClosestPoint(PostClosestPointRequest req, string geoJson);

        Task<Response<GetBufferResponse>> PostBuffer(string json);

        Task<Response<PointInPolygonResponse>> GetPointInPolygon(PointInPolygonRequest req);

        Task<Response<GreatCircleDistanceResponse>> GetGreatCircleDistance(GreatCircleDistanceRequest req);

        Task<Response<GeofenceResponse>> GetGeofence(GetGeofenceRequest req);

        Task<Response<ClosestPointResponse>> GetClosestPoint(GetClosestPointRequest request);

        Task<Response<GetBufferResponse>> GetBuffer(GetBufferRequest requests, string format);

        Task<Response<UploadResult>> Upload(string geoJson, string dataFormat = "geojson");

        Task<Response<UpdateResult>> Update(Guid udid, string geoJson = "geojson");

        Task<Response<MapDataListResponse>> GetList();

        Task<Response<string>> Download(string udid);

        Task<Response<bool>> DeleteData(Guid udid);

        Task<Response<Geolocation.IpAddressToLocationResult>> GetIPToLocation(string ip, string apiVersion = "1.0");

        Task<Response<Render.CopyrightCaptionResult>> GetCopyrightCaption(string apiVersion = "1.0");

        Task<Response<Render.CopyrightResult>> GetCopyrightForTile(CopyrightForTileRequest req);
        
        Task<Response<Render.CopyrightResult>> GetCopyrightForWorld(string apiVersion = "1.0");

        Task<Response<Render.CopyrightResult>> GetCopyrightFromBoundingBox(CopyrightFromBoundingBoxRequest req);

        Task<Response<byte[]>> GetMapImage(MapImageRequest req);

        Task<Response<byte[]>> GetMapImageryTile(MapImageryTileRequest req);

        Task<Response<byte[]>> GetMapTile(MapTileRequest req);

        Task<Response<RouteDirectionsResponse>> GetRouteDirections(RouteRequestDirections routeReq);

        Task<Response<RouteRangeResponse>> GetRouteRange(RouteRangeRequest routeRequest);

        Task<(string ResultUrl, Exception ex)> GetRouteDirections(IEnumerable<RouteRequestDirections> routeRequestItems);

        Task<(RouteMatrixResponse matrix, Exception ex)> GetRouteMatrix(RouteMatrixRequest routeMatrixRequest, IEnumerable<Common.Coordinate> coordinatesOrigins, IEnumerable<Common.Coordinate> coordinatesDestinations);

        Task<Response<SearchAddressResponse>> GetSearchAddress(SearchAddressRequest searchAddressRequest);

        Task<Response<SearchAddressReverseResponse>> GetSearchAddressReverse(SearchAddressReverseRequest request);

        Task<Response<SearchAddressReverseCrossStreetResponse>> GetSearchAddressReverseCrossStreet(SearchAddressReverseCrossStreetRequest request);

        Task<Response<SearchAddressStructuredResponse>> GetSearchAddressStructured(SearchAddressStructuredRequest req);

        Task<Response<SearchFuzzyResponse>> GetSearchFuzzy(SearchFuzzyRequest req);

        Task<Response<SearchNearbyResponse>> GetSearchNearby(SearchNearbyRequest req);

        Task<Response<SearchPoiResponse>> GetSearchPoi(SearchPoiRequest req);

        Task<Response<SearchPoiCategoryResponse>> GetSearchPOICategory(SearchPoiCategoryRequest req);

        Task<(string ResultUrl, Exception ex)> GetSearchAddress(IEnumerable<SearchAddressRequest> req);

        Task<(string ResultUrl, Exception ex)> GetSearchAddressReverse(IEnumerable<SearchAddressReverseRequest> req);

        Task<Response<SearchAlongRouteResponse>> GetSearchAlongRoute(SearchAlongRouteRequest req, LineString lineString);

        Task<(string ResultUrl, Exception ex)> GetSearchFuzzy(IEnumerable<SearchFuzzyRequest> req);

        Task<Response<SearchGeometryResponse>> GetSearchInsidePolygon(SearchInsidePolygonRequest request, Object geoJson);

        Task<Response<TimezoneResult>> GetTimezoneByCoordinates(TimeZoneRequest req);

        Task<Response<TimezoneResult>> GetTimezoneById(TimeZoneRequest req);

        Task<Response<IEnumerable<IanaId>>> GetTimezoneEnumIANA();

        Task<Response<IEnumerable<TimezoneEnumWindow>>> GetTimezoneEnumWindows();

        Task<Response<TimezoneIanaVersionResult>> GetTimezoneIANAVersion();

        Task<Response<IEnumerable<IanaId>>> GetTimezoneWindowsToIANA(TimezoneWindowsToIANARequest req);

        Task<Response<TrafficFlowSegmentResult>> GetTrafficFlowSegment(TrafficFlowSegmentRequest req);

        Task<Response<byte[]>> GetTrafficFlowTile(TrafficFlowTileRequest req);

        Task<Response<TrafficIncidentDetailResult>> GetTrafficIncidentDetail(TrafficIncidentDetailRequest req);

        Task<Response<byte[]>> GetTrafficIncidentTile(TrafficIncidentTileRequest req);

        Task<Response<TrafficIncidentViewportResult>> GetTrafficIncidentViewport(TrafficIncidentViewportRequest req);


    }
}
