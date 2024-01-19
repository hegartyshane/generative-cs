using System.Diagnostics.CodeAnalysis;

namespace ChatAIze.GenerativeCS.Options.OpenAI;

public record OpenAIClientOptions
{
    public OpenAIClientOptions() { }

    [SetsRequiredMembers]
    public OpenAIClientOptions(string apiKey)
    {
        ApiKey = apiKey;
    }

    public required string ApiKey { get; set; }

    public ChatCompletionOptions DefaultCompletionOptions { get; set; } = new();

    public EmbeddingOptions DefaultEmbeddingOptions { get; set; } = new();

    public TextToSpeechOptions DefaultTextToSpeechOptions { get; set; } = new();

    public TranscriptionOptions DefaultTranscriptionOptions { get; set; } = new();

    public TranslationOptions DefaultTranslationOptions { get; set; } = new();

    public ModerationOptions DefaultModerationOptions { get; set; } = new();
}
