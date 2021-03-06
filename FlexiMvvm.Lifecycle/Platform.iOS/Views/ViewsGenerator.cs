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
using System.Threading.Tasks;
using FlexiMvvm.ViewModels;
using FlexiMvvm.ViewModels.Core;
using FlexiMvvm.Views.Core;
using FlexiMvvm.Views.Keyboard;

namespace FlexiMvvm.Views
{
    public partial class CollectionViewController : UIKit.UICollectionViewController, IIosView, IKeyboardHandlerOwner
    {
        private IViewLifecycleDelegate _lifecycleDelegate;
        private KeyboardHandler _keyboardHandler;

        protected IViewLifecycleDelegate LifecycleDelegate => _lifecycleDelegate ?? (_lifecycleDelegate = CreateLifecycleDelegate());

        public virtual bool HandleKeyboard { get; } = false;

        public KeyboardHandler KeyboardHandler => _keyboardHandler;

        protected virtual IViewLifecycleDelegate CreateLifecycleDelegate()
        {
            return new ViewLifecycleDelegate<CollectionViewController>(this);
        }

        public override void ViewDidLoad()
        {
            base.ViewDidLoad();

            LifecycleDelegate.ViewDidLoad();
        }

        public override void ViewWillAppear(bool animated)
        {
            base.ViewWillAppear(animated);

            LifecycleDelegate.ViewWillAppear();
        }

        public override void ViewWillDisappear(bool animated)
        {
            base.ViewWillDisappear(animated);

            LifecycleDelegate.ViewWillDisappear();
        }

        public override void ViewDidDisappear(bool animated)
        {
            base.ViewDidDisappear(animated);

            LifecycleDelegate.ViewDidDisappear();
        }

        void IKeyboardHandlerOwner.SetKeyboardHandler(KeyboardHandler handler)
        {
            _keyboardHandler = handler;
        }
    }

    public partial class CollectionViewController<TViewModel> : CollectionViewController, INavigationView<TViewModel>, IViewModelOwner<TViewModel>
        where TViewModel : class, IViewModelWithoutParameters
    {
        public event EventHandler<ResultSetEventArgs> ResultSet;

        public TViewModel ViewModel { get; private set; }

        protected override IViewLifecycleDelegate CreateLifecycleDelegate()
        {
            return new ViewLifecycleDelegate<CollectionViewController<TViewModel>, TViewModel>(this);
        }

        public void SetResult(ResultCode resultCode)
        {
            LifecycleDelegate.SetResult(resultCode);
        }

        public void SetResult(ResultCode resultCode, Result result)
        {
            LifecycleDelegate.SetResult(resultCode, result);
        }

        public void RaiseResultSet(ResultCode resultCode, Result? result)
        {
            ResultSet?.Invoke(this, new ResultSetEventArgs(resultCode, result));
        }

        public void HandleResult(object sender, ResultSetEventArgs args)
        {
            if (sender == null)
                throw new ArgumentNullException(nameof(sender));
            if (args == null)
                throw new ArgumentNullException(nameof(args));

            LifecycleDelegate.HandleResult(sender, args);
        }

        void IViewModelOwner<TViewModel>.SetViewModel(TViewModel viewModel)
        {
            ViewModel = viewModel ?? throw new ArgumentNullException(nameof(viewModel));
        }

        async Task IViewModelOwner<TViewModel>.InitializeViewModelAsync()
        {
            await ViewModel.InitializeAsync();
        }
    }

