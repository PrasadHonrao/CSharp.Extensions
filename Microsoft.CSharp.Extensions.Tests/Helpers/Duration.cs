﻿using System.ComponentModel;

namespace Microsoft.CSharp.Extensions.Tests.Helpers
{
    public enum Duration
    {
        [Description("Eight hours")]
        Day,

        [Description("Five days")]
        Week,

        [Description("Twenty-one days")]
        Month,

        [Description("")]
        HalfYear,

        Year
    }
}