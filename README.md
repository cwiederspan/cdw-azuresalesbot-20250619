# Azure Sales Bot

This project uses the Azure Realtime API and a custom prompt to have an interactive voice conversation with the user via a web page. 
It also uses the Azure Developer CLI (azd) to create and deploy the resources into an Azure Container App that then talks to the 
Azure OpenAI resource with a managed identity.

```bash

az login -t $TENANT_ID

# Setup the AZD configuration
azd init

# Add the Azure AI Service service
azd add

# Provision and deploy the application
azd up

```
