import { Component } from '@angular/core';
import {MatTableModule} from "@angular/material/table";

@Component({
  selector: 'app-user-info',
  standalone: true,
  imports: [
    MatTableModule
  ],
  templateUrl: './user-info.component.html',
  styleUrl: './user-info.component.css'
})
export class UserInfoComponent {
  userData = [
    { property: 'Name', value: 'John' },
    { property: 'Last Name', value: 'Smith' },
    { property: 'Date of Birth', value: '1990-01-01' },
    { property: 'Age', value: '33' },
    { property: 'Email', value: 'jsmith@example.com' }
  ];

  displayedColumns: string[] = ['property', 'value'];
}
