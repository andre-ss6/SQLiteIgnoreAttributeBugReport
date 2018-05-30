using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;

namespace SQLiteIgnoreAttributeBugReport
{
    public class PocoBug
    {
        public virtual int Id { get; set; }
        public virtual IEnumerable<int> Bug { get; set; }
    }
}