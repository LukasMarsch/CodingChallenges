namespace Euler11
{
    class RowAdjacent: IAdjacency
    {
        public int getAdjacentProduct(Table table)
        {
            Cursor<Table> myCursor = new Cursor<Table>();
            // create a duplicate of table cursor
            myCursor.position = table.cursor.position;

            int[] result = new int[4];

            for(int i=0; i<4; i++){
                myCursor.right();
                result[i] = table.Get(myCursor.position);
            }
            int product = 1;
            Array.ForEach(result, x => product *= x);
            return product;
        }
    }

    class ColumnAdjacent: IAdjacency
    {
        /*
            returns the Product of 4 adjacent tiles on the current cursor position downwards
        */
        public int getAdjacentProduct(Table table)
        {
            Cursor<Table> myCursor = new Cursor<Table>();
            myCursor.position = table.cursor.position;

            List<int> result = new List<int>();

            for(int i=0; i<4; i++){
                try{
                    myCursor.down();
                } catch {
                    break;
                }
                
                result.Add(table.Get(myCursor.position));
            }
            int product = 1;
            result.ForEach(x => product *= x);
            return product;
        }
    }
}