    public partial class CollectionViewController<TViewModel, TParameters> : CollectionViewController, INavigationView<TViewModel>, IViewModelOwner<TViewModel>
        where TViewModel : class, IViewModelWithParameters<TParameters>
        where TParameters : Parameters
    {
        private readonly TParameters _parameters;

        public CollectionViewController(TParameters parameters)
        {
            _parameters = parameters;
        }

        public event EventHandler<ResultSetEventArgs> ResultSet;

        public TViewModel ViewModel { get; private set; }

        protected override IViewLifecycleDelegate CreateLifecycleDelegate()
        {
            return new ViewLifecycleDelegate<CollectionViewController<TViewModel, TParameters>, TViewModel>(this);
        }

        public void SetResult(ResultCode resultCode)
        {
            LifecycleDelegate.SetResult(resultCode);
        }

        public void SetResult(ResultCode resultCode, Result result)
        {
            LifecycleDelegate.SetResult(resultCode, result);
        }

        public void RaiseResultSet(ResultCode resultCode, Result? result)
        {
            ResultSet?.Invoke(this, new ResultSetEventArgs(resultCode, result));
        }

        public void HandleResult(object sender, ResultSetEventArgs args)
        {
            if (sender == null)
                throw new ArgumentNullException(nameof(sender));
            if (args == null)
                throw new ArgumentNullException(nameof(args));

            LifecycleDelegate.HandleResult(sender, args);
        }

        void IViewModelOwner<TViewModel>.SetViewModel(TViewModel viewModel)
        {
            ViewModel = viewModel ?? throw new ArgumentNullException(nameof(viewModel));
        }

        async Task IViewModelOwner<TViewModel>.InitializeViewModelAsync()
        {
            await ViewModel.InitializeAsync(_parameters);
        }
    }
}

namespace FlexiMvvm.Views
{
    public partial class NavigationController : UIKit.UINavigationController, IIosView, IKeyboardHandlerOwner
    {
        private IViewLifecycleDelegate _lifecycleDelegate;
        private KeyboardHandler _keyboardHandler;

        protected IViewLifecycleDelegate LifecycleDelegate => _lifecycleDelegate ?? (_lifecycleDelegate = CreateLifecycleDelegate());

        public virtual bool HandleKeyboard { get; } = false;

        public KeyboardHandler KeyboardHandler => _keyboardHandler;

        protected virtual IViewLifecycleDelegate CreateLifecycleDelegate()
        {
            return new ViewLifecycleDelegate<NavigationController>(this);
        }

        public override void ViewDidLoad()
        {
            base.ViewDidLoad();

            LifecycleDelegate.ViewDidLoad();
        }

        public override void ViewWillAppear(bool animated)
        {
            base.ViewWillAppear(animated);

            LifecycleDelegate.ViewWillAppear();
        }

        public override void ViewWillDisappear(bool animated)
        {
            base.ViewWillDisappear(animated);

            LifecycleDelegate.ViewWillDisappear();
        }

        public override void ViewDidDisappear(bool animated)
        {
            base.ViewDidDisappear(animated);

            LifecycleDelegate.ViewDidDisappear();
        }

        void IKeyboardHandlerOwner.SetKeyboardHandler(KeyboardHandler handler)
        {
            _keyboardHandler = handler;
        }
    }

    public partial class NavigationController<TViewModel> : NavigationController, INavigationView<TViewModel>, IViewModelOwner<TViewModel>
        where TViewModel : class, IViewModelWithoutParameters
    {
        public event EventHandler<ResultSetEventArgs> ResultSet;

        public TViewModel ViewModel { get; private set; }

        protected override IViewLifecycleDelegate CreateLifecycleDelegate()
        {
            return new ViewLifecycleDelegate<NavigationController<TViewModel>, TViewModel>(this);
        }

        public void SetResult(ResultCode resultCode)
        {
            LifecycleDelegate.SetResult(resultCode);
        }

        public void SetResult(ResultCode resultCode, Result result)
        {
            LifecycleDelegate.SetResult(resultCode, result);
        }

        public void RaiseResultSet(ResultCode resultCode, Result? result)
        {
            ResultSet?.Invoke(this, new ResultSetEventArgs(resultCode, result));
        }

        public void HandleResult(object sender, ResultSetEventArgs args)
        {
            if (sender == null)
                throw new ArgumentNullException(nameof(sender));
            if (args == null)
                throw new ArgumentNullException(nameof(args));

            LifecycleDelegate.HandleResult(sender, args);
        }

        void IViewModelOwner<TViewModel>.SetViewModel(TViewModel viewModel)
        {
            ViewModel = viewModel ?? throw new ArgumentNullException(nameof(viewModel));
        }

        async Task IViewModelOwner<TViewModel>.InitializeViewModelAsync()
        {
            await ViewModel.InitializeAsync();
        }
    }

