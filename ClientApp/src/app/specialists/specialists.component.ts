import { Component, OnInit } from '@angular/core';

@Component({
  selector: 'app-specialists',
  templateUrl: './specialists.component.html',
  styleUrls: ['./specialists.component.css']
})
export class SpecialistsComponent implements OnInit {

  public specialist: Specialist = {
    id: 1,
    lastName: 'Nazwisko1',
    firstName: 'Imię1',
    email: 'email1@example.com',
    phoneNumber: 111111111
  };

  public localization: Localization = {
    id: 1,
    streetName: 'Ulica1',
    number: '00',
    zipCode: 11111,
    city: 'Miasto1'
  }

  constructor() { }
  
  ngOnInit() {
  }

}

interface Specialist {
  id: number;
  lastName: string;
  firstName: string;
  email: string;
  phoneNumber: number;
  description?: string;
  education?: string;
}

interface Localization {
  id: number;
  streetName: string;
  number: string;
  zipCode: number;
  city: string;
}






