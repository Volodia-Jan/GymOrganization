import { Component } from '@angular/core';
import { CommonModule } from '@angular/common';
import {BannerComponent} from "../home/banner/banner.component";

@Component({
  selector: 'app-catalog',
  standalone: true,
  imports: [CommonModule, BannerComponent],
  templateUrl: './catalog.component.html',
  styleUrl: './catalog.component.css'
})
export class CatalogComponent {

}
