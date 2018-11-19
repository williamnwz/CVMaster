import { Component, Input } from '@angular/core';


@Component({
  moduleId: module.id,
  selector: 'widget-user',
  templateUrl: "./widget-user.html"
})
export class WidgetUserComponent {

  @Input("imageSrc") imageSrc: string;
  @Input("name") name: string;
  @Input("description") description: string;

  @Input("color") color: string;

  public getBGColor(): string {
    
    return "bg-" + this.color;
  }

  constructor() {
    this.imageSrc = "";
    this.name = "";
    this.description = "";
    this.description = "";
    this.color = "black";
  }


}
