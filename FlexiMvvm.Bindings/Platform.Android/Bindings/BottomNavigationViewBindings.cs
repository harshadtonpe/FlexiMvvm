﻿// =========================================================================
// Copyright 2018 EPAM Systems, Inc.
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
using System.Windows.Input;
using Android.Support.Design.Widget;
using FlexiMvvm.Bindings.Custom;
using JetBrains.Annotations;

namespace FlexiMvvm.Bindings
{
    public static class BottomNavigationViewBindings
    {
        /// <summary>
        /// Two way binding on <see cref="BottomNavigationView.SelectedItemId"/> property and <see cref="BottomNavigationView.NavigationItemSelected"/> event.
        /// </summary>
        /// <param name="bottomNavigationViewReference">The item reference.</param>
        /// <param name="trackCanExecuteCommandChanged">If set to <c>true</c> then <see cref="BottomNavigationView.Enabled"/> value will be updated based on <see cref="ICommand.CanExecute(object)"/> result.</param>
        /// <returns>Two way binding on <see cref="BottomNavigationView.SelectedItemId"/> property and <see cref="BottomNavigationView.NavigationItemSelected"/> event.</returns>
        /// <exception cref="ArgumentNullException">bottomNavigationViewReference is null.</exception>
        [NotNull]
        public static TargetItemBinding<BottomNavigationView, int> SelectedItemIdAndNavigationItemSelectedBinding(
            [NotNull] this IItemReference<BottomNavigationView> bottomNavigationViewReference,
            bool trackCanExecuteCommandChanged = false)
        {
            if (bottomNavigationViewReference == null)
                throw new ArgumentNullException(nameof(bottomNavigationViewReference));

            return new TargetItemTwoWayCustomBinding<BottomNavigationView, int, BottomNavigationView.NavigationItemSelectedEventArgs>(
                bottomNavigationViewReference,
                (bottomNavigationView, eventHandler) => bottomNavigationView.NotNull().NavigationItemSelected += eventHandler,
                (bottomNavigationView, eventHandler) => bottomNavigationView.NotNull().NavigationItemSelected -= eventHandler,
                (bottomNavigationView, canExecuteCommand) =>
                {
                    if (trackCanExecuteCommandChanged)
                    {
                        bottomNavigationView.NotNull().Enabled = canExecuteCommand;
                    }
                },
                (bottomNavigationView, eventArgs) => eventArgs?.Item.NotNull().ItemId ?? bottomNavigationView.NotNull().SelectedItemId,
                (bottomNavigationView, selectedItemId) => bottomNavigationView.NotNull().SelectedItemId = selectedItemId,
                () => "SelectedItemIdAndNavigationItemSelected");
        }
    }
}