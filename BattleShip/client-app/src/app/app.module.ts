import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';
import { AppHeaderComponent } from './template/app-header/app-header.component';
import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';

@NgModule({
  declarations: [
        AppComponent,
        AppHeaderComponent
  ],
  imports: [
    BrowserModule,
    AppRoutingModule
  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }
