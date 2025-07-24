# SKChatConsoleDemo

A simple console application demonstrating how to use Microsoft Semantic Kernel with Azure OpenAI for interactive chat functionality.

## Overview

This project showcases:
- Integration with Azure OpenAI using Semantic Kernel
- Environment-based configuration management
- Interactive console chat interface
- Best practices for configuration and environment setup

## Prerequisites

- .NET 8.0 SDK
- Visual Studio 2022 or Visual Studio Code
- Azure OpenAI resource with a deployed model
- Azure OpenAI API key and endpoint


## Dependencies

- **Microsoft.SemanticKernel** (v1.60.0) - Core Semantic Kernel functionality
- **Microsoft.Extensions.Configuration** (v9.0.7) - Configuration framework
- **Microsoft.Extensions.Configuration.Json** (v9.0.7) - JSON configuration provider
- **Microsoft.Extensions.Configuration.EnvironmentVariables** (v9.0.7) - Environment variables support

## Setup Instructions

### 1. Clone and Build

### 2. Configure Azure OpenAI

Update the `appsettings.json` file with your Azure OpenAI details:


## Usage

### Running the Application

The application will:
1. Display the current environment
2. Prompt you to ask a question
3. Send your question to Azure OpenAI via Semantic Kernel
4. Display the AI response

### Example Interaction

- Running in Development environment 
- Ask me anything – I'm all ears!................? 
- What is the capital of France? 
- The capital of France is Paris. It's the largest city in France and serves as the country's political, economic, and cultural center.


## Related Resources

- [Semantic Kernel Documentation](https://learn.microsoft.com/en-us/semantic-kernel/)
- [.NET Configuration](https://docs.microsoft.com/en-us/dotnet/core/extensions/configuration)