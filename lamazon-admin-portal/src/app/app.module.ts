import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';

import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { PerformanceCheckComponent } from './components/performance-check/performance-check.component';
import { HomeComponent } from './components/home/home.component';
import { HttpClientModule } from '@angular/common/http';
import { PerformanceCheckService } from './services/performance-check.service';

@NgModule({
  declarations: [
    AppComponent,
    PerformanceCheckComponent,
    HomeComponent
  ],
  imports: [
    BrowserModule,
    AppRoutingModule,
    HttpClientModule
  ],
  providers: [
    PerformanceCheckService
  ],
  bootstrap: [AppComponent]
})
export class AppModule { }
