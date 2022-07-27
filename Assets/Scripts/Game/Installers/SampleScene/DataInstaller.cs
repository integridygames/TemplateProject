using Game.Gameplay.Models.SampleScene;
using Zenject;

namespace Game.Installers.SampleScene
{
    public class DataInstaller : MonoInstaller
    {
        public override void InstallBindings()
        {
            Container.Bind<DayTime>().AsSingle();
        }
    }
}