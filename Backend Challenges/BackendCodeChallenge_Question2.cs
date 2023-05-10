public class Factory
{
    private RobotService _robotService;
    private PartsService _partsService;
    private CarService _carService;

    public Factory()
    {
        _robotService = new RobotService();
        _partsService = new PartsService();
        _carService = new CarService();
    }

    public Robot BuildRobot(Enum robotType)
    {

        if (robotType == null) return null;

        var parts = GetRobotPartsFor(robotType);
        return _robotService.BuildRobotDog(parts);
        
    }

    public Car AssemblePartsAndBuildCar(Enum carType)
    {
        if(carType == null) return null;

        var parts = GetCarPartsFor(carType);
        return _carService.BuildCar(parts);

    }

    public List<Parts> GetRobotPartsFor(Enum RobotType)
    {
        return _partsService.GetParts(RobotType);
    }

    public List<Parts> GetCarPartsFor(Enum CarType)
    {
        return _partsService.GetParts(CarType);
    }
}


