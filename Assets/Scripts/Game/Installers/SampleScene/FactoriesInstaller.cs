using Game.Gameplay.Factories;
using Game.Gameplay.Models;
using Zenject;

namespace Game.Installers.SampleScene
{
    public class FactoriesInstaller : MonoInstaller
    {
        public override void InstallBindings()
        {
            Container.Bind<ApplicationData>().FromFactory<ApplicationDataFactory>().AsSingle();
        }
    }
}