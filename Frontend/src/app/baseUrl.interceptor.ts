import { Injectable, Inject } from '@angular/core';
import { HttpInterceptor, HttpEvent, HttpResponse, HttpRequest, HttpHandler } from '@angular/common/http';
import { Observable } from 'rxjs';

@Injectable()
export class BaseUrlInterceptor implements HttpInterceptor {

  constructor(@Inject('BASE_API_URL') private baseUrl: string) {
  }

  intercept(httpRequest: HttpRequest<any>, next: HttpHandler): Observable<HttpEvent<any>> {
    if(!this.baseUrl){
      console.log("baseUrl: EMPTY");
      return next.handle(httpRequest);
    }

    console.log("baseUrl: this.baseUrl");
    const apiRequest = httpRequest.clone({ 
      url: `${this.baseUrl}${httpRequest.url}`,
      withCredentials: true
    });
    return next.handle(apiRequest);
  }
}