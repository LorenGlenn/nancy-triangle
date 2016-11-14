using System.Collections.Generic;
namespace TriangleShape.Objects
{
  public class Triangle
  {
    private int _side1;
    private int _side2;
    private int _side3;


    public Triangle(int side1, int side2, int side3)
    {
      _side1 = side1;
      _side2 = side2;
      _side3 = side3;
    }

    public int GetLength1()
    {
      return _side1;
    }

    public int GetLength2()
    {
      return _side2;
    }

    public int GetLength3()
    {
      return _side3;
    }
    public string calculate()
    {

      if (_side1 == _side2 && _side1 == _side3){
        return "equilateral";
      }

      else if (_side1 != _side2 && _side2 != _side3 && _side1 != _side3 && _side1 + _side2 > _side3 && _side2 + _side3 > _side1 && _side1 + _side3 > _side2){
        return "scalene";
      }

      else if (_side1 == _side2 && _side1 != _side3 && _side1 + _side2 > _side3 || _side2 == _side3 && _side2 != _side1 && _side3 + _side2 > _side1 || _side1 == _side3 && _side1 != _side2 && _side3 + _side1 > _side2){
        return "isosceles";
      }

      else {
        return "Not a triangle";
      }
    }
  }
}
