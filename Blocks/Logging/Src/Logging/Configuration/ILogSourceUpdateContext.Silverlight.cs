﻿//===============================================================================
// Microsoft patterns & practices Enterprise Library
// Logging Application Block
//===============================================================================
// Copyright © Microsoft Corporation.  All rights reserved.
// THIS CODE AND INFORMATION IS PROVIDED "AS IS" WITHOUT WARRANTY
// OF ANY KIND, EITHER EXPRESSED OR IMPLIED, INCLUDING BUT NOT
// LIMITED TO THE IMPLIED WARRANTIES OF MERCHANTABILITY AND
// FITNESS FOR A PARTICULAR PURPOSE.
//===============================================================================

using System.Collections.Generic;

using Microsoft.Practices.EnterpriseLibrary.Logging.Diagnostics;

namespace Microsoft.Practices.EnterpriseLibrary.Logging.Configuration
{
    /// <summary>
    /// Provides an update context for changing the <see cref="LogSource"/> settings.
    /// </summary>
    public interface ILogSourceUpdateContext
    {
        /// <summary>
        /// Gets the name for the <see cref="LogSource"/> instance being configured.
        /// </summary>
        string Name { get; }

        /// <summary>
        /// Gets or sets the <see cref="SourceLevels"/> values at which to trace for the <see cref="LogSource"/> instance being configured.
        /// </summary>
        SourceLevels Level { get; set; }

        /// <summary>
        /// Gets or sets the <see cref="AutoFlush"/> values for the <see cref="LogSource"/> instance being configured.
        /// </summary>
        bool AutoFlush { get; set; }

        /// <summary>
        /// Gets a collection of configured <see cref="TraceListener"/>s for the <see cref="LogSource"/> instance. This collection can be updated.
        /// </summary>
        ICollection<string> Listeners { get; }
    }
}