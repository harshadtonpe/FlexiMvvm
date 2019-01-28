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

using JetBrains.Annotations;

namespace FlexiMvvm
{
    internal static class StringExtensions
    {
        [NotNull]
        internal static string WithoutNamespace([NotNull] this string value)
        {
            var sanitizedClassName = value.WithoutGenericPart();

            return value.Substring(sanitizedClassName.LastIndexOf('.') + 1);
        }

        [NotNull]
        internal static string WithoutInterfacePrefix([NotNull] this string value)
        {
            return value.TrimStart('I');
        }

        [NotNull]
        internal static string WithoutGenericPart([NotNull] this string value)
        {
            return value.Contains("<") ? value.Substring(0, value.IndexOf('<')) : value;
        }
    }
}
