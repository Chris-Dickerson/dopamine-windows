using CommonServiceLocator;
using Dopamine.Services.Playback;
using Dopamine.ViewModels;
using Prism.Events;

namespace Dopamine.ViewModels.Common
{
    public class CompactPlaybackControlsViewModel : PlaybackControlsViewModel
    {
        public CompactPlaybackControlsViewModel() : base(ServiceLocator.Current.GetInstance<IPlaybackService>(), ServiceLocator.Current.GetInstance<IEventAggregator>())
        {
        }
    }
}
