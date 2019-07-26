namespace AzureMapsToolkit.Mobility
{
    /// <summary>
    /// The type of the query. By default originType=position, specified as a comma separated string composed by latitude followed by longitude, e.g. "47.641268,-122.125679”.
    /// </summary>
    public enum QueryType : byte
    {
        Position,

        CountryCode
    }
}