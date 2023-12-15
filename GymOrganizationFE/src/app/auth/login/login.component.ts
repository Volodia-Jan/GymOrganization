import {Component} from '@angular/core';
import {CommonModule} from '@angular/common';
import {MatInputModule} from "@angular/material/input";
import {MatButtonModule} from "@angular/material/button";
import {Router, RouterLink} from "@angular/router";
import {AuthorizationService} from "../../_services/authorization.service";
import {LoginRequest} from "../../_requests/login-request";
import {FormsModule} from "@angular/forms";
import {HttpClientModule} from "@angular/common/http";

@Component({
  selector: 'app-login',
  standalone: true,
  imports: [CommonModule, MatInputModule, MatButtonModule, RouterLink, FormsModule, HttpClientModule],
  templateUrl: './login.component.html',
  styleUrls: ['./login.component.css', '../auth.component.css']
})
export class LoginComponent {
  model: LoginRequest;

  constructor(
    public authorizationService: AuthorizationService,
    private router: Router,
  ) {
    this.model = {
      login: '',
      password: ''
    }
  }

  login() {
    this.authorizationService.login(this.model).subscribe({
      next: () => this.router.navigateByUrl('/'),
    });
  }

  logout() {
    this.authorizationService.logout();
    this.router.navigateByUrl('/');
  }
}
