import { Component } from '@angular/core';
import { Obra } from '../models/obra/obra.model';
import { ObrasService } from '../services/obras/obras.service';

@Component({
  selector: 'obras',
  templateUrl: './obras.component.html',
  providers: [ObrasService]
})
export class ObrasComponent {

  public Obras: Array<Obra> = [];

  constructor(private obrasService: ObrasService) {

    this.obrasService.getObras().subscribe((obras) => {
      this.Obras = obras;
    });
    
  }





}
