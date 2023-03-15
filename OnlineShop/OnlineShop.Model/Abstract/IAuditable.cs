using System;

namespace OnlineShop.Model.Abstract
{
    public interface IAuditable
    {
        DateTime? CreatedDate { get; set; }
        string CreatedBy { get; set; }
        DateTime? UpdatedDate { get; set; }
        string UpdatedBy { get; set; }

        string MetaKeyword { set; get; }
        string MetaDescription { set; get; }

        bool Status { get; set; }
    }
}
