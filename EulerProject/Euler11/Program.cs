namespace Euler11
{
    class main
    {
        public static void Main(String[] args){
            var t = new Table();
            var f = new fourAdjacent(t);
            int max = 0;
            while(t.cursor.position < 400){
                // setup
                int[] current = new int[4];
                
                try{
                    current = f.FourInARow();
                } catch {
                    Console.WriteLine(t.cursor.position);
                    t.cursor.rightWithLineBreak();
                    continue;
                }
                int product = 1;
                Array.ForEach(current, x => product *= x);
                max = Math.Max(product, max);




                /* for dbug purposes
                * Console.WriteLine(t.cursor.position);
                * 
                *///finally
                t.cursor.rightWithLineBreak();
            }
            Console.WriteLine(max);
        }
    }
       

/*
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
        } */
    }
}