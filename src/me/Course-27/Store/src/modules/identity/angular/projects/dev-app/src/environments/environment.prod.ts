import { Environment } from '@abp/ng.core';

const baseUrl = 'http://localhost:4200';

export const environment = {
  production: true,
  application: {
    baseUrl: 'http://localhost:4200/',
    name: 'Identity',
    logoUrl: '',
  },
  oAuthConfig: {
    issuer: 'https://localhost:44396',
    redirectUri: baseUrl,
    clientId: 'Identity_App',
    responseType: 'code',
    scope: 'offline_access Identity',
  },
  apis: {
    default: {
      url: 'https://localhost:44396',
      rootNamespace: 'Zo.Store.Identity',
    },
    Identity: {
      url: 'https://localhost:44310',
      rootNamespace: 'Zo.Store.Identity',
    },
  },
} as Environment;
