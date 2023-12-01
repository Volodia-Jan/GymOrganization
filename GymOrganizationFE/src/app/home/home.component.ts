import {Component, HostListener, OnInit} from '@angular/core';
import { CommonModule } from '@angular/common';
import {BannerComponent} from "./banner/banner.component";

@Component({
  selector: 'app-home',
  standalone: true,
  imports: [CommonModule, BannerComponent],
  templateUrl: './home.component.html',
  styleUrl: './home.component.css'
})
export class HomeComponent implements OnInit{
  ngOnInit(): void {
  }


}
