using TegridyCore.Base;
using Zenject;

namespace Game.Installers
{
    public class ViewsInstaller : MonoInstaller
    {
        public override void InstallBindings()
        {
            InstallViews();
        }

        private void InstallViews()
        {
            var views= FindObjectsOfType<ViewBase>(true);

            foreach (var view in views)
            {
                var binding = Container.Bind(view.GetType()).FromInstance(view);

                if (view.AsTransient)
                {
                    binding.AsTransient();
                }
                else
                {
                    binding.AsSingle();
                }
            }
        }
    }
}