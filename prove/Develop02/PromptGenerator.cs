using System;
using System.IO;
public class PromptGenerator {
public List<string> Prompts;

    public PromptGenerator(){
        Prompts = new List<string>{
            "Who was the most interesting person I interacted with today?",
            "What was the best part of my day?",
            "How did I see the hand of the Lord in my life today?",
            "What was the strongest emotion I felt today?",
            "If I had one thing I could do over today, what would it be?",
            "What did you learn today?",
            "What would you do another way that you have done today?",
            "Have you spen enough time with you children today? What did you do with them?"

        };
    }
    public string GenerateRandomPrompt(){
        Random random = new Random();
        int index = random.Next(Prompts.Count);
        return Prompts[index];

    }
}