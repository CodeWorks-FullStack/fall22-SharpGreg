namespace GreglistSharp.Services;

public class CarsService
{
  // REPOSITORY PATTERN
  // will be used to control communication with the DB

  private readonly CarsRepository _carsRepo;

  public CarsService(CarsRepository carsRepo)
  {
    _carsRepo = carsRepo;
  }

  public List<Car> GetCars()
  {
    return _carsRepo.GetCars();
  }

  public Car GetCar(int id)
  {
    return _carsRepo.GetCar(id);
  }

  public Car CreateCar(Car carData)
  {
    return _carsRepo.CreateCar(carData);
  }

  internal Car DeleteById(int id)
  {
    return _carsRepo.DeleteCar(id);
  }

  internal Car EditCar(Car carData, int id)
  {
    return _carsRepo.EditCar(carData, id);
  }
}