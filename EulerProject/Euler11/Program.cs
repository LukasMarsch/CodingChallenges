using Euler11;

namespace Euler11
{
    class main
    {
        public static void Main(String[] args){
            var t = new Table();
            Console.WriteLine(t.cursor.position = 19);
        
            for(int i=0; i<100;i++){
            Console.WriteLine(t.cursor.rightWithLineBreak());
            }
            
        }
    }
       

/*    class fourAdjacent
    {
        public Table table{get; set;}

        public fourAdjacent(Table table)
        {
            this.table = table; 
        }

        public int[] FourInARow()
        {
            Cursor<Table> c = new Euler11.Cursor<Table>();
            c.cursor = table.cursor.value();
            int[] result = new int[4];
            for(int i = 0; i<4; i++){
                    result[i] = table.values[c.right()];
                }
            return result;
        }

        public int[] FourDown() 
        {
            int[] result = new int[4];
            for(int i = 0; i<4; i++)
            {
                int c = table.down();
                result[i] = table.values[c];
            }
            return result;
        }

        public int[] FourUpLeft()
        {
            int myCursor = table.cursor;
            int[] result = new int[4];
            try{
                for(int i=0; i<4; i++){
                    myCursor;
                    table.left();
                    result[i] = table.values[]
                
                }
            } catch {
                throw new Exception();
            }
            return result;
        } 
    }*/
}