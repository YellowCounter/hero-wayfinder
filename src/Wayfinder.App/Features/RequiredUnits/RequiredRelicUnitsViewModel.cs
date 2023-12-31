﻿using Microsoft.Extensions.Localization;
using System.Text.RegularExpressions;

namespace Wayfinder.App.Features.RequiredUnits
{
    public partial class RequiredRelicUnitsViewModel : RequiredUnitsViewModel
    {
        [GeneratedRegex("^RELIC")]
        protected override partial Regex IsValidRequirement();

        public RequiredRelicUnitsViewModel(IStringLocalizer<Resources> localizer)
            : base(localizer)
        { }
    }
}
