import { Component, OnInit } from '@angular/core';
import { FormControl, FormGroup, Validators } from '@angular/forms';
import { Router } from '@angular/router';
import { EquipoService } from '../servcicios/equipo.service';

@Component({
  selector: 'app-equipos',
  templateUrl: './equipos.component.html',
  styleUrls: ['./equipos.component.css']
})
export class EquiposComponent implements OnInit {

  constructor(private equipoSvc: EquipoService, private router: Router) { }

  ngOnInit() {
  }

  formEquipos = new FormGroup({
    team1: new FormControl('', Validators.required),
    team2: new FormControl('', Validators.required)
  });

  save() {
    let eq: IMatch = this.formEquipos.value;
    
    this.equipoSvc.saveEquipos(eq);
    this.router.navigate(['partido']);
  }

}
