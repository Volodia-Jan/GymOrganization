import { Component } from '@angular/core';
import { CommonModule } from '@angular/common';
import {MatInputModule} from "@angular/material/input";
import {MatButtonModule} from "@angular/material/button";
import {RouterLink} from "@angular/router";

@Component({
  selector: 'app-login',
  standalone: true,
  imports: [CommonModule, MatInputModule, MatButtonModule, RouterLink],
  templateUrl: './login.component.html',
  styleUrls: ['./login.component.css', '../auth.component.css']
})
export class LoginComponent {

}
