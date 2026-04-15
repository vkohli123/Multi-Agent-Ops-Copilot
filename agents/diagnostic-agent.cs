using System.Threading.Tasks;

namespace AgenticAIOps.Agents
{
    public class DiagnosticAgent
    {
        public Task<string> AnalyzeAsync(string alert)
        {
            // Simulated reasoning
            var result = $"Root cause analysis for alert: {alert} → Possible CPU spike or memory leak";
            return Task.FromResult(result);
        }
    }
}