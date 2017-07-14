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
  public Vector2 mPrePosition;
  public Vector2 mPosition;
  
  public Vector2 mPreSpeed;
  public Vector2 mSpeed;
  
  public Vector2 mScale;
  /*offset*/
  public AABB mAABB;
  public Vector2 mAABBOffset;
  /*position state using bool*/
  public bool mPrepushWallRight;
  public bool mpushWallRight;
  
  public bool mPrePushWallLeft;
  public bool mPushWallLef;
  
  public bool mPreAtCeiling;
  public bool mAtCeiling;
  
  public bool mPreOnGround;
  public bool mOnGround;
}

/*to update the object by void*/
public void UpdatePhysics(){
  mPrePosition = mPosition;
  mPreSpeed = mSpeed;
  
  mPrePushWallRight = mPushWallRight;
  mPrePushWallLeft = mPushWallLeft;
  mPreAtCeiling = mAtCeiling;
  mPreOnGround = mOnGround;
}

/*update position using current speed*/
mPosition += mSpeed * Time.deltaTime;

if(mPosition.y < 0.0f){
  mPosition.y = 0.0f;
  mOnGround = true;
}else{
  mOnGround = false;
}
/*Update AABB's center because of new position*/
mAABB.center = mPosition + mAABBOffset;

