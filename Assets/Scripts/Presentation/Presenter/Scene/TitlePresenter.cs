using System;
using CAFU.Core;
using UniRx;
using Zenject;

namespace Fakestarbaby.SampleCafu.Presentation.Presenter.Scene
{
    public class TitlePresenter :
        IInitializable,
        IDisposable,
        IPresenter
    {
        private CompositeDisposable Disposable { get; } = new CompositeDisposable();

        void IInitializable.Initialize()
        {
        }

        void IDisposable.Dispose() => Disposable?.Dispose();
    }
}