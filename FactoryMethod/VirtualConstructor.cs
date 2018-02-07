using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod
{
    public interface Creator
    {
        Figure FactoryMethod();
    }

    class TFigureCreator : Creator
    {
        public Figure FactoryMethod()
        {
            return new TFigure();
        }
    }
    class ZFigureCreator : Creator
    {
        public Figure FactoryMethod()
        {
            return new ZFigure();
        }
    }
    class SFigureCreator : Creator
    {
        public Figure FactoryMethod()
        {
            return new SFigure();
        }
    }
    class JFigureCreator : Creator
    {
        public Figure FactoryMethod()
        {
            return new JFigure();
        }
    }
    class LFigureCreator : Creator
    {
        public Figure FactoryMethod()
        {
            return new LFigure();
        }
    }
    class IFigureCreator : Creator
    {
        public Figure FactoryMethod()
        {
            return new IFigure();
        }
    }
    class OFigureCreator : Creator
    {
        public Figure FactoryMethod()
        {
            return new OFigure();
        }
    }
}
