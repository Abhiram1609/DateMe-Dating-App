import { HttpClient } from '@angular/common/http';
import { Component, inject, OnInit } from '@angular/core';
import { RouterOutlet } from '@angular/router';
import { NgFor } from '@angular/common';


@Component({
  selector: 'app-root',
  standalone: true,
  imports: [RouterOutlet, NgFor],
  templateUrl: './app.html',
  styleUrl: './app.css'
})
export class App implements OnInit{
  protected title = 'client';
  http = inject(HttpClient); 
  users: any;

  ngOnInit(): void {
    this.http.get('http://localhost:5137/api/users').subscribe({
      next: response => {
        this.users = response
        console.log('Received' , response);
        
      },
      error: error => console.log(error),
      complete: () =>console.log('Request has completed, check network tab for details')
    })
  }
}


