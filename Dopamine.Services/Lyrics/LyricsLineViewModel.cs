using Prism.Mvvm;
using System;

namespace Dopamine.Services.Lyrics
{
    public class LyricsLineViewModel : BindableBase
    {
        private TimeSpan time;
        private string text;
        private bool isTimed;
        private bool isHighlighted;

        public TimeSpan Time => this.time;

        public string Text => this.text;

        public bool IsTimed => this.isTimed;

        public bool IsHighlighted
        {
            get => this.isTimed & this.isHighlighted;
            set => SetProperty<bool>(ref this.isHighlighted, value);
        }

        public LyricsLineViewModel(TimeSpan time, string text)
        {
            this.time = time;
            this.text = text;

            this.isTimed = true;
        }

        public LyricsLineViewModel(string text)
        {
            this.time = TimeSpan.Zero;
            this.text = text;

            this.isTimed = false;
        }
    }
}