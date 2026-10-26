using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using PagedList.Mvc;

namespace MyStore.Models.ViewModell
{
    public class ProductSearchVM
    {
        //tiêu chí để search theo tên, mô tả sp
        //hoặc loại sản phẩm
        public string SearchTerm { get; set; }

        //các tiêu chí để search theo giá
        public decimal? MinPrice { get; set; }
        public decimal? MaxPrice { get; set; }

        public string SortOder { get; set; } //tiêu chí sắp xếp sản phẩm theo giá

        //các thuộc tính hỗ trợ phân trang
        public int PageNumber { get; set; } //số trang hiện tại
        public int PageSize { get; set; } = 10; //số lượng sản phẩm hiển thị trên 1 trang

        //danh sách sản phẩm đã phân trang
        public PagedList.IPagedList<Product> PagedProducts { get; set; }
        public List<Product> Products { get; internal set; }
    }
}