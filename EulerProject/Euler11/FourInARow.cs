namespace Euler11;

static class FourAdjacent
{

  public static int[] FourInARow(Table table)
  {
    Cursor<Table> cursor = new Cursor<Table>();
    // create a duplicate of table cursor
    cursor.position = table.cursor.position;
    // create an array for the relevant numbers
    int[] result = new int[4];

    // process pick the 4 relevant positions including the first and move the cursor inbetween
    result[0] = table.Get();
    for(int i = 1; i < 5; i++)
    {
      cursor.Right();
      Console.WriteLine($"{i}: {table.Get(cursor.position)}");
      result[i] = table.Get(cursor.position);
    }
    Console.WriteLine($"{result[0]}");
    return result;
  }

  public static int[] FourDown(Table table) 
  {
    Cursor<Table> cursor = new Cursor<Table>();
    cursor.position = table.cursor.position;
    int[] result = new int[4];

    result[0] = table.Get(cursor.position);
    for(int i = 1; i<5; i++) {
      cursor.Down();
      result[i] = table.Get(cursor.position);
    }
    Euler11.ArrayPrint(result);
    return result;
  }

  public static int[] FourUpLeft(Table table) {
    Cursor<Table> cursor = new Cursor<Table>();
    cursor.position = table.cursor.position;
    int[] result = new int[4];
    
    result[0] = table.Get(cursor.position);
    for(int i = 1; i<5; i++) {
      cursor.Up();
      cursor.Left();
      result[i] = table.Get(cursor.position);
    }
  Euler11.ArrayPrint(result);
    
    return result;
  }

  public static int[] FourUpRight(Table table) {
    Cursor<Table> cursor = new Cursor<Table>();
    cursor.position = table.cursor.position;
    int[] result = new int[4];

    result[0] = table.Get(cursor.position);
    for(int i = 1; i < 5; i++) {
      cursor.Up();
      cursor.Right();
      result[i] = table.Get(cursor.position);
    }
  Euler11.ArrayPrint(result);
    return result;
  }
}
