using CommonServiceLocator;
using Dopamine.Services.Playback;
using Dopamine.ViewModels;

namespace Dopamine.ViewModels.Common
{
    public class PopupVolumeControlsViewModel : VolumeControlsViewModel
    {
        public PopupVolumeControlsViewModel() : base(ServiceLocator.Current.GetInstance<IPlaybackService>())
        {
        }
    }
}
