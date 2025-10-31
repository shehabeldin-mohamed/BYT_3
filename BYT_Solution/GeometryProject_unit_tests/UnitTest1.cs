using BYT_Solution.Models;

namespace GeometryProject_unit_tests;

public class Tests
{
    private readonly IShape Cube = new Cube(5);
    private readonly IShape Cylinder = new Cylinder(5,5);
    private readonly IShape Rectangle = new Rectangle(5,3);
    private readonly IShape sphere = new Sphere(5);
    
    //Cube Tests
    
    
    //Cylider Tests
    
    
    
    //Rectangles Tests
    
    
    
    //Sphere Tests
    [Test]
    public void TestSphereCalculateArea()
    {
        Assert.That(sphere.CalculateArea(), Is.EqualTo(314.159).Within(0.001));
    }

    [Test]
    public void TestSphereCalculateVolume()
    {
        Assert.That(sphere.CalculateVolume(), Is.EqualTo(523.598).Within(0.001));
    }
    

}