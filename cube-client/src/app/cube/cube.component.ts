import { Component, OnInit } from '@angular/core';

import {HttpService} from "../services/http.service";

import {Cube} from "../models/cube";

@Component({
  selector: 'app-cube',
  templateUrl: './cube.component.html',
  styleUrls: ['./cube.component.css'],
  providers: [HttpService]
})
export class CubeComponent implements OnInit {
  private _cubes: Cube[] = [];
  private _sides: string = "0,1,2,3,4,5,6,7,8,9,10";

  constructor(private _httpService: HttpService) { }

  ngOnInit() {
    this.getWebApi(this._sides);
  }

  calculateVolumes() {
    this.getWebApi(this._sides);
  }

  private getWebApi(sides: string) {
    var portNumber = 15329;
    var url = `cube?sides=${sides}`;

    this._httpService.getWebApi(portNumber, url)
      .subscribe(
        (data: Cube[]) => {
          console.log(data);
          this._cubes = data;
        }
      );
  }
}
