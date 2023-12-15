import {CanActivateFn, RouterStateSnapshot, ActivatedRouteSnapshot, Router} from '@angular/router';
import {Observable} from 'rxjs';
import {map} from 'rxjs/operators';
import {AuthorizationService} from "../_services/authorization.service";
import {ToastrService} from "ngx-toastr";
import { inject } from '@angular/core';

export const authGuard: CanActivateFn = (
  route: ActivatedRouteSnapshot,
  state: RouterStateSnapshot
): Observable<boolean> | Promise<boolean> | boolean => {
  let router = inject(Router);
  return inject(AuthorizationService).currentUser$.pipe(
    map(user => {
      if (user) {
        return true;
      } else {
        router.navigateByUrl("/auth/login")
        return false;
      }
    })
  );
};
