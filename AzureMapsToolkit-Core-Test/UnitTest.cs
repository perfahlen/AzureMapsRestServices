using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json;
using System.Threading.Tasks;

using Azure.Core.GeoJson;

using AzureMapsToolkit;
using AzureMapsToolkit.Common;
using AzureMapsToolkit.GeoJson;
using AzureMapsToolkit.Mobility;
using AzureMapsToolkit.Render;
using AzureMapsToolkit.Route;
using AzureMapsToolkit.Search;
using AzureMapsToolkit.Timezone;
using AzureMapsToolkit.Traffic;
using AzureMapsToolkit.Weather;
using Xunit;

namespace AzureMapsToolkit_Core_Test
{
    public class UnitTest
    {

        const string _KEY = AzureMapsKey._KEY;


        [Fact]
        public async Task InvalidIPCountry()
        {
            var am = new AzureMapsToolkit.AzureMapsServices(_KEY);
            var res = await am.GetIPToLocation("83.10.0.3");

            Assert.NotEqual("SE", res.Result.CountryRegion.IsoCode);

        }

        [Fact]
        public async Task ValidIPCountry()
        {
            var am = new AzureMapsToolkit.AzureMapsServices(_KEY);
            var res = await am.GetIPToLocation("83.68.254.182");

            Assert.Equal("SE", res.Result.CountryRegion.IsoCode);

        }

        [Fact]
        public async Task InvaliddIPAddress()
        {
            var am = new AzureMapsToolkit.AzureMapsServices(_KEY);
            var res = await am.GetIPToLocation("perfa");
            Assert.True(res.Error != null);
        }

        [Fact]
        public async Task GetCopyrightCaption()
        {
            var am = new AzureMapsToolkit.AzureMapsServices(_KEY);
            var result = await am.GetCopyrightCaption();
            Assert.Contains("TomTom", result.Result.CopyrightsCaption);
        }

        [Fact]
        public async Task GetCopyrightForTile()
        {
            var am = new AzureMapsToolkit.AzureMapsServices(_KEY);
            var req = new AzureMapsToolkit.Render.CopyrightForTileRequest
            {
                Zoom = 6,
                X = 9,
                Y = 22,
                Text = "yes"
            };
            var resp = await am.GetCopyrightForTile(req);
            Assert.Equal("CAN", resp.Result.Regions[0].Country.ISO3);
        }

        [Fact]
        public async Task GetCopyrightForWorld()
        {
            var am = new AzureMapsToolkit.AzureMapsServices(_KEY);
            _ = await am.GetCopyrightForWorld();

        }

        [Fact]
        public async Task GetCopyrightFromBoundingBox()
        {
            var am = new AzureMapsToolkit.AzureMapsServices(_KEY);
            var req = new CopyrightFromBoundingBoxRequest
            {
                Mincoordinates = "52.41064,4.84228",
                Maxcoordinates = "52.41072,4.84239",
                Text = "yes"
            };
            var res = await am.GetCopyrightFromBoundingBox(req);

            Assert.Null(res.Error);
        }

        [Fact]
        public async Task GetMapImage()
        {
            var am = new AzureMapsToolkit.AzureMapsServices(_KEY);
            var req = new MapImageRequest
            {
                Format = AzureMapsToolkit.Render.RasterTileFormat.png,
                Layer = StaticMapLayer.basic,
                Zoom = 2,
                Center = "62,17"
            };
            var content = await am.GetMapImage(req);
            Assert.NotEmpty(content.Result);

        }

        [Fact]
        public async Task GetMapImageryTilePreview()
        {
            var am = new AzureMapsToolkit.AzureMapsServices(_KEY);
            var req = new MapImageryTileRequest
            {
                Format = RasterTileFormat.png,
                Zoom = 6,
                X = 10,
                Y = 22,
                Style = MapImageryStyle.satellite
            };
            var content = await am.GetMapImageryTile(req);
            Assert.NotEmpty(content.Result);
        }


        [Fact]
        public async Task GetMapTile()
        {
            var am = new AzureMapsToolkit.AzureMapsServices(_KEY);
            var req = new MapTileRequest
            {
                Format = TileFormat.png,
                Layer = StaticMapLayer.basic,
                Style = MapTileStyle.main,
                Zoom = 6,
                X = 10,
                Y = 22
            };

            var content = await am.GetMapTile(req);
            Assert.NotEmpty(content.Result);
        }

        [Fact]
        public async Task GetRouteDirections()
        {

            var am = new AzureMapsToolkit.AzureMapsServices(_KEY);
            var req = new RouteRequestDirections
            {
                //Query = "52.50931,13.42936:52.50274,13.43872"
                Query = "62.469026,16.696987:62.397051,17.363892",
                Avoid = Avoid.tollRoads
            };
            var directions = await am.GetRouteDirections(req);
            Assert.Null(directions.Error);
            Assert.NotNull(directions.Result);
        }

        [Fact]
        public async Task GetRouteDirectionsError()
        {

            var am = new AzureMapsToolkit.AzureMapsServices(_KEY);
            var req = new RouteRequestDirections
            {
                Query = "52.50931,13.42936:52.50274,13.43872f", // intentially error
                VehicleEngineType = VehicleEngineType.Combustion,
                InstructionsType = RouteInstructionsType.text
            };
            var directions = await am.GetRouteDirections(req);
            Assert.NotNull(directions.Error);
        }

