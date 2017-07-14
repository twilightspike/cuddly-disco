#include <cmath> /*Or should I type instead <math.h>?*/

public struct AABB(Vector2 center, Vector2 halfSize){
  /*public Vector2 center;
  public Vector2 halfSize;*/
  this.center = center;
  this.halfSize = halfSize;
}
public bool Ovverlaps(AABB other){
  if( Math.Abs(center.x - other.center.x) > halfSize.x + other.halfSize.x ) return false;
  if( Math.Abs(center.y - other.center.y) > halfSize.y + other.halfSize.y ) return false;
  return true;
}

/*create Object and fill the data*/
public class MovingObject{
  public Vector2 Position0;
  public Vector2 Position1;
  
  public Vector2 Speed0;
  public Vector2 Speed1;
  
  public Vector2 scale;
  /*offset*/
  public AABB aabb;
  public Vector2 aabbOffset;
}