    public partial class NavigationController<TViewModel, TParameters> : NavigationController, INavigationView<TViewModel>, IViewModelOwner<TViewModel>
        where TViewModel : class, IViewModelWithParameters<TParameters>
        where TParameters : Parameters
    {
        private readonly TParameters _parameters;

        public NavigationController(TParameters parameters)
        {
            _parameters = parameters;
        }

        public event EventHandler<ResultSetEventArgs> ResultSet;

        public TViewModel ViewModel { get; private set; }

        protected override IViewLifecycleDelegate CreateLifecycleDelegate()
        {
            return new ViewLifecycleDelegate<NavigationController<TViewModel, TParameters>, TViewModel>(this);
        }

        public void SetResult(ResultCode resultCode)
        {
            LifecycleDelegate.SetResult(resultCode);
        }

        public void SetResult(ResultCode resultCode, Result result)
        {
            LifecycleDelegate.SetResult(resultCode, result);
        }

        public void RaiseResultSet(ResultCode resultCode, Result? result)
        {
            ResultSet?.Invoke(this, new ResultSetEventArgs(resultCode, result));
        }

        public void HandleResult(object sender, ResultSetEventArgs args)
        {
            if (sender == null)
                throw new ArgumentNullException(nameof(sender));
            if (args == null)
                throw new ArgumentNullException(nameof(args));

            LifecycleDelegate.HandleResult(sender, args);
        }

        void IViewModelOwner<TViewModel>.SetViewModel(TViewModel viewModel)
        {
            ViewModel = viewModel ?? throw new ArgumentNullException(nameof(viewModel));
        }

        async Task IViewModelOwner<TViewModel>.InitializeViewModelAsync()
        {
            await ViewModel.InitializeAsync(_parameters);
        }
    }
}

namespace FlexiMvvm.Views
{
    public partial class PageViewController : UIKit.UIPageViewController, IIosView, IKeyboardHandlerOwner
    {
        private IViewLifecycleDelegate _lifecycleDelegate;
        private KeyboardHandler _keyboardHandler;

        protected IViewLifecycleDelegate LifecycleDelegate => _lifecycleDelegate ?? (_lifecycleDelegate = CreateLifecycleDelegate());

        public virtual bool HandleKeyboard { get; } = false;

        public KeyboardHandler KeyboardHandler => _keyboardHandler;

        protected virtual IViewLifecycleDelegate CreateLifecycleDelegate()
        {
            return new ViewLifecycleDelegate<PageViewController>(this);
        }

        public override void ViewDidLoad()
        {
            base.ViewDidLoad();

            LifecycleDelegate.ViewDidLoad();
        }

        public override void ViewWillAppear(bool animated)
        {
            base.ViewWillAppear(animated);

            LifecycleDelegate.ViewWillAppear();
        }

        public override void ViewWillDisappear(bool animated)
        {
            base.ViewWillDisappear(animated);

            LifecycleDelegate.ViewWillDisappear();
        }

        public override void ViewDidDisappear(bool animated)
        {
            base.ViewDidDisappear(animated);

            LifecycleDelegate.ViewDidDisappear();
        }

        void IKeyboardHandlerOwner.SetKeyboardHandler(KeyboardHandler handler)
        {
            _keyboardHandler = handler;
        }
    }

    public partial class PageViewController<TViewModel> : PageViewController, INavigationView<TViewModel>, IViewModelOwner<TViewModel>
        where TViewModel : class, IViewModelWithoutParameters
    {
        public event EventHandler<ResultSetEventArgs> ResultSet;

        public TViewModel ViewModel { get; private set; }

        protected override IViewLifecycleDelegate CreateLifecycleDelegate()
        {
            return new ViewLifecycleDelegate<PageViewController<TViewModel>, TViewModel>(this);
        }

        public void SetResult(ResultCode resultCode)
        {
            LifecycleDelegate.SetResult(resultCode);
        }

        public void SetResult(ResultCode resultCode, Result result)
        {
            LifecycleDelegate.SetResult(resultCode, result);
        }

        public void RaiseResultSet(ResultCode resultCode, Result? result)
        {
            ResultSet?.Invoke(this, new ResultSetEventArgs(resultCode, result));
        }

        public void HandleResult(object sender, ResultSetEventArgs args)
        {
            if (sender == null)
                throw new ArgumentNullException(nameof(sender));
            if (args == null)
                throw new ArgumentNullException(nameof(args));

            LifecycleDelegate.HandleResult(sender, args);
        }

        void IViewModelOwner<TViewModel>.SetViewModel(TViewModel viewModel)
        {
            ViewModel = viewModel ?? throw new ArgumentNullException(nameof(viewModel));
        }

        async Task IViewModelOwner<TViewModel>.InitializeViewModelAsync()
        {
            await ViewModel.InitializeAsync();
        }
    }

