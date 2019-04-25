namespace DynamicViews.Models
{
    public class Report
    {
        public string Name { get; set; }

        public IReportViewModel ViewModel { get; set; }
    }
}
