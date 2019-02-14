import { Component, Inject } from '@angular/core';
import { HttpClient } from '@angular/common/http';

@Component({
  selector: 'app-home',
  templateUrl: './home.component.html',
})
export class HomeComponent {
  public host: Host;

  constructor(http: HttpClient, @Inject('BASE_URL') baseUrl: string) {
    http.get<Host>(baseUrl + 'api/HostData/Host').subscribe(result => {
      console.log(result);
      this.host = result;
    }, error => console.error(error));
  }
}

interface Host {
  hostName: string;
}
