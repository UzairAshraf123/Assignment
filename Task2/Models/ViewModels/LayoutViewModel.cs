using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Task2.Models.ViewModels
{
    public class LayoutViewModel
    {
        public string Header { get; set; }

        public IEnumerable<string> Permissions { get; set; }

    }
}