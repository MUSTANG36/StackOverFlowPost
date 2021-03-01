using System;
using System.Collections.Generic;
using System.Text;

namespace StackOverFlowPost
{
    class Post
    {
        public int id;
        public string title { set;  get; }

        public string description { set;  get; }

        //date and time
        public DateTime TimeDateCreated { private set;  get;  }
        
        public int totalVotes { private set; get;  }

        public Post(int id, string title, string description) {

            this.id = id;
            this.title = title;
            this.description = description;

            TimeDateCreated = DateTime.UtcNow;

            this.totalVotes = 0;

        }

       
        
    }
}
