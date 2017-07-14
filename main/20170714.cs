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
  public Vector2 position0;
  public Vector2 position1;
  
  public Vector2 speed0;
  public Vector2 speed1;
  
  public Vector2 scale;
  /*offset*/
  public AABB aabb;
  public Vector2 aabbOffset;
  /*position state using bool*/
  public bool pushWallRight0;
  public bool pushWallRight1;
  
  public bool pushWallLeft0;
  public bool pushWallLeft1;
  
  public bool atCeiling0;
  public bool atCeiling1;
  
  public bool onGround0;
  public bool onGround1;
}

/*to update the object by void*/
public void UpdatePhysics{
  position0 = position1;
  speed0 = speed1;
  
  pushWallRight0 = pushWallRight1;
  pushWallLeft0 = pushWallLeft1;
  atCeiling0 = atCeiling1;
  onGround0 = onGround1;
}