        [Fact]
        public async Task GetRouteRange()
        {

            var am = new AzureMapsToolkit.AzureMapsServices(_KEY);
            var req = new RouteRangeRequest
            {
                Query = "52.50931,13.42936",
                TimeBudgetInSec = "12000"
            };
            var range = await am.GetRouteRange(req);
            Assert.NotNull(range.Result.ReachableRange.Boundary);
        }

        [Fact]
        public async Task GetPostRouteDirections()
        {

            var am = new AzureMapsToolkit.AzureMapsServices(_KEY);
            var req = new List<PostRouteDirectionsRequest>
            {
                new PostRouteDirectionsRequest
                {
                    Query = "47.620659,-122.348934:47.610101,-122.342015",
                    RouteType = RouteType.Fastest,
                    TravelMode = TravelMode.Car
                },

                new PostRouteDirectionsRequest
                {
                    Query = "40.759856,-73.985108:40.771136,-73.973506",
                    TravelMode = TravelMode.Pedestrian,
                    RouteType = RouteType.Shortest
                },

                new PostRouteDirectionsRequest
                {
                    Query = "48.923159,-122.557362:32.621279,-116.840362"
                }
            };

            var (ResultUrl, ex) = await am.GetRouteDirections(req);

            Assert.Null(ex);

            Assert.NotNull(ResultUrl);

            Assert.True(ResultUrl.Length > 0);

        }


        [Fact]
        public async Task GetDistanceMatrix()
        {

            var am = new AzureMapsToolkit.AzureMapsServices(_KEY);

            var origins = new List<Coordinate> {
                new Coordinate { Longitude = 4.85106f, Latitude = 52.36006f },
                new Coordinate { Longitude = 4.85056f, Latitude = 52.36187f}
            };


            var destinations = new List<Coordinate> {
                new Coordinate { Longitude = 4.85003f, Latitude = 52.36241f },
                new Coordinate { Longitude =  13.42937f, Latitude = 52.50931f}
            };

            var (ResultUrl, ex) = await am.GetRouteMatrix(new RouteMatrixRequest
            {
                RouteType = RouteType.Fastest
            }, origins, destinations);

            Assert.Null(ex);

            Assert.NotNull(ResultUrl);

            GetDistanceMatrixResult();

        }

        [Fact]
        public async Task GetDistanceMatrixResult()
        {

            var am = new AzureMapsToolkit.AzureMapsServices(_KEY);
            var req = new RouteMatrixRequest
            {
                RouteType = RouteType.Fastest
            };

            var origins = new List<Coordinate> {
                new Coordinate { Longitude = 4.85106f, Latitude = 52.36006f },
                new Coordinate { Longitude = 4.85056f, Latitude = 52.36187f}
            };


            var destinations = new List<Coordinate> {
                new Coordinate { Longitude = 4.85003f, Latitude = 52.36241f },
                new Coordinate { Longitude =  13.42937f, Latitude = 52.50931f}
            };
            var (ResultUrl, _) = await am.GetRouteMatrix(req, origins, destinations);

            var matrixResponse = await am.GetRouteMatrixResult(ResultUrl);

            Assert.Null(matrixResponse.Error);
            Assert.NotNull(matrixResponse.Result);
        }


        [Fact]
        public async Task GetSearchAddress()
        {
            var am = new AzureMapsToolkit.AzureMapsServices(_KEY);

            //var searchAddressRequest = new SearchAddressRequest
            //{
            //    Query = "15127 NE 24th Street,Redmond, WA 98052",
            //    CountrySet = "US",
            //    Limit = 10
            //};

            var searchAddressRequest = new SearchAddressRequest
            {
                Query = "test",
                Lat = 51.3,
                Lon = 12.3,
                Language = "de-DE"
            };
            var resp = await am.GetSearchAddress(searchAddressRequest);

            Assert.Null(resp.Error);

            //Assert.Equal(14.15, resp.Result.Results[0].Score);

        }

        [Fact]
        public async Task GetSearchAddressReverse()
        {
            var am = new AzureMapsToolkit.AzureMapsServices(_KEY);

            var req = new SearchAddressReverseRequest
            {
                //Query = "37.337,-121.89",
                Query = "47.591180, -122.332700",
                EntityType = SearchAddressEntityType.Municipality | SearchAddressEntityType.PostalCodeArea
            };

            var resp = await am.GetSearchAddressReverse(req);

            Assert.Null(resp.Error);

            Assert.Equal(1, resp.Result.Summary.NumResults);
        }

        [Fact]
        public async Task GetSearchAddressReverseCrossStreet()
        {
            var am = new AzureMapsToolkit.AzureMapsServices(_KEY);

            var req = new SearchAddressReverseCrossStreetRequest
            {
                Query = "62.390132,17.305199"
            };

            var resp = await am.GetSearchAddressReverseCrossStreet(req);

            Assert.Null(resp.Error);

            Assert.Equal(1, resp.Result.Summary.NumResults);
        }

