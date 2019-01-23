﻿// <auto-generated />
// =========================================================================
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
using FlexiMvvm.Bindings;
using FlexiMvvm.ViewModels;
using FlexiMvvm.ViewModels.Core;
using FlexiMvvm.Views;
using FlexiMvvm.Views.Core;

namespace FlexiMvvm.Views
{
    public partial class BindableViewController<TViewModel> : ViewController<TViewModel>, IBindableView<TViewModel>, IBindingSetOwner
        where TViewModel : class, IViewModel
    {
        new protected IBindableViewLifecycleDelegate LifecycleDelegate => (IBindableViewLifecycleDelegate)base.LifecycleDelegate;

        public IDisposable BindingSet { get; private set; }

        protected override IViewLifecycleDelegate CreateLifecycleDelegate()
        {
            return new BindableViewLifecycleDelegate<BindableViewController<TViewModel>, TViewModel>(this);
        }

        public void Bind()
        {
            LifecycleDelegate.Bind();
        }

        public virtual void Bind(BindingSet<TViewModel> bindingSet)
        {
        }

        void IBindingSetOwner.SetBindingSet(IDisposable bindingSet)
        {
            BindingSet = bindingSet;
        }
    }

    public partial class BindableViewController<TViewModel, TParameters> : ViewController<TViewModel, TParameters>, IBindableView<TViewModel>, IBindingSetOwner
        where TViewModel : class, IViewModelWithParameters<TParameters>, IParametersOwner<TParameters>
        where TParameters : Parameters
    {
        public BindableViewController(TParameters parameters)
            : base(parameters)
        {
        }

        new protected IBindableViewLifecycleDelegate LifecycleDelegate => (IBindableViewLifecycleDelegate)base.LifecycleDelegate;

        public IDisposable BindingSet { get; private set; }

        protected override IViewLifecycleDelegate CreateLifecycleDelegate()
        {
            return new BindableViewLifecycleDelegate<BindableViewController<TViewModel, TParameters>, TViewModel>(this);
        }

        public void Bind()
        {
            LifecycleDelegate.Bind();
        }

        public virtual void Bind(BindingSet<TViewModel> bindingSet)
        {
        }

        void IBindingSetOwner.SetBindingSet(IDisposable bindingSet)
        {
            BindingSet = bindingSet;
        }
    }
}

namespace FlexiMvvm.Views
{
    public partial class BindableTabBarController<TViewModel> : TabBarController<TViewModel>, IBindableView<TViewModel>, IBindingSetOwner
        where TViewModel : class, IViewModel
    {
        new protected IBindableViewLifecycleDelegate LifecycleDelegate => (IBindableViewLifecycleDelegate)base.LifecycleDelegate;

        public IDisposable BindingSet { get; private set; }

        protected override IViewLifecycleDelegate CreateLifecycleDelegate()
        {
            return new BindableViewLifecycleDelegate<BindableTabBarController<TViewModel>, TViewModel>(this);
        }

        public void Bind()
        {
            LifecycleDelegate.Bind();
        }

        public virtual void Bind(BindingSet<TViewModel> bindingSet)
        {
        }

        void IBindingSetOwner.SetBindingSet(IDisposable bindingSet)
        {
            BindingSet = bindingSet;
        }
    }

    public partial class BindableTabBarController<TViewModel, TParameters> : TabBarController<TViewModel, TParameters>, IBindableView<TViewModel>, IBindingSetOwner
        where TViewModel : class, IViewModelWithParameters<TParameters>, IParametersOwner<TParameters>
        where TParameters : Parameters
    {
        public BindableTabBarController(TParameters parameters)
            : base(parameters)
        {
        }

        new protected IBindableViewLifecycleDelegate LifecycleDelegate => (IBindableViewLifecycleDelegate)base.LifecycleDelegate;

        public IDisposable BindingSet { get; private set; }

        protected override IViewLifecycleDelegate CreateLifecycleDelegate()
        {
            return new BindableViewLifecycleDelegate<BindableTabBarController<TViewModel, TParameters>, TViewModel>(this);
        }

        public void Bind()
        {
            LifecycleDelegate.Bind();
        }

        public virtual void Bind(BindingSet<TViewModel> bindingSet)
        {
        }

        void IBindingSetOwner.SetBindingSet(IDisposable bindingSet)
        {
            BindingSet = bindingSet;
        }
    }
}

namespace FlexiMvvm.Views
{
    public partial class BindablePageViewController<TViewModel> : PageViewController<TViewModel>, IBindableView<TViewModel>, IBindingSetOwner
        where TViewModel : class, IViewModel
    {
        new protected IBindableViewLifecycleDelegate LifecycleDelegate => (IBindableViewLifecycleDelegate)base.LifecycleDelegate;

        public IDisposable BindingSet { get; private set; }

        protected override IViewLifecycleDelegate CreateLifecycleDelegate()
        {
            return new BindableViewLifecycleDelegate<BindablePageViewController<TViewModel>, TViewModel>(this);
        }

        public void Bind()
        {
            LifecycleDelegate.Bind();
        }

        public virtual void Bind(BindingSet<TViewModel> bindingSet)
        {
        }

        void IBindingSetOwner.SetBindingSet(IDisposable bindingSet)
        {
            BindingSet = bindingSet;
        }
    }

    public partial class BindablePageViewController<TViewModel, TParameters> : PageViewController<TViewModel, TParameters>, IBindableView<TViewModel>, IBindingSetOwner
        where TViewModel : class, IViewModelWithParameters<TParameters>, IParametersOwner<TParameters>
        where TParameters : Parameters
    {
        public BindablePageViewController(TParameters parameters)
            : base(parameters)
        {
        }

        new protected IBindableViewLifecycleDelegate LifecycleDelegate => (IBindableViewLifecycleDelegate)base.LifecycleDelegate;

        public IDisposable BindingSet { get; private set; }

        protected override IViewLifecycleDelegate CreateLifecycleDelegate()
        {
            return new BindableViewLifecycleDelegate<BindablePageViewController<TViewModel, TParameters>, TViewModel>(this);
        }

        public void Bind()
        {
            LifecycleDelegate.Bind();
        }

        public virtual void Bind(BindingSet<TViewModel> bindingSet)
        {
        }

        void IBindingSetOwner.SetBindingSet(IDisposable bindingSet)
        {
            BindingSet = bindingSet;
        }
    }
}
