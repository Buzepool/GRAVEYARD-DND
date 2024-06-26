using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cemitério_DND
{
    public class Character
    {
       

        public string Name { get; private set; }

        public string Class { get; private set; }   

        public int Level { get; private set; }

        public Character(string name, string @class, string level)
        {
            //Jogar mensagem caso não esteja correto
            if (string.IsNullOrEmpty(name))
            {
                throw new ArgumentNullException("Name is a required field ");
            }
            if (string.IsNullOrEmpty(level))
            {
                throw new ArgumentNullException("Level is a required field ");
            }
            if (string.IsNullOrEmpty(@class))
            {
                throw new ArgumentNullException("Class is a required field ");
            }

            Name = name;
            Class = @class;
            Level = int.Parse(level);
        }
    }
}