        [Fact]
        public async Task GetSearchAddressStructured()
        {
            var am = new AzureMapsToolkit.AzureMapsServices(_KEY);
            var req = new SearchAddressStructuredRequest
            {
                CountryCode = "SE",
                StreetNumber = "10",
                StreetName = "Storgatan",
                Municipality = "Sundsvall",
                PostalCode = "85230",
                CountrySubdivision = "Sundsvall",
                Offset = 1

            };
            var result = await am.GetSearchAddressStructured(req);

            Assert.Null(result.Error);

            Assert.Equal(1, result.Result.Summary.FuzzyLevel);

        }

        [Fact]
        public async Task GetSearchFuzzy()
        {
            var am = new AzureMapsToolkit.AzureMapsServices(_KEY);
            var req = new SearchFuzzyRequest
            {
                CountrySet = "US",
                Query = "seattle",
                IdxSet = new string[] { "Geo", "POI" }
            };
            var res = await am.GetSearchFuzzy(req);

            Assert.Null(res.Error);

            Assert.Equal(1, res.Result.Summary.FuzzyLevel);
        }

        [Fact]
        public async Task GetSearchNearby()
        {
            var am = new AzureMapsToolkit.AzureMapsServices(_KEY);
            var req = new SearchNearbyRequest
            {
                CountrySet = "US",
                Lat = 40.70627,
                Lon = -74.011454,
                Limit = 10,
                Radius = 8046
            };

            var res = await am.GetSearchNearby(req);

            Assert.Null(res.Error);

            Assert.Equal(1, res.Result.Summary.FuzzyLevel);
        }

        [Fact]
        public async Task GetSearchPoi()
        {
            var am = new AzureMapsToolkit.AzureMapsServices(_KEY);
            var req = new SearchPoiRequest
            {
                CountrySet = "US",
                Query = "juice bars",
                Limit = 5,
                Lat = 47.606038,
                Lon = -122.333345,
                Radius = 8074
            };

            var res = await am.GetSearchPoi(req);

            Assert.Null(res.Error);

        }

        [Fact]
        public async Task GetSearchPoiCategory()
        {
            var am = new AzureMapsToolkit.AzureMapsServices(_KEY);
            var req = new SearchPoiCategoryRequest
            {
                CountrySet = "US",
                Query = "atm",
                Limit = 3,
                Lat = 40.758953,
                Lon = -73.985263,
                Radius = 3200
            };

            var res = await am.GetSearchPOICategory(req);

            Assert.Null(res.Error);

        }

        [Fact]
        public async Task GetSearchAddressBatch()
        {
            var am = new AzureMapsToolkit.AzureMapsServices(_KEY);
            var req1 = new SearchAddressRequest
            {
                Query = "400 Broad St, Seattle, WA 98109",
                Limit = 3
            };
            var req2 = new SearchAddressRequest
            {
                Query = "One, Microsoft Way, Redmond, WA 98052",
                Limit = 3
            };
            var req3 = new SearchAddressRequest
            {
                Query = "350 5th Ave, New York, NY 10118",
                Limit = 3
            };

            var req = new SearchAddressRequest[] { req1, req2, req3 };

            var (ResultUrl, ex) = await am.GetSearchAddress(req);

            Assert.Null(ex);

            Assert.NotNull(ResultUrl);
        }

        [Fact]
        public async Task GetSearchAddressReverseBatch()
        {
            var am = new AzureMapsToolkit.AzureMapsServices(_KEY);
            var q1 = new SearchAddressReverseRequest
            {
                Query = "48.858561,2.294911"
            };
            var q2 = new SearchAddressReverseRequest
            {
                Query = "47.639765,-122.127896",
                Radius = 5000
            };
            var q3 = new SearchAddressReverseRequest
            {
                Query = "47.621028,-122.348170"
            };

            var req = new SearchAddressReverseRequest[] { q1, q2, q3 };

            var (ResultUrl, ex) = await am.GetSearchAddressReverse(req);

            Assert.Null(ex);

            Assert.NotNull(ResultUrl);
        }

        [Fact]
        public async Task GetSearchAlongRoute()
        {
            var am = new AzureMapsToolkit.AzureMapsServices(_KEY);

            var req = new SearchAlongRouteRequest
            {
                Limit = 2,
                MaxDetourTime = 1000,
                Query = "burger"
            };

            List<GeoPosition> coordinates = new()
            {
                new GeoPosition(-122.143035, 47.653536),
                new GeoPosition(-122.187164, 47.617556),
                new GeoPosition(-122.114981, 47.570599),
                new GeoPosition(-122.132756, 47.654009)
            };

            GeoLineString lineString = new(coordinates);

            var result = await am.GetSearchAlongRoute(req, lineString);

            Assert.Null(result.Error);

            Assert.Equal("NON_NEAR", result.Result.Summary.QueryType);

        }

        [Fact]
        public async Task GetSeachFuzzyBatch()
        {
            var am = new AzureMapsToolkit.AzureMapsServices(_KEY);

            var q1 = new SearchFuzzyRequest
            {
                Query = "atm",
                Lon = 47.639769,
                Lat = -122.128362,
                Radius = 5000,
                Limit = 5
            };

            var q2 = new SearchFuzzyRequest
            {
                Query = "Statue Of Liberty",
                Limit = 2
            };

            var q3 = new SearchFuzzyRequest
            {
                Query = "Starbucks",
                Lat = 47.639769,
                Lon = -122.128362,
                Radius = 5000
            };

            var req = new SearchFuzzyRequest[] { q1, q2, q3 };
            var (ResultUrl, ex) = await am.GetSearchFuzzy(req);

            Assert.Null(ex);

            Assert.NotNull(ResultUrl);

        }

