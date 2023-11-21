using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FacebookWrapper.ObjectModel;
using FacebookWrapper;

namespace LogicUnit
{
    public class PostsSorter
    {
        public IPostComparer PostComparer { get; set; }

        public PostsSorter(IPostComparer i_PostComparer)
        {
            PostComparer = i_PostComparer;
        }

        public void Sort(List<Post> io_PostsList)
        {
            for (int g = io_PostsList.Count / 2; g > 0; g /= 2)
            {
                for (int i = g; i < io_PostsList.Count; i++)
                {
                    for (int j = i - g; j >= 0; j -= g)
                    {
                        if (PostComparer.ShouldSwap(io_PostsList[j], io_PostsList[j + g]))
                        {                        
                            doSwap(io_PostsList, j, j + g);
                        }
                    }
                }
            }
        }

        private void doSwap(List<Post> io_PostsList, int i_Index1, int i_Index2)
        {
            Post temp = io_PostsList[i_Index1];

            io_PostsList[i_Index1] = io_PostsList[i_Index2];
            io_PostsList[i_Index2] = temp;
        }
    }
}