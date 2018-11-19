import { Component } from '@angular/core';
import * as $ from 'jquery';

@Component({
  selector: 'app-nav-menu',
  templateUrl: './nav-menu.component.html',
  styleUrls: ['./nav-menu.component.css']
})
export class NavMenuComponent {
  isExpanded = false;


  collapse() {
    this.isExpanded = false;
  }

  toggle() {
    this.isExpanded = !this.isExpanded;
  }

  constructor() {
    this.toggleMenu();
  }

  toggleMenu() {
    $(".main-sidebar").ready(function () {

      $(".treeview").find(".pull-right-container").click(function () {
        let parent = $(this).parent().parent();
        if (parent.hasClass("menu-open")) {
          parent.removeClass("menu-open");
          parent.addClass("menu-close");
          parent.find(".treeview-menu").slideToggle();
        } else {
          parent.removeClass("menu-close");
          parent.addClass("menu-open");
          parent.find(".treeview-menu").slideToggle();
        }
      });


    });


  }
}
