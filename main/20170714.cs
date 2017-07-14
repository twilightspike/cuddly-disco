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
  public Vector2 mPosition;
  public Vector2 mPosition_1;
  
  public Vector2 mSpeed;
  public Vector2 mSpeed_1;
  
  public Vector2 mScale;
  /*offset*/
  public AABB mAABB;
  public Vector2 mAABBOffset;
  /*position state using bool*/
  public bool pushWallRight;
  public bool pushWallRight_1;
  
  public bool mPushWallLeft;
  public bool mPushWallLeft_1;
  
  public bool mAtCeiling;
  public bool mAtCeiling_1;
  
  public bool mOnGround;
  public bool mOnGround_1;
}

/*to update the object by void*/
public void UpdatePhysics(){
  mPosition = mPosition_1;
  mSpeed = mSpeed_1;
  
  mPushWallRight = mPushWallRight_1;
  mPushWallLeft = mPushWallLeft_1;
  mAtCeiling = mAtCeiling_1;
  mOnGround = mOnGround_1;
}

