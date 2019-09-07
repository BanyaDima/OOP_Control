using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CustomList;

namespace OOP_Control
{
    class Program
    {
        static void Main(string[] args)
        {
           

            string text = @"Text:file.txt(6B);Some string content
Image:img.bmp(19MB);1920х1080
Text:data.txt(12B);Another string
Text:data1.txt(7B);Yet another string
Movie:logan.2017.mkv(19GB);1920х1080;2h12m";

            List result = new List();
            string[] files = text.Split(new string[] { Environment.NewLine }, StringSplitOptions.RemoveEmptyEntries);

            for (int i = 0; i < files.Length; i++)
            {
                string[] split = files[i].Split(':');
                string fileType = split[0].ToLower();
                switch(fileType)
                {
                    case "text":
                        Text textFile = new Text();
                        textFile.Parse(split[1]);
                        result.Add(textFile);
                        break;
                    case "image":
                        Images imagesFile = new Images();
                        imagesFile.Parse(split[1]);
                        result.Add(imagesFile);
                        break;
                    case "movie":
                        Movies moviesFile = new Movies();
                        moviesFile.Parse(split[1]);
                        result.Add(moviesFile);
                        break;
                    default:
                        break;
                }
            }
        }

    }
}
