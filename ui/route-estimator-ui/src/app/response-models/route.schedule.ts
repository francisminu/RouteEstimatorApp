export interface RouteSchedule
{
    rouesList: Array<RouteModel>,
    nextArrivalTime: number,
    secondArrivalTime: number
}

export interface RouteModel{
    routeName: string,
    nextArrivalTime: number,
    secondArrivalTime: number
}