using System;
using Fakestarbaby.SampleCafu.Application;
using PretendLand.Suntory.Domain.UseCase.Interface;
using PretendLand.Suntory.Presentation.Presenter.Interface;
using UniRx;
using Zenject;

namespace Fakestarbaby.SampleCafu.Presentation.Presenter.Scene
{
    public class TitlePresenter :
        IInitializable,
        IDisposable,
        ITitleNavigator
    {
        [Inject(Id = Const.InjectId.Title.BUTTON_START)]
        private IEventDispatcher ButtonStart { get; set; }

        private CompositeDisposable Disposable { get; } = new CompositeDisposable();

        void IInitializable.Initialize()
        {
        }

        void IDisposable.Dispose() => Disposable?.Dispose();

        IObservable<Unit> ITitleNavigator.NavigateGameSceneAsObservable() =>
            ButtonStart.DispatchEventAsObservable().AsUnitObservable();
    }
}