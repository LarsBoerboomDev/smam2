using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmamForms
{
    class Hint
    {
        private string id;
        private string name;
        private string body;

        public string Id { get => id; set => id = value; }
        public string Name { get => name; set => name = value; }
        public string Body { get => body; set => body = value; }
    }
}
