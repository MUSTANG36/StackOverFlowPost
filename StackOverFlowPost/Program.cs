using System;
using System.Collections.Generic;

namespace StackOverFlowPost
{
    class Program
    {
        static void Main(string[] args)
        {

            var postnumber = new List<Post>();
            var id = 1;
            var voteCount = 0;

            while (true)
            {
                Console.WriteLine("1-Create a post: 2-Read post- 3-Quit");
                var inputNum = Convert.ToInt32(Console.ReadLine());


                if (inputNum == 1)
                {
                    Console.WriteLine("Enter Title:");
                    var inputTitle = Console.ReadLine();

                    Console.WriteLine("Enter Description:");
                    var inputDes = Console.ReadLine();

                    postnumber.Add(new Post(id, inputTitle, inputDes));
                    id += 1;




                }
                else if (inputNum == 2)
                {
                    for (var i = 0; i < postnumber.Count; i++)
                    {

                        Console.WriteLine(@"Post Id: {0} " + "\n" + "Title: {1}" +
                            "\n" + "Description: {2}" + "\n" + "Date Created: {3}", postnumber[i].id, postnumber[i].title, postnumber[i].description, postnumber[i].TimeDateCreated);
                        Console.WriteLine(@"Votes: {0}", postnumber[i].totalVotes);


                        Console.WriteLine("Does this post get a vote: Up or Down ");
                        var input = Console.ReadLine().ToLower();


                        if (input == "up")
                        {
                            // need to pass vote to total votes

                            voteCount += 1;
                            //postnumber[i].totalVotes(voteCount);


                        }
                        else if (input == "down")
                        {
                            //problem here, its reseting the totalVotes current value 0 
                            voteCount -= 1;
                            voteCount = postnumber[i].totalVotes;
                        }
                        else
                        {
                            Console.WriteLine("That was not a valid input");
                        }





                    }

                }

                else if(inputNum == 3){
                    Environment.Exit(0);
                }
            }

        }
    }
}
