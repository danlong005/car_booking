import axios, { AxiosResponse } from 'axios';
import Car from '../models/car.interface';

export async function getAllCars() : Promise<Array<Car>> {
    let cars: Array<Car> = [];
    try {
        let response: AxiosResponse = await axios.get("http://localhost:4000/api/v1/cars")
        cars = response.data;
    } catch (error) {
        console.log(error);
    }

    return cars;
}
