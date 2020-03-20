using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventExample
{

    //声明一个委托类型，定义事件处理函数的格式 
    public delegate void Tick(object sender,Clock args);

    public class Clock
    {
        public int hour { get; set; }
        public int minute { get; set; }
        public int second { get; set; }
        public static int alarmhour = 0;
        public static int alarmminute = 0;
        public static int alarmsecond =58;
        public event Tick tick;
        public event Tick alarm;
        public Clock() { }
        public Clock(int x,int y, int z)
        {
            this.hour = x;
            this.minute = y;
            this.second = z;
        }
        public void Start(int x, int y,int z)
        {
            Console.WriteLine("开始计时，初始时间为：" +x+ ":"+y+":"+z);
            
            Clock args = new Clock()
            {
                hour = x,   
                minute = y,
                second = z
            };
            while (true)
            {   
                alarm(this, args);
                tick(this, args);
            }
        }
    }

    public class Form
    {
        public static int x, y, z;
        public Clock clock = new Clock(x,y,z);

        public Form(int x, int y,int z)
        {
            Form.x= x;
            Form.y = y;
            Form.z = z;
            clock.tick += Btn_tick;
            clock.alarm += Btn_alarm;

        }
        void Btn_tick(object sender, Clock clock)
        {
                clock.second += 1;
                if (clock.second == 61)
                {
                    clock.second = 0;
                    clock.minute += 1;
                }
                if(clock.minute==61)
                {
                    clock.minute = 0;
                    clock.hour += 1;
                }
                System.Threading.Thread.Sleep(1000);
                Console.WriteLine("现在的时间为"+clock.hour+":"+clock.minute+":"+clock.second);
            
        }

        void Btn_alarm(object sender, Clock clock)
        {
        
            if (clock.hour == Clock.alarmhour && clock.minute == Clock.alarmminute && clock.second == Clock.alarmsecond)
            {
                    Console.WriteLine("设定的时间到了，闹钟响了");
            }
            
        }
    }

    class Program
    {
        static void Main(string[] args)
        {

            Form form1 = new Form(0,0,55);
            int x, y, z = 0;
            Console.WriteLine("请设定时钟,初始闹钟设定为0：0；58");
            Console.WriteLine("小时：");
            string a = Console.ReadLine();
            x = Int32.Parse(a);
            Console.WriteLine("分钟：");
            string b = Console.ReadLine();
            y = Int32.Parse(b);
            Console.WriteLine("秒钟");
            string c = Console.ReadLine();
            z = Int32.Parse(c);
            Console.WriteLine("启动时钟请输入1");
            string key = Console.ReadLine();
            if (key == "1")
            {
                form1.clock.Start(x,y,z);
            }
            Console.ReadKey();
        }
    }
       






}
