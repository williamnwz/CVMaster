import { NgModule } from "@angular/core";
import { BrowserModule } from "@angular/platform-browser";
import { ContainerComponent } from "./basic-components/container/container.component";
import { WidgetUserComponent } from "./basic-components/widget-user/widget-user.component";

@NgModule({
  declarations: [
    WidgetUserComponent,
    ContainerComponent
  ],
  imports: [
    BrowserModule
  ],
  exports: [
    WidgetUserComponent,
    ContainerComponent
  ]
})
export class SharedModule {

}
