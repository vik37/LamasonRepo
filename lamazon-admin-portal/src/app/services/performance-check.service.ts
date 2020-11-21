import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { Observable } from 'rxjs';

@Injectable({
  providedIn: 'root'
})
export class PerformanceCheckService {

  apiUrl = 'https://localhost:44336/api/external/performance/getorder';
  
  constructor(private http:HttpClient) { }

  checkPerformance(): Observable<any> {
    return this.http.get(this.apiUrl);
  }
  
}