    public partial class PageViewController<TViewModel, TParameters> : PageViewController, INavigationView<TViewModel>, IViewModelOwner<TViewModel>
        where TViewModel : class, IViewModelWithParameters<TParameters>
        where TParameters : Parameters
    {
        private readonly TParameters _parameters;

        public PageViewController(TParameters parameters)
        {
            _parameters = parameters;
        }

        public event EventHandler<ResultSetEventArgs> ResultSet;

        public TViewModel ViewModel { get; private set; }

        protected override IViewLifecycleDelegate CreateLifecycleDelegate()
        {
            return new ViewLifecycleDelegate<PageViewController<TViewModel, TParameters>, TViewModel>(this);
        }

        public void SetResult(ResultCode resultCode)
        {
            LifecycleDelegate.SetResult(resultCode);
        }

        public void SetResult(ResultCode resultCode, Result result)
        {
            LifecycleDelegate.SetResult(resultCode, result);
        }

        public void RaiseResultSet(ResultCode resultCode, Result? result)
        {
            ResultSet?.Invoke(this, new ResultSetEventArgs(resultCode, result));
        }

        public void HandleResult(object sender, ResultSetEventArgs args)
        {
            if (sender == null)
                throw new ArgumentNullException(nameof(sender));
            if (args == null)
                throw new ArgumentNullException(nameof(args));

            LifecycleDelegate.HandleResult(sender, args);
        }

        void IViewModelOwner<TViewModel>.SetViewModel(TViewModel viewModel)
        {
            ViewModel = viewModel ?? throw new ArgumentNullException(nameof(viewModel));
        }

        async Task IViewModelOwner<TViewModel>.InitializeViewModelAsync()
        {
            await ViewModel.InitializeAsync(_parameters);
        }
    }
}

namespace FlexiMvvm.Views
{
    public partial class SplitViewController : UIKit.UISplitViewController, IIosView, IKeyboardHandlerOwner
    {
        private IViewLifecycleDelegate _lifecycleDelegate;
        private KeyboardHandler _keyboardHandler;

        protected IViewLifecycleDelegate LifecycleDelegate => _lifecycleDelegate ?? (_lifecycleDelegate = CreateLifecycleDelegate());

        public virtual bool HandleKeyboard { get; } = false;

        public KeyboardHandler KeyboardHandler => _keyboardHandler;

        protected virtual IViewLifecycleDelegate CreateLifecycleDelegate()
        {
            return new ViewLifecycleDelegate<SplitViewController>(this);
        }

        public override void ViewDidLoad()
        {
            base.ViewDidLoad();

            LifecycleDelegate.ViewDidLoad();
        }

        public override void ViewWillAppear(bool animated)
        {
            base.ViewWillAppear(animated);

            LifecycleDelegate.ViewWillAppear();
        }

        public override void ViewWillDisappear(bool animated)
        {
            base.ViewWillDisappear(animated);

            LifecycleDelegate.ViewWillDisappear();
        }

        public override void ViewDidDisappear(bool animated)
        {
            base.ViewDidDisappear(animated);

            LifecycleDelegate.ViewDidDisappear();
        }

        void IKeyboardHandlerOwner.SetKeyboardHandler(KeyboardHandler handler)
        {
            _keyboardHandler = handler;
        }
    }

