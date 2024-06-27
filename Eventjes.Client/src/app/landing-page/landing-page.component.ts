import { Component, OnInit } from '@angular/core';

@Component({
  selector: 'app-landing-page',
  templateUrl: './landing-page.component.html',
  styleUrls: ['./landing-page.component.css']
})
export class LandingPageComponent implements OnInit {
  events = [
    { name: 'Angular Workshop', date: '2024-07-01', attendees: ['Alice', 'Bob', 'Charlie'] },
    { name: 'React Conference', date: '2024-07-10', attendees: ['Dave', 'Eve', 'Frank'] },
    { name: 'Vue Meetup', date: '2024-07-15', attendees: ['Grace', 'Heidi', 'Ivan'] }
  ];

  constructor() { }

  ngOnInit(): void {
  }
}

