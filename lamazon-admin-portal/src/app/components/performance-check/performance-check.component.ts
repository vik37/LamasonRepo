import { Component, OnInit } from '@angular/core';
import { PerformanceCheckService } from 'src/app/services/performance-check.service';

@Component({
  selector: 'app-performance-check',
  templateUrl: './performance-check.component.html',
  styleUrls: ['./performance-check.component.css']
})
export class PerformanceCheckComponent implements OnInit {

  constructor(private _service:PerformanceCheckService) { }

  milliseconds = 0;
  timeLimit:number = 1000;

  ngOnInit(): void {
    this._service.checkPerformance().subscribe(time => {
      this.milliseconds = time;
    })
  }

}
