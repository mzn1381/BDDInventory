namespace Inventory.Presentation.Test.Integration.NetCoreHosting
{
    public static class HostConstants
    {
        public const int Port = 5084;
        public static readonly string Endpoint = $"http://localhost:{Port}/";

        public const string CsProjectPath =
        // /Users/mzn1381/Program/TddTest/Tdd.Peresentation/Tdd.Peresentation.csproj
            @"/Users/mzn1381/Program/InventoryBddProject/Inventory.Presentation/Inventory.Presentation.csproj";
    }
}