        [Fact]
        public async Task SearchInsidePolygon()
        {
            var am = new AzureMapsToolkit.AzureMapsServices(_KEY);
            var coll = JsonSerializer.Deserialize<GeoCollection>("{\"type\":\"GeometryCollection\",\"geometries\":[{\"type\":\"Polygon\",\"coordinates\":[[[-122.43576049804686,37.7524152343544],[-122.43301391601562,37.70660472542312],[-122.36434936523437,37.712059855877314],[-122.43576049804686,37.7524152343544]]]}]}");
            var d = await am.GetSearchInsidePolygon(new SearchInsidePolygonRequest
            {
                Query = "burger"
            }, coll);

            Assert.Null(d.Error);

        }

        [Fact]
        public async Task GetTimeZoneByCoordinates()
        {
            var am = new AzureMapsToolkit.AzureMapsServices(_KEY);
            var req = new TimeZoneRequest
            {
                Query = "47.0,-122",
                Options = TimezoneOptions.All
            };
            var r = await am.GetTimezoneByCoordinates(req);

            Assert.Null(r.Error);
            Assert.Equal("US", r.Result.TimeZones[0].Countries[0].Code);
        }


        [Fact]
        public async Task GetTimeZoneById()
        {
            var am = new AzureMapsToolkit.AzureMapsServices(_KEY);
            var req = new TimeZoneRequest
            {
                Query = "Europe/Stockholm",
                Options = TimezoneOptions.All
            };
            var r = await am.GetTimezoneById(req);

            Assert.Null(r.Error);
            Assert.Equal("SE", r.Result.TimeZones[0].Countries[0].Code);
        }

        [Fact]
        public async Task GetTimezoneIANA()
        {
            var am = new AzureMapsToolkit.AzureMapsServices(_KEY);

            var r = await am.GetTimezoneEnumIANA();

            Assert.Null(r.Error);

        }

        [Fact]
        public async Task GetTimezoneEnumWindows()
        {
            var am = new AzureMapsToolkit.AzureMapsServices(_KEY);

            var r = await am.GetTimezoneEnumWindows();

            Assert.Null(r.Error);
            Assert.NotNull(r.Result);
        }

        [Fact]
        public async Task GetTimezoneIANAVersion()
        {
            var am = new AzureMapsToolkit.AzureMapsServices(_KEY);

            var r = await am.GetTimezoneIANAVersion();

            Assert.Null(r.Error);

            Assert.StartsWith("20", r.Result.Version);
        }


        [Fact]
        public async Task GetTimezoneWindowsToIANA()
        {
            var am = new AzureMapsToolkit.AzureMapsServices(_KEY);
            var req = new TimezoneWindowsToIANARequest
            {
                Query = "pacific standard time"
            };
            var r = await am.GetTimezoneWindowsToIANA(req);

            Assert.Null(r.Error);

            Assert.NotNull(r.Result);
        }

        [Fact]
        public async Task GetTrafficFlowSegment()
        {
            var am = new AzureMapsToolkit.AzureMapsServices(_KEY);
            var req = new TrafficFlowSegmentRequest
            {
                //Query = "52.41072,4.84239",
                Query = "62.40948,17.23301",
                Style = TrafficFlowSegmentStyle.Absolute,
                Zoom = 10
            };

            var r = await am.GetTrafficFlowSegment(req);

            Assert.Null(r.Error);

        }

        [Fact]
        public async Task GetTrafficFlowTile()
        {
            var am = new AzureMapsToolkit.AzureMapsServices(_KEY);
            var req = new TrafficFlowTileRequest
            {
                Style = TrafficFlowSegmentStyle.Absolute,
                Zoom = 12,
                X = 2044,
                Y = 1360
            };

            var r = await am.GetTrafficFlowTile(req);

            Assert.Null(r.Error);
        }

        [Fact]
        public async Task GetTrafficIncidentTile()
        {
            var am = new AzureMapsToolkit.AzureMapsServices(_KEY);
            var req = new TrafficIncidentTileRequest
            {
                Style = TrafficIncidentTileStyle.s1,
                Zoom = 12,
                X = 2044,
                Y = 1360
            };

            var r = await am.GetTrafficIncidentTile(req);

            Assert.Null(r.Error);
        }

        [Fact]
        public async Task GetTrafficIncidentDetail()
        {
            var am = new AzureMapsToolkit.AzureMapsServices(_KEY);
            var req = new TrafficIncidentDetailRequest
            {
                Style = TrafficIncidentTileStyle.s3,
                Boundingbox = "6841263.950712,511972.674418,6886056.049288,582676.925582",
                BoundingZoom = 11,
                Trafficmodelid = "1335294634919",
                Projection = "EPSG900913"
            };

            var r = await am.GetTrafficIncidentDetail(req);

            Assert.Null(r.Error);
        }

