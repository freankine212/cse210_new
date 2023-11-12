using System.Text;
using System.IO;
using System;
using System.Collections.Generic;

public class PromptGenerator
{
    public List<string> _prompts;
    
        public static string[] _prompt ={
            "How was your day today?",
            "Did you help someone have a good day today?",
            "Play any good games today?",
            "What was the scripture that impacted your day most?",
            "How did your family help you out today?"
        };
        
        public PromptGenerator()
        {
            
        }

        public void Display()
        {
            var random = new Random();
            int index = random.Next(_prompts.Count);
            string promptGenerator = _prompts[index];
            Console.WriteLine($"\n{_prompts}");
        }
        //this should pull to the program.cs file  
        public string GetPrompt(string _prompt)
        {
            var random = new Random();
            int index = random.Next(_prompts.Count);
            string promptGenerator = _prompts[index];

            return _prompt;
        }
}

