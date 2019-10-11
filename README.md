# Azure Maps REST Services

[![NuGet](https://img.shields.io/badge/NuGet-4.1.1-blue.svg)](https://www.nuget.org/packages/AzureMapsRestToolkit/)
[![license](https://img.shields.io/badge/license-MIT-yellow.svg)](https://github.com/perfahlen/AzureMapsRestServices/blob/master/LICENSE)


# .Net Standard 2.0 library to access AzureMaps Services
This library covers 50 Azure Maps services including the following services
- Data services
- Geolocation services
- Render services
- Route services
- Search services
- Spatial services
- TimeZone services
- Traffic services
- Mobility services

## Exceptions
Exception is captures by the library and if any exceptions captured it will be return in the __Error__ property in the returned object. See example below.

## Example
Search address example
```
var am = new AzureMapsToolkit.AzureMapsServices('<Azure Maps Key>');
var searchAddressRequest = new SearchAddressRequest
{
   Query = "15127 NE 24th Street,Redmond, WA 98052",
   Limit = 10
};
var resp = am.GetSearchAddress(searchAddressRequest).Result;
if (resp.Error != null)
{
   //Handle error
}

```

## Installation with Nuget
```
PM> Install-Package AzureMapsRestToolkit
```
