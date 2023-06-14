namespace Euler11;

static class FourAdjacent
{

  public static List<int> FourInARow(Table table)
  {
    Cursor<Table> cursor = new Cursor<Table>();
    // create a duplicate of table cursor
    cursor.position = table.cursor.position;
    // create an array for the relevant numbers
    List<int> result = new List<int>(4);

    // process pick the 4 relevant positions including the first and move the cursor inbetween
    result.Add(table.Get());
    for(int i = 1; i < 4; i++)
    {
      cursor.Right();
      // Console.WriteLine($"{i}: {table.Get(cursor.position)}");
      result.Add(table.Get(cursor.position));
    }
    // Euler11.ArrayPrint(result);
    return result;
  }

  public static List<int> FourDown(Table table) 
  {
    Cursor<Table> cursor = new Cursor<Table>();
    cursor.position = table.cursor.position;
    List<int> result = new List<int>(4);

    result.Add(table.Get(cursor.position));
    for(int i = 1; i < 4; i++) {
      cursor.Down();
      result.Add(table.Get(cursor.position));
    }
    // Euler11.ArrayPrint(result);
    return result;
  }

  public static List<int> FourUpLeft(Table table) {
    Cursor<Table> cursor = new Cursor<Table>();
    cursor.position = table.cursor.position;
    List<int> result = new List<int>(4);
    
    result.Add(table.Get(cursor.position));
    for(int i = 1; i<4; i++) {
      cursor.Up();
      cursor.Left();
      result.Add(table.Get(cursor.position));
    }
    // Euler11.ArrayPrint(result);
    return result;
  }

  public static List<int> FourUpRight(Table table) {
    Cursor<Table> cursor = new Cursor<Table>();
    cursor.position = table.cursor.position;
    List<int> result = new List<int>(4);

    result.Add(table.Get(cursor.position));
    for(int i = 1; i < 4; i++) {
      cursor.Up();
      cursor.Right();
      result.Add(table.Get(cursor.position));
    }
    // Euler11.ArrayPrint(result);
    return result;
  }
}
