import { Component, Input, OnInit } from '@angular/core';
import { INavItem } from 'src/app/core/interface/i-nav-item';

@Component({
  selector: 'app-menu-list-item',
  templateUrl: './menu-list.component.html',
  styleUrls: ['./menu-list.component.scss']
})
export class MenuListComponent implements OnInit {

  @Input() item: INavItem;

  constructor() { }

  ngOnInit(): void {
  }

}
