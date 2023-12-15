import {ApplicationConfig} from '@angular/core';
import {provideRouter} from '@angular/router';

import {routes} from './app.routes';
import {provideAnimations} from '@angular/platform-browser/animations';
import {provideToastr, ToastrService} from "ngx-toastr";
import {provideHttpClient} from "@angular/common/http";
import {AuthorizationService} from "./_services/authorization.service";

export const appConfig: ApplicationConfig = {
  providers: [provideToastr(), provideRouter(routes), provideAnimations(), provideHttpClient()]
};
