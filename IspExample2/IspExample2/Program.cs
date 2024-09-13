using System.Collections;

namespace IspExample2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] num1 = { 1, 2, 3 ,4,5};
            ArrayList num2 = new ArrayList() { 1,2,3,4,5};
            
            ReadCollection num3 = new ReadCollection(num1 );
            foreach (int i in num3)
            {
                Console.WriteLine(i);
            }
            //下面会报错，因为num3是IEnumerable,不符合Sum方法要求的ICollection类型
            int result = Sum(num3);
            Console.WriteLine(result);



        }
        static int Sum(ICollection collection)
        {
            int sum = 0;
            foreach (var item in collection)
            {
                sum += (int)item;
            }
            return sum;
        }
    }
    class ReadCollection : IEnumerable
    {
        private int[] _array;
        public ReadCollection(int[] array)
        {
            this._array = array;
        }
        public IEnumerator GetEnumerator()
        {
            return new Enum(this); 
        }

        class Enum : IEnumerator
        {
            private ReadCollection _collection;
            private int _index;
            public Enum(ReadCollection collection)
            {
                this._collection = collection;
                _index = -1;
            }
            public object Current
            {
                get
                {
                    object o = _collection._array[_index];
                    return o;
                }
            }

            public bool MoveNext()
            {
                if(++_index<_collection._array.Length)
                    return true;
                return false;
            }

            public void Reset()
            {
                throw new NotImplementedException();
            }
        }
    }
}
