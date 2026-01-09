

using _3_dars.Models;

namespace _3_dars.Services;

public class Airlaneservice
{
    List<AirLine> AirLines;

    public Airlaneservice()
    {
        AirLines = new List<AirLine>();
    }



    public Guid AddPlane(AirLine plane)
    {
        plane.PlaneId = Guid.NewGuid();
        AirLines.Add(plane);
        return plane.PlaneId;
    }


    public AirLine? GetPlaneById(Guid planeId)
    {

        foreach (var plane in AirLines)
        {
            if (plane.PlaneId == planeId)
                return plane;
        }

        return null;
    }

    public List<AirLine> GetAirlinePlanes()
    {
        return AirLines;
    }


    public bool UpdateAirlinePlane(Guid planeId, AirLine newPlane)
    {


        AirLine? plane = GetPlaneById(planeId);

        if (plane == null)
        {
            return false;
        }

        plane.CompanyName = newPlane.CompanyName;
        plane.PlaneCount = newPlane.PlaneCount;
        plane.FlightCostMin = newPlane.FlightCostMin;
        plane.FlightCostMax = newPlane.FlightCostMax;

        return true;

    }

    public bool DeleteAirline(Guid planeId)
    {

        foreach (var plane in AirLines)
        {
            if (plane.PlaneId == planeId)
            {
                AirLines.Remove(plane);
                return true;
            }
        }

        return false;
    }

}
