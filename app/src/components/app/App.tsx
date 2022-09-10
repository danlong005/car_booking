import React, {useEffect, useState} from 'react';
import './App.css';

import { getAllCars } from "../../services/car.service";
import Car from "../../models/car.interface";

type AppProps = {};

const App: React.FC<AppProps> = () => {
  let [cars, setCars] = useState<Array<Car>>([]);
  let [loading, setLoading] = useState<boolean>(true);

  useEffect(() => {
      (async () => {
          await setCars(await getAllCars());
          setLoading(false);
      })();
  }, []);

  return (
    <div className="App">
        { loading ? (
            <div>Everything is loading</div>
        ) : (
            <div>
            {
                cars.map((car, index) => <div key={index}>{car.model}</div>)
            }
            </div>
        )}
    </div>
  );
}

export default App;
