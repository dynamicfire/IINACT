namespace FetchDependencies;

public static class ApiVersion
{
    public static readonly Version IinactApiVersion = new(1, 3, 0);
    public static readonly string NamespaceIdentifier = 
        $"IINACT_API_V{IinactApiVersion.ToString().Replace(".", "_")}";
}
