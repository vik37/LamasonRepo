import { NgModule } from '@angular/core';
import { Routes, RouterModule } from '@angular/router';

import { HomeComponent } from './components/home/home.component';
import { PerformanceCheckComponent } from './components/performance-check/performance-check.component';

const routes: Routes = [
  { path: '', component: HomeComponent},
  { path: 'performance-check', component: PerformanceCheckComponent}
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
