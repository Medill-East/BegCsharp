/*
迭代器实现思路

添加一个 Primes 类
using collection
创建公有类 Primes
创建私有长整型变量 min max
初始化 Primes : this (2,100){}
实现一个参数为(long minimum, long maximum)的公有类 Primes
    如果最小值<2 则最小值为2
    否则将 minimum 赋值给 min
    将 maximum 赋值给 max
实现一个公有的 IEnumerator 类方法 GetEnumerator()
    进行第一层循环 
        先将可能的长整型素数赋值为 min 如果可能的素数比最大值小则++
            判断 是素数为真
            然后进行第二层循环
                先假设公约数为2 如果公约数 <= （long）Math.Floor(Math.Sqrt(possiblePrime)) 则++
                    设定长整型变量 remainderAfterDivision 为 可能的素数对可能的公约数取余
                    如果余数为 0 
                        判断 不是素数
                        break
    如果 是素数
        yield return 可能的素数

修改program
创建 Primes 类变量 primeFrom2to1000 = new Primes(2,1000)
利用 foreach 进行迭代输出
*/






using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace Ch11Ex03
{
    class Program
    {
        static void Main(string[] args)
        {
            Primes primeFrom2to1000 = new Primes(2, 1000);

            foreach (long i in primeFrom2to1000)
            {
                WriteLine($"{i}");
            }
            ReadKey();
        }
    }
}
