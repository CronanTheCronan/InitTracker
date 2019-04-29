import { Component, OnInit } from '@angular/core';
import { HttpClient } from '@angular/common/http';

@Component({
  selector: 'app-creature',
  templateUrl: './creature.component.html',
  styleUrls: ['./creature.component.css']
})
export class CreatureComponent implements OnInit {
  creatures: any;

  constructor(private http:HttpClient) { }

  ngOnInit() {
    this.getCreatures();
  }

  getCreatures() {
    this.http.get('http://localhost:5000/api/creatures').subscribe(response => {
      this.creatures = response;
    }, error => {
      console.log(error);
    })
  }

}
