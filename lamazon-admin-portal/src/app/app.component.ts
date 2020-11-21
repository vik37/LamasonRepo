import { Component } from '@angular/core';

@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.css']
})
export class AppComponent {

  navBarTitle = "Lamazon admin portal";
  navBarItems:Array<{name:string, link:string}> = [
    { name: 'Home', link: '/' },
    { name: 'Performance check', link: '/performance-check' }
  ]
}
