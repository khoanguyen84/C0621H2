namespace Lession31
{
    class MyRandom
    {
        public int Next(){
            return 10;
        }

        public int Next(int max){
            return max;
        }

        public static int Next(int min, int max){
            return min+max;
        }
    }
}