import { Component } from '@angular/core';
import { CommonModule } from '@angular/common';
import {MatTableModule} from "@angular/material/table";
import {SubscriptionInfoComponent} from "./subscription-info/subscription-info.component";
import {UserInfoComponent} from "./user-info/user-info.component";

@Component({
  selector: 'app-profile',
  standalone: true,
  imports: [CommonModule, MatTableModule, SubscriptionInfoComponent, UserInfoComponent],
  templateUrl: './profile.component.html',
  styleUrl: './profile.component.css'
})
export class ProfileComponent {

}
