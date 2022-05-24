// This file can be replaced during build by using the `fileReplacements` array.
// `ng build --prod` replaces `environment.ts` with `environment.prod.ts`.
// The list of file replacements can be found in `angular.json`.

const currentEnvironment = 'dev';
const serverUrl = `https://localhost:5002`;
const clientUrl = 'http://localhost:4200';

export const environment = {
  production: false,
  currentEnvironment: currentEnvironment,
  clientUrl: clientUrl,
  clientRoot: clientUrl,
  clientId: 'AngularClient',
  clientScope: ['profile', 'openid', 'angular', 'offline_access'].join(' '),
  aggregatorUrl: `${serverUrl}/api/v1/`,
  apiUrl: 'http://localhost:40274/api/',
  idsUrl: 'https://conecta-development.northeurope.cloudapp.azure.com/api/v1/',
  ivcertUrl: 'https://demo.ivcert.net/login?returnUrl=%2Fcircuits%2Fnew',
  stsAuthority: `${serverUrl}`,
  configuration: {
    formats: {
      angularDate: 'dd/MM/yyyy',
      angularFriendlyDate: 'dd MMMM yyyy',
      momentDate: 'DD-MMM-YY',
      angularDateAndTime: 'dd/MM/yy HH:mm',
      momentDateAndTime: 'DD-MMM-YY HH:mm',
      serverDateAndTime: 'YYYY/MM/DD HH:mm',
      serverDate: 'YYYY/MM/DD',
    },
    files: {
      acceptedTypes:
        '.pdf,.doc,.docx,application/msword,application/vnd.openxmlformats-officedocument.wordprocessingml.document',
      maxSize: 4e6,
    },
  },
  profile: {
    languange: 'es',
    theme: 'dynamic',
  },
};
