using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laba1_Object_
{
    class ObjectModel_MySystem_
    {
        List<BaseBlock> blocks_WaterLvL;
        List<BaseBlock> gainBlocks_WaterLvL;
        List<BaseBlock> blocks_Conc;
        List<BaseBlock> gainBlocks_Conc;

        private double dt;
        private double input1;
        private double input2;
        private double input3;
        public double Time { get;set;}
        public double Input1 {
            get
            {

                return input1;
            }

            set
            {
                var y = value < 0f ? 0f : value;
                input1 = y + input2 - input3 > 50f ? 50f : y;
            }
        }
        public double Input2 {
            get
            {

                return input2;
            }

            set
            {
                var y = value < 0f ? 0f : value;
                input2 = y + input1 - input3 > 50f ? 50f : y;
            }
        }
        public double Input3
        {
            get
            {
                return input3;
            }

            set
            {
                var y = value < 0f ? 0f : value;
                input3 = -y + input1 + input2 > 50f ? 50f : y;
            }
        }
        public double Output1 { get; set; }
        public double Output2 { get; set; }

        public ObjectModel_MySystem_(double dt)
        {
            blocks_WaterLvL = new List<BaseBlock>();
            blocks_WaterLvL.Add(new GainBlock(1));
            blocks_WaterLvL.Add(new AperiodicBlock(dt, 5.1648));
            blocks_WaterLvL.Add(new Noise(1));

            gainBlocks_WaterLvL = new List<BaseBlock>();
            gainBlocks_WaterLvL.Add(new GainBlock(2));
            gainBlocks_WaterLvL.Add(new GainBlock(1));
            gainBlocks_WaterLvL.Add(new GainBlock(3));
            ///
            blocks_Conc = new List<BaseBlock>();
            blocks_Conc.Add(new GainBlock(1));
            blocks_Conc.Add(new AperiodicBlock(dt, 3));
            blocks_Conc.Add(new Noise(0.5));

            gainBlocks_Conc = new List<BaseBlock>();
            gainBlocks_Conc.Add(new GainBlock(2));
            gainBlocks_Conc.Add(new GainBlock(1));
            gainBlocks_Conc.Add(new GainBlock(3));

        }
        public double GetValueWaterLvL()
        {
            double u = 0;
            u = gainBlocks_WaterLvL[0].Transfer(Input1) + gainBlocks_WaterLvL[1].Transfer(Input2) - gainBlocks_WaterLvL[2].Transfer(Input3);
            var y = u - Output1;
            foreach (var b in blocks_WaterLvL)
            {
                y = b.Transfer(y);
            }
            Time += dt;
            Output1 = y;
            return y;

        }
        public double GetValueConc()
        {

            return 0;
        }
    }
}
