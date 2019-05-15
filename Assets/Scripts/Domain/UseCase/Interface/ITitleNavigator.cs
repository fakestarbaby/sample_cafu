using System;
using CAFU.Core;
using UniRx;

namespace PretendLand.Suntory.Domain.UseCase.Interface
{
    public interface ITitleNavigator : IPresenter
    {
        IObservable<Unit> NavigateGameSceneAsObservable();
    }
}