using AzureMapsToolkit.Common;
using System;
using System.Collections.Generic;
using System.Text;

namespace AzureMapsToolkit.Search
{
    /// <summary>
    /// Specifies the level of filtering performed on geographies. Narrows the search for specified geography entity types, e.g. return only municipality. The resulting response will contain the geography ID as well as the entity type matched. If you provide more than one entity as a comma separated list, endpoint will return the 'smallest entity available'. Returned Geometry ID can be used to get the geometry of that geography via Get Search Polygon API. The following parameters are ignored when entityType is set:
    /// </summary>
    [Flags]
    public enum SearchAddressEntityTypes: byte
    {
        [NameArgument("Country")]
        Country = 1 << 0,


        [NameArgument("CountrySecondarySubdivision")]
        CountrySecondarySubdivision = 1 << 1,

        [NameArgument("CountrySubdivision")]
        CountrySubdivision = 1 << 2,

        [NameArgument("CountryTertiarySubdivision")]
        CountryTertiarySubdivision,

        [NameArgument("Municipality")]
        Municipality = 1 << 3,

        [NameArgument("MunicipalitySubdivision")]
        MunicipalitySubdivision = 1 << 4,

        [NameArgument("Neighbourhood")]
        Neighbourhood = 1 << 5,


        [NameArgument("PostalCodeArea")]
        PostalCodeArea = 1 << 6


    }
}
