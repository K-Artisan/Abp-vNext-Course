import { eLayoutType, RoutesService } from '@abp/ng.core';
import { eThemeSharedRouteNames } from '@abp/ng.theme.shared';
import { APP_INITIALIZER } from '@angular/core';
import { eProductRouteNames } from '../enums/route-names';

export const PRODUCT_ROUTE_PROVIDERS = [
  {
    provide: APP_INITIALIZER,
    useFactory: configureRoutes,
    deps: [RoutesService],
    multi: true,
  },
];

export function configureRoutes(routes: RoutesService) {
  return () => {
    routes.add([
      {
        path: '/product',
        name: eProductRouteNames.Product,
        iconClass: 'fas fa-book',
        layout: eLayoutType.application,
        order: 3,
      },
    ]);
  };
}
