using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Store
{
    static class Repository
    {
        static public BindingList<Option> Opt { get; set; }
        static public BindingList<Phone> Phones { get; set; }

        static Repository()
        {
            Opt = new BindingList<Option>
            {new Option() { Name = "WiFi" } ,
             new Option() { Name = "SMS" },
            new Option() { Name = "GPS" },
            new Option() { Name = "MMS" },
            new Option() { Name = "TV" },
            new Option() { Name = "MultiTouch" },
            new Option() { Name = "2 Sim" }
            };
            Phones = new BindingList<Phone>
            {new Phone() {Model="Sony", OS="Android", CPU="Mediatek MT6755", Price=739, MyImage = new Bitmap("Sony.jpeg"), Options =new BindingList<Option>
            {  Opt[1],Opt[2],Opt[4],Opt[3]} },
            new Phone() {Model="iPhone 7", OS="Apple iOS", CPU="A10 Fusion", Price=1799, MyImage = new Bitmap("Iphone.jpeg"), Options =new BindingList<Option>
            {  Opt[1],Opt[2],Opt[4],Opt[3]} },
            new Phone() {Model="Huawei P9", OS="Android", CPU="HiSilicon Kirin 955", Price=1050, MyImage = new Bitmap("Huawei.jpg"), Options =new BindingList<Option>
            {  Opt[1],Opt[2],Opt[4],Opt[3], Opt[5],Opt[6]} },
            new Phone() {Model="Lenovo P70-A", OS="Android", CPU="Mediatek MT6752", Price=397, MyImage = new Bitmap("Lenovo.jpeg"), Options =new BindingList<Option>
            {  Opt[1],Opt[2],Opt[4],Opt[3], Opt[6]} },
            };


        }


    }
}