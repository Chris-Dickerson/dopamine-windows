using CommonServiceLocator;
using Dopamine.Services.Playback;
using Dopamine.Services.Playback;

namespace Dopamine.ViewModels.Common
{
    public class ProgressControlsThinViewModel : ProgressControlsViewModel
    {
        public ProgressControlsThinViewModel() : base(ServiceLocator.Current.GetInstance<IPlaybackService>())
        {
        }
    }
}