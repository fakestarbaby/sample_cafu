using System;
using CAFU.Core;
using UniRx;
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
        private CompositeDisposable Disposable { get; } = new CompositeDisposable();

        void IInitializable.Initialize()
        {
        }

        void IDisposable.Dispose() => Disposable?.Dispose();
    }
}