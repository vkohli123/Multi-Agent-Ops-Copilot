# 🚀 Agentic AIOps Copilot

Production-style multi-agent system for automated incident triage and diagnostics using **.NET 8**, **Semantic Kernel concepts**, and **Azure-native architecture**.

---

## 🧠 Overview

Agentic AIOps Copilot is a multi-agent orchestration system that processes infrastructure alerts, performs root-cause analysis, and generates actionable remediation steps.

Inspired by Azure Agentic AIOps architecture, this project demonstrates how **AI agents can automate DevOps workflows**, reduce manual debugging, and improve system reliability.

---

## ⚙️ Key Features

* 🧩 Multi-agent orchestration (Orchestrator, Diagnostic, Summarizer)
* 🔍 Automated incident triage from alert signals
* 📊 Telemetry-driven reasoning (CPU, memory, failure patterns)
* 🔐 Designed with RBAC-style guardrails (extensible)
* ⚡ Lightweight, extensible, and production-inspired design

---

## 🏗️ Architecture

```
Alert → Orchestrator Agent → Diagnostic Agent → Summarizer Agent → Actionable Insight
```

### Agents

* **Orchestrator Agent**

  * Entry point for alert processing
  * Coordinates agent workflow

* **Diagnostic Agent**

  * Performs root cause analysis
  * Simulates system reasoning based on telemetry

* **Summarizer Agent**

  * Converts diagnosis into human-readable insights
  * Suggests remediation actions

---

## 📁 Project Structure

```
Agentic-aiops-copilot/
│
├── agents/
│   ├── orchestrator.cs
│   ├── diagnostic-agent.cs
│   └── summarizer-agent.cs
│
├── services/
│   ├── telemetry-service.cs
│   └── alert-processor.cs
│
├── Program.cs
└── README.md
```

---

## Azure Architecture

Components deployed in AKS
Webhook: service that publishes the webhook endpoint to receive the alert from Azure Monitor.
mas: Multi-Agent System responsible to implement the webhook to receive the Azure Monitor alert and implement the Semantic Kernel (kernel, magentic orchestration, agents and tools).
Service Account: this service account is used in the workload identity model. This service account is federated to a managed identity that could have permissions in the monitored resource, allowing for instance to execute commands like kubeclt, query azure monitor logs, etc. It allows the agents to use the Azure RBAC as a guardrail for the agents.


## 🔄 Workflow

1. Alert is received (simulated or via API)
2. Orchestrator triggers diagnostic pipeline
3. Diagnostic agent analyzes system state
4. Summarizer generates actionable output
5. Final response is returned/logged

---

## ▶️ Getting Started

### Prerequisites

* .NET 8 SDK
* Visual Studio / VS Code

---

### Run Locally

```bash
dotnet run
```

---

### Sample Output

```
[Orchestrator] Received alert: High CPU usage detected in production
[Final Summary]: Summary: Root cause analysis for alert → Possible CPU spike or memory leak.
Suggested action: Restart service / scale resources.
```

---

## 🔐 Security Considerations

* Designed to integrate with Azure RBAC (future extension)
* Sensitive configs should be stored in environment variables
* Can be extended with Azure Key Vault integration

---

## ☁️ Azure Integration (Planned / Extensible)

* Azure OpenAI (LLM-based reasoning)
* Azure Monitor (real alert ingestion)
* AKS (agent deployment)
* Managed Identity + Workload Identity
* Azure Key Vault (secrets management)

---

## 🚀 Future Enhancements

* Semantic Kernel integration for planner-executor agents
* Real-time alert ingestion via webhook
* Tool-calling agents (kubectl, logs, metrics)
* Multi-agent collaboration strategies
* Observability dashboards

---

## 💡 Inspiration

This project is inspired by modern **Agentic AIOps systems** and Azure-native architectures for autonomous incident management.

---

## 🧑‍💻 Author

Vedant Kohli

---

## 📄 License

MIT License
