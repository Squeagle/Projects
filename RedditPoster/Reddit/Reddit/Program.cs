using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Reddit;
using RedditSharp;
using System.Data.Common;

namespace Reddit
{
    class Program
    {
        static void Main(string[] args)
        {
            RedditSharp.Reddit reddit = new RedditSharp.Reddit();
            
            var user = reddit.GetUser("riseofbacon");

            var posts = user.GetPosts(RedditSharp.Things.Sort.Top).Where(p => p.SubredditName == "DestinyTheGame").Take(3);

            foreach (var post in posts)
            {
                Console.WriteLine(post.Title);
            }

            Console.ReadLine();
        }
    }
}
