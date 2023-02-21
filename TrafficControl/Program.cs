// See https://aka.ms/new-console-template for more information

using TrafficControl;

TrafficLight trafficLight = new();
Car car1 = new Car(trafficLight, 1);
Car car2 = new Car(trafficLight, 2);
Car car3 = new Car(trafficLight, 3);

Taxi taxi1 = new Taxi(trafficLight, 4);
Taxi taxi2 = new Taxi(trafficLight, 5);
Taxi taxi3 = new Taxi(trafficLight, 6);

Pedestrian pedestrian = new Pedestrian(trafficLight, 70);

trafficLight.RunTrafficLight();