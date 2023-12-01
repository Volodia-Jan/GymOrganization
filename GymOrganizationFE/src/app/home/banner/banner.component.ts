import {Component, HostListener, OnInit} from '@angular/core';
import { CommonModule } from '@angular/common';
import {MatGridListModule} from "@angular/material/grid-list";
import {NgImageSliderModule} from "ng-image-slider";
import {EventType} from "@angular/router";

@Component({
  selector: 'app-banner',
  standalone: true,
  imports: [CommonModule, MatGridListModule, NgImageSliderModule],
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
      imageSize: {width: '100%', height: '300px'},
      infinite: true,
      autoSlide: 2,
      animationSpeed: 2,
      showArrow: false,
      slideImage: "1",
      images: [
        {
          image: '/assets/banner/people_gym2.jpg',
          thumbImage: '/assets/banner/people_gym2.jpg',
        },
        {
          image: '/assets/banner/people_gym3.jpg',
          thumbImage: '/assets/banner/people_gym3.jpg',
        },
        {
          image: '/assets/banner/gym2.jpg',
          thumbImage: '/assets/banner/gym2.jpg',
        },
        {
          image: '/assets/banner/gym1.jpg',
          thumbImage: '/assets/banner/gym1.jpg',
        },
        {
          image: '/assets/banner/people_gym1.jpg',
          thumbImage: '/assets/banner/people_gym1.jpg',
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
