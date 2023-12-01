import {Routes} from '@angular/router';
import {AuthComponent} from "./auth/auth.component";
import {LoginComponent} from "./auth/login/login.component";
import {RegisterComponent} from "./auth/register/register.component";
import {HomeComponent} from "./home/home.component";
import {CatalogComponent} from "./catalog/catalog.component";
import {ProfileComponent} from "./profile/profile.component";

export const routes: Routes = [
  {path: '', component: HomeComponent},
  {
    path: 'auth', children: [
      {path: 'login', component: LoginComponent},
      {path: 'register', component: RegisterComponent}
    ]
  },
  {path: 'catalog', component: CatalogComponent},
  {path: 'profile', component: ProfileComponent}
];