        [Fact]
        public async Task GetTrafficIncidentViewport()
        {
            var am = new AzureMapsToolkit.AzureMapsServices(_KEY);
            var req = new TrafficIncidentViewportRequest
            {
                Boundingbox = "-939584.4813015489,-23954526.723651607,14675583.153020501,25043442.895825107",
                Boundingzoom = 2,
                Overviewbox = "-939584.4813018347,-23954526.723651607,14675583.153020501,25043442.8958229083",
                Overviewzoom = 2,
                Copyright = true
            };

            var r = await am.GetTrafficIncidentViewport(req);

            Assert.Null(r.Error);

            Assert.Equal("world", r.Result.ViewpResp.Maps);
        }

        [Fact]
        public async Task GetSearchAddresstMoq()
        {

            var mock = new Moq.Mock<IAzureMapsServices>();
            var response = new Response<SearchAddressResponse>
            {
                Result = new SearchAddressResponse
                {
                    Summary = new SearchSummary { TotalResults = 1 },
                    Results = new SearchAddressResult[] { new SearchAddressResult
                    {
                        Address = new SearchResultAddress{ Country = "Sweden"}
                    }
                        }
                }
            };

            var setup = mock.Setup(x => x.GetSearchAddress(new SearchAddressRequest())).Returns(Task.FromResult(response));

            Assert.True(true);

        }

        [Fact]
        public async Task Upload()
        {
            return;
            var am = new AzureMapsToolkit.AzureMapsServices(_KEY);
            var json = "{ \"type\": \"FeatureCollection\", \"features\": [ { \"type\": \"Feature\", \"properties\": { \"geometryId\": 1001 }, \"geometry\": { \"type\": \"Polygon\", \"coordinates\": [ [ [ -111.9267386, 33.5362475 ], [ -111.9627875, 33.5104882 ], [ -111.9027061, 33.5004686 ], [ -111.9267386, 33.5362475 ] ] ] } } ] }";
            var res = await am.Upload(json);

            Assert.NotNull(res.Result);
            Assert.Null(res.Error);

        }

        [Fact]
        public async Task Update()
        {
            return;
            var am = new AzureMapsToolkit.AzureMapsServices(_KEY);

            var json = "{\"type\": \"FeatureCollection\", \"features\": [{\"type\": \"Feature\",\"geometry\": {\"type\": \"Point\",\"coordinates\": [-122.126986, 47.639754]}, \"properties\": {\"geometryId\": \"001\",\"radius\": 500}}]}";
            var res = await am.Update(System.Guid.Parse(""), json);

            Assert.NotNull(res.Result);
            Assert.Null(res.Error);

        }

        [Fact]
        public async Task DeleteData()
        {
            return;
            var am = new AzureMapsToolkit.AzureMapsServices(_KEY);
            var res = await am.DeleteData(System.Guid.Parse("895e6375-7d4e-0052-48c1-749d503cf522"));

            Assert.Null(res.Error);
            Assert.True(res.Result);
        }

        [Fact]
        public async Task ListData()
        {
            var am = new AzureMapsToolkit.AzureMapsServices(_KEY);
            var res = await am.GetList();
            Assert.InRange(res.Result.MapDataList.Count, 0, int.MaxValue);
        }

        [Fact]
        public async Task DownloadData()
        {
            var am = new AzureMapsToolkit.AzureMapsServices(_KEY);
            var res = await am.Download("");
            Assert.Null(res.Error);
            Assert.NotNull(res.Result);
        }

        [Fact]

        public async Task GetBuffer()
        {
            return;
            var am = new AzureMapsToolkit.AzureMapsServices(_KEY);
            var res = await am.GetBuffer(new AzureMapsToolkit.Spatial.BufferRequest
            {
                Udid = System.Guid.Parse(""),
                Distances = 100.ToString()
            });

            Assert.Null(res.Error);

            Assert.NotNull(res.Result.Summary);

        }

        [Fact]
        public async Task PostBuffer()
        {
            var am = new AzureMapsToolkit.AzureMapsServices(_KEY);
            var buffer = await am.PostBuffer("{ \"geometries\": { \"type\": \"FeatureCollection\", \"features\": [ { \"type\": \"Feature\", \"properties\": { \"geometryId\": \"ExampleId\" }, \"geometry\": { \"type\": \"Point\", \"coordinates\": [ -111.9267386, 33.5362475 ] } } ] }, \"distances\": [ 176.3 ] }");
            Assert.Null(buffer.Error);

        }

        [Fact]
        public async Task GetClosestPoint()
        {
            return;
            var am = new AzureMapsToolkit.AzureMapsServices(_KEY);
            var res = await am.GetClosestPoint(new AzureMapsToolkit.Spatial.ClosestPointRequest
            {
                Lon = -105.05860381672178,
                Lat = 40.516153406773952,
                Udid = Guid.Parse(""),
                NumberOfClosestPoints = 2
            });

            Assert.Null(res.Error);
        }

        [Fact]
        public async Task GetGeofence()
        {
            return;
            var am = new AzureMapsToolkit.AzureMapsServices(_KEY);
            var res = await am.GetGeofence(new AzureMapsToolkit.Spatial.GeofenceRequest
            {
                Udid = Guid.Parse(""),
                Lat = 47.609826136787518,
                Lon = -122.15225500989803,
                DeviceId = "1"
            });

            Assert.NotNull(res);

            Assert.Null(res.Error);
        }

