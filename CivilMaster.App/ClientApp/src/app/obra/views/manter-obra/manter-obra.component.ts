import { Component } from '@angular/core';
import { Obra } from '../../../models/obra/obra.model';
import { ObrasService } from '../../../services/obras/obras.service';

@Component({
  selector: 'manter-obra',
  templateUrl: './manter-obra.component.html',
  providers: [ObrasService],
})
export class ManterObraComponent {

  public Obra: Obra;

  constructor(private obrasService: ObrasService) {
    
  }


}
