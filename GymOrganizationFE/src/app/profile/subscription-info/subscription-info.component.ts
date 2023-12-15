import { Component } from '@angular/core';

@Component({
  selector: 'app-subscription-info',
  standalone: true,
  imports: [],
  templateUrl: './subscription-info.component.html',
  styleUrl: './subscription-info.component.css'
})
export class SubscriptionInfoComponent {
  subscriptionsInfo = {
    name: "Year subscription",
    startDate: '01/01/2022',
    endDate: '01/01/2023'
  }
}