    public partial class SplitViewController<TViewModel> : SplitViewController, INavigationView<TViewModel>, IViewModelOwner<TViewModel>
        where TViewModel : class, IViewModelWithoutParameters
    {
        public event EventHandler<ResultSetEventArgs> ResultSet;

        public TViewModel ViewModel { get; private set; }

        protected override IViewLifecycleDelegate CreateLifecycleDelegate()
        {
            return new ViewLifecycleDelegate<SplitViewController<TViewModel>, TViewModel>(this);
        }

        public void SetResult(ResultCode resultCode)
        {
            LifecycleDelegate.SetResult(resultCode);
        }

        public void SetResult(ResultCode resultCode, Result result)
        {
            LifecycleDelegate.SetResult(resultCode, result);
        }

        public void RaiseResultSet(ResultCode resultCode, Result? result)
        {
            ResultSet?.Invoke(this, new ResultSetEventArgs(resultCode, result));
        }

        public void HandleResult(object sender, ResultSetEventArgs args)
        {
            if (sender == null)
                throw new ArgumentNullException(nameof(sender));
            if (args == null)
                throw new ArgumentNullException(nameof(args));

            LifecycleDelegate.HandleResult(sender, args);
        }

        void IViewModelOwner<TViewModel>.SetViewModel(TViewModel viewModel)
        {
            ViewModel = viewModel ?? throw new ArgumentNullException(nameof(viewModel));
        }

        async Task IViewModelOwner<TViewModel>.InitializeViewModelAsync()
        {
            await ViewModel.InitializeAsync();
        }
    }

    public partial class SplitViewController<TViewModel, TParameters> : SplitViewController, INavigationView<TViewModel>, IViewModelOwner<TViewModel>
        where TViewModel : class, IViewModelWithParameters<TParameters>
        where TParameters : Parameters
    {
        private readonly TParameters _parameters;

        public SplitViewController(TParameters parameters)
        {
            _parameters = parameters;
        }

        public event EventHandler<ResultSetEventArgs> ResultSet;

        public TViewModel ViewModel { get; private set; }

        protected override IViewLifecycleDelegate CreateLifecycleDelegate()
        {
            return new ViewLifecycleDelegate<SplitViewController<TViewModel, TParameters>, TViewModel>(this);
        }

        public void SetResult(ResultCode resultCode)
        {
            LifecycleDelegate.SetResult(resultCode);
        }

        public void SetResult(ResultCode resultCode, Result result)
        {
            LifecycleDelegate.SetResult(resultCode, result);
        }

        public void RaiseResultSet(ResultCode resultCode, Result? result)
        {
            ResultSet?.Invoke(this, new ResultSetEventArgs(resultCode, result));
        }

        public void HandleResult(object sender, ResultSetEventArgs args)
        {
            if (sender == null)
                throw new ArgumentNullException(nameof(sender));
            if (args == null)
                throw new ArgumentNullException(nameof(args));

            LifecycleDelegate.HandleResult(sender, args);
        }

        void IViewModelOwner<TViewModel>.SetViewModel(TViewModel viewModel)
        {
            ViewModel = viewModel ?? throw new ArgumentNullException(nameof(viewModel));
        }

        async Task IViewModelOwner<TViewModel>.InitializeViewModelAsync()
        {
            await ViewModel.InitializeAsync(_parameters);
        }
    }
}

namespace FlexiMvvm.Views
{
    public partial class TabBarController : UIKit.UITabBarController, IIosView, IKeyboardHandlerOwner
    {
        private IViewLifecycleDelegate _lifecycleDelegate;
        private KeyboardHandler _keyboardHandler;

        protected IViewLifecycleDelegate LifecycleDelegate => _lifecycleDelegate ?? (_lifecycleDelegate = CreateLifecycleDelegate());

        public virtual bool HandleKeyboard { get; } = false;

        public KeyboardHandler KeyboardHandler => _keyboardHandler;

        protected virtual IViewLifecycleDelegate CreateLifecycleDelegate()
        {
            return new ViewLifecycleDelegate<TabBarController>(this);
        }

        public override void ViewDidLoad()
        {
            base.ViewDidLoad();

            LifecycleDelegate.ViewDidLoad();
        }

        public override void ViewWillAppear(bool animated)
        {
            base.ViewWillAppear(animated);

            LifecycleDelegate.ViewWillAppear();
        }

        public override void ViewWillDisappear(bool animated)
        {
            base.ViewWillDisappear(animated);

            LifecycleDelegate.ViewWillDisappear();
        }

        public override void ViewDidDisappear(bool animated)
        {
            base.ViewDidDisappear(animated);

            LifecycleDelegate.ViewDidDisappear();
        }

        void IKeyboardHandlerOwner.SetKeyboardHandler(KeyboardHandler handler)
        {
            _keyboardHandler = handler;
        }
    }

