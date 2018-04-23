using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppInterFace練習
{
    class Program
    {
        public interface G水果
        {
            string 蘋果(string 切片);
            string 香蕉();
            string 西瓜(int 數量);
            string 鳳梨();
        }

        public class t特產 : G水果
        {
            public string 蘋果(string 切片)
            {
                Console.WriteLine("好吃的水果" + 切片);
                return "新鮮又健康";
            }

            public string 香蕉()
            {
                Console.WriteLine("幫助消化");
                return "神物";
            }

            public string 西瓜(int 數量)
            {
                Console.WriteLine("夏天必吃"+ 數量);
                return "清涼";
            }

            public string 鳳梨()
            {
                Console.WriteLine("刺激腸胃蠕動");
                return "我愛水果";
            }

            public string  水果總動員(string 必吃)
            {
                return "今天吃了嗎?" + 必吃;
            }
        }

        static void Main(string[] args)
        {
            
        }
    }
}
