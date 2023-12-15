import {Component, HostListener, OnInit} from '@angular/core';
import { CommonModule } from '@angular/common';
import {MatGridListModule} from "@angular/material/grid-list";
import {GalleryComponent} from "ng-gallery";

@Component({
  selector: 'app-banner',
  standalone: true,
  imports: [CommonModule, MatGridListModule, GalleryComponent],
  templateUrl: './banner.component.html',
  styleUrl: './banner.component.css'
})
export class BannerComponent implements OnInit{
  gridListConfig : any;
  sliderConfig : any;
  ngOnInit(): void {
    this.gridListConfig = {
      cols: 4,
      rowHeight: 250,
      grids: [
        {
          imagePath: 'assets/banner/gym1.jpg',
          rowspan: 2,
          colspan: 2
        },
        {
          imagePath: 'assets/banner/gym2.jpg',
          rowspan: 1,
          colspan: 1
        },
        {
          imagePath: 'assets/banner/people_gym1.jpg',
          rowspan: 1,
          colspan: 1
        },
        {
          imagePath: 'assets/banner/people_gym2.jpg',
          rowspan: 1,
          colspan: 1
        },
        {
          imagePath: 'assets/banner/people_gym3.jpg',
          rowspan: 1,
          colspan: 1
        }
      ]
    }

    this.sliderConfig = {
      imageSize: 'cover',
      autoPlay: true,
      images: [
        {
          src: '/assets/banner/people_gym2.jpg',
          thumb: '/assets/banner/people_gym2.jpg',
        },
        {
          src: '/assets/banner/people_gym3.jpg',
          thumb: '/assets/banner/people_gym3.jpg',
        },
        {
          src: '/assets/banner/gym2.jpg',
          thumb: '/assets/banner/gym2.jpg',
        },
        {
          src: '/assets/banner/gym1.jpg',
          thumb: '/assets/banner/gym1.jpg',
        },
        {
          src: '/assets/banner/people_gym1.jpg',
          thumb: '/assets/banner/people_gym1.jpg',
        },
      ]
    }
  }


  @HostListener('window:resize', ['$event'])
  onResize(event: any) {
    let width = event.target.innerWidth;
    if (width <= 1300){
      this.gridListConfig.rowHeight = 175;
    }

    if (width > 1300){
      this.gridListConfig.rowHeight = 250;
    }
  }
}
