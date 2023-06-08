namespace Euler11;

static class FourAdjacent
{

  public static int[] FourInARow(Table table)
  {
    Cursor<Table> cursor = new Cursor<Table>();
    // create a duplicate of table cursor
    cursor.position = table.cursor.value();
    // create an array for the relevant numbers
    int[] result = new int[4];

    // process pick the 4 relevant positions including the first and move the cursor inbetween
    result[0] = table.Get(cursor.value());
    for(int i = 1; i<5; i++) {
      cursor.right();
      result[i] = table.Get(cursor.value());
    }
  Euler11.ArrayPrint(result);
  return result;
  }

  public static int[] FourDown(Table table) 
  {
    Cursor<Table> cursor = new Cursor<Table>();
    cursor.position = table.cursor.value();
    int[] result = new int[4];

    result[0] = table.values[cursor.value()];
    for(int i = 1; i<5; i++) {
      cursor.down();
      result[i] = table.values[cursor.value()];
    }
  Euler11.ArrayPrint(result);
    return result;
  }

  public static int[] FourUpLeft(Table table) {
    Cursor<Table> cursor = new Cursor<Table>();
    cursor.position = table.cursor.value();
    int[] result = new int[4];
    
    result[0] = table.values[cursor.value()];
    for(int i = 1; i<5; i++) {
      cursor.up();
      cursor.left();
      result[i] = table.values[cursor.value()];
    }
  Euler11.ArrayPrint(result);
    
    return result;
  }

  public static int[] FourUpRight(Table table) {
    Cursor<Table> cursor = new Cursor<Table>();
    cursor.position = table.cursor.value();
    int[] result = new int[4];

    result[0] = table.values[cursor.value()];
    for(int i = 1; i < 5; i++) {
      cursor.up();
      cursor.right();
      result[i] = table.values[cursor.value()];
    }
  Euler11.ArrayPrint(result);
    return result;
  }
}
