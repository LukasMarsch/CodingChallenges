namespace Euler11;

class FourAdjacent
{
  public Table table{get; set;}

  public FourAdjacent(Table table)
  {
    this.table = table; 
  }

  public int[] FourInARow()
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

  return result;
  }

  public int[] FourDown() 
  {
    Cursor<Table> cursor = new Cursor<Table>();
    cursor.position = table.cursor.value();
    int[] result = new int[4];

    result[0] = table.values[cursor.value()];
    for(int i = 1; i<5; i++) {
      cursor.down();
      result[i] = table.values[cursor.value()];
    }
    return result;
  }

  public int[] FourUpLeft() {
    Cursor<Table> cursor = new Cursor<Table>();
    cursor.position = table.cursor.value();
    int[] result = new int[4];
    
    result[0] = table.values[cursor.value()];
    for(int i = 1; i<5; i++) {
      cursor.up();
      cursor.left();
      result[i] = table.values[cursor.value()];
    }
    return result;
  }

  public int[] FourUpRight() {
    Cursor<Table> cursor = new Cursor<Table>();
    cursor.position = table.cursor.value();
    int[] result = new int[4];

    result[0] = table.values[cursor.value()];
    for(int i = 1; i < 5; i++) {
      cursor.up();
      cursor.right();
      result[i] = table.values[cursor.value()];
    }
    return result;
  }
}
