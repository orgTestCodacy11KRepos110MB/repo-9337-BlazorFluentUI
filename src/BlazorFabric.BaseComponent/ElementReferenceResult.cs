﻿using Microsoft.AspNetCore.Components;
using System;
using System.Collections.Generic;
using System.Text;

namespace BlazorFabric
{

    /// <summary>
    /// This class is returned from JSInterop so we can tell if the returned ElementReference is empty or not.  We can't inspect the contents in C# so we need a flag.
    /// </summary>
    public class ElementReferenceResult
    {
        public ElementReference ElementReference { get; set; }
        public bool IsNull { get; set; }
    }
}
