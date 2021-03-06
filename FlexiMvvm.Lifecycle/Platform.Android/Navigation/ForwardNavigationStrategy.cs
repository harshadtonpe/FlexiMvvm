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

using System;
using Android.Content;
using Android.OS;
using FlexiMvvm.ViewModels;
using FlexiMvvm.Views;
using JetBrains.Annotations;

namespace FlexiMvvm.Navigation
{
    /// <summary>
    /// Defines the contract for forward navigation.
    /// </summary>
    /// <param name="sourceView">The source view from which navigation is performed from.</param>
    /// <param name="targetViewIntent">The description of the target view.</param>
    /// <param name="requestCode">The target view result identifier.</param>
    public delegate void ForwardNavigationDelegate([NotNull] INavigationView<IViewModel> sourceView, [NotNull] Intent targetViewIntent, int? requestCode = null);

    /// <summary>
    /// Provides a set of forward navigation strategies.
    /// </summary>
    public sealed class ForwardNavigationStrategy
    {
        /// <summary>
        /// Forward navigation using <see cref="INavigationView{TViewModel}.StartActivity(Intent, Bundle)"/> method.
        /// </summary>
        /// <param name="options">Additional options for how the target view should be started.</param>
        /// <returns>The forward navigation delegate.</returns>
        [NotNull]
        public ForwardNavigationDelegate StartActivity([CanBeNull] Bundle options = null)
        {
            return (sourceView, targetViewIntent, requestCode) =>
            {
                sourceView.NotNull().StartActivity(targetViewIntent.NotNull(), options);
            };
        }

        /// <summary>
        /// Forward navigation using <see cref="INavigationView{TViewModel}.StartActivityForResult(Intent, int, Bundle)"/> method.
        /// </summary>
        /// <param name="options">Additional options for how the target view should be started.</param>
        /// <returns>The forward navigation delegate.</returns>
        [NotNull]
        public ForwardNavigationDelegate StartActivityForResult([CanBeNull] Bundle options = null)
        {
            return (sourceView, targetViewIntent, requestCode) =>
            {
                if (requestCode == null)
                {
                    throw new ArgumentNullException(
                        $"Request code should be specified for '{nameof(StartActivityForResult)}' navigation strategy.", nameof(requestCode));
                }

                sourceView.NotNull().StartActivityForResult(targetViewIntent.NotNull(), requestCode.Value, options);
            };
        }
    }
}
