namespace Euler11
{
    class Cursor<Table>
    {
        public int position { get; set; }

        public Cursor() {
            this.position = -1;
        }

        public int value() => position;

        public int right(){
            // Zeilenumbruch
            if(position%20 == 19){
                throw new IndexOutOfRangeException("Zeilenumbruch");
            }
            //nach rechts rutschen
            return position +=  1;
        }
        
        public int left(){
            // Zeilenanfang
            if(position%20 == 0){
                throw new IndexOutOfRangeException("Zeilenanfang");
            }
            return position -= 1;
        }

        public int left(int a){
            for(int i = 0; i<a; i++){
                left();
            }
            return position;
        }

        public int up(){
            // erste Zeile
            if(position < 20){
                throw new IndexOutOfRangeException("Erste Zeile");
            }
            return position -= 20;
        }

        public int down(){
            //letzte Zeile
            if(position >= 380){
                throw new IndexOutOfRangeException("letzte Zeile");
            }
            return position += 20;
        }

        public int rightWithLineBreak()
        {
            try {
                right();
            } catch {
                if(this.position == 399){
                    position += 1;
                    return position;
                }
                down();
                try{
                    return left(19);
                } catch {
                    throw new Exception();
                }
            }
            return position;
        }
    }
}