﻿// Copyright (c) 2020 DHGMS Solutions and Contributors. All rights reserved.
// DHGMS Solutions and Contributors licenses this file to you under the MIT license.
// See the LICENSE file in the project root for full license information.

namespace Whipstaff.Core.Entities
{
    /// <summary>
    /// Represents an object that has a User Id.
    /// </summary>
    /// <typeparam name="T">The type for user id.</typeparam>
    public interface IUserId<out T>
    {
        /// <summary>
        /// Gets the User Id.
        /// </summary>
        T UserId { get; }
    }
}