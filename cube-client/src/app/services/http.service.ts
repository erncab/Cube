import { Injectable } from '@angular/core';
import {Http, Response} from "@angular/http";

import { Observable } from 'rxjs/Observable';
import 'rxjs/add/operator/map';
import 'rxjs/add/operator/catch';

@Injectable()
export class HttpService {

  constructor(private _http: Http) { }

  getWebApi(portNumber: number, url: string) {
    var fullUrl = `http://localhost:${portNumber}/api/${url}`;

    return this._http.get(fullUrl)
      .map((response: Response) => response.json())
      .catch((error: any) => Observable.throw(error.json().error || 'Server error received.'))
  }

}
