import { Component } from '@angular/core';
import { ObrasService } from '../../../services/obras/obras.service';
import { Obra } from '../../../models/obra/obra.model';


@Component({
  selector: 'obras',
  templateUrl: './consulta-obras.component.html',
  providers: [ObrasService]
})
export class ConsultaObrasComponent {

  public Obras: Array<Obra> = [];

  constructor(private obrasService: ObrasService) {

    this.obrasService.getObras().subscribe((obras) => {
      this.Obras = obras;
    });
    
  }





}
