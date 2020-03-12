using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laba1_Object_
{
    public abstract class BaseBlock // базовое звено
    {
        public abstract double Transfer(double x);
    }

    public class GainBlock:BaseBlock // пропорциональное звено
    {
        public double Gain { get; set; }

        public GainBlock(double gain)
        {
            this.Gain = gain;
        }

        public override double Transfer(double x)
        {
            return this.Gain*x;
        }
    }

    public class IntegralBlock : BaseBlock // интегральное звено
    {
        public double dt { get; set; }
        private double i1;
        private double x1;

        public IntegralBlock(double dt)
        {
            this.dt = dt;
        }

        public override double Transfer(double x)
        {
            i1 = i1 + dt * (x + x1) / 2;
            x1 = x;
            return i1;
        }
    }

    public class AperiodicBlock: BaseBlock //аппериодическое звено
    {
        public double T { get; set; }
        public double dt { get; set; }
        private double y1;

        public AperiodicBlock(double dt, double t)
        {
            this.dt = dt;
            this.T = t;
        }

        public override double Transfer(double x)
        {
            y1 = (x*dt+T*y1) / (T + dt);
            return y1;
        }
    }

    public class DelayBlock : BaseBlock //звено запаздывания
    {
        public double time { get; set; }
        public double dt { get; set; }
        private int cnt;
        private Queue<double> buff;

        public DelayBlock(double time, double dt)
        {
            this.time = time;
            this.dt = dt;
            cnt = (int)(time / dt);
            buff = new Queue<double>();
        }

        public override double Transfer(double x)
        {
            buff.Enqueue(x);
            if(buff.Count < cnt)
            {
                return 0;
            }
            else
            {
                return buff.Dequeue();
            }
        }
    }

    public class Noise : BaseBlock //Шум
    {
        private double noise { get; set; }
        private Random rand;

        public Noise(double noise)
        {
            this.noise = noise;
            rand = new Random();
        }
        public override double Transfer(double x)
        {
            var nn = x * noise / 100;
            return x + 2 * nn * rand.NextDouble()-nn;
        }
    }
    public class LimitBlock : BaseBlock
    {
        public double MinValue { get; set; }
        public double MaxValue { get; set; }
        public LimitBlock(double min ,double max)
        {
            MaxValue = max;
            MinValue = min;
        }

        public override double Transfer(double x)
        {
            var y = x < MinValue ? MinValue : x;
            return y > MaxValue ? MaxValue : y;
        }
    }
}
