using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Geometría
{
  class Rectangulo
  {
    private float area;
    private float perimetro;
    private Punto Vertice1;
    private Punto Vertice2;
    private Punto Vertice3;
    private Punto Vertice4;


    public Rectangulo(Punto Vertice1, Punto Vertice3)
    {
      this.Vertice1 = new Punto(Math.Abs(Vertice1.GetX()), Math.Abs(Vertice1.GetY()));
      this.Vertice3 = new Punto(Math.Abs(Vertice3.GetX()), Math.Abs(Vertice3.GetY()));
      this.Vertice2 = new Punto(Math.Abs(Vertice1.GetX()), Math.Abs(Vertice3.GetY()));
      this.Vertice4 = new Punto(Math.Abs(Vertice3.GetX()), Math.Abs(Vertice1.GetY()));

      float Base = Vertice4.GetX() - Vertice1.GetX();
      float Altura = Vertice1.GetY() - Vertice2.GetY();

      this.area = (Base * Altura);
      this.perimetro = (this.Area() * 2);
    }

    public float Area()
    {
      return this.area;
    }
    public float Perimetro()
    {
      return this.perimetro;
    }

  }
}
