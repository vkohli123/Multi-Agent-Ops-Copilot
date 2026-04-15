using System.Threading.Tasks;
using AgenticAIOps.Agents;

namespace AgenticAIOps.Services
{
    public class AlertProcessor
    {
        private readonly Orchestrator _orchestrator;

        public AlertProcessor()
        {
            _orchestrator = new Orchestrator();
        }

        public async Task ProcessAsync(string alert)
        {
            await _orchestrator.HandleAlertAsync(alert);
        }
    }
}