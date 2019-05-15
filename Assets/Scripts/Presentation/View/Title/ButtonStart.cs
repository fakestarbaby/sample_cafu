using System;
using PretendLand.Suntory.Presentation.Presenter.Interface;
using UniRx;
using UniRx.Triggers;
using UnityEngine.EventSystems;

namespace Fakestarbaby.SampleCafu.Presentation.View.Title
{
    public class ButtonStart :
        UIBehaviour,
        IEventDispatcher
    {
        IObservable<Unit> IEventDispatcher.DispatchEventAsObservable() =>
            this.OnPointerDownAsObservable().AsUnitObservable();
    }
}