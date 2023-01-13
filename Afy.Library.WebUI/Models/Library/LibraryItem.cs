namespace Afy.Library.WebUI.Models.Library
{
    public class LibraryItem : BaseEntity
    {
        public string? Name { get; set; }
        public bool IsFolder { get; set; }
        public string? ParentId { get; set; }
    }
}
