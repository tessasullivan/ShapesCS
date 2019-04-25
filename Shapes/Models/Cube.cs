namespace Shapes.Models
{
  public class Cube
  {
    private Rectangle _face;
    public Cube (Rectangle side)
    {
      _face = side;
    }
    public int GetVolume()
    {
        int length = _face.GetLength();
        return length * length * length;
    }
    public int GetSurfaceArea()
    {
        int length = _face.GetLength();
        return (length * length) * 6;
    }   
  }
}