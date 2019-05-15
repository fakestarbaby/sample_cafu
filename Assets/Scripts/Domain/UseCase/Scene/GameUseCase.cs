using System;
using CAFU.Core;
using UniRx;
using Zenject;

namespace Fakestarbaby.SampleCafu.Domain.UseCase.Scene
{
    public interface IGameUseCase : IUseCase
    {
    }

    public class GameUseCase :
        IInitializable,
        IDisposable,
        IGameUseCase
    {
        private CompositeDisposable Disposable { get; } = new CompositeDisposable();

        void IInitializable.Initialize()
        {
        }

        void IDisposable.Dispose() => Disposable?.Dispose();
    }
}