    public partial class TabBarController<TViewModel> : TabBarController, INavigationView<TViewModel>, IViewModelOwner<TViewModel>
        where TViewModel : class, IViewModelWithoutParameters
    {
        public event EventHandler<ResultSetEventArgs> ResultSet;

        public TViewModel ViewModel { get; private set; }

        protected override IViewLifecycleDelegate CreateLifecycleDelegate()
        {
            return new ViewLifecycleDelegate<TabBarController<TViewModel>, TViewModel>(this);
        }

        public void SetResult(ResultCode resultCode)
        {
            LifecycleDelegate.SetResult(resultCode);
        }

        public void SetResult(ResultCode resultCode, Result result)
        {
            LifecycleDelegate.SetResult(resultCode, result);
        }

        public void RaiseResultSet(ResultCode resultCode, Result? result)
        {
            ResultSet?.Invoke(this, new ResultSetEventArgs(resultCode, result));
        }

        public void HandleResult(object sender, ResultSetEventArgs args)
        {
            if (sender == null)
                throw new ArgumentNullException(nameof(sender));
            if (args == null)
                throw new ArgumentNullException(nameof(args));

            LifecycleDelegate.HandleResult(sender, args);
        }

        void IViewModelOwner<TViewModel>.SetViewModel(TViewModel viewModel)
        {
            ViewModel = viewModel ?? throw new ArgumentNullException(nameof(viewModel));
        }

        async Task IViewModelOwner<TViewModel>.InitializeViewModelAsync()
        {
            await ViewModel.InitializeAsync();
        }
    }

    public partial class TabBarController<TViewModel, TParameters> : TabBarController, INavigationView<TViewModel>, IViewModelOwner<TViewModel>
        where TViewModel : class, IViewModelWithParameters<TParameters>
        where TParameters : Parameters
    {
        private readonly TParameters _parameters;

        public TabBarController(TParameters parameters)
        {
            _parameters = parameters;
        }

        public event EventHandler<ResultSetEventArgs> ResultSet;

        public TViewModel ViewModel { get; private set; }

        protected override IViewLifecycleDelegate CreateLifecycleDelegate()
        {
            return new ViewLifecycleDelegate<TabBarController<TViewModel, TParameters>, TViewModel>(this);
        }

        public void SetResult(ResultCode resultCode)
        {
            LifecycleDelegate.SetResult(resultCode);
        }

        public void SetResult(ResultCode resultCode, Result result)
        {
            LifecycleDelegate.SetResult(resultCode, result);
        }

        public void RaiseResultSet(ResultCode resultCode, Result? result)
        {
            ResultSet?.Invoke(this, new ResultSetEventArgs(resultCode, result));
        }

        public void HandleResult(object sender, ResultSetEventArgs args)
        {
            if (sender == null)
                throw new ArgumentNullException(nameof(sender));
            if (args == null)
                throw new ArgumentNullException(nameof(args));

            LifecycleDelegate.HandleResult(sender, args);
        }

        void IViewModelOwner<TViewModel>.SetViewModel(TViewModel viewModel)
        {
            ViewModel = viewModel ?? throw new ArgumentNullException(nameof(viewModel));
        }

        async Task IViewModelOwner<TViewModel>.InitializeViewModelAsync()
        {
            await ViewModel.InitializeAsync(_parameters);
        }
    }
}

namespace FlexiMvvm.Views
{
    public partial class TableViewController : UIKit.UITableViewController, IIosView, IKeyboardHandlerOwner
    {
        private IViewLifecycleDelegate _lifecycleDelegate;
        private KeyboardHandler _keyboardHandler;

        protected IViewLifecycleDelegate LifecycleDelegate => _lifecycleDelegate ?? (_lifecycleDelegate = CreateLifecycleDelegate());

        public virtual bool HandleKeyboard { get; } = false;

        public KeyboardHandler KeyboardHandler => _keyboardHandler;

        protected virtual IViewLifecycleDelegate CreateLifecycleDelegate()
        {
            return new ViewLifecycleDelegate<TableViewController>(this);
        }

        public override void ViewDidLoad()
        {
            base.ViewDidLoad();

            LifecycleDelegate.ViewDidLoad();
        }

        public override void ViewWillAppear(bool animated)
        {
            base.ViewWillAppear(animated);

            LifecycleDelegate.ViewWillAppear();
        }

