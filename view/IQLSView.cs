using System;
using System.Collections.Generic;
using System.Text;

namespace DoAnCSharp.view
{
    internal interface IQLSView
    {
        // Khai báo sự kiện mà Controller có thể đăng ký
        event EventHandler SaveClicked;
        event EventHandler SearchClicked;

        // Các thuộc tính để lấy dữ liệu từ UI
        string StudentId { get; }
    }
}
