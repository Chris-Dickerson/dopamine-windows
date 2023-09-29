using CommonServiceLocator;
using Dopamine.Services.Playback;
using Dopamine.ViewModels;

namespace Dopamine.ViewModels.Common
{
    public class HorizontalVolumeControlsViewModel : VolumeControlsViewModel
    {
        public HorizontalVolumeControlsViewModel() : base(ServiceLocator.Current.GetInstance<IPlaybackService>())
        {
        }
    }
}