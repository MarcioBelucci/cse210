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

    private List<string> _usedPrompts = new List<string>();

    public string GetRandomPrompt()
    {
        if (_prompts.Count == 0)
        {
            _prompts.AddRange(_usedPrompts);
            _usedPrompts.Clear();
        }
        
        Random random = new Random();
        int index = random.Next(_prompts.Count);
        string prompt = _prompts[index];

        _usedPrompts.Add(prompt);
        _prompts.RemoveAt(index);

        return prompt;
    }

}