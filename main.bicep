param location string = 'polandcentral'
param webAppName string = 'recruitment-api-sandra'

resource appServicePlan 'Microsoft.Web/serverfarms@2022-03-01' = {
  name: 'plan-recruitment'
  location: location
  sku: {
    name: 'S1'
  }
  kind: 'linux'
  properties: {
    reserved: true
  }
}

resource webApp 'Microsoft.Web/sites@2022-03-01' = {
  name: webAppName
  location: location
  properties: {
    serverFarmId: appServicePlan.id       
    siteConfig: {
      linuxFxVersion: 'DOTNETCORE|8.0'
    }
  }
}