# AzureMapsRestServices
.Net Standard 2.0 library to access AzureMaps Services

In total as is 36 Azure Maps services. 

Search address example
```
var searchAddressRequest = new SearchAddressRequest
{
   Query = "15127 NE 24th Street,Redmond, WA 98052",
   Limit = 10
};
var resp = am.GetSearchAddress(searchAddressRequest).Result;
```
