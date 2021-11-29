import { HttpClient } from '@angular/common/http';
import { Component, Inject, OnInit } from '@angular/core';
import { Specialist } from '../Interfaces/specialist';

@Component({
  selector: 'app-specialists',
  templateUrl: './specialists.component.html',
  styleUrls: ['./specialists.component.css']
})
export class SpecialistsComponent implements OnInit {

  public specialists: Specialist[] = new Array();

  constructor(http: HttpClient, @Inject('BASE_URL') baseUrl: string) {
    http.get<Specialist[]>(baseUrl + 'specialist').subscribe(result => {
      this.specialists = result;
    }, error => console.error(error));
  }

  ngOnInit() {
  }
}
