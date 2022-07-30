import { Component, OnInit } from '@angular/core';
import { NavItems } from 'src/app/core/constants/nav-items';

@Component({
  selector: 'app-sidebar',
  templateUrl: './sidebar.component.html',
  styleUrls: ['./sidebar.component.scss']
})
export class SidebarComponent implements OnInit {

  navItems = NavItems;

  constructor() { }

  ngOnInit(): void {
  }

}