        public override void ViewWillDisappear(bool animated)
        {
            base.ViewWillDisappear(animated);

            LifecycleDelegate.ViewWillDisappear();
        }

        public override void ViewDidDisappear(bool animated)
        {
            base.ViewDidDisappear(animated);

            LifecycleDelegate.ViewDidDisappear();
        }

        void IKeyboardHandlerOwner.SetKeyboardHandler(KeyboardHandler handler)
        {
            _keyboardHandler = handler;
        }
    }

    public partial class TableViewController<TViewModel> : TableViewController, INavigationView<TViewModel>, IViewModelOwner<TViewModel>
        where TViewModel : class, IViewModelWithoutParameters
    {
        public event EventHandler<ResultSetEventArgs> ResultSet;

        public TViewModel ViewModel { get; private set; }

        protected override IViewLifecycleDelegate CreateLifecycleDelegate()
        {
            return new ViewLifecycleDelegate<TableViewController<TViewModel>, TViewModel>(this);
        }

        public void SetResult(ResultCode resultCode)
        {
            LifecycleDelegate.SetResult(resultCode);
        }

        public void SetResult(ResultCode resultCode, Result result)
        {
            LifecycleDelegate.SetResult(resultCode, result);
        }

        public void RaiseResultSet(ResultCode resultCode, Result? result)
        {
            ResultSet?.Invoke(this, new ResultSetEventArgs(resultCode, result));
        }

        public void HandleResult(object sender, ResultSetEventArgs args)
        {
            if (sender == null)
                throw new ArgumentNullException(nameof(sender));
            if (args == null)
                throw new ArgumentNullException(nameof(args));

            LifecycleDelegate.HandleResult(sender, args);
        }

        void IViewModelOwner<TViewModel>.SetViewModel(TViewModel viewModel)
        {
            ViewModel = viewModel ?? throw new ArgumentNullException(nameof(viewModel));
        }

        async Task IViewModelOwner<TViewModel>.InitializeViewModelAsync()
        {
            await ViewModel.InitializeAsync();
        }
    }

    public partial class TableViewController<TViewModel, TParameters> : TableViewController, INavigationView<TViewModel>, IViewModelOwner<TViewModel>
        where TViewModel : class, IViewModelWithParameters<TParameters>
        where TParameters : Parameters
    {
        private readonly TParameters _parameters;

        public TableViewController(TParameters parameters)
        {
            _parameters = parameters;
        }

        public event EventHandler<ResultSetEventArgs> ResultSet;

        public TViewModel ViewModel { get; private set; }

        protected override IViewLifecycleDelegate CreateLifecycleDelegate()
        {
            return new ViewLifecycleDelegate<TableViewController<TViewModel, TParameters>, TViewModel>(this);
        }

        public void SetResult(ResultCode resultCode)
        {
            LifecycleDelegate.SetResult(resultCode);
        }

        public void SetResult(ResultCode resultCode, Result result)
        {
            LifecycleDelegate.SetResult(resultCode, result);
        }

        public void RaiseResultSet(ResultCode resultCode, Result? result)
        {
            ResultSet?.Invoke(this, new ResultSetEventArgs(resultCode, result));
        }

        public void HandleResult(object sender, ResultSetEventArgs args)
        {
            if (sender == null)
                throw new ArgumentNullException(nameof(sender));
            if (args == null)
                throw new ArgumentNullException(nameof(args));

            LifecycleDelegate.HandleResult(sender, args);
        }

        void IViewModelOwner<TViewModel>.SetViewModel(TViewModel viewModel)
        {
            ViewModel = viewModel ?? throw new ArgumentNullException(nameof(viewModel));
        }

        async Task IViewModelOwner<TViewModel>.InitializeViewModelAsync()
        {
            await ViewModel.InitializeAsync(_parameters);
        }
    }
}

namespace FlexiMvvm.Views
{
    public partial class ViewController : UIKit.UIViewController, IIosView, IKeyboardHandlerOwner
    {
        private IViewLifecycleDelegate _lifecycleDelegate;
        private KeyboardHandler _keyboardHandler;

        protected IViewLifecycleDelegate LifecycleDelegate => _lifecycleDelegate ?? (_lifecycleDelegate = CreateLifecycleDelegate());

        public virtual bool HandleKeyboard { get; } = true;

        public KeyboardHandler KeyboardHandler => _keyboardHandler;

