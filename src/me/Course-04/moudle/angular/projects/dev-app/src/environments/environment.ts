import { Config } from '@abp/ng.core';

export const environment = {
  production: false,
  application: {
    baseUrl: 'http://localhost:4200/',
    name: 'Product',
    logoUrl: '',
  },
  oAuthConfig: {
    issuer: 'https://localhost:44363',
    clientId: 'Product_ConsoleTestApp',
    dummyClientSecret: '1q2w3e*',
    scope: 'Product',
    oidc: false,
    requireHttps: true,
  },
  apis: {
    default: {
      url: 'https://localhost:44363',
      rootNamespace: 'Zo.Abp.Course.Product',
    },
    Product: {
      url: 'https://localhost:44327',
      rootNamespace: 'Zo.Abp.Course.Product',
    },
  },
} as Config.Environment;
