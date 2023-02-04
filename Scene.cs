using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Pt2pt
{
    public class Scene
    {
        public List<Figure> Figures;

        //Lista para guardar figuras para reproducir animación
        public List<Figure> RFigures;

        public Scene()
        {
            Figures = new List<Figure>();
            RFigures = new List<Figure>();
        }
    
    }
}
