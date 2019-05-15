using System;
using CAFU.Core;
using UniRx;

namespace PretendLand.Suntory.Presentation.Presenter.Interface
{
    public interface IEventDispatcher : IView
    {
        IObservable<Unit> DispatchEventAsObservable();
    }
}