        [Fact]

        public async Task GetGreatCircleDistance()
        {
            var am = new AzureMapsToolkit.AzureMapsServices(_KEY);
            var res = await am.GetGreatCircleDistance(new AzureMapsToolkit.Spatial.GreatCircleDistanceRequest
            {
                Query = "47.622942,-122.316456:47.610378,-122.200676"
            });

            Assert.Null(res.Error);

            Assert.Equal(8797.62, res.Result.Result.DistanceInMeters);
        }


        [Fact]
        public async Task GetGreatCircleDistance2()
        {
            var am = new AzureMapsToolkit.AzureMapsServices(_KEY);
            var res = await am.GetGreatCircleDistance(new AzureMapsToolkit.Spatial.GreatCircleDistanceRequest
            {
                Start = new AzureMapsToolkit.Spatial.Coordinate { Lat = 47.622942, Lon = -122.316456 },
                End = new AzureMapsToolkit.Spatial.Coordinate { Lat = 47.610378, Lon = -122.200676 }
            });

            Assert.Null(res.Error);

            Assert.Equal(8797.62, res.Result.Result.DistanceInMeters);
        }

        [Fact]
        public async Task GetPointInPolygon()
        {
            return;
            var am = new AzureMapsToolkit.AzureMapsServices(_KEY);
            var res = await am.GetPointInPolygon(
                new AzureMapsToolkit.Spatial.PointInPolygonRequest
                {
                    Lat = 33.5362475,
                    Lon = -111.9267386,
                    Udid = Guid.Parse("")
                }
                );
            Assert.Null(res.Error);
        }

        [Fact]
        public async Task PostClosestPoint()
        {
            var am = new AzureMapsToolkit.AzureMapsServices(_KEY);
            var res = await am.PostClosestPoint(new AzureMapsToolkit.Spatial.PostClosestPointRequest
            {
                Lon = -122.316456,
                Lat = 47.62294,
                NumberOfClosestPoints = 2
            }, "{ \"type\": \"FeatureCollection\", \"features\": [ { \"type\": \"Feature\", \"properties\": { \"geometryId\": 1001 }, \"geometry\": { \"type\": \"Point\", \"coordinates\": [ -105.02860293715861, 40.516153406773952 ] } }, { \"type\": \"Feature\", \"properties\": { \"geometryId\": 1002 }, \"geometry\": { \"type\": \"Point\", \"coordinates\": [ -105.02860381672178, 40.515990990037309 ] } }, { \"type\": \"Feature\", \"properties\": { \"geometryId\": 1003 }, \"geometry\": { \"type\": \"Point\", \"coordinates\": [ -105.02812292879467, 40.516058678088562 ] } } ] }");

            Assert.Null(res.Error);
        }

        [Fact]
        public async Task PostGeofence()
        {
            var am = new AzureMapsToolkit.AzureMapsServices(_KEY);
            var json = "{ \"type\": \"FeatureCollection\", \"features\": [ { \"type\": \"Feature\", \"geometry\": { \"type\": \"Polygon\", \"coordinates\": [ [ [ -122.13241226662022, 47.617011400917221 ], [ -122.12810106940353, 47.6169969269402 ], [ -122.12824948956276, 47.619076837513489 ], [ -122.12833297981392, 47.621929787055336 ], [ -122.12971398040168, 47.62184100705295 ], [ -122.1318413862121, 47.62195364373008 ], [ -122.13231034769727, 47.617163326181213 ], [ -122.13241226662022, 47.617011400917221 ] ] ] }, \"properties\": { \"geometryId\": \"2\", \"name\": \"Crossroad Mall\" } }, { \"type\": \"Feature\", \"geometry\": { \"type\": \"Polygon\", \"coordinates\": [ [ [ -122.15342205632391, 47.609818185466253 ], [ -122.153451623509, 47.606287331460038 ], [ -122.14971782206638, 47.606250040787046 ], [ -122.14817354810637, 47.606391046012305 ], [ -122.14827351288071, 47.609833167963558 ], [ -122.15225500989803, 47.609826136787518 ], [ -122.15342205632391, 47.609818185466253 ] ] ] }, \"properties\": { \"geometryId\": \"1\", \"name\": \"Sammamish High school\" } } ] }";
            var reqOjb = new AzureMapsToolkit.Spatial.PostGeofenceRequest
            {
                Lat = 47.617011400917221,
                Lon = -122.13241226662022,
                SearchBuffer = 50,
                DeviceId = Guid.NewGuid().ToString(),
                Mode = AzureMapsToolkit.Spatial.Mode.EnterAndExit,
                IsAsync = false
            };
            var res = await am.PostGeofence(reqOjb, json);

            Assert.Null(res.Error);
        }

