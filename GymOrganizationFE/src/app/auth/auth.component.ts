import { Component } from '@angular/core';
import { CommonModule } from '@angular/common';
import {MatTabsModule} from "@angular/material/tabs";
import {LoginComponent} from "./login/login.component";
import {RegisterComponent} from "./register/register.component";

@Component({
  selector: 'app-auth',
  standalone: true,
  imports: [CommonModule, MatTabsModule, LoginComponent, RegisterComponent],
  templateUrl: './auth.component.html',
  styleUrl: './auth.component.css'
})
export class AuthComponent {

}
