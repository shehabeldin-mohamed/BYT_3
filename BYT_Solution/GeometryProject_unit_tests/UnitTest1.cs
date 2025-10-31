using BYT_Solution.Models;

namespace GeometryProject_unit_tests;

public class Tests
{
    private readonly IShape Cube = new Cube(5);
    private readonly IShape Cylinder = new Cylinder(5,5);
    private readonly IShape Rectangle = new Rectangle(5,3);
    private readonly IShape sphere = new Sphere(5);
    
    //Cube Tests
    [Test]
    public void TestCubeCalculateArea()
    {
        Assert.That(Cube.CalculateArea(), Is.EqualTo(150));
    }

    [Test]
    public void TestCubeCalculateVolume()
    {
        Assert.That(Cube.CalculateVolume(), Is.EqualTo(125));
    }
    
    //Cylider Tests
    [Test]
    public void TestCylinderCalculateArea()
    {
        Assert.That(Cylinder.CalculateArea(), Is.EqualTo(314.159).Within(0.001));
    }

    [Test]
    public void TestCylinderCalculateVolume()
    {
        Assert.That(Cylinder.CalculateVolume(), Is.EqualTo(392.699).Within(0.001));
    }
    
    
    //Rectangle Tests
    [Test]
    public void TestRectangleCalculateArea()
    {
        Assert.That(Rectangle.CalculateArea(), Is.EqualTo(15));
    }

    [Test]
    public void TestRectangleCalculateVolume()
    {
        Assert.That(Rectangle.CalculateVolume(), Is.EqualTo(0));
    }
    
    
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