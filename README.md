# Azure Maps REST Services

[![NuGet](https://img.shields.io/badge/NuGet-7.1.0-blue.svg)](https://www.nuget.org/packages/AzureMapsRestToolkit/)
[![license](https://img.shields.io/badge/license-MIT-yellow.svg)](https://github.com/perfahlen/AzureMapsRestServices/blob/master/LICENSE)

# .NET 5 library to access AzureMaps Services

This library covers 73 Azure Maps endpoints including the following services
- Data services
- Geolocation services
- Render services
- Route services
- Search services
- Spatial services
- TimeZone services
- Traffic services
- Mobility services
- Weather services
- Elevation services

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

## TLS 1.2 issue
See issue <https://github.com/perfahlen/AzureMapsRestServices/issues/33>


## .Net Standard 2.0 library to access AzureMaps Services (DEPRECATED)
**NOTE, this version is deprecated and last release is 6.0.0.0**

The .Net Standard release is available in the net-standard branch.

Nuget: ```Install-Package AzureMapsRestToolkit -Version 6.0.0```

.NET CLI ```dotnet add package AzureMapsRestToolkit --version 6.0.0```

PackageReference ```<PackageReference Include="AzureMapsRestToolkit" Version="6.0.0" />```

Cake
```// Install AzureMapsRestToolkit as a Cake Addin
#addin nuget:?package=AzureMapsRestToolkit&version=6.0.0

// Install AzureMapsRestToolkit as a Cake Tool
#tool nuget:?package=AzureMapsRestToolkit&version=6.0.0
```
