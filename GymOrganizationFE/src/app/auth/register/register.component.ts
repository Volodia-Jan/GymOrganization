import {Component, OnInit} from '@angular/core';
import {CommonModule} from '@angular/common';
import {MatButtonModule} from "@angular/material/button";
import {MatFormFieldModule} from "@angular/material/form-field";
import {MatInputModule} from "@angular/material/input";
import {RouterLink} from "@angular/router";
import {MatDatepickerModule} from "@angular/material/datepicker";
import {MatIconModule} from "@angular/material/icon";
import {MatNativeDateModule} from "@angular/material/core";
import {FormsModule} from "@angular/forms";
import {RegisterRequest} from "../../_requests/register-request";
import {AuthorizationService} from "../../_services/authorization.service";
import {HttpClientModule} from "@angular/common/http";

@Component({
  selector: 'app-register',
  standalone: true,
  imports: [CommonModule, MatButtonModule, MatFormFieldModule, MatInputModule, RouterLink, MatDatepickerModule,
    MatNativeDateModule, MatIconModule, FormsModule, HttpClientModule],
  templateUrl: './register.component.html',
  styleUrls: ['./register.component.css', '../auth.component.css']
})
export class RegisterComponent implements OnInit{
  model: RegisterRequest;

  constructor(private authService: AuthorizationService) {
    this.model = {
      firstName: '',
      lastName: '',
      email: '',
      dateOfBirth: Date(),
      password: '',
      confirmPassword: ''
    }
  }
  ngOnInit(): void {
  }

  register() {
    this.authService.register(this.model).subscribe({
      next: (response) => {
        console.log(response);
      },
    });
  }
}
