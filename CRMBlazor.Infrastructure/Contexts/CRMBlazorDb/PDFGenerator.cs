namespace CRMBlazor.Infrastructure.Contexts.CRMBlazorDb
{
    public class PDFGenerator
    {
        public string html { get; set; }
        public string filename { get; set; }
        public string outDir { get; set; } = "/PDF/";
    }
}
