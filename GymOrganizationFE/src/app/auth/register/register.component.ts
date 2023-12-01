import {Component} from '@angular/core';
import {CommonModule} from '@angular/common';
import {MatButtonModule} from "@angular/material/button";
import {MatFormFieldModule} from "@angular/material/form-field";
import {MatInputModule} from "@angular/material/input";
import {RouterLink} from "@angular/router";
import {MatDatepickerModule} from "@angular/material/datepicker";
import {MatIconModule} from "@angular/material/icon";
import {MatNativeDateModule} from "@angular/material/core";

@Component({
  selector: 'app-register',
  standalone: true,
  imports: [CommonModule, MatButtonModule, MatFormFieldModule, MatInputModule, RouterLink, MatDatepickerModule,
    MatNativeDateModule, MatIconModule],
  templateUrl: './register.component.html',
  styleUrls: ['./register.component.css', '../auth.component.css']
})
export class RegisterComponent {

}
