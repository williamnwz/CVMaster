import { Component } from '@angular/core';
import { ObrasService } from '../../services/obras/obras.service';
import { Obra } from '../../models/obra/obra.model';

@Component({
  selector: 'manter-obra',
  templateUrl: './manter-obra.component.html',
  providers: [ObrasService]
})
export class ManterObraComponent {

  public Obra: Obra;

  constructor(private obrasService: ObrasService) {

    this.obrasService.getObras().subscribe((obras) => {
      this.Obra = obras[0];
    });
    
  }


}
