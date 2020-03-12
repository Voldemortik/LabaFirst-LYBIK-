using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laba1_Object_
{
    class ObjectModel
    {
        List<BaseBlock> blocks;
        private double dt;
        public double Time { get; set; }
        public double Input { get; set; }
        public double Output { get; set; }
        
        public ObjectModel(double dt)
        {
           
        }
        public double GetValue()
        {
            //var y = Input;
            var y = Input;
            foreach (var b in blocks)
            {
                y = b.Transfer(y);
            }
            Time += dt;
            Output = y;
            return y;
            
        }


    }
}
