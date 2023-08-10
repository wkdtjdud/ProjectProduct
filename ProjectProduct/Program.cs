using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjectProduct
{
    internal class Program
    {
       static private List<Product> input = new List<Product>()
        {
            new Product() { Date = 1, Menu = "스파게티"},
            new Product() { Date = 2, Menu = "순두부찌개"},
            new Product() { Date = 3, Menu = "토마토 바질 파스타"},
            new Product() { Date = 4, Menu = "짜장면"},
            new Product() { Date = 5, Menu = "치킨"},
            new Product() { Date = 6, Menu = "라면"},
            new Product() { Date = 7, Menu = "닭고기 엔칠라다"},
            new Product() { Date = 8, Menu = "김치볶음밥"},
            new Product() { Date = 9, Menu = "간장게장"},
            new Product() { Date = 10, Menu = "비빔밥"},
            new Product() { Date = 11, Menu = "불고기"},
            new Product() { Date = 12, Menu = "떡볶이"},
            new Product() { Date = 13, Menu = "치킨 알프레도 파스타"},
            new Product() { Date = 14, Menu = "돈까스 카레라이스"},
            new Product() { Date = 15, Menu = "김밥"},
            new Product() { Date = 16, Menu = "감자탕"},
            new Product() { Date = 17, Menu = "해물파전"},
            new Product() { Date = 18, Menu = "크림 소스 연어"},
            new Product() { Date = 19, Menu = "계란찜"},
            new Product() { Date = 20, Menu = "냉면"},
            new Product() { Date = 21, Menu = "춘천닭갈비"},
            new Product() { Date = 22, Menu = "설렁탕"},
            new Product() { Date = 23, Menu = "떡국"},
            new Product() { Date = 24, Menu = "빙수"},
            new Product() { Date = 25, Menu = "삼겹살"},
            new Product() { Date = 26, Menu = "로스트 치킨과 감자"},
            new Product() { Date = 27, Menu = "갈비"},
            new Product() { Date = 28, Menu = "마르게리따 피자"},
            new Product() { Date = 29, Menu = "삼계탕"},
            new Product() { Date = 30, Menu = "모듬 초밥"},
            new Product() { Date = 31, Menu = "소고기 스테이크"},


        };



        static void Main(string[] args)
        {
           var output = from item in input
                     
                       orderby item.Date descending
                       select item;
            foreach (var item in output)
            {
               Console.WriteLine(item);


            }

        }
    }
}
