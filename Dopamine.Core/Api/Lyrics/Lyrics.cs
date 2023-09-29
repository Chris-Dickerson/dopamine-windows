namespace Dopamine.Core.Api.Lyrics
{
    public enum SourceTypeEnum
    {
        Audio,
        Lrc,
        Online
    }

    public class Lyrics
    {
        private string text;
        private string source;

        public string Text
        {
            get => this.text;
            set => this.text = value;
        }

        public string Source => this.source;

        public bool HasText => !string.IsNullOrWhiteSpace(this.Text);

        public bool HasSource => !string.IsNullOrWhiteSpace(this.source);

        public SourceTypeEnum SourceType { get; set; }

        public Lyrics()
        {
            this.text = string.Empty;
            this.source = string.Empty;
        }

        public Lyrics(string text, string source)
        {
            this.text = text;
            this.source = source;
        }

        public Lyrics(string text, string source, SourceTypeEnum sourceType) : this(text, source)
        {
            this.SourceType = sourceType;
        }

        public Lyrics Clone()
        {
            return new Lyrics(this.text, this.Source, this.SourceType);
        }
    }
}
