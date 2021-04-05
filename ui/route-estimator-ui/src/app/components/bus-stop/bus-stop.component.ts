import { Component, OnInit, Input } from '@angular/core';
import { GetRouteScheduleRequestModel } from '../../request-models/route-schedule-request-model';
import { ApiService } from '../../services/api.service';
import { RouteModel, RouteSchedule } from '../../response-models/route.schedule';

@Component({
  selector: 'app-bus-stop',
  templateUrl: './bus-stop.component.html',
  styleUrls: ['./bus-stop.component.scss']
})
export class BusStopComponent implements OnInit {

  @Input()
  stopNumber!: string;
  nextArrivalTime: number;
  secondArrivalTime: number;
  routesList: Array<RouteModel>;
  
  constructor(private apiService: ApiService){
    this.nextArrivalTime = 0;
    this.secondArrivalTime = 0;
    this.routesList = new Array<RouteModel>();
  }

  
  ngOnInit()
  {
    var requestModel = this.getRequestModel();
    this.apiService.getConfigResponse(requestModel)
      .subscribe((resp) => {
      this.routesList = resp.body.routesList;
      console.log(this.routesList);
      this.nextArrivalTime = resp.body.firstArrivalTime;
      this.secondArrivalTime = resp.body.secondArrivalTime;
    });
    var myVar = setInterval(() => {
      requestModel = this.getRequestModel();
      this.apiService.getConfigResponse(requestModel)
      .subscribe((resp) => {
      console.log('Received response from api');
      this.routesList = resp.body.routesList;
    });
    }, 60000);

  }

  getRequestModel(): GetRouteScheduleRequestModel
  {
    const requestModel: GetRouteScheduleRequestModel = {
      stopNumber: +this.stopNumber,
      currentTime: new Date()
    };
    return requestModel;
  }

}
