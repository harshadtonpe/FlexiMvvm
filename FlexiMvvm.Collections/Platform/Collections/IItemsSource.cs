﻿// =========================================================================
// Copyright 2019 EPAM Systems, Inc.
//
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
//
// http://www.apache.org/licenses/LICENSE-2.0
//
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// See the License for the specific language governing permissions and
// limitations under the License.
// =========================================================================

using System.Collections.Generic;

namespace FlexiMvvm.Collections
{
    /// <summary>
    /// Defines the contract for a object which contains items collection.
    /// </summary>
    /// <typeparam name="T">The type of the collection item.</typeparam>
    public interface IItemsSource<T>
    {
        /// <summary>
        /// Gets or sets gets the collection of items. Can be <c>null</c>.
        /// </summary>
        IEnumerable<T>? Items { get; set; }
    }
}
