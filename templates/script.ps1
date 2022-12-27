az group create `
    --location francecentral `
    --name razordemo


az deployment group create `
    --resource-group razordemo `
    --template-file 'templates\template.json' `
    --parameters 'templates\parameters.json'