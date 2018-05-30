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
using SQLite;

namespace SQLiteIgnoreAttributeBugReport
{
    public class Derived : PocoBug
    {
        [PrimaryKey]
        public override int Id { get; set; }

        [Ignore]
        public override IEnumerable<int> Bug { get; set; }
    }
}