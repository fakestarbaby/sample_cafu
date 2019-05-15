using Fakestarbaby.SampleCafu.Domain.UseCase.Scene;
using Fakestarbaby.SampleCafu.Presentation.Presenter.Scene;
using Zenject;

namespace Fakestarbaby.SampleCafu.Application.Installer
{
    public class TitleInstaller : MonoInstaller<TitleInstaller>
    {
        public override void InstallBindings()
        {
            // UseCase
            Container.BindInterfacesTo<TitleUseCase>().AsCached();

            // Presenter
            Container.BindInterfacesTo<TitlePresenter>().AsCached();
        }
    }
}