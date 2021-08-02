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
        private static readonly string _KEY;

        static UnitTest()
        {
            _KEY = Environment.GetEnvironmentVariable("AZURE_MAPS_KEY");
            if (string.IsNullOrEmpty(_KEY))
                throw new Exception("Please set the AZURE_MAPS_KEY environment variable to a valid Azure Maps key.");
        }

        [Fact]
        public void InvalidIPCountry()
        {
            var am = new AzureMapsToolkit.AzureMapsServices(_KEY);
            var res = am.GetIPToLocation("83.10.0.3").Result;

            Assert.NotEqual("SE", res.Result.CountryRegion.IsoCode);

        }

        [Fact]
        public void ValidIPCountry()
        {
            var am = new AzureMapsToolkit.AzureMapsServices(_KEY);
            var res = am.GetIPToLocation("83.68.254.182").Result;

            Assert.Equal("SE", res.Result.CountryRegion.IsoCode);

        }

        [Fact]
        public void InvaliddIPAddress()
        {
            var am = new AzureMapsToolkit.AzureMapsServices(_KEY);
            var res = am.GetIPToLocation("perfa").Result;
            Assert.True(res.Error != null);
        }

        [Fact]
        public void GetCopyrightCaption()
        {
            var am = new AzureMapsToolkit.AzureMapsServices(_KEY);
            var result = am.GetCopyrightCaption().Result;
            Assert.Contains("TomTom", result.Result.CopyrightsCaption);
        }

        [Fact]
        public void GetCopyrightForTile()
        {
            var am = new AzureMapsToolkit.AzureMapsServices(_KEY);
            var req = new AzureMapsToolkit.Render.CopyrightForTileRequest
            {
                Zoom = 6,
                X = 9,
                Y = 22,
                Text = "yes"
            };
            var resp = am.GetCopyrightForTile(req).Result;
            Assert.Equal("CAN", resp.Result.Regions[0].Country.ISO3);
        }

        [Fact]
        public void GetCopyrightForWorld()
        {
            var am = new AzureMapsToolkit.AzureMapsServices(_KEY);
            _ = am.GetCopyrightForWorld().Result;

        }

        [Fact]
        public void GetCopyrightFromBoundingBox()
        {
            var am = new AzureMapsToolkit.AzureMapsServices(_KEY);
            var req = new CopyrightFromBoundingBoxRequest
            {
                Mincoordinates = "52.41064,4.84228",
                Maxcoordinates = "52.41072,4.84239",
                Text = "yes"
            };
            var res = am.GetCopyrightFromBoundingBox(req).Result;

            Assert.Null(res.Error);
        }

        [Fact]
        public void GetMapImage()
        {
            var am = new AzureMapsToolkit.AzureMapsServices(_KEY);
            var req = new MapImageRequest
            {
                Format = AzureMapsToolkit.Render.RasterTileFormat.png,
                Layer = StaticMapLayer.basic,
                Zoom = 2,
                Center = "62,17"
            };
            var content = am.GetMapImage(req).Result;
            Assert.NotEmpty(content.Result);

        }

        [Fact]
        public void GetMapImageryTilePreview()
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
            var content = am.GetMapImageryTile(req).Result;
            Assert.NotEmpty(content.Result);
        }


        [Fact]
        public void GetMapTile()
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

            var content = am.GetMapTile(req).Result;
            Assert.NotEmpty(content.Result);
        }

        [Fact]
        public void GetRouteDirections()
        {

            var am = new AzureMapsToolkit.AzureMapsServices(_KEY);
            var req = new RouteRequestDirections
            {
                //Query = "52.50931,13.42936:52.50274,13.43872"
                Query = "62.469026,16.696987:62.397051,17.363892",
                Avoid = Avoid.tollRoads
            };
            var directions = am.GetRouteDirections(req).Result;
            Assert.Null(directions.Error);
            Assert.NotNull(directions.Result);
        }

        [Fact]
        public void GetRouteDirectionsError()
        {

            var am = new AzureMapsToolkit.AzureMapsServices(_KEY);
            var req = new RouteRequestDirections
            {
                Query = "52.50931,13.42936:52.50274,13.43872f", // intentially error
                VehicleEngineType = VehicleEngineType.Combustion,
                InstructionsType = RouteInstructionsType.text
            };
            var directions = am.GetRouteDirections(req).Result;
            Assert.NotNull(directions.Error);
        }

        [Fact]
        public void GetRouteRange()
        {

            var am = new AzureMapsToolkit.AzureMapsServices(_KEY);
            var req = new RouteRangeRequest
            {
                Query = "52.50931,13.42936",
                TimeBudgetInSec = "12000"
            };
            var range = am.GetRouteRange(req).Result;
            Assert.NotNull(range.Result.ReachableRange.Boundary);
        }

        [Fact]
        public void GetPostRouteDirections()
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

            var (ResultUrl, ex) = am.GetRouteDirections(req).Result;

            Assert.Null(ex);

            Assert.NotNull(ResultUrl);

            Assert.True(ResultUrl.Length > 0);

        }


        [Fact]
        public void GetDistanceMatrix()
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

            var (ResultUrl, ex) = am.GetRouteMatrix(new RouteMatrixRequest
            {
                RouteType = RouteType.Fastest
            }, origins, destinations).Result;

            Assert.Null(ex);

            Assert.NotNull(ResultUrl);

            GetDistanceMatrixResult();

        }

        [Fact]
        public void GetDistanceMatrixResult()
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
            var (ResultUrl, _) = am.GetRouteMatrix(req, origins, destinations).Result;

            var matrixResponse = am.GetRouteMatrixResult(ResultUrl).Result;

            Assert.Null(matrixResponse.Error);
            Assert.NotNull(matrixResponse.Result);
        }


        [Fact]
        public void GetSearchAddress()
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
            var resp = am.GetSearchAddress(searchAddressRequest).Result;

            Assert.Null(resp.Error);

            //Assert.Equal(14.15, resp.Result.Results[0].Score);

        }

        [Fact]
        public void GetSearchAddressReverse()
        {
            var am = new AzureMapsToolkit.AzureMapsServices(_KEY);

            var req = new SearchAddressReverseRequest
            {
                //Query = "37.337,-121.89",
                Query = "47.591180, -122.332700",
                EntityType = SearchAddressEntityType.Municipality | SearchAddressEntityType.PostalCodeArea
            };

            var resp = am.GetSearchAddressReverse(req).Result;

            Assert.Null(resp.Error);

            Assert.Equal(1, resp.Result.Summary.NumResults);
        }

        [Fact]
        public void GetSearchAddressReverseCrossStreet()
        {
            var am = new AzureMapsToolkit.AzureMapsServices(_KEY);

            var req = new SearchAddressReverseCrossStreetRequest
            {
                Query = "62.390132,17.305199"
            };

            var resp = am.GetSearchAddressReverseCrossStreet(req).Result;

            Assert.Null(resp.Error);

            Assert.Equal(1, resp.Result.Summary.NumResults);
        }

        [Fact]
        public void GetSearchAddressStructured()
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
            var result = am.GetSearchAddressStructured(req).Result;

            Assert.Null(result.Error);

            Assert.Equal(1, result.Result.Summary.FuzzyLevel);

        }

        [Fact]
        public void GetSearchFuzzy()
        {
            var am = new AzureMapsToolkit.AzureMapsServices(_KEY);
            var req = new SearchFuzzyRequest
            {
                CountrySet = "US",
                Query = "seattle",
                IdxSet = new string[] { "Geo", "POI" }
            };
            var res = am.GetSearchFuzzy(req).Result;

            Assert.Null(res.Error);

            Assert.Equal(1, res.Result.Summary.FuzzyLevel);
        }

        [Fact]
        public void GetSearchNearby()
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

            var res = am.GetSearchNearby(req).Result;

            Assert.Null(res.Error);

            Assert.Equal(1, res.Result.Summary.FuzzyLevel);
        }

        [Fact]
        public void GetSearchPoi()
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

            var res = am.GetSearchPoi(req).Result;

            Assert.Null(res.Error);

        }

        [Fact]
        public void GetSearchPoiCategory()
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

            var res = am.GetSearchPOICategory(req).Result;

            Assert.Null(res.Error);

        }

        [Fact]
        public void GetSearchAddressBatch()
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

            var (ResultUrl, ex) = am.GetSearchAddress(req).Result;

            Assert.Null(ex);

            Assert.NotNull(ResultUrl);
        }

        [Fact]
        public void GetSearchAddressReverseBatch()
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

            var (ResultUrl, ex) = am.GetSearchAddressReverse(req).Result;

            Assert.Null(ex);

            Assert.NotNull(ResultUrl);
        }

        [Fact]
        public void GetSearchAlongRoute()
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

            var result = am.GetSearchAlongRoute(req, lineString).Result;

            Assert.Null(result.Error);

            Assert.Equal("NON_NEAR", result.Result.Summary.QueryType);

        }

        [Fact]
        public void GetSeachFuzzyBatch()
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
            var (ResultUrl, ex) = am.GetSearchFuzzy(req).Result;

            Assert.Null(ex);

            Assert.NotNull(ResultUrl);

        }

        [Fact]
        public void SearchInsidePolygon()
        {
            var am = new AzureMapsToolkit.AzureMapsServices(_KEY);
            var coll = JsonSerializer.Deserialize<GeoCollection>("{\"type\":\"GeometryCollection\",\"geometries\":[{\"type\":\"Polygon\",\"coordinates\":[[[-122.43576049804686,37.7524152343544],[-122.43301391601562,37.70660472542312],[-122.36434936523437,37.712059855877314],[-122.43576049804686,37.7524152343544]]]}]}");
            var d = am.GetSearchInsidePolygon(new SearchInsidePolygonRequest
            {
                Query = "burger"
            }, coll).Result;

            Assert.Null(d.Error);

        }

        [Fact]
        public void GetTimeZoneByCoordinates()
        {
            var am = new AzureMapsToolkit.AzureMapsServices(_KEY);
            var req = new TimeZoneRequest
            {
                Query = "47.0,-122",
                Options = TimezoneOptions.All
            };
            var r = am.GetTimezoneByCoordinates(req).Result;

            Assert.Null(r.Error);
            Assert.Equal("US", r.Result.TimeZones[0].Countries[0].Code);
        }


        [Fact]
        public void GetTimeZoneById()
        {
            var am = new AzureMapsToolkit.AzureMapsServices(_KEY);
            var req = new TimeZoneRequest
            {
                Query = "Europe/Stockholm",
                Options = TimezoneOptions.All
            };
            var r = am.GetTimezoneById(req).Result;

            Assert.Null(r.Error);
            Assert.Equal("SE", r.Result.TimeZones[0].Countries[0].Code);
        }

        [Fact]
        public void GetTimezoneIANA()
        {
            var am = new AzureMapsToolkit.AzureMapsServices(_KEY);

            var r = am.GetTimezoneEnumIANA().Result;

            Assert.Null(r.Error);

        }

        [Fact]
        public void GetTimezoneEnumWindows()
        {
            var am = new AzureMapsToolkit.AzureMapsServices(_KEY);

            var r = am.GetTimezoneEnumWindows().Result;

            Assert.Null(r.Error);
            Assert.NotNull(r.Result);
        }

        [Fact]
        public void GetTimezoneIANAVersion()
        {
            var am = new AzureMapsToolkit.AzureMapsServices(_KEY);

            var r = am.GetTimezoneIANAVersion().Result;

            Assert.Null(r.Error);

            Assert.StartsWith("20", r.Result.Version);
        }


        [Fact]
        public void GetTimezoneWindowsToIANA()
        {
            var am = new AzureMapsToolkit.AzureMapsServices(_KEY);
            var req = new TimezoneWindowsToIANARequest
            {
                Query = "pacific standard time"
            };
            var r = am.GetTimezoneWindowsToIANA(req).Result;

            Assert.Null(r.Error);

            Assert.NotNull(r.Result);
        }

        [Fact]
        public void GetTrafficFlowSegment()
        {
            var am = new AzureMapsToolkit.AzureMapsServices(_KEY);
            var req = new TrafficFlowSegmentRequest
            {
                //Query = "52.41072,4.84239",
                Query = "62.40948,17.23301",
                Style = TrafficFlowSegmentStyle.Absolute,
                Zoom = 10
            };

            var r = am.GetTrafficFlowSegment(req).Result;

            Assert.Null(r.Error);

        }

        [Fact]
        public void GetTrafficFlowTile()
        {
            var am = new AzureMapsToolkit.AzureMapsServices(_KEY);
            var req = new TrafficFlowTileRequest
            {
                Style = TrafficFlowSegmentStyle.Absolute,
                Zoom = 12,
                X = 2044,
                Y = 1360
            };

            var r = am.GetTrafficFlowTile(req).Result;

            Assert.Null(r.Error);
        }

        [Fact]
        public void GetTrafficIncidentTile()
        {
            var am = new AzureMapsToolkit.AzureMapsServices(_KEY);
            var req = new TrafficIncidentTileRequest
            {
                Style = TrafficIncidentTileStyle.s1,
                Zoom = 12,
                X = 2044,
                Y = 1360
            };

            var r = am.GetTrafficIncidentTile(req).Result;

            Assert.Null(r.Error);
        }

        [Fact]
        public void GetTrafficIncidentDetail()
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

            var r = am.GetTrafficIncidentDetail(req).Result;

            Assert.Null(r.Error);
        }

        [Fact]
        public void GetTrafficIncidentViewport()
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

            var r = am.GetTrafficIncidentViewport(req).Result;

            Assert.Null(r.Error);

            Assert.Equal("world", r.Result.ViewpResp.Maps);
        }

        [Fact]
        public void GetSearchAddresstMoq()
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
        public void Upload()
        {
            return;
            var am = new AzureMapsToolkit.AzureMapsServices(_KEY);
            var json = "{ \"type\": \"FeatureCollection\", \"features\": [ { \"type\": \"Feature\", \"properties\": { \"geometryId\": 1001 }, \"geometry\": { \"type\": \"Polygon\", \"coordinates\": [ [ [ -111.9267386, 33.5362475 ], [ -111.9627875, 33.5104882 ], [ -111.9027061, 33.5004686 ], [ -111.9267386, 33.5362475 ] ] ] } } ] }";
            var res = am.Upload(json).Result;

            Assert.NotNull(res.Result);
            Assert.Null(res.Error);

        }

        [Fact]
        public void Update()
        {
            return;
            var am = new AzureMapsToolkit.AzureMapsServices(_KEY);

            var json = "{\"type\": \"FeatureCollection\", \"features\": [{\"type\": \"Feature\",\"geometry\": {\"type\": \"Point\",\"coordinates\": [-122.126986, 47.639754]}, \"properties\": {\"geometryId\": \"001\",\"radius\": 500}}]}";
            var res = am.Update(System.Guid.Parse(""), json).Result;

            Assert.NotNull(res.Result);
            Assert.Null(res.Error);

        }

        [Fact]
        public void DeleteData()
        {
            return;
            var am = new AzureMapsToolkit.AzureMapsServices(_KEY);
            var res = am.DeleteData(System.Guid.Parse("895e6375-7d4e-0052-48c1-749d503cf522")).Result;

            Assert.Null(res.Error);
            Assert.True(res.Result);
        }

        [Fact]
        public void ListData()
        {
            var am = new AzureMapsToolkit.AzureMapsServices(_KEY);
            var res = am.GetList().Result;
            Assert.InRange(res.Result.MapDataList.Count, 0, int.MaxValue);
        }

        [Fact]
        public void DownloadData()
        {
            var am = new AzureMapsToolkit.AzureMapsServices(_KEY);
            var res = am.Download("").Result;
            Assert.Null(res.Error);
            Assert.NotNull(res.Result);
        }

        [Fact]

        public void GetBuffer()
        {
            return;
            var am = new AzureMapsToolkit.AzureMapsServices(_KEY);
            var res = am.GetBuffer(new AzureMapsToolkit.Spatial.BufferRequest
            {
                Udid = System.Guid.Parse(""),
                Distances = 100.ToString()
            }).Result;

            Assert.Null(res.Error);

            Assert.NotNull(res.Result.Summary);

        }

        [Fact]
        public void PostBuffer()
        {
            var am = new AzureMapsToolkit.AzureMapsServices(_KEY);
            var buffer = am.PostBuffer("{ \"geometries\": { \"type\": \"FeatureCollection\", \"features\": [ { \"type\": \"Feature\", \"properties\": { \"geometryId\": \"ExampleId\" }, \"geometry\": { \"type\": \"Point\", \"coordinates\": [ -111.9267386, 33.5362475 ] } } ] }, \"distances\": [ 176.3 ] }").Result;
            Assert.Null(buffer.Error);

        }

        [Fact]
        public void GetClosestPoint()
        {
            return;
            var am = new AzureMapsToolkit.AzureMapsServices(_KEY);
            var res = am.GetClosestPoint(new AzureMapsToolkit.Spatial.ClosestPointRequest
            {
                Lon = -105.05860381672178,
                Lat = 40.516153406773952,
                Udid = Guid.Parse(""),
                NumberOfClosestPoints = 2
            }).Result;

            Assert.Null(res.Error);
        }

        [Fact]
        public void GetGeofence()
        {
            return;
            var am = new AzureMapsToolkit.AzureMapsServices(_KEY);
            var res = am.GetGeofence(new AzureMapsToolkit.Spatial.GeofenceRequest
            {
                Udid = Guid.Parse(""),
                Lat = 47.609826136787518,
                Lon = -122.15225500989803,
                DeviceId = "1"
            }).Result;

            Assert.NotNull(res);

            Assert.Null(res.Error);
        }

        [Fact]

        public void GetGreatCircleDistance()
        {
            var am = new AzureMapsToolkit.AzureMapsServices(_KEY);
            var res = am.GetGreatCircleDistance(new AzureMapsToolkit.Spatial.GreatCircleDistanceRequest
            {
                Query = "47.622942,-122.316456:47.610378,-122.200676"
            }).Result;

            Assert.Null(res.Error);

            Assert.Equal(8797.62, res.Result.Result.DistanceInMeters);
        }


        [Fact]
        public void GetGreatCircleDistance2()
        {
            var am = new AzureMapsToolkit.AzureMapsServices(_KEY);
            var res = am.GetGreatCircleDistance(new AzureMapsToolkit.Spatial.GreatCircleDistanceRequest
            {
                Start = new AzureMapsToolkit.Spatial.Coordinate { Lat = 47.622942, Lon = -122.316456 },
                End = new AzureMapsToolkit.Spatial.Coordinate { Lat = 47.610378, Lon = -122.200676 }
            }).Result;

            Assert.Null(res.Error);

            Assert.Equal(8797.62, res.Result.Result.DistanceInMeters);
        }

        [Fact]
        public void GetPointInPolygon()
        {
            return;
            var am = new AzureMapsToolkit.AzureMapsServices(_KEY);
            var res = am.GetPointInPolygon(
                new AzureMapsToolkit.Spatial.PointInPolygonRequest
                {
                    Lat = 33.5362475,
                    Lon = -111.9267386,
                    Udid = Guid.Parse("")
                }
                ).Result;
            Assert.Null(res.Error);
        }

        [Fact]
        public void PostClosestPoint()
        {
            var am = new AzureMapsToolkit.AzureMapsServices(_KEY);
            var res = am.PostClosestPoint(new AzureMapsToolkit.Spatial.PostClosestPointRequest
            {
                Lon = -122.316456,
                Lat = 47.62294,
                NumberOfClosestPoints = 2
            }, "{ \"type\": \"FeatureCollection\", \"features\": [ { \"type\": \"Feature\", \"properties\": { \"geometryId\": 1001 }, \"geometry\": { \"type\": \"Point\", \"coordinates\": [ -105.02860293715861, 40.516153406773952 ] } }, { \"type\": \"Feature\", \"properties\": { \"geometryId\": 1002 }, \"geometry\": { \"type\": \"Point\", \"coordinates\": [ -105.02860381672178, 40.515990990037309 ] } }, { \"type\": \"Feature\", \"properties\": { \"geometryId\": 1003 }, \"geometry\": { \"type\": \"Point\", \"coordinates\": [ -105.02812292879467, 40.516058678088562 ] } } ] }")
            .Result;

            Assert.Null(res.Error);
        }

        [Fact]
        public void PostGeofence()
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
            var res = am.PostGeofence(reqOjb, json).Result;

            Assert.Null(res.Error);
        }

        [Fact]
        public void PostPointInPolygon()
        {
            var am = new AzureMapsToolkit.AzureMapsServices(_KEY);
            var json = "{ \"type\": \"FeatureCollection\", \"features\": [ { \"type\": \"Feature\", \"properties\": { \"geometryId\": 1001 }, \"geometry\": { \"type\": \"Polygon\", \"coordinates\": [ [ [ -111.9267386, 33.5362475 ], [ -111.9627875, 33.5104882 ], [ -111.9027061, 33.5004686 ], [ -111.9267386, 33.5362475 ] ] ] } } ] }";
            var res = am.PostPointInPolygon(new AzureMapsToolkit.Spatial.PostPointInPolygonRequest { Lat = 33.5362475, Lon = -111.9267386 }, json).Result;
            Assert.Null(res.Error);
        }

        // not sure how to test this service, it seems it requires a vehicleId, but which?
        [Fact]
        public void GetCarShareInfo()
        {
            return;
            var am = new AzureMapsToolkit.AzureMapsServices(_KEY);
            var res = am.GetCarShareInfo(new AzureMapsToolkit.Mobility.CarShareInfoRequest
            {
                Query = ""
            }).Result;

            Assert.Null(res.Error);
        }

        [Fact]
        public void GetMetroAreaInfo()
        {
            var am = new AzureMapsToolkit.AzureMapsServices(_KEY);
            var res = am.GetMetroAreaInfo(new AzureMapsToolkit.Mobility.MetroAreaInfoRequest
            {
                Query = "121",
                DetailType = $"{AzureMapsToolkit.Mobility.DetailType.AGENCIES}"
            }).Result;

            Assert.Null(res.Error);

            Assert.Equal("NICE bus", res.Result.Agencies.First().AgencyName);
        }

        [Fact]
        public void GetMetroArea()
        {
            var am = new AzureMapsToolkit.AzureMapsServices(_KEY);
            var res = am.GetMetroArea(new AzureMapsToolkit.Mobility.MetroAreaRequest
            {
                Query = "40.648677,-74.010535",
                QueryType = AzureMapsToolkit.Mobility.QueryType.position
            }).Result;

            Assert.Null(res.Error);

            Assert.NotNull(res.Result.Results[0].Geometry);

            Assert.Equal(121, res.Result.Results[0].MetroId);

        }

        [Fact]
        public void GetNearbyTransit()
        {
            var am = new AzureMapsToolkit.AzureMapsServices(_KEY);
            var res = am.GetNearbyTransit(new AzureMapsToolkit.Mobility.NearbyTransitRequest
            {
                MetroId = 121,
                Query = "40.693393,-73.988310",
                Limit = 5,
                Radius = 300,
                ObjectType = AzureMapsToolkit.Mobility.ObjectType.Stop

            }).Result;

            Assert.Null(res.Error);
        }

        [Fact]
        public void GetRealTimeArrivals()
        {
            var am = new AzureMapsToolkit.AzureMapsServices(_KEY);
            var res = am.GetRealTimeArrivals(new AzureMapsToolkit.Mobility.RealTimeArrivalsRequest
            {
                Query = "121---19919516"
            }).Result;

            Assert.Null(res.Error);
        }

        [Fact]
        public void GetTransitItenary()
        {
            var am = new AzureMapsToolkit.AzureMapsServices(_KEY);
            _ = am.GetTransitItinerary(new AzureMapsToolkit.Mobility.TransitItineraryRequest
            {
            }).Result;
        }

        [Fact]
        public void GetTransitLineInfo()
        {
            var am = new AzureMapsToolkit.AzureMapsServices(_KEY);
            var transitLineInfoRequest = new AzureMapsToolkit.Mobility.TransitLineInfoRequest
            {
                MetroId = 121,
                Query = "121---373227",
                DetailTypes = TransitLineDetailType.Stops | TransitLineDetailType.Schedule | TransitLineDetailType.Stops
            };
            var res = am.GetTransitLineInfo(transitLineInfoRequest).Result;
            Assert.Null(res.Error);
        }

        [Fact]
        public void GetTransitRoute()
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
            var res = am.GetTransitRoute(transitRouteRequest).Result;

            Assert.Null(res.Error);
        }

        [Fact]
        public void GetElevationDataForBoundingBox()
        {
            var am = new AzureMapsToolkit.AzureMapsServices(_KEY);
            var req = new AzureMapsToolkit.Elevation.GetElevationDataForBoundingBoxRequest
            {
                Bounds = "-121.66853362143818, 46.84646479863713,-121.65853362143818, 46.8564647986371",
                Rows = 2,
                Columns = 3
            };
            var res = am.GetElevationDataForBoundingBox(req).Result;

            Assert.Null(res.Error);
        }

        [Fact]
        public void GetElevationDataForPoints()
        {
            var am = new AzureMapsToolkit.AzureMapsServices(_KEY);
            var req = new AzureMapsToolkit.Elevation.GetElevationDataForPointsRequest
            {
                Points = "-121.66853362143818, 46.84646479863713|-121.68853362143818, 46.856464798637127",

            };
            var res = am.GetElevationDataForPoints(req).Result;

            Assert.Null(res.Error);
        }

        [Fact]
        public void GetElevationDataForPolyline()
        {
            var am = new AzureMapsToolkit.AzureMapsServices(_KEY);
            var req = new AzureMapsToolkit.Elevation.GetElevationDataForPolylineRequest
            {
                Lines = "-121.66853362143818, 46.84646479863713|-121.67853362143818, 46.85646479863713",
                Samples = 5

            };
            var res = am.GetElevationDataForPolyline(req).Result;

            Assert.Null(res.Error);

            Assert.Equal(5, res.Result.Result.Length);
        }

        [Fact]
        public void PostElevationDataForPoints()
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


            var res = am.PostElevationDataForPoints(req).Result;

            Assert.Null(res.Error);
            Assert.Equal(2, res.Result.Result.Length);

        }

        [Fact]
        public void PostElevationDataForPoline()
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


            var res = am.PostElevationDataForPolyline(req, data).Result;

            Assert.Null(res.Error);
            Assert.Equal(5, res.Result.Result.Length);

        }

        [Fact]
        public void GetCurrentCondition()
        {
            var am = new AzureMapsToolkit.AzureMapsServices(_KEY);
            var q = new GetCurrentConditionsRequest
            {
                Query = "47.641268,-122.125679",
                Unit = Unit.imperial
            };
            var res = am.GetCurrentCondition(q).Result;

            Assert.Null(res.Error);
        }

        [Fact]
        public void GetDailyForeCast()
        {
            var am = new AzureMapsToolkit.AzureMapsServices(_KEY);
            var q = new GetForecastRequest
            {
                Query = "62.6490341,30.0734812",
                Unit = Unit.metric
            };
            var res = am.GetDailyForecast(q).Result;

            Assert.Null(res.Error);
        }

        [Fact]
        public void GetDailyIndices()
        {
            var am = new AzureMapsToolkit.AzureMapsServices(_KEY);
            var q = new GetDailyIndicesRequest
            {
                Query = "43.84745,-79.37849",
                //IndexGroupId = 11
            };
            var res = am.GetDailyIndices(q).Result;

            Assert.Null(res.Error);

        }

        [Fact]
        public void GetHourlyForecast()
        {
            var am = new AzureMapsToolkit.AzureMapsServices(_KEY);
            var q = new GetHourlyForecastRequest
            {
                Query = "47.632346,-122.13887",
                Duration = 12
            };
            var res = am.GetHourlyForecast(q).Result;

            Assert.Null(res.Error);
        }

        [Fact]
        public void GetMinuteForecast()
        {
            var am = new AzureMapsToolkit.AzureMapsServices(_KEY);
            var q = new GetMinuteForecastRequest
            {
                Query = "47.632346,-122.13887",
                Interval = 5
            };
            var res = am.GetMinuteForecast(q).Result;

            Assert.Null(res.Error);
        }

        [Fact]
        public void GetQuerterDayForecast()
        {
            var am = new AzureMapsToolkit.AzureMapsServices(_KEY);
            var q = new GetForecastRequest
            {
                Query = "47.632346,-122.13887",
                Duration = 5
            };
            var res = am.GetQuarterDayForecast(q).Result;

            Assert.Null(res.Error);

        }

        [Fact]
        public void GetSevereWeatherAlerts()
        {
            var am = new AzureMapsToolkit.AzureMapsServices(_KEY);
            var q = new GetSevereWeatherAlertsRequest
            {
                Query = "47.632346,-122.13887",

            };
            var res = am.GetSevereWeatherAlerts(q).Result;

            Assert.Null(res.Error);

        }

        [Fact]
        public void GetWeatherAlongRoute()
        {
            var am = new AzureMapsToolkit.AzureMapsServices(_KEY);
            var q = new GetWeatherAlongRouteRequest
            {
                Query = "38.907,-77.037,0:38.907,-77.009,10:38.926,-76.928,20:39.033,-76.852,30:39.168,-76.732,40:39.269,-76.634,50:39.287,-76.612,60"

            };
            var res = am.GetWeatherAlongRoute(q).Result;

            Assert.Null(res.Error);
        }

    }
}
