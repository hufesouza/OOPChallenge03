using System;

namespace OOPChallenge03
{
    internal class PhotoBookTest
    {
        // testing the logic of the code
        static void Main(string[] args)
        {
            PhotoBook a = new PhotoBook();
            Console.WriteLine(a.GetNumberPages());

            PhotoBook b = new PhotoBook(25);
            Console.WriteLine(b.GetNumberPages());

            BigPhotoBook c = new BigPhotoBook();
            Console.WriteLine(c.GetNumberPages());
        }
    }
}
