﻿// Copyright (c) 2019 DHGMS Solutions and Contributors. All rights reserved.
// This file is licensed to you under the MIT license.
// See the LICENSE file in the project root for full license information.

using System;
using System.Collections.Generic;
using System.Text;

namespace Dhgms.AspNetCoreContrib.App.Features.Mediatr
{
    /// <summary>
    /// Represents a MediatR registration.
    /// </summary>
    public interface IMediatrRegistrationModel
    {
        /// <summary>
        /// Gets the registration type.
        /// </summary>
        public Type ServiceType { get; }

        /// <summary>
        /// Gets the implementation type.
        /// </summary>
        public Type ImplementationType { get; }
    }
}
