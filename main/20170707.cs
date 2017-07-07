float timer = 80f;
/*120sec = 2min*/
void Update(){
  timer = Time.deltaTime;
  GetComponent<ok>().text = timer.ToString();
}
