import { Component, Input } from '@angular/core';


@Component({
  moduleId: module.id,
  selector: 'widget-user',
  templateUrl: "./widget-user.html"
})
export class WidgetUserComponent {

  @Input("imageSrc") ImageSrc: string;
  @Input("name") Name: string;
  @Input("description") Description: string;

  constructor() {
    this.ImageSrc = "";
    this.Name = "";
    this.Description = "";
  }

}
