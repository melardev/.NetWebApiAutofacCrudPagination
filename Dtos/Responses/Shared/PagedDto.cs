using WebApiAutofacCrudPagination.Models;

namespace WebApiAutofacCrudPagination.Dtos.Responses.Shared
{
    public abstract class PagedDto : SuccessResponse
    {
        public PageMeta PageMeta { get; set; }
    }
}