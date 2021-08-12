using System;
namespace Lession10
{
    class MyGeneric<T> where T: class
    {
        private T[] data = new T[0];
        public int Count {get; private set;}
        public int Capacity {get; private set;}

        public T this[int i]
        {
            get { return data[i]; }
            set { data[i] = value; }
        }
        public void Add(T item){
            if(Count < Capacity){
                data[Count] = item;
            }
            else{
                CalsCapacity();
                Array.Resize(ref data, Capacity);
                data[Count] = item;
            }
            CalsCount();
        }

        private void CalsCapacity(){
            int capacity = 0;
            int n = 2;
            do{
                capacity = (int)Math.Pow(2,n);
                n++;
            }
            while(capacity-1 < Count);
            Capacity = capacity;
        }

        private void CalsCount(){
            var count = 0;
            for(int i=0; i< data.Length; i++){
                if(data[i] != null){
                    count++;
                }
            }
            Count = count;
        }
    }
}