import { NgModule } from "@angular/core";
import { ObrasService } from "../services/obras/obras.service";
import { BrowserModule } from "@angular/platform-browser";
import { ManterObraComponent } from "./views/manter-obra/manter-obra.component";
import { ConsultaObrasComponent } from "./views/consulta-obras/consulta-obras.component";
import { SharedModule } from "../shared/shared.module";
import { RouterModule } from '@angular/router';

@NgModule({
  declarations: [
    ConsultaObrasComponent,
    ManterObraComponent
  ],
  imports: [
    BrowserModule,
    SharedModule,
    RouterModule.forChild([
      {
        path: "obras/consulta-obras",
        component: ConsultaObrasComponent,
        canActivate: []
      },
      {
        path: "obras/nova-obra",
        component: ManterObraComponent,
        canActivate: []
      }
    ])
  ],
   exports: [
     ConsultaObrasComponent,
     ManterObraComponent
  ],
  providers: [
    ObrasService
  ]
})
export class ObraModule {

}
