import { HttpClient } from '@angular/common/http';
import { Component, OnInit } from '@angular/core';

@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.css']
})
export class AppComponent implements OnInit {
  title = 'The datting app';
  users:any;
  constructor(private http:HttpClient){}

  ngOnInit(): void {
    this.getUsers();
  }

  getUsers(){
    this.http.get('https://localhost:44350/api/Users/getAll')
      .subscribe({
        next: r => {this.users = r;
                   console.log(r);},
        error:error => console.log(error),
        complete: ()=> console.log('Request complete')
      });
  }
}
