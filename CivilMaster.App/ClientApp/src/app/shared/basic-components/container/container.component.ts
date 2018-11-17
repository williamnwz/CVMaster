import { Component, Input } from "@angular/core";

@Component({
  selector: "container",
  templateUrl: "./container.html"
})
export class ContainerComponent {

  @Input("header") Header: string

  constructor() {
    this.Header = "";
  }

}
