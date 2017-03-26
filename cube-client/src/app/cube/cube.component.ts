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

    //this.randomize();
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

          this.updateGraph(this._cubes);

          console.log("this._cubes: " + this._cubes);
        }
      );
  }

  private updateGraph(series: Cube[]) {
    let _lineChartData:Array<any> = new Array(series.length);

    for (let i = 0; i < this.lineChartData.length; i++) {
      _lineChartData[i] = {
        label: this.lineChartData[i].label,
        data: new Array(series.length)
      };

      for (let j = 0; j < series.length; j++) {
        _lineChartData[i].data[j] = series[j].volume;
      }
    }

    this.lineChartData = _lineChartData;
  }

  /**************************** chart *************************************************/
    // https://github.com/valor-software/ng2-charts/issues/458

    // lineChart
  public lineChartData:Array<any> = [
    {
      label: 'Volume',
      data: [22, 59, 80, 81, 56, 55, 40, 34, 78, 22]
    },
    {
      label: 'Inner Cube Volume',
      data: [17, 48, 40, 19, 86, 27, 90, 89, 54, 42]
    },
    {
      label: 'Difference',
      data: [89, 48, 77, 9, 100, 27, 40, 21, 67, 90]
    }
  ];

  public lineChartLabels:Array<any> = ['1', '2', '3', '4', '5', '6', '7', '8', '9', '10'];

  public lineChartOptions: any = {
    responsive: true
  };

  public lineChartColors:Array<any> = [
    {
      borderColor: 'red',
      pointHoverBackgroundColor: '#fff',
      pointHoverBorderColor: 'rgba(148,159,177,0.8)'
    },
    {
      borderColor: 'blue',
      pointHoverBackgroundColor: '#fff',
      pointHoverBorderColor: 'rgba(77,83,96,1)'
    },
    {
      borderColor: 'green',
      pointHoverBackgroundColor: '#fff',
      pointHoverBorderColor: 'rgba(148,159,177,0.8)'
    }
  ];

  public lineChartLegend: boolean = true;

  public lineChartType: string = 'line';

  public randomize(): void {
    let _lineChartData:Array<any> = new Array(this.lineChartData.length);

    for (let i = 0; i < this.lineChartData.length; i++) {
      _lineChartData[i] = {
        data: new Array(this.lineChartData[i].data.length),
        label: this.lineChartData[i].label};

      for (let j = 0; j < this.lineChartData[i].data.length; j++) {
        _lineChartData[i].data[j] = Math.floor((Math.random() * 100) + 1);
      }
    }

    this.lineChartData = _lineChartData;
  }

  // events
  public chartClicked(e:any):void {
    console.log(e);
  }

  public chartHovered(e:any):void {
    console.log(e);
  }
  /**************************** chart *************************************************/
}
