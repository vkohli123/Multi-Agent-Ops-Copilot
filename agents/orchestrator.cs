using System;
using System.Threading.Tasks;
using AgenticAIOps.Services;

namespace AgenticAIOps.Agents
{
    public class Orchestrator
    {
        private readonly DiagnosticAgent _diagnostic;
        private readonly SummarizerAgent _summarizer;

        public Orchestrator()
        {
            _diagnostic = new DiagnosticAgent();
            _summarizer = new SummarizerAgent();
        }

        public async Task HandleAlertAsync(string alert)
        {
            Console.WriteLine($"[Orchestrator] Received alert: {alert}");

            var diagnosis = await _diagnostic.AnalyzeAsync(alert);
            var summary = await _summarizer.SummarizeAsync(diagnosis);

            Console.WriteLine($"[Final Summary]: {summary}");
        }
    }
}