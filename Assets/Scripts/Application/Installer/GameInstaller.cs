using Fakestarbaby.SampleCafu.Domain.UseCase.Scene;
using Fakestarbaby.SampleCafu.Presentation.Presenter.Scene;
using Zenject;

namespace Fakestarbaby.SampleCafu.Application.Installer
{
    public class GameInstaller : MonoInstaller<GameInstaller>
    {
        public override void InstallBindings()
        {
            // UseCase
            Container.BindInterfacesTo<GameUseCase>().AsCached();

            // Presenter
            Container.BindInterfacesTo<GamePresenter>().AsCached();
        }
    }
}