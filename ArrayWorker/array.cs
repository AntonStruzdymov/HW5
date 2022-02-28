namespace HWLibrary
{
    public class ArrayWorker
    {

        public int[] InvertArray(int[] myarray)
        {
            int t;
            for (int i = 0, j = myarray.Length - 1; i < j; i++, j--)
            {
                t = myarray[i];
                myarray[i] = myarray[j];
                myarray[j] = t;
            }
            return myarray;

        }

        public int[] NewArray(int[] Source, int newValue, int Index)
        {
            {
                int[] newSource = new int[Source.Length + 1];
                for (int i = 0; i < newSource.Length; i++)
                {
                    if (i < Index)
                    {
                        newSource[i] = Source[i];
                    }
                    else if (i == Index)
                    {
                        newSource[i] = newValue;
                    }
                    else if (i > Index)
                    {
                        newSource[i] = Source[i - 1];
                    }
                }
                return newSource;
            }
        }
    }
}