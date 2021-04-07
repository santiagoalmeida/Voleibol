import { Component, OnInit } from '@angular/core';
import { Router } from '@angular/router';
import { EquipoService } from '../servcicios/equipo.service';

@Component({
  selector: 'app-partido',
  templateUrl: './partido.component.html',
  styleUrls: ['./partido.component.css']
})
export class PartidoComponent implements OnInit {
  match: IMatch;
  constructor(private equipoSvc: EquipoService, private router: Router) { }

  ngOnInit() {
    this.match = this.equipoSvc.getEquipos();
    if (!this.match.finish) {
      if (this.match == null)
        this.router.navigate(['']);

      if (!this.match.times || this.match.times.filter(c => !c.terminado).length <= 0) {
        if (!this.match.times)
          this.match.times = [];

        let tme: ITimes = {} as ITimes;

        tme.team1Points = 0;
        tme.team2Points = 0;
        tme.numTime = 1;
        tme.terminado = false
        this.match.times.push(tme);
      }
    }
  }

  terminar() {
    this.equipoSvc.borrar();
    this.router.navigate(['']);
  }

  punto(equipo: number) {
    this.match.pointTeam = equipo;
    this.equipoSvc.addPoint(this.match).subscribe(c => this.equipoSvc.checkSet(c)
      .subscribe(d => {
        this.match = d;
        this.equipoSvc.saveEquipos(this.match);
      }));
  }
}