        protected virtual IViewLifecycleDelegate CreateLifecycleDelegate()
        {
            return new ViewLifecycleDelegate<ViewController>(this);
        }

        public override void ViewDidLoad()
        {
            base.ViewDidLoad();

            LifecycleDelegate.ViewDidLoad();
        }

        public override void ViewWillAppear(bool animated)
        {
            base.ViewWillAppear(animated);

            LifecycleDelegate.ViewWillAppear();
        }

        public override void ViewWillDisappear(bool animated)
        {
            base.ViewWillDisappear(animated);

            LifecycleDelegate.ViewWillDisappear();
        }

        public override void ViewDidDisappear(bool animated)
        {
            base.ViewDidDisappear(animated);

            LifecycleDelegate.ViewDidDisappear();
        }

        void IKeyboardHandlerOwner.SetKeyboardHandler(KeyboardHandler handler)
        {
            _keyboardHandler = handler;
        }
    }

    public partial class ViewController<TViewModel> : ViewController, INavigationView<TViewModel>, IViewModelOwner<TViewModel>
        where TViewModel : class, IViewModelWithoutParameters
    {
        public event EventHandler<ResultSetEventArgs> ResultSet;

        public TViewModel ViewModel { get; private set; }

        protected override IViewLifecycleDelegate CreateLifecycleDelegate()
        {
            return new ViewLifecycleDelegate<ViewController<TViewModel>, TViewModel>(this);
        }

        public void SetResult(ResultCode resultCode)
        {
            LifecycleDelegate.SetResult(resultCode);
        }

        public void SetResult(ResultCode resultCode, Result result)
        {
            LifecycleDelegate.SetResult(resultCode, result);
        }

        public void RaiseResultSet(ResultCode resultCode, Result? result)
        {
            ResultSet?.Invoke(this, new ResultSetEventArgs(resultCode, result));
        }

        public void HandleResult(object sender, ResultSetEventArgs args)
        {
            if (sender == null)
                throw new ArgumentNullException(nameof(sender));
            if (args == null)
                throw new ArgumentNullException(nameof(args));

            LifecycleDelegate.HandleResult(sender, args);
        }

        void IViewModelOwner<TViewModel>.SetViewModel(TViewModel viewModel)
        {
            ViewModel = viewModel ?? throw new ArgumentNullException(nameof(viewModel));
        }

        async Task IViewModelOwner<TViewModel>.InitializeViewModelAsync()
        {
            await ViewModel.InitializeAsync();
        }
    }

    public partial class ViewController<TViewModel, TParameters> : ViewController, INavigationView<TViewModel>, IViewModelOwner<TViewModel>
        where TViewModel : class, IViewModelWithParameters<TParameters>
        where TParameters : Parameters
    {
        private readonly TParameters _parameters;

        public ViewController(TParameters parameters)
        {
            _parameters = parameters;
        }

        public event EventHandler<ResultSetEventArgs> ResultSet;

        public TViewModel ViewModel { get; private set; }

        protected override IViewLifecycleDelegate CreateLifecycleDelegate()
        {
            return new ViewLifecycleDelegate<ViewController<TViewModel, TParameters>, TViewModel>(this);
        }

        public void SetResult(ResultCode resultCode)
        {
            LifecycleDelegate.SetResult(resultCode);
        }

        public void SetResult(ResultCode resultCode, Result result)
        {
            LifecycleDelegate.SetResult(resultCode, result);
        }

        public void RaiseResultSet(ResultCode resultCode, Result? result)
        {
            ResultSet?.Invoke(this, new ResultSetEventArgs(resultCode, result));
        }

        public void HandleResult(object sender, ResultSetEventArgs args)
        {
            if (sender == null)
                throw new ArgumentNullException(nameof(sender));
            if (args == null)
                throw new ArgumentNullException(nameof(args));

            LifecycleDelegate.HandleResult(sender, args);
        }

        void IViewModelOwner<TViewModel>.SetViewModel(TViewModel viewModel)
        {
            ViewModel = viewModel ?? throw new ArgumentNullException(nameof(viewModel));
        }

        async Task IViewModelOwner<TViewModel>.InitializeViewModelAsync()
        {
            await ViewModel.InitializeAsync(_parameters);
        }
    }
}

