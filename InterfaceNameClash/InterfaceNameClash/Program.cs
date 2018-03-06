using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceNameClash
{
    public interface IDrawToForm
    {
        void Draw();
    }
    public interface IDrawToMemory
    {
        void Draw();
    }
    public interface IDrawToPrinter
    {
        void Draw();
    }
    class Program
    {

        static void Main(string[] args)
        {
            Console.WriteLine("***** Fun with Interface Name Clashes *****\n");
            Octagon oct = new Octagon();
            IDrawToForm itfForm = (IDrawToForm)oct;
            itfForm.Draw();

            ((IDrawToPrinter)oct).Draw();

            if (oct is IDrawToMemory)
                ((IDrawToMemory)oct).Draw();

            /*IDrawToPrinter itfPriner = (IDrawToPrinter)oct;
            itfPriner.Draw();

            IDrawToMemory itfMemory = (IDrawToMemory)oct;
            itfMemory.Draw();*/

            Console.ReadLine();
        }
      

   }
}
