import { Component } from '@angular/core';
import { HttpClient } from '@angular/common/http';

@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.css']
})
export class AppComponent {  
  public user?: User;

  constructor(http: HttpClient) {
    http.get<User>('/api/user').subscribe({
      next: (result) => this.user = result, 
      error: (e) => alert(e.message)
    });
  }
}

interface User {
  identityName: string;
}
