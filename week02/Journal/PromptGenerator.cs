public class PromptGenerator
{
    private List<string> _prompts = new List<string>
    {
        "What are you grateful for today?",
        "Describe a challenge you faced today.",
        "Write about your lunch time experience.",
        "What is a goal you want to achieve tomorrow?",
        "Reflect on an accomplishment that you achieved today and how it made you feel."
    };

    public string GetRandomPrompt()
    {
        Random random = new Random();
        int index = random.Next(_prompts.Count);
        return _prompts[index];
    }
}