        [Fact]
        public async Task PostPointInPolygon()
        {
            var am = new AzureMapsToolkit.AzureMapsServices(_KEY);
            var json = "{ \"type\": \"FeatureCollection\", \"features\": [ { \"type\": \"Feature\", \"properties\": { \"geometryId\": 1001 }, \"geometry\": { \"type\": \"Polygon\", \"coordinates\": [ [ [ -111.9267386, 33.5362475 ], [ -111.9627875, 33.5104882 ], [ -111.9027061, 33.5004686 ], [ -111.9267386, 33.5362475 ] ] ] } } ] }";
            var res = await am.PostPointInPolygon(new AzureMapsToolkit.Spatial.PostPointInPolygonRequest { Lat = 33.5362475, Lon = -111.9267386 }, json);
            Assert.Null(res.Error);
        }

        // not sure how to test this service, it seems it requires a vehicleId, but which?
        [Fact]
        public async Task GetCarShareInfo()
        {
            return;
            var am = new AzureMapsToolkit.AzureMapsServices(_KEY);
            var res = await am.GetCarShareInfo(new AzureMapsToolkit.Mobility.CarShareInfoRequest
            {
                Query = ""
            });

            Assert.Null(res.Error);
        }

        [Fact]
        public async Task GetMetroAreaInfo()
        {
            var am = new AzureMapsToolkit.AzureMapsServices(_KEY);
            var res = await am.GetMetroAreaInfo(new AzureMapsToolkit.Mobility.MetroAreaInfoRequest
            {
                Query = "121",
                DetailType = $"{AzureMapsToolkit.Mobility.DetailType.AGENCIES}"
            });

            Assert.Null(res.Error);

            Assert.Equal("NICE bus", res.Result.Agencies.First().AgencyName);
        }

        [Fact]
        public async Task GetMetroArea()
        {
            var am = new AzureMapsToolkit.AzureMapsServices(_KEY);
            var res = await am.GetMetroArea(new AzureMapsToolkit.Mobility.MetroAreaRequest
            {
                Query = "40.648677,-74.010535",
                QueryType = AzureMapsToolkit.Mobility.QueryType.position
            });

            Assert.Null(res.Error);

            Assert.NotNull(res.Result.Results[0].Geometry);

            Assert.Equal(121, res.Result.Results[0].MetroId);

        }

        [Fact]
        public async Task GetNearbyTransit()
        {
            var am = new AzureMapsToolkit.AzureMapsServices(_KEY);
            var res = await am.GetNearbyTransit(new AzureMapsToolkit.Mobility.NearbyTransitRequest
            {
                MetroId = 121,
                Query = "40.693393,-73.988310",
                Limit = 5,
                Radius = 300,
                ObjectType = AzureMapsToolkit.Mobility.ObjectType.Stop

            });

            Assert.Null(res.Error);
        }

        [Fact]
        public async Task GetRealTimeArrivals()
        {
            var am = new AzureMapsToolkit.AzureMapsServices(_KEY);
            var res = await am.GetRealTimeArrivals(new AzureMapsToolkit.Mobility.RealTimeArrivalsRequest
            {
                Query = "121---19919516"
            });

            Assert.Null(res.Error);
        }

        [Fact]
        public async Task GetTransitItenary()
        {
            var am = new AzureMapsToolkit.AzureMapsServices(_KEY);
            _ = await am.GetTransitItinerary(new AzureMapsToolkit.Mobility.TransitItineraryRequest
            {
            });
        }

        [Fact]
        public async Task GetTransitLineInfo()
        {
            var am = new AzureMapsToolkit.AzureMapsServices(_KEY);
            var transitLineInfoRequest = new AzureMapsToolkit.Mobility.TransitLineInfoRequest
            {
                MetroId = 121,
                Query = "121---373227",
                DetailTypes = TransitLineDetailType.Stops | TransitLineDetailType.Schedule | TransitLineDetailType.Stops
            };
            var res = await am.GetTransitLineInfo(transitLineInfoRequest);
            Assert.Null(res.Error);
        }

        [Fact]
        public async Task GetTransitRoute()
        {
            var am = new AzureMapsToolkit.AzureMapsServices(_KEY);
            var transitRouteRequest = new TransitRouteRequest
            {
                MetroId = 121,
                Origin = "40.680903,-73.983723",
                OriginType = OriginType.position,
                Destination = "40.682051,-73.976702",
                DestinationType = DestinationType.position
            };
            var res = await am.GetTransitRoute(transitRouteRequest);

            Assert.Null(res.Error);
        }

        [Fact]
        public async Task GetElevationDataForBoundingBox()
        {
            var am = new AzureMapsToolkit.AzureMapsServices(_KEY);
            var req = new AzureMapsToolkit.Elevation.GetElevationDataForBoundingBoxRequest
            {
                Bounds = "-121.66853362143818, 46.84646479863713,-121.65853362143818, 46.8564647986371",
                Rows = 2,
                Columns = 3
            };
            var res = await am.GetElevationDataForBoundingBox(req);

            Assert.Null(res.Error);
        }

        [Fact]
        public async Task GetElevationDataForPoints()
        {
            var am = new AzureMapsToolkit.AzureMapsServices(_KEY);
            var req = new AzureMapsToolkit.Elevation.GetElevationDataForPointsRequest
            {
                Points = "-121.66853362143818, 46.84646479863713|-121.68853362143818, 46.856464798637127",

            };
            var res = await am.GetElevationDataForPoints(req);

            Assert.Null(res.Error);
        }

