using System;
using CAFU.Core;
using PretendLand.Suntory.Domain.UseCase.Interface;
using UniRx;
using UnityEngine;
using Zenject;

namespace Fakestarbaby.SampleCafu.Domain.UseCase.Scene
{
    public interface ITitleUseCase : IUseCase
    {
    }

    public class TitleUseCase :
        IInitializable,
        IDisposable,
        ITitleUseCase
    {
        [Inject] private ITitleNavigator TitleNavigator { get; set; }

        private CompositeDisposable Disposable { get; } = new CompositeDisposable();

        void IInitializable.Initialize()
        {
            TitleNavigator
                .NavigateGameSceneAsObservable()
                .Subscribe(_ => NavigateGameScene())
                .AddTo(Disposable);
        }

        void IDisposable.Dispose() => Disposable?.Dispose();

        private void NavigateGameScene()
        {
            Debug.Log("Navigate game scene.");
        }
    }
}