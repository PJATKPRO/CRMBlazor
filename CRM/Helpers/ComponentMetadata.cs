namespace CRMBlazor.Helpers
{
    internal sealed class ComponentMetadata
    {
        public Type ComponentType { get; set; }
        public Dictionary<string, object> ComponentParameters { get; set; }
    }
}
