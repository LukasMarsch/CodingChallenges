namespace Euler11
{
    class Cursor<Table>
    {
        public int position { get; set; }

        public Cursor() {
            this.position = -1;
        }

        public int Right(){
            // Zeilenumbruch
            if(position%20 == 19){
                throw new IndexOutOfRangeException("Zeilenumbruch");
            }
            //nach rechts rutschen
            return position +=  1;
        }
        
        public int Left(){
            // Zeilenanfang
            if(position%20 == 0){
                throw new IndexOutOfRangeException("Zeilenanfang");
            }
            return position -= 1;
        }

        public int Left(int a){
            for(int i = 0; i<a; i++){
                Left();
            }
            return position;
        }

        public int Up(){
            // erste Zeile
            if(position < 20){
                throw new IndexOutOfRangeException("Erste Zeile");
            }
            return position -= 20;
        }

        public int Down(){
            //letzte Zeile
            if(position >= 380){
                throw new IndexOutOfRangeException("letzte Zeile");
            }
            return position += 20;
        }

        public int RightWithLineBreak()
        {
            try {
                Right();
            } catch {
                if(this.position == 399){
                    position += 1;
                    return position;
                }
                Down();
                try{
                    return Left(19);
                } catch {
                    throw new Exception();
                }
            }
            return position;
        }
    }
}
