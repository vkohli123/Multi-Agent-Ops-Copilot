using System.Threading.Tasks;

namespace AgenticAIOps.Agents
{
    public class SummarizerAgent
    {
        public Task<string> SummarizeAsync(string diagnosis)
        {
            var summary = $"Summary: {diagnosis}. Suggested action: Restart service / scale resources.";
            return Task.FromResult(summary);
        }
    }
}