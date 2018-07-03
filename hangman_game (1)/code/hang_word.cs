using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hangman_game
{
    class hang_word
    {
      private  string name;
      private string category;
       
        public string Name
        {
            get { return name; }
            set { name = value;}
        }
        public string Category
        {
            get { return category; }
            set { category = value; }
        }
      public hang_word()
        {
            name = "";
            category = "";
        }
       public hang_word(string name,string category)
        {
            this.name = name;
            this.category = category;
        }

        
        public List<int> search(char c)
        {
            List<int> postions = new List<int>();

            for(int i=0; i<name.Length;i++)
            {
                if (name[i] == c)
                    postions.Add(i);

            }
            return postions;
        }
        public string hide_word()
        {
            string templable = "";
            for (int i = 0; i < name.Length; i++)
            {
                if (name[i] != ' ')
                {
                    templable += '-';
                }
                else
                    templable += name[i];
            }
            return templable;
        }
        public bool check_char(char c)
        {

            if (name.Contains(c))
                return true;
            else
                return false;
        }

        public string word_when_click(char c,string lab)
        {
            List<int> pos = search(c);
            StringBuilder sb = new StringBuilder(lab);

            if (pos != null)
            {
                for (int i = 0; i < pos.Count; i++)
                {
                    sb[pos[i]] = c;
                }
            }
            return sb.ToString();
        }


    }
}
    