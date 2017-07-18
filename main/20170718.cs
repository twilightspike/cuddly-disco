public static readonly List<char> icecream = new List<char>() {};
public static readonly List<char> marshmellow = new List<char>() {' ', '_'};
public static readonly List<char> donut = new List<char>() {'#', 'D', 'W'};

public static List<char>[][] outerWallStraight = Map.DefineTilemask
(
  icecream, marshmellow, icecream,
  donut, icecream, donut,
  icecream, icecream, icecream
);