        [Fact]
        public async Task GetElevationDataForPolyline()
        {
            var am = new AzureMapsToolkit.AzureMapsServices(_KEY);
            var req = new AzureMapsToolkit.Elevation.GetElevationDataForPolylineRequest
            {
                Lines = "-121.66853362143818, 46.84646479863713|-121.67853362143818, 46.85646479863713",
                Samples = 5

            };
            var res = await am.GetElevationDataForPolyline(req);

            Assert.Null(res.Error);

            Assert.Equal(5, res.Result.Result.Length);
        }

        [Fact]
        public async Task PostElevationDataForPoints()
        {
            var am = new AzureMapsToolkit.AzureMapsServices(_KEY);
            var req = new AzureMapsToolkit.Elevation.PostDataForPoints[] {
                new AzureMapsToolkit.Elevation.PostDataForPoints
                {
                Lat= 46.846464798637129,
                Lon = -121.66853362143819
                },
                new AzureMapsToolkit.Elevation.PostDataForPoints
                {
                    Lat = 46.856464798637127,
                    Lon = -121.68853362143818
                }
            };


            var res = await am.PostElevationDataForPoints(req);

            Assert.Null(res.Error);
            Assert.Equal(2, res.Result.Result.Length);

        }

        [Fact]
        public async Task PostElevationDataForPoline()
        {
            var am = new AzureMapsToolkit.AzureMapsServices(_KEY);
            var req = new AzureMapsToolkit.Elevation.PostDataForPolylineRequest
            {
                Samples = 5
            };

            var data = new AzureMapsToolkit.Elevation.PostDataForPolylineData[]
            {
                new AzureMapsToolkit.Elevation.PostDataForPolylineData
                {
                    Lat =46.846464798637129,
                    Lon = -121.66853362143819
                },
                new AzureMapsToolkit.Elevation.PostDataForPolylineData
                {
                     Lat =46.856464798637127,
                     Lon = -121.67853362143818
                }
            };


            var res = await am.PostElevationDataForPolyline(req, data);

            Assert.Null(res.Error);
            Assert.Equal(5, res.Result.Result.Length);

        }

        [Fact]
        public async Task GetCurrentCondition()
        {
            var am = new AzureMapsToolkit.AzureMapsServices(_KEY);
            var q = new GetCurrentConditionsRequest
            {
                Query = "47.641268,-122.125679",
                Unit = Unit.imperial
            };
            var res = await am.GetCurrentCondition(q);

            Assert.Null(res.Error);
        }

        [Fact]
        public async Task GetDailyForeCast()
        {
            var am = new AzureMapsToolkit.AzureMapsServices(_KEY);
            var q = new GetForecastRequest
            {
                Query = "62.6490341,30.0734812",
                Unit = Unit.metric
            };
            var res = await am.GetDailyForecast(q);

            Assert.Null(res.Error);
        }

        [Fact]
        public async Task GetDailyIndices()
        {
            var am = new AzureMapsToolkit.AzureMapsServices(_KEY);
            var q = new GetDailyIndicesRequest
            {
                Query = "43.84745,-79.37849",
                //IndexGroupId = 11
            };
            var res = await am.GetDailyIndices(q);

            Assert.Null(res.Error);

        }

        [Fact]
        public async Task GetHourlyForecast()
        {
            var am = new AzureMapsToolkit.AzureMapsServices(_KEY);
            var q = new GetHourlyForecastRequest
            {
                Query = "47.632346,-122.13887",
                Duration = 12
            };
            var res = await am.GetHourlyForecast(q);

            Assert.Null(res.Error);
        }

        [Fact]
        public async Task GetMinuteForecast()
        {
            var am = new AzureMapsToolkit.AzureMapsServices(_KEY);
            var q = new GetMinuteForecastRequest
            {
                Query = "47.632346,-122.13887",
                Interval = 5
            };
            var res = await am.GetMinuteForecast(q);

            Assert.Null(res.Error);
        }

        [Fact]
        public async Task GetQuerterDayForecast()
        {
            var am = new AzureMapsToolkit.AzureMapsServices(_KEY);
            var q = new GetForecastRequest
            {
                Query = "47.632346,-122.13887",
                Duration = 5
            };
            var res = await am.GetQuarterDayForecast(q);

            Assert.Null(res.Error);

        }

        [Fact]
        public async Task GetSevereWeatherAlerts()
        {
            var am = new AzureMapsToolkit.AzureMapsServices(_KEY);
            var q = new GetSevereWeatherAlertsRequest
            {
                Query = "47.632346,-122.13887",

            };
            var res = await am.GetSevereWeatherAlerts(q);

            Assert.Null(res.Error);

        }

        [Fact]
        public async Task GetWeatherAlongRoute()
        {
            var am = new AzureMapsToolkit.AzureMapsServices(_KEY);
            var q = new GetWeatherAlongRouteRequest
            {
                Query = "38.907,-77.037,0:38.907,-77.009,10:38.926,-76.928,20:39.033,-76.852,30:39.168,-76.732,40:39.269,-76.634,50:39.287,-76.612,60"

            };
            var res = await am.GetWeatherAlongRoute(q);

            Assert.Null(res.Error);
        }

    